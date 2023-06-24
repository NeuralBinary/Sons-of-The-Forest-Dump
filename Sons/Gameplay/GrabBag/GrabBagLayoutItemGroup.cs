using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Inventory;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x0200084E RID: 2126
	[Token(Token = "0x200084E")]
	public class GrabBagLayoutItemGroup : LayoutItemGroup<GrabBagLayoutItem>
	{
		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06003C7D RID: 15485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CD")]
		public UnityEvent<ItemInstance, bool> OnItemInteraction
		{
			[Token(Token = "0x6003C7D")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06003C7E RID: 15486 RVA: 0x00012690 File Offset: 0x00010890
		[Token(Token = "0x170007CE")]
		public bool DisableGroupIfRecieverHasEquipped
		{
			[Token(Token = "0x6003C7E")]
			[Address(RVA = "0x612480", Offset = "0x610A80", VA = "0x180612480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C7F")]
		[Address(RVA = "0x35A7B20", Offset = "0x35A6120", VA = "0x1835A7B20", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C80")]
		[Address(RVA = "0x35A8060", Offset = "0x35A6660", VA = "0x1835A8060", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x000126A8 File Offset: 0x000108A8
		[Token(Token = "0x6003C81")]
		[Address(RVA = "0x35A86E0", Offset = "0x35A6CE0", VA = "0x1835A86E0", Slot = "9")]
		public override bool TryAddItem(ItemInstance itemInstance, int itemId)
		{
			return default(bool);
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C82")]
		[Address(RVA = "0x35A8790", Offset = "0x35A6D90", VA = "0x1835A8790", Slot = "10")]
		public override void TryRemoveItem(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C83")]
		[Address(RVA = "0x35A8830", Offset = "0x35A6E30", VA = "0x1835A8830", Slot = "8")]
		protected override void RefreshItems()
		{
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x000126C0 File Offset: 0x000108C0
		[Token(Token = "0x6003C84")]
		[Address(RVA = "0x35A9020", Offset = "0x35A7620", VA = "0x1835A9020")]
		private bool WouldEnableVisualLayoutItem()
		{
			return default(bool);
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x000126D8 File Offset: 0x000108D8
		[Token(Token = "0x6003C85")]
		[Address(RVA = "0x35A9060", Offset = "0x35A7660", VA = "0x1835A9060")]
		private bool WouldDisableVisualLayoutItem()
		{
			return default(bool);
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C86")]
		[Address(RVA = "0x35A90A0", Offset = "0x35A76A0", VA = "0x1835A90A0")]
		private void GetNonUniqueCollectionValues(out int outCurrentVisualCount, out int outFinalVisualCount)
		{
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C87")]
		[Address(RVA = "0x35A92E0", Offset = "0x35A78E0", VA = "0x1835A92E0")]
		private void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C88")]
		[Address(RVA = "0x35A9580", Offset = "0x35A7B80", VA = "0x1835A9580")]
		public void OnMouseEnterLayoutItem(LayoutItem layoutItem)
		{
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C89")]
		[Address(RVA = "0x35A95B0", Offset = "0x35A7BB0", VA = "0x1835A95B0")]
		public void OnMouseExitLayoutItem(LayoutItem layoutItem)
		{
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8A")]
		[Address(RVA = "0x35A9580", Offset = "0x35A7B80", VA = "0x1835A9580")]
		public void OnMouseOverLayoutItem(LayoutItem layoutItem)
		{
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8B")]
		[Address(RVA = "0x35A95E0", Offset = "0x35A7BE0", VA = "0x1835A95E0")]
		public void GrayOutItems(bool shouldGreyout)
		{
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8C")]
		[Address(RVA = "0x35A9730", Offset = "0x35A7D30", VA = "0x1835A9730")]
		public void SetFromInventoryLayoutItemGroup(int itemId, bool isUniqueCollection)
		{
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8D")]
		[Address(RVA = "0x35A9A40", Offset = "0x35A8040", VA = "0x1835A9A40")]
		public GrabBagLayoutItemGroup()
		{
		}

		// Token: 0x0400332B RID: 13099
		[Token(Token = "0x400332B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _disableGroupIfRecieverHasEquipped;

		// Token: 0x0400332C RID: 13100
		[Token(Token = "0x400332C")]
		[FieldOffset(Offset = "0x80")]
		private PlayerInventory _inventory;
	}
}
