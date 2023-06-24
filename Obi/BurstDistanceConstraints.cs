using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	public class BurstDistanceConstraints : BurstConstraintsImpl<BurstDistanceConstraintsBatch>
	{
		// Token: 0x0600032A RID: 810 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x2784DD0", Offset = "0x27833D0", VA = "0x182784DD0")]
		public BurstDistanceConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x2784E20", Offset = "0x2783420", VA = "0x182784E20", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2784F30", Offset = "0x2783530", VA = "0x182784F30", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
