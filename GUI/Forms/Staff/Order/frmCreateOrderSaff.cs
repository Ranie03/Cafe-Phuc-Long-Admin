using GUI.Forms.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class frmCreateOrderSaff : Form
    {
        public frmCreateOrderSaff()
        {
            InitializeComponent();
            this.Load += FrmOrderSaff_Load;
        }

        private void FrmOrderSaff_Load(object sender, EventArgs e)
        {
            int sl = 20;
            int panelWidth = 120;
            int panelHeight = 180;
            int spacing = 10;
            int maxColumns = groupBox_product.Width / (panelWidth + spacing);
            int currentColumn = 0;
            int currentRow = 0;
            // Tạo một Panel và đặt thuộc tính AutoScroll thành true
            Panel panel = new Panel();
            panel.Width = groupBox_product.Width;
            panel.Height = groupBox_product.Height;
            panel.AutoScroll = true;

            groupBox_product.Controls.Add(panel);

            for (int i = 0; i < sl; i++)
            {
                UC_Product uc_product = new UC_Product();
                uc_product.Width = panelWidth;
                uc_product.Height = panelHeight;
                uc_product.Location = new Point(currentColumn * (panelWidth + spacing), currentRow * (panelHeight + spacing));

                panel.Controls.Add(uc_product);

                currentColumn++;
                if (currentColumn >= maxColumns)
                {
                    currentColumn = 0;
                    currentRow++;
                }
            }

        }
    }
}
