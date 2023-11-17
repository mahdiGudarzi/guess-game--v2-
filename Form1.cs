using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using Label = System.Windows.Forms.Label;
namespace guess_game
{

   
    public partial class form1 : Form
    {
        private string pic1,pic2 = default ;
        Dictionary<string, Label> Pic = new Dictionary<string, Label>();
        Label Cheker = default;
        public form1()
        {
            InitializeComponent();

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Path.Combine(baseDirectory, "..", "..");
            string imgFolderPath = Path.Combine(projectDirectory, "img");
            string[] imageFiles = Directory.GetFiles(imgFolderPath, "*.jpg");
            PictureBox[] pictureBoxes ={ pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
            Label[] labels ={label1,label2,label3,label4,label5,label6,label7,label8};
            Random random = new Random();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
              
                string randomImagePath = imageFiles[random.Next(imageFiles.Length)];
                pictureBox.Image = Image.FromFile(randomImagePath);
                pictureBox.Name = Path.GetFileNameWithoutExtension(randomImagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.SendToBack();


            }
            foreach (var label in labels)
            {
                label.Visible = true;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            if (Cheker != (sender as Label))
            {
                Console.WriteLine(sender);
                if (string.IsNullOrEmpty(pic1))
                {
                    this.pic1 = this.pictureBox1.Name;
                    Pic.Add("pic1", (sender as Label));
                    Cheker = (sender as Label);
                    

                }
                else if (string.IsNullOrEmpty(pic2))
                {
                    this.pic2 = this.pictureBox1.Name;
                    Pic.Add("pic2", (sender as Label));
                    Cheker = (sender as Label);
                    
                }
            }
            check();




        }

        private void label2_Click(object sender, EventArgs e)
        {


            if (Cheker != (sender as Label))
            {
                Console.WriteLine(sender);
                if (string.IsNullOrEmpty(pic1))
                {
                    this.pic1 = this.pictureBox2.Name;
                    Pic.Add("pic1", (sender as Label));
                    Cheker = (sender as Label);
                    

                }
                else if (string.IsNullOrEmpty(pic2))
                {
                    this.pic2 = this.pictureBox2.Name;
                    Pic.Add("pic2", (sender as Label));
                    Cheker = (sender as Label);
                    
                }
            }
            check();


        }

        private void label3_Click(object sender, EventArgs e)
        {

            if (Cheker != (sender as Label))
            {
                Console.WriteLine(sender);
                if (string.IsNullOrEmpty(pic1))
                {
                    this.pic1 = this.pictureBox3.Name;
                    Pic.Add("pic1", (sender as Label));
                    Cheker = (sender as Label);
                    

                }
                else if (string.IsNullOrEmpty(pic2))
                {
                    this.pic2 = this.pictureBox3.Name;
                    Pic.Add("pic2", (sender as Label));
                    Cheker = (sender as Label);
                    
                }
            }
            check();


        }

        private void label4_Click(object sender, EventArgs e)
        {

            if (Cheker != (sender as Label))
            {
                Console.WriteLine(sender);
                if (string.IsNullOrEmpty(pic1))
                {
                    this.pic1 = this.pictureBox4.Name;
                    Pic.Add("pic1", (sender as Label));
                    Cheker = (sender as Label);
                    

                }
                else if (string.IsNullOrEmpty(pic2))
                {
                    this.pic2 = this.pictureBox4.Name;
                    Pic.Add("pic2", (sender as Label));
                    Cheker = (sender as Label);
                    
                }
            }
            check();



        }

        private void label5_Click(object sender, EventArgs e)
        {



            if (Cheker != (sender as Label))
            {
                Console.WriteLine(sender);
                if (string.IsNullOrEmpty(pic1))
                {
                    this.pic1 = this.pictureBox5.Name;
                    Pic.Add("pic1", (sender as Label));
                    Cheker = (sender as Label);
                    

                }
                else if (string.IsNullOrEmpty(pic2))
                {
                    this.pic2 = this.pictureBox5.Name;
                    Pic.Add("pic2", (sender as Label));
                    Cheker = (sender as Label);
                    
                }
            }
            check();


        }

        private void label6_Click(object sender, EventArgs e)
        {


            if (Cheker != (sender as Label))
            {
                Console.WriteLine(sender);
                if (string.IsNullOrEmpty(pic1))
                {
                    this.pic1 = this.pictureBox6.Name;
                    Pic.Add("pic1", (sender as Label));
                    Cheker = (sender as Label);
                    

                }
                else if (string.IsNullOrEmpty(pic2))
                {
                    this.pic2 = this.pictureBox6.Name;
                    Pic.Add("pic2", (sender as Label));
                    Cheker = (sender as Label);
                    
                }
            }
            check();


        }

        private void label7_Click(object sender, EventArgs e)
        {


            if (Cheker != (sender as Label))
            {
                Console.WriteLine(sender);
                if (string.IsNullOrEmpty(pic1))
                {
                    this.pic1 = this.pictureBox7.Name;
                    Pic.Add("pic1", (sender as Label));
                    Cheker = (sender as Label);
                    

                }
                else if (string.IsNullOrEmpty(pic2))
                {
                    this.pic2 = this.pictureBox7.Name;
                    Pic.Add("pic2", (sender as Label));
                    Cheker = (sender as Label);
                    
                }
            }
            check();


        }

        private void label8_Click(object sender, EventArgs e)
        {

            if (Cheker != (sender as Label))
            {
                Console.WriteLine(sender);
                if (string.IsNullOrEmpty(pic1))
                {
                    this.pic1 = this.pictureBox8.Name;
                    Pic.Add("pic1", (sender as Label));
                    Cheker = (sender as Label);
                    

                }
                else if (string.IsNullOrEmpty(pic2))
                {
                    this.pic2 = this.pictureBox8.Name;
                    Pic.Add("pic2", (sender as Label));
                    Cheker = (sender as Label);
                    
                }
            }
            check();


        }

        private void check()
        {
            if (!string.IsNullOrEmpty(pic1) && !string.IsNullOrEmpty(pic2))
            {
                if (string.Compare(pic1, pic2) == 0)
                   
                {
                    Label temp;
                    Pic.TryGetValue("pic1", out temp);
                    temp.Visible = false;
                    Pic.TryGetValue("pic2", out temp);
                    temp.Visible = false;
                }

                this.pic1 = default;
                this.pic2 = default;
                this.Pic.Remove("pic1");
                this.Pic.Remove("pic2");
            }
        }

    }
}
