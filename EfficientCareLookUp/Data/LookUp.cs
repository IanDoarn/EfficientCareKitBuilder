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
                    "SELECT kit_product_number FROM doarni.effcient_care_kit_numbers WHERE kit_product_number = '{0}'",
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
            switch (w)
            {
                case 0: return "'WARSAW'";
                case 1: return "'SOUTHAVEN'";
                case 2: return "'NONE AVAILABLE'";
                case 3: return "'WARSAW', 'SOUTHAVEN'";
                default: return "'WARSAW', 'SOUTHAVEN', 'NONE AVAILABLE'";

            }
        }

        public DataTable Search(string kitNumber, int warehouse)
        {
            string q = string.Format(Properties.Settings.Default.EFFICIENT_CARE_QUERY, kitNumber, warehouseString(warehouse));         
            
            return oracle.execute(q);  
        }
    }
}
