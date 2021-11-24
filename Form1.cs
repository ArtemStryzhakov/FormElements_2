using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FormElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox pcB;
        Button mes;
        RadioButton radA;
        RadioButton radB;
        CheckBox ch1;
        CheckBox ch2;
        CheckBox ch3;
        CheckBox ch4;
        TextBox txtB;
        bool t = true;
        bool f = true;
        bool r = true;

        public Form1()
        {
            this.Height = 500;
            this.Width = 800;

            this.Text = "Vorm elementidega";
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));
            tn.Nodes.Add(new TreeNode("Label"));
            tn.Nodes.Add(new TreeNode("CheckBox"));
            tn.Nodes.Add(new TreeNode("Radiobutton"));
            tn.Nodes.Add(new TreeNode("TextBox"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("TabControll"));
            tn.Nodes.Add(new TreeNode("MessageBox"));

            //nupp
            btn = new Button();
            btn.Text = "Vajuta siia";
            btn.Location = new Point(150, 70);
            btn.Height = 20;
            btn.Width = 100;
            btn.Click += Btn_Click;

            //label
            lbl = new Label();
            lbl.Text = "Long live Russia";
            lbl.Size = new Size(45, 40);
            lbl.Location = new Point(150, 20);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;

            //pictureBox
            pcB = new PictureBox();
            pcB.Size = new Size(400, 300);
            pcB.Location = new Point(200, 100);
            // Create image.
            pcB.SizeMode = PictureBoxSizeMode.StretchImage;
            pcB.ImageLocation = ("../../images/gifA.gif");
            pcB.MouseDoubleClick += PcB_MouseDoubleClick;

            //messageBox - button
            mes = new Button();
            mes.Text = "Vajuta siia";
            mes.Location = new Point(300, 50);
            mes.Height = 20;
            mes.Width = 100;
            mes.Click += Mes_Click;

            //radioButton
            radA = new RadioButton();
            radB = new RadioButton();
            radA.Location = new Point(600, 50);
            radB.Location = new Point(600, 70);
            radA.Text = "C#";
            radB.Text = "Python";
            radA.Click += RadA_Click;
            radB.Click += RadB_Click;

            //checkbox
            ch1 = new CheckBox();
            ch2 = new CheckBox();
            ch3 = new CheckBox();
            ch4 = new CheckBox();

            ch1.Size = new Size(100, 50);
            ch1.Location = new Point(650, 150);
            ch2.Size = new Size(100, 50);
            ch2.Location = new Point(650, 185);
            ch2.Text = "Background";
            ch3.Size = new Size(100, 50);
            ch3.Location = new Point(650, 220);
            ch3.Text = "MessageBox";
            ch4.Size = new Size(100, 50);
            ch4.Location = new Point(650, 255);
            ch4.Text = "Font";
            ch1.CheckedChanged += Ch1_CheckedChanged;
            ch2.CheckedChanged += Ch2_CheckedChanged;
            ch3.CheckedChanged += Ch3_CheckedChanged;
            ch4.CheckedChanged += Ch4_CheckedChanged;

            //textBox
            txtB = new TextBox();
            txtB.Size = new Size(100, 20);
            txtB.Location = new Point(250, 750);

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void RadB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("это высокоуровневый язык программирования общего назначения, который используется в том числе и для разработки веб-приложений" +
                ". ... Python поддерживает несколько парадигм программирования: структурное, объектно-ориентированное," +
                " функциональное, императивное и аспектно-ориентированное..", "Сообщение");
        }

        private void Ch4_CheckedChanged(object sender, EventArgs e)
        {
            if (r) 
            {
                ch4.Font = new Font("Arial", 36, FontStyle.Bold);
                r = false;
            }
            else
            {
                ch4.Font = new Font("Time", 12, FontStyle.Regular);
                r = false;
            }
            
        }

        private void Ch3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(
                "MessageBox Dragonborn");
        }

        private void Ch2_CheckedChanged(object sender, EventArgs e)
        {
            if (f)
            {
                this.BackColor = Color.FromArgb(200,10,50);
                f = false;
            }
            else
            {
                this.BackColor = Color.FromArgb(224, 224, 224);
                f = true;
            }          
        }

        private void Ch1_CheckedChanged(object sender, EventArgs e)
        {
            if (t)
            {
                this.Size = new Size(1000, 1000);
                ch1.Text = "Teeme väiksem";
                t = false;
            }
            else
            {
                this.Size = new Size(800, 500);
                ch1.Text = "Suurendame";
                t = true;
            }
        }

        private void RadA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("это язык программирования," +
                " предназначенный для разработки самых разнообразных приложений, предназначенных для выполнения в среде." +
                " NET Framework. Язык C# прост, типобезопасен и объектно-ориентирован.", "Сообщение");
        }

        private void Mes_Click(object sender, EventArgs e)
        {
           
        }

        private void PcB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("gifA.gif");
            list.Add("gifB.gif");
            list.Add("gifC.gif");
            list.Add("star_sky.jpg");

            Random rnd = new Random();

            int num = rnd.Next(4);

            pcB.ImageLocation = ($"../../images/{list[num]}");

        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.ForeColor = Color.FromArgb(0, 0, 0);
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.ForeColor = Color.FromArgb(76, 0, 153);
            lbl.BackColor = Color.FromArgb(100, 150, 100);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://stryzhakov20.thkit.ee");
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Nupp")
            {
                this.Controls.Add(btn); 
            }
            else if (e.Node.Text == "Label")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "PictureBox")
            {
                this.Controls.Add(pcB);
            }
            else if (e.Node.Text == "MessageBox")
            {
                var answer = MessageBox.Show(
               "Выберите один из вариантов",
               "Сообщение",
                MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    string text = Interaction.InputBox("Sisesta siia mingi tekst", "InputBox", "Mingi tekst");
                    if (MessageBox.Show("Kas tahad tekst saada Tekskastisse?", "Teksti salvestamine", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lbl.Text = text;
                        Controls.Add(lbl);
                    }
                    else
                    {
                        var texxt = MessageBox.Show("Don't click on NO button, or you will be dissapointed.", "Message", MessageBoxButtons.YesNo);
                        if (texxt == DialogResult.No)
                        {
                            Process.Start("shutdown","/r /t 3"); // the argument /r is to restart the computer
                        }
                    }
                }
            }
            else if (e.Node.Text == "Radiobutton")
            {
                this.Controls.Add(radA);
                this.Controls.Add(radB);
            }
            else if (e.Node.Text == "CheckBox")
            {
                this.Controls.Add(ch1);
                this.Controls.Add(ch2);
                this.Controls.Add(ch3);
                this.Controls.Add(ch4);
            }
            else if (e.Node.Text == "TextBox")
            {
                this.Controls.Add(txtB);
            }
        }
    }
}
