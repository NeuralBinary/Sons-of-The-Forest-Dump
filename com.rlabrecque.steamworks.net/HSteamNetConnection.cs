using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	[Serializable]
	public struct HSteamNetConnection : IEquatable<HSteamNetConnection>, IComparable<HSteamNetConnection>
	{
		// Token: 0x06000AB8 RID: 2744 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public HSteamNetConnection(uint value)
		{
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0000947C File Offset: 0x0000767C
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x98B940", Offset = "0x989F40", VA = "0x18098B940", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00009494 File Offset: 0x00007694
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x000094AC File Offset: 0x000076AC
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(HSteamNetConnection x, HSteamNetConnection y)
		{
			return default(bool);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x000094C4 File Offset: 0x000076C4
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x98B9E0", Offset = "0x989FE0", VA = "0x18098B9E0")]
		public static bool operator !=(HSteamNetConnection x, HSteamNetConnection y)
		{
			return default(bool);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x000094DC File Offset: 0x000076DC
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator HSteamNetConnection(uint value)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x000094F4 File Offset: 0x000076F4
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(HSteamNetConnection that)
		{
			return 0U;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0000950C File Offset: 0x0000770C
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(HSteamNetConnection other)
		{
			return default(bool);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00009524 File Offset: 0x00007724
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(HSteamNetConnection other)
		{
			return 0;
		}

		// Token: 0x04000AA9 RID: 2729
		[Token(Token = "0x4000AA9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HSteamNetConnection Invalid;

		// Token: 0x04000AAA RID: 2730
		[Token(Token = "0x4000AAA")]
		[FieldOffset(Offset = "0x0")]
		public uint m_HSteamNetConnection;
	}
}
