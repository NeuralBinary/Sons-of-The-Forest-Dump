using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001CA RID: 458
	[Token(Token = "0x20001CA")]
	[Serializable]
	public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
	{
		// Token: 0x06000A86 RID: 2694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public HServerQuery(int value)
		{
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x634F00", Offset = "0x633500", VA = "0x180634F00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0000914C File Offset: 0x0000734C
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x98B550", Offset = "0x989B50", VA = "0x18098B550", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00009164 File Offset: 0x00007364
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0000917C File Offset: 0x0000737C
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(HServerQuery x, HServerQuery y)
		{
			return default(bool);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00009194 File Offset: 0x00007394
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x98B5F0", Offset = "0x989BF0", VA = "0x18098B5F0")]
		public static bool operator !=(HServerQuery x, HServerQuery y)
		{
			return default(bool);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000091AC File Offset: 0x000073AC
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator HServerQuery(int value)
		{
			return default(HServerQuery);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000091C4 File Offset: 0x000073C4
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator int(HServerQuery that)
		{
			return 0;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000091DC File Offset: 0x000073DC
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(HServerQuery other)
		{
			return default(bool);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x000091F4 File Offset: 0x000073F4
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x98B0A0", Offset = "0x9896A0", VA = "0x18098B0A0", Slot = "5")]
		public int CompareTo(HServerQuery other)
		{
			return 0;
		}

		// Token: 0x04000AA3 RID: 2723
		[Token(Token = "0x4000AA3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HServerQuery Invalid;

		// Token: 0x04000AA4 RID: 2724
		[Token(Token = "0x4000AA4")]
		[FieldOffset(Offset = "0x0")]
		public int m_HServerQuery;
	}
}
