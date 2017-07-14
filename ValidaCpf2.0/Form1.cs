using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidaCpf2._0
{
    public partial class frmCpf : Form
    {
        public frmCpf()
        {
            InitializeComponent();
        }

        

        private void txValidaCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void btnValidaCpf_Click(object sender, EventArgs e)
        {
            
            validaCpf.validaDig(txValidaCpf.Text);
            bool result = validaCpf.validaDig(txValidaCpf.Text);

            if (result == true)
            {
                MessageBox.Show("CPF VALIDO, OBS: NÃO FOI FACIL CHEGAR NESSE RESULTADO!");
            }
            else
                MessageBox.Show("CPF INVALIDO, OBS: TAMBEM NÃO FOI FACIL!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
