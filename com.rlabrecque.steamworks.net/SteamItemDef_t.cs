using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C7 RID: 455
	[Token(Token = "0x20001C7")]
	[Serializable]
	public struct SteamItemDef_t : IEquatable<SteamItemDef_t>, IComparable<SteamItemDef_t>
	{
		// Token: 0x06000A67 RID: 2663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public SteamItemDef_t(int value)
		{
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x634F00", Offset = "0x633500", VA = "0x180634F00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00008F24 File Offset: 0x00007124
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x98B240", Offset = "0x989840", VA = "0x18098B240", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00008F3C File Offset: 0x0000713C
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00008F54 File Offset: 0x00007154
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(SteamItemDef_t x, SteamItemDef_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00008F6C File Offset: 0x0000716C
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(SteamItemDef_t x, SteamItemDef_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00008F84 File Offset: 0x00007184
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator SteamItemDef_t(int value)
		{
			return default(SteamItemDef_t);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00008F9C File Offset: 0x0000719C
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator int(SteamItemDef_t that)
		{
			return 0;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00008FB4 File Offset: 0x000071B4
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(SteamItemDef_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00008FCC File Offset: 0x000071CC
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x98B0A0", Offset = "0x9896A0", VA = "0x18098B0A0", Slot = "5")]
		public int CompareTo(SteamItemDef_t other)
		{
			return 0;
		}

		// Token: 0x04000A9E RID: 2718
		[Token(Token = "0x4000A9E")]
		[FieldOffset(Offset = "0x0")]
		public int m_SteamItemDef;
	}
}
