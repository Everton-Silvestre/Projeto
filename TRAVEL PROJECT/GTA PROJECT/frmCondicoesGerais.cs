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
    public partial class frmCondicoesGerais : Form
    {
        public frmCondicoesGerais(string url)
        {
            InitializeComponent();
            webCondGerais.Url = new System.Uri(url, System.UriKind.Absolute);
        }
          
              
    }
}
