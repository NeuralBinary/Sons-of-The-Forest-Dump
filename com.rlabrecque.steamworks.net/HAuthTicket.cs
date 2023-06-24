using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001B2 RID: 434
	[Token(Token = "0x20001B2")]
	[Serializable]
	public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
	{
		// Token: 0x060009EC RID: 2540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public HAuthTicket(uint value)
		{
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000086E4 File Offset: 0x000068E4
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x98A620", Offset = "0x988C20", VA = "0x18098A620", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000086FC File Offset: 0x000068FC
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00008714 File Offset: 0x00006914
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(HAuthTicket x, HAuthTicket y)
		{
			return default(bool);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0000872C File Offset: 0x0000692C
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x98A6C0", Offset = "0x988CC0", VA = "0x18098A6C0")]
		public static bool operator !=(HAuthTicket x, HAuthTicket y)
		{
			return default(bool);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00008744 File Offset: 0x00006944
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator HAuthTicket(uint value)
		{
			return default(HAuthTicket);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0000875C File Offset: 0x0000695C
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(HAuthTicket that)
		{
			return 0U;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00008774 File Offset: 0x00006974
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(HAuthTicket other)
		{
			return default(bool);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0000878C File Offset: 0x0000698C
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(HAuthTicket other)
		{
			return 0;
		}

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HAuthTicket Invalid;

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		[FieldOffset(Offset = "0x0")]
		public uint m_HAuthTicket;
	}
}
