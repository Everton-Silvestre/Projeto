using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{

    public class Voucher
    {
        AcessoBancoDados banco;
        string comando;

        public void inserir_voucher_cli(int cod, int PlanCod ,string dias, int QuantPe, string dataini, Boolean DadosAtu, decimal Valreal, decimal valdolar)
        {
            try
            {
                banco = new AcessoBancoDados();                                          
                banco.Conectar();
                comando = "INSERT INTO `voucher001`(`CliCod`, PlanCod , `VouDias`, `VouQuantPess`, `VouDataIni`, `VouDadosAtu`, VouValReal, VouValDolar) VALUES ('" + cod + "','" + PlanCod  +"','" + dias + "','" + QuantPe + "','" + dataini + "', '" + DadosAtu + "','" + Valreal.ToString().Replace(",", ".") + "','" + valdolar.ToString().Replace(",", ".") + "')";
                banco.ExecutaComandoSql(comando);               

            }

            catch (Exception e)
            {
                Console.WriteLine("Erro ao Inserir Voucher -- " + e.Message);
            }
            finally
            {
                banco = null;

            }

        }


        public void inserir_voucher_agen(int cod, int PlanCod, string dias, int QuantPe, string dataini, Boolean DadosAtu, decimal Valreal, decimal valdolar)
        {
            try
            {
                banco = new AcessoBancoDados();                                          
                banco.Conectar();
                comando = "INSERT INTO `voucher000`(`AgenCod`, PlanCod , `VouDias`, `VouQuantPess`, `VouDataIni`, `VouDadosAtu`, VouValReal, VouValDolar) VALUES ('" + cod + "','" + PlanCod + "','" + dias + "','" + QuantPe + "','" + dataini + "', '" + DadosAtu + "','" + Valreal.ToString().Replace(",", ".") + "','" + valdolar.ToString().Replace(",", ".") + "')";
                banco.ExecutaComandoSql(comando);               

            }

            catch (Exception e)
            {
                Console.WriteLine("Erro ao Inserir Voucher -- " + e.Message);
            }
            finally
            {
                banco = null;

            }

        }
                   
    
    }

}
