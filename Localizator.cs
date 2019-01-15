using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Localizator
{
    public partial class Localizator : Form
    {

        // cheia de acces la serviciul GeoLite City de la Maxmind
        //  daca nu mai este valabila, trebuie ceruta alta cheie, la http://www.maxmind.com/app/demo_request?type=city_ws
        string cheie = "h35ruIxv8zWj";

        // Sursa: http://www.maxmind.com/app/web_services_cityisporg_usage
        // Contributed by Gokhan Saltik
        private string ReturnData(string IP)
        {
            System.Uri objUrl = new System.Uri("http://geoip3.maxmind.com/b?l="+cheie+"&i=" + IP);
            System.Net.WebRequest objWebReq;
            System.Net.WebResponse objResp;
            System.IO.StreamReader sReader;
            string strReturn = string.Empty;

            //Try to connect to the server and retrieve data. 
            try
            {
                objWebReq = System.Net.WebRequest.Create(objUrl);
                objResp = objWebReq.GetResponse();

                //Get the data and store in a return string. 
                sReader = new System.IO.StreamReader(objResp.GetResponseStream());
                strReturn = sReader.ReadToEnd();

                //Close the objects. 
                sReader.Close();
                objResp.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                objWebReq = null;
            }

            return strReturn;

        }


        public Localizator()
        {
            InitializeComponent();
        }

        private void btnLocalizeaza_Click(object sender, EventArgs e)
        {
            string[] rezultat = ReturnData(tbIP.Text).Split(','); // raspunsul este de forma "tara,judet,oras,lat,long", trebuie impartit
            tbTara.Text = rezultat[0];
            tbJudet.Text = rezultat[1];
            tbOras.Text = rezultat[2];
            tbLat.Text = rezultat[3];
            tbLong.Text = rezultat[4];
        }
    }
}
