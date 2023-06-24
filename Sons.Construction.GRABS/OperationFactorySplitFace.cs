using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	[CreateAssetMenu(menuName = "Sons/Construction/GRABS/OperationFactory: SplitFace", fileName = "GRABS OperationFactory - SplitFace")]
	public class OperationFactorySplitFace : OperationFactory
	{
		// Token: 0x060001DF RID: 479 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2DA00C0", Offset = "0x2D9E6C0", VA = "0x182DA00C0", Slot = "4")]
		public override Operation GetOperation(InteractionPoint ip, GrabsController controller)
		{
			return null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public OperationFactorySplitFace()
		{
		}

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SnapAxis _splitAxis;
	}
}
