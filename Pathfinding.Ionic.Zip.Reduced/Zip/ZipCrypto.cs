using System;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	internal class ZipCrypto
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2859270", Offset = "0x2857870", VA = "0x182859270")]
		private ZipCrypto()
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x28593D0", Offset = "0x28579D0", VA = "0x1828593D0")]
		public static ZipCrypto ForWrite(string password)
		{
			return null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2859490", Offset = "0x2857A90", VA = "0x182859490")]
		public static ZipCrypto ForRead(string password, ZipEntry e)
		{
			return null;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x17000021")]
		private byte MagicByte
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x2859700", Offset = "0x2857D00", VA = "0x182859700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2859740", Offset = "0x2857D40", VA = "0x182859740")]
		public byte[] DecryptMessage(byte[] cipherText, int length)
		{
			return null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x28598F0", Offset = "0x2857EF0", VA = "0x1828598F0")]
		public byte[] EncryptMessage(byte[] plainText, int length)
		{
			return null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2859AA0", Offset = "0x28580A0", VA = "0x182859AA0")]
		public void InitCipher(string passphrase)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2859BA0", Offset = "0x28581A0", VA = "0x182859BA0")]
		private void UpdateKeys(byte byteValue)
		{
		}

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x10")]
		private uint[] _Keys;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x18")]
		private CRC32 crc32;
	}
}
