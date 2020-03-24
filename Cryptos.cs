using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptosV
{
	static class Cryptos
	{
		static string alphabet_en = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		static string alphabet_ua = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";

		public static string EncryptCaesar(string text, int shift = 3)
		{
			char[] ch_text = text.ToCharArray();
			string result = "";

			string s_alphabet = "";

			//if (alphabet_en.Contains(char.ToUpper(ch_text[0])))
			//{
			//	s_alphabet = alphabet_en;
			//}
			//else
			//{
			//	s_alphabet = alphabet_ua;
			//}

			//char[] alphabet = s_alphabet.ToArray();
			//int a_length = s_alphabet.Length;

			

			for (int i = 0; i < text.Length; i++)
			{
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

				bool skip = !alphabet.Contains(ch);

				if (!skip)
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
			string alphabet1 = "АБВГДЕЄЖЗИІЇЙКЛМ";
			string alphabet2 = "НОПРСТУФХЦЧШЩЬЮЯ";

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
	}
}
