using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Testing
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class Screenshot
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3147B40", Offset = "0x3146140", VA = "0x183147B40")]
		public bool Write(string path)
		{
			return default(bool);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x3147E00", Offset = "0x3146400", VA = "0x183147E00")]
		public bool WriteWithExif(string path, string comment)
		{
			return default(bool);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x3147EB0", Offset = "0x31464B0", VA = "0x183147EB0")]
		private static void Completed()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Screenshot()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		public byte[] Bytes;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D Texture;
	}
}
