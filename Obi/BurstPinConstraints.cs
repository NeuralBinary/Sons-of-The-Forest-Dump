using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	public class BurstPinConstraints : BurstConstraintsImpl<BurstPinConstraintsBatch>
	{
		// Token: 0x0600034B RID: 843 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x278C0C0", Offset = "0x278A6C0", VA = "0x18278C0C0")]
		public BurstPinConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x278C110", Offset = "0x278A710", VA = "0x18278C110", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x278C220", Offset = "0x278A820", VA = "0x18278C220", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
