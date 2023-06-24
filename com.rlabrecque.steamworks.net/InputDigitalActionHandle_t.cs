using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001BE RID: 446
	[Token(Token = "0x20001BE")]
	[Serializable]
	public struct InputDigitalActionHandle_t : IEquatable<InputDigitalActionHandle_t>, IComparable<InputDigitalActionHandle_t>
	{
		// Token: 0x06000A39 RID: 2617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public InputDigitalActionHandle_t(ulong value)
		{
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00008C24 File Offset: 0x00006E24
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x98AE30", Offset = "0x989430", VA = "0x18098AE30", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00008C3C File Offset: 0x00006E3C
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00008C54 File Offset: 0x00006E54
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00008C6C File Offset: 0x00006E6C
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x8DB2B0", Offset = "0x8D98B0", VA = "0x1808DB2B0")]
		public static bool operator !=(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00008C84 File Offset: 0x00006E84
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator InputDigitalActionHandle_t(ulong value)
		{
			return default(InputDigitalActionHandle_t);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00008C9C File Offset: 0x00006E9C
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(InputDigitalActionHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00008CB4 File Offset: 0x00006EB4
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(InputDigitalActionHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00008CCC File Offset: 0x00006ECC
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(InputDigitalActionHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000A8F RID: 2703
		[Token(Token = "0x4000A8F")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_InputDigitalActionHandle;
	}
}
