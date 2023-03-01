using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Weapon
{
	// Token: 0x02000859 RID: 2137
	[Token(Token = "0x2000859")]
	[AddComponentMenu("Sons/Items/PaperTargetController")]
	public class PaperTargetController : HeldControllerBase
	{
		// Token: 0x06003926 RID: 14630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003926")]
		[Address(RVA = "0x2ED38B0", Offset = "0x2ED28B0", VA = "0x182ED38B0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003927")]
		[Address(RVA = "0x2ED3C50", Offset = "0x2ED2C50", VA = "0x182ED3C50")]
		private void OnDisable()
		{
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003928")]
		[Address(RVA = "0x2ED4200", Offset = "0x2ED3200", VA = "0x182ED4200")]
		private void Update()
		{
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003929")]
		[Address(RVA = "0x2ED4030", Offset = "0x2ED3030", VA = "0x182ED4030")]
		private void OnPrimaryAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392A")]
		[Address(RVA = "0x2ED3DC0", Offset = "0x2ED2DC0", VA = "0x182ED3DC0")]
		private void OnItemLeavesHandEvent()
		{
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392B")]
		[Address(RVA = "0x2ED3B80", Offset = "0x2ED2B80", VA = "0x182ED3B80")]
		private void OnActionCompleteEvent()
		{
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x00010C20 File Offset: 0x0000EE20
		[Token(Token = "0x600392C")]
		[Address(RVA = "0x2ED3AB0", Offset = "0x2ED2AB0", VA = "0x182ED3AB0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392D")]
		[Address(RVA = "0x2ED44C0", Offset = "0x2ED34C0", VA = "0x182ED44C0")]
		public PaperTargetController()
		{
		}

		// Token: 0x040030A9 RID: 12457
		[Token(Token = "0x40030A9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _maxPlacementRange;

		// Token: 0x040030AA RID: 12458
		[Token(Token = "0x40030AA")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private LayerMask _allowedSurfacesLayerMask;

		// Token: 0x040030AB RID: 12459
		[Token(Token = "0x40030AB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _targetAsset;

		// Token: 0x040030AC RID: 12460
		[Token(Token = "0x40030AC")]
		[FieldOffset(Offset = "0x80")]
		private bool _hasValidTarget;

		// Token: 0x040030AD RID: 12461
		[Token(Token = "0x40030AD")]
		[FieldOffset(Offset = "0x88")]
		private Transform _targetVisual;
	}
}
