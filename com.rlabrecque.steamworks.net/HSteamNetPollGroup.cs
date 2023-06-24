using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D2 RID: 466
	[Token(Token = "0x20001D2")]
	[Serializable]
	public struct HSteamNetPollGroup : IEquatable<HSteamNetPollGroup>, IComparable<HSteamNetPollGroup>
	{
		// Token: 0x06000AC3 RID: 2755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public HSteamNetPollGroup(uint value)
		{
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0000953C File Offset: 0x0000773C
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x98BA70", Offset = "0x98A070", VA = "0x18098BA70", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00009554 File Offset: 0x00007754
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0000956C File Offset: 0x0000776C
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(HSteamNetPollGroup x, HSteamNetPollGroup y)
		{
			return default(bool);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00009584 File Offset: 0x00007784
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x98BB10", Offset = "0x98A110", VA = "0x18098BB10")]
		public static bool operator !=(HSteamNetPollGroup x, HSteamNetPollGroup y)
		{
			return default(bool);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0000959C File Offset: 0x0000779C
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator HSteamNetPollGroup(uint value)
		{
			return default(HSteamNetPollGroup);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x000095B4 File Offset: 0x000077B4
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(HSteamNetPollGroup that)
		{
			return 0U;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000095CC File Offset: 0x000077CC
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(HSteamNetPollGroup other)
		{
			return default(bool);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000095E4 File Offset: 0x000077E4
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(HSteamNetPollGroup other)
		{
			return 0;
		}

		// Token: 0x04000AAB RID: 2731
		[Token(Token = "0x4000AAB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HSteamNetPollGroup Invalid;

		// Token: 0x04000AAC RID: 2732
		[Token(Token = "0x4000AAC")]
		[FieldOffset(Offset = "0x0")]
		public uint m_HSteamNetPollGroup;
	}
}
