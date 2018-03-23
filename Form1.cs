using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//Alex Detherow
namespace BannoUI

{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            //hide title
            titlePanel.Visible = false;
            //show information
            infoPanel.Visible = true;
            //create a new http client
            ClientClass rClient = new ClientClass();
            //set the url endpoint
            rClient.endPoint = "https://banno.com/";

            string strResponse = string.Empty;
            //store html code
            strResponse = rClient.Request();
            //count alphanumerics
            CharStringBreakDown(strResponse);
            //count png photos
            PNGCount(strResponse);
            //count financial institution occurences
            FinancialInstCount(strResponse);
            //show the twitter handler
            TwitterHandlerPrint(strResponse);
            //do the same for features page
            ClientClass sClient = new ClientClass();
            sClient.endPoint = "https://banno.com/features";
            string strResponseFeatures = string.Empty;
            strResponseFeatures = sClient.Request();
            //count all features by border separation
            ProductCount(strResponseFeatures);
            

        }
        private  void CharStringBreakDown(string httpString)
        {
            int arrayCount = 0;
            int count = httpString.Count(char.IsLetterOrDigit);
            char[] alphaNumArray = new char[count];
            string labelText = "Char  Count";

            foreach (char element in httpString)
            {

                if (char.IsLetterOrDigit(element))
                {


                    alphaNumArray[arrayCount] = element;
                    arrayCount++;
                }

            }
            CharStat charStat = new CharStat(alphaNumArray);
            char[] trimList = charStat.DuplicateStatSort();
            int[] countNumArray = charStat.CountStatSort();
            charCountLabel.Text = labelText;

            for (int i = 0; i < 3; i++)
            {
                string charLabel = trimList[i].ToString();
                string numLabel = countNumArray[i].ToString();
                charCountLabel.Text += "\n" + charLabel + " = " + numLabel;
            }
            charCountLabel.Text += "\nCharacter Count = " + charStat.DuplicatedTrimLength().ToString();
            charCountLabel.Text += "\nTotal Alphnumerics = " + charStat.CharStatLength();

            
        }
        private void PNGCount(string httpString)
        {
            string labelOutput = " ";
            labelOutput = (Regex.Matches(httpString, ".png").Count).ToString();
            pngCountLabel.Text = labelOutput;
        }
        private void FinancialInstCount(string httpString)
        {
            string labelOutput = " ";
            labelOutput = (Regex.Matches(httpString, "financial institutions").Count).ToString();
            finInstCountLabel.Text = labelOutput;
        }
        private void TwitterHandlerPrint(string httpString)
        {
            string pattern = ".*Twitter.*";
            Regex r = new Regex(pattern);
            foreach (Match m in r.Matches(httpString))
            {
                twitterHandleLabel.Text += m.Value;
            }
        }
        private void ProductCount(string httpString)
        {
            string labelOutput = " ";
            labelOutput = (Regex.Matches(httpString, "flex-item.feature-group-label").Count).ToString();
            productCountLabel.Text = labelOutput;
        }


    }
}
