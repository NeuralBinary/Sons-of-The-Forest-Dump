using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	public interface IDistanceConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x06000459 RID: 1113
		[Token(Token = "0x6000459")]
		void SetDistanceConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList restLengths, ObiNativeVector2List stiffnesses, ObiNativeFloatList lambdas, int count);
	}
}
