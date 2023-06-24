using System;
using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.BZip2
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	internal class BitWriter
	{
		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public BitWriter(Stream s)
		{
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600034E RID: 846 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x170000D4")]
		public byte RemainingBits
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x28883D0", Offset = "0x28869D0", VA = "0x1828883D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x170000D5")]
		public int NumRemainingBits
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x170000D6")]
		public int TotalBytesWrittenOut
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x28883E0", Offset = "0x28869E0", VA = "0x1828883E0")]
		public void Reset()
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x2888440", Offset = "0x2886A40", VA = "0x182888440")]
		public void WriteBits(int nbits, uint value)
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x28884E0", Offset = "0x2886AE0", VA = "0x1828884E0")]
		public void WriteByte(byte b)
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x28884F0", Offset = "0x2886AF0", VA = "0x1828884F0")]
		public void WriteInt(uint u)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x2888560", Offset = "0x2886B60", VA = "0x182888560")]
		public void Flush()
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x2888570", Offset = "0x2886B70", VA = "0x182888570")]
		public void FinishAndPad()
		{
		}

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x10")]
		private uint accumulator;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x14")]
		private int nAccumulatedBits;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x18")]
		private Stream output;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x20")]
		private int totalBytesWrittenOut;
	}
}
