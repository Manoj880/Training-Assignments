using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeQue_2
{
    public partial class Automobiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                string[] str = new string[] {"Kawasaki H2r", "triumph", "lamborgini", "Lykan Hypersport", "Bugatti" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Pictures/" + str + ".JFIF";
        }

            protected void Button1_Click1(object sender, EventArgs e)
            {


                if (DropDownList1.Items.FindByText("Kawasaki H2r").Selected == true)
                {
                    TextBox1.Text = "Price: 40,00,000/-";
                }
                else if (DropDownList1.Items.FindByText("triumph").Selected == true)
                {
                    TextBox1.Text = "Price: 11,35,000/-";
                }
                else if (DropDownList1.Items.FindByText("lamborgini").Selected == true)
                {
                    TextBox1.Text = "Price: 6,25,00,000/-";
                }
                else if (DropDownList1.Items.FindByText("Lykan Hypersport").Selected == true)
                {
                    TextBox1.Text = "Price: 21,70,00,000/-";
                }
                else if (DropDownList1.Items.FindByText("Bugatti").Selected == true)
                {
                    TextBox1.Text = "Price: 28,40,00,000/-";
                }
            }
           

        
    }
}