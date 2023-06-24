using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	public class ByteReader
	{
		// Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public ByteReader(byte[] bytes)
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x2662C40", Offset = "0x2661240", VA = "0x182662C40")]
		public ByteReader(TextAsset asset)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x2662CF0", Offset = "0x26612F0", VA = "0x182662CF0")]
		public static ByteReader Open(string path)
		{
			return null;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x170000E5")]
		public bool canRead
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x2662E10", Offset = "0x2661410", VA = "0x182662E10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x2662E30", Offset = "0x2661430", VA = "0x182662E30")]
		private static string ReadLine(byte[] buffer, int start, int count)
		{
			return null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x2662E90", Offset = "0x2661490", VA = "0x182662E90")]
		public string ReadLine()
		{
			return null;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2662EA0", Offset = "0x26614A0", VA = "0x182662EA0")]
		public string ReadLine(bool skipEmptyLines)
		{
			return null;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2662FC0", Offset = "0x26615C0", VA = "0x182662FC0")]
		public Dictionary<string, string> ReadDictionary()
		{
			return null;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x26631A0", Offset = "0x26617A0", VA = "0x1826631A0")]
		public BetterList<string> ReadCSV()
		{
			return null;
		}

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x10")]
		private byte[] mBuffer;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x18")]
		private int mOffset;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x0")]
		private static BetterList<string> mTemp;
	}
}
