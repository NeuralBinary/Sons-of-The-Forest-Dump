using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[CreateAssetMenu(menuName = "Sons/Construction/GRABS/OperationFactory: MergeAlignedFaces", fileName = "GRABS OperationFactory - MergeAlignedFaces")]
	public class OperationFactoryMergeAlignedFaces : OperationFactory
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2D9EAB0", Offset = "0x2D9D0B0", VA = "0x182D9EAB0", Slot = "4")]
		public override Operation GetOperation(InteractionPoint ip, GrabsController controller)
		{
			return null;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public OperationFactoryMergeAlignedFaces()
		{
		}
	}
}
