using System;
using Il2CppDummyDll;

namespace Pathfinding.ClipperLib
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public struct IntRect
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x283A4F0", Offset = "0x2838AF0", VA = "0x18283A4F0")]
		public IntRect(long l, long t, long r, long b)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1E3D580", Offset = "0x1E3BB80", VA = "0x181E3D580")]
		public IntRect(IntRect ir)
		{
		}

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x0")]
		public long left;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x8")]
		public long top;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x10")]
		public long right;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		public long bottom;
	}
}
