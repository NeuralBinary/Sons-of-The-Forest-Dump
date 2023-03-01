using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using TMPro;
using UnityEngine;

namespace TheForest.Items.UI
{
	// Token: 0x0200049F RID: 1183
	[Token(Token = "0x200049F")]
	[AddComponentMenu("Items/UI/Item Amount Label")]
	public class ItemAmountLabel : MonoBehaviour
	{
		// Token: 0x06001DF6 RID: 7670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF6")]
		[Address(RVA = "0x2D0F010", Offset = "0x2D0E010", VA = "0x182D0F010")]
		public ItemAmountLabel()
		{
		}

		// Token: 0x04001C37 RID: 7223
		[Token(Token = "0x4001C37")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker]
		public int _itemId;

		// Token: 0x04001C38 RID: 7224
		[Token(Token = "0x4001C38")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI _label;

		// Token: 0x04001C39 RID: 7225
		[Token(Token = "0x4001C39")]
		[FieldOffset(Offset = "0x30")]
		private int _displayedAmount;
	}
}
