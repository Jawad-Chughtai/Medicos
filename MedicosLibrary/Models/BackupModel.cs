using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    public class BackupModel
    {
        public string Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedAt { get; set; }


        public void CreateBackup(string filePath)
        {
            Id = DateTime.Now.ToString("yyMMddhhmmss");
            FileName = DateTime.Now.ToString("yyyy-MM-dd") + ".bak";
            FilePath = filePath + "\\" + FileName;
            CreatedAt = DateTime.Now;


            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand(@"Backup Database dbMedicos to Disk = '" + FilePath +"' WITH INIT", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }

            catch
            {
                throw;
            }

            finally
            {
                con.Close();
            }

        }

        public void RestoreDatabase(string restorePath)
        {
            try
            {
                // read connectionstring from config file
                var connectionString = "Data Source=.;Initial Catalog=dbMedicos;Integrated Security=True";

                // read backup folder from config file ("C:/temp/")

                //var connectionString = "Server=DESKTOP-D3LVOOI\\MSSQLSERVER01;  Trusted_Connection=True; MultipleActiveResultSets=true;";
                var sqlConStrBuilder = new SqlConnectionStringBuilder(connectionString);
                var dbOfflineQuery = String.Format("use master alter database {0} set offline with rollback immediate;",
                        sqlConStrBuilder.InitialCatalog);

                var query = String.Format("Restore DATABASE {0} From DISK='{1}' WITH REPLACE",
                   sqlConStrBuilder.InitialCatalog, restorePath);

                var dbOnlineQuery = String.Format("use master alter database {0} set online with rollback immediate;",
                      sqlConStrBuilder.InitialCatalog);

                using (var connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
                {
                    var mainQuery = dbOfflineQuery + " " + query + " " + dbOnlineQuery;
                    using (var command = new SqlCommand(mainQuery, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                }

            }
            catch
            {
                throw;
            }
        }
    }
}
