namespace TEW_Worker_Image_Consolidation
{
    partial class Form1
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
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBackground = new System.Windows.Forms.TextBox();
            this.btnConsolidate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkJpgToJpgResize = new System.Windows.Forms.CheckBox();
            this.chkJpgToJpg = new System.Windows.Forms.CheckBox();
            this.chkJpgToGif = new System.Windows.Forms.CheckBox();
            this.chkJpgToGifResize = new System.Windows.Forms.CheckBox();
            this.cmbWhichJpg = new System.Windows.Forms.ComboBox();
            this.cmbWhichPng = new System.Windows.Forms.ComboBox();
            this.chkPngToGif = new System.Windows.Forms.CheckBox();
            this.chkPngToGifBG = new System.Windows.Forms.CheckBox();
            this.chkPngToGifResize = new System.Windows.Forms.CheckBox();
            this.chkPngToJpg = new System.Windows.Forms.CheckBox();
            this.chkPngToJpgResize = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkPngToJpgBG = new System.Windows.Forms.CheckBox();
            this.chkJpgToGifBG = new System.Windows.Forms.CheckBox();
            this.chkGifToJpgBG = new System.Windows.Forms.CheckBox();
            this.cmbWhichGif = new System.Windows.Forms.ComboBox();
            this.chkGifToGif = new System.Windows.Forms.CheckBox();
            this.chkGifToGifBG = new System.Windows.Forms.CheckBox();
            this.chkGifToGifResize = new System.Windows.Forms.CheckBox();
            this.chkGifToJpg = new System.Windows.Forms.CheckBox();
            this.chkGifToJpgResize = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(112, 12);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(429, 20);
            this.txtRoot.TabIndex = 0;
            this.txtRoot.Text = "D:\\Google Drive\\TEW Portraits\\C-Verse Renders\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image Root Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Background Image";
            // 
            // txtBackground
            // 
            this.txtBackground.Location = new System.Drawing.Point(112, 38);
            this.txtBackground.Name = "txtBackground";
            this.txtBackground.Size = new System.Drawing.Size(429, 20);
            this.txtBackground.TabIndex = 2;
            this.txtBackground.Text = "D:\\Google Drive\\TEW Portraits\\CVerseBackground.jpg";
            // 
            // btnConsolidate
            // 
            this.btnConsolidate.Location = new System.Drawing.Point(562, 36);
            this.btnConsolidate.Name = "btnConsolidate";
            this.btnConsolidate.Size = new System.Drawing.Size(75, 23);
            this.btnConsolidate.TabIndex = 7;
            this.btnConsolidate.Text = "Consolidate!";
            this.btnConsolidate.UseVisualStyleBackColor = true;
            this.btnConsolidate.Click += new System.EventHandler(this.btnConsolidate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destination Folder";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(112, 64);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(429, 20);
            this.txtDestination.TabIndex = 8;
            this.txtDestination.Text = "D:\\Google Drive\\TEW Portraits\\Consolidated\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "jpg/jpeg";
            // 
            // chkJpgToJpgResize
            // 
            this.chkJpgToJpgResize.AutoSize = true;
            this.chkJpgToJpgResize.Checked = true;
            this.chkJpgToJpgResize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJpgToJpgResize.Location = new System.Drawing.Point(228, 96);
            this.chkJpgToJpgResize.Name = "chkJpgToJpgResize";
            this.chkJpgToJpgResize.Size = new System.Drawing.Size(100, 17);
            this.chkJpgToJpgResize.TabIndex = 13;
            this.chkJpgToJpgResize.Text = "Resize Squares";
            this.chkJpgToJpgResize.UseVisualStyleBackColor = true;
            // 
            // chkJpgToJpg
            // 
            this.chkJpgToJpg.AutoSize = true;
            this.chkJpgToJpg.Checked = true;
            this.chkJpgToJpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJpgToJpg.Location = new System.Drawing.Point(143, 96);
            this.chkJpgToJpg.Name = "chkJpgToJpg";
            this.chkJpgToJpg.Size = new System.Drawing.Size(82, 17);
            this.chkJpgToJpg.TabIndex = 15;
            this.chkJpgToJpg.Text = "Copy to .jpg";
            this.chkJpgToJpg.UseVisualStyleBackColor = true;
            this.chkJpgToJpg.CheckedChanged += new System.EventHandler(this.chkJpgToJpg_CheckedChanged);
            // 
            // chkJpgToGif
            // 
            this.chkJpgToGif.AutoSize = true;
            this.chkJpgToGif.Checked = true;
            this.chkJpgToGif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJpgToGif.Location = new System.Drawing.Point(143, 119);
            this.chkJpgToGif.Name = "chkJpgToGif";
            this.chkJpgToGif.Size = new System.Drawing.Size(79, 17);
            this.chkJpgToGif.TabIndex = 18;
            this.chkJpgToGif.Text = "Copy to .gif";
            this.chkJpgToGif.UseVisualStyleBackColor = true;
            this.chkJpgToGif.CheckedChanged += new System.EventHandler(this.chkJpgToGif_CheckedChanged);
            // 
            // chkJpgToGifResize
            // 
            this.chkJpgToGifResize.AutoSize = true;
            this.chkJpgToGifResize.Checked = true;
            this.chkJpgToGifResize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJpgToGifResize.Location = new System.Drawing.Point(228, 119);
            this.chkJpgToGifResize.Name = "chkJpgToGifResize";
            this.chkJpgToGifResize.Size = new System.Drawing.Size(100, 17);
            this.chkJpgToGifResize.TabIndex = 16;
            this.chkJpgToGifResize.Text = "Resize Squares";
            this.chkJpgToGifResize.UseVisualStyleBackColor = true;
            this.chkJpgToGifResize.CheckedChanged += new System.EventHandler(this.chkJpgToGifResize_CheckedChanged);
            // 
            // cmbWhichJpg
            // 
            this.cmbWhichJpg.FormattingEnabled = true;
            this.cmbWhichJpg.Items.AddRange(new object[] {
            "All",
            "Square",
            "Non-Square"});
            this.cmbWhichJpg.Location = new System.Drawing.Point(12, 94);
            this.cmbWhichJpg.Name = "cmbWhichJpg";
            this.cmbWhichJpg.Size = new System.Drawing.Size(73, 21);
            this.cmbWhichJpg.TabIndex = 26;
            this.cmbWhichJpg.Text = "All";
            this.cmbWhichJpg.SelectedIndexChanged += new System.EventHandler(this.cmbWhichJpg_SelectedIndexChanged);
            // 
            // cmbWhichPng
            // 
            this.cmbWhichPng.FormattingEnabled = true;
            this.cmbWhichPng.Items.AddRange(new object[] {
            "All",
            "Square",
            "Non-Square"});
            this.cmbWhichPng.Location = new System.Drawing.Point(12, 151);
            this.cmbWhichPng.Name = "cmbWhichPng";
            this.cmbWhichPng.Size = new System.Drawing.Size(73, 21);
            this.cmbWhichPng.TabIndex = 33;
            this.cmbWhichPng.Text = "All";
            this.cmbWhichPng.SelectedIndexChanged += new System.EventHandler(this.cmbWhichPng_SelectedIndexChanged);
            // 
            // chkPngToGif
            // 
            this.chkPngToGif.AutoSize = true;
            this.chkPngToGif.Checked = true;
            this.chkPngToGif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPngToGif.Location = new System.Drawing.Point(143, 176);
            this.chkPngToGif.Name = "chkPngToGif";
            this.chkPngToGif.Size = new System.Drawing.Size(79, 17);
            this.chkPngToGif.TabIndex = 32;
            this.chkPngToGif.Text = "Copy to .gif";
            this.chkPngToGif.UseVisualStyleBackColor = true;
            this.chkPngToGif.CheckedChanged += new System.EventHandler(this.chkPngToGif_CheckedChanged);
            // 
            // chkPngToGifBG
            // 
            this.chkPngToGifBG.AutoSize = true;
            this.chkPngToGifBG.Location = new System.Drawing.Point(333, 176);
            this.chkPngToGifBG.Name = "chkPngToGifBG";
            this.chkPngToGifBG.Size = new System.Drawing.Size(127, 17);
            this.chkPngToGifBG.TabIndex = 31;
            this.chkPngToGifBG.Text = "Include Backgrounds";
            this.chkPngToGifBG.UseVisualStyleBackColor = true;
            // 
            // chkPngToGifResize
            // 
            this.chkPngToGifResize.AutoSize = true;
            this.chkPngToGifResize.Checked = true;
            this.chkPngToGifResize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPngToGifResize.Location = new System.Drawing.Point(228, 176);
            this.chkPngToGifResize.Name = "chkPngToGifResize";
            this.chkPngToGifResize.Size = new System.Drawing.Size(100, 17);
            this.chkPngToGifResize.TabIndex = 30;
            this.chkPngToGifResize.Text = "Resize Squares";
            this.chkPngToGifResize.UseVisualStyleBackColor = true;
            this.chkPngToGifResize.CheckedChanged += new System.EventHandler(this.chkPngToGifResize_CheckedChanged);
            // 
            // chkPngToJpg
            // 
            this.chkPngToJpg.AutoSize = true;
            this.chkPngToJpg.Checked = true;
            this.chkPngToJpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPngToJpg.Location = new System.Drawing.Point(143, 153);
            this.chkPngToJpg.Name = "chkPngToJpg";
            this.chkPngToJpg.Size = new System.Drawing.Size(82, 17);
            this.chkPngToJpg.TabIndex = 29;
            this.chkPngToJpg.Text = "Copy to .jpg";
            this.chkPngToJpg.UseVisualStyleBackColor = true;
            this.chkPngToJpg.CheckedChanged += new System.EventHandler(this.chkPngToJpg_CheckedChanged);
            // 
            // chkPngToJpgResize
            // 
            this.chkPngToJpgResize.AutoSize = true;
            this.chkPngToJpgResize.Checked = true;
            this.chkPngToJpgResize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPngToJpgResize.Location = new System.Drawing.Point(228, 153);
            this.chkPngToJpgResize.Name = "chkPngToJpgResize";
            this.chkPngToJpgResize.Size = new System.Drawing.Size(100, 17);
            this.chkPngToJpgResize.TabIndex = 28;
            this.chkPngToJpgResize.Text = "Resize Squares";
            this.chkPngToJpgResize.UseVisualStyleBackColor = true;
            this.chkPngToJpgResize.CheckedChanged += new System.EventHandler(this.chkPngToJpgResize_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "png";
            // 
            // chkPngToJpgBG
            // 
            this.chkPngToJpgBG.AutoSize = true;
            this.chkPngToJpgBG.Checked = true;
            this.chkPngToJpgBG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPngToJpgBG.Location = new System.Drawing.Point(333, 153);
            this.chkPngToJpgBG.Name = "chkPngToJpgBG";
            this.chkPngToJpgBG.Size = new System.Drawing.Size(127, 17);
            this.chkPngToJpgBG.TabIndex = 34;
            this.chkPngToJpgBG.Text = "Include Backgrounds";
            this.chkPngToJpgBG.UseVisualStyleBackColor = true;
            // 
            // chkJpgToGifBG
            // 
            this.chkJpgToGifBG.AutoSize = true;
            this.chkJpgToGifBG.Location = new System.Drawing.Point(333, 119);
            this.chkJpgToGifBG.Name = "chkJpgToGifBG";
            this.chkJpgToGifBG.Size = new System.Drawing.Size(127, 17);
            this.chkJpgToGifBG.TabIndex = 36;
            this.chkJpgToGifBG.Text = "Include Backgrounds";
            this.chkJpgToGifBG.UseVisualStyleBackColor = true;
            // 
            // chkGifToJpgBG
            // 
            this.chkGifToJpgBG.AutoSize = true;
            this.chkGifToJpgBG.Checked = true;
            this.chkGifToJpgBG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGifToJpgBG.Location = new System.Drawing.Point(333, 209);
            this.chkGifToJpgBG.Name = "chkGifToJpgBG";
            this.chkGifToJpgBG.Size = new System.Drawing.Size(127, 17);
            this.chkGifToJpgBG.TabIndex = 44;
            this.chkGifToJpgBG.Text = "Include Backgrounds";
            this.chkGifToJpgBG.UseVisualStyleBackColor = true;
            // 
            // cmbWhichGif
            // 
            this.cmbWhichGif.FormattingEnabled = true;
            this.cmbWhichGif.Items.AddRange(new object[] {
            "All",
            "Square",
            "Non-Square"});
            this.cmbWhichGif.Location = new System.Drawing.Point(12, 207);
            this.cmbWhichGif.Name = "cmbWhichGif";
            this.cmbWhichGif.Size = new System.Drawing.Size(73, 21);
            this.cmbWhichGif.TabIndex = 43;
            this.cmbWhichGif.Text = "All";
            this.cmbWhichGif.SelectedIndexChanged += new System.EventHandler(this.cmbWhichGif_SelectedIndexChanged);
            // 
            // chkGifToGif
            // 
            this.chkGifToGif.AutoSize = true;
            this.chkGifToGif.Checked = true;
            this.chkGifToGif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGifToGif.Location = new System.Drawing.Point(143, 232);
            this.chkGifToGif.Name = "chkGifToGif";
            this.chkGifToGif.Size = new System.Drawing.Size(79, 17);
            this.chkGifToGif.TabIndex = 42;
            this.chkGifToGif.Text = "Copy to .gif";
            this.chkGifToGif.UseVisualStyleBackColor = true;
            this.chkGifToGif.CheckedChanged += new System.EventHandler(this.chkGifToGif_CheckedChanged);
            // 
            // chkGifToGifBG
            // 
            this.chkGifToGifBG.AutoSize = true;
            this.chkGifToGifBG.Location = new System.Drawing.Point(333, 232);
            this.chkGifToGifBG.Name = "chkGifToGifBG";
            this.chkGifToGifBG.Size = new System.Drawing.Size(127, 17);
            this.chkGifToGifBG.TabIndex = 41;
            this.chkGifToGifBG.Text = "Include Backgrounds";
            this.chkGifToGifBG.UseVisualStyleBackColor = true;
            // 
            // chkGifToGifResize
            // 
            this.chkGifToGifResize.AutoSize = true;
            this.chkGifToGifResize.Checked = true;
            this.chkGifToGifResize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGifToGifResize.Location = new System.Drawing.Point(228, 232);
            this.chkGifToGifResize.Name = "chkGifToGifResize";
            this.chkGifToGifResize.Size = new System.Drawing.Size(100, 17);
            this.chkGifToGifResize.TabIndex = 40;
            this.chkGifToGifResize.Text = "Resize Squares";
            this.chkGifToGifResize.UseVisualStyleBackColor = true;
            this.chkGifToGifResize.CheckedChanged += new System.EventHandler(this.chkGifToGifResize_CheckedChanged);
            // 
            // chkGifToJpg
            // 
            this.chkGifToJpg.AutoSize = true;
            this.chkGifToJpg.Checked = true;
            this.chkGifToJpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGifToJpg.Location = new System.Drawing.Point(143, 209);
            this.chkGifToJpg.Name = "chkGifToJpg";
            this.chkGifToJpg.Size = new System.Drawing.Size(82, 17);
            this.chkGifToJpg.TabIndex = 39;
            this.chkGifToJpg.Text = "Copy to .jpg";
            this.chkGifToJpg.UseVisualStyleBackColor = true;
            this.chkGifToJpg.CheckedChanged += new System.EventHandler(this.chkGifToJpg_CheckedChanged);
            // 
            // chkGifToJpgResize
            // 
            this.chkGifToJpgResize.AutoSize = true;
            this.chkGifToJpgResize.Checked = true;
            this.chkGifToJpgResize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGifToJpgResize.Location = new System.Drawing.Point(228, 209);
            this.chkGifToJpgResize.Name = "chkGifToJpgResize";
            this.chkGifToJpgResize.Size = new System.Drawing.Size(100, 17);
            this.chkGifToJpgResize.TabIndex = 38;
            this.chkGifToJpgResize.Text = "Resize Squares";
            this.chkGifToJpgResize.UseVisualStyleBackColor = true;
            this.chkGifToJpgResize.CheckedChanged += new System.EventHandler(this.chkGifToJpgResize_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "gif";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Cannot adjust background JPG->JPG.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 263);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkGifToJpgBG);
            this.Controls.Add(this.cmbWhichGif);
            this.Controls.Add(this.chkGifToGif);
            this.Controls.Add(this.chkGifToGifBG);
            this.Controls.Add(this.chkGifToGifResize);
            this.Controls.Add(this.chkGifToJpg);
            this.Controls.Add(this.chkGifToJpgResize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkJpgToGifBG);
            this.Controls.Add(this.chkPngToJpgBG);
            this.Controls.Add(this.cmbWhichPng);
            this.Controls.Add(this.chkPngToGif);
            this.Controls.Add(this.chkPngToGifBG);
            this.Controls.Add(this.chkPngToGifResize);
            this.Controls.Add(this.chkPngToJpg);
            this.Controls.Add(this.chkPngToJpgResize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbWhichJpg);
            this.Controls.Add(this.chkJpgToGif);
            this.Controls.Add(this.chkJpgToGifResize);
            this.Controls.Add(this.chkJpgToJpg);
            this.Controls.Add(this.chkJpgToJpgResize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.btnConsolidate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBackground);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoot);
            this.Name = "Form1";
            this.Text = "TEW Worker Image Consolidation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBackground;
        private System.Windows.Forms.Button btnConsolidate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkJpgToJpgResize;
        private System.Windows.Forms.CheckBox chkJpgToJpg;
        private System.Windows.Forms.CheckBox chkJpgToGif;
        private System.Windows.Forms.CheckBox chkJpgToGifResize;
        private System.Windows.Forms.ComboBox cmbWhichJpg;
        private System.Windows.Forms.ComboBox cmbWhichPng;
        private System.Windows.Forms.CheckBox chkPngToGif;
        private System.Windows.Forms.CheckBox chkPngToGifBG;
        private System.Windows.Forms.CheckBox chkPngToGifResize;
        private System.Windows.Forms.CheckBox chkPngToJpg;
        private System.Windows.Forms.CheckBox chkPngToJpgResize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPngToJpgBG;
        private System.Windows.Forms.CheckBox chkJpgToGifBG;
        private System.Windows.Forms.CheckBox chkGifToJpgBG;
        private System.Windows.Forms.ComboBox cmbWhichGif;
        private System.Windows.Forms.CheckBox chkGifToGif;
        private System.Windows.Forms.CheckBox chkGifToGifBG;
        private System.Windows.Forms.CheckBox chkGifToGifResize;
        private System.Windows.Forms.CheckBox chkGifToJpg;
        private System.Windows.Forms.CheckBox chkGifToJpgResize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

