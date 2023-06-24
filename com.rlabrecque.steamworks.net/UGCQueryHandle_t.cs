using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E8 RID: 488
	[Token(Token = "0x20001E8")]
	[Serializable]
	public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
	{
		// Token: 0x06000B8D RID: 2957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public UGCQueryHandle_t(ulong value)
		{
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0000A2A4 File Offset: 0x000084A4
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x98E2C0", Offset = "0x98C8C0", VA = "0x18098E2C0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0000A2BC File Offset: 0x000084BC
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0000A2D4 File Offset: 0x000084D4
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0000A2EC File Offset: 0x000084EC
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x98E360", Offset = "0x98C960", VA = "0x18098E360")]
		public static bool operator !=(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0000A304 File Offset: 0x00008504
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator UGCQueryHandle_t(ulong value)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0000A31C File Offset: 0x0000851C
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(UGCQueryHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0000A334 File Offset: 0x00008534
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(UGCQueryHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0000A34C File Offset: 0x0000854C
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(UGCQueryHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000AE7 RID: 2791
		[Token(Token = "0x4000AE7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UGCQueryHandle_t Invalid;

		// Token: 0x04000AE8 RID: 2792
		[Token(Token = "0x4000AE8")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_UGCQueryHandle;
	}
}
