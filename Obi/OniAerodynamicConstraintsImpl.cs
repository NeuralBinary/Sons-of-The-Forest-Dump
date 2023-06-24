using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	public class OniAerodynamicConstraintsImpl : OniConstraintsImpl
	{
		// Token: 0x0600049F RID: 1183 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x27AABA0", Offset = "0x27A91A0", VA = "0x1827AABA0")]
		public OniAerodynamicConstraintsImpl(OniSolverImpl solver)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x27AAC00", Offset = "0x27A9200", VA = "0x1827AAC00", Slot = "9")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x27AACC0", Offset = "0x27A92C0", VA = "0x1827AACC0", Slot = "10")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
