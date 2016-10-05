using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTA_PROJECT

{
    public class ValidaCPF
    {
        public int Valida_Num_1(string cpf)
        {
            int soma = 0, contador = 10;
            for (int i = 0; i < 9; i++) soma += int.Parse(cpf[i].ToString()) * contador--;
                return val_retorno(soma);
            
        }
        public int Valida_Num_2(string cpf)
        {
            int soma = 0, contador = 11;
            for (int i = 0; i < 10; i++) soma += int.Parse(cpf[i].ToString()) * contador--;
            return val_retorno(soma);
        }

        private int val_retorno(int soma)
        {
            if ((soma % 11) == 0) return 0;
            else if ((soma % 11) >= 2) return (11 - (soma % 11));
            return 0;

        }

        private Boolean verificacao(string cpf)
        {
            if (cpf.Length >= 11)
            {

                if (cpf == "00000000000" || cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" || cpf == "44444444444" || cpf == "55555555555" ||
                cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999")
                {
                    return false;
                }
            }
            else return false;

            return true;
        }



        public Boolean validação(string cpf)
        {
            Boolean resp = false;
            if (this.verificacao(cpf))
            {

                if (this.Valida_Num_1(cpf) == int.Parse(cpf[9].ToString()) && this.Valida_Num_2(cpf) == int.Parse(cpf[10].ToString()))
                    resp = true;
             }
            return resp;
        }
    }
}    
                   
   

