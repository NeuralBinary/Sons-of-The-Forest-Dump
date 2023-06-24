using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	public class OniStitchConstraintsBatchImpl : OniConstraintsBatchImpl, IStitchConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x27ACAB0", Offset = "0x27AB0B0", VA = "0x1827ACAB0")]
		public OniStitchConstraintsBatchImpl(OniStitchConstraintsImpl constraints)
		{
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x27ACAC0", Offset = "0x27AB0C0", VA = "0x1827ACAC0", Slot = "11")]
		public void SetStitchConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
