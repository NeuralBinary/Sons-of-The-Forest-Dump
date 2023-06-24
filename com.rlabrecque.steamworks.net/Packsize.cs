using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	public static class Packsize
	{
		// Token: 0x06000941 RID: 2369 RVA: 0x00007C7C File Offset: 0x00005E7C
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x985E90", Offset = "0x984490", VA = "0x180985E90")]
		public static bool Test()
		{
			return default(bool);
		}

		// Token: 0x04000A1F RID: 2591
		[Token(Token = "0x4000A1F")]
		public const int value = 8;

		// Token: 0x020001A5 RID: 421
		[Token(Token = "0x20001A5")]
		private struct ValvePackingSentinel_t
		{
			// Token: 0x04000A20 RID: 2592
			[Token(Token = "0x4000A20")]
			[FieldOffset(Offset = "0x0")]
			private uint m_u32;

			// Token: 0x04000A21 RID: 2593
			[Token(Token = "0x4000A21")]
			[FieldOffset(Offset = "0x8")]
			private ulong m_u64;

			// Token: 0x04000A22 RID: 2594
			[Token(Token = "0x4000A22")]
			[FieldOffset(Offset = "0x10")]
			private ushort m_u16;

			// Token: 0x04000A23 RID: 2595
			[Token(Token = "0x4000A23")]
			[FieldOffset(Offset = "0x18")]
			private double m_d;
		}
	}
}
