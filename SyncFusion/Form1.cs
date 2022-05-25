using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncFusion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pdfForm = new PdfForm();
            pdfForm.Hide();
            pdfForm.Load("3.pdf");
            pdfForm.PageTo(2);
            pdfForm.Show();
        }
    }
}
