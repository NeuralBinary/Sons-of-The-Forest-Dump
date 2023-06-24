using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001CB RID: 459
	[Token(Token = "0x20001CB")]
	[Serializable]
	public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
	{
		// Token: 0x06000A91 RID: 2705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public SNetListenSocket_t(uint value)
		{
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0000920C File Offset: 0x0000740C
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x98B680", Offset = "0x989C80", VA = "0x18098B680", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00009224 File Offset: 0x00007424
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0000923C File Offset: 0x0000743C
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00009254 File Offset: 0x00007454
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0000926C File Offset: 0x0000746C
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator SNetListenSocket_t(uint value)
		{
			return default(SNetListenSocket_t);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00009284 File Offset: 0x00007484
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(SNetListenSocket_t that)
		{
			return 0U;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0000929C File Offset: 0x0000749C
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(SNetListenSocket_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000092B4 File Offset: 0x000074B4
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(SNetListenSocket_t other)
		{
			return 0;
		}

		// Token: 0x04000AA5 RID: 2725
		[Token(Token = "0x4000AA5")]
		[FieldOffset(Offset = "0x0")]
		public uint m_SNetListenSocket;
	}
}
