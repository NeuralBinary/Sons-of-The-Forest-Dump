using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	public class OniBendConstraintsBatchImpl : OniConstraintsBatchImpl, IBendConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060004A2 RID: 1186 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x27AAD90", Offset = "0x27A9390", VA = "0x1827AAD90")]
		public OniBendConstraintsBatchImpl(OniBendConstraintsImpl constraints)
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x27AADA0", Offset = "0x27A93A0", VA = "0x1827AADA0", Slot = "11")]
		public void SetBendConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList restBends, ObiNativeVector2List bendingStiffnesses, ObiNativeVector2List plasticity, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
