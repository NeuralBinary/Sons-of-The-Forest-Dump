using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	public interface ISkinConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x0600045D RID: 1117
		[Token(Token = "0x600045D")]
		void SetSkinConstraints(ObiNativeIntList particleIndices, ObiNativeVector4List skinPoints, ObiNativeVector4List skinNormals, ObiNativeFloatList skinRadiiBackstop, ObiNativeFloatList skinCompliance, ObiNativeFloatList lambdas, int count);
	}
}
