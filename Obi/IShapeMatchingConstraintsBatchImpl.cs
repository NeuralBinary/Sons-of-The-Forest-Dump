using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	public interface IShapeMatchingConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x0600045B RID: 1115
		[Token(Token = "0x600045B")]
		void SetShapeMatchingConstraints(ObiNativeIntList particleIndices, ObiNativeIntList firstIndex, ObiNativeIntList numIndices, ObiNativeIntList explicitGroup, ObiNativeFloatList shapeMaterialParameters, ObiNativeVector4List restComs, ObiNativeVector4List coms, ObiNativeQuaternionList orientations, ObiNativeFloatList lambdas, int count);

		// Token: 0x0600045C RID: 1116
		[Token(Token = "0x600045C")]
		void CalculateRestShapeMatching();
	}
}
