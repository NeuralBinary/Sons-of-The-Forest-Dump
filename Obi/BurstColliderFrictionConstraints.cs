using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	public class BurstColliderFrictionConstraints : BurstConstraintsImpl<BurstColliderFrictionConstraintsBatch>
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x277BE00", Offset = "0x277A400", VA = "0x18277BE00")]
		public BurstColliderFrictionConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x277BE50", Offset = "0x277A450", VA = "0x18277BE50", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x277BF60", Offset = "0x277A560", VA = "0x18277BF60", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x277C030", Offset = "0x277A630", VA = "0x18277C030", Slot = "15")]
		public override int GetConstraintCount()
		{
			return 0;
		}
	}
}
