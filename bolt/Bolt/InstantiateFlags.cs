using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	[Documentation]
	public struct InstantiateFlags
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x1700012C")]
		public bool IsZero
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x8FF980", Offset = "0x8FDF80", VA = "0x1808FF980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		private InstantiateFlags(int val)
		{
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x8FFC60", Offset = "0x8FE260", VA = "0x1808FFC60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x8FFCE0", Offset = "0x8FE2E0", VA = "0x1808FFCE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x8EBF80", Offset = "0x8EA580", VA = "0x1808EBF80")]
		public static implicit operator bool(InstantiateFlags a)
		{
			return default(bool);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator int(InstantiateFlags a)
		{
			return 0;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator InstantiateFlags(int a)
		{
			return default(InstantiateFlags);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x634E90", Offset = "0x633490", VA = "0x180634E90")]
		public static InstantiateFlags operator &(InstantiateFlags a, InstantiateFlags b)
		{
			return default(InstantiateFlags);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x634EA0", Offset = "0x6334A0", VA = "0x180634EA0")]
		public static InstantiateFlags operator |(InstantiateFlags a, InstantiateFlags b)
		{
			return default(InstantiateFlags);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x8FFB90", Offset = "0x8FE190", VA = "0x1808FFB90")]
		public static InstantiateFlags operator ^(InstantiateFlags a, InstantiateFlags b)
		{
			return default(InstantiateFlags);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x634EB0", Offset = "0x6334B0", VA = "0x180634EB0")]
		public static InstantiateFlags operator ~(InstantiateFlags a)
		{
			return default(InstantiateFlags);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(InstantiateFlags a, InstantiateFlags b)
		{
			return default(bool);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(InstantiateFlags a, InstantiateFlags b)
		{
			return default(bool);
		}

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x0")]
		public static readonly InstantiateFlags ZERO;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x4")]
		public static readonly InstantiateFlags TAKE_CONTROL;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly InstantiateFlags ASSIGN_CONTROL;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x0")]
		private readonly int bits;
	}
}
