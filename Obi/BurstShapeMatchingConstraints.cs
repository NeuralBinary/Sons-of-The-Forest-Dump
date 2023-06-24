using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	public class BurstShapeMatchingConstraints : BurstConstraintsImpl<BurstShapeMatchingConstraintsBatch>
	{
		// Token: 0x06000354 RID: 852 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x278E300", Offset = "0x278C900", VA = "0x18278E300")]
		public BurstShapeMatchingConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x278E350", Offset = "0x278C950", VA = "0x18278E350", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x278E460", Offset = "0x278CA60", VA = "0x18278E460", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
