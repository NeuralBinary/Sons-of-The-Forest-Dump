using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Interfaces;
using Sons.Weapon;
using TheForest.Items.Special;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Item
{
	// Token: 0x020005A5 RID: 1445
	[Token(Token = "0x20005A5")]
	[AddComponentMenu("Sons/Items/PlasmaLighterController")]
	public class PlasmaLighterController : HeldControllerBase
	{
		// Token: 0x0600252E RID: 9518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252E")]
		[Address(RVA = "0x2D86C50", Offset = "0x2D85C50", VA = "0x182D86C50", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252F")]
		[Address(RVA = "0x2D873A0", Offset = "0x2D863A0", VA = "0x182D873A0")]
		public void ShowLight()
		{
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002530")]
		[Address(RVA = "0x2D86120", Offset = "0x2D85120", VA = "0x182D86120")]
		public void HideLight()
		{
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002531")]
		[Address(RVA = "0x2D877C0", Offset = "0x2D867C0", VA = "0x182D877C0")]
		public void UpdateLightStimuli(bool lightActive)
		{
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002532")]
		[Address(RVA = "0x2D861A0", Offset = "0x2D851A0", VA = "0x182D861A0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x0000AE90 File Offset: 0x00009090
		[Token(Token = "0x6002533")]
		[Address(RVA = "0x2D86440", Offset = "0x2D85440", VA = "0x182D86440", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002534")]
		[Address(RVA = "0x2D87080", Offset = "0x2D86080", VA = "0x182D87080")]
		private void RegisterEvents()
		{
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002535")]
		[Address(RVA = "0x2D874A0", Offset = "0x2D864A0", VA = "0x182D874A0")]
		private void UnregisterEvents()
		{
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002536")]
		[Address(RVA = "0x2D86E00", Offset = "0x2D85E00", VA = "0x182D86E00")]
		private void OnDisable()
		{
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002537")]
		[Address(RVA = "0x2D86B10", Offset = "0x2D85B10", VA = "0x182D86B10")]
		public void LightFire(ILightableFire fire, bool prompt, Action onMovementCallback, PlasmaLighterController.OnLightFireComplete onLightFireCompleteCallback)
		{
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002538")]
		[Address(RVA = "0x2D86A40", Offset = "0x2D85A40", VA = "0x182D86A40")]
		private IEnumerator LightFireRoutine(ILightableFire fire, bool prompt, Action onMovementCallback, PlasmaLighterController.OnLightFireComplete onLightFireCompleteCallback)
		{
			return null;
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002539")]
		[Address(RVA = "0x2D86750", Offset = "0x2D85750", VA = "0x182D86750")]
		private void LightFireCleanUp()
		{
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x600253A")]
		[Address(RVA = "0x2D86720", Offset = "0x2D85720", VA = "0x182D86720")]
		public bool IsLightingFire(ILightableFire fire)
		{
			return default(bool);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[Token(Token = "0x600253B")]
		[Address(RVA = "0x2D86030", Offset = "0x2D85030", VA = "0x182D86030")]
		private static bool HasHorizontalVelocity()
		{
			return default(bool);
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253C")]
		[Address(RVA = "0x2D86E20", Offset = "0x2D85E20", VA = "0x182D86E20")]
		public void OnLeanForwardToLight()
		{
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253D")]
		[Address(RVA = "0x2D86E70", Offset = "0x2D85E70", VA = "0x182D86E70")]
		private void OnLightHeldItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x0000AED8 File Offset: 0x000090D8
		[Token(Token = "0x600253E")]
		[Address(RVA = "0x2D865C0", Offset = "0x2D855C0", VA = "0x182D865C0")]
		private static bool IsLightableItemInRightHand()
		{
			return default(bool);
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253F")]
		[Address(RVA = "0x2D86BE0", Offset = "0x2D85BE0", VA = "0x182D86BE0")]
		private IEnumerator LightHeldItemRoutine()
		{
			return null;
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002540")]
		[Address(RVA = "0x2D85EF0", Offset = "0x2D84EF0", VA = "0x182D85EF0")]
		private void CancelLightHeldItem()
		{
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002541")]
		[Address(RVA = "0x2D87850", Offset = "0x2D86850", VA = "0x182D87850")]
		public PlasmaLighterController()
		{
		}

		// Token: 0x04002185 RID: 8581
		[Token(Token = "0x4002185")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lightGroup;

		// Token: 0x04002186 RID: 8582
		[Token(Token = "0x4002186")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Light _localPlayerLight;

		// Token: 0x04002187 RID: 8583
		[Token(Token = "0x4002187")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Light _remotePlayerLight;

		// Token: 0x04002188 RID: 8584
		[Token(Token = "0x4002188")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private LightFireReceiver _lightFireReceiver;

		// Token: 0x04002189 RID: 8585
		[Token(Token = "0x4002189")]
		[FieldOffset(Offset = "0x90")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _stimuliIllumination;

		// Token: 0x0400218A RID: 8586
		[Token(Token = "0x400218A")]
		[FieldOffset(Offset = "0x98")]
		private LayerBehaviourActivator _fullBodyLayerBehaviourActivator;

		// Token: 0x0400218B RID: 8587
		[Token(Token = "0x400218B")]
		[FieldOffset(Offset = "0xA0")]
		private AnimatorLayersController _layersController;

		// Token: 0x0400218C RID: 8588
		[Token(Token = "0x400218C")]
		[FieldOffset(Offset = "0xA8")]
		private LayerBehaviourActivator _leftArmLayerBehaviourActivator;

		// Token: 0x0400218D RID: 8589
		[Token(Token = "0x400218D")]
		[FieldOffset(Offset = "0xB0")]
		private LayerBehaviourActivator _spineLayerBehaviourActivator;

		// Token: 0x0400218E RID: 8590
		[Token(Token = "0x400218E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _movePlayerInToRange;

		// Token: 0x0400218F RID: 8591
		[Token(Token = "0x400218F")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _movePlayerInToRangeDuration;

		// Token: 0x04002190 RID: 8592
		[Token(Token = "0x4002190")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _lightFireAnimationTimeoutDelay;

		// Token: 0x04002191 RID: 8593
		[Token(Token = "0x4002191")]
		[FieldOffset(Offset = "0xC8")]
		private ILightableFire _activeLightFireRoutineFire;

		// Token: 0x04002192 RID: 8594
		[Token(Token = "0x4002192")]
		[FieldOffset(Offset = "0xD0")]
		private PlasmaLighterController.OnLightFireComplete _activeLightFireRoutineCompleteCallback;

		// Token: 0x04002193 RID: 8595
		[Token(Token = "0x4002193")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private float _durationToHoldFlameToItem;

		// Token: 0x04002194 RID: 8596
		[Token(Token = "0x4002194")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float _animationTimeoutDelay;

		// Token: 0x04002195 RID: 8597
		[Token(Token = "0x4002195")]
		[FieldOffset(Offset = "0xE0")]
		private Coroutine _lightHeldItemRoutine;

		// Token: 0x020005A6 RID: 1446
		// (Invoke) Token: 0x06002543 RID: 9539
		[Token(Token = "0x20005A6")]
		public delegate void OnLightFireComplete();
	}
}
