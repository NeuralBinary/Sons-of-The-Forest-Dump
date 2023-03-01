using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Interfaces;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000858 RID: 2136
	[Token(Token = "0x2000858")]
	[AddComponentMenu("Sons/Weapon/MolotovWeaponController")]
	public class MolotovWeaponController : RangedWeaponController, IBurnable
	{
		// Token: 0x06003916 RID: 14614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003916")]
		[Address(RVA = "0x2ED2CC0", Offset = "0x2ED1CC0", VA = "0x182ED2CC0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, int itemId)
		{
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003917")]
		[Address(RVA = "0x2ED34C0", Offset = "0x2ED24C0", VA = "0x182ED34C0", Slot = "14")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003918")]
		[Address(RVA = "0x2ED3590", Offset = "0x2ED2590", VA = "0x182ED3590", Slot = "15")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003919")]
		[Address(RVA = "0x2ED2EA0", Offset = "0x2ED1EA0", VA = "0x182ED2EA0")]
		private void OnActivated()
		{
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391A")]
		[Address(RVA = "0x2ED3660", Offset = "0x2ED2660", VA = "0x182ED3660", Slot = "16")]
		protected override void Update()
		{
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391B")]
		[Address(RVA = "0x2ED3040", Offset = "0x2ED2040", VA = "0x182ED3040", Slot = "12")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391C")]
		[Address(RVA = "0x2EC6A60", Offset = "0x2EC5A60", VA = "0x182EC6A60", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391D")]
		[Address(RVA = "0x2ED30F0", Offset = "0x2ED20F0", VA = "0x182ED30F0", Slot = "33")]
		protected override void OnItemLeavesHandCallback()
		{
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391E")]
		[Address(RVA = "0x2ED29B0", Offset = "0x2ED19B0", VA = "0x182ED29B0", Slot = "32")]
		protected override void AttackEndCallback()
		{
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		[Token(Token = "0x600391F")]
		[Address(RVA = "0x2ED2E00", Offset = "0x2ED1E00", VA = "0x182ED2E00", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003920")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "27")]
		public override void TriggerShotFiredAudio()
		{
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003921")]
		[Address(RVA = "0x2ED2AA0", Offset = "0x2ED1AA0", VA = "0x182ED2AA0", Slot = "36")]
		public void Burn()
		{
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003922")]
		[Address(RVA = "0x2ED2AC0", Offset = "0x2ED1AC0", VA = "0x182ED2AC0")]
		private void EnableLitObjects(bool enable)
		{
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x00010C08 File Offset: 0x0000EE08
		// (set) Token: 0x06003924 RID: 14628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000717")]
		public bool IsBurning
		{
			[Token(Token = "0x6003923")]
			[Address(RVA = "0x2ED3890", Offset = "0x2ED2890", VA = "0x182ED3890", Slot = "35")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003924")]
			[Address(RVA = "0x2ED38A0", Offset = "0x2ED28A0", VA = "0x182ED38A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003925")]
		[Address(RVA = "0x2ED37E0", Offset = "0x2ED27E0", VA = "0x182ED37E0")]
		public MolotovWeaponController()
		{
		}

		// Token: 0x040030A3 RID: 12451
		[Token(Token = "0x40030A3")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private AmmoProperties _litAmmo;

		// Token: 0x040030A4 RID: 12452
		[Token(Token = "0x40030A4")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private AmmoProperties _unlitAmmo;

		// Token: 0x040030A5 RID: 12453
		[Token(Token = "0x40030A5")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _stimuliBrightness;

		// Token: 0x040030A6 RID: 12454
		[Token(Token = "0x40030A6")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[EventRef]
		private string _onLightAudioEvent;

		// Token: 0x040030A7 RID: 12455
		[Token(Token = "0x40030A7")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private List<GameObject> _litObjects;
	}
}
