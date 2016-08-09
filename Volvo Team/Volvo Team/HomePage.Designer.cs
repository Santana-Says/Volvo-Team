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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBoxRecords = new System.Windows.Forms.PictureBox();
            this.picBoxBanner = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBoxInventory = new System.Windows.Forms.PictureBox();
            this.picBoxTrade = new System.Windows.Forms.PictureBox();
            this.picBoxSplash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSplash)).BeginInit();
            this.SuspendLayout();
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picBoxRecords
            // 
            this.picBoxRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxRecords.Image = global::Volvo_Team.Properties.Resources.Button_Employee_Login;
            this.picBoxRecords.Location = new System.Drawing.Point(-3, 38);
            this.picBoxRecords.Name = "picBoxRecords";
            this.picBoxRecords.Size = new System.Drawing.Size(126, 41);
            this.picBoxRecords.TabIndex = 12;
            this.picBoxRecords.TabStop = false;
            this.picBoxRecords.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picBoxBanner
            // 
            this.picBoxBanner.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picBoxBanner.Image = global::Volvo_Team.Properties.Resources.volvo_logo_scaled;
            this.picBoxBanner.Location = new System.Drawing.Point(-3, -1);
            this.picBoxBanner.Name = "picBoxBanner";
            this.picBoxBanner.Size = new System.Drawing.Size(890, 33);
            this.picBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxBanner.TabIndex = 8;
            this.picBoxBanner.TabStop = false;
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
            // picBoxInventory
            // 
            this.picBoxInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxInventory.Image = global::Volvo_Team.Properties.Resources.volvo3;
            this.picBoxInventory.Location = new System.Drawing.Point(439, 310);
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
            this.picBoxTrade.Location = new System.Drawing.Point(-3, 310);
            this.picBoxTrade.Name = "picBoxTrade";
            this.picBoxTrade.Size = new System.Drawing.Size(448, 288);
            this.picBoxTrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTrade.TabIndex = 5;
            this.picBoxTrade.TabStop = false;
            this.picBoxTrade.Click += new System.EventHandler(this.picBoxTrade_Click);
            // 
            // picBoxSplash
            // 
            this.picBoxSplash.Image = global::Volvo_Team.Properties.Resources.Volvo_Splash;
            this.picBoxSplash.InitialImage = null;
            this.picBoxSplash.Location = new System.Drawing.Point(-3, -1);
            this.picBoxSplash.Name = "picBoxSplash";
            this.picBoxSplash.Size = new System.Drawing.Size(890, 599);
            this.picBoxSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSplash.TabIndex = 11;
            this.picBoxSplash.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 597);
            this.Controls.Add(this.picBoxSplash);
            this.Controls.Add(this.picBoxRecords);
            this.Controls.Add(this.picBoxBanner);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxInventory);
            this.Controls.Add(this.picBoxTrade);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBanner;
        private System.Windows.Forms.PictureBox picBoxInventory;
        private System.Windows.Forms.PictureBox picBoxTrade;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxSplash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBoxRecords;
    }
}

