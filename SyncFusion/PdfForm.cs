using Syncfusion.Windows.Forms.PdfViewer;
using Syncfusion.WinForms.Controls;
using System.IO;
using System.Windows.Forms;

namespace SyncFusion
{
    public partial class PdfForm : SfForm
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
            if (pdfViewerControl.IsDocumentLoaded)
            {
                pdfViewerControl.Unload();
            }

            pdfViewerControl.Load(path);
        }
        public void Load(byte[] pdfBytes)
        {
            if (pdfViewerControl.IsDocumentLoaded)
            {
                pdfViewerControl.Unload();
            }

            pdfViewerControl.Load(new MemoryStream(pdfBytes));
        }
        public void PageTo(int page)
        {
            pdfViewerControl.GoToPageAtIndex(page);
        }
    }
}
