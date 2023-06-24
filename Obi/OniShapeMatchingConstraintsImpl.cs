using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	public class OniShapeMatchingConstraintsImpl : OniConstraintsImpl
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x27AC530", Offset = "0x27AAB30", VA = "0x1827AC530")]
		public OniShapeMatchingConstraintsImpl(OniSolverImpl solver)
		{
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x27AC590", Offset = "0x27AAB90", VA = "0x1827AC590", Slot = "9")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x27AC650", Offset = "0x27AAC50", VA = "0x1827AC650", Slot = "10")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
