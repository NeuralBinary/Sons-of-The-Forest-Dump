using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005E4 RID: 1508
	[Token(Token = "0x20005E4")]
	public class QuickSelectLayoutItem : LayoutItem
	{
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x17000529")]
		public int ItemId
		{
			[Token(Token = "0x60026AC")]
			[Address(RVA = "0x8E3D80", Offset = "0x8E2D80", VA = "0x1808E3D80")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x1700052A")]
		public ItemData.QuickSelectSlotTypes SlotType
		{
			[Token(Token = "0x60026AD")]
			[Address(RVA = "0x5F1A40", Offset = "0x5F0A40", VA = "0x1805F1A40")]
			get
			{
				return default(ItemData.QuickSelectSlotTypes);
			}
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AE")]
		[Address(RVA = "0x2DAAF00", Offset = "0x2DA9F00", VA = "0x182DAAF00")]
		public void Set(int itemId, ItemData.QuickSelectSlotTypes slot)
		{
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AF")]
		[Address(RVA = "0x2DAAE10", Offset = "0x2DA9E10", VA = "0x182DAAE10", Slot = "8")]
		protected override void OnMouseEnter()
		{
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B0")]
		[Address(RVA = "0x2DAAE90", Offset = "0x2DA9E90", VA = "0x182DAAE90")]
		public void PlayAudio()
		{
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B1")]
		[Address(RVA = "0x2DAAF10", Offset = "0x2DA9F10", VA = "0x182DAAF10", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B2")]
		[Address(RVA = "0x2DAB010", Offset = "0x2DAA010", VA = "0x182DAB010")]
		public QuickSelectLayoutItem()
		{
		}

		// Token: 0x04002322 RID: 8994
		[Token(Token = "0x4002322")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _itemId;

		// Token: 0x04002323 RID: 8995
		[Token(Token = "0x4002323")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private ItemData.QuickSelectSlotTypes _slotType;

		// Token: 0x04002324 RID: 8996
		[Token(Token = "0x4002324")]
		[FieldOffset(Offset = "0x70")]
		[EventRef]
		[SerializeField]
		private string _onInteractAudioEvent;
	}
}
