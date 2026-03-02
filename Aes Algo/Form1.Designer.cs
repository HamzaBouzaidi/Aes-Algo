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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KeyText = new System.Windows.Forms.Label();
            this.Keytextbox = new System.Windows.Forms.TextBox();
            this.Encryption = new System.Windows.Forms.Button();
            this.Decryption = new System.Windows.Forms.Button();
            this.Mode = new System.Windows.Forms.ComboBox();
            this.Modelabel = new System.Windows.Forms.Label();
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(302, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 31);
            this.textBox1.TabIndex = 1;
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
            this.Encryption.Location = new System.Drawing.Point(243, 375);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(157, 39);
            this.Encryption.TabIndex = 5;
            this.Encryption.Text = "Encryption";
            this.Encryption.UseVisualStyleBackColor = true;
            // 
            // Decryption
            // 
            this.Decryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decryption.Location = new System.Drawing.Point(432, 375);
            this.Decryption.Name = "Decryption";
            this.Decryption.Size = new System.Drawing.Size(157, 39);
            this.Decryption.TabIndex = 6;
            this.Decryption.Text = "Decryption";
            this.Decryption.UseVisualStyleBackColor = true;
            // 
            // Mode
            // 
            this.Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.FormattingEnabled = true;
            this.Mode.Location = new System.Drawing.Point(302, 213);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(121, 33);
            this.Mode.TabIndex = 7;
            this.Mode.Text = "ECD";
            // 
            // Modelabel
            // 
            this.Modelabel.AutoSize = true;
            this.Modelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modelabel.Location = new System.Drawing.Point(69, 213);
            this.Modelabel.Name = "Modelabel";
            this.Modelabel.Size = new System.Drawing.Size(77, 25);
            this.Modelabel.TabIndex = 8;
            this.Modelabel.Text = "Mode:";
            this.Modelabel.Click += new System.EventHandler(this.Modelabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.Modelabel);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.Decryption);
            this.Controls.Add(this.Encryption);
            this.Controls.Add(this.Keytextbox);
            this.Controls.Add(this.KeyText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Plaintext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Plaintext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label KeyText;
        private System.Windows.Forms.TextBox Keytextbox;
        private System.Windows.Forms.Button Encryption;
        private System.Windows.Forms.Button Decryption;
        private System.Windows.Forms.ComboBox Mode;
        private System.Windows.Forms.Label Modelabel;
    }
}

