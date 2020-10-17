using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessSpeadSheetGoogle
{
    public partial class Form1 : Form
    {        
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Demo Read Google SpeadSheet";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }
          
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            String spreadsheetId = "1uHaPYZ7qiRawdhjuwk_F7_FVmS1oshdzGbyhVkFYPzc";
            String range = "sang!A2:G";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            // Prints the names and majors of students in a sample spreadsheet:
           
            // https://docs.google.com/spreadsheets/d/1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms/edit

            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                ListViewItem item = new ListViewItem();
                foreach (var row in values) 
                {                    
                    Console.WriteLine("{0}, {1}", row[0], row[1]);

                      item = new ListViewItem(new string[] {row[0].ToString(), row[1].ToString()});
                    lst_data.Items.AddRange(new ListViewItem[] { item });
                }
              
            }
            else
            {
                Console.WriteLine("No data found.");
            }
            
        }
    }
}
