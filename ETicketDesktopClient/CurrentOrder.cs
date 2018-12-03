using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETicketDesktopClient
{
    public partial class CurrentOrder : Form
    {
        int orderId;
        public CurrentOrder(int orderId)
        {
            this.orderId = orderId;
            InitializeComponent();
            label1.Text = this.orderId.ToString();
        }
    }
}
