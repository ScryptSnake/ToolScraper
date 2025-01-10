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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            listData = new ListBox();
            pictureBoxKenLogo = new PictureBox();
            tbSearch = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
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
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listData);
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 594);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(480, 513);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(529, 13);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = "Tool Data:";
            // 
            // listData
            // 
            listData.FormattingEnabled = true;
            listData.ItemHeight = 15;
            listData.Location = new Point(529, 37);
            listData.Name = "listData";
            listData.Size = new Size(443, 514);
            listData.TabIndex = 0;
            // 
            // pictureBoxKenLogo
            // 
            pictureBoxKenLogo.BackColor = Color.Transparent;
            pictureBoxKenLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxKenLogo.Image = (Image)resources.GetObject("pictureBoxKenLogo.Image");
            pictureBoxKenLogo.Location = new Point(884, 12);
            pictureBoxKenLogo.Name = "pictureBoxKenLogo";
            pictureBoxKenLogo.Size = new Size(88, 66);
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
        private PictureBox pictureBox1;
        private PictureBox pictureBoxKenLogo;
    }
}
