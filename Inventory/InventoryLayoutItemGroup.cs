using System;
using Il2CppDummyDll;
using Sons.Crafting;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Inventory
{
	// Token: 0x020005F9 RID: 1529
	[Token(Token = "0x20005F9")]
	public class InventoryLayoutItemGroup : LayoutItemGroup<InventoryLayoutItem>
	{
		// Token: 0x06002713 RID: 10003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x2D9B3C0", Offset = "0x2D9A3C0", VA = "0x182D9B3C0")]
		private void Awake()
		{
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x2D9C9A0", Offset = "0x2D9B9A0", VA = "0x182D9C9A0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002715")]
		[Address(RVA = "0x2D9BF80", Offset = "0x2D9AF80", VA = "0x182D9BF80", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002716")]
		[Address(RVA = "0x2D9E260", Offset = "0x2D9D260", VA = "0x182D9E260")]
		public void SetQuickSelectMode(bool enable)
		{
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002717")]
		[Address(RVA = "0x2D9B660", Offset = "0x2D9A660", VA = "0x182D9B660")]
		private void GrayOutItems(bool shouldGrayOut, bool blockInteractions)
		{
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002718")]
		[Address(RVA = "0x2D9BF70", Offset = "0x2D9AF70", VA = "0x182D9BF70")]
		private void OnCraftBegin(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002719")]
		[Address(RVA = "0x2D9D680", Offset = "0x2D9C680", VA = "0x182D9D680")]
		private void OnLayoutItemHovered(LayoutItem layoutItem)
		{
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271A")]
		[Address(RVA = "0x2D9E3F0", Offset = "0x2D9D3F0", VA = "0x182D9E3F0")]
		private void TryRefresh(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x0000B688 File Offset: 0x00009888
		[Token(Token = "0x600271B")]
		[Address(RVA = "0x2D9E330", Offset = "0x2D9D330", VA = "0x182D9E330", Slot = "9")]
		public override bool TryAddItem(ItemInstance itemInstance, int itemId)
		{
			return default(bool);
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271C")]
		[Address(RVA = "0x2D9E410", Offset = "0x2D9D410", VA = "0x182D9E410", Slot = "10")]
		public override void TryRemoveItem(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271D")]
		[Address(RVA = "0x2D9DA90", Offset = "0x2D9CA90", VA = "0x182D9DA90", Slot = "8")]
		protected override void RefreshItems()
		{
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[Token(Token = "0x600271E")]
		[Address(RVA = "0x2D9E500", Offset = "0x2D9D500", VA = "0x182D9E500")]
		private bool WouldEnableVisualLayoutItem()
		{
			return default(bool);
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[Token(Token = "0x600271F")]
		[Address(RVA = "0x2D9E4C0", Offset = "0x2D9D4C0", VA = "0x182D9E4C0")]
		private bool WouldDisableVisualLayoutItem()
		{
			return default(bool);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002720")]
		[Address(RVA = "0x2D9B400", Offset = "0x2D9A400", VA = "0x182D9B400")]
		private void GetNonUniqueCollectionValues(out int outCurrentVisualCount, out int outFinalVisualCount)
		{
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002721")]
		[Address(RVA = "0x2D9D100", Offset = "0x2D9C100", VA = "0x182D9D100")]
		private void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002722")]
		[Address(RVA = "0x2D9BA80", Offset = "0x2D9AA80", VA = "0x182D9BA80")]
		private void OnAlternateInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002723")]
		[Address(RVA = "0x2D9D830", Offset = "0x2D9C830", VA = "0x182D9D830")]
		private void OnToggleItemToQuickSlot(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002724")]
		[Address(RVA = "0x2D9B7A0", Offset = "0x2D9A7A0", VA = "0x182D9B7A0")]
		private void OnAddItemToMat(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002725")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void OnDropItemFromInventory(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x2D9C6D0", Offset = "0x2D9B6D0", VA = "0x182D9C6D0")]
		private void OnDropItemFromInventory()
		{
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002727")]
		[Address(RVA = "0x2D9E540", Offset = "0x2D9D540", VA = "0x182D9E540")]
		public InventoryLayoutItemGroup()
		{
		}

		// Token: 0x04002367 RID: 9063
		[Token(Token = "0x4002367")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _alwaysShowIfOwned;

		// Token: 0x04002368 RID: 9064
		[Token(Token = "0x4002368")]
		[FieldOffset(Offset = "0x71")]
		[SerializeField]
		private bool _startDisabled;

		// Token: 0x04002369 RID: 9065
		[Token(Token = "0x4002369")]
		[FieldOffset(Offset = "0x78")]
		private PlayerInventory _inventory;
	}
}
