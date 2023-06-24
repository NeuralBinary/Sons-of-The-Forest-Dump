using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	public interface IStretchShearConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x0600045F RID: 1119
		[Token(Token = "0x600045F")]
		void SetStretchShearConstraints(ObiNativeIntList particleIndices, ObiNativeIntList orientationIndices, ObiNativeFloatList restLengths, ObiNativeQuaternionList restOrientations, ObiNativeVector3List stiffnesses, ObiNativeFloatList lambdas, int count);
	}
}
