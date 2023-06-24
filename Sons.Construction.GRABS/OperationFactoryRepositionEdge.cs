using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[CreateAssetMenu(menuName = "Sons/Construction/GRABS/OperationFactory: RepositionEdge", fileName = "GRABS OperationFactory - RepositionEdge")]
	public class OperationFactoryRepositionEdge : OperationFactory
	{
		// Token: 0x060001DB RID: 475 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2D9FF70", Offset = "0x2D9E570", VA = "0x182D9FF70", Slot = "4")]
		public override Operation GetOperation(InteractionPoint ip, GrabsController controller)
		{
			return null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public OperationFactoryRepositionEdge()
		{
		}
	}
}
