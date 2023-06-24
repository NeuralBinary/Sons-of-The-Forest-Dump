using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[CreateAssetMenu(menuName = "Sons/Construction/GRABS/OperationFactory: PickBlueprintHeight", fileName = "GRABS OperationFactory - PickBlueprintHeight")]
	public class OperationFactoryPickBlueprintHeight : OperationFactory
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2D9EBC0", Offset = "0x2D9D1C0", VA = "0x182D9EBC0", Slot = "4")]
		public override Operation GetOperation(InteractionPoint ip, GrabsController controller)
		{
			return null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public OperationFactoryPickBlueprintHeight()
		{
		}
	}
}
