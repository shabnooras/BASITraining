using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BASITraining.Models;
using BASITraining.Logic;

namespace BASITraining
{
    public partial class shoppingcart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List<cartitem> Getcoursecartitems()
        {
            ShoppingCartActions actions = new ShoppingCartActions();
            return actions.GetCartItems();

        }

        protected void CartList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void updatebutton_Click(object sender, EventArgs e)
        {

        }

        protected void CheckoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}