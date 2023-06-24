using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200010E RID: 270
	[Token(Token = "0x200010E")]
	public class OniStitchConstraintsImpl : OniConstraintsImpl
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x27ACBD0", Offset = "0x27AB1D0", VA = "0x1827ACBD0")]
		public OniStitchConstraintsImpl(OniSolverImpl solver)
		{
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x27ACC30", Offset = "0x27AB230", VA = "0x1827ACC30", Slot = "9")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x27ACCF0", Offset = "0x27AB2F0", VA = "0x1827ACCF0", Slot = "10")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
