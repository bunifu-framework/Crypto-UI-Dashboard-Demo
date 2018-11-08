using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspirationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveSidePanel(btnDashboard);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.bunifuElipse1.ApplyElipse(pnl1, 8);
            this.bunifuElipse1.ApplyElipse(pnl2, 8);
            this.bunifuElipse1.ApplyElipse(pnl3, 8);
        }

        private void MoveSidePanel(Control c)
        {
            SidePanel.Height = c.Height;
            SidePanel.Top = c.Top;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnDashboard);
        }

        private void btnSendTckn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnSendTckn);
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnData);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnPayments);
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnWallet);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnCart);
        }
    }
}
