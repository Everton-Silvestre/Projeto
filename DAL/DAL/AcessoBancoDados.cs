using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class AcessoBancoDados
    {
       
        
            private DataTable dados;
            private MySqlConnection conexão;
            private MySqlDataAdapter adaptador;
            private MySqlCommandBuilder construtor;



            public void Conectar()
            {
                if (conexão != null)
                    conexão.Close();

                string stringdeconexao = ("server=localhost;database=gta;uid=root;pwd=''");


                try
                {
                    conexão = new MySqlConnection(stringdeconexao);
                    conexão.Open();
                }
                catch (MySqlException e)
                {

                    throw new Exception(e.Message);
                }

            }

            public void ExecutaComandoSql(string query)
            {
                MySqlCommand comando = new MySqlCommand(query, conexão);
                comando.ExecuteNonQuery();
                conexão.Close();
            }

            public DataTable Tabela_Dados(string query)
            {
                dados = new DataTable();
                adaptador = new MySqlDataAdapter(query, conexão);
                construtor = new MySqlCommandBuilder(adaptador);
                adaptador.Fill(dados);
                return dados;
            }

           


            public MySqlDataReader Leitura(string query)
            {
                MySqlCommand comando = new MySqlCommand(query, conexão);
                MySqlDataReader ler = comando.ExecuteReader();
                //ler.Read();
                return ler;


            }



        }
    
}
