using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000601 RID: 1537
	[Token(Token = "0x2000601")]
	[AddComponentMenu("Sons/Inventory/InWorldLayoutItemInteractionUiToggler")]
	public class InWorldLayoutItemInteractionUiToggler : MonoBehaviour
	{
		// Token: 0x0600275F RID: 10079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275F")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public InWorldLayoutItemInteractionUiToggler()
		{
		}

		// Token: 0x04002384 RID: 9092
		[Token(Token = "0x4002384")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _takeUiElement;

		// Token: 0x04002385 RID: 9093
		[Token(Token = "0x4002385")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _placeUiElement;
	}
}
