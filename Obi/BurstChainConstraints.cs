using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public class BurstChainConstraints : BurstConstraintsImpl<BurstChainConstraintsBatch>
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x27776D0", Offset = "0x2775CD0", VA = "0x1827776D0")]
		public BurstChainConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x2777720", Offset = "0x2775D20", VA = "0x182777720", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2777830", Offset = "0x2775E30", VA = "0x182777830", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
