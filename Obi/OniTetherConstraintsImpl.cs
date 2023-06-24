using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	public class OniTetherConstraintsImpl : OniConstraintsImpl
	{
		// Token: 0x060004E3 RID: 1251 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x27AD2A0", Offset = "0x27AB8A0", VA = "0x1827AD2A0")]
		public OniTetherConstraintsImpl(OniSolverImpl solver)
		{
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x27AD300", Offset = "0x27AB900", VA = "0x1827AD300", Slot = "9")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x27AD3C0", Offset = "0x27AB9C0", VA = "0x1827AD3C0", Slot = "10")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
