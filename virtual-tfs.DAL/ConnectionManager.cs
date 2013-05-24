using System;
using System.Data.SqlClient;

namespace VirtualTFS.DAL
{
    public class ConnectionManager
    {
        static public bool CheckDatabases()
        {
            bool result = false;

            try
            {
                using (var entity = new VirtualTFS.DAL.Entities(Define.ENTITYCONNSTRING))
                {
                    result = entity.DatabaseExists();
                }
            }
            catch (SqlException)
            {
                //throw;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}
