﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP229_Lab1
{
    public partial class _Default : Page
    {
        /// <summary>
        /// The Method executes every time the page loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            HelloLabel.Text = "Bye Bye!";
        }
    }
}