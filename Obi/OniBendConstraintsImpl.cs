using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	public class OniBendConstraintsImpl : OniConstraintsImpl
	{
		// Token: 0x060004A4 RID: 1188 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x27AAF00", Offset = "0x27A9500", VA = "0x1827AAF00")]
		public OniBendConstraintsImpl(OniSolverImpl solver)
		{
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x27AAF60", Offset = "0x27A9560", VA = "0x1827AAF60", Slot = "9")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x27AB020", Offset = "0x27A9620", VA = "0x1827AB020", Slot = "10")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
