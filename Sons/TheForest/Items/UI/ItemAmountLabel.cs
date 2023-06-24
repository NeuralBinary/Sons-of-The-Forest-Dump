using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using TMPro;
using UnityEngine;

namespace TheForest.Items.UI
{
	// Token: 0x02000494 RID: 1172
	[Token(Token = "0x2000494")]
	[AddComponentMenu("Items/UI/Item Amount Label")]
	public class ItemAmountLabel : MonoBehaviour
	{
		// Token: 0x06001E46 RID: 7750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E46")]
		[Address(RVA = "0x32EF700", Offset = "0x32EDD00", VA = "0x1832EF700")]
		public ItemAmountLabel()
		{
		}

		// Token: 0x04001C67 RID: 7271
		[Token(Token = "0x4001C67")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker]
		public int _itemId;

		// Token: 0x04001C68 RID: 7272
		[Token(Token = "0x4001C68")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI _label;

		// Token: 0x04001C69 RID: 7273
		[Token(Token = "0x4001C69")]
		[FieldOffset(Offset = "0x30")]
		private int _displayedAmount;
	}
}
