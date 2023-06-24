using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000336 RID: 822
	[Token(Token = "0x2000336")]
	public class DiagonalMatrix
	{
		// Token: 0x06001B7D RID: 7037 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B7D")]
		[Address(RVA = "0x1F5CFB0", Offset = "0x1F5B5B0", VA = "0x181F5CFB0")]
		public DiagonalMatrix(int N)
		{
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0x1F5D040", Offset = "0x1F5B640", VA = "0x181F5D040")]
		public void Clear()
		{
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0x1F5D070", Offset = "0x1F5B670", VA = "0x181F5D070")]
		public void Set(int r, int c, double value)
		{
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x00013A84 File Offset: 0x00011C84
		[Token(Token = "0x1700041C")]
		public int Rows
		{
			[Token(Token = "0x6001B80")]
			[Address(RVA = "0xFC64C0", Offset = "0xFC4AC0", VA = "0x180FC64C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x00013A9C File Offset: 0x00011C9C
		[Token(Token = "0x1700041D")]
		public int Columns
		{
			[Token(Token = "0x6001B81")]
			[Address(RVA = "0xFC64C0", Offset = "0xFC4AC0", VA = "0x180FC64C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x00013AB4 File Offset: 0x00011CB4
		[Token(Token = "0x1700041E")]
		public Index2i Size
		{
			[Token(Token = "0x6001B82")]
			[Address(RVA = "0x1F5D100", Offset = "0x1F5B700", VA = "0x181F5D100")]
			get
			{
				return default(Index2i);
			}
		}

		// Token: 0x1700041F RID: 1055
		[Token(Token = "0x1700041F")]
		public double this[int r, int c]
		{
			[Token(Token = "0x6001B83")]
			[Address(RVA = "0x1F04690", Offset = "0x1F02C90", VA = "0x181F04690")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6001B84")]
			[Address(RVA = "0x1F5D130", Offset = "0x1F5B730", VA = "0x181F5D130")]
			set
			{
			}
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x1F5D140", Offset = "0x1F5B740", VA = "0x181F5D140")]
		public void Multiply(double[] X, double[] Result)
		{
		}

		// Token: 0x04000E7D RID: 3709
		[Token(Token = "0x4000E7D")]
		[FieldOffset(Offset = "0x10")]
		public double[] D;
	}
}
