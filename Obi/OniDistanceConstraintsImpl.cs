using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	public class OniDistanceConstraintsImpl : OniConstraintsImpl
	{
		// Token: 0x060004B3 RID: 1203 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x27AB8E0", Offset = "0x27A9EE0", VA = "0x1827AB8E0")]
		public OniDistanceConstraintsImpl(OniSolverImpl solver)
		{
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x27AB940", Offset = "0x27A9F40", VA = "0x1827AB940", Slot = "9")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x27ABA00", Offset = "0x27AA000", VA = "0x1827ABA00", Slot = "10")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
