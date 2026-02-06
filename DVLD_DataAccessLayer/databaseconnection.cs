// Ensure you have the following NuGet package installed in your project:
// System.Data.SqlClient

namespace DVLD_DataAccessLayer
{
    public class databaseconnection
    {
        protected static readonly string _connectionString = "Data Source=.;Initial Catalog=DvldDataBase;Integrated Security=True;Trust Server Certificate=True";
    }

}
