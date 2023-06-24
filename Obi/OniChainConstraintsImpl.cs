using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000101")]
	public class OniChainConstraintsImpl : OniConstraintsImpl
	{
		// Token: 0x060004AE RID: 1198 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x27AB5A0", Offset = "0x27A9BA0", VA = "0x1827AB5A0")]
		public OniChainConstraintsImpl(OniSolverImpl solver)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x27AB600", Offset = "0x27A9C00", VA = "0x1827AB600", Slot = "9")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x27AB6C0", Offset = "0x27A9CC0", VA = "0x1827AB6C0", Slot = "10")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
