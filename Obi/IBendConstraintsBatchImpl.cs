using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	public interface IBendConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x0600044C RID: 1100
		[Token(Token = "0x600044C")]
		void SetBendConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList restBends, ObiNativeVector2List bendingStiffnesses, ObiNativeVector2List plasticity, ObiNativeFloatList lambdas, int count);
	}
}
