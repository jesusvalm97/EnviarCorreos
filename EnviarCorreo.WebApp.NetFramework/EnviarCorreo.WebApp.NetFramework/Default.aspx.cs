﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnviarCorreo.WebApp.NetFramework
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            string emailOrigin = txtEmailOrigen.Text;
            string emailDestinatary = txtEmailDestinatary.Text;
            string emailSubject = txtEmailSubject.Text;
            string emailBody = txtEmailBody.Text;

            EmailTools.SendEmail(emailOrigin, emailDestinatary, emailSubject, emailBody);
        }
    }
}