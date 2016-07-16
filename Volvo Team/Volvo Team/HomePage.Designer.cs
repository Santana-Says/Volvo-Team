namespace Volvo_Team
{
    partial class HomePage
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picBoxInventory = new System.Windows.Forms.PictureBox();
            this.picBoxTrade = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox4.Image = global::Volvo_Team.Properties.Resources.volvo_logo_scaled;
            this.pictureBox4.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(890, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // picBoxInventory
            // 
            this.picBoxInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxInventory.Image = global::Volvo_Team.Properties.Resources.volvo3;
            this.picBoxInventory.Location = new System.Drawing.Point(439, 320);
            this.picBoxInventory.Name = "picBoxInventory";
            this.picBoxInventory.Size = new System.Drawing.Size(448, 288);
            this.picBoxInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxInventory.TabIndex = 7;
            this.picBoxInventory.TabStop = false;
            this.picBoxInventory.Click += new System.EventHandler(this.picBoxInventory_Click);
            // 
            // picBoxTrade
            // 
            this.picBoxTrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxTrade.Image = global::Volvo_Team.Properties.Resources.volvo1;
            this.picBoxTrade.Location = new System.Drawing.Point(-3, 320);
            this.picBoxTrade.Name = "picBoxTrade";
            this.picBoxTrade.Size = new System.Drawing.Size(448, 288);
            this.picBoxTrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTrade.TabIndex = 5;
            this.picBoxTrade.TabStop = false;
            this.picBoxTrade.Click += new System.EventHandler(this.picBoxTrade_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Volvo_Team.Properties.Resources.volvo2;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(890, 304);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 60);
            this.label1.TabIndex = 9;
            this.label1.Text = "VIEW OUR INVENTORY";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 60);
            this.label2.TabIndex = 10;
            this.label2.Text = "TRADE-IN EVENT";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.picBoxInventory);
            this.Controls.Add(this.picBoxTrade);
            this.Controls.Add(this.pictureBox2);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picBoxInventory;
        private System.Windows.Forms.PictureBox picBoxTrade;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

