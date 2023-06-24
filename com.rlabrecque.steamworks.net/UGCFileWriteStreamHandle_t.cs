using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001DE RID: 478
	[Token(Token = "0x20001DE")]
	[Serializable]
	public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
	{
		// Token: 0x06000B27 RID: 2855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public UGCFileWriteStreamHandle_t(ulong value)
		{
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00009BB4 File Offset: 0x00007DB4
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x98D3A0", Offset = "0x98B9A0", VA = "0x18098D3A0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00009BCC File Offset: 0x00007DCC
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00009BE4 File Offset: 0x00007DE4
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00009BFC File Offset: 0x00007DFC
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x98D440", Offset = "0x98BA40", VA = "0x18098D440")]
		public static bool operator !=(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00009C14 File Offset: 0x00007E14
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00009C2C File Offset: 0x00007E2C
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(UGCFileWriteStreamHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00009C44 File Offset: 0x00007E44
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(UGCFileWriteStreamHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00009C5C File Offset: 0x00007E5C
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000AD4 RID: 2772
		[Token(Token = "0x4000AD4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UGCFileWriteStreamHandle_t Invalid;

		// Token: 0x04000AD5 RID: 2773
		[Token(Token = "0x4000AD5")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_UGCFileWriteStreamHandle;
	}
}
