using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.ShowBalloonTip(10000, "Balloontip", "Please click on the notifyIcon below", ToolTipIcon.Info);
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            Console.WriteLine("notifyIcon balloontip click");
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("notifyIcon click");
        }
    }
}
