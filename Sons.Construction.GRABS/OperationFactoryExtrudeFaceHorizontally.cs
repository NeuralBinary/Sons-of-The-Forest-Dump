using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[CreateAssetMenu(menuName = "Sons/Construction/GRABS/OperationFactory: ExtrudeFaceHorizontally", fileName = "GRABS OperationFactory - ExtrudeFaceHorizontally")]
	public class OperationFactoryExtrudeFaceHorizontally : OperationFactory
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2D9C9F0", Offset = "0x2D9AFF0", VA = "0x182D9C9F0", Slot = "4")]
		public override Operation GetOperation(InteractionPoint ip, GrabsController controller)
		{
			return null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public OperationFactoryExtrudeFaceHorizontally()
		{
		}
	}
}
