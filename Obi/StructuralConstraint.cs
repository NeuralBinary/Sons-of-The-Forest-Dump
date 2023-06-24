using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	public struct StructuralConstraint
	{
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0000401C File Offset: 0x0000221C
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170000D6")]
		public float restLength
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x27BEF10", Offset = "0x27BD510", VA = "0x1827BEF10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x27BEF70", Offset = "0x27BD570", VA = "0x1827BEF70")]
			set
			{
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x27BEFD0", Offset = "0x27BD5D0", VA = "0x1827BEFD0")]
		public StructuralConstraint(IStructuralConstraintBatch batchIndex, int constraintIndex, float force)
		{
		}

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0x0")]
		public IStructuralConstraintBatch batchIndex;

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x8")]
		public int constraintIndex;

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0xC")]
		public float force;
	}
}
