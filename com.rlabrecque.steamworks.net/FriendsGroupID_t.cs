using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001B8 RID: 440
	[Token(Token = "0x20001B8")]
	[Serializable]
	public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
	{
		// Token: 0x060009F9 RID: 2553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x9895E0", Offset = "0x987BE0", VA = "0x1809895E0")]
		public FriendsGroupID_t(short value)
		{
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x98A800", Offset = "0x988E00", VA = "0x18098A800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000087A4 File Offset: 0x000069A4
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x98A810", Offset = "0x988E10", VA = "0x18098A810", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000087BC File Offset: 0x000069BC
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x98A8B0", Offset = "0x988EB0", VA = "0x18098A8B0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x000087D4 File Offset: 0x000069D4
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x98A8C0", Offset = "0x988EC0", VA = "0x18098A8C0")]
		public static bool operator ==(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return default(bool);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000087EC File Offset: 0x000069EC
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x98A8D0", Offset = "0x988ED0", VA = "0x18098A8D0")]
		public static bool operator !=(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return default(bool);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00008804 File Offset: 0x00006A04
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x98A930", Offset = "0x988F30", VA = "0x18098A930")]
		public static explicit operator FriendsGroupID_t(short value)
		{
			return default(FriendsGroupID_t);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0000881C File Offset: 0x00006A1C
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x98A930", Offset = "0x988F30", VA = "0x18098A930")]
		public static explicit operator short(FriendsGroupID_t that)
		{
			return 0;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00008834 File Offset: 0x00006A34
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x98A940", Offset = "0x988F40", VA = "0x18098A940", Slot = "4")]
		public bool Equals(FriendsGroupID_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0000884C File Offset: 0x00006A4C
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x98A950", Offset = "0x988F50", VA = "0x18098A950", Slot = "5")]
		public int CompareTo(FriendsGroupID_t other)
		{
			return 0;
		}

		// Token: 0x04000A85 RID: 2693
		[Token(Token = "0x4000A85")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FriendsGroupID_t Invalid;

		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		[FieldOffset(Offset = "0x0")]
		public short m_FriendsGroupID;
	}
}
