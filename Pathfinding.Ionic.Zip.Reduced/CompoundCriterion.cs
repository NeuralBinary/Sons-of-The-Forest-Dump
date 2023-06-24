using System;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	internal class CompoundCriterion : SelectionCriterion
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CompoundCriterion()
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		internal SelectionCriterion Right
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x2852F50", Offset = "0x2851550", VA = "0x182852F50")]
			set
			{
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2852FC0", Offset = "0x28515C0", VA = "0x182852FC0", Slot = "6")]
		internal override bool Evaluate(string filename)
		{
			return default(bool);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x28530D0", Offset = "0x28516D0", VA = "0x1828530D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x28532A0", Offset = "0x28518A0", VA = "0x1828532A0", Slot = "7")]
		internal override bool Evaluate(ZipEntry entry)
		{
			return default(bool);
		}

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x18")]
		internal LogicalConjunction Conjunction;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x20")]
		internal SelectionCriterion Left;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x28")]
		private SelectionCriterion _Right;
	}
}
