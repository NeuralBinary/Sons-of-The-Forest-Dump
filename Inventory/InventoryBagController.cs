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
	// Token: 0x020005D2 RID: 1490
	[Token(Token = "0x20005D2")]
	[AddComponentMenu("Sons/Items/InventoryBagController")]
	public class InventoryBagController : HeldControllerBase
	{
		// Token: 0x06002618 RID: 9752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002618")]
		[Address(RVA = "0x2D94A80", Offset = "0x2D93A80", VA = "0x182D94A80", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002619")]
		[Address(RVA = "0x2D96830", Offset = "0x2D95830", VA = "0x182D96830")]
		private void Update()
		{
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261A")]
		[Address(RVA = "0x2D950C0", Offset = "0x2D940C0", VA = "0x182D950C0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x600261B")]
		[Address(RVA = "0x2D94AD0", Offset = "0x2D93AD0", VA = "0x182D94AD0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x0000B400 File Offset: 0x00009600
		[Token(Token = "0x600261C")]
		[Address(RVA = "0x2D94B80", Offset = "0x2D93B80", VA = "0x182D94B80", Slot = "8")]
		protected override bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261D")]
		[Address(RVA = "0x2D95C80", Offset = "0x2D94C80", VA = "0x182D95C80")]
		private void ToggleQuickSelect(bool enable)
		{
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261E")]
		[Address(RVA = "0x2D95A20", Offset = "0x2D94A20", VA = "0x182D95A20")]
		private void RegisterInputEvents()
		{
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261F")]
		[Address(RVA = "0x2D964E0", Offset = "0x2D954E0", VA = "0x182D964E0")]
		private void UnregisterInputEvents()
		{
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002620")]
		[Address(RVA = "0x2D94CF0", Offset = "0x2D93CF0", VA = "0x182D94CF0")]
		private void OnClose(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002621")]
		[Address(RVA = "0x2D966F0", Offset = "0x2D956F0", VA = "0x182D966F0")]
		private void UpdateQuickSelect(bool update)
		{
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002622")]
		[Address(RVA = "0x2D94D90", Offset = "0x2D93D90", VA = "0x182D94D90")]
		private void OnCursorMoved(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002623")]
		[Address(RVA = "0x2D95180", Offset = "0x2D94180", VA = "0x182D95180")]
		private void OnPrimaryAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x0000B418 File Offset: 0x00009618
		[Token(Token = "0x6002624")]
		[Address(RVA = "0x2D962E0", Offset = "0x2D952E0", VA = "0x182D962E0")]
		private static bool TryPerformEatAction(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002625")]
		[Address(RVA = "0x2D954C0", Offset = "0x2D944C0", VA = "0x182D954C0")]
		private void OnRemoveFromBackpack(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002626")]
		[Address(RVA = "0x2D95610", Offset = "0x2D94610", VA = "0x182D95610")]
		public void RefreshQuickSelectItems()
		{
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002627")]
		[Address(RVA = "0x2D96A60", Offset = "0x2D95A60", VA = "0x182D96A60")]
		public InventoryBagController()
		{
		}

		// Token: 0x0400225E RID: 8798
		[Token(Token = "0x400225E")]
		[FieldOffset(Offset = "0x70")]
		private bool _inventoryMode;

		// Token: 0x0400225F RID: 8799
		[Token(Token = "0x400225F")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Vector2 _startingCursorPosition;

		// Token: 0x04002260 RID: 8800
		[Token(Token = "0x4002260")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float _cursorThrottleSpeedWhenOverItem;

		// Token: 0x04002261 RID: 8801
		[Token(Token = "0x4002261")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private VirtualMouseInput _virtualMouse;

		// Token: 0x04002262 RID: 8802
		[Token(Token = "0x4002262")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InputCursorState _inputCursorState;

		// Token: 0x04002263 RID: 8803
		[Token(Token = "0x4002263")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private LayoutItemCursorSnapping _cursorSnapping;

		// Token: 0x04002264 RID: 8804
		[Token(Token = "0x4002264")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _cursorMouseSpeed;

		// Token: 0x04002265 RID: 8805
		[Token(Token = "0x4002265")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _cursorGamepadSpeed;

		// Token: 0x04002266 RID: 8806
		[Token(Token = "0x4002266")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<QuickSlotHookPoint> _quickSlotHookPoints;

		// Token: 0x04002267 RID: 8807
		[Token(Token = "0x4002267")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<QuickSelectLayoutItem> _quickSelectLayoutItems;

		// Token: 0x04002268 RID: 8808
		[Token(Token = "0x4002268")]
		[FieldOffset(Offset = "0xB0")]
		[EventRef]
		[SerializeField]
		private string _openQuickSelectAudioEvent;

		// Token: 0x04002269 RID: 8809
		[Token(Token = "0x4002269")]
		[FieldOffset(Offset = "0xB8")]
		[EventRef]
		[SerializeField]
		private string _closeQuickSelectAudioEvent;

		// Token: 0x0400226A RID: 8810
		[Token(Token = "0x400226A")]
		[FieldOffset(Offset = "0xC0")]
		private bool _currentlyActive;

		// Token: 0x0400226B RID: 8811
		[Token(Token = "0x400226B")]
		[FieldOffset(Offset = "0xC4")]
		private Vector2 _cursorDelta;

		// Token: 0x0400226C RID: 8812
		[Token(Token = "0x400226C")]
		[FieldOffset(Offset = "0xCC")]
		private bool _isClosing;

		// Token: 0x0400226D RID: 8813
		[Token(Token = "0x400226D")]
		[FieldOffset(Offset = "0xCD")]
		private bool _isOverItem;

		// Token: 0x0400226E RID: 8814
		[Token(Token = "0x400226E")]
		[FieldOffset(Offset = "0xD0")]
		private Vector2 _mouseScreenPosition;
	}
}
