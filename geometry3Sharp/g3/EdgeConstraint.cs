using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200024F RID: 591
	[Token(Token = "0x200024F")]
	public struct EdgeConstraint
	{
		// Token: 0x060014FA RID: 5370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x1E8C330", Offset = "0x1E8A930", VA = "0x181E8C330")]
		public EdgeConstraint(EdgeRefineFlags rflags)
		{
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x1E8C3A0", Offset = "0x1E8A9A0", VA = "0x181E8C3A0")]
		public EdgeConstraint(EdgeRefineFlags rflags, IProjectionTarget target)
		{
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x0001037C File Offset: 0x0000E57C
		[Token(Token = "0x17000351")]
		public bool CanFlip
		{
			[Token(Token = "0x60014FC")]
			[Address(RVA = "0x1E8C410", Offset = "0x1E8AA10", VA = "0x181E8C410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x00010394 File Offset: 0x0000E594
		[Token(Token = "0x17000352")]
		public bool CanSplit
		{
			[Token(Token = "0x60014FD")]
			[Address(RVA = "0x1E8C420", Offset = "0x1E8AA20", VA = "0x181E8C420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x000103AC File Offset: 0x0000E5AC
		[Token(Token = "0x17000353")]
		public bool CanCollapse
		{
			[Token(Token = "0x60014FE")]
			[Address(RVA = "0x1E8C430", Offset = "0x1E8AA30", VA = "0x181E8C430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x000103C4 File Offset: 0x0000E5C4
		[Token(Token = "0x17000354")]
		public bool NoModifications
		{
			[Token(Token = "0x60014FF")]
			[Address(RVA = "0x1E8C440", Offset = "0x1E8AA40", VA = "0x181E8C440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x000103DC File Offset: 0x0000E5DC
		[Token(Token = "0x17000355")]
		public bool IsUnconstrained
		{
			[Token(Token = "0x6001500")]
			[Address(RVA = "0x1E8C450", Offset = "0x1E8AA50", VA = "0x181E8C450")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040009C7 RID: 2503
		[Token(Token = "0x40009C7")]
		[FieldOffset(Offset = "0x0")]
		private EdgeRefineFlags refineFlags;

		// Token: 0x040009C8 RID: 2504
		[Token(Token = "0x40009C8")]
		[FieldOffset(Offset = "0x8")]
		public IProjectionTarget Target;

		// Token: 0x040009C9 RID: 2505
		[Token(Token = "0x40009C9")]
		[FieldOffset(Offset = "0x10")]
		public int TrackingSetID;

		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x40009CA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EdgeConstraint Unconstrained;

		// Token: 0x040009CB RID: 2507
		[Token(Token = "0x40009CB")]
		[FieldOffset(Offset = "0x18")]
		public static readonly EdgeConstraint NoFlips;

		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x40009CC")]
		[FieldOffset(Offset = "0x30")]
		public static readonly EdgeConstraint FullyConstrained;
	}
}
