using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	[Serializable]
	public struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
	{
		// Token: 0x06000B3D RID: 2877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public ScreenshotHandle(uint value)
		{
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00009D34 File Offset: 0x00007F34
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x98D620", Offset = "0x98BC20", VA = "0x18098D620", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00009D4C File Offset: 0x00007F4C
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00009D64 File Offset: 0x00007F64
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(ScreenshotHandle x, ScreenshotHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00009D7C File Offset: 0x00007F7C
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x98D6C0", Offset = "0x98BCC0", VA = "0x18098D6C0")]
		public static bool operator !=(ScreenshotHandle x, ScreenshotHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00009D94 File Offset: 0x00007F94
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator ScreenshotHandle(uint value)
		{
			return default(ScreenshotHandle);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00009DAC File Offset: 0x00007FAC
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(ScreenshotHandle that)
		{
			return 0U;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00009DC4 File Offset: 0x00007FC4
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(ScreenshotHandle other)
		{
			return default(bool);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00009DDC File Offset: 0x00007FDC
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(ScreenshotHandle other)
		{
			return 0;
		}

		// Token: 0x04000AD8 RID: 2776
		[Token(Token = "0x4000AD8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ScreenshotHandle Invalid;

		// Token: 0x04000AD9 RID: 2777
		[Token(Token = "0x4000AD9")]
		[FieldOffset(Offset = "0x0")]
		public uint m_ScreenshotHandle;
	}
}
