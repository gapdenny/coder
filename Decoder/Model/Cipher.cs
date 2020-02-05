using System;

namespace Decoder.Model
{
    public class Cipher
    {
		public string getDecryptedData(String RawData, int NumberOfRails)
{
			if (String.IsNullOrEmpty(RawData))
				return "";
			if (NumberOfRails < 2)
				throw new ArgumentOutOfRangeException("Number of rails may be biger than 1");

			char[] decryptedData = new char[RawData.Length];
			int n = 0;
			for (int i = 0; i < NumberOfRails; i++)
			{
				int index = i;
				bool down = true;
				while (index < RawData.Length)
				{
					
					decryptedData[index] = RawData[n];
					n++;

					if (i == 0 || i == NumberOfRails - 1)
					{
						index = index + 2 * (NumberOfRails - 1);
					}
					else if (down)
					{
						index = index + 2 * (NumberOfRails - i - 1);
						down = !down;
					}
					else
					{
						index = index + 2 * i;
						down = !down;
					}
				}
			}
			return new String(decryptedData);
		}

		public string getEncryptedData(String rawData, int NumberOfRails)
		{
			if (String.IsNullOrEmpty(rawData))
				return "";
			if (NumberOfRails < 2)
				throw new ArgumentOutOfRangeException("Number of rails may be biger than 1");
			char[] encryptedData = new char[rawData.Length];
			int n = 0;


			for (int i = 0; i < NumberOfRails; i++)
			{
				int index = i;
				bool down = true;
				while (index < rawData.Length)
				{
					
					encryptedData[n++] = rawData[index];

					if (i == 0 || i == NumberOfRails - 1)
					{
						index = index + 2 * (NumberOfRails - 1);
					}
					else if (down)
					{
						index = index + 2 * (NumberOfRails - i - 1);
						down = !down;
					}
					else
					{
						index = index + 2 * i;
						down = !down;
					}
				}
			}
			return new String(encryptedData);
		}
	}
}
