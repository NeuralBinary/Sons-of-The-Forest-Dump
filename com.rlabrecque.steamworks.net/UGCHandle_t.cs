using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001DF RID: 479
	[Token(Token = "0x20001DF")]
	[Serializable]
	public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
	{
		// Token: 0x06000B32 RID: 2866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public UGCHandle_t(ulong value)
		{
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00009C74 File Offset: 0x00007E74
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x98D4E0", Offset = "0x98BAE0", VA = "0x18098D4E0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00009C8C File Offset: 0x00007E8C
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00009CA4 File Offset: 0x00007EA4
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(UGCHandle_t x, UGCHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00009CBC File Offset: 0x00007EBC
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x98D580", Offset = "0x98BB80", VA = "0x18098D580")]
		public static bool operator !=(UGCHandle_t x, UGCHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00009CD4 File Offset: 0x00007ED4
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator UGCHandle_t(ulong value)
		{
			return default(UGCHandle_t);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00009CEC File Offset: 0x00007EEC
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(UGCHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00009D04 File Offset: 0x00007F04
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(UGCHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00009D1C File Offset: 0x00007F1C
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(UGCHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000AD6 RID: 2774
		[Token(Token = "0x4000AD6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UGCHandle_t Invalid;

		// Token: 0x04000AD7 RID: 2775
		[Token(Token = "0x4000AD7")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_UGCHandle;
	}
}
