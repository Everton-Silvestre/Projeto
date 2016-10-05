using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace GTA_PROJECT
        
{
    public class ValidaCNPJ
    {
        private int[] array = new int[14];

        private int Valida_Num_1(string cnpj)
        {
            int soma = 0,contador = 5, contador2 = 9;
            for (int i = 0; i < cnpj.Length; i++)
            {
               
                if (i < 4) soma += int.Parse(cnpj[i].ToString ()) * contador--;
                else if (i >= 4 && i < 12) soma += int.Parse(cnpj[i].ToString())  * contador2--;
          
            }

           return val_retorno(soma);
           
        }
        private int Valida_Num_2(string cnpj)
        {
            int soma = 0,contador=6, contador2 = 9;
            for (int i = 0; i < 13 ; i++)
            {
                if (i < 5)
                {
                    soma += int.Parse(cnpj[i].ToString()) * contador--;
                }
                else if (i >= 5 && i < 13) soma += int.Parse(cnpj[i].ToString()) * contador2--;
                     
            }
            return val_retorno(soma);
         
        }

        private int val_retorno(int soma)
        {
                if ((soma % 11) == 0) return 0;
                else if ((soma % 11) >= 2) return (11 - (soma % 11));
                return 0;

         }
        
        private Boolean verificacao(string cnpj)
        {
            if (cnpj.Length >= 14)
            {
               if (cnpj == "00000000000000")
                {
                    return false;
                }
            }
            else if (cnpj.Length < 14){
             
                return false;
            }

            return true;
        }
        public Boolean validação(string cnpj)
        {
            Boolean resp=false;
            if (this.verificacao(cnpj))
            {

                if (this.Valida_Num_1(cnpj) == int.Parse(cnpj[12].ToString()) && this.Valida_Num_2(cnpj) == int.Parse(cnpj[13].ToString()))
                    resp = true;                                         
            }
            return resp;
        }                
      }
                 
   }

