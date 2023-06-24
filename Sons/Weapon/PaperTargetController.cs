using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Weapon
{
	// Token: 0x020008C9 RID: 2249
	[Token(Token = "0x20008C9")]
	[AddComponentMenu("Sons/Items/PaperTargetController")]
	public class PaperTargetController : HeldControllerBase
	{
		// Token: 0x06004042 RID: 16450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004042")]
		[Address(RVA = "0x35F73E0", Offset = "0x35F59E0", VA = "0x1835F73E0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004043")]
		[Address(RVA = "0x35F76A0", Offset = "0x35F5CA0", VA = "0x1835F76A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004044")]
		[Address(RVA = "0x35F7880", Offset = "0x35F5E80", VA = "0x1835F7880")]
		private void Update()
		{
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004045")]
		[Address(RVA = "0x35F7CE0", Offset = "0x35F62E0", VA = "0x1835F7CE0")]
		private void OnPrimaryAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004046")]
		[Address(RVA = "0x35F7EB0", Offset = "0x35F64B0", VA = "0x1835F7EB0")]
		private void OnItemLeavesHandEvent()
		{
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004047")]
		[Address(RVA = "0x35F82D0", Offset = "0x35F68D0", VA = "0x1835F82D0")]
		private void OnActionCompleteEvent()
		{
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x00013A28 File Offset: 0x00011C28
		[Token(Token = "0x6004048")]
		[Address(RVA = "0x35F83B0", Offset = "0x35F69B0", VA = "0x1835F83B0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004049")]
		[Address(RVA = "0x35F84D0", Offset = "0x35F6AD0", VA = "0x1835F84D0")]
		public PaperTargetController()
		{
		}

		// Token: 0x04003570 RID: 13680
		[Token(Token = "0x4003570")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _maxPlacementRange;

		// Token: 0x04003571 RID: 13681
		[Token(Token = "0x4003571")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private LayerMask _allowedSurfacesLayerMask;

		// Token: 0x04003572 RID: 13682
		[Token(Token = "0x4003572")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _targetAsset;

		// Token: 0x04003573 RID: 13683
		[Token(Token = "0x4003573")]
		[FieldOffset(Offset = "0x78")]
		private bool _hasValidTarget;

		// Token: 0x04003574 RID: 13684
		[Token(Token = "0x4003574")]
		[FieldOffset(Offset = "0x80")]
		private Transform _targetVisual;
	}
}
