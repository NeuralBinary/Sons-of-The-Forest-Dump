using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x20001C8")]
	[Serializable]
	public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t>
	{
		// Token: 0x06000A71 RID: 2673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public SteamItemInstanceID_t(ulong value)
		{
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00008FE4 File Offset: 0x000071E4
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x98B2C0", Offset = "0x9898C0", VA = "0x18098B2C0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00008FFC File Offset: 0x000071FC
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00009014 File Offset: 0x00007214
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0000902C File Offset: 0x0000722C
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x98B360", Offset = "0x989960", VA = "0x18098B360")]
		public static bool operator !=(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00009044 File Offset: 0x00007244
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator SteamItemInstanceID_t(ulong value)
		{
			return default(SteamItemInstanceID_t);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0000905C File Offset: 0x0000725C
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(SteamItemInstanceID_t that)
		{
			return 0UL;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00009074 File Offset: 0x00007274
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(SteamItemInstanceID_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0000908C File Offset: 0x0000728C
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(SteamItemInstanceID_t other)
		{
			return 0;
		}

		// Token: 0x04000A9F RID: 2719
		[Token(Token = "0x4000A9F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SteamItemInstanceID_t Invalid;

		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4000AA0")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamItemInstanceID;
	}
}
