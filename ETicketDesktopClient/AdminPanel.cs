using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETicketDesktopClient
{
    public partial class AdminPanel : Form
    {
        Thread thread;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void orderBt_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenNewWindow);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenNewWindow(object obj)
        {
            Application.Run(new Orders());
        }
    }
}
