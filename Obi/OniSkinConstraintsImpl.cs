using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	public class OniSkinConstraintsImpl : OniConstraintsImpl
	{
		// Token: 0x060004D4 RID: 1236 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x27AC8C0", Offset = "0x27AAEC0", VA = "0x1827AC8C0")]
		public OniSkinConstraintsImpl(OniSolverImpl solver)
		{
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x27AC920", Offset = "0x27AAF20", VA = "0x1827AC920", Slot = "9")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x27AC9E0", Offset = "0x27AAFE0", VA = "0x1827AC9E0", Slot = "10")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
