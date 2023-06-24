using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	public class OniStretchShearConstraintsBatchImpl : OniConstraintsBatchImpl, IStretchShearConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x27ACDC0", Offset = "0x27AB3C0", VA = "0x1827ACDC0")]
		public OniStretchShearConstraintsBatchImpl(OniStretchShearConstraintsImpl constraints)
		{
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x27ACDD0", Offset = "0x27AB3D0", VA = "0x1827ACDD0", Slot = "11")]
		public void SetStretchShearConstraints(ObiNativeIntList particleIndices, ObiNativeIntList orientationIndices, ObiNativeFloatList restLengths, ObiNativeQuaternionList restOrientations, ObiNativeVector3List stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
