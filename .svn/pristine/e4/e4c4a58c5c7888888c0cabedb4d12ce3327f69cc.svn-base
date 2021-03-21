using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PraticaWFA.Model
{
    public class Conexao
    {
        MySqlConnection conexao1 = null;

        string stringDeConexao = "Server=mysql.uhserver.com;Database=magiclink;Uid=devgti;pwd=projetopratica@5";


        public MySqlConnection openConnection()
        {
            conexao1 = new MySqlConnection(stringDeConexao);

            conexao1.Open();

            return conexao1;
        }
        public MySqlConnection closeConnection()
        {
            conexao1 = new MySqlConnection();

            conexao1.Close();

            return conexao1;
        }



    }

}
