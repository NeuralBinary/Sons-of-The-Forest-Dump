using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000111 RID: 273
	[Token(Token = "0x2000111")]
	public class OniTetherConstraintsBatchImpl : OniConstraintsBatchImpl, ITetherConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060004E1 RID: 1249 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x27AD150", Offset = "0x27AB750", VA = "0x1827AD150")]
		public OniTetherConstraintsBatchImpl(OniTetherConstraintsImpl constraints)
		{
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x27AD160", Offset = "0x27AB760", VA = "0x1827AD160", Slot = "11")]
		public void SetTetherConstraints(ObiNativeIntList particleIndices, ObiNativeVector2List maxLengthScale, ObiNativeFloatList stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
