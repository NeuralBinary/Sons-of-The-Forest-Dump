using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	public class BurstBendTwistConstraints : BurstConstraintsImpl<BurstBendTwistConstraintsBatch>
	{
		// Token: 0x060002BC RID: 700 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2775E30", Offset = "0x2774430", VA = "0x182775E30")]
		public BurstBendTwistConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2775E80", Offset = "0x2774480", VA = "0x182775E80", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2775F90", Offset = "0x2774590", VA = "0x182775F90", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
