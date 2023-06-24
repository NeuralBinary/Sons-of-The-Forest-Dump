using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	public interface IPinConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x0600045A RID: 1114
		[Token(Token = "0x600045A")]
		void SetPinConstraints(ObiNativeIntList particleIndices, ObiNativeIntList colliderIndices, ObiNativeVector4List offsets, ObiNativeQuaternionList restDarbouxVectors, ObiNativeFloatList stiffnesses, ObiNativeFloatList lambdas, int count);
	}
}
