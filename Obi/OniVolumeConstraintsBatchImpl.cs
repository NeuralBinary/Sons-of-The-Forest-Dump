using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	public class OniVolumeConstraintsBatchImpl : OniConstraintsBatchImpl, IVolumeConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x27AD490", Offset = "0x27ABA90", VA = "0x1827AD490")]
		public OniVolumeConstraintsBatchImpl(OniVolumeConstraintsImpl constraints)
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x27AD4A0", Offset = "0x27ABAA0", VA = "0x1827AD4A0", Slot = "11")]
		public void SetVolumeConstraints(ObiNativeIntList triangles, ObiNativeIntList firstTriangle, ObiNativeIntList numTriangles, ObiNativeFloatList restVolumes, ObiNativeVector2List pressureStiffness, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
