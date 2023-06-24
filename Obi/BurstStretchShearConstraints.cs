using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	public class BurstStretchShearConstraints : BurstConstraintsImpl<BurstStretchShearConstraintsBatch>
	{
		// Token: 0x06000374 RID: 884 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x2793BE0", Offset = "0x27921E0", VA = "0x182793BE0")]
		public BurstStretchShearConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x2793C30", Offset = "0x2792230", VA = "0x182793C30", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x2793D40", Offset = "0x2792340", VA = "0x182793D40", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
