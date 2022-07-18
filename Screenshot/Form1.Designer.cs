namespace Screenshot
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDownStartX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartY = new System.Windows.Forms.NumericUpDown();
            this.buttonOpenDir = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.buttonSetBox = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSizeX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSizeY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartY)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeY)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(264, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDownStartX
            // 
            this.numericUpDownStartX.Location = new System.Drawing.Point(0, 22);
            this.numericUpDownStartX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStartX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownStartX.Name = "numericUpDownStartX";
            this.numericUpDownStartX.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownStartX.TabIndex = 1;
            this.numericUpDownStartX.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // numericUpDownStartY
            // 
            this.numericUpDownStartY.Location = new System.Drawing.Point(126, 22);
            this.numericUpDownStartY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStartY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownStartY.Name = "numericUpDownStartY";
            this.numericUpDownStartY.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownStartY.TabIndex = 2;
            this.numericUpDownStartY.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // buttonOpenDir
            // 
            this.buttonOpenDir.Location = new System.Drawing.Point(102, 415);
            this.buttonOpenDir.Name = "buttonOpenDir";
            this.buttonOpenDir.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenDir.TabIndex = 3;
            this.buttonOpenDir.Text = "OpenDir";
            this.buttonOpenDir.UseVisualStyleBackColor = true;
            this.buttonOpenDir.Click += new System.EventHandler(this.ButtonOpenDir_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(183, 415);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveImage.TabIndex = 4;
            this.buttonSaveImage.Text = "SaveImg";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.ButtonSaveImage_Click);
            // 
            // buttonSetBox
            // 
            this.buttonSetBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSetBox.Location = new System.Drawing.Point(183, 130);
            this.buttonSetBox.Name = "buttonSetBox";
            this.buttonSetBox.Size = new System.Drawing.Size(75, 23);
            this.buttonSetBox.TabIndex = 5;
            this.buttonSetBox.Text = "ShowArea";
            this.buttonSetBox.UseVisualStyleBackColor = true;
            this.buttonSetBox.Click += new System.EventHandler(this.ButtonSetBox_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(66, 133);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Set immediately";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownStartX);
            this.groupBox1.Controls.Add(this.numericUpDownStartY);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 55);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Point";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownSizeX);
            this.groupBox2.Controls.Add(this.numericUpDownSizeY);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 51);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // numericUpDownSizeX
            // 
            this.numericUpDownSizeX.Location = new System.Drawing.Point(0, 22);
            this.numericUpDownSizeX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownSizeX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownSizeX.Name = "numericUpDownSizeX";
            this.numericUpDownSizeX.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownSizeX.TabIndex = 9;
            this.numericUpDownSizeX.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // numericUpDownSizeY
            // 
            this.numericUpDownSizeY.Location = new System.Drawing.Point(126, 22);
            this.numericUpDownSizeY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownSizeY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownSizeY.Name = "numericUpDownSizeY";
            this.numericUpDownSizeY.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownSizeY.TabIndex = 10;
            this.numericUpDownSizeY.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSetBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.buttonOpenDir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private NumericUpDown numericUpDownStartX;
        private NumericUpDown numericUpDownStartY;
        private Button buttonOpenDir;
        private Button buttonSaveImage;
        private Button buttonSetBox;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDownSizeX;
        private NumericUpDown numericUpDownSizeY;
    }
}