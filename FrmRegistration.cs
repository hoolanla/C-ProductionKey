using FoxLearn.License;
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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        const int ProductionCode = 1;




        private void btnOK_Click(object sender, EventArgs e)
        {

          
            KeyManager km = new KeyManager(textProductID.Text);
            string ProductionKey = textProductKey.Text;
        
           if(km.ValidKey(ref ProductionKey))
              
            {
                KeyValuesClass kv = new KeyValuesClass();
                if(km.DisassembleKey(ProductionKey,ref kv))
                {
                    LicenseInfo Lic = new LicenseInfo();
                    Lic.ProductKey= ProductionKey;
                    Lic.FullName = "FoxLearn";
                    
                    km.SaveSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath),Lic);

                    MessageBox.Show("OK");
              
                    }
                else
                {
                    MessageBox.Show("False!!");
                }
             
                   

            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            textProductID.Text = ComputerInfo.GetComputerId();


            KeyManager km = new KeyManager(textProductID.Text);
            LicenseInfo lic = new LicenseInfo();
            //Get license information from license file
            int value = km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), ref lic);
            string productKey = lic.ProductKey;
            

        }
    }
}
