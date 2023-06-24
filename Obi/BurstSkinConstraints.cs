using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	public class BurstSkinConstraints : BurstConstraintsImpl<BurstSkinConstraintsBatch>
	{
		// Token: 0x06000362 RID: 866 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x2791D10", Offset = "0x2790310", VA = "0x182791D10")]
		public BurstSkinConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x2791D60", Offset = "0x2790360", VA = "0x182791D60", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x2791E70", Offset = "0x2790470", VA = "0x182791E70", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
