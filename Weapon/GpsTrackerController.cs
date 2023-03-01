using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Gameplay.GPS;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Weapon
{
	// Token: 0x0200084A RID: 2122
	[Token(Token = "0x200084A")]
	[AddComponentMenu("Sons/Items/GpsTrackerController")]
	public class GpsTrackerController : HeldControllerBase
	{
		// Token: 0x060038B2 RID: 14514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B2")]
		[Address(RVA = "0x2ECE290", Offset = "0x2ECD290", VA = "0x182ECE290", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x000109B0 File Offset: 0x0000EBB0
		[Token(Token = "0x60038B3")]
		[Address(RVA = "0x2ECE5E0", Offset = "0x2ECD5E0", VA = "0x182ECE5E0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B4")]
		[Address(RVA = "0x2ECE730", Offset = "0x2ECD730", VA = "0x182ECE730", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B5")]
		[Address(RVA = "0x2ECE8C0", Offset = "0x2ECD8C0", VA = "0x182ECE8C0")]
		private void OnZoomMapAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B6")]
		[Address(RVA = "0x2EC61C0", Offset = "0x2EC51C0", VA = "0x182EC61C0")]
		public GpsTrackerController()
		{
		}

		// Token: 0x0400306E RID: 12398
		[Token(Token = "0x400306E")]
		[FieldOffset(Offset = "0x70")]
		private AnimatorLayersController _layersController;

		// Token: 0x0400306F RID: 12399
		[Token(Token = "0x400306F")]
		[FieldOffset(Offset = "0x78")]
		private LayerBehaviourActivator _leftArmLayerBehaviourActivator;

		// Token: 0x04003070 RID: 12400
		[Token(Token = "0x4003070")]
		[FieldOffset(Offset = "0x80")]
		private int _currentZoomLevel;

		// Token: 0x04003071 RID: 12401
		[Token(Token = "0x4003071")]
		[FieldOffset(Offset = "0x88")]
		private GPSTrackerSystem _gpsTrackerSystem;
	}
}
