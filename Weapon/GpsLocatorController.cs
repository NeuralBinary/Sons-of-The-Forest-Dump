using System;
using Endnight.Utilities;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Gameplay.GPS;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Sons.Weapon
{
	// Token: 0x02000848 RID: 2120
	[Token(Token = "0x2000848")]
	[AddComponentMenu("Sons/Items/GpsLocatorController")]
	public class GpsLocatorController : HeldControllerBase, IItemInstanceModuleConsumer
	{
		// Token: 0x060038A3 RID: 14499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A3")]
		[Address(RVA = "0x2ECD430", Offset = "0x2ECC430", VA = "0x182ECD430", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A4")]
		[Address(RVA = "0x27E57D0", Offset = "0x27E47D0", VA = "0x1827E57D0")]
		private void OnMouseEnter()
		{
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A5")]
		[Address(RVA = "0x2ECDCC0", Offset = "0x2ECCCC0", VA = "0x182ECDCC0")]
		private void OnMouseExit()
		{
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A6")]
		[Address(RVA = "0x2ECDA60", Offset = "0x2ECCA60", VA = "0x182ECDA60")]
		protected void OnEnable()
		{
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A7")]
		[Address(RVA = "0x2ECD890", Offset = "0x2ECC890", VA = "0x182ECD890")]
		protected void OnDisable()
		{
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x00010980 File Offset: 0x0000EB80
		[Token(Token = "0x60038A8")]
		[Address(RVA = "0x2ECD560", Offset = "0x2ECC560", VA = "0x182ECD560", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A9")]
		[Address(RVA = "0x2ECDCD0", Offset = "0x2ECCCD0", VA = "0x182ECDCD0")]
		protected void RegisterEvents()
		{
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AA")]
		[Address(RVA = "0x2ECDF30", Offset = "0x2ECCF30", VA = "0x182ECDF30")]
		protected void UnregisterEvents()
		{
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AB")]
		[Address(RVA = "0x2ECD880", Offset = "0x2ECC880", VA = "0x182ECD880")]
		private void OnCycleLocatorIconAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AC")]
		[Address(RVA = "0x2ECDCB0", Offset = "0x2ECCCB0", VA = "0x182ECDCB0")]
		private void OnItemActivated()
		{
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AD")]
		[Address(RVA = "0x2ECD150", Offset = "0x2ECC150", VA = "0x182ECD150")]
		private void CycleLocatorIcon()
		{
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AE")]
		[Address(RVA = "0x2ECD5E0", Offset = "0x2ECC5E0", VA = "0x182ECD5E0", Slot = "10")]
		public void ModuleRefreshed(ItemInstanceModule module)
		{
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AF")]
		[Address(RVA = "0x2EC61C0", Offset = "0x2EC51C0", VA = "0x182EC61C0")]
		public GpsLocatorController()
		{
		}

		// Token: 0x04003063 RID: 12387
		[Token(Token = "0x4003063")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[EventRef]
		private string _changeIconAudioEvent;

		// Token: 0x04003064 RID: 12388
		[Token(Token = "0x4003064")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _inGrabBag;

		// Token: 0x04003065 RID: 12389
		[Token(Token = "0x4003065")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RawImage _locatorIcon;

		// Token: 0x04003066 RID: 12390
		[Token(Token = "0x4003066")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RawImage _locatorIconOutline;

		// Token: 0x04003067 RID: 12391
		[Token(Token = "0x4003067")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RawImage _locatorColor;

		// Token: 0x04003068 RID: 12392
		[Token(Token = "0x4003068")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GPSLocatorIcons _locatorIcons;

		// Token: 0x04003069 RID: 12393
		[Token(Token = "0x4003069")]
		[FieldOffset(Offset = "0xA0")]
		private GPSLocator _gpsLocator;

		// Token: 0x0400306A RID: 12394
		[Token(Token = "0x400306A")]
		[FieldOffset(Offset = "0xA8")]
		private bool _isMouseOver;

		// Token: 0x0400306B RID: 12395
		[Token(Token = "0x400306B")]
		[FieldOffset(Offset = "0xB0")]
		private MouseEventsProxy _mouseEventsProxy;

		// Token: 0x0400306C RID: 12396
		[Token(Token = "0x400306C")]
		[FieldOffset(Offset = "0xB8")]
		private ItemInstance _itemInstance;
	}
}
