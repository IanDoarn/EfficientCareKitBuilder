using EfficientCareLookUp.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfficientCareLookUp.Data
{
    public class LookUp
    {

        private Postgres postgres;
        private OracleDB oracle;

        public LookUp(Postgres postgres, OracleDB oracle)
        {
            this.postgres = postgres;
            this.oracle = oracle;
        }

        public bool CheckKitNumber(string s)
        {
            try
            {
                DataTable dt = postgres.execute(string.Format(
                    Properties.Settings.Default.EFFICIENT_CARE_KIT_VERIFY,
                    s
                    ));

                foreach (DataRow r in dt.Rows)
                    if (r[0].ToString() == s)
                        return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool CheckBundleNumber(string s)
        {
            try
            {
                DataTable dt = postgres.execute(string.Format(
                    Properties.Settings.Default.EFFICIENT_CARE_BUNDLE_NUMBER_VERIFY,
                    s
                    ));

                foreach (DataRow r in dt.Rows)
                    if (r[0].ToString() == s)
                        return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        private string warehouseString(int w)
        {
            switch ((Warehouse) w)
            {
                case Warehouse.WARSAW: return "'WARSAW'";
                case Warehouse.SOUTHAVEN: return "'SOUTHAVEN'";
                case Warehouse.NONE: return "'NONE AVAILABLE'";
                case Warehouse.ALL: return "'WARSAW', 'SOUTHAVEN', 'NONE AVAILABLE'";
                default: return "'WARSAW', 'SOUTHAVEN'";

            }
        }

        public DataTable SearchComponents(string kitNumber, int warehouse)
        {
            string q = string.Format(Properties.Settings.Default.EFFICIENT_CARE_COMPONENT_LOOKUP, kitNumber, warehouseString(warehouse));         
            
            return oracle.execute(q);  
        }

        public DataTable SearchKits(string bundleNumber)
        {
            string q = string.Format(Properties.Settings.Default.EFFICIENT_CARE_BUNDLE_BREAKOUT, bundleNumber);

            DataTable dt  = postgres.execute(q);

            DataTable bundleTable = new DataTable();
            bundleTable.Columns.Add("KIT_NUMBER", typeof(string));
            bundleTable.Columns.Add("VALID", typeof(int));
            bundleTable.Columns.Add("INVALID", typeof(int));


            foreach (DataRow row in dt.Rows)
            {
                string kNumber = row[0].ToString();

                DataTable kit = oracle.execute(string.Format(Properties.Settings.Default.EFFICIENT_CARE_KIT_SERIAL_LOOKUP, kNumber));
                
                foreach(DataRow krow in kit.Rows)
                    bundleTable.Rows.Add(krow[0].ToString(), krow[1], krow[2]);
            }

            return bundleTable;
        }

    }
}
