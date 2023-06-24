using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	public interface IStitchConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x0600045E RID: 1118
		[Token(Token = "0x600045E")]
		void SetStitchConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList stiffnesses, ObiNativeFloatList lambdas, int count);
	}
}
