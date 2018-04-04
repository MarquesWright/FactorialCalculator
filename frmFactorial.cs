using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{    
    public partial class Form1 : Form    
    {        
          public Form1()        
          {            
                InitializeComponent();        
          }
          
          private void btnCalculate_Click(object sender, EventArgs e)        
          {            
              // get input from user and intialize variables            
              int number = Convert.ToInt32(txtNumber.Text);            
              long factorial = 1;                        
              
              // for loop to calculate the factorial            
              for (int i = number; i >= 1; i--)            
              {                
                  factorial = factorial * i;            
              }
              
              // return results to the factorial textbox            
              txtFactorial.Text = factorial.ToString("n0");            
              txtNumber.Focus();
          }
          
          private void btnExit_Click(object sender, EventArgs e)        
          {            
              // closes application            
              this.Close();        
          }    
    }
}
