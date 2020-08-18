using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobloxUsernameChecker
{
    public partial class Form1 : Form
    {
        private HttpClient httpClient = new HttpClient();
        private int total;
        private int available;

        public Form1()
        {
            InitializeComponent();

            //Downloads Newtonsoft.Json.dll
            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/PY44N/FileDownloads/raw/master/Newtonsoft.Json.dll", "Newtonsoft.Json.dll");
            }
        }

        private async Task<string> CheckName(string[] names)
        {
            string working = "";
            string[] strArray = names;
            for (int index = 0; index < strArray.Length; ++index)
            {
                string name = strArray[index];
                string str1 = await (await this.httpClient.GetAsync("https://api.roblox.com/users/get-by-username?username=" + name)).Content.ReadAsStringAsync();
                try
                {
                    string str2 = JsonConvert.DeserializeObject<Dictionary<string, string>>(str1)["Id"];
                }
                catch (Exception ex)
                {
                    if (ex.ToString().Contains("The given key was not present in the dictionary") & name.Length > 2 & name.Length <= 20)
                        working = working + name + "\n";
                    ++this.available;
                    this.AvailableCount.Text = "Available: " + this.available.ToString();
                }
                ++this.total;
                this.TotalCount.Text = "Total: " + this.total.ToString();
                name = (string)null;
            }
            strArray = (string[])null;
            return working;
        }


        private async void Start_Click(object sender, EventArgs e)
        {
            this.total = 0;
            this.available = 0;
            this.TotalCount.Text = "Total: 0";
            this.AvailableCount.Text = "Available: 0";
            string[] names = this.Input.Text.Split('\n');
            RichTextBox richTextBox = this.Output;
            richTextBox.Text = await this.CheckName(names);
            richTextBox = (RichTextBox)null;
        }
    }
}
