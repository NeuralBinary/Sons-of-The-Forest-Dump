using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	public class OniStretchShearConstraintsImpl : OniConstraintsImpl
	{
		// Token: 0x060004DE RID: 1246 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x27ACF60", Offset = "0x27AB560", VA = "0x1827ACF60")]
		public OniStretchShearConstraintsImpl(OniSolverImpl solver)
		{
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x27ACFC0", Offset = "0x27AB5C0", VA = "0x1827ACFC0", Slot = "9")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x27AD080", Offset = "0x27AB680", VA = "0x1827AD080", Slot = "10")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
