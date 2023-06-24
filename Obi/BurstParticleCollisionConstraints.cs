using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	public class BurstParticleCollisionConstraints : BurstConstraintsImpl<BurstParticleCollisionConstraintsBatch>
	{
		// Token: 0x06000334 RID: 820 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x2785FD0", Offset = "0x27845D0", VA = "0x182785FD0")]
		public BurstParticleCollisionConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x2786020", Offset = "0x2784620", VA = "0x182786020", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x2786130", Offset = "0x2784730", VA = "0x182786130", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000326C File Offset: 0x0000146C
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x2786200", Offset = "0x2784800", VA = "0x182786200", Slot = "15")]
		public override int GetConstraintCount()
		{
			return 0;
		}
	}
}
