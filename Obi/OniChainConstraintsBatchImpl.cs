using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000100 RID: 256
	[Token(Token = "0x2000100")]
	public class OniChainConstraintsBatchImpl : OniConstraintsBatchImpl, IChainConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060004AC RID: 1196 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x27AB460", Offset = "0x27A9A60", VA = "0x1827AB460")]
		public OniChainConstraintsBatchImpl(OniChainConstraintsImpl constraints)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x27AB470", Offset = "0x27A9A70", VA = "0x1827AB470", Slot = "11")]
		public void SetChainConstraints(ObiNativeIntList particleIndices, ObiNativeVector2List restLengths, ObiNativeIntList firstIndex, ObiNativeIntList numIndices, int count)
		{
		}
	}
}
