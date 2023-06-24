using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Interfaces;
using Sons.Inventory;
using Sons.Weapon;
using TheForest.Items.Special;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Item
{
	// Token: 0x020005B5 RID: 1461
	[Token(Token = "0x20005B5")]
	[AddComponentMenu("Sons/Items/PlasmaLighterController")]
	public class PlasmaLighterController : HeldControllerBase
	{
		// Token: 0x0600262D RID: 9773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262D")]
		[Address(RVA = "0x33A67A0", Offset = "0x33A4DA0", VA = "0x1833A67A0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262E")]
		[Address(RVA = "0x33A69F0", Offset = "0x33A4FF0", VA = "0x1833A69F0")]
		public void ShowLight()
		{
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262F")]
		[Address(RVA = "0x33A6BB0", Offset = "0x33A51B0", VA = "0x1833A6BB0")]
		public void HideLight()
		{
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002630")]
		[Address(RVA = "0x33A6C80", Offset = "0x33A5280", VA = "0x1833A6C80")]
		public void UpdateLightStimuli(bool lightActive)
		{
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002631")]
		[Address(RVA = "0x33A6D10", Offset = "0x33A5310", VA = "0x1833A6D10", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x6002632")]
		[Address(RVA = "0x33A7270", Offset = "0x33A5870", VA = "0x1833A7270", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002633")]
		[Address(RVA = "0x33A7480", Offset = "0x33A5A80", VA = "0x1833A7480")]
		private void RegisterEvents()
		{
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002634")]
		[Address(RVA = "0x33A7BE0", Offset = "0x33A61E0", VA = "0x1833A7BE0")]
		private void UnregisterEvents()
		{
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002635")]
		[Address(RVA = "0x33A8340", Offset = "0x33A6940", VA = "0x1833A8340")]
		private void OnDisable()
		{
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002636")]
		[Address(RVA = "0x33A8360", Offset = "0x33A6960", VA = "0x1833A8360")]
		public void LightFire(ILightableFire fire, bool prompt, Action onMovementCallback, PlasmaLighterController.OnLightFireComplete onLightFireCompleteCallback)
		{
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002637")]
		[Address(RVA = "0x33A83A0", Offset = "0x33A69A0", VA = "0x1833A83A0")]
		private IEnumerator LightFireRoutine(ILightableFire fire, bool prompt, Action onMovementCallback, PlasmaLighterController.OnLightFireComplete onLightFireCompleteCallback)
		{
			return null;
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002638")]
		[Address(RVA = "0x33A8560", Offset = "0x33A6B60", VA = "0x1833A8560")]
		private void LightFireCleanUp()
		{
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x0000B568 File Offset: 0x00009768
		[Token(Token = "0x6002639")]
		[Address(RVA = "0x33A88E0", Offset = "0x33A6EE0", VA = "0x1833A88E0")]
		public bool IsLightingFire(ILightableFire fire)
		{
			return default(bool);
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x600263A")]
		[Address(RVA = "0x33A8910", Offset = "0x33A6F10", VA = "0x1833A8910")]
		private static bool HasHorizontalVelocity()
		{
			return default(bool);
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263B")]
		[Address(RVA = "0x33A89E0", Offset = "0x33A6FE0", VA = "0x1833A89E0")]
		public void OnLeanForwardToLight()
		{
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263C")]
		[Address(RVA = "0x33A8A60", Offset = "0x33A7060", VA = "0x1833A8A60")]
		private void OnLightHeldItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x600263D")]
		[Address(RVA = "0x33A8BA0", Offset = "0x33A71A0", VA = "0x1833A8BA0")]
		private static bool IsLightableItemInRightHand()
		{
			return default(bool);
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263E")]
		[Address(RVA = "0x33A8DD0", Offset = "0x33A73D0", VA = "0x1833A8DD0")]
		private IEnumerator LightHeldItemRoutine()
		{
			return null;
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263F")]
		[Address(RVA = "0x33A8E60", Offset = "0x33A7460", VA = "0x1833A8E60")]
		private void CancelLightHeldItem()
		{
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002640")]
		[Address(RVA = "0x33A8FE0", Offset = "0x33A75E0", VA = "0x1833A8FE0")]
		public PlasmaLighterController()
		{
		}

		// Token: 0x04002259 RID: 8793
		[Token(Token = "0x4002259")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _lightGroup;

		// Token: 0x0400225A RID: 8794
		[Token(Token = "0x400225A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Light _localPlayerLight;

		// Token: 0x0400225B RID: 8795
		[Token(Token = "0x400225B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Light _remotePlayerLight;

		// Token: 0x0400225C RID: 8796
		[Token(Token = "0x400225C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private LightFireReceiver _lightFireReceiver;

		// Token: 0x0400225D RID: 8797
		[Token(Token = "0x400225D")]
		[FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _stimuliIllumination;

		// Token: 0x0400225E RID: 8798
		[Token(Token = "0x400225E")]
		[FieldOffset(Offset = "0x90")]
		private LayerBehaviourActivator _fullBodyLayerBehaviourActivator;

		// Token: 0x0400225F RID: 8799
		[Token(Token = "0x400225F")]
		[FieldOffset(Offset = "0x98")]
		private AnimatorLayersController _layersController;

		// Token: 0x04002260 RID: 8800
		[Token(Token = "0x4002260")]
		[FieldOffset(Offset = "0xA0")]
		private LayerBehaviourActivator _leftArmLayerBehaviourActivator;

		// Token: 0x04002261 RID: 8801
		[Token(Token = "0x4002261")]
		[FieldOffset(Offset = "0xA8")]
		private LayerBehaviourActivator _spineLayerBehaviourActivator;

		// Token: 0x04002262 RID: 8802
		[Token(Token = "0x4002262")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _movePlayerInToRange;

		// Token: 0x04002263 RID: 8803
		[Token(Token = "0x4002263")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _movePlayerInToRangeDuration;

		// Token: 0x04002264 RID: 8804
		[Token(Token = "0x4002264")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _lightFireAnimationTimeoutDelay;

		// Token: 0x04002265 RID: 8805
		[Token(Token = "0x4002265")]
		[FieldOffset(Offset = "0xC0")]
		private ILightableFire _activeLightFireRoutineFire;

		// Token: 0x04002266 RID: 8806
		[Token(Token = "0x4002266")]
		[FieldOffset(Offset = "0xC8")]
		private PlasmaLighterController.OnLightFireComplete _activeLightFireRoutineCompleteCallback;

		// Token: 0x04002267 RID: 8807
		[Token(Token = "0x4002267")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _durationToHoldFlameToItem;

		// Token: 0x04002268 RID: 8808
		[Token(Token = "0x4002268")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float _animationTimeoutDelay;

		// Token: 0x04002269 RID: 8809
		[Token(Token = "0x4002269")]
		[FieldOffset(Offset = "0xD8")]
		private Coroutine _lightHeldItemRoutine;

		// Token: 0x020005B6 RID: 1462
		// (Invoke) Token: 0x06002642 RID: 9794
		[Token(Token = "0x20005B6")]
		public delegate void OnLightFireComplete();
	}
}
