﻿using System;
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
    public partial class Connec : Form
    {
        public Connec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           KPI_Tools.Cpdf IntPDF = new KPI_Tools.Cpdf();
           IntPDF.Show();
           this.Hide();
        }
    }
}
