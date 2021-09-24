using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MIS316_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAddThem_Click(object sender, EventArgs e)
    {   
        //Attempt to run the code and check for invalid input
        try
        {
            //Declar variables for input and sum
            decimal inputA = 0m;
            decimal inputB = 0m;
            decimal addRes = 0m;

            //Read inputs and store as variables
            inputA = Convert.ToDecimal(txtInputA.Text);
            inputB = Convert.ToDecimal(txtInputB.Text);

            //Calculate sum and store in addRes variable
            addRes = inputA + inputB;

            //Output sum to page
            lblAddThem.Text = addRes.ToString();
        }
        catch (Exception)
        {
            lblAddThem.Text = "Please enter numeric values in the textboxes!";
        }
    }

    protected void btnSubThem_Click(object sender, EventArgs e)
    {
        //Attempt to run the code and check for invalid input
        try
        {
            //Declar variables for input and result
            decimal inputA = 0m;
            decimal inputB = 0m;
            decimal subRes = 0m;

            //Read inputs and store as variables
            inputA = Convert.ToDecimal(txtInputA.Text);
            inputB = Convert.ToDecimal(txtInputB.Text);

            //Calculate result and store in subRes variable
            subRes = inputA - inputB;

            //Output result to page
            lblSubThem.Text = subRes.ToString();
        }
        catch (Exception)
        {
            lblSubThem.Text = "Please enter numeric values in the textboxes!";
        }

    }

    protected void btnMultThem_Click(object sender, EventArgs e)
    {
        //Attempt to run the code and check for invalid input
        try
        {
            //Declar variables for input and result
            decimal inputA = 0m;
            decimal inputB = 0m;
            decimal multRes = 0m;

            //Read inputs and store as variables
            inputA = Convert.ToDecimal(txtInputA.Text);
            inputB = Convert.ToDecimal(txtInputB.Text);

            //Calculate result and store in multRes variable
            multRes = inputA * inputB;

            //Output result to page
            lblMultThem.Text = multRes.ToString();
        }
        catch (Exception)
        {
            lblMultThem.Text = "Please enter numeric values in the textboxes!";
        }

    }

    protected void btnDivThem_Click(object sender, EventArgs e)
    {
        //Attempt to run the code and check for invalid input
        try
        {
            //Declar variables for input and result
            decimal inputA = 0m;
            decimal inputB = 0m;
            decimal divRes = 0m;

            //Read inputs and store as variables
            inputA = Convert.ToDecimal(txtInputA.Text);
            inputB = Convert.ToDecimal(txtInputB.Text);
            try
                //Check for proper input and send erro message if divided by 0 
            {
                //Calculate result and store in divRes variable
                divRes = inputA / inputB;

                //Output result to page
                lblDivThem.Text = divRes.ToString();
            }
            catch (Exception)
            {
                lblDivThem.Text = "Cannot divide by zero!"; 
            }

        }
        catch (Exception)
        {
            lblDivThem.Text = "Please enter numeric values in the textboxes!";
        }

    }

    protected void btnAllCalc_Click(object sender, EventArgs e)
    {
        //Attempt to run the code and check for invalid input
        try
        {
            //Declar variables for input and calculations
            decimal inputA = 0m;
            decimal inputB = 0m;
            decimal addRes = 0m;
            decimal subRes = 0m;
            decimal multRes = 0m;
            decimal divRes = 0m;

            //Read inputs and store as variables
            inputA = Convert.ToDecimal(txtInputA.Text);
            inputB = Convert.ToDecimal(txtInputB.Text);

            //Calculate all results and store in Res variables
            addRes = inputA + inputB;
            subRes = inputA - inputB;
            multRes = inputA * inputB;
            try
                //Check for proper input and send erro message if divided by 0 
            {
                divRes = inputA / inputB;
                lblDivThem.Text = divRes.ToString();

            }
            catch (Exception)
            {
                lblDivThem.Text = "Cannot divide by zero!";
         
            }

            //Output results to page
            lblAddThem.Text = addRes.ToString();
            lblSubThem.Text = subRes.ToString();
            lblMultThem.Text = multRes.ToString();
        }
        catch (Exception)
        {
            lblAddThem.Text = "Please enter numeric values in the textboxes!";
            lblSubThem.Text = "Please enter numeric values in the textboxes!";
            lblMultThem.Text = "Please enter numeric values in the textboxes!";
            lblDivThem.Text = "Please enter numeric values in the textboxes!";
        }

    }

    protected void btnClearAll_Click(object sender, EventArgs e)
    {
        //Declar variables for input and calculations as strings
        string inputA = "";
        string inputB = "";
        string addRes = "";
        string subRes = "";
        string multRes = "";
        string divRes = "";

        //Clear all results on page
        txtInputA.Text = inputA.ToString();
        txtInputB.Text = inputB.ToString();

        lblAddThem.Text = addRes.ToString();
        lblSubThem.Text = subRes.ToString();
        lblMultThem.Text = multRes.ToString();
        lblDivThem.Text = divRes.ToString();
    }
}