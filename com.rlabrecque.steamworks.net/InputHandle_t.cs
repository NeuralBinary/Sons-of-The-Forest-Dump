using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001BF RID: 447
	[Token(Token = "0x20001BF")]
	[Serializable]
	public struct InputHandle_t : IEquatable<InputHandle_t>, IComparable<InputHandle_t>
	{
		// Token: 0x06000A43 RID: 2627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public InputHandle_t(ulong value)
		{
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00008CE4 File Offset: 0x00006EE4
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x98AEB0", Offset = "0x9894B0", VA = "0x18098AEB0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00008CFC File Offset: 0x00006EFC
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00008D14 File Offset: 0x00006F14
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(InputHandle_t x, InputHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00008D2C File Offset: 0x00006F2C
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x8DB2B0", Offset = "0x8D98B0", VA = "0x1808DB2B0")]
		public static bool operator !=(InputHandle_t x, InputHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00008D44 File Offset: 0x00006F44
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator InputHandle_t(ulong value)
		{
			return default(InputHandle_t);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00008D5C File Offset: 0x00006F5C
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(InputHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00008D74 File Offset: 0x00006F74
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(InputHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00008D8C File Offset: 0x00006F8C
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(InputHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000A90 RID: 2704
		[Token(Token = "0x4000A90")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_InputHandle;
	}
}
