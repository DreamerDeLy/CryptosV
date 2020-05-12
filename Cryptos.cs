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

		public enum CipherType
		{
			Caesar,
			XOR,
			LitoreaClassic,
			Numbers,
			Vigenere,
			Atbash,
			Qwerty
		}

		public static string EncryptCaesar(string text, int shift = 3)
		{
			string result = "";

			for (int i = 0; i < text.Length; i++)
			{
				char ch = text[i];
				char ch_result = ch;

				bool current_case = char.IsUpper(ch);
				ch = char.ToUpper(ch);

				string alphabet = "";

				if (alphabet_en.Contains(ch))
				{
					alphabet = alphabet_en;
				}
				else
				{
					alphabet = alphabet_ua;
				}
				
				int a_length = alphabet.Length;


				if (alphabet.Contains(ch))
				{
					int ch_pos = alphabet.IndexOf(ch);

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

			string result = "";

			for (int i = 0; i < text.Length; i++)
			{
				char ch = text[i];
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
			string result = "";

			for (int i = 0; i < text.Length; i++)
			{
				string alphabet = "";

				if (alphabet_en.Contains(char.ToUpper(text[i])))
				{
					alphabet = alphabet_en;
				}
				else
				{
					alphabet = alphabet_ua;
				}

				char ch = text[i];
				string str_result = "" + ch;

				char ch_next = ' ';
				if (i < (text.Length - 1)) ch_next = text[i + 1];

				ch = char.ToUpper(ch);
				ch_next = char.ToUpper(ch_next);

				if (alphabet.Contains(ch))
				{
					int n = alphabet.IndexOf(ch) + 1;
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

			string gamma = GetRepeatKey(key, text.Length);

			int i_k = 0; // key pos

			for (int i = 0; i < text.Length; i++)
			{
				char ch = text[i];
				char ch_result = ch;

				bool current_case = char.IsUpper(ch);

				ch = char.ToUpper(ch);

				string alphabet = "";

				if (alphabet_en.Contains(ch))
				{
					alphabet = alphabet_en;
				}
				else
				{
					alphabet = alphabet_ua;
				}

				int a_length = alphabet.Length;


				char k = char.ToUpper(gamma[i_k]);

				string key_alphabet = "";

				if (alphabet_en.Contains(k))
				{
					key_alphabet = alphabet_en;
				}
				else
				{
					key_alphabet = alphabet_ua;
				}


				if (alphabet.Contains(ch))
				{
					int ch_pos = alphabet.IndexOf(ch);
					int key_pos = key_alphabet.IndexOf(k);

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

		public static string EncryptAtbash(string text)
		{
			string result = "";

			for (int i = 0; i < text.Length; i++)
			{
				char ch = text[i];
				char ch_result = ch;

				bool current_case = char.IsUpper(ch);

				ch = char.ToUpper(ch);


				string alphabet = "";

				if (alphabet_en.Contains(ch))
				{
					alphabet = alphabet_en;
				}
				else
				{
					alphabet = alphabet_ua;
				}

				int a_length = alphabet.Length;
				

				if (alphabet.Contains(ch))
				{
					int ch_pos = alphabet.IndexOf(ch);

					int n = a_length - (ch_pos + 1);
					ch_result = alphabet[n];

					if (!current_case) ch_result = char.ToLower(ch_result);
				}

				result += ch_result;
			}

			return result;
		}

		public static string DecryptAtbash(string text)
		{
			return EncryptAtbash(text);
		}

		public static string EncryptQwerty(string text)
		{
			string qwerty_en = "qwertyuiop[]asdfghjkl;'zxcvbnm,.";
			string qwerty_ua = "йцукенгшщзхїфівапролджєячсмитьбю";

			string result = "";

			foreach (char c in text)
			{
				if (qwerty_en.Contains(c))
				{
					int i = qwerty_en.IndexOf(c);
					result += qwerty_ua[i];
				}
				else if (qwerty_ua.Contains(c))
				{
					int i = qwerty_ua.IndexOf(c);
					result += qwerty_en[i];
				}
				else
				{
					result += c;
				}
			}

			return result;
		}

		public static string DecryptQwerty(string text)
		{
			return EncryptQwerty(text);
		}

		public static string EncryptTarabar(string text)
		{
			string result = "";

			return result;
		}
	}
}
