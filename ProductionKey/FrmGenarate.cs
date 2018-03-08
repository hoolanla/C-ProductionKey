using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using FoxLearn.License;

namespace ProductionKey
{
    public partial class FrmGenarate : Form
    {
        public FrmGenarate()
        {
            InitializeComponent();
        }


        const int ProductionCode = 1;
     
        private void Form1_Load(object sender, EventArgs e)
        {

            textProductID.Text = ComputerInfo.GetComputerId();


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
           KeyManager km = new KeyManager(textProductID.Text);
           KeyValuesClass kv;
           string ProductionKey =textProductKey.Text;
           kv = new KeyValuesClass()
           {
               Type = LicenseType.FULL,Header=Convert.ToByte(9),Footer=Convert.ToByte(6),ProductCode=(byte)ProductionCode,
               Edition = Edition.ENTERPRISE,Version=1
           };
            if(!km.GenerateKey(kv,ref ProductionKey))
            {
                textProductKey.Text = "ERROR";
            }
            textProductKey.Text = ProductionKey;
        }
    }
}
