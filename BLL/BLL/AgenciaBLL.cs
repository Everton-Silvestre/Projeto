using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DAL;


namespace BLL
{
    public class AgenciaBLL
    {
        AcessoBancoDados banco;
        string comando;
        public Boolean inserir(string RazaoSocial, string NomeFant, string cnpj, string cep, string endereco, string bairro, string cidade, string telefone, string estado, string email, string respcad, string agenbanco, string favor, string agennro, string contcor, string NomeResp, string RgResp, string NomeSuple, string RgSuple, int EndNum)
        {
            
            try
            {


                banco = new AcessoBancoDados();


                banco.Conectar();
                comando = "INSERT INTO `agen000`(`AgenRazSoc`, `AgenNomFant`, `AgenCnpj`, `AgenEnd`, `AgenBairro`, `AgenCid`, `AgenTel`, `AgenRespCad`, `AgenCep`, `AgenEst`, `AgenEmail`, `AgenBan`, `AgenFavo`, `AgenNro`, `AgenContCor`,`AgenNomResp`, `AgenRgResp`, `AgenNomSuple`, `AgenRgSuple`, `AgenEndNum`) VALUES ('" + RazaoSocial + "','" + NomeFant + "','" + Convert.ToInt64(cnpj) + "','" + endereco + "','" + bairro + "','" + cidade + "','" + telefone + "','" + respcad + "','" + Convert.ToInt64(cep) + "','" + estado + "','" + email + "','" + agenbanco + "','" + favor + "','" + agennro + "','" + contcor + "','" + NomeResp + "','" + RgResp + "','" + NomeSuple + "','" + RgSuple + "','" + EndNum + "')";
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




        public DataTable selecionar_agencia()
        {
            DataTable dt = new DataTable();

            try
            {
                string comando;

                banco = new AcessoBancoDados();
                banco.Conectar();
                comando = ("SELECT * FROM Agen000");
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

       
        public DataTable selecionar_agencia(string login, string senha)
        {
            DataTable dt = new DataTable();

            try
            {
                string comando;

                banco = new AcessoBancoDados();
                banco.Conectar();
                comando = ("SELECT * FROM Agen000 where AgenCod=(SELECT Agen_Cod from usuario000 where UsuLog = '" + login + "' and UsuSen = '" + senha +"')");
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


        public DataTable selecionar_senha(string login, string senha)
        {
            DataTable dt = new DataTable();

            try
            {
                string comando;

                banco = new AcessoBancoDados();
                banco.Conectar();
                comando = ("SELECT UsuSen from usuario000 where UsuLog = '" + login + "' and UsuSen = '" + senha + "'");
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


        public string selecionar_email(string email,string agencia)
        {
                      

            try
            {
                string comando;
                MySqlDataReader dr;
                banco = new AcessoBancoDados();
                banco.Conectar();
                comando = ("SELECT AgenCod FROM agen000 where AgenEmail = '" + email + "' and AgenNomFant = '" + agencia + "'");
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


        public Boolean atualizar_agencia(int cod , string RazaoSocial, string NomeFant, string cnpj, string cep, string endereco, string bairro, string cidade, string telefone, string estado, string email, string respcad, string agenbanco, string favor, string agennro, string contcor, string NomeResp, string RgResp, string NomeSuple, string RgSuple, string senha_nova,string senha_antiga, int EndNum)
        {

            try
            {

                string comando;
                banco = new AcessoBancoDados();

                banco.Conectar();
                comando = "UPDATE `agen000` SET `AgenRazSoc`='" + RazaoSocial + "',`AgenNomFant`='" + NomeFant + "',`AgenCnpj`='" + Convert.ToInt64(cnpj) + "',`AgenEnd`='" + endereco + "',`AgenBairro`='" + bairro + "',`AgenCid`='" + cidade + "',`AgenTel`='" + Convert.ToInt64(telefone) + "',`AgenRespCad`='" + respcad + "',`AgenCep`='" + Convert.ToInt64(cep) + "',`AgenEst`='" + estado + "',`AgenEmail`='" + email + "',`AgenBan`='" + agenbanco + "',`AgenFavo`='" + favor + "',`AgenNro`='" + agennro + "',`AgenContCor`='" + contcor + "',`AgenNomResp`='" + NomeResp + "',`AgenRgResp`='" + RgResp + "',`AgenNomSuple`='" + NomeSuple + "',`AgenRgSuple`='" + RgSuple + "',`AgenEndNum`='" + EndNum + "' WHERE `AgenCod` = '" + cod + "'";
                banco.ExecutaComandoSql(comando);

                banco.Conectar();
                comando = "UPDATE `usuario000` SET UsuLog = '" + email + "', `UsuData`= CURDATE() WHERE `Agen_Cod` = '" + cod + "'";
                banco.ExecutaComandoSql(comando);

                banco.Conectar();
                comando = "UPDATE `usuario000` SET UsuSen = '" + senha_nova  +"' WHERE `UsuSen` = '" + senha_antiga + "'";
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
