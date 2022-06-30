using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestVSTOAddin
{
    public partial class SampleControl : UserControl
    {
        Microsoft.Office.Interop.Word.Document document;

        public SampleControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            document = Globals.ThisAddIn.Application.ActiveDocument;
            //Document document2 = Globals.ThisAddIn.Application.Documents.Open(@"C:\Doc1.docx", false);
            //document = Globals.ThisAddIn.Application.CompareDocuments(document, document2, WdCompareDestination.wdCompareDestinationNew, WdGranularity.wdGranularityWordLevel);
            //string openXml = document.WordOpenXML;
            //document.Close();
            //Globals.ThisAddIn.Application.Documents.Open(@"C:\Doc1.docx", false);
        }
    }
}
