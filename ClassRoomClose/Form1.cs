using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClassRoomClose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string OCam = "https://ohsoft.net/eng/ocam/download.php?cate=1002";
            string ActivityPresenter = "https://atomisystems.com/download/";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    
                    try
                    {
                        string F2600G4 = "https://support.hp.com/tw-zh/drivers/hp-prodesk-600-g4-microtower-pc/21341167";
                        System.Diagnostics.Process.Start(F2600G4);
                        System.Diagnostics.Process.Start(OCam);
                        System.Diagnostics.Process.Start(ActivityPresenter);
                    }
                    catch (Win32Exception noBrowser)
                    {
                        if (noBrowser.ErrorCode == -2147467259)
                            MessageBox.Show(noBrowser.Message);
                    }
                    catch (Exception other)
                    {
                        MessageBox.Show(other.Message);
                    }
                    break;
                case 1:
                    string F3800G2 = "https://support.hp.com/tw-zh/drivers/hp-elitedesk-800-g2-tower-pc/7633297";
                    System.Diagnostics.Process.Start(F3800G2);
                    System.Diagnostics.Process.Start(OCam);
                    System.Diagnostics.Process.Start(ActivityPresenter);
                    break;
                case 2:
                    string F3600G3 = "https://support.hp.com/tw-zh/drivers/hp-prodesk-600-g3-small-form-factor-pc/15292277";
                    System.Diagnostics.Process.Start(F3600G3);
                    System.Diagnostics.Process.Start(OCam);
                    System.Diagnostics.Process.Start(ActivityPresenter);
                    break;
                default:
                    
                    break;  
            }
        }
    }
}
