using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E9 RID: 489
	[Token(Token = "0x20001E9")]
	[Serializable]
	public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		// Token: 0x06000B98 RID: 2968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public UGCUpdateHandle_t(ulong value)
		{
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0000A364 File Offset: 0x00008564
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x98E400", Offset = "0x98CA00", VA = "0x18098E400", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0000A37C File Offset: 0x0000857C
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0000A394 File Offset: 0x00008594
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0000A3AC File Offset: 0x000085AC
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x98E4A0", Offset = "0x98CAA0", VA = "0x18098E4A0")]
		public static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0000A3C4 File Offset: 0x000085C4
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator UGCUpdateHandle_t(ulong value)
		{
			return default(UGCUpdateHandle_t);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0000A3DC File Offset: 0x000085DC
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(UGCUpdateHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0000A3F4 File Offset: 0x000085F4
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(UGCUpdateHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0000A40C File Offset: 0x0000860C
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(UGCUpdateHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000AE9 RID: 2793
		[Token(Token = "0x4000AE9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UGCUpdateHandle_t Invalid;

		// Token: 0x04000AEA RID: 2794
		[Token(Token = "0x4000AEA")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_UGCUpdateHandle;
	}
}
