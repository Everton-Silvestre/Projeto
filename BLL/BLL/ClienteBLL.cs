using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text;
using DAL;

namespace BLL
{
    public class ClienteBLL
    {

        AcessoBancoDados banco;

        public Boolean inserir(string nome, string rg, string cpf, string tel, string email, string cep, string endereco, string endnum, string bairro, string cid, string est, string ban, string favo, string agen, string contcor)
        {


            try
            {

                string comando;
                banco = new AcessoBancoDados();

                banco.Conectar();
                comando = "INSERT INTO `clientes000`(`CliNome`, `CliEnd`, `CliEndNro`, `CliTel`, `CliCpf`, `CliRg`, `CliCid`, `CliEst`, `CliEmail`, `CliCep`, `CliBairro`, `CliBan`, `CliFavo`, `CliAgen`, `CliCorren`) VALUES ('" + nome + "','" + endereco + "','" + Convert.ToInt64(endnum) + "','" + Convert.ToInt64(tel) + "','" + Convert.ToInt64(cpf) + "','" + Convert.ToInt64(rg) + "','" + cid + "','" + est + "','" + email + "','" + Convert.ToInt64(cep) + "','" + bairro + "','" + ban + "','" + favo + "','" + agen + "','" + contcor + "')";
                banco.ExecutaComandoSql(comando);
                return true;


            }
            catch (MySqlException e)
            {

                if (e.Number == 1062)
                {

                    return false;

                }
                else
                {

                    return false;

                }
                
               
            }
            finally
            {
                banco = null;
            }
        }

               

        public string selecionar_email_cli(string email)
        {
        
            try
            {
                string comando;
                MySqlDataReader dr;
                banco = new AcessoBancoDados();
                banco.Conectar();
                comando = ("SELECT CliCod FROM clientes000 where CliEmail = '" + email + "'");
                dr = banco.Leitura(comando);
           
                
                while (dr.Read())
                {
                    return dr.GetInt32(0).ToString();

                }
                    


            }

            catch (Exception e)
            {
                Console.WriteLine("Erro ao Carregar Email -- " + e.Message);
            }
            finally
            {
                banco = null;
            }

            return "";
        }

        public string selecionar_email_agen(string email)
        {
          
            try
            {
                string comando;
                MySqlDataReader dr;
                banco = new AcessoBancoDados();
                banco.Conectar();
                comando = ("SELECT AgenCod FROM agen000 where AgenEmail = '" + email + "'");
                dr = banco.Leitura(comando);
          
                while (dr.Read())
                {
                    return dr.GetInt32(0).ToString();

                }
                                   

            }

            catch (Exception e)
            {
                Console.WriteLine("Erro ao Carregar Email -- " + e.Message);
            }
            finally
            {
                banco = null;
            }

            return "";
        }



        public DataTable selecionar_cliente(string log)
        {
            DataTable dt = new DataTable();

            try
            {
                string comando;

                banco = new AcessoBancoDados();
                banco.Conectar();
                comando = ("SELECT * FROM clientes000 where CliCod=(SELECT CodCli from usuario001 where UsuLog = '" + log +"') ");
                dt = banco.Tabela_Dados(comando);


            }

            catch (Exception e)
            {
                Console.WriteLine("Erro ao Carregar Agentes -- " + e.Message);
            }
            finally
            {
                banco = null;
            }

            return dt;
        }


        public DataTable selecionar_cliente(string log, string senha)
        {
            DataTable dt = new DataTable();

            try
            {
                string comando;

                banco = new AcessoBancoDados();
                banco.Conectar();
                comando = ("SELECT UsuSenha from usuario001 where UsuLog = '" + log + "' and UsuSenha = '" + senha + "'");
                dt = banco.Tabela_Dados(comando);


            }

            catch (Exception e)
            {
                Console.WriteLine("Erro ao Carregar Cliente -- " + e.Message);
            }
            finally
            {
                banco = null;
            }

            return dt;
        }


        public MySqlDataReader leitura_cliente()
        {
      
            string comando = "";

            try
            {
                

                banco = new AcessoBancoDados();
                banco.Conectar();
                comando = ("SELECT * FROM clientes000");
           
                return banco.Leitura(comando);
                

            } 

            catch (Exception e)
            {
                Console.WriteLine("Erro ao Carregar Clientes -- " + e.Message);
            }
            finally
            {
                banco = null;
            }
          
            return banco.Leitura(comando);
        }

        public Boolean atualizar_cliente(int cod, string nome, string endereco,string endnum, string tel, string cpf, string rg,string cid,string est, string email, string cep,  string bairro,  string ban, string favo, string agen, string contcor,string senha)
        {
           
            try
            {

                string comando;
                banco = new AcessoBancoDados();

                banco.Conectar();
                comando = "UPDATE `clientes000` SET `CliNome`='" + nome + "',`CliEnd`= '" + endereco + "' ,`CliEndNro`='" + Convert.ToInt64(endnum) + "',`CliTel`='" + Convert.ToInt64(tel) + "',`CliCpf`='" + Convert.ToInt64(cpf) + "',`CliRg`='" + Convert.ToInt64(rg) + "',`CliCid`='" + cid + "',`CliEst`='" + est + "',`CliEmail`='" + email + "',`CliCep`='" + Convert.ToInt64(cep) + "',`CliBairro`='" + bairro + "',`CliBan`='" + ban + "',`CliFavo`='" + favo + "',`CliAgen`='" + agen + "',`CliCorren`='" + contcor + "' WHERE `CliCod` = '" + cod + "'";
                banco.ExecutaComandoSql(comando);
                banco.Conectar();
                comando = "UPDATE `usuario001` SET `UsuLog`='" + email + "',UsuSenha = '" + senha +"', `UsuData`= CURDATE() WHERE `CodCli` = '" + cod + "'";
                banco.ExecutaComandoSql(comando);
                return true;


            }
            catch (MySqlException e)
            {
                if (e.Number == 1062)
                {

                    return false;

                }
                else
                {

                    return false;

                }
            }
            finally
            {
                banco = null;
            }

        }


    }
}