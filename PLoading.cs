using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPI_Tools
{
    public partial class PLoading : Form
    {
        public PLoading()
        {
            InitializeComponent();
        }

        int loadin1 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadin1 += 1;
            Load1.Value = loadin1;
            Pource1.Text = loadin1 + "%";
            if (Load1.Value >= 100)
            {
                Load1.Value = 0;
                timer1.Stop();
                Connec IntCon = new Connec();
                IntCon.Show();
                this.Hide();

            }
        }
        private void PLoading_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
        }

        private void Pource1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
