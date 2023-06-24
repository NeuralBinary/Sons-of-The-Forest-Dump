using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000102")]
	public class OniDistanceConstraintsBatchImpl : OniConstraintsBatchImpl, IDistanceConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x27AB790", Offset = "0x27A9D90", VA = "0x1827AB790")]
		public OniDistanceConstraintsBatchImpl(OniDistanceConstraintsImpl constraints)
		{
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x27AB7A0", Offset = "0x27A9DA0", VA = "0x1827AB7A0", Slot = "11")]
		public void SetDistanceConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList restLengths, ObiNativeVector2List stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
