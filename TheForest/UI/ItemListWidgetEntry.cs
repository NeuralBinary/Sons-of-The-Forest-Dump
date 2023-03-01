using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using TMPro;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003FA RID: 1018
	[Token(Token = "0x20003FA")]
	public class ItemListWidgetEntry : MonoBehaviour
	{
		// Token: 0x06001AD2 RID: 6866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD2")]
		[Address(RVA = "0x2CE2A10", Offset = "0x2CE1A10", VA = "0x182CE2A10")]
		private void Reset()
		{
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x6001AD3")]
		[Address(RVA = "0x2CE2920", Offset = "0x2CE1920", VA = "0x182CE2920")]
		public bool MatchItemId(int itemid)
		{
			return default(bool);
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x2CE2970", Offset = "0x2CE1970", VA = "0x182CE2970")]
		public bool OwnsAny()
		{
			return default(bool);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x2CE2A80", Offset = "0x2CE1A80", VA = "0x182CE2A80")]
		public void SetLabelEnabled(bool value)
		{
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x2CE2B40", Offset = "0x2CE1B40", VA = "0x182CE2B40")]
		public ItemListWidgetEntry()
		{
		}

		// Token: 0x04001A20 RID: 6688
		[Token(Token = "0x4001A20")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker]
		public int[] _itemIds;

		// Token: 0x04001A21 RID: 6689
		[Token(Token = "0x4001A21")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _icon;

		// Token: 0x04001A22 RID: 6690
		[Token(Token = "0x4001A22")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _actionIcon;

		// Token: 0x04001A23 RID: 6691
		[Token(Token = "0x4001A23")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI _amountLabel;

		// Token: 0x04001A24 RID: 6692
		[Token(Token = "0x4001A24")]
		[FieldOffset(Offset = "0x40")]
		public int _lastAmountDisplayed;

		// Token: 0x04001A25 RID: 6693
		[Token(Token = "0x4001A25")]
		[FieldOffset(Offset = "0x48")]
		public GameObject _takeIcon;

		// Token: 0x04001A26 RID: 6694
		[Token(Token = "0x4001A26")]
		[FieldOffset(Offset = "0x50")]
		public GameObject _craftIcon;

		// Token: 0x04001A27 RID: 6695
		[Token(Token = "0x4001A27")]
		[FieldOffset(Offset = "0x58")]
		public bool _useFillSprite;
	}
}
