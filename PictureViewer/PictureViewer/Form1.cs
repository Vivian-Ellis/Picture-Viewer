/* 
 * Vivian Ellis final project
 * CSCD 371 Picture Viewer
 * Summer 2017
 * 
 * This program lets a user specify a directory
 * or a list of pictures from the web
 * if not pictures exist in directory nothing will be displayed
 * similarly if no pictures exist on web URL an 'X' image will be
 * displayed letting user know that the URL does not contain an image
 * 
 * the last picture appears for double time and then the cycle starts
 * over again. There is no transition between pictures.
 * 
 * A file 'pictures' includes 5 pictures of type .gif,.bmp, and .jpg 
 *
 * A text file includes random pictures from the web. Copy paste to
 * test. Use keyboard short cut to paste into the rich text box 'webURL'.
 * Make sure to enter after each entry.
 * 
 * The form adjusts to picture size, however if the picture is 
 * bigger than the users screen you can move the form to view
 * the rest of the picture, no scroll bar will be included.
 * 
 * see Help -> About for more specifications on how to run the program
 */


using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        //where the user wants to grab the pictures from
        private string path = "";

        //all the pictures in that path
        private string[] pictures;

        //i just tells us which picture we are currently looking at
        private int i = 0;

        //is user searching the web?
        private bool isWebSearch = false;

        public Form1()
        {
            InitializeComponent();
            toolStripStatusCurrentDirectory.Text = "";
            timer.Interval= (int)setTimerInterval.Value*1000;
            webTimer.Interval = (int)setTimerInterval.Value * 1000;

            //have to select which method to search by before begining
            WebSearchButton.Visible = false;
            pause.Visible = false;
            pauseToolStripMenuItem.Enabled = false;
            SearchDirectory.Visible = false;
            webURL.Visible = false;
            setTimerInterval.Enabled = false;
        }

        //user wants to look for a directory
        private void SearchDirectory_Click(object sender, EventArgs e)
        {
            isWebSearch = false;
            pause.Enabled = true;
            pauseToolStripMenuItem.Enabled = true;
            //the three types of images we will look for
            string[] jpg;
            string[] gif;
            string[] bmp;

            //start from the beginning
            i = 0;

            FolderBrowserDialog directory = new FolderBrowserDialog();
            if (directory.ShowDialog() == DialogResult.OK)
            {
                //grab the directory
                path = directory.SelectedPath;
                toolStripStatusCurrentDirectory.Text = path;

                jpg = System.IO.Directory.GetFiles(path, "*.jpg");
                gif = System.IO.Directory.GetFiles(path, "*.gif");
                bmp = System.IO.Directory.GetFiles(path, "*.bmp");

                //merge them together...
                pictures = jpg.Concat(gif.Concat(bmp).ToArray()).ToArray();

                //there is nothing to look at
                if (pictures.Length == 0) return;

                //show the first picture right away
                Image image = Image.FromFile(pictures[0]);
                pictureViewer.Image = image;

                //move to the next picture
                i++;

                //start the timer
                timer.Enabled = true;
                timer.Start();

            }//end if
        }//end SearchDirectory_Click

        private void timer_Tick(object sender, EventArgs e)
        {
            //we will cycle through the pictures until the user says stop
            if (i < pictures.Length)
            {
                Image image = Image.FromFile(pictures[i]);
                pictureViewer.Width = image.Width;
                pictureViewer.Height = image.Height;
                pictureViewer.Image = image;
                i++;
            }
            else
                i = 0;
        }//end timer_Tick

        //pause the slide show
        private void stopTimer_Click(object sender, EventArgs e)
        {
            pause.Enabled = false;
            pauseToolStripMenuItem.Enabled = false;

            if (isWebSearch == true)
            {
                webTimer.Enabled = false;
                webTimer.Stop();
            }
            else
            {
                timer.Enabled = false;
                timer.Stop();
            }
        }//end stopTimer_Click

        //view pictures from the web
        private void WebSearchButton_Click(object sender, EventArgs e)
        {
            //user didnt input anything
            if (webURL.Lines.Length == 0) return;

            i = 0;
            pause.Enabled = true;
            pauseToolStripMenuItem.Enabled = true;

            //display first image right away
            pictureViewer.ImageLocation = webURL.Lines[i];
            toolStripStatusCurrentDirectory.Text = webURL.Lines[i];

            //move to the next picture
            i++;

            //start the webTimer
            webTimer.Enabled = true;
            webTimer.Start();
        }//end WebSearchButton_Click

        //private void Transition(Image image)
        //{
        //    Graphics g = Graphics.FromImage(image);
       //}

        private void setTimerInterval_ValueChanged(object sender, EventArgs e)
        {
            webTimer.Interval = (int)setTimerInterval.Value * 1000;
            timer.Interval = (int)setTimerInterval.Value * 1000;
        }//end setTimerInterval_ValueChanged

        //user wants to search their computer
        private void imagesFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webTimer.Enabled = false;
            webTimer.Stop();
            webURL.Text = "";
            WebSearchButton.Visible = false;

            pause.Visible = true;
            pause.Enabled = false;
            pauseToolStripMenuItem.Enabled = false;

            timer.Enabled = false;
            timer.Stop();
            SearchDirectory.Visible = true;
            webURL.Visible = false;
            setTimerInterval.Enabled = true;
            pictureViewer.Image = null;
        }//end imagesFromFileToolStrinpMenuItem_Click

        //user wants to search the web
        private void webImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //searching the web
            isWebSearch = true;

            timer.Enabled = false;
            timer.Stop();
            WebSearchButton.Visible = true;
            pause.Visible = true;
            pause.Enabled = false;
            pauseToolStripMenuItem.Enabled = false;

            webTimer.Enabled = false;
            webTimer.Stop();
            SearchDirectory.Visible = false;
            webURL.Visible = true;
            setTimerInterval.Enabled = true;
            pictureViewer.Image = null;
            webURL.Text = "";
        }//end webImageToolStripMenuItem_Click

        private void webTimer_Tick(object sender, EventArgs e)
        {
            foreach(string s in webURL.Lines)
            {
                if (i < webURL.Lines.Length)
                {
                    pictureViewer.ImageLocation = webURL.Lines[i];
                    toolStripStatusCurrentDirectory.Text = webURL.Lines[i];

                    //move to the next picture
                    i++;
                }//end if
                else
                    i = 0;
            }//end foreach
        }//end webTimer_Tick

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer viv\nversion 1.0\nPlatform target: any CPU - Preferred 32-bit\nTarget framework: .NET Framework 4.5.2");
        }//end about

        //show to 'rules'
        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Welcome to Picture Viewer!\n\nIn this program you will first select where you would like to view pictures(via web URL or file).\nUser must select either option from the 'Options' menu.\n         If the user selects 'Images From Web' a text box appears and allows the user to enter the web address of a picture. Hit enter after each URL and leave no double spacing\n          If the user chooses 'Images From File' a 'Search Directory' button will appear letting the user chose from their computer. All pictures of type .jpg, .gif, and .bmp will be displayed\nAt anytime the timer may be set between 1 - 60 seconds. The default viewing time is 5 seconds.");
        }//end rules

        //clears all pictures currently showing
        private void ClearAll(object sender, EventArgs e)
        {
            toolStripStatusCurrentDirectory.Text = "";
            webURL.Text = "";

            //reset everything to beginning
            WebSearchButton.Visible = false;
            pause.Visible = false;
            pauseToolStripMenuItem.Enabled = false;
            SearchDirectory.Visible = false;
            webURL.Visible = false;
            setTimerInterval.Enabled = false;

            setTimerInterval.Value = 5;
            webTimer.Interval = 5000;
            timer.Interval = 5000;

            timer.Enabled = false;
            timer.Stop();

            webTimer.Enabled = false;
            webTimer.Stop();

            pictureViewer.Image = null;
        }//end ClearAll
    }//end form class
}//end name space PictureViewer
