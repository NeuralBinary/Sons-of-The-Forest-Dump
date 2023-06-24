using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[CreateAssetMenu(menuName = "Sons/Construction/GRABS/OperationFactory: ExtrudeFaceVertically", fileName = "GRABS OperationFactory - ExtrudeFaceVertically")]
	public class OperationFactoryExtrudeFaceVertically : OperationFactory
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2D9DB80", Offset = "0x2D9C180", VA = "0x182D9DB80", Slot = "4")]
		public override Operation GetOperation(InteractionPoint ip, GrabsController controller)
		{
			return null;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public OperationFactoryExtrudeFaceVertically()
		{
		}
	}
}
