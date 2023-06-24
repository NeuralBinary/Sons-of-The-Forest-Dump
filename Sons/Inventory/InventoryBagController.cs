using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Input;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace Sons.Inventory
{
	// Token: 0x020005E3 RID: 1507
	[Token(Token = "0x20005E3")]
	[AddComponentMenu("Sons/Items/InventoryBagController")]
	public class InventoryBagController : HeldControllerBase
	{
		// Token: 0x06002721 RID: 10017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002721")]
		[Address(RVA = "0x33BC060", Offset = "0x33BA660", VA = "0x1833BC060", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002722")]
		[Address(RVA = "0x33BC120", Offset = "0x33BA720", VA = "0x1833BC120")]
		private void Update()
		{
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002723")]
		[Address(RVA = "0x33BC230", Offset = "0x33BA830", VA = "0x1833BC230")]
		private void OnDisable()
		{
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		[Token(Token = "0x6002724")]
		[Address(RVA = "0x33BC420", Offset = "0x33BAA20", VA = "0x1833BC420", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[Token(Token = "0x6002725")]
		[Address(RVA = "0x33BC4C0", Offset = "0x33BAAC0", VA = "0x1833BC4C0", Slot = "8")]
		protected override bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x33BC910", Offset = "0x33BAF10", VA = "0x1833BC910")]
		private void ToggleQuickSelect(bool enable)
		{
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002727")]
		[Address(RVA = "0x33BCF20", Offset = "0x33BB520", VA = "0x1833BCF20")]
		private void RegisterInputEvents()
		{
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002728")]
		[Address(RVA = "0x33BD250", Offset = "0x33BB850", VA = "0x1833BD250")]
		private void UnregisterInputEvents()
		{
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002729")]
		[Address(RVA = "0x33BD520", Offset = "0x33BBB20", VA = "0x1833BD520")]
		private void OnClose(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272A")]
		[Address(RVA = "0x33BD6C0", Offset = "0x33BBCC0", VA = "0x1833BD6C0")]
		private void UpdateQuickSelect(bool update)
		{
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272B")]
		[Address(RVA = "0x33BD8F0", Offset = "0x33BBEF0", VA = "0x1833BD8F0")]
		private void OnCursorMoved(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272C")]
		[Address(RVA = "0x33BDD30", Offset = "0x33BC330", VA = "0x1833BDD30")]
		private void OnPrimaryAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x0000BB08 File Offset: 0x00009D08
		[Token(Token = "0x600272D")]
		[Address(RVA = "0x33BE0B0", Offset = "0x33BC6B0", VA = "0x1833BE0B0")]
		private static bool TryPerformEatAction(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272E")]
		[Address(RVA = "0x33BE330", Offset = "0x33BC930", VA = "0x1833BE330")]
		private void OnRemoveFromBackpack(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272F")]
		[Address(RVA = "0x33BE4A0", Offset = "0x33BCAA0", VA = "0x1833BE4A0")]
		public void RefreshQuickSelectItems()
		{
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002730")]
		[Address(RVA = "0x33BE8F0", Offset = "0x33BCEF0", VA = "0x1833BE8F0")]
		public InventoryBagController()
		{
		}

		// Token: 0x0400233C RID: 9020
		[Token(Token = "0x400233C")]
		[FieldOffset(Offset = "0x68")]
		private bool _inventoryMode;

		// Token: 0x0400233D RID: 9021
		[Token(Token = "0x400233D")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Vector2 _startingCursorPosition;

		// Token: 0x0400233E RID: 9022
		[Token(Token = "0x400233E")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _cursorThrottleSpeedWhenOverItem;

		// Token: 0x0400233F RID: 9023
		[Token(Token = "0x400233F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private VirtualMouseInput _virtualMouse;

		// Token: 0x04002340 RID: 9024
		[Token(Token = "0x4002340")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private InputCursorState _inputCursorState;

		// Token: 0x04002341 RID: 9025
		[Token(Token = "0x4002341")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private LayoutItemCursorSnapping _cursorSnapping;

		// Token: 0x04002342 RID: 9026
		[Token(Token = "0x4002342")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _cursorMouseSpeed;

		// Token: 0x04002343 RID: 9027
		[Token(Token = "0x4002343")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float _cursorGamepadSpeed;

		// Token: 0x04002344 RID: 9028
		[Token(Token = "0x4002344")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<QuickSlotHookPoint> _quickSlotHookPoints;

		// Token: 0x04002345 RID: 9029
		[Token(Token = "0x4002345")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<QuickSelectLayoutItem> _quickSelectLayoutItems;

		// Token: 0x04002346 RID: 9030
		[Token(Token = "0x4002346")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[EventRef]
		private string _openQuickSelectAudioEvent;

		// Token: 0x04002347 RID: 9031
		[Token(Token = "0x4002347")]
		[FieldOffset(Offset = "0xB0")]
		[EventRef]
		[SerializeField]
		private string _closeQuickSelectAudioEvent;

		// Token: 0x04002348 RID: 9032
		[Token(Token = "0x4002348")]
		[FieldOffset(Offset = "0xB8")]
		private bool _currentlyActive;

		// Token: 0x04002349 RID: 9033
		[Token(Token = "0x4002349")]
		[FieldOffset(Offset = "0xBC")]
		private Vector2 _cursorDelta;

		// Token: 0x0400234A RID: 9034
		[Token(Token = "0x400234A")]
		[FieldOffset(Offset = "0xC4")]
		private bool _isClosing;

		// Token: 0x0400234B RID: 9035
		[Token(Token = "0x400234B")]
		[FieldOffset(Offset = "0xC5")]
		private bool _isOverItem;

		// Token: 0x0400234C RID: 9036
		[Token(Token = "0x400234C")]
		[FieldOffset(Offset = "0xC8")]
		private Vector2 _mouseScreenPosition;
	}
}
