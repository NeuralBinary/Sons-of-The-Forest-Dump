using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	public class OniAerodynamicConstraintsBatchImpl : OniConstraintsBatchImpl, IAerodynamicConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x0600049D RID: 1181 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x27AAA90", Offset = "0x27A9090", VA = "0x1827AAA90")]
		public OniAerodynamicConstraintsBatchImpl(OniAerodynamicConstraintsImpl constraints)
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x27AAAA0", Offset = "0x27A90A0", VA = "0x1827AAAA0", Slot = "11")]
		public void SetAerodynamicConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList aerodynamicCoeffs, int count)
		{
		}
	}
}
