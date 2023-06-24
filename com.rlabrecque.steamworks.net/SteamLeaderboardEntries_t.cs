using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	[Serializable]
	public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		// Token: 0x06000BA3 RID: 2979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public SteamLeaderboardEntries_t(ulong value)
		{
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0000A424 File Offset: 0x00008624
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x98E540", Offset = "0x98CB40", VA = "0x18098E540", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0000A43C File Offset: 0x0000863C
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0000A454 File Offset: 0x00008654
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0000A46C File Offset: 0x0000866C
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x8DB2B0", Offset = "0x8D98B0", VA = "0x1808DB2B0")]
		public static bool operator !=(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0000A484 File Offset: 0x00008684
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator SteamLeaderboardEntries_t(ulong value)
		{
			return default(SteamLeaderboardEntries_t);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0000A49C File Offset: 0x0000869C
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(SteamLeaderboardEntries_t that)
		{
			return 0UL;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0000A4B4 File Offset: 0x000086B4
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(SteamLeaderboardEntries_t other)
		{
			return default(bool);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0000A4CC File Offset: 0x000086CC
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(SteamLeaderboardEntries_t other)
		{
			return 0;
		}

		// Token: 0x04000AEB RID: 2795
		[Token(Token = "0x4000AEB")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamLeaderboardEntries;
	}
}
