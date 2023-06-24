using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	public interface IAerodynamicConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x0600044B RID: 1099
		[Token(Token = "0x600044B")]
		void SetAerodynamicConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList aerodynamicCoeffs, int count);
	}
}
