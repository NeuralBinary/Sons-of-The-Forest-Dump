using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	[Serializable]
	public struct RTime32 : IEquatable<RTime32>, IComparable<RTime32>
	{
		// Token: 0x06000B73 RID: 2931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public RTime32(uint value)
		{
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0000A0F4 File Offset: 0x000082F4
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x98DB70", Offset = "0x98C170", VA = "0x18098DB70", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0000A10C File Offset: 0x0000830C
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0000A124 File Offset: 0x00008324
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(RTime32 x, RTime32 y)
		{
			return default(bool);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0000A13C File Offset: 0x0000833C
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(RTime32 x, RTime32 y)
		{
			return default(bool);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0000A154 File Offset: 0x00008354
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator RTime32(uint value)
		{
			return default(RTime32);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0000A16C File Offset: 0x0000836C
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(RTime32 that)
		{
			return 0U;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0000A184 File Offset: 0x00008384
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(RTime32 other)
		{
			return default(bool);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0000A19C File Offset: 0x0000839C
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(RTime32 other)
		{
			return 0;
		}

		// Token: 0x04000AE1 RID: 2785
		[Token(Token = "0x4000AE1")]
		[FieldOffset(Offset = "0x0")]
		public uint m_RTime32;
	}
}
