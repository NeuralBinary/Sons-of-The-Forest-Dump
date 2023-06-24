using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	public class OniBendTwistConstraintsBatchImpl : OniConstraintsBatchImpl, IBendTwistConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060004A7 RID: 1191 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x27AB0F0", Offset = "0x27A96F0", VA = "0x1827AB0F0")]
		public OniBendTwistConstraintsBatchImpl(OniBendTwistConstraintsImpl constraints)
		{
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x27AB100", Offset = "0x27A9700", VA = "0x1827AB100", Slot = "11")]
		public void SetBendTwistConstraints(ObiNativeIntList orientationIndices, ObiNativeQuaternionList restOrientations, ObiNativeVector3List stiffnesses, ObiNativeVector2List plasticity, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
