using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E4 RID: 484
	[Token(Token = "0x20001E4")]
	[Serializable]
	public struct PartyBeaconID_t : IEquatable<PartyBeaconID_t>, IComparable<PartyBeaconID_t>
	{
		// Token: 0x06000B68 RID: 2920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public PartyBeaconID_t(ulong value)
		{
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0000A034 File Offset: 0x00008234
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x98DA30", Offset = "0x98C030", VA = "0x18098DA30", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0000A04C File Offset: 0x0000824C
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0000A064 File Offset: 0x00008264
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(PartyBeaconID_t x, PartyBeaconID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0000A07C File Offset: 0x0000827C
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x98DAD0", Offset = "0x98C0D0", VA = "0x18098DAD0")]
		public static bool operator !=(PartyBeaconID_t x, PartyBeaconID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0000A094 File Offset: 0x00008294
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator PartyBeaconID_t(ulong value)
		{
			return default(PartyBeaconID_t);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0000A0AC File Offset: 0x000082AC
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(PartyBeaconID_t that)
		{
			return 0UL;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0000A0C4 File Offset: 0x000082C4
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(PartyBeaconID_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0000A0DC File Offset: 0x000082DC
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(PartyBeaconID_t other)
		{
			return 0;
		}

		// Token: 0x04000ADF RID: 2783
		[Token(Token = "0x4000ADF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PartyBeaconID_t Invalid;

		// Token: 0x04000AE0 RID: 2784
		[Token(Token = "0x4000AE0")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_PartyBeaconID;
	}
}
