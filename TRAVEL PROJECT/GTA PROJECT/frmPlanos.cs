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
    public partial class frmPlanos : Form
    {
        public frmPlanos()
        {
            InitializeComponent();
        }

        private void frmPlanos_Load(object sender, EventArgs e)
        {
            dtgridInternacional.Rows.Insert(0,"BRONZE");
            dtgridInternacional.Rows.Insert(1, "RUBI");
            dtgridNacionais.Rows.Insert(0, "PLUS");
            dtgridNacionais.Rows.Insert(1, "VIP");
            dtgridEstudante.Rows.Insert(0, "STUDENT FULL");
            dtgridEstudante.Rows.Insert(1, "STUDENT GLOBAL");
            dtgridMari.Rows.Insert(0, "BRONZE MARITIMO");
            dtgridMari.Rows.Insert(1, "MERCOSUL MARITIMO");
            dtgridPratEsp.Rows.Insert(0, "BRONZE NEVE");            
            dtgridPratEsp.Rows.Insert(1, "ALL SPORTS");
            dtCorp.Rows.Insert(0, "TITANIUM");
            dtCorp.Rows.Insert(1, "EURO BUSINESS");
            dtgridRecp.Rows.Insert(0, "RECEPTIVO BRONZE");
            dtgridRecp.Rows.Insert(1, "RECEPTIVO UNION");    
                        
            
        }

        private void dtgridInternacional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            Planos_Detalhes a = new Planos_Detalhes();
                     
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
               
                string Plano = dtgridInternacional.Rows[e.RowIndex].Cells[0].Value.ToString();
                a.atribuir(Plano);

            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {

                if (Variaveis.logado == "sim")
                {
                    frmEmitir emitir = new frmEmitir();
                    emitir.ShowDialog();
                }
                else
                {

                    MessageBox.Show("É necessário logar para emitir voucher");

                }

            }
        }

        private void dtgridEstudante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Planos_Detalhes a = new Planos_Detalhes();

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {

                string Plano = dtgridEstudante.Rows[e.RowIndex].Cells[0].Value.ToString();
                a.atribuir(Plano);

            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {

                if (Variaveis.logado == "sim")
                {
                    frmEmitir emitir = new frmEmitir();
                    emitir.ShowDialog();
                }
                else
                {

                    MessageBox.Show("É necessário logar para emitir voucher");

                }

            }
        }

        private void dtgridMari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Planos_Detalhes a = new Planos_Detalhes();

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {

                string Plano = dtgridMari.Rows[e.RowIndex].Cells[0].Value.ToString();
                a.atribuir(Plano);

            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {

                if (Variaveis.logado == "sim")
                {
                    frmEmitir emitir = new frmEmitir();
                    emitir.ShowDialog();
                }
                else
                {

                    MessageBox.Show("É necessário logar para emitir voucher");

                }

            }
        }

        private void dtgridNacionais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Planos_Detalhes a = new Planos_Detalhes();

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {

                string Plano = dtgridNacionais.Rows[e.RowIndex].Cells[0].Value.ToString();
                a.atribuir(Plano);

            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {

                if (Variaveis.logado == "sim")
                {
                    frmEmitir emitir = new frmEmitir();
                    emitir.ShowDialog();
                }
                else
                {

                    MessageBox.Show("É necessário logar para emitir voucher");

                }

            }
        }

        private void dtgridPratEsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Planos_Detalhes a = new Planos_Detalhes();

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {

                string Plano = dtgridPratEsp.Rows[e.RowIndex].Cells[0].Value.ToString();
                a.atribuir(Plano);

            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {

                if (Variaveis.logado == "sim")
                {
                    frmEmitir emitir = new frmEmitir();
                    emitir.ShowDialog();
                }
                else
                {

                    MessageBox.Show("É necessário logar para emitir voucher");

                }

            }
        }

        private void dtCorp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Planos_Detalhes a = new Planos_Detalhes();

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {

                string Plano = dtCorp.Rows[e.RowIndex].Cells[0].Value.ToString();
                a.atribuir(Plano);

            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {

                if (Variaveis.logado == "sim")
                {
                    frmEmitir emitir = new frmEmitir();
                    emitir.ShowDialog();
                }
                else
                {

                    MessageBox.Show("É necessário logar para emitir voucher");

                }

            }
        }

        private void dtgridRecp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Planos_Detalhes a = new Planos_Detalhes();

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {

                string Plano = dtgridRecp.Rows[e.RowIndex].Cells[0].Value.ToString();
                a.atribuir(Plano);

            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {

                if (Variaveis.logado == "sim")
                {
                    frmEmitir emitir = new frmEmitir();
                    emitir.ShowDialog();
                }
                else
                {

                    MessageBox.Show("É necessário logar para emitir voucher");

                }

            }
        }                                
              
    }
}
