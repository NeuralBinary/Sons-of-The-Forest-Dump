using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public class BurstParticleFrictionConstraints : BurstConstraintsImpl<BurstParticleFrictionConstraintsBatch>
	{
		// Token: 0x06000340 RID: 832 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2789910", Offset = "0x2787F10", VA = "0x182789910")]
		public BurstParticleFrictionConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2789960", Offset = "0x2787F60", VA = "0x182789960", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2789A70", Offset = "0x2788070", VA = "0x182789A70", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000032E4 File Offset: 0x000014E4
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x2789B40", Offset = "0x2788140", VA = "0x182789B40", Slot = "15")]
		public override int GetConstraintCount()
		{
			return 0;
		}
	}
}
