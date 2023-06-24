using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Gameplay.GPS;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Weapon
{
	// Token: 0x020008BA RID: 2234
	[Token(Token = "0x20008BA")]
	[AddComponentMenu("Sons/Items/GpsTrackerController")]
	public class GpsTrackerController : HeldControllerBase
	{
		// Token: 0x06003FCA RID: 16330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCA")]
		[Address(RVA = "0x35EE9B0", Offset = "0x35ECFB0", VA = "0x1835EE9B0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x00013770 File Offset: 0x00011970
		[Token(Token = "0x6003FCB")]
		[Address(RVA = "0x35EF180", Offset = "0x35ED780", VA = "0x1835EF180", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCC")]
		[Address(RVA = "0x35EF340", Offset = "0x35ED940", VA = "0x1835EF340", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCD")]
		[Address(RVA = "0x35EF550", Offset = "0x35EDB50", VA = "0x1835EF550")]
		private void OnZoomMapAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCE")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public GpsTrackerController()
		{
		}

		// Token: 0x04003535 RID: 13621
		[Token(Token = "0x4003535")]
		[FieldOffset(Offset = "0x68")]
		private AnimatorLayersController _layersController;

		// Token: 0x04003536 RID: 13622
		[Token(Token = "0x4003536")]
		[FieldOffset(Offset = "0x70")]
		private LayerBehaviourActivator _leftArmLayerBehaviourActivator;

		// Token: 0x04003537 RID: 13623
		[Token(Token = "0x4003537")]
		[FieldOffset(Offset = "0x78")]
		private int _currentZoomLevel;

		// Token: 0x04003538 RID: 13624
		[Token(Token = "0x4003538")]
		[FieldOffset(Offset = "0x80")]
		private GPSTrackerSystem _gpsTrackerSystem;
	}
}
