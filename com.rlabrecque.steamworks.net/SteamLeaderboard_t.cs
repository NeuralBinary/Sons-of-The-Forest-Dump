using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001EB RID: 491
	[Token(Token = "0x20001EB")]
	[Serializable]
	public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
	{
		// Token: 0x06000BAD RID: 2989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public SteamLeaderboard_t(ulong value)
		{
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0000A4E4 File Offset: 0x000086E4
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x98E5C0", Offset = "0x98CBC0", VA = "0x18098E5C0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0000A4FC File Offset: 0x000086FC
		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0000A514 File Offset: 0x00008714
		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0000A52C File Offset: 0x0000872C
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x8DB2B0", Offset = "0x8D98B0", VA = "0x1808DB2B0")]
		public static bool operator !=(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0000A544 File Offset: 0x00008744
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator SteamLeaderboard_t(ulong value)
		{
			return default(SteamLeaderboard_t);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0000A55C File Offset: 0x0000875C
		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(SteamLeaderboard_t that)
		{
			return 0UL;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0000A574 File Offset: 0x00008774
		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(SteamLeaderboard_t other)
		{
			return default(bool);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0000A58C File Offset: 0x0000878C
		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(SteamLeaderboard_t other)
		{
			return 0;
		}

		// Token: 0x04000AEC RID: 2796
		[Token(Token = "0x4000AEC")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamLeaderboard;
	}
}
