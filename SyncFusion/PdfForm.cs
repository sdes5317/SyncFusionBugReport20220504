using Syncfusion.Windows.Forms.PdfViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncFusion
{
    public partial class PdfForm : Form
    {
        private readonly PdfViewerControl pdfViewerControl;

        public PdfForm()
        {
            InitializeComponent();

            pdfViewerControl = new PdfViewerControl();
            pdfViewerControl.Dock = DockStyle.Fill;
            Controls.Add(pdfViewerControl);

        }

        public void Load(string path)
        {
            pdfViewerControl.Load(path);
        }
        public void PageTo(int page)
        {
            pdfViewerControl.GoToPageAtIndex(page);
        }
    }
}
