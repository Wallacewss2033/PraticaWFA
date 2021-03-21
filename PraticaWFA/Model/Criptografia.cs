using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PraticaWFA.Model
{
	public class Criptografia
	{

		public string ComputeSHA1Hash(string senha)
		{

			byte[] textBytes = Encoding.ASCII.GetBytes(senha);

			SHA1 sha1 = SHA1.Create();
			byte[] computeHash = sha1.ComputeHash(textBytes);

			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < computeHash.Length; i++)
			{
				stringBuilder.Append(computeHash[i].ToString("x2"));

			}
			return stringBuilder.ToString();
		}

	}
}
