using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptosV
{
	static class Cryptos
	{
		public static string alphabet_en = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		public static string alphabet_ua = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";

		public enum CiperType
		{
			Caesar,
			XOR,
			LitoreaClassic,
			Numbers,
			Vigenere
		}

		public static string EncryptCaesar(string text, int shift = 3)
		{
			char[] ch_text = text.ToCharArray();
			string result = "";	

			for (int i = 0; i < text.Length; i++)
			{
				string s_alphabet = "";

				if (alphabet_en.Contains(char.ToUpper(ch_text[i])))
				{
					s_alphabet = alphabet_en;
				}
				else
				{
					s_alphabet = alphabet_ua;
				}

				char[] alphabet = s_alphabet.ToArray();
				int a_length = s_alphabet.Length;

				//

				char ch = ch_text[i];
				char ch_result = ch;

				bool current_case = char.IsUpper(ch);

				ch = char.ToUpper(ch);

				if (alphabet.Contains(ch))
				{
					int ch_pos = Array.IndexOf(alphabet, ch);

					int n = (a_length + ch_pos + shift) % a_length;
					ch_result = alphabet[n];

					if (!current_case) ch_result = char.ToLower(ch_result);
				}

				result += ch_result;
			}

			return result;
		}

		public static string DecryptCaesar(string text, int shift = 3)
		{
			return EncryptCaesar(text, 0-shift);
		}

		public static string EncryptXOR(string message, int key)
		{
			string result = "";
			for (int i = 0; i < message.Length; i++)
				result += (char)(message[i] ^ key);
			return result;
		}

		public static string DecryptXOR(string message, int key)
		{
			return EncryptXOR(message, key);
		}

		public static string EncryptLitorea(string text)
		{
			string alphabet1 = "БВГДЖЗКЛМН";
			string alphabet2 = "ЩШЧЦХФТСРП";

			char[] ch_text = text.ToCharArray();
			string result = "";

			for (int i = 0; i < text.Length; i++)
			{
				char ch = ch_text[i];
				char ch_result = ch;

				bool current_case = char.IsUpper(ch);
				ch = char.ToUpper(ch);

				if (alphabet1.Contains(ch))
				{
					int n = alphabet1.IndexOf(ch);
					ch_result = alphabet2[n];
				}
				else if (alphabet2.Contains(ch))
				{
					int n = alphabet2.IndexOf(ch);
					ch_result = alphabet1[n];
				}

				if (!current_case) ch_result = char.ToLower(ch_result);

				result += ch_result;
			}

			return result;
		}

		public static string DecryptLitorea(string text)
		{
			return EncryptLitorea(text);
		}

		public static string EncryptNumber(string text)
		{
			char[] ch_text = text.ToCharArray();
			string result = "";

			for (int i = 0; i < text.Length; i++)
			{
				string s_alphabet = "";

				if (alphabet_en.Contains(char.ToUpper(ch_text[i])))
				{
					s_alphabet = alphabet_en;
				}
				else
				{
					s_alphabet = alphabet_ua;
				}

				char[] alphabet = s_alphabet.ToArray();

				char ch = ch_text[i];
				char ch_next = ' ';
				if (i < (text.Length - 1)) ch_next = ch_text[i + 1];

				string str_result =  "" + ch;

				ch = char.ToUpper(ch);
				ch_next = char.ToUpper(ch_next);

				if (alphabet.Contains(ch))
				{
					int n = Array.IndexOf(alphabet, ch) + 1;
					str_result = n.ToString();

					if (alphabet.Contains(ch_next)) str_result += "-";
				}

				result += str_result;
			}

			return result;
		}

		public static string DecryptNumber(string text)
		{
			string result = "";

			string[] words = text.Split(' ');

			foreach(string w in words)
			{
				string[] letters = w.Split('-');

				foreach(string l in letters)
				{
					string str = l.Trim();
					int n = Convert.ToInt32(str);

					if ((n - 1) < alphabet_ua.Length)
					{
						result += alphabet_ua[(n-1)];
					}
				}

				result += " ";
			}

			return result;
		}

		
		private static string GetRepeatKey(string s, int n)
		{
			var p = s;
			while (p.Length < n)
			{
				p += p;
			}

			return p.Substring(0, n);
		}

		public static string EncryptVigenere(string text, string key, bool key_minus = false)
		{
			string result = "";

			char[] ch_text = text.ToCharArray();
			string gamma = GetRepeatKey(key, text.Length);

			int i_k = 0; // key pos

			for (int i = 0; i < text.Length; i++)
			{
				string s_alphabet = "";

				if (alphabet_en.Contains(char.ToUpper(ch_text[i])))
				{
					s_alphabet = alphabet_en;
				}
				else
				{
					s_alphabet = alphabet_ua;
				}

				char[] alphabet = s_alphabet.ToArray();
				int a_length = s_alphabet.Length;

				char ch = ch_text[i];
				char ch_result = ch;

				bool current_case = char.IsUpper(ch);

				ch = char.ToUpper(ch);


				if (alphabet_en.Contains(char.ToUpper(gamma[i_k])))
				{
					s_alphabet = alphabet_en;
				}
				else
				{
					s_alphabet = alphabet_ua;
				}

				char[] key_alphabet = s_alphabet.ToArray();

				char k = gamma[i_k];
				k = char.ToUpper(k);

				if (alphabet.Contains(ch))
				{
					int ch_pos = Array.IndexOf(alphabet, ch);
					int key_pos = Array.IndexOf(key_alphabet, k);

					if (key_minus) key_pos = 0 - key_pos; // For decode

					int n = (a_length + ch_pos + key_pos) % a_length;
					ch_result = alphabet[n];

					if (!current_case) ch_result = char.ToLower(ch_result);
					i_k++;
				}

				result += ch_result;
			}

			return result;
		}

		public static string DecryptVigenere(string text, string key)
		{
			return EncryptVigenere(text, key, true);
		}
	}
}
