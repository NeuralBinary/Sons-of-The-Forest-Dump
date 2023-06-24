using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000614 RID: 1556
	[Token(Token = "0x2000614")]
	[AddComponentMenu("Sons/Inventory/InWorldLayoutItemInteractionUiToggler")]
	public class InWorldLayoutItemInteractionUiToggler : MonoBehaviour
	{
		// Token: 0x06002876 RID: 10358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002876")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InWorldLayoutItemInteractionUiToggler()
		{
		}

		// Token: 0x04002473 RID: 9331
		[Token(Token = "0x4002473")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _takeUiElement;

		// Token: 0x04002474 RID: 9332
		[Token(Token = "0x4002474")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _placeUiElement;
	}
}
