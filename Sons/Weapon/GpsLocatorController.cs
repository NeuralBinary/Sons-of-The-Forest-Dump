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
	// Token: 0x020008B8 RID: 2232
	[Token(Token = "0x20008B8")]
	[AddComponentMenu("Sons/Items/GpsLocatorController")]
	public class GpsLocatorController : HeldControllerBase, IItemInstanceModuleConsumer
	{
		// Token: 0x06003FBB RID: 16315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBB")]
		[Address(RVA = "0x35ECEE0", Offset = "0x35EB4E0", VA = "0x1835ECEE0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBC")]
		[Address(RVA = "0x34F17A0", Offset = "0x34EFDA0", VA = "0x1834F17A0")]
		private void OnMouseEnter()
		{
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBD")]
		[Address(RVA = "0x34F17B0", Offset = "0x34EFDB0", VA = "0x1834F17B0")]
		private void OnMouseExit()
		{
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBE")]
		[Address(RVA = "0x35ED120", Offset = "0x35EB720", VA = "0x1835ED120")]
		protected void OnEnable()
		{
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBF")]
		[Address(RVA = "0x35ED740", Offset = "0x35EBD40", VA = "0x1835ED740")]
		protected void OnDisable()
		{
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x00013740 File Offset: 0x00011940
		[Token(Token = "0x6003FC0")]
		[Address(RVA = "0x35ED980", Offset = "0x35EBF80", VA = "0x1835ED980", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC1")]
		[Address(RVA = "0x35ED9F0", Offset = "0x35EBFF0", VA = "0x1835ED9F0")]
		protected void RegisterEvents()
		{
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x35EDD20", Offset = "0x35EC320", VA = "0x1835EDD20")]
		protected void UnregisterEvents()
		{
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x35EE1F0", Offset = "0x35EC7F0", VA = "0x1835EE1F0")]
		private void OnCycleLocatorIconAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC4")]
		[Address(RVA = "0x35EE200", Offset = "0x35EC800", VA = "0x1835EE200")]
		private void OnItemActivated()
		{
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC5")]
		[Address(RVA = "0x35EE210", Offset = "0x35EC810", VA = "0x1835EE210")]
		private void CycleLocatorIcon()
		{
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC6")]
		[Address(RVA = "0x35EE660", Offset = "0x35ECC60", VA = "0x1835EE660", Slot = "10")]
		public void ModuleRefreshed(ItemInstanceModule module)
		{
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC7")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public GpsLocatorController()
		{
		}

		// Token: 0x0400352B RID: 13611
		[Token(Token = "0x400352B")]
		[FieldOffset(Offset = "0x68")]
		[EventRef]
		[SerializeField]
		private string _changeIconAudioEvent;

		// Token: 0x0400352C RID: 13612
		[Token(Token = "0x400352C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _inGrabBag;

		// Token: 0x0400352D RID: 13613
		[Token(Token = "0x400352D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RawImage _locatorIcon;

		// Token: 0x0400352E RID: 13614
		[Token(Token = "0x400352E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RawImage _locatorIconOutline;

		// Token: 0x0400352F RID: 13615
		[Token(Token = "0x400352F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RawImage _locatorColor;

		// Token: 0x04003530 RID: 13616
		[Token(Token = "0x4003530")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GPSLocatorIcons _locatorIcons;

		// Token: 0x04003531 RID: 13617
		[Token(Token = "0x4003531")]
		[FieldOffset(Offset = "0x98")]
		private GPSLocator _gpsLocator;

		// Token: 0x04003532 RID: 13618
		[Token(Token = "0x4003532")]
		[FieldOffset(Offset = "0xA0")]
		private bool _isMouseOver;

		// Token: 0x04003533 RID: 13619
		[Token(Token = "0x4003533")]
		[FieldOffset(Offset = "0xA8")]
		private MouseEventsProxy _mouseEventsProxy;
	}
}
