using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionKey
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnFrmGen_Click(object sender, EventArgs e)
        {


            using(FrmGenarate frm = new FrmGenarate())
            
            {
                frm.ShowDialog();


            }

        }

        private void btnFrmRegis_Click(object sender, EventArgs e)
        {
            using(FrmRegistration frm = new FrmRegistration())
            {

                frm.ShowDialog();
            }
        }
    }
}
