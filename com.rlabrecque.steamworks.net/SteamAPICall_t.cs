using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	[Serializable]
	public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
	{
		// Token: 0x06000B7D RID: 2941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public SteamAPICall_t(ulong value)
		{
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0000A1B4 File Offset: 0x000083B4
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x98DBF0", Offset = "0x98C1F0", VA = "0x18098DBF0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0000A1CC File Offset: 0x000083CC
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0000A1E4 File Offset: 0x000083E4
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(SteamAPICall_t x, SteamAPICall_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0000A1FC File Offset: 0x000083FC
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x98DC90", Offset = "0x98C290", VA = "0x18098DC90")]
		public static bool operator !=(SteamAPICall_t x, SteamAPICall_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0000A214 File Offset: 0x00008414
		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator SteamAPICall_t(ulong value)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0000A22C File Offset: 0x0000842C
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(SteamAPICall_t that)
		{
			return 0UL;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0000A244 File Offset: 0x00008444
		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(SteamAPICall_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0000A25C File Offset: 0x0000845C
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(SteamAPICall_t other)
		{
			return 0;
		}

		// Token: 0x04000AE2 RID: 2786
		[Token(Token = "0x4000AE2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SteamAPICall_t Invalid;

		// Token: 0x04000AE3 RID: 2787
		[Token(Token = "0x4000AE3")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamAPICall;
	}
}
