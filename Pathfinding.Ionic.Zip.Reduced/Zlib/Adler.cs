using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public sealed class Adler
	{
		// Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Adler()
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x289DA70", Offset = "0x289C070", VA = "0x18289DA70")]
		public static uint Adler32(uint adler, byte[] buf, int index, int len)
		{
			return 0U;
		}

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint BASE;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int NMAX;
	}
}
