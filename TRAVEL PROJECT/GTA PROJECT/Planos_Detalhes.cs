using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GTA_PROJECT
{
    public class Planos_Detalhes
    {

        public void atribuir(string Plano)
        {
            frmPlanoInternacinal PlanInt = new frmPlanoInternacinal();
            frmPlanoNacional PlanNac = new frmPlanoNacional();
            frmPlanoEsporte PlanEsp = new frmPlanoEsporte();
            frmPlanoCorporativo PlanCorp = new frmPlanoCorporativo();
            frmPlanoMaritímo PlanMari = new frmPlanoMaritímo();
            frmPlanoReceptivo PlanRece = new frmPlanoReceptivo();
            frmPlanoStudent PlanEst = new frmPlanoStudent();
           

            if (Plano == "BRONZE")
            {
           
                PlanInt.Controls["gbBronze"].Visible = true;
                PlanInt.ShowDialog();
            }
            else if (Plano == "RUBI")
            {

                PlanInt.Controls["gbRubi"].Visible = true;
                PlanInt.ShowDialog();
                       
            
            }

            else if (Plano == "PLUS")
            {

                PlanNac.Controls["gbPlus"].Visible = true;
                PlanNac.ShowDialog();


            }
            else if (Plano == "VIP")
            {

                PlanNac.Controls["gbVip"].Visible = true;
                PlanNac.ShowDialog();


            }
            else if (Plano == "BRONZE MARITIMO")
            {

                PlanMari.Controls["gbBronze"].Visible = true;
                PlanMari.ShowDialog();


            }
            else if (Plano == "MERCOSUL MARITIMO")
            {

                PlanMari.Controls["gbMercosul"].Visible = true;
                PlanMari.ShowDialog();


            }    
                else if (Plano == "BRONZE NEVE")
            {

                PlanEsp.Controls["gbBronzeNeve"].Visible = true;
                PlanEsp.ShowDialog();
                       
                }
                        else if (Plano == "ALL SPORTS")
            {

                PlanEsp.Controls["gbAllSport"].Visible = true;
                PlanEsp.ShowDialog();
                       
            
            }
                 else if (Plano == "STUDENT FULL")
            {

                PlanEst.Controls["gbStudentFull"].Visible = true;
                PlanEst.ShowDialog();
                       
                        }
                              else if (Plano == "STUDENT GLOBAL")
            {

                PlanEst.Controls["gbStudentGlobal"].Visible = true;
                PlanEst.ShowDialog();
                       
                              }
            else if (Plano == "TITANIUM")
            {

                PlanCorp.Controls["gbTitanium"].Visible = true;
                PlanCorp.ShowDialog();
                       
            
            }

            else if (Plano == "EURO BUSINESS")
            {

                PlanCorp.Controls["gbEuroBusiness"].Visible = true;
                PlanCorp.ShowDialog();
            }


            else if (Plano == "RECEPTIVO BRONZE")
            {

                PlanRece.Controls["gbBronze"].Visible = true;
                PlanRece.ShowDialog();
            }

            else if (Plano == "RECEPTIVO UNION")
            {

                PlanRece.Controls["gbUnion"].Visible = true;
                PlanRece.ShowDialog();
             }    
        }
              
        public static string TipoPlan="", Plano="", Quant="",Dias = "";
        public static decimal valor;
        
        }   
             
   }