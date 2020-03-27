using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Forms
using System.IO;            // File
using System.Text.RegularExpressions; // Regex

namespace CryptosV
{
	public partial class MainForm : Form
	{
		int key_caesar = 3;
		Cryptos.CiperType selected_method = Cryptos.CiperType.Caesar;

		public MainForm()
		{
			InitializeComponent();

			setSafety(2);
			tbAlphabet1.Text = Cryptos.alphabet_en;
			tbAlphabet2.Text = Cryptos.alphabet_ua;
		}

		private void btnCode_Click(object sender, EventArgs e)
		{
			string result = "";
			string text = rtbText.Text;

			switch (selected_method)
			{
				case Cryptos.CiperType.LitoreaClassic:
					result = Cryptos.EncryptLitorea(text); 
					break;
				case Cryptos.CiperType.Caesar:
					result = Cryptos.EncryptCaesar(text, key_caesar);
					break;
				case Cryptos.CiperType.XOR:
					int xor_key = Convert.ToInt32(tbXORKey.Text);
					result = Cryptos.EncryptXOR(text, xor_key);
					break;
				case Cryptos.CiperType.Numbers:
					result = Cryptos.EncryptNumber(text);
					break;
				case Cryptos.CiperType.Vigenere:
					string v_key = tbVigenereKey.Text;
					result = Cryptos.EncryptVigenere(text, v_key);
					break;
				case Cryptos.CiperType.Atbash:
					result = Cryptos.EncryptAtbash(text);
					break;
				default:
					MessageBox.Show("This option not supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
			}

			rtbResult.Text = result; 
		}

		private void btnDecode_Click(object sender, EventArgs e)
		{
			string result = "";
			string text = rtbText.Text;

			switch (selected_method)
			{
				case Cryptos.CiperType.LitoreaClassic:
					result = Cryptos.DecryptLitorea(text); 
					break;
				case Cryptos.CiperType.Caesar:
					result = Cryptos.DecryptCaesar(text, key_caesar);
					break;
				case Cryptos.CiperType.XOR:
					int xor_key = Convert.ToInt32(tbXORKey.Text);
					result = Cryptos.DecryptXOR(text, xor_key);
					break;
				case Cryptos.CiperType.Numbers:
					result = Cryptos.DecryptNumber(text);
					break;
				case Cryptos.CiperType.Vigenere:
					string v_key = tbVigenereKey.Text;
					result = Cryptos.DecryptVigenere(text, v_key);
					break;
				case Cryptos.CiperType.Atbash:
					//result = Cryptos.DecryptNumber(text);
					break;
				default:
					MessageBox.Show("This option not supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
			}

			rtbResult.Text = result;
		}



		private void rbLitorea_CheckedChanged(object sender, EventArgs e)
		{
			selected_method = Cryptos.CiperType.LitoreaClassic;
			setSafety(2);
		}

		private void rbCaesar_CheckedChanged(object sender, EventArgs e)
		{
			selected_method = Cryptos.CiperType.Caesar;
			setSafety(2);
		}

		private void rbXor_CheckedChanged(object sender, EventArgs e)
		{
			selected_method = Cryptos.CiperType.XOR;
			setSafety(3);
		}

		private void rbNumber_CheckedChanged(object sender, EventArgs e)
		{
			selected_method = Cryptos.CiperType.Numbers;
			setSafety(1);
		}

		private void rbVigenere_CheckedChanged(object sender, EventArgs e)
		{
			selected_method = Cryptos.CiperType.Vigenere;
			setSafety(3);
		}
		private void rbAtbash_CheckedChanged(object sender, EventArgs e)
		{
			selected_method = Cryptos.CiperType.Atbash;
			setSafety(2);
		}


		private void nudCaesarKey_ValueChanged(object sender, EventArgs e)
		{
			key_caesar = Convert.ToInt32(nudCaesarKey.Value);
		}


		private void btnSwap_Click(object sender, EventArgs e)
		{
			string text1 = rtbText.Text;
			string text2 = rtbResult.Text;

			rtbText.Text = text2;
			rtbResult.Text = text1;
		}

		private void btnCrear_Click(object sender, EventArgs e)
		{
			rtbText.Text = "";
			rtbResult.Text = "";
		}

		private void tbXORKey_KeyPress(object sender, KeyPressEventArgs e)
		{
			// ввод в texBox только цифр и кнопки Backspace
			char ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}

		void setSafety(int level = 1)
		{
			switch (level)
			{
				case 1:
					pnlColor.BackColor = Color.Red;
					lblSafety.Text = "Safety: low";
					break;
				case 2:
					pnlColor.BackColor = Color.Yellow;
					lblSafety.Text = "Safety: medium";
					break;
				case 3:
					pnlColor.BackColor = Color.Lime;
					lblSafety.Text = "Safety: high";
					break;
			}
		}

		private void btnAlphabetsSet_Click(object sender, EventArgs e)
		{
			Cryptos.alphabet_en = tbAlphabet1.Text.ToUpper();
			Cryptos.alphabet_ua = tbAlphabet2.Text.ToUpper();
		}

		private void tsmiReadFromFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{ 
				string path = openFileDialog1.FileName;
				
				try
				{
					string new_text = File.ReadAllText(path);
					rtbText.Text = new_text;
				}
				catch
				{
					MessageBox.Show("Error while saving file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void tsmiSaveToFile_Click(object sender, EventArgs e)
		{
			string result_text = rtbResult.Text;
			string[] result_strings = new[] { result_text };

			Regex regEx = new Regex("[A-Za-z0-9_-]*[.]*[A-Za-z0-9]{3,4}");

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string path = saveFileDialog1.FileName;

					if (!regEx.Match(path).Success)
					{
						path += ".txt";
					}

					File.WriteAllLines(path, result_strings);
				}
				catch
				{
					MessageBox.Show("Error while saving file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		
	}
}
