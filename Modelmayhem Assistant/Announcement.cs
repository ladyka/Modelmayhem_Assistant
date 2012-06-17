using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Modelmayhem_Assistant
{
    class Announcement
    {
        private string authcookie;
        private HttpWebRequest loginWebRequest;


        internal bool loginonsite(string login, string password)
        {
            loginWebRequest = (HttpWebRequest)WebRequest.Create("https://secure.modelmayhem.com/login/action");
            loginWebRequest.AllowAutoRedirect = false;
            loginWebRequest.Method = "POST";
            loginWebRequest.UserAgent = "Mozilla/5.0 (X11; Linux x86_64; rv:15.0) Gecko/15.0 Firefox/15.0";
            loginWebRequest.ContentType = "application/x-www-form-urlencoded";
            loginWebRequest.ProtocolVersion = HttpVersion.Version10;
            loginWebRequest.Referer = "https://secure.modelmayhem.com/login/box";
            loginWebRequest.CookieContainer = new CookieContainer();
            var buffer = Encoding.ASCII.GetBytes(string.Format("email={0}&clear=true&password={1}", login, password));

            loginWebRequest.ContentLength = buffer.Length;
            try
            {
                var writer = loginWebRequest.GetRequestStream();
                writer.Write(buffer, 0, buffer.Length);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            bool retval = false;
            try 
            {
                var httpWebResponse = (HttpWebResponse)loginWebRequest.GetResponse();
                authcookie = httpWebResponse.Headers[HttpResponseHeader.SetCookie];
                var location = httpWebResponse.Headers.Get("Location") ?? "";
                retval =  !location.Contains("failed");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return retval;
        }

        internal string sendannouncement(string message)
        {
            var sendMsgWebR = (HttpWebRequest)WebRequest.Create("http://www.modelmayhem.com/announce/save");
            sendMsgWebR.AllowAutoRedirect = false;
            sendMsgWebR.Method = "POST";
            sendMsgWebR.UserAgent = "Mozilla/5.0 (X11; Linux x86_64; rv:15.0) Gecko/15.0 Firefox/15.0";
            sendMsgWebR.ContentType = "application/x-www-form-urlencoded";
            sendMsgWebR.ProtocolVersion = HttpVersion.Version10;
            sendMsgWebR.Referer = "http://www.modelmayhem.com/announce/preview";
            sendMsgWebR.CookieContainer = loginWebRequest.CookieContainer;
            var buffer = Encoding.ASCII.GetBytes(string.Format("announcement={0}&action=announcement&vip_status=1&submit=Let%27s+do+this+ALREADY%21", message));

            sendMsgWebR.ContentLength = buffer.Length;

            try
            {
                var writer = sendMsgWebR.GetRequestStream();
                writer.Write(buffer, 0, buffer.Length);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            string returnvalue = "error";
            try
            {
                var httpWebResponse = (HttpWebResponse)sendMsgWebR.GetResponse();
                authcookie = httpWebResponse.Headers[HttpResponseHeader.SetCookie];
                returnvalue = httpWebResponse.Headers.Get("Location") ?? "error_Location";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return returnvalue;
        }
    }
}
