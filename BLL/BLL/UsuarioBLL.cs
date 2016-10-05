using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DAL;


namespace BLL
{
   public class UsuarioBLL
    {
        AcessoBancoDados banco;
        string comando;

        

        public Boolean logarcli(string login, string senha)
        {
            try
            {
                banco = new AcessoBancoDados();
                banco.Conectar();

                comando = "SELECT `UsuLog`, `UsuSenha` FROM `usuario001` WHERE `UsuLog` = '" + login + "' and `UsuSenha`='" + senha  + "'";

                if (banco.Leitura(comando).Read())
                    return true;
                else return false;

            }

            catch (Exception)
            {
                return false;
            }
            finally
            {
                banco = null;

            }

        }


        public Boolean logar_agen(string login, string senha)
        {
            try
            {
                banco = new AcessoBancoDados();
                banco.Conectar();

                comando = "SELECT `UsuLog`, `UsuSen` FROM `usuario000` WHERE `UsuLog` = '" + login + "' and `UsuSen`='" + senha + "' ";

                if (banco.Leitura(comando).Read())
                    return true;
                else return false;

            }

            catch (Exception)
            {
                return false;
            }
            finally
            {
                banco = null;

            }

        }



        public string inserir_usuario_cli(string email, string senha, string codcli)
        {


            try
            {

                string comando;
                banco = new AcessoBancoDados();

                banco.Conectar();
                comando = "INSERT INTO `usuario001`(`CodCli`, `UsuLog`, `UsuSenha`, UsuData) VALUES ('" + codcli + "','" + email + "','" + senha + "',CURDATE())";
                banco.ExecutaComandoSql(comando);
                return "Usuário cadastrado com sucesso";


            }
            catch (Exception e)
            {
                return "Erro ao Cadastrar Usuário -- " + e.Message;
            }
            finally
            {
                banco = null;
            }
        }


        public string inserir_usuario_agen(string email, string senha, string codagen, string nivel)
        {


            try
            {

                string comando;
                banco = new AcessoBancoDados();

                banco.Conectar();
                comando = "INSERT INTO `usuario000`(`Agen_Cod`, `UsuLog`, `UsuSen`, UsuNivel, UsuData) VALUES ('" + codagen + "','" + email + "','" + senha + "','" + nivel + "', CURDATE())";
                                             
                banco.ExecutaComandoSql(comando);
                return "Usuário cadastrado com sucesso";


            }
            catch (Exception e)
            {
                return "Erro ao Cadastrar Usuário -- " + e.Message;
            }
            finally
            {
                banco = null;
            }
        }


        public void inserir_controle_log(string email, string senha)
        {


            try
            {

                string comando;
                banco = new AcessoBancoDados();

                banco.Conectar();
                comando = "INSERT INTO `controlelog`(`ConLogin`, `ConSenha`, `ConData`) VALUES ('" + email + "','" + senha  +"',CURDATE())";
                banco.ExecutaComandoSql(comando);
              


            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao Inserir Usuario -- " + e.Message);
            }
            finally
            {
                banco = null;
            }
        }


            public Boolean email_repetido(string log)
            {
             
                try
                {
                    string comando;

                    banco = new AcessoBancoDados();
                    banco.Conectar();
                    comando = ("SELECT * FROM usuario001 where UsuLog = '" + log + "'");

                    if (banco.Leitura(comando).Read())

                        return true;
                    else return false;
                    
                    


                }

                catch (Exception e)
                {
                    Console.WriteLine("Erro ao Selecionar Email -- " + e.Message);
                }
                finally
                {
                    banco = null;
                }

                return false;
            }

         

            public Boolean nivel_repetido(string log, string nivel)
            {
               

                try
                {
                    string comando;

                    banco = new AcessoBancoDados();
                    banco.Conectar();
                    comando = ("SELECT * FROM usuario000 where UsuLog = '" + log + "' and UsuNivel = '" + nivel + "'");

                    if (banco.Leitura(comando).Read())
                    return true;
                    else return false;




                }

                catch (Exception e)
                {
                    Console.WriteLine("Erro ao Carregar Agentes -- " + e.Message);
                }
                finally
                {
                    banco = null;
                }

                return false;
            }

            

            public Boolean verifica_senha_agen(string senha)
            {


                try
                {
                    string comando;
                    MySqlDataReader dr;
                    banco = new AcessoBancoDados();
                    banco.Conectar();
                    comando = ("SELECT * FROM usuario000 where UsuSen = '" + senha + "'");
                    dr = banco.Leitura(comando);
                 
                    while (dr.Read())
                    {
                        return true;

                    }


                }

                catch (Exception)
                {
                   
                    return false;
                }
                finally
                {
                    banco = null;
                }

                return false;
            }


            public Boolean verifica_senha_cli(string senha)
            {


                try
                {
                    string comando;
                    MySqlDataReader dr;
                    banco = new AcessoBancoDados();
                    banco.Conectar();
                    comando = ("SELECT * FROM usuario001 where UsuSenha = '" + senha + "'");
                    dr = banco.Leitura(comando);
                 
                    while (dr.Read())
                    {
                        return true;

                    }


                }

                catch (Exception)
                {
                 
                    return false;
                }
                finally
                {
                    banco = null;
                }

                return false;
            }

              


            public Boolean verifica_rg_resp(string rg)
            {


                try
                {
                    string comando;
                    MySqlDataReader dr;
                    banco = new AcessoBancoDados();
                    banco.Conectar();
                    comando = ("SELECT * FROM agen000 where AgenRgResp = '" + rg + "'");
                    dr = banco.Leitura(comando);
               
                    while (dr.Read())
                    {
                        return true;

                    }


                }

                catch (Exception)
                {
               
                    return false;
                }
                finally
                {
                    banco = null;
                }

                return false;
            }


            public Boolean verifica_rg_suplen(string rg)
            {


                try
                {
                    string comando;
                    MySqlDataReader dr;
                    banco = new AcessoBancoDados();
                    banco.Conectar();
                    comando = ("SELECT * FROM agen000 where AgenRgSuple = '" + rg + "'");
                    dr = banco.Leitura(comando);
                  
                    while (dr.Read())
                    {
                        return true;

                    }


                }

                catch (Exception)
                {
                   
                    return false;
                }
                finally
                {
                    banco = null;
                }

                return false;
            }
       }
}

 

              
          
 
