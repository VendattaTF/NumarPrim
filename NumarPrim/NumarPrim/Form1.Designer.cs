namespace NumarPrim
{
    partial class Corp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {                    
            this.TitleLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(58, 60);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(203, 43);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Număr prim";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(108, 220);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(115, 39);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Calculeaza";
            this.StartButton.UseMnemonic = false;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(64, 137);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(194, 20);
            this.textbox.TabIndex = 6;
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged_1);
            this.textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            // 
            // buttonAuto
            // 
            this.buttonAuto.Location = new System.Drawing.Point(12, 26);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(55, 31);
            this.buttonAuto.TabIndex = 7;
            this.buttonAuto.Text = "Auto:off";
            this.buttonAuto.UseVisualStyleBackColor = true;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ResultLabel.Location = new System.Drawing.Point(77, 270);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(194, 74);
            this.ResultLabel.TabIndex = 8;
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(125, 176);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(78, 38);
            this.buttonFile.TabIndex = 9;
            this.buttonFile.Text = "Citește din fișier";
            this.buttonFile.UseMnemonic = false;
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Open in.txt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Corp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(335, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.buttonAuto);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Corp";
            this.Text = "NrPrim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Label debugInstructionsLabel;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label helloWorldLabel;
        public System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.Button StartButton;
        public System.Windows.Forms.TextBox textbox;
        public System.Windows.Forms.Button buttonAuto;
        public System.Windows.Forms.Label ResultLabel;
        public System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button button2;
    }
}

