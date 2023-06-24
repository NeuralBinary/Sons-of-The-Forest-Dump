using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	[Serializable]
	public struct InputActionSetHandle_t : IEquatable<InputActionSetHandle_t>, IComparable<InputActionSetHandle_t>
	{
		// Token: 0x06000A25 RID: 2597 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public InputActionSetHandle_t(ulong value)
		{
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00008AA4 File Offset: 0x00006CA4
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x98AD30", Offset = "0x989330", VA = "0x18098AD30", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00008ABC File Offset: 0x00006CBC
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00008AD4 File Offset: 0x00006CD4
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(InputActionSetHandle_t x, InputActionSetHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00008AEC File Offset: 0x00006CEC
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x8DB2B0", Offset = "0x8D98B0", VA = "0x1808DB2B0")]
		public static bool operator !=(InputActionSetHandle_t x, InputActionSetHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00008B04 File Offset: 0x00006D04
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator InputActionSetHandle_t(ulong value)
		{
			return default(InputActionSetHandle_t);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00008B1C File Offset: 0x00006D1C
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(InputActionSetHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00008B34 File Offset: 0x00006D34
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(InputActionSetHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00008B4C File Offset: 0x00006D4C
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(InputActionSetHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000A8D RID: 2701
		[Token(Token = "0x4000A8D")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_InputActionSetHandle;
	}
}
