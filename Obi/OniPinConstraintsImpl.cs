using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	public class OniPinConstraintsImpl : OniConstraintsImpl
	{
		// Token: 0x060004C9 RID: 1225 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x27ABFA0", Offset = "0x27AA5A0", VA = "0x1827ABFA0")]
		public OniPinConstraintsImpl(OniSolverImpl solver)
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x27AC000", Offset = "0x27AA600", VA = "0x1827AC000", Slot = "9")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x27AC0C0", Offset = "0x27AA6C0", VA = "0x1827AC0C0", Slot = "10")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
