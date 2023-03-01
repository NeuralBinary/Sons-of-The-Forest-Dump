using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai;
using Sons.Crafting;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace Sons.Cutscenes
{
	// Token: 0x02000776 RID: 1910
	[Token(Token = "0x2000776")]
	public class InventoryCutscene : Cutscene
	{
		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000656")]
		public InventoryCameraController InventoryCameraController
		{
			[Token(Token = "0x6003226")]
			[Address(RVA = "0x5F1A50", Offset = "0x5F0A50", VA = "0x1805F1A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003227")]
		[Address(RVA = "0x2E486B0", Offset = "0x2E476B0", VA = "0x182E486B0", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003228")]
		[Address(RVA = "0x2E47D10", Offset = "0x2E46D10", VA = "0x182E47D10")]
		private void OnEnable()
		{
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003229")]
		[Address(RVA = "0x2E479B0", Offset = "0x2E469B0", VA = "0x182E479B0")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600322A")]
		[Address(RVA = "0x2E48AC0", Offset = "0x2E47AC0", VA = "0x182E48AC0")]
		public void SetQuickSelectMode(bool enable)
		{
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600322B")]
		[Address(RVA = "0x2E486C0", Offset = "0x2E476C0", VA = "0x182E486C0")]
		public void RefreshQuickSelect()
		{
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600322C")]
		[Address(RVA = "0x2E489B0", Offset = "0x2E479B0", VA = "0x182E489B0")]
		public void SetLayoutGroupVisibility(int itemId, bool visible)
		{
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600322D")]
		[Address(RVA = "0x2E47AD0", Offset = "0x2E46AD0", VA = "0x182E47AD0")]
		private void OnCraftBegin(CraftingRecipe recipe)
		{
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600322E")]
		[Address(RVA = "0x2E47C70", Offset = "0x2E46C70", VA = "0x182E47C70")]
		private void OnCraftComplete(CraftingRecipe recipe)
		{
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x0000E598 File Offset: 0x0000C798
		[Token(Token = "0x600322F")]
		[Address(RVA = "0x2E47DC0", Offset = "0x2E46DC0", VA = "0x182E47DC0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003230")]
		[Address(RVA = "0x2E48FD0", Offset = "0x2E47FD0", VA = "0x182E48FD0")]
		private void Update()
		{
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003231")]
		[Address(RVA = "0x2E48F60", Offset = "0x2E47F60", VA = "0x182E48F60")]
		private IEnumerator UnWrapMat()
		{
			return null;
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003232")]
		[Address(RVA = "0x2E47000", Offset = "0x2E46000", VA = "0x182E47000", Slot = "13")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003233")]
		[Address(RVA = "0x2E479C0", Offset = "0x2E469C0", VA = "0x182E479C0")]
		public void OnClearCraftingMat(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003234")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void OnDropItemFromInventory(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003235")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void OnCloseInventory(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003236")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003237")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void OnAddItemToMat(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003238")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void OnRemoveItemFromMat(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003239")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void OnMoveCursor(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600323A")]
		[Address(RVA = "0x2E49100", Offset = "0x2E48100", VA = "0x182E49100")]
		public InventoryCutscene()
		{
		}

		// Token: 0x04002BB9 RID: 11193
		[Token(Token = "0x4002BB9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _inventory;

		// Token: 0x04002BBA RID: 11194
		[Token(Token = "0x4002BBA")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private InventoryCameraController _inventoryCameraController;

		// Token: 0x04002BBB RID: 11195
		[Token(Token = "0x4002BBB")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Animator _layoutGroupsRolloutAnimator;

		// Token: 0x04002BBC RID: 11196
		[Token(Token = "0x4002BBC")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Animator _inventoryBagAnimator;

		// Token: 0x04002BBD RID: 11197
		[Token(Token = "0x4002BBD")]
		[FieldOffset(Offset = "0xD0")]
		[EventRef]
		[SerializeField]
		private string _unwrapBagAudio;

		// Token: 0x04002BBE RID: 11198
		[Token(Token = "0x4002BBE")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[EventRef]
		private string _wrapUpBagAudio;

		// Token: 0x04002BBF RID: 11199
		[Token(Token = "0x4002BBF")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private VirtualMouseInput _virtualMouse;

		// Token: 0x04002BC0 RID: 11200
		[Token(Token = "0x4002BC0")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Transform _inventoryLayoutItemGroupsRoot;

		// Token: 0x04002BC1 RID: 11201
		[Token(Token = "0x4002BC1")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Transform _backpackDefaultLocation;

		// Token: 0x04002BC2 RID: 11202
		[Token(Token = "0x4002BC2")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Transform _backpackMatLocation;

		// Token: 0x04002BC3 RID: 11203
		[Token(Token = "0x4002BC3")]
		[FieldOffset(Offset = "0x100")]
		private readonly int _inventoryAnimationLayer;

		// Token: 0x04002BC4 RID: 11204
		[Token(Token = "0x4002BC4")]
		[FieldOffset(Offset = "0x108")]
		private Transform _backpackLayoutItemTransform;

		// Token: 0x04002BC5 RID: 11205
		[Token(Token = "0x4002BC5")]
		[FieldOffset(Offset = "0x110")]
		private bool _inQuickSelectMode;

		// Token: 0x04002BC6 RID: 11206
		[Token(Token = "0x4002BC6")]
		[FieldOffset(Offset = "0x118")]
		private InventoryBagController _inventoryBagController;

		// Token: 0x04002BC7 RID: 11207
		[Token(Token = "0x4002BC7")]
		[FieldOffset(Offset = "0x120")]
		private List<InventoryLayoutItemGroup> _inventoryLayoutItemGroups;

		// Token: 0x04002BC8 RID: 11208
		[Token(Token = "0x4002BC8")]
		[FieldOffset(Offset = "0x128")]
		private bool _isShuttingDown;

		// Token: 0x04002BC9 RID: 11209
		[Token(Token = "0x4002BC9")]
		[FieldOffset(Offset = "0x129")]
		private bool _isCleaningUp;

		// Token: 0x04002BCA RID: 11210
		[Token(Token = "0x4002BCA")]
		[FieldOffset(Offset = "0x130")]
		private Animator _playerAnimator;

		// Token: 0x04002BCB RID: 11211
		[Token(Token = "0x4002BCB")]
		[FieldOffset(Offset = "0x138")]
		private ButterflySpawner _playerButterflySpawner;
	}
}
