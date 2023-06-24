using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D0 RID: 464
	[Token(Token = "0x20001D0")]
	[Serializable]
	public struct HSteamListenSocket : IEquatable<HSteamListenSocket>, IComparable<HSteamListenSocket>
	{
		// Token: 0x06000AAD RID: 2733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public HSteamListenSocket(uint value)
		{
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x000093BC File Offset: 0x000075BC
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x98B810", Offset = "0x989E10", VA = "0x18098B810", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x000093D4 File Offset: 0x000075D4
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x000093EC File Offset: 0x000075EC
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(HSteamListenSocket x, HSteamListenSocket y)
		{
			return default(bool);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00009404 File Offset: 0x00007604
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x98B8B0", Offset = "0x989EB0", VA = "0x18098B8B0")]
		public static bool operator !=(HSteamListenSocket x, HSteamListenSocket y)
		{
			return default(bool);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0000941C File Offset: 0x0000761C
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator HSteamListenSocket(uint value)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00009434 File Offset: 0x00007634
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(HSteamListenSocket that)
		{
			return 0U;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0000944C File Offset: 0x0000764C
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(HSteamListenSocket other)
		{
			return default(bool);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00009464 File Offset: 0x00007664
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(HSteamListenSocket other)
		{
			return 0;
		}

		// Token: 0x04000AA7 RID: 2727
		[Token(Token = "0x4000AA7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HSteamListenSocket Invalid;

		// Token: 0x04000AA8 RID: 2728
		[Token(Token = "0x4000AA8")]
		[FieldOffset(Offset = "0x0")]
		public uint m_HSteamListenSocket;
	}
}
