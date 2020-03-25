using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptosV
{
	public partial class MainForm : Form
	{

		int selected_method = 2;
		int key_caesar = 3;

		public MainForm()
		{
			InitializeComponent();
		}

		private void btnCode_Click(object sender, EventArgs e)
		{
			string result = "";
			string text = rtbText.Text;

			switch (selected_method)
			{
				case 1:
					result = Cryptos.EncryptLitorea(text); 
					break;
				case 2:
					result = Cryptos.EncryptCaesar(text, key_caesar);
					break;
				case 3:
					int key = Convert.ToInt32(tbXORKey.Text);
					result = Cryptos.EncryptXOR(text, key);
					break;
				case 4:
					result = Cryptos.EncryptNumber(text);
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
				case 1:
					result = Cryptos.DecryptLitorea(text); 
					break;
				case 2:
					result = Cryptos.DecryptCaesar(text, key_caesar);
					break;
				case 3:
					int key = Convert.ToInt32(tbXORKey.Text);
					result = Cryptos.DecryptXOR(text, key);
					break;
				case 4:
					result = Cryptos.DecryptNumber(text);
					break;
				default:
					MessageBox.Show("This option not supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
			}

			rtbResult.Text = result;
		}



		private void rbLitorea_CheckedChanged(object sender, EventArgs e)
		{
			selected_method = 1;
		}

		private void rbCaesar_CheckedChanged(object sender, EventArgs e)
		{
			selected_method = 2;
		}

		private void rbXor_CheckedChanged(object sender, EventArgs e)
		{
			selected_method = 3;
		}

		private void rbNumber_CheckedChanged(object sender, EventArgs e)
		{
			selected_method = 4;
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

		
	}
}
