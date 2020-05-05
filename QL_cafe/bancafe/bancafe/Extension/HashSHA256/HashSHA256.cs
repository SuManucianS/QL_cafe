using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bancafe.Extension.HashSHA256
{
	class HashSHA256
	{
		private static string getbumhash(byte[] data)
		{
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < data.Length; i++)
			{
				builder.Append(data[i].ToString("x2"));
			}
			return builder.ToString();
		}
		public static string Hash(string data)
		{
			using (var bum = SHA256.Create())
			{
				return getbumhash(bum.ComputeHash(Encoding.UTF8.GetBytes(data)));
			}

		}
	}
}
