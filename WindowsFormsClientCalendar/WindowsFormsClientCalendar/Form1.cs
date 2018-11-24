using Microsoft.Toolkit.Services.Services.MicrosoftGraph;
using Microsoft.Toolkit.Services.WinForms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClientCalendar
{
    public partial class Form1 : Form
    {
        private Microsoft.Graph.GraphServiceClient graphClient = null;
        public Form1()
        {
            InitializeComponent();

            // values to connect to Microsoft Graph
            graphLoginComponent1.ClientId = "7c7a7d9b-9465-4c1c-942f-d27697515807";
            graphLoginComponent1.Scopes = new string[] { MicrosoftGraphScope.UserRead, MicrosoftGraphScope.MailSend,  MicrosoftGraphScope.CalendarsReadWrite };

        }

        private async void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            if (!await graphLoginComponent1.LoginAsync())
            {
                return;
            }

            txtName.Text = graphLoginComponent1.DisplayName;
          



        }

        private async void btnAddCalendar_Click(object sender, EventArgs e)
        {
            //if (!await graphLoginComponent1.LoginAsync())
            //{
            //    return;
            //}
            //graphClient = graphLoginComponent1.GraphServiceClient;
            //Microsoft.Graph.Event kegiatan = new Microsoft.Graph.Event();
            //kegiatan.Subject = txtTitle.Text;
            //var tanggal = new Microsoft.Graph.DateTimeTimeZone();
            //tanggal.DateTime = dtpDate.Value.ToString("yyyy-MM-ddThh:mm:ss.000Z");
            //tanggal.DateTime = "2018-11-25T10:18:43.027Z";
            //tanggal.TimeZone = "UTC";
            //kegiatan.Start = tanggal;
            //var hasil = await graphClient.Me.Events.Request().AddAsync(kegiatan);
            //MessageBox.Show(hasil.ToString());

        }
    }
}
