using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	public class BurstAerodynamicConstraints : BurstConstraintsImpl<BurstAerodynamicConstraintsBatch>
	{
		// Token: 0x060002AA RID: 682 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x27740E0", Offset = "0x27726E0", VA = "0x1827740E0")]
		public BurstAerodynamicConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2774130", Offset = "0x2772730", VA = "0x182774130", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2774240", Offset = "0x2772840", VA = "0x182774240", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
