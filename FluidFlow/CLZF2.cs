using System;
using Il2CppDummyDll;

namespace FluidSimulation
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public static class CLZF2
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000006")]
		[Address(RVA = "0xAFBEB0", Offset = "0xAFA4B0", VA = "0x180AFBEB0")]
		public static byte[] Compress(byte[] inputBytes)
		{
			return null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000007")]
		[Address(RVA = "0xAFBFD0", Offset = "0xAFA5D0", VA = "0x180AFBFD0")]
		public static byte[] Decompress(byte[] inputBytes)
		{
			return null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000008")]
		[Address(RVA = "0xAFC0F0", Offset = "0xAFA6F0", VA = "0x180AFC0F0")]
		public static int lzf_compress(byte[] input, ref byte[] output)
		{
			return 0;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xAFC830", Offset = "0xAFAE30", VA = "0x180AFC830")]
		public static int lzf_decompress(byte[] input, ref byte[] output)
		{
			return 0;
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint HLOG;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x4")]
		private static readonly uint HSIZE;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x8")]
		private static readonly uint MAX_LIT;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0xC")]
		private static readonly uint MAX_OFF;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly uint MAX_REF;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		private static readonly long[] HashTable;
	}
}
