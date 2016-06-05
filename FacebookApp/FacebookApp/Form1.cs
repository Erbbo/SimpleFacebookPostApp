using System;
using System.Windows.Forms;
using Facebook;
using System.Collections.Generic;
using System.Dynamic;

namespace FacebookApp
{
    public partial class Form1 : Form
    {
        private readonly AuthorizeApp _client;
        private string _accessToken;

        public Form1()
        {
            InitializeComponent();
            _client = new AuthorizeApp();
        }

        private void authorizeBtn_Click(object sender, EventArgs e)
        {
            _client.Authorize();
            var url = _client.GetLoginUrl(_client.Parameters);
            webBrowser.Navigate(url);
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            FacebookOAuthResult result = null;
            try
            {
                if (e.Url.ToString().Contains("access_token"))
                {
                    result = _client.ParseOAuthCallbackUrl(new Uri(e.Url.ToString()));
                }
                if (result != null && result.IsSuccess)
                {
                    _accessToken = result.AccessToken;
                }
            }
            catch (Exception ex)
            {
                errorMessage.Text = ex.Message;
            }
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic post = new ExpandoObject();
                post.message = richTxtBox.Text;
                _client.AccessToken = _accessToken;
                var result = (IDictionary<string, object>)_client.Get("/me?fields=id");
                var feed = "/" + result["id"] + "/feed/";
                _client.Post(feed, post);
                errorMessage.Text = "Success, you posted to " + feed;
                webBrowser.Navigate("www.Facebook.com");
            }
            catch (Exception ex)
            {
                errorMessage.Text = ex.Message;
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(address.Text);
        }
    }
}
