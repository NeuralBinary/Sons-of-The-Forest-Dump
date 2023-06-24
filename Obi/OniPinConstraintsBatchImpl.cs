using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	public class OniPinConstraintsBatchImpl : OniConstraintsBatchImpl, IPinConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x27ABE00", Offset = "0x27AA400", VA = "0x1827ABE00")]
		public OniPinConstraintsBatchImpl(OniPinConstraintsImpl constraints)
		{
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x27ABE10", Offset = "0x27AA410", VA = "0x1827ABE10", Slot = "11")]
		public void SetPinConstraints(ObiNativeIntList particleIndices, ObiNativeIntList colliderIndices, ObiNativeVector4List offsets, ObiNativeQuaternionList restDarbouxVectors, ObiNativeFloatList stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
