using System.Configuration;

namespace EbenezerSolution.Data.Connection
{
    public class MasterConnection
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ESConnectionString"].ToString();
    }
}
