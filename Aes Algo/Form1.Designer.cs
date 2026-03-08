namespace Aes_Algo
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
            this.components = new System.ComponentModel.Container();
            this.Plaintext = new System.Windows.Forms.Label();
            this.PlaintextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KeyText = new System.Windows.Forms.Label();
            this.Keytextbox = new System.Windows.Forms.TextBox();
            this.Encryption = new System.Windows.Forms.Button();
            this.Decryption = new System.Windows.Forms.Button();
            this.Mode = new System.Windows.Forms.ComboBox();
            this.Modelabel = new System.Windows.Forms.Label();
            this.keylength = new System.Windows.Forms.Label();
            this.KeylenghtcomboBox = new System.Windows.Forms.ComboBox();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plaintext
            // 
            this.Plaintext.AutoSize = true;
            this.Plaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plaintext.Location = new System.Drawing.Point(70, 71);
            this.Plaintext.Name = "Plaintext";
            this.Plaintext.Size = new System.Drawing.Size(151, 24);
            this.Plaintext.TabIndex = 0;
            this.Plaintext.Text = "Enter Plaintext:";
            // 
            // PlaintextBox
            // 
            this.PlaintextBox.BackColor = System.Drawing.SystemColors.Info;
            this.PlaintextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaintextBox.Location = new System.Drawing.Point(302, 64);
            this.PlaintextBox.Name = "PlaintextBox";
            this.PlaintextBox.Size = new System.Drawing.Size(268, 31);
            this.PlaintextBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // KeyText
            // 
            this.KeyText.AutoSize = true;
            this.KeyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyText.Location = new System.Drawing.Point(69, 137);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(162, 25);
            this.KeyText.TabIndex = 3;
            this.KeyText.Text = "Enter the Key:";
            this.KeyText.Click += new System.EventHandler(this.KeyText_Click);
            // 
            // Keytextbox
            // 
            this.Keytextbox.BackColor = System.Drawing.SystemColors.Info;
            this.Keytextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keytextbox.Location = new System.Drawing.Point(302, 137);
            this.Keytextbox.Name = "Keytextbox";
            this.Keytextbox.Size = new System.Drawing.Size(268, 31);
            this.Keytextbox.TabIndex = 4;
            // 
            // Encryption
            // 
            this.Encryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encryption.Location = new System.Drawing.Point(655, 63);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(157, 39);
            this.Encryption.TabIndex = 5;
            this.Encryption.Text = "Encryption";
            this.Encryption.UseVisualStyleBackColor = true;
            this.Encryption.Click += new System.EventHandler(this.Encryption_Click);
            // 
            // Decryption
            // 
            this.Decryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decryption.Location = new System.Drawing.Point(655, 137);
            this.Decryption.Name = "Decryption";
            this.Decryption.Size = new System.Drawing.Size(157, 39);
            this.Decryption.TabIndex = 6;
            this.Decryption.Text = "Decryption";
            this.Decryption.UseVisualStyleBackColor = true;
            this.Decryption.Click += new System.EventHandler(this.Decryption_Click);
            // 
            // Mode
            // 
            this.Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.FormattingEnabled = true;
            this.Mode.Items.AddRange(new object[] {
            "ECB",
            "CBC",
            "CFB"});
            this.Mode.Location = new System.Drawing.Point(282, 354);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(121, 33);
            this.Mode.TabIndex = 7;
            // 
            // Modelabel
            // 
            this.Modelabel.AutoSize = true;
            this.Modelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modelabel.Location = new System.Drawing.Point(69, 362);
            this.Modelabel.Name = "Modelabel";
            this.Modelabel.Size = new System.Drawing.Size(77, 25);
            this.Modelabel.TabIndex = 8;
            this.Modelabel.Text = "Mode:";
            this.Modelabel.Click += new System.EventHandler(this.Modelabel_Click);
            // 
            // keylength
            // 
            this.keylength.AutoSize = true;
            this.keylength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keylength.Location = new System.Drawing.Point(69, 440);
            this.keylength.Name = "keylength";
            this.keylength.Size = new System.Drawing.Size(131, 25);
            this.keylength.TabIndex = 9;
            this.keylength.Text = "Key length:";
            // 
            // KeylenghtcomboBox
            // 
            this.KeylenghtcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeylenghtcomboBox.FormattingEnabled = true;
            this.KeylenghtcomboBox.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.KeylenghtcomboBox.Location = new System.Drawing.Point(282, 432);
            this.KeylenghtcomboBox.Name = "KeylenghtcomboBox";
            this.KeylenghtcomboBox.Size = new System.Drawing.Size(121, 33);
            this.KeylenghtcomboBox.TabIndex = 10;
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.Red;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(682, 597);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(157, 39);
            this.Exitbtn.TabIndex = 11;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.SystemColors.Info;
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(302, 213);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(275, 41);
            this.OutputBox.TabIndex = 12;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(270, 583);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(133, 42);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save.txt";
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Location = new System.Drawing.Point(437, 583);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(133, 42);
            this.LoadBtn.TabIndex = 14;
            this.LoadBtn.Text = "Load.txt";
            this.LoadBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 659);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.KeylenghtcomboBox);
            this.Controls.Add(this.keylength);
            this.Controls.Add(this.Modelabel);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.Decryption);
            this.Controls.Add(this.Encryption);
            this.Controls.Add(this.Keytextbox);
            this.Controls.Add(this.KeyText);
            this.Controls.Add(this.PlaintextBox);
            this.Controls.Add(this.Plaintext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Plaintext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label KeyText;
        private System.Windows.Forms.TextBox Keytextbox;
        private System.Windows.Forms.Button Encryption;
        private System.Windows.Forms.Button Decryption;
        private System.Windows.Forms.ComboBox Mode;
        private System.Windows.Forms.Label Modelabel;
        private System.Windows.Forms.Label keylength;
        private System.Windows.Forms.ComboBox KeylenghtcomboBox;
        private System.Windows.Forms.Button Exitbtn;
        public System.Windows.Forms.TextBox PlaintextBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
    }
}

