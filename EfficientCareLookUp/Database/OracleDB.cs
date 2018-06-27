using EfficientCareLookUp.Config;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace EfficientCareLookUp.Database
{
    public class OracleDB : IDatabaseConnection
    {
        private OracleConnection connection = null;
        private OracleConfig oracleConfig;
        private string ConnectionString;
        private bool isConnected = false;

        public OracleConnection ConnectionObj { get { return connection; } set { this.connection = value; } }

        public bool IsConnected() { return isConnected; }

        public OracleDB(OracleConfig oracleConfig)
        {
            this.oracleConfig = oracleConfig;
            this.ConnectionString = this.oracleConfig.ConnectionString();
            connection = new OracleConnection(ConnectionString);
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
                isConnected = true;
            }
            catch (OracleException ex)
            {
                //string message = string.Format("{0}. ERROR CODE [{1}]", ex.Message, ex.ErrorCode);
                //throw ErrorHandler.Throw(ErrorType.NO_CONNECTION, message);
                throw ex;
            }
            catch (Exception ex)
            {
                //throw ErrorHandler.Throw(ErrorType.NO_CONNECTION, ex.Message);
                throw ex;
            }

        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
                isConnected = false;
            }
            catch (OracleException ex)
            {
                //string message = string.Format("{0}. ERROR CODE [{1}]", ex.Message, ex.ErrorCode);
                //throw ErrorHandler.Throw(ErrorType.NO_CONNECTION, message);
                throw ex;
            }
            catch (Exception ex)
            {
                //throw ErrorHandler.Throw(ErrorType.DEFAULT, ex.Message);
                throw ex;
            }
        }

        public bool TestConnection()
        {
            // Close connection incase it is already open
            if (isConnected)
            {
                CloseConnection();
            }

            // Test connection
            try
            {
                OpenConnection();
                CloseConnection();
                return true;
            }
            catch (OracleException ex)
            {
                //string message = string.Format("{0}. ERROR CODE [{1}]", ex.Message, ex.ErrorCode);
                //throw ErrorHandler.Throw(ErrorType.NO_CONNECTION, message);
                throw ex;
            }
            catch (Exception ex)
            {
                //throw ErrorHandler.Throw(ErrorType.NO_CONNECTION, ex.Message);
                throw ex;
            }
        }

        public DataTable execute(string query, bool ensureReturn = true)
        {
            if (!isConnected)
            {
                //throw ErrorHandler.Throw(ErrorType.NO_CONNECTION, "No connection to the database is currently made.");
                throw new Exception("No connection established");
            }

            try
            {
                DataTable dt = new DataTable();

                OracleCommand cmd = new OracleCommand(query);

                cmd.CommandType = CommandType.Text;

                cmd.Connection = connection;

                using (OracleDataAdapter adapter = new OracleDataAdapter())
                {
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                }

                if (ensureReturn)
                {
                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }

                    //throw ErrorHandler.Throw(ErrorType.NO_DATA_RETURNED_FROM_QUERY, string.Format("QUERY: [{0}]", query));
                    throw new Exception("No data returned from query");
                }
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }

                    return null;
                }
            }
            catch(OracleException ex)
            {
                //string message = string.Format("{0}. ERROR CODE [{1}]", ex.Message + " QUERY = " + query, ex.ErrorCode);
                //throw ErrorHandler.Throw(ErrorType.DATABASE_ERROR, message);
                throw ex;
            }
            catch (Exception ex)
            {
                //throw ErrorHandler.Throw(ErrorType.DATABASE_ERROR, ex.Message);
                throw ex;
            }
        }

    }
}
