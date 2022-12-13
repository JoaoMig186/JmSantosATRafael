using Dapper;
using Microsoft.Data.SqlClient;

namespace JmSantosAT_Final_Rafael.Models
{
    public class ReadOnly
    {
        private string connectionString = "Server=tcp:jmserverdb.database.windows.net,1433;Initial Catalog = jmdatabase; Persist Security Info=False;User ID = jmsantos; Password=Lillgabi123; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
        
    public List<Amigo> GetAll()
        {
            var sql = @"SELECT A.AMIGOID,
                               A.AMIGONOME,
                               A.AMIGOSOBRENOME,
                               A.AMIGOTELEFONE,
                               A.AMIGOEMAIL,
                               A.PAISAMIGO,
                               A.ESTADOAMIGO,
                               A.IMAGEMAMIGO
                            FROM AMIGO A 
                       ";

            var result = new List<Amigo>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                result = sqlConnection.Query<Amigo>(sql).ToList();
                return result;
            }
        }

        public List<Pais> GetAllPaises()
        {
            var sql = @"SELECT P.PAISID,
                               P.PAISNOME,
                               P.PAISIMAGEM
                            FROM PAIS P 
                       ";

            var result = new List<Pais>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                result = sqlConnection.Query<Pais>(sql).ToList();
                return result;
            }
        }

        public List<Estado> GetAllEstados()
        {
            var sql = @"SELECT E.ESTADOSID,
                               E.ESTADOSNOME,
                               E.ESTADOSIMAGEM,
                               P.PAISID,
                               P.PAISNOME 
                        FROM ESTADO E
                        INNER JOIN PAIS P
                        ON E.PAISID = P.PAISID;
                       ";

            var result = new List<Estado>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                result = sqlConnection.Query<Estado>(sql).ToList();
                return result;
            }
        }
    }
}
