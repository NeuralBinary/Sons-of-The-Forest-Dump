using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x20001C5")]
	[Serializable]
	public struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
	{
		// Token: 0x06000A51 RID: 2641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public SteamInventoryResult_t(int value)
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x634F00", Offset = "0x633500", VA = "0x180634F00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00008DA4 File Offset: 0x00006FA4
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x98AFB0", Offset = "0x9895B0", VA = "0x18098AFB0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00008DBC File Offset: 0x00006FBC
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00008DD4 File Offset: 0x00006FD4
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00008DEC File Offset: 0x00006FEC
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x98B050", Offset = "0x989650", VA = "0x18098B050")]
		public static bool operator !=(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00008E04 File Offset: 0x00007004
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator SteamInventoryResult_t(int value)
		{
			return default(SteamInventoryResult_t);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00008E1C File Offset: 0x0000701C
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator int(SteamInventoryResult_t that)
		{
			return 0;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00008E34 File Offset: 0x00007034
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(SteamInventoryResult_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00008E4C File Offset: 0x0000704C
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x98B0A0", Offset = "0x9896A0", VA = "0x18098B0A0", Slot = "5")]
		public int CompareTo(SteamInventoryResult_t other)
		{
			return 0;
		}

		// Token: 0x04000A9A RID: 2714
		[Token(Token = "0x4000A9A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SteamInventoryResult_t Invalid;

		// Token: 0x04000A9B RID: 2715
		[Token(Token = "0x4000A9B")]
		[FieldOffset(Offset = "0x0")]
		public int m_SteamInventoryResult;
	}
}
