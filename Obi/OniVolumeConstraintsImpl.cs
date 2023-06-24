using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	public class OniVolumeConstraintsImpl : OniConstraintsImpl
	{
		// Token: 0x060004E8 RID: 1256 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x27AD630", Offset = "0x27ABC30", VA = "0x1827AD630")]
		public OniVolumeConstraintsImpl(OniSolverImpl solver)
		{
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x27AD690", Offset = "0x27ABC90", VA = "0x1827AD690", Slot = "9")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x27AD750", Offset = "0x27ABD50", VA = "0x1827AD750", Slot = "10")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
