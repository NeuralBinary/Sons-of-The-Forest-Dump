using System;
using Il2CppDummyDll;

namespace Pathfinding.ClipperLib
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public struct IntPoint
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0xF9DB00", Offset = "0xF9C100", VA = "0x180F9DB00")]
		public IntPoint(long X, long Y)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x283A3A0", Offset = "0x28389A0", VA = "0x18283A3A0")]
		public IntPoint(double x, double y)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1E2F3F0", Offset = "0x1E2D9F0", VA = "0x181E2F3F0")]
		public IntPoint(IntPoint pt)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x283A3C0", Offset = "0x28389C0", VA = "0x18283A3C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x283A460", Offset = "0x2838A60", VA = "0x18283A460", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x283A4B0", Offset = "0x2838AB0", VA = "0x18283A4B0")]
		public static bool operator ==(IntPoint a, IntPoint b)
		{
			return default(bool);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x283A4D0", Offset = "0x2838AD0", VA = "0x18283A4D0")]
		public static bool operator !=(IntPoint a, IntPoint b)
		{
			return default(bool);
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x0")]
		public long X;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x8")]
		public long Y;
	}
}
