using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.FieldOfView;
using Sons.Inventory;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay
{
	// Token: 0x02000742 RID: 1858
	[Token(Token = "0x2000742")]
	[AddComponentMenu("Sons/Gameplay/BinocularsItemController")]
	public class BinocularsItemController : HeldControllerBase
	{
		// Token: 0x060031A8 RID: 12712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031A8")]
		[Address(RVA = "0x348E7A0", Offset = "0x348CDA0", VA = "0x18348E7A0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x060031A9 RID: 12713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031A9")]
		[Address(RVA = "0x348E9D0", Offset = "0x348CFD0", VA = "0x18348E9D0")]
		private void Update()
		{
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031AA")]
		[Address(RVA = "0x348ECD0", Offset = "0x348D2D0", VA = "0x18348ECD0")]
		private void OnDisable()
		{
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		[Token(Token = "0x60031AB")]
		[Address(RVA = "0x348EE90", Offset = "0x348D490", VA = "0x18348EE90", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031AC")]
		[Address(RVA = "0x348EFB0", Offset = "0x348D5B0", VA = "0x18348EFB0")]
		private void OnItemActivated()
		{
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031AD")]
		[Address(RVA = "0x348EFC0", Offset = "0x348D5C0", VA = "0x18348EFC0")]
		private void ActivateLookThroughMode(bool activate)
		{
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031AE")]
		[Address(RVA = "0x348F130", Offset = "0x348D730", VA = "0x18348F130")]
		private void OnZoomMapAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031AF")]
		[Address(RVA = "0x348F370", Offset = "0x348D970", VA = "0x18348F370")]
		public void DisableRendererVisibility(bool onOff)
		{
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B0")]
		[Address(RVA = "0x348F800", Offset = "0x348DE00", VA = "0x18348F800")]
		public BinocularsItemController()
		{
		}

		// Token: 0x04002AD9 RID: 10969
		[Token(Token = "0x4002AD9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<float> _zoomLevels;

		// Token: 0x04002ADA RID: 10970
		[Token(Token = "0x4002ADA")]
		[FieldOffset(Offset = "0x70")]
		[EventRef]
		[SerializeField]
		public string _zoomChangeSfxEvent;

		// Token: 0x04002ADB RID: 10971
		[Token(Token = "0x4002ADB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private FovManager.FieldOfViewChangeSettings _fovChangeSettings;

		// Token: 0x04002ADC RID: 10972
		[Token(Token = "0x4002ADC")]
		[FieldOffset(Offset = "0x80")]
		private int _currentZoomLevel;

		// Token: 0x04002ADD RID: 10973
		[Token(Token = "0x4002ADD")]
		[FieldOffset(Offset = "0x88")]
		private Binoculars _binocularsHookup;

		// Token: 0x04002ADE RID: 10974
		[Token(Token = "0x4002ADE")]
		[FieldOffset(Offset = "0x90")]
		private FovManager _cameraFovManager;

		// Token: 0x04002ADF RID: 10975
		[Token(Token = "0x4002ADF")]
		[FieldOffset(Offset = "0x98")]
		private bool _zoomIsRegistered;

		// Token: 0x04002AE0 RID: 10976
		[Token(Token = "0x4002AE0")]
		[FieldOffset(Offset = "0x99")]
		private bool _binocularsAreActive;

		// Token: 0x04002AE1 RID: 10977
		[Token(Token = "0x4002AE1")]
		[FieldOffset(Offset = "0x9A")]
		private bool _raiseBinoculars;
	}
}
