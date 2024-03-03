using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Minesweeper : Form
    {

        int Score = 0;
        PictureBox[] tile_block = new PictureBox[100];
        public Minesweeper()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_tiles();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void tiles_Paint(object sender, PaintEventArgs e)
        {

        }


        private void load_tiles()
        {
            

            int x = 0;
            int y = 0;
            int k = 0;
            int t=0;
            int tileControl = 0;

            Random rand = new Random();
            for(int i=0;i<100;i++)
            {
                int ran=rand.Next(0,2);

                tile_block[i]= new PictureBox();
                tile_block[i].Height = 40;
                tile_block[i].Width = 40;
                tile_block[i].Left = x;
                tile_block[i].Top = y;
                tile_block[i].BorderStyle = BorderStyle.FixedSingle;
                

                tile_block[i].SizeMode = PictureBoxSizeMode.StretchImage;
                tile_block[i].Click += new System.EventHandler(ClickTile);

                //tile[i].Image = img.Images[ran];
                if(ran==0)
                {
                    tile_block[i].Tag = "Bomb";
                }
                else
                {
                    tile_block[i].Tag = "Money";
                }

                tiles.Controls.Add(tile_block[i]);
                x = x + 40;
                k++;

                if((t+tileControl)%2==0)
                {
                    tile_block[i].Image = img.Images[2];
                    t++;
                }
                else 
                {
                    tile_block[i].Image = img.Images[3];
                    t++;
                }
                
               
                

                if(k==10)
                {
                    x = 0;
                    y = y + 40;
                    k = 0;
                    tileControl++;
                }
            }
        }

        private void ClickTile(Object sender, System.EventArgs e)
        {
            DialogResult ans;
            PictureBox tile = (PictureBox)sender;
            if(tile.Tag.ToString() !="Clicked")
            {
                if (tile.Tag.ToString() == "Bomb")
                {
                    tile.Image = img.Images[0];
                    ans = MessageBox.Show("Game Over :( , Your score: " + Score.ToString() + "\nPlay Again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        Score = 0;
                        Punctaj_label.Text = "0";
                        foreach (PictureBox pictureBox in tile_block)
                        {
                            tiles.Controls.Remove(pictureBox);
                        }
                        load_tiles();

                    }
                    else
                    {   
                        Application.Exit();
                    }
                }
                else if (tile.Tag.ToString() == "Money")
                {
                    tile.Image = img.Images[1];
                    tile.Tag = "Clicked";
                    Score += 5;
                    Punctaj_label.Text = Score.ToString();

                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
