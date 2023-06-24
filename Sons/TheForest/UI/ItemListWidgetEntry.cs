using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using TMPro;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003EC RID: 1004
	[Token(Token = "0x20003EC")]
	public class ItemListWidgetEntry : MonoBehaviour
	{
		// Token: 0x06001B10 RID: 6928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x32B0850", Offset = "0x32AEE50", VA = "0x1832B0850")]
		private void Reset()
		{
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x000081C0 File Offset: 0x000063C0
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x32B0980", Offset = "0x32AEF80", VA = "0x1832B0980")]
		public bool MatchItemId(int itemid)
		{
			return default(bool);
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x000081D8 File Offset: 0x000063D8
		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x32B09D0", Offset = "0x32AEFD0", VA = "0x1832B09D0")]
		public bool OwnsAny()
		{
			return default(bool);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x32B0A70", Offset = "0x32AF070", VA = "0x1832B0A70")]
		public void SetLabelEnabled(bool value)
		{
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x32B0C50", Offset = "0x32AF250", VA = "0x1832B0C50")]
		public ItemListWidgetEntry()
		{
		}

		// Token: 0x04001A44 RID: 6724
		[Token(Token = "0x4001A44")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker]
		public int[] _itemIds;

		// Token: 0x04001A45 RID: 6725
		[Token(Token = "0x4001A45")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _icon;

		// Token: 0x04001A46 RID: 6726
		[Token(Token = "0x4001A46")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _actionIcon;

		// Token: 0x04001A47 RID: 6727
		[Token(Token = "0x4001A47")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI _amountLabel;

		// Token: 0x04001A48 RID: 6728
		[Token(Token = "0x4001A48")]
		[FieldOffset(Offset = "0x40")]
		public int _lastAmountDisplayed;

		// Token: 0x04001A49 RID: 6729
		[Token(Token = "0x4001A49")]
		[FieldOffset(Offset = "0x48")]
		public GameObject _takeIcon;

		// Token: 0x04001A4A RID: 6730
		[Token(Token = "0x4001A4A")]
		[FieldOffset(Offset = "0x50")]
		public GameObject _craftIcon;

		// Token: 0x04001A4B RID: 6731
		[Token(Token = "0x4001A4B")]
		[FieldOffset(Offset = "0x58")]
		public bool _useFillSprite;
	}
}
