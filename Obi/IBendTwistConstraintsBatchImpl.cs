using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	public interface IBendTwistConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x0600044D RID: 1101
		[Token(Token = "0x600044D")]
		void SetBendTwistConstraints(ObiNativeIntList orientationIndices, ObiNativeQuaternionList restDarboux, ObiNativeVector3List stiffnesses, ObiNativeVector2List plasticity, ObiNativeFloatList lambdas, int count);
	}
}
