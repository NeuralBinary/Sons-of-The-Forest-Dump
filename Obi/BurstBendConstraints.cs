using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	public class BurstBendConstraints : BurstConstraintsImpl<BurstBendConstraintsBatch>
	{
		// Token: 0x060002B3 RID: 691 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2774C40", Offset = "0x2773240", VA = "0x182774C40")]
		public BurstBendConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2774C90", Offset = "0x2773290", VA = "0x182774C90", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2774DA0", Offset = "0x27733A0", VA = "0x182774DA0", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
