﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities111 db = new DBCVENTITYEntities111();
            Repeater1.DataSource = db.TBLHAKKIMDA.ToList();
            Repeater1.DataBind();
        }
    }
}