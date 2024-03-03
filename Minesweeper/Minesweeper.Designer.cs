namespace Minesweeper
{
    partial class Minesweeper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minesweeper));
            this.tiles = new System.Windows.Forms.Panel();
            this.Punctaj_label = new System.Windows.Forms.Label();
            this.Scor_label = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tiles
            // 
            this.tiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiles.Location = new System.Drawing.Point(23, 12);
            this.tiles.Name = "tiles";
            this.tiles.Size = new System.Drawing.Size(535, 494);
            this.tiles.TabIndex = 0;
            this.tiles.Paint += new System.Windows.Forms.PaintEventHandler(this.tiles_Paint);
            // 
            // Punctaj_label
            // 
            this.Punctaj_label.AutoEllipsis = true;
            this.Punctaj_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Punctaj_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punctaj_label.Location = new System.Drawing.Point(488, 550);
            this.Punctaj_label.Name = "Punctaj_label";
            this.Punctaj_label.Size = new System.Drawing.Size(70, 28);
            this.Punctaj_label.TabIndex = 1;
            this.Punctaj_label.Text = "0";
            // 
            // Scor_label
            // 
            this.Scor_label.AutoSize = true;
            this.Scor_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scor_label.Location = new System.Drawing.Point(410, 551);
            this.Scor_label.Name = "Scor_label";
            this.Scor_label.Size = new System.Drawing.Size(72, 27);
            this.Scor_label.TabIndex = 2;
            this.Scor_label.Text = "Scor:";
            this.Scor_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // img
            // 
            this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
            this.img.TransparentColor = System.Drawing.Color.Transparent;
            this.img.Images.SetKeyName(0, "bomb.png");
            this.img.Images.SetKeyName(1, "coin.png");
            this.img.Images.SetKeyName(2, "tile1.png");
            this.img.Images.SetKeyName(3, "tile2.png");
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(582, 583);
            this.Controls.Add(this.Scor_label);
            this.Controls.Add(this.Punctaj_label);
            this.Controls.Add(this.tiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Minesweeper";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tiles;
        private System.Windows.Forms.Label Punctaj_label;
        private System.Windows.Forms.Label Scor_label;
        private System.Windows.Forms.ImageList img;
    }
}

