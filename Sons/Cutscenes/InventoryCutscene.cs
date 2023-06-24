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
	// Token: 0x02000681 RID: 1665
	[Token(Token = "0x2000681")]
	public class InventoryCutscene : Cutscene
	{
		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C3")]
		public InventoryCameraController InventoryCameraController
		{
			[Token(Token = "0x6002B9D")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9E")]
		[Address(RVA = "0x34116E0", Offset = "0x340FCE0", VA = "0x1834116E0", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9F")]
		[Address(RVA = "0x34116F0", Offset = "0x340FCF0", VA = "0x1834116F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA0")]
		[Address(RVA = "0x3411850", Offset = "0x340FE50", VA = "0x183411850")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA1")]
		[Address(RVA = "0x3411860", Offset = "0x340FE60", VA = "0x183411860")]
		public void SetQuickSelectMode(bool enable)
		{
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA2")]
		[Address(RVA = "0x3411F90", Offset = "0x3410590", VA = "0x183411F90")]
		public void RefreshQuickSelect()
		{
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA3")]
		[Address(RVA = "0x3412280", Offset = "0x3410880", VA = "0x183412280")]
		public void SetLayoutGroupVisibility(int itemId, bool visible)
		{
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA4")]
		[Address(RVA = "0x3412400", Offset = "0x3410A00", VA = "0x183412400")]
		private void OnCraftBegin(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA5")]
		[Address(RVA = "0x3412630", Offset = "0x3410C30", VA = "0x183412630")]
		private void OnCraftComplete(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x0000CE70 File Offset: 0x0000B070
		[Token(Token = "0x6002BA6")]
		[Address(RVA = "0x3412720", Offset = "0x3410D20", VA = "0x183412720", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA7")]
		[Address(RVA = "0x34136A0", Offset = "0x3411CA0", VA = "0x1834136A0")]
		private void Update()
		{
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BA8")]
		[Address(RVA = "0x3413840", Offset = "0x3411E40", VA = "0x183413840")]
		private IEnumerator UnWrapMat()
		{
			return null;
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA9")]
		[Address(RVA = "0x34138D0", Offset = "0x3411ED0", VA = "0x1834138D0", Slot = "13")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAA")]
		[Address(RVA = "0x3414B60", Offset = "0x3413160", VA = "0x183414B60")]
		public void OnClearCraftingMat(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnDropItemFromInventory(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnCloseInventory(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnAddItemToMat(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnRemoveItemFromMat(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnMoveCursor(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB1")]
		[Address(RVA = "0x3414CB0", Offset = "0x34132B0", VA = "0x183414CB0")]
		public InventoryCutscene()
		{
		}

		// Token: 0x0400268C RID: 9868
		[Token(Token = "0x400268C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _inventory;

		// Token: 0x0400268D RID: 9869
		[Token(Token = "0x400268D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private InventoryCameraController _inventoryCameraController;

		// Token: 0x0400268E RID: 9870
		[Token(Token = "0x400268E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Animator _layoutGroupsRolloutAnimator;

		// Token: 0x0400268F RID: 9871
		[Token(Token = "0x400268F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Animator _inventoryBagAnimator;

		// Token: 0x04002690 RID: 9872
		[Token(Token = "0x4002690")]
		[FieldOffset(Offset = "0xD0")]
		[EventRef]
		[SerializeField]
		private string _unwrapBagAudio;

		// Token: 0x04002691 RID: 9873
		[Token(Token = "0x4002691")]
		[FieldOffset(Offset = "0xD8")]
		[EventRef]
		[SerializeField]
		private string _wrapUpBagAudio;

		// Token: 0x04002692 RID: 9874
		[Token(Token = "0x4002692")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private VirtualMouseInput _virtualMouse;

		// Token: 0x04002693 RID: 9875
		[Token(Token = "0x4002693")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Transform _inventoryLayoutItemGroupsRoot;

		// Token: 0x04002694 RID: 9876
		[Token(Token = "0x4002694")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Transform _backpackDefaultLocation;

		// Token: 0x04002695 RID: 9877
		[Token(Token = "0x4002695")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Transform _backpackMatLocation;

		// Token: 0x04002696 RID: 9878
		[Token(Token = "0x4002696")]
		[FieldOffset(Offset = "0x100")]
		private readonly int _inventoryAnimationLayer;

		// Token: 0x04002697 RID: 9879
		[Token(Token = "0x4002697")]
		[FieldOffset(Offset = "0x108")]
		private Transform _backpackLayoutItemTransform;

		// Token: 0x04002698 RID: 9880
		[Token(Token = "0x4002698")]
		[FieldOffset(Offset = "0x110")]
		private bool _inQuickSelectMode;

		// Token: 0x04002699 RID: 9881
		[Token(Token = "0x4002699")]
		[FieldOffset(Offset = "0x118")]
		private InventoryBagController _inventoryBagController;

		// Token: 0x0400269A RID: 9882
		[Token(Token = "0x400269A")]
		[FieldOffset(Offset = "0x120")]
		private List<InventoryLayoutItemGroup> _inventoryLayoutItemGroups;

		// Token: 0x0400269B RID: 9883
		[Token(Token = "0x400269B")]
		[FieldOffset(Offset = "0x128")]
		private bool _isShuttingDown;

		// Token: 0x0400269C RID: 9884
		[Token(Token = "0x400269C")]
		[FieldOffset(Offset = "0x129")]
		private bool _isCleaningUp;

		// Token: 0x0400269D RID: 9885
		[Token(Token = "0x400269D")]
		[FieldOffset(Offset = "0x130")]
		private Animator _playerAnimator;

		// Token: 0x0400269E RID: 9886
		[Token(Token = "0x400269E")]
		[FieldOffset(Offset = "0x138")]
		private ButterflySpawner _playerButterflySpawner;
	}
}
