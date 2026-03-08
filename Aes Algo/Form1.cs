using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aes_Algo
{

    public partial class Form1 : Form
    {
        private EncryptionPackage _currentPackage;
        public Form1()
        {
            InitializeComponent();
             // Set defaults so user doesn't forget
            if (Mode.SelectedIndex < 0) Mode.SelectedIndex = 0;
            if (KeylenghtcomboBox.SelectedIndex < 0) KeylenghtcomboBox.SelectedIndex = 0;

            
            Encryption.Click += Encryption_Click;
            Decryption.Click += Decryption_Click;
            SaveBtn.Click += SaveBtn_Click;
            LoadBtn.Click += LoadBtn_Click;
        }

        private void KeyText_Click(object sender, EventArgs e)
        {
            if(KeyText.Text == " ")
            {
                MessageBox.Show("Please enter a key for encryption/decryption.");
            }
        }

        private void Modelabel_Click(object sender, EventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Encryption_Click(object sender, EventArgs e)
        {
            try
            {
                string plaintext = PlaintextBox.Text;
                string password = Keytextbox.Text;

                if (Mode.SelectedItem == null) throw new Exception("Select mode.");
                if (KeylenghtcomboBox.SelectedItem == null) throw new Exception("Select key length.");

                CipherMode mode = (CipherMode)Enum.Parse(typeof(CipherMode), Mode.SelectedItem.ToString());
                int keySize = int.Parse(KeylenghtcomboBox.SelectedItem.ToString());

                var aes = new AesService();
                _currentPackage = aes.Encrypt(plaintext, password, mode, keySize);

                // You need an OutputBox for this:
                OutputBox.Text = Convert.ToBase64String(_currentPackage.Ciphertext);

                MessageBox.Show("Encryption successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed: " + ex.Message);
            }
        }
        

        private void Decryption_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentPackage == null)
                {
                    MessageBox.Show("Load ciphertext from .txt first (or encrypt first).");
                    return;
                }

                string password = Keytextbox.Text;

                var aes = new AesService();
                string plaintext = aes.Decrypt(_currentPackage, password);

                OutputBox.Text = plaintext;

                MessageBox.Show("Decryption successful.");
            }
            catch (CryptographicException)
            {
                MessageBox.Show("Decryption failed: wrong key or unsupported mode (CFB may fail on .NET Framework).");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption failed: " + ex.Message);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentPackage == null)
                {
                    MessageBox.Show("Encrypt first so you have ciphertext to save.");
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Text files (*.txt)|*.txt";
                    sfd.FileName = "ciphertext.txt";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        PackageFormat.SaveToFile(sfd.FileName, _currentPackage);
                        MessageBox.Show("Saved.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Text files (*.txt)|*.txt";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        _currentPackage = PackageFormat.LoadFromFile(ofd.FileName);

                        // Sync UI with loaded file
                        Mode.SelectedItem = _currentPackage.Mode;
                        KeylenghtcomboBox.SelectedItem = _currentPackage.KeySize.ToString();

                        OutputBox.Text = Convert.ToBase64String(_currentPackage.Ciphertext);

                        MessageBox.Show("Loaded.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load failed: " + ex.Message);
            }
        }
    }
}
    
