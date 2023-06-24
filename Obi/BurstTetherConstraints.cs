using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	public class BurstTetherConstraints : BurstConstraintsImpl<BurstTetherConstraintsBatch>
	{
		// Token: 0x0600037D RID: 893 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x2795220", Offset = "0x2793820", VA = "0x182795220")]
		public BurstTetherConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2795270", Offset = "0x2793870", VA = "0x182795270", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2795380", Offset = "0x2793980", VA = "0x182795380", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
