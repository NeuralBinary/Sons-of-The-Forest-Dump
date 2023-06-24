using System;
using Il2CppDummyDll;
using Sons.Crafting;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Inventory
{
	// Token: 0x0200060B RID: 1547
	[Token(Token = "0x200060B")]
	public class InventoryLayoutItemGroup : LayoutItemGroup<InventoryLayoutItem>
	{
		// Token: 0x0600281D RID: 10269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281D")]
		[Address(RVA = "0x33D3CD0", Offset = "0x33D22D0", VA = "0x1833D3CD0")]
		private void Awake()
		{
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281E")]
		[Address(RVA = "0x33D3D80", Offset = "0x33D2380", VA = "0x1833D3D80", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281F")]
		[Address(RVA = "0x33D46C0", Offset = "0x33D2CC0", VA = "0x1833D46C0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002820")]
		[Address(RVA = "0x33D5190", Offset = "0x33D3790", VA = "0x1833D5190")]
		public void SetQuickSelectMode(bool enable)
		{
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002821")]
		[Address(RVA = "0x33D52D0", Offset = "0x33D38D0", VA = "0x1833D52D0")]
		private void GrayOutItems(bool shouldGrayOut, bool blockInteractions)
		{
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002822")]
		[Address(RVA = "0x33D5440", Offset = "0x33D3A40", VA = "0x1833D5440")]
		private void OnCraftBegin(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002823")]
		[Address(RVA = "0x33D5450", Offset = "0x33D3A50", VA = "0x1833D5450")]
		private void OnLayoutItemHovered(LayoutItem layoutItem)
		{
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002824")]
		[Address(RVA = "0x33D56B0", Offset = "0x33D3CB0", VA = "0x1833D56B0")]
		private void TryRefresh(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x0000BD78 File Offset: 0x00009F78
		[Token(Token = "0x6002825")]
		[Address(RVA = "0x33D56D0", Offset = "0x33D3CD0", VA = "0x1833D56D0", Slot = "9")]
		public override bool TryAddItem(ItemInstance itemInstance, int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002826")]
		[Address(RVA = "0x33D5780", Offset = "0x33D3D80", VA = "0x1833D5780", Slot = "10")]
		public override void TryRemoveItem(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002827")]
		[Address(RVA = "0x33D5820", Offset = "0x33D3E20", VA = "0x1833D5820", Slot = "8")]
		protected override void RefreshItems()
		{
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x0000BD90 File Offset: 0x00009F90
		[Token(Token = "0x6002828")]
		[Address(RVA = "0x33D6300", Offset = "0x33D4900", VA = "0x1833D6300")]
		private bool WouldEnableVisualLayoutItem()
		{
			return default(bool);
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		[Token(Token = "0x6002829")]
		[Address(RVA = "0x33D6340", Offset = "0x33D4940", VA = "0x1833D6340")]
		private bool WouldDisableVisualLayoutItem()
		{
			return default(bool);
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282A")]
		[Address(RVA = "0x33D6380", Offset = "0x33D4980", VA = "0x1833D6380")]
		private void GetNonUniqueCollectionValues(out int outCurrentVisualCount, out int outFinalVisualCount)
		{
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282B")]
		[Address(RVA = "0x33D6650", Offset = "0x33D4C50", VA = "0x1833D6650")]
		private void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282C")]
		[Address(RVA = "0x33D6D60", Offset = "0x33D5360", VA = "0x1833D6D60")]
		private void OnAlternateInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282D")]
		[Address(RVA = "0x33D72B0", Offset = "0x33D58B0", VA = "0x1833D72B0")]
		private void OnToggleItemToQuickSlot(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282E")]
		[Address(RVA = "0x33D7670", Offset = "0x33D5C70", VA = "0x1833D7670")]
		private void OnAddItemToMat(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnDropItemFromInventory(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002830")]
		[Address(RVA = "0x33D7990", Offset = "0x33D5F90", VA = "0x1833D7990")]
		private void OnDropItemFromInventory()
		{
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002831")]
		[Address(RVA = "0x33D7D00", Offset = "0x33D6300", VA = "0x1833D7D00")]
		public InventoryLayoutItemGroup()
		{
		}

		// Token: 0x0400244B RID: 9291
		[Token(Token = "0x400244B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _alwaysShowIfOwned;

		// Token: 0x0400244C RID: 9292
		[Token(Token = "0x400244C")]
		[FieldOffset(Offset = "0x79")]
		[SerializeField]
		private bool _startDisabled;

		// Token: 0x0400244D RID: 9293
		[Token(Token = "0x400244D")]
		[FieldOffset(Offset = "0x80")]
		private PlayerInventory _inventory;
	}
}
