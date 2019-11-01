using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace PingProject
{
    public partial class PingApp : Form
    {
        //INITIALIZES THE PINGCOUNTER AND THE STRING FOR THE LOG INFORMATION:
        private int pingCounter = 0;
        private string log = "";
        private Boolean startBool = true;

        //FILE VARIABLES:
        private StreamWriter saveLogFile;

        public PingApp()
        {
            InitializeComponent();
        }

        //THIS SETS THE BASE FREQUENCY TIMER WHEN THE FORM LOADS.
        private void PingApp_Load(object sender, EventArgs e)
        {
            freqTimer.Interval = 1;
        }

        //THIS BASICALLY JUST CONTROLS WHAT THE USER SEES. ADJUSTS THE FREQUENCY LABEL TO THE FREQUENCY VALUE.
        private void frequencyTrackBar_Scroll(object sender, EventArgs e)
        {
            frequencyLabel.Text = "Frequency(" + frequencyTrackBar.Value.ToString() + ") sec";
            if (frequencyTrackBar.Value >= 60)
            {
                frequencyLabel.Text = "Frequency(1) min";
            }
            //freqTimer.Interval = frequencyTrackBar.Value * 1000;
        }

        //STARTS THE PINGING PROCESS, DISABLES A FEW CRUCIAL FEATURES,
        //SETS THE TIMER INTERVAL TO THE TRACKBAR VALUE, THEN STARTS UP THE PINGSTART() METHOD.
        private void startButton_Click(object sender, EventArgs e)
        {
            if (startBool)
            {
                frequencyTrackBar.Enabled = false;
                ipBox.Enabled = false;
                clearLogButton.Enabled = false;
                saveLogButton.Enabled = false;
                pingStart();
                freqTimer.Interval = frequencyTrackBar.Value * 1000;
                freqTimer.Start();
                startButton.Text = "STOP";
                startBool = false;


                //CASE STRUCTURE FOR THE EASTER EGG AND THE SOFTWARE CREDITS.
                switch (ipBox.Text.ToLower())
                {

                    case "3.14159":
                        MessageBox.Show("She's MY number π!", "( ͡° ͜ʖ ͡°)", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                        break;
                    case "credits":
                        MessageBox.Show("Manufacturer: Dakota Shapiro Software" + Environment.NewLine +
                                        "Programmer: Dakota Shapiro" + Environment.NewLine +
                                        "Publisher: Dakota Shapiro Publishing", "Software Credits", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        break;

                }

            }
            else
            {
                freqTimer.Stop();
                freqTimer.Equals(0);

                customActiveLabel.ForeColor = System.Drawing.Color.White;
                customActiveLabel.Text = "(Inactive)";

                googleActiveLabel.ForeColor = System.Drawing.Color.White;
                googleActiveLabel.Text = "(Inactive)";

                usaActiveLabel.ForeColor = System.Drawing.Color.White;
                usaActiveLabel.Text = "(Inactive)";

                frequencyTrackBar.Enabled = true;
                ipBox.Enabled = true;
                clearLogButton.Enabled = true;
                saveLogButton.Enabled = true;

                pingCounter = 0;
                pingCount.Text = "-- pings(s)";
                startButton.Text = "START";
                startBool = true;
            }
        }

        //THIS STARTS THE PINGSTART() METHOD AT EACH INTERVAL TICK.
        private void repetition(object sender, EventArgs e)
        {
            pingStart();
        }

        //PINGS THE THREE SITES, THEN TESTS TO MAKE SURE THE CONNECTION IS STABLE.
        private void pingStart()
        {
            DateTime now = DateTime.Now;
            Ping ping = new Ping();
            if (ipBox.Text != "")
            {
                try
                {
                    PingReply ip = ping.Send(ipBox.Text.ToString(), 1000);
                    if (ip.Status.ToString() == "Success")
                    {
                        customActiveLabel.ForeColor = System.Drawing.Color.Green;
                        customActiveLabel.Text = "Success";
                    }
                    else
                    {
                        customActiveLabel.ForeColor = System.Drawing.Color.Red;
                        customActiveLabel.Text = "Failed";
                    }
                }
                catch
                {
                    customActiveLabel.ForeColor = System.Drawing.Color.Red;
                    customActiveLabel.Text = "Failed";
                }
            }

            try
            {
                PingReply google = ping.Send("google.com", 1000);
                PingReply usa = ping.Send("yahoo.com", 1000);

                if (google.Status.ToString() == "Success")
                {
                    googleActiveLabel.ForeColor = System.Drawing.Color.Green;
                    googleActiveLabel.Text = "Success";
                }
                else
                {
                    googleActiveLabel.ForeColor = System.Drawing.Color.Red;
                    googleActiveLabel.Text = "Failed";
                }
                if (usa.Status.ToString() == "Success")
                {
                    usaActiveLabel.ForeColor = System.Drawing.Color.Green;
                    usaActiveLabel.Text = "Success";
                }
                else
                {
                    usaActiveLabel.ForeColor = System.Drawing.Color.Red;
                    usaActiveLabel.Text = "Failed";
                }
            }
            catch
            {
                googleActiveLabel.ForeColor = System.Drawing.Color.Red;
                googleActiveLabel.Text = "Failed";

                usaActiveLabel.ForeColor = System.Drawing.Color.Red;
                usaActiveLabel.Text = "Failed";
            }
            pingCounter++;
            pingCount.Text = pingCounter.ToString() + " ping(s)";
            log = now + " -- Ping# " + pingCounter + ": Ip: " + customActiveLabel.Text + " Google.com: " + googleActiveLabel.Text +
                " Yahoo.com: " + usaActiveLabel.Text;
            //logBox.Text = log;
            logListBox.Items.Add(log);
        }

        //THIS STOPS THE TIMER, SETS IT TO ZERO, REVERTS EVERYTHING BACK TO INACTIVE, ENABLES CRUCIAL
        //FEATURES, THEN SETS THE PINGCOUNTER BACK TO ZERO AND SETS THE TEXT BACK TO DEFAULT.
        private void stopButton_Click(object sender, EventArgs e) //THIS CODE WAS REPURPOSED TO IMPROVE THE START
                                                                  //BUTTON.
        {
            //freqTimer.Stop();
            //freqTimer.Equals(0);

            //customActiveLabel.ForeColor = System.Drawing.Color.White;
            //customActiveLabel.Text = "(Inactive)";

            //googleActiveLabel.ForeColor = System.Drawing.Color.White;
            //googleActiveLabel.Text = "(Inactive)";

            //usaActiveLabel.ForeColor = System.Drawing.Color.White;
            //usaActiveLabel.Text = "(Inactive)";

            //frequencyTrackBar.Enabled = true;
            //ipBox.Enabled = true;
            //clearLogButton.Enabled = true;

            //pingCounter = 0;
            //pingCount.Text = "-- pings(s)";




        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            //logBox.Text = "";
            logListBox.Items.Clear();
            log = "";
        }

        //THIS MODULE ALLOWS FOR THE CREATION OF A TEXT FILE.  IT TRANSLATE ALL THE LISTBOX INFORMATION
        //INTO A SINGLE STRING, THEN SLAPS IT INTO A FILE.
        private void FileCreate()
        {
            //SETS THE PROPERTIES FOR THE SAVE FILE DIALOG BOX
            saveFileDialog1.FileName = "*.txt";
            saveFileDialog1.Filter = "textFile|*.txt|docFile|.docx";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath( //THIS IS THE CODE FOR A DESKTOP DIRECTORY.
                             System.Environment.SpecialFolder.DesktopDirectory);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //TESTS TO SEE IF THE USER SELECTED 'SAVE.'
            {
                saveLogFile = File.CreateText(saveFileDialog1.FileName); //SETS THE FILE DIRECTORY.

                string fileString = "--Receipt for Ping Log--" + Environment.NewLine + Environment.NewLine;


                for (int i = 0; i < logListBox.Items.Count; i++)
                { //THIS IS THE FOR LOOP THAT PUTS THE LISTBOX INFO
                    fileString += logListBox.Items[i] + Environment.NewLine; //INTO A SINGLE STRING.
                }
                fileString += Environment.NewLine + "--End of Receipt--";

                saveLogFile.WriteLine(fileString); //WRITES TO THE SELECTED FILE.

                saveLogFile.Close(); //CLOSES THE FILE.
            }

        }

        private void saveLogButton_Click(object sender, EventArgs e)
        {
            FileCreate(); //CALLS THE MODULE THAT CREATES THE FILE
        }
        
        //WHEN THE LINK LABEL IS CLICKED ON, IT RUNS THE VISITLINK() MODULE.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            VisitLink();

        }

        //THIS MODULE TESTS TO SEE IF IT CAN OPEN THE WEBPAGE.  IF THE TEST FAILS, THEN IT PROMPTS THE USER
        //WITH A MESSAGE BOX THAT GIVES AN ERROR DESCRIPTION, AND ASKS IF THEY WOULD LIKE TO TRY AGAIN.
        private void VisitLink()
        {
            try
            {
                linkLabel1.LinkVisited = true;

                System.Diagnostics.Process.Start("https://goo.gl/forms/tjHHyfQwjCA8xaUf1");
            }
            catch (Exception err)
            {
                if (MessageBox.Show("Error: " + err.Message, "Link Error", MessageBoxButtons.RetryCancel,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button2) == DialogResult.Retry)
                {
                    VisitLink();
                }

            }
        }
    }
}
