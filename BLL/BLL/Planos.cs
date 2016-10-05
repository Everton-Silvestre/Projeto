using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class Planos
    {
        public DataTable selecionar_planos(string plano, string categoria)
        {
          
            DataTable dt = new DataTable();
            AcessoBancoDados banco;

            try
            {
                string comando;

                banco = new AcessoBancoDados();
                banco.Conectar();
                comando = ("SELECT `AtriDescri`, AtriValor FROM `atributos` WHERE PlanCod = (SELECT PlanCod FROM `planos000` WHERE PlanNome = '"+ plano +"' AND PlanCate = '" + categoria + "')");
                                  
                dt = banco.Tabela_Dados(comando);


            }

            catch (Exception e)
            {
                Console.WriteLine("Erro ao Carregar Planos -- " + e.Message);
            }
            finally
            {
                banco = null;
            }

            return dt;
        }
    

    public DataTable selecionar_categ_planos(string categoria)
        {
          
            DataTable dt = new DataTable();
            AcessoBancoDados banco;

            try
            {
                string comando;

                banco = new AcessoBancoDados();
                banco.Conectar();
                comando = ("SELECT PlanNome FROM planos000 WHERE PlanCate = '" + categoria + "'");
                                              
                dt = banco.Tabela_Dados(comando);


            }

            catch (Exception e)
            {
                Console.WriteLine("Erro ao Carregar Planos -- " + e.Message);
            }
            finally
            {
                banco = null;
            }

            return dt;
        }

    public DataTable selecionar_categoria()
    {

        DataTable dt = new DataTable();
        AcessoBancoDados banco;

        try
        {
            string comando;

            banco = new AcessoBancoDados();
            banco.Conectar();
            comando = ("SELECT DISTINCT `PlanCate` FROM `planos000`");

            dt = banco.Tabela_Dados(comando);


        }

        catch (Exception e)
        {
            Console.WriteLine("Erro ao Carregar Planos -- " + e.Message);
        }
        finally
        {
            banco = null;
        }

        return dt;
    }

    public DataTable selecionar_planos_voucher(string plano, string categoria)
    {

        DataTable dt = new DataTable();
        AcessoBancoDados banco;

        try
        {
            string comando;

            banco = new AcessoBancoDados();
            banco.Conectar();
            comando = ("SELECT `PlanCod`, `PlanNome`, `PlanCate` FROM `planos000` WHERE `PlanCate` = '" + categoria  +"'");

            dt = banco.Tabela_Dados(comando);


        }

        catch (Exception e)
        {
            Console.WriteLine("Erro ao Carregar Planos -- " + e.Message);
        }
        finally
        {
            banco = null;
        }

        return dt;
    }
    
    
    
    
    
    }



}
