using Facebook;
using System;
using System.Dynamic;

namespace FacebookApp
{
    public class AuthorizeApp : FacebookClient
    {
        public dynamic Parameters { get; set; }

        public override string AppId
        {
            get { return base.AppId; }
            set { base.AppId = value; }
        }

        public override string AppSecret
        {
            get { return base.AppSecret; }
            set { base.AppSecret = value; }
        }

        public override Uri GetLoginUrl(object parameters)
        {
            return base.GetLoginUrl(parameters);
        }

        public void Authorize()
        {
            var auth = new AuthorizeApp();
            // No need for an app secret in an implicit grant flow
            // AppSecret = "f6e06af58b57e006c3ef96f0fabd5e65";
            Parameters = new ExpandoObject();
            Parameters.type = "user_agent";
            Parameters.client_id = "1171153062936655";
            Parameters.redirect_uri = "https://erictestappwebpage.wordpress.com/";
            Parameters.grant_type = "client_credentials";
            Parameters.scope = "manage_pages,offline_access,publish_actions";
        }
    }
}
