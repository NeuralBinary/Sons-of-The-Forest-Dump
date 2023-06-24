using System;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	internal static class Crc32
	{
		// Token: 0x06000053 RID: 83 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x775CC0", Offset = "0x7742C0", VA = "0x180775CC0")]
		public static int Compute(byte[] data, int offset, int length)
		{
			return 0;
		}

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int SERIALIZER_VERSION;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly uint[] Crc32Table;
	}
}
