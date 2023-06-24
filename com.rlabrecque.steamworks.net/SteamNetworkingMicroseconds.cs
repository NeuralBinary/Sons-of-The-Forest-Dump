using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x20001D9")]
	[Serializable]
	public struct SteamNetworkingMicroseconds : IEquatable<SteamNetworkingMicroseconds>, IComparable<SteamNetworkingMicroseconds>
	{
		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public SteamNetworkingMicroseconds(long value)
		{
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x98CF60", Offset = "0x98B560", VA = "0x18098CF60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x000097F4 File Offset: 0x000079F4
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x98CF70", Offset = "0x98B570", VA = "0x18098CF70", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0000980C File Offset: 0x00007A0C
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x98CFF0", Offset = "0x98B5F0", VA = "0x18098CFF0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00009824 File Offset: 0x00007A24
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y)
		{
			return default(bool);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0000983C File Offset: 0x00007A3C
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x8DB2B0", Offset = "0x8D98B0", VA = "0x1808DB2B0")]
		public static bool operator !=(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y)
		{
			return default(bool);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00009854 File Offset: 0x00007A54
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator SteamNetworkingMicroseconds(long value)
		{
			return default(SteamNetworkingMicroseconds);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0000986C File Offset: 0x00007A6C
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator long(SteamNetworkingMicroseconds that)
		{
			return 0L;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00009884 File Offset: 0x00007A84
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(SteamNetworkingMicroseconds other)
		{
			return default(bool);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0000989C File Offset: 0x00007A9C
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x98D000", Offset = "0x98B600", VA = "0x18098D000", Slot = "5")]
		public int CompareTo(SteamNetworkingMicroseconds other)
		{
			return 0;
		}

		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4000ACD")]
		[FieldOffset(Offset = "0x0")]
		public long m_SteamNetworkingMicroseconds;
	}
}
