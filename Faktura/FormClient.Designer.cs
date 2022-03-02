namespace Faktura
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNrTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customImageButton1 = new MyImageButton.CustomImageButton();
            this.button_Canel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbID.ForeColor = System.Drawing.Color.White;
            this.tbID.Location = new System.Drawing.Point(27, 47);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(408, 26);
            this.tbID.TabIndex = 9;
            this.tbID.Text = "0";
            // 
            // tbImie
            // 
            this.tbImie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tbImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbImie.ForeColor = System.Drawing.Color.White;
            this.tbImie.Location = new System.Drawing.Point(27, 105);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(408, 26);
            this.tbImie.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Imie";
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tbNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNazwisko.ForeColor = System.Drawing.Color.White;
            this.tbNazwisko.Location = new System.Drawing.Point(27, 167);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(408, 26);
            this.tbNazwisko.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nazwisko";
            // 
            // tbNrTel
            // 
            this.tbNrTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tbNrTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNrTel.ForeColor = System.Drawing.Color.White;
            this.tbNrTel.Location = new System.Drawing.Point(27, 229);
            this.tbNrTel.Name = "tbNrTel";
            this.tbNrTel.Size = new System.Drawing.Size(408, 26);
            this.tbNrTel.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nr telefonu";
            // 
            // customImageButton1
            // 
            this.customImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("customImageButton1.Image")));
            this.customImageButton1.ImageHover = ((System.Drawing.Image)(resources.GetObject("customImageButton1.ImageHover")));
            this.customImageButton1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customImageButton1.ImageNormal")));
            this.customImageButton1.Location = new System.Drawing.Point(449, 2);
            this.customImageButton1.Name = "customImageButton1";
            this.customImageButton1.Size = new System.Drawing.Size(28, 25);
            this.customImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton1.TabIndex = 17;
            this.customImageButton1.TabStop = false;
            this.customImageButton1.Click += new System.EventHandler(this.customImageButton1_Click);
            // 
            // button_Canel
            // 
            this.button_Canel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Canel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.button_Canel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_Canel.FlatAppearance.BorderSize = 3;
            this.button_Canel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Canel.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.button_Canel.ForeColor = System.Drawing.Color.White;
            this.button_Canel.Location = new System.Drawing.Point(281, 322);
            this.button_Canel.Name = "button_Canel";
            this.button_Canel.Size = new System.Drawing.Size(187, 75);
            this.button_Canel.TabIndex = 18;
            this.button_Canel.Text = "Anuluj";
            this.button_Canel.UseVisualStyleBackColor = false;
            this.button_Canel.Click += new System.EventHandler(this.button_Canel_Click);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_Save.FlatAppearance.BorderSize = 3;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(88, 322);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(187, 75);
            this.button_Save.TabIndex = 19;
            this.button_Save.Text = "Zapisz";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click_1);
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.button_Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_Clear.FlatAppearance.BorderSize = 3;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.Location = new System.Drawing.Point(27, 341);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(45, 36);
            this.button_Clear.TabIndex = 20;
            this.button_Clear.Text = "X";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(478, 409);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Canel);
            this.Controls.Add(this.customImageButton1);
            this.Controls.Add(this.tbNrTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(478, 409);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(478, 409);
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKlient";
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNrTel;
        private System.Windows.Forms.Label label4;
        private MyImageButton.CustomImageButton customImageButton1;
        private System.Windows.Forms.Button button_Canel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Clear;
    }
}