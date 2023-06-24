using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Interfaces;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008E9 RID: 2281
	[Token(Token = "0x20008E9")]
	[AddComponentMenu("Sons/Items/TorchWeaponController")]
	public class TorchWeaponController : GenericMeleeWeaponController, IBurnable
	{
		// Token: 0x0600412B RID: 16683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412B")]
		[Address(RVA = "0x360B1B0", Offset = "0x36097B0", VA = "0x18360B1B0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412C")]
		[Address(RVA = "0x360B500", Offset = "0x3609B00", VA = "0x18360B500", Slot = "13")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412D")]
		[Address(RVA = "0x360B630", Offset = "0x3609C30", VA = "0x18360B630", Slot = "28")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412E")]
		[Address(RVA = "0x360B760", Offset = "0x3609D60", VA = "0x18360B760", Slot = "29")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412F")]
		[Address(RVA = "0x360B890", Offset = "0x3609E90", VA = "0x18360B890")]
		private void OnActivated()
		{
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004130")]
		[Address(RVA = "0x360BAC0", Offset = "0x360A0C0", VA = "0x18360BAC0", Slot = "17")]
		internal override void Update()
		{
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00013EC0 File Offset: 0x000120C0
		[Token(Token = "0x6004131")]
		[Address(RVA = "0x360BC80", Offset = "0x360A280", VA = "0x18360BC80", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004132")]
		[Address(RVA = "0x360BDE0", Offset = "0x360A3E0", VA = "0x18360BDE0", Slot = "33")]
		public void Burn()
		{
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004133")]
		[Address(RVA = "0x360BE00", Offset = "0x360A400", VA = "0x18360BE00")]
		private void EnableLitObjects(bool enable)
		{
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004134")]
		[Address(RVA = "0x360C0E0", Offset = "0x360A6E0", VA = "0x18360C0E0")]
		public void BlockKeepLitOnStash()
		{
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004135")]
		[Address(RVA = "0x360C0F0", Offset = "0x360A6F0", VA = "0x18360C0F0")]
		private void UpdateLightStimuli(bool lightActive)
		{
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x00013ED8 File Offset: 0x000120D8
		// (set) Token: 0x06004137 RID: 16695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000843")]
		public bool IsBurning
		{
			[Token(Token = "0x6004136")]
			[Address(RVA = "0x360C180", Offset = "0x360A780", VA = "0x18360C180", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004137")]
			[Address(RVA = "0x360C190", Offset = "0x360A790", VA = "0x18360C190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004138")]
		[Address(RVA = "0x360C1A0", Offset = "0x360A7A0", VA = "0x18360C1A0")]
		public TorchWeaponController()
		{
		}

		// Token: 0x040035F5 RID: 13813
		[Token(Token = "0x40035F5")]
		[FieldOffset(Offset = "0x180")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _stimuliBrightness;

		// Token: 0x040035F6 RID: 13814
		[Token(Token = "0x40035F6")]
		[FieldOffset(Offset = "0x188")]
		[EventRef]
		[SerializeField]
		private string _onLightAudioEvent;

		// Token: 0x040035F7 RID: 13815
		[Token(Token = "0x40035F7")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private List<GameObject> _litObjects;

		// Token: 0x040035F8 RID: 13816
		[Token(Token = "0x40035F8")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private GameObject _firstPersonFill;

		// Token: 0x040035F9 RID: 13817
		[Token(Token = "0x40035F9")]
		[FieldOffset(Offset = "0x1A0")]
		private bool _blockKeepLitOnStash;
	}
}
