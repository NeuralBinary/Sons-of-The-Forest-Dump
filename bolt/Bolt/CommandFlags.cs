using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	[Documentation]
	public struct CommandFlags
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x1700012E")]
		public bool IsZero
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x8FF980", Offset = "0x8FDF80", VA = "0x1808FF980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		private CommandFlags(int val)
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x900190", Offset = "0x8FE790", VA = "0x180900190", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x900210", Offset = "0x8FE810", VA = "0x180900210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x8EBF80", Offset = "0x8EA580", VA = "0x1808EBF80")]
		public static implicit operator bool(CommandFlags a)
		{
			return default(bool);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator int(CommandFlags a)
		{
			return 0;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator CommandFlags(int a)
		{
			return default(CommandFlags);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x634E90", Offset = "0x633490", VA = "0x180634E90")]
		public static CommandFlags operator &(CommandFlags a, CommandFlags b)
		{
			return default(CommandFlags);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x634EA0", Offset = "0x6334A0", VA = "0x180634EA0")]
		public static CommandFlags operator |(CommandFlags a, CommandFlags b)
		{
			return default(CommandFlags);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x8FFB90", Offset = "0x8FE190", VA = "0x1808FFB90")]
		public static CommandFlags operator ^(CommandFlags a, CommandFlags b)
		{
			return default(CommandFlags);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x634EB0", Offset = "0x6334B0", VA = "0x180634EB0")]
		public static CommandFlags operator ~(CommandFlags a)
		{
			return default(CommandFlags);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00004770 File Offset: 0x00002970
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(CommandFlags a, CommandFlags b)
		{
			return default(bool);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(CommandFlags a, CommandFlags b)
		{
			return default(bool);
		}

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CommandFlags ZERO;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x4")]
		public static readonly CommandFlags HAS_EXECUTED;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x8")]
		public static readonly CommandFlags SEND_STATE;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0xC")]
		public static readonly CommandFlags SEND_STATE_PERFORMED;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly CommandFlags CORRECTION_RECEIVED;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x14")]
		public static readonly CommandFlags DISPOSE;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly CommandFlags MISSING;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x0")]
		private readonly int bits;
	}
}
