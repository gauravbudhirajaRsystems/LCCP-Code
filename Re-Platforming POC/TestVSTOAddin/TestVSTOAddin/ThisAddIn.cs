using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Office.Interop.Word;
using VstoHelperLibrary;

namespace TestVSTOAddin
{
    public partial class ThisAddIn
    {
        private SampleControl sampleControl;
        private Microsoft.Office.Tools.CustomTaskPane customTaskPane;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //Application.Documents.Open(@"C:\Doc.docx",false);
            //sampleControl = new SampleControl();
            //customTaskPane = CustomTaskPanes.Add(sampleControl, "Sample Control");
            //customTaskPane.Visible = true;

            //string receivedXml = string.Empty;
            //Application.Documents.Open(@"C:\Users\gaurav.budhiraja\OneDrive - Litera\Documents\Application Security.docx");
            //Application.Documents.Open(@"C:\Doc.docx");
            Microsoft.Office.Interop.Word.Document activeDocument = Application.Documents.Open(@"C:\Doc.docx");
            //Application.ActiveDocument.Close();
            //Application.Documents.Open(@"C:\Doc1.docx");
            string fileName = activeDocument.FullName;
            //activeDocument.Close();
            //using (WordprocessingDocument document = WordprocessingDocument.Open(fileName, true))
            //{
            //    MainDocumentPart mainPart = document.MainDocumentPart;
            //    Body body = mainPart.Document.Body;
            //    Request request = new Request()
            //    {
            //        InnerXml = body.InnerXml,
            //        OuterXml = body.OuterXml
            //    };
            //    receivedXml = HelperClass.AddParagraph(request);
            //}
            Request request = new Request() { 
                WordOpenXML = activeDocument.WordOpenXML 
            };
            string recievedXml = HelperClass.AddParagraph(request);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
