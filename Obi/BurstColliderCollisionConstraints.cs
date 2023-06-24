using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	public class BurstColliderCollisionConstraints : BurstConstraintsImpl<BurstColliderCollisionConstraintsBatch>
	{
		// Token: 0x060002EE RID: 750 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2779040", Offset = "0x2777640", VA = "0x182779040")]
		public BurstColliderCollisionConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x2779090", Offset = "0x2777690", VA = "0x182779090", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x27791A0", Offset = "0x27777A0", VA = "0x1827791A0", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2779270", Offset = "0x2777870", VA = "0x182779270", Slot = "15")]
		public override int GetConstraintCount()
		{
			return 0;
		}
	}
}
