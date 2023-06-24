using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	public class OniSkinConstraintsBatchImpl : OniConstraintsBatchImpl, ISkinConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060004D2 RID: 1234 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x27AC720", Offset = "0x27AAD20", VA = "0x1827AC720")]
		public OniSkinConstraintsBatchImpl(OniSkinConstraintsImpl constraints)
		{
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x27AC730", Offset = "0x27AAD30", VA = "0x1827AC730", Slot = "11")]
		public void SetSkinConstraints(ObiNativeIntList particleIndices, ObiNativeVector4List skinPoints, ObiNativeVector4List skinNormals, ObiNativeFloatList skinRadiiBackstop, ObiNativeFloatList skinCompliance, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
