using Microsoft.Office.Interop.Word;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;
using Document = Microsoft.Office.Interop.Word.Document;

namespace TestVSTOAddin
{
    class BADocument
    {
        public Document Document { get; set; }
    }

    public partial class ThisAddIn
    {
        //private readonly SampleControl sampleControl;
        //private Microsoft.Office.Tools.CustomTaskPane customTaskPane;

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            //string fileName = activeDocument.Name;
            //string newfileName = Guid.NewGuid().ToString() + "_" + fileName;
            //string path = @"C:\" + newfileName;
            //activeDocument.SaveAs2(path);
            //string path = @"C:\ReceivedDoc2.docx";
            //byte[] bytes = File.ReadAllBytes(path);
            //Document document = Application.Documents.Open(@"C:\NewDoc1.docx", null, true);
            Document document = Application.Documents.Open(@"C:\Test.docx", null, true);
            //var nullObj = null;
            //Application.Quit();
            XDocument xDocument = XDocument.Parse(document.WordOpenXML);
            //string xmlRequestBody = xDocument.ToString();

            //var app = document.Application;
            //var ass = app.Assistant;
            //sampleControl = new SampleControl();
            //customTaskPane = CustomTaskPanes.Add(sampleControl, "Sample Control");
            //customTaskPane.Visible = true;
            using (var client = new HttpClient())
            {
                //BADocument bADocument = new BADocument() { Document = document };
                // Setting Base address.  
                client.BaseAddress = new Uri("https://localhost:7275/");
                /*Document*/
                //var json = JsonConvert.SerializeObject(bytes);
                var json = JsonConvert.SerializeObject(xDocument);
                //var json = JsonConvert.SerializeObject(document, new JsonSerializerSettings
                //{
                //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                //    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                //    ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
                //});

                //var data = new StringContent(json, Encoding.UTF8, "application/json");
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                // HTTP POST  
                var response = client.PostAsync("api/startup/HasNullHeaderFooter", data).Result;

                // Verification  
                if (response.IsSuccessStatusCode)
                {
                    // Reading Response.  
                    var result = response.Content.ReadAsStringAsync().Result;
                    //receivedResult = JsonConvert.DeserializeObject<bool>(result);
                }
            }


            //Application.Documents.Open(@"C:\Doc.docx",false);
            //sampleControl = new SampleControl();
            //customTaskPane = CustomTaskPanes.Add(sampleControl, "Sample Control");
            //customTaskPane.Visible = true;

            //string receivedXml = string.Empty;
            //Application.Documents.Open(@"C:\Users\gaurav.budhiraja\OneDrive - Litera\Documents\Application Security.docx");
            //Application.Documents.Open(@"C:\Doc.docx");
            //Microsoft.Office.Interop.Word.Document activeDocument = Application.Documents.Open(@"C:\Doc.docx");
            //activeDocument.WordOpenXML
            //Application.ActiveDocument.Close();
            //Application.Documents.Open(@"C:\Doc1.docx");
            //string fileName = activeDocument.Name;
            //string newfileName = Guid.NewGuid().ToString() + "_" + fileName;
            //string path = @"C:\" + newfileName;
            //activeDocument.SaveAs2(path);
            //string path = @"C:\Doc.docx";
            //byte[] bytes = File.ReadAllBytes(path);

            //using (var client = new HttpClient())
            //{
            //    // Setting Base address.  
            //    client.BaseAddress = new Uri("https://localhost:7275/");
            //    /*Document*/
            //    var json = JsonConvert.SerializeObject(bytes);
            //    var data = new StringContent(json, Encoding.UTF8, "application/json");

            //    // HTTP POST  
            //    var response = client.PostAsync("api/startup/HasNullHeaderFooter", data).Result;

            //    // Verification  
            //    if (response.IsSuccessStatusCode)
            //    {
            //        // Reading Response.  
            //        var result = response.Content.ReadAsStringAsync().Result;
            //        //receivedResult = JsonConvert.DeserializeObject<bool>(result);
            //    }
            //}

            // return receivedResult;

            // activeDocument.Fil
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
            //Request request = new Request() { 
            //    WordOpenXML = activeDocument.WordOpenXML 
            //};
            //string recievedXml = HelperClass.AddParagraph(request);
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
