using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001BB RID: 443
	[Token(Token = "0x20001BB")]
	[Serializable]
	public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
	{
		// Token: 0x06000A1A RID: 2586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public HTTPRequestHandle(uint value)
		{
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000089E4 File Offset: 0x00006BE4
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x98AC00", Offset = "0x989200", VA = "0x18098AC00", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000089FC File Offset: 0x00006BFC
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00008A14 File Offset: 0x00006C14
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00008A2C File Offset: 0x00006C2C
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x98ACA0", Offset = "0x9892A0", VA = "0x18098ACA0")]
		public static bool operator !=(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00008A44 File Offset: 0x00006C44
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator HTTPRequestHandle(uint value)
		{
			return default(HTTPRequestHandle);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00008A5C File Offset: 0x00006C5C
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(HTTPRequestHandle that)
		{
			return 0U;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00008A74 File Offset: 0x00006C74
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(HTTPRequestHandle other)
		{
			return default(bool);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00008A8C File Offset: 0x00006C8C
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(HTTPRequestHandle other)
		{
			return 0;
		}

		// Token: 0x04000A8B RID: 2699
		[Token(Token = "0x4000A8B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HTTPRequestHandle Invalid;

		// Token: 0x04000A8C RID: 2700
		[Token(Token = "0x4000A8C")]
		[FieldOffset(Offset = "0x0")]
		public uint m_HTTPRequestHandle;
	}
}
