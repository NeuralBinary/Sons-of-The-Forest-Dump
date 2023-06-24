using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	public class BurstVolumeConstraints : BurstConstraintsImpl<BurstVolumeConstraintsBatch>
	{
		// Token: 0x06000386 RID: 902 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x2796060", Offset = "0x2794660", VA = "0x182796060")]
		public BurstVolumeConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x27960B0", Offset = "0x27946B0", VA = "0x1827960B0", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x27961C0", Offset = "0x27947C0", VA = "0x1827961C0", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
