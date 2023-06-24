using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	[Serializable]
	public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
	{
		// Token: 0x06000B5D RID: 2909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public DepotId_t(uint value)
		{
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00009F74 File Offset: 0x00008174
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x98D900", Offset = "0x98BF00", VA = "0x18098D900", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00009F8C File Offset: 0x0000818C
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00009FA4 File Offset: 0x000081A4
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(DepotId_t x, DepotId_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00009FBC File Offset: 0x000081BC
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x98D9A0", Offset = "0x98BFA0", VA = "0x18098D9A0")]
		public static bool operator !=(DepotId_t x, DepotId_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00009FD4 File Offset: 0x000081D4
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator DepotId_t(uint value)
		{
			return default(DepotId_t);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00009FEC File Offset: 0x000081EC
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(DepotId_t that)
		{
			return 0U;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0000A004 File Offset: 0x00008204
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(DepotId_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0000A01C File Offset: 0x0000821C
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(DepotId_t other)
		{
			return 0;
		}

		// Token: 0x04000ADD RID: 2781
		[Token(Token = "0x4000ADD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DepotId_t Invalid;

		// Token: 0x04000ADE RID: 2782
		[Token(Token = "0x4000ADE")]
		[FieldOffset(Offset = "0x0")]
		public uint m_DepotId;
	}
}
