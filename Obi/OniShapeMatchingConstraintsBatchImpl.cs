using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	public class OniShapeMatchingConstraintsBatchImpl : OniConstraintsBatchImpl, IShapeMatchingConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060004CC RID: 1228 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x27AC190", Offset = "0x27AA790", VA = "0x1827AC190")]
		public OniShapeMatchingConstraintsBatchImpl(OniShapeMatchingConstraintsImpl constraints)
		{
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x27AC1A0", Offset = "0x27AA7A0", VA = "0x1827AC1A0", Slot = "11")]
		public void SetShapeMatchingConstraints(ObiNativeIntList particleIndices, ObiNativeIntList firstIndex, ObiNativeIntList numIndices, ObiNativeIntList explicitGroup, ObiNativeFloatList shapeMaterialParameters, ObiNativeVector4List restComs, ObiNativeVector4List coms, ObiNativeQuaternionList orientations, ObiNativeFloatList lambdas, int count)
		{
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x27AC390", Offset = "0x27AA990", VA = "0x1827AC390", Slot = "12")]
		public void CalculateRestShapeMatching()
		{
		}
	}
}
