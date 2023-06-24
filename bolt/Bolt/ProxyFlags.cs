using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	[Documentation]
	public struct ProxyFlags
	{
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x1700012D")]
		public bool IsZero
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x8FF980", Offset = "0x8FDF80", VA = "0x1808FF980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		private ProxyFlags(int val)
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x8FFE70", Offset = "0x8FE470", VA = "0x1808FFE70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x8FFEF0", Offset = "0x8FE4F0", VA = "0x1808FFEF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x8EBF80", Offset = "0x8EA580", VA = "0x1808EBF80")]
		public static implicit operator bool(ProxyFlags a)
		{
			return default(bool);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator int(ProxyFlags a)
		{
			return 0;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator ProxyFlags(int a)
		{
			return default(ProxyFlags);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x634E90", Offset = "0x633490", VA = "0x180634E90")]
		public static ProxyFlags operator &(ProxyFlags a, ProxyFlags b)
		{
			return default(ProxyFlags);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x634EA0", Offset = "0x6334A0", VA = "0x180634EA0")]
		public static ProxyFlags operator |(ProxyFlags a, ProxyFlags b)
		{
			return default(ProxyFlags);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x8FFB90", Offset = "0x8FE190", VA = "0x1808FFB90")]
		public static ProxyFlags operator ^(ProxyFlags a, ProxyFlags b)
		{
			return default(ProxyFlags);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x634EB0", Offset = "0x6334B0", VA = "0x180634EB0")]
		public static ProxyFlags operator ~(ProxyFlags a)
		{
			return default(ProxyFlags);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(ProxyFlags a, ProxyFlags b)
		{
			return default(bool);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(ProxyFlags a, ProxyFlags b)
		{
			return default(bool);
		}

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ProxyFlags ZERO;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x4")]
		public static readonly ProxyFlags CREATE_REQUESTED;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ProxyFlags CREATE_DONE;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0xC")]
		public static readonly ProxyFlags DESTROY_REQUESTED;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ProxyFlags DESTROY_PENDING;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x14")]
		public static readonly ProxyFlags DESTROY_IGNORE;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ProxyFlags IDLE;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly ProxyFlags FORCE_SYNC;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x0")]
		private readonly int bits;
	}
}
