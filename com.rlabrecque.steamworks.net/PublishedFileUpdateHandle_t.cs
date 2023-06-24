using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001DD RID: 477
	[Token(Token = "0x20001DD")]
	[Serializable]
	public struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
	{
		// Token: 0x06000B1C RID: 2844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public PublishedFileUpdateHandle_t(ulong value)
		{
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00009AF4 File Offset: 0x00007CF4
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x98D260", Offset = "0x98B860", VA = "0x18098D260", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00009B0C File Offset: 0x00007D0C
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00009B24 File Offset: 0x00007D24
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00009B3C File Offset: 0x00007D3C
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x98D300", Offset = "0x98B900", VA = "0x18098D300")]
		public static bool operator !=(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00009B54 File Offset: 0x00007D54
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00009B6C File Offset: 0x00007D6C
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(PublishedFileUpdateHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00009B84 File Offset: 0x00007D84
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(PublishedFileUpdateHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00009B9C File Offset: 0x00007D9C
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(PublishedFileUpdateHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000AD2 RID: 2770
		[Token(Token = "0x4000AD2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PublishedFileUpdateHandle_t Invalid;

		// Token: 0x04000AD3 RID: 2771
		[Token(Token = "0x4000AD3")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_PublishedFileUpdateHandle;
	}
}
