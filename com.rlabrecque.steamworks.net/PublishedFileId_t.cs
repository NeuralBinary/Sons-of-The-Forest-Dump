using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	[Serializable]
	public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
	{
		// Token: 0x06000B11 RID: 2833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public PublishedFileId_t(ulong value)
		{
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00009A34 File Offset: 0x00007C34
		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x98D120", Offset = "0x98B720", VA = "0x18098D120", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00009A4C File Offset: 0x00007C4C
		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00009A64 File Offset: 0x00007C64
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(PublishedFileId_t x, PublishedFileId_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00009A7C File Offset: 0x00007C7C
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x98D1C0", Offset = "0x98B7C0", VA = "0x18098D1C0")]
		public static bool operator !=(PublishedFileId_t x, PublishedFileId_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00009A94 File Offset: 0x00007C94
		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator PublishedFileId_t(ulong value)
		{
			return default(PublishedFileId_t);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00009AAC File Offset: 0x00007CAC
		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(PublishedFileId_t that)
		{
			return 0UL;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00009AC4 File Offset: 0x00007CC4
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(PublishedFileId_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00009ADC File Offset: 0x00007CDC
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(PublishedFileId_t other)
		{
			return 0;
		}

		// Token: 0x04000AD0 RID: 2768
		[Token(Token = "0x4000AD0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PublishedFileId_t Invalid;

		// Token: 0x04000AD1 RID: 2769
		[Token(Token = "0x4000AD1")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_PublishedFileId;
	}
}
