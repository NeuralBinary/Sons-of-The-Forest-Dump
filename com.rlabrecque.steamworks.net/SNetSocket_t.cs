using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001CC RID: 460
	[Token(Token = "0x20001CC")]
	[Serializable]
	public struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
	{
		// Token: 0x06000A9B RID: 2715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public SNetSocket_t(uint value)
		{
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x000092CC File Offset: 0x000074CC
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x98B700", Offset = "0x989D00", VA = "0x18098B700", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x000092E4 File Offset: 0x000074E4
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000092FC File Offset: 0x000074FC
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(SNetSocket_t x, SNetSocket_t y)
		{
			return default(bool);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00009314 File Offset: 0x00007514
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(SNetSocket_t x, SNetSocket_t y)
		{
			return default(bool);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0000932C File Offset: 0x0000752C
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator SNetSocket_t(uint value)
		{
			return default(SNetSocket_t);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00009344 File Offset: 0x00007544
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(SNetSocket_t that)
		{
			return 0U;
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0000935C File Offset: 0x0000755C
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(SNetSocket_t other)
		{
			return default(bool);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00009374 File Offset: 0x00007574
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(SNetSocket_t other)
		{
			return 0;
		}

		// Token: 0x04000AA6 RID: 2726
		[Token(Token = "0x4000AA6")]
		[FieldOffset(Offset = "0x0")]
		public uint m_SNetSocket;
	}
}
