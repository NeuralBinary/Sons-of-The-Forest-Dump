using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	public class BurstStitchConstraints : BurstConstraintsImpl<BurstStitchConstraintsBatch>
	{
		// Token: 0x0600036B RID: 875 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2792D40", Offset = "0x2791340", VA = "0x182792D40")]
		public BurstStitchConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x2792D90", Offset = "0x2791390", VA = "0x182792D90", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x2792EA0", Offset = "0x27914A0", VA = "0x182792EA0", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
