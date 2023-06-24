using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	public interface ITetherConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x06000460 RID: 1120
		[Token(Token = "0x6000460")]
		void SetTetherConstraints(ObiNativeIntList particleIndices, ObiNativeVector2List maxLengthScale, ObiNativeFloatList stiffnesses, ObiNativeFloatList lambdas, int count);
	}
}
