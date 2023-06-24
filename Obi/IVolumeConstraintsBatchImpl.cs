using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000F4")]
	public interface IVolumeConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x06000461 RID: 1121
		[Token(Token = "0x6000461")]
		void SetVolumeConstraints(ObiNativeIntList triangles, ObiNativeIntList firstTriangle, ObiNativeIntList numTriangles, ObiNativeFloatList restVolumes, ObiNativeVector2List pressureStiffness, ObiNativeFloatList lambdas, int count);
	}
}
