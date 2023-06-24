using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[CreateAssetMenu(menuName = "Sons/Construction/GRABS/OperationFactory: RepositionFace", fileName = "GRABS OperationFactory - RepositionFace")]
	public class OperationFactoryRepositionFace : OperationFactory
	{
		// Token: 0x060001DD RID: 477 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2DA0010", Offset = "0x2D9E610", VA = "0x182DA0010", Slot = "4")]
		public override Operation GetOperation(InteractionPoint ip, GrabsController controller)
		{
			return null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public OperationFactoryRepositionFace()
		{
		}
	}
}
