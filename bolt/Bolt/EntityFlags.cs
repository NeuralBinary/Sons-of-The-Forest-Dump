using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	[Documentation]
	public struct EntityFlags
	{
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x1700012B")]
		public bool IsZero
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x8FF980", Offset = "0x8FDF80", VA = "0x1808FF980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		private EntityFlags(int val)
		{
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x8FF990", Offset = "0x8FDF90", VA = "0x1808FF990", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x8FFA10", Offset = "0x8FE010", VA = "0x1808FFA10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x8EBF80", Offset = "0x8EA580", VA = "0x1808EBF80")]
		public static implicit operator bool(EntityFlags a)
		{
			return default(bool);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator int(EntityFlags a)
		{
			return 0;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator EntityFlags(int a)
		{
			return default(EntityFlags);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x634E90", Offset = "0x633490", VA = "0x180634E90")]
		public static EntityFlags operator &(EntityFlags a, EntityFlags b)
		{
			return default(EntityFlags);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x634EA0", Offset = "0x6334A0", VA = "0x180634EA0")]
		public static EntityFlags operator |(EntityFlags a, EntityFlags b)
		{
			return default(EntityFlags);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x8FFB90", Offset = "0x8FE190", VA = "0x1808FFB90")]
		public static EntityFlags operator ^(EntityFlags a, EntityFlags b)
		{
			return default(EntityFlags);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x634EB0", Offset = "0x6334B0", VA = "0x180634EB0")]
		public static EntityFlags operator ~(EntityFlags a)
		{
			return default(EntityFlags);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(EntityFlags a, EntityFlags b)
		{
			return default(bool);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(EntityFlags a, EntityFlags b)
		{
			return default(bool);
		}

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EntityFlags ZERO;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x4")]
		public static readonly EntityFlags HAS_CONTROL;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x8")]
		public static readonly EntityFlags PERSIST_ON_LOAD;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0xC")]
		public static readonly EntityFlags ATTACHED;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x10")]
		public static readonly EntityFlags CONTROLLER_LOCAL_PREDICTION;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x14")]
		public static readonly EntityFlags SCENE_OBJECT;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x0")]
		private readonly int bits;
	}
}
