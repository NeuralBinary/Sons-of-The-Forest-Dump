using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	public class OniBendTwistConstraintsImpl : OniConstraintsImpl
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x27AB270", Offset = "0x27A9870", VA = "0x1827AB270")]
		public OniBendTwistConstraintsImpl(OniSolverImpl solver)
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x27AB2D0", Offset = "0x27A98D0", VA = "0x1827AB2D0", Slot = "9")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x27AB390", Offset = "0x27A9990", VA = "0x1827AB390", Slot = "10")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
