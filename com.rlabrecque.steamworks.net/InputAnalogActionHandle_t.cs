using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001BD RID: 445
	[Token(Token = "0x20001BD")]
	[Serializable]
	public struct InputAnalogActionHandle_t : IEquatable<InputAnalogActionHandle_t>, IComparable<InputAnalogActionHandle_t>
	{
		// Token: 0x06000A2F RID: 2607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public InputAnalogActionHandle_t(ulong value)
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00008B64 File Offset: 0x00006D64
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x98ADB0", Offset = "0x9893B0", VA = "0x18098ADB0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00008B7C File Offset: 0x00006D7C
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00008B94 File Offset: 0x00006D94
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(InputAnalogActionHandle_t x, InputAnalogActionHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00008BAC File Offset: 0x00006DAC
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x8DB2B0", Offset = "0x8D98B0", VA = "0x1808DB2B0")]
		public static bool operator !=(InputAnalogActionHandle_t x, InputAnalogActionHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00008BC4 File Offset: 0x00006DC4
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator InputAnalogActionHandle_t(ulong value)
		{
			return default(InputAnalogActionHandle_t);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00008BDC File Offset: 0x00006DDC
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(InputAnalogActionHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00008BF4 File Offset: 0x00006DF4
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(InputAnalogActionHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00008C0C File Offset: 0x00006E0C
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(InputAnalogActionHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000A8E RID: 2702
		[Token(Token = "0x4000A8E")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_InputAnalogActionHandle;
	}
}
