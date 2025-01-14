namespace WinformsDemoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bSearch = new Button();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label1 = new Label();
            listData = new ListBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBoxKenLogo = new PictureBox();
            tbSearch = new TextBox();
            label2 = new Label();
            lbError = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKenLogo).BeginInit();
            SuspendLayout();
            // 
            // bSearch
            // 
            bSearch.BackColor = SystemColors.ControlDarkDark;
            bSearch.FlatStyle = FlatStyle.Popup;
            bSearch.ForeColor = SystemColors.ButtonFace;
            bSearch.Location = new Point(311, 26);
            bSearch.Name = "bSearch";
            bSearch.Size = new Size(142, 32);
            bSearch.TabIndex = 0;
            bSearch.Text = "Search";
            bSearch.UseVisualStyleBackColor = false;
            bSearch.Click += bSearch_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listData);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 794);
            panel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(546, 48);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(29, 13);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 3;
            label3.Text = "Image(s):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(529, 13);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = "Tool Data:";
            // 
            // listData
            // 
            listData.BackColor = Color.FromArgb(255, 255, 150);
            listData.FormattingEnabled = true;
            listData.ItemHeight = 15;
            listData.Location = new Point(529, 82);
            listData.Name = "listData";
            listData.Size = new Size(443, 529);
            listData.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(29, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 586);
            panel2.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Location = new Point(248, 343);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(227, 210);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(14, 343);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(227, 210);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(14, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(456, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxKenLogo
            // 
            pictureBoxKenLogo.BackColor = Color.Transparent;
            pictureBoxKenLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxKenLogo.Image = (Image)resources.GetObject("pictureBoxKenLogo.Image");
            pictureBoxKenLogo.Location = new Point(884, 12);
            pictureBoxKenLogo.Name = "pictureBoxKenLogo";
            pictureBoxKenLogo.Size = new Size(88, 66);
            pictureBoxKenLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxKenLogo.TabIndex = 4;
            pictureBoxKenLogo.TabStop = false;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(84, 26);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(221, 29);
            tbSearch.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 30);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 3;
            label2.Text = "KMT#:";
            // 
            // lbError
            // 
            lbError.BackColor = Color.Transparent;
            lbError.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbError.ForeColor = Color.Firebrick;
            lbError.Location = new Point(476, 9);
            lbError.Name = "lbError";
            lbError.Size = new Size(402, 72);
            lbError.TabIndex = 5;
            lbError.Text = "Image(s):";
            lbError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Goldenrod;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 761);
            Controls.Add(pictureBoxKenLogo);
            Controls.Add(lbError);
            Controls.Add(label2);
            Controls.Add(tbSearch);
            Controls.Add(panel1);
            Controls.Add(bSearch);
            DoubleBuffered = true;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 800);
            Name = "Form1";
            Text = "Kennametal EndMill Scraper V1.0";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKenLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSearch;
        private Panel panel1;
        private TextBox tbSearch;
        private Label label1;
        private ListBox listData;
        private Label label2;
        private PictureBox pictureBoxKenLogo;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label lbError;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
