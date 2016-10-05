using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class CEP
    {
        public DataSet Completar_Cep(string mskCep)
        {
            DataSet ds = new DataSet();


            try
            {

                ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + mskCep + "&formato=xml");

                if (ds.Tables[0].Rows[0]["resultado"].ToString().Trim() != "0")
                {
                    return ds;
                }
         
            }

            catch (Exception)
            {
                return ds;
            }

            return ds;
        }
                  

    }
}
