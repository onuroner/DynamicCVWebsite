﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities111 db = new DBCVENTITYEntities111();
            var mesaj = db.TBLILETIŞIM.ToList();
            Repeater1.DataSource = mesaj;
            Repeater1.DataBind();
        }
    }
}