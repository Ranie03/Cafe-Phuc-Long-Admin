﻿using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class frmMainSale : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public frmMainSale(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.Load += FrmMainSale_Load; ;
        }

        private void FrmMainSale_Load(object sender, EventArgs e)
        {
            
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateOrderSaff frmOrderSaff = _serviceProvider.GetRequiredService<frmCreateOrderSaff>();
            frmOrderSaff.ShowDialog();
            this.Show();
        }

        private void openOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrderManagement frmOrderManagement = _serviceProvider.GetRequiredService<frmOrderManagement>();
            frmOrderManagement.ShowDialog();
            this.Show();
        }
    }
}
