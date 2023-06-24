using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001BA RID: 442
	[Token(Token = "0x20001BA")]
	[Serializable]
	public struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
	{
		// Token: 0x06000A0F RID: 2575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public HTTPCookieContainerHandle(uint value)
		{
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00008924 File Offset: 0x00006B24
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x98AAD0", Offset = "0x9890D0", VA = "0x18098AAD0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0000893C File Offset: 0x00006B3C
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00008954 File Offset: 0x00006B54
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0000896C File Offset: 0x00006B6C
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x98AB70", Offset = "0x989170", VA = "0x18098AB70")]
		public static bool operator !=(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00008984 File Offset: 0x00006B84
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator HTTPCookieContainerHandle(uint value)
		{
			return default(HTTPCookieContainerHandle);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0000899C File Offset: 0x00006B9C
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(HTTPCookieContainerHandle that)
		{
			return 0U;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000089B4 File Offset: 0x00006BB4
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(HTTPCookieContainerHandle other)
		{
			return default(bool);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000089CC File Offset: 0x00006BCC
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(HTTPCookieContainerHandle other)
		{
			return 0;
		}

		// Token: 0x04000A89 RID: 2697
		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HTTPCookieContainerHandle Invalid;

		// Token: 0x04000A8A RID: 2698
		[Token(Token = "0x4000A8A")]
		[FieldOffset(Offset = "0x0")]
		public uint m_HTTPCookieContainerHandle;
	}
}
