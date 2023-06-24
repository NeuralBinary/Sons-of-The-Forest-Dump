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
	// Token: 0x020008C8 RID: 2248
	[Token(Token = "0x20008C8")]
	[AddComponentMenu("Sons/Weapon/MolotovWeaponController")]
	public class MolotovWeaponController : RangedWeaponController, IBurnable
	{
		// Token: 0x06004032 RID: 16434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004032")]
		[Address(RVA = "0x35F5D30", Offset = "0x35F4330", VA = "0x1835F5D30", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004033")]
		[Address(RVA = "0x35F5E80", Offset = "0x35F4480", VA = "0x1835F5E80", Slot = "14")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004034")]
		[Address(RVA = "0x35F5FB0", Offset = "0x35F45B0", VA = "0x1835F5FB0", Slot = "15")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004035")]
		[Address(RVA = "0x35F60E0", Offset = "0x35F46E0", VA = "0x1835F60E0")]
		private void OnActivated()
		{
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004036")]
		[Address(RVA = "0x35F6310", Offset = "0x35F4910", VA = "0x1835F6310", Slot = "16")]
		protected override void Update()
		{
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004037")]
		[Address(RVA = "0x35F64D0", Offset = "0x35F4AD0", VA = "0x1835F64D0", Slot = "12")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004038")]
		[Address(RVA = "0x35E31D0", Offset = "0x35E17D0", VA = "0x1835E31D0", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004039")]
		[Address(RVA = "0x35F6580", Offset = "0x35F4B80", VA = "0x1835F6580", Slot = "34")]
		protected override void OnItemLeavesHandCallback()
		{
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403A")]
		[Address(RVA = "0x35F6CF0", Offset = "0x35F52F0", VA = "0x1835F6CF0", Slot = "33")]
		protected override void AttackEndCallback()
		{
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x000139F8 File Offset: 0x00011BF8
		[Token(Token = "0x600403B")]
		[Address(RVA = "0x35F6F60", Offset = "0x35F5560", VA = "0x1835F6F60", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public override void TriggerShotFiredAudio()
		{
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403D")]
		[Address(RVA = "0x35F6FF0", Offset = "0x35F55F0", VA = "0x1835F6FF0", Slot = "37")]
		public void Burn()
		{
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403E")]
		[Address(RVA = "0x35F7010", Offset = "0x35F5610", VA = "0x1835F7010")]
		private void EnableLitObjects(bool enable)
		{
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600403F RID: 16447 RVA: 0x00013A10 File Offset: 0x00011C10
		// (set) Token: 0x06004040 RID: 16448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700083B")]
		public bool IsBurning
		{
			[Token(Token = "0x600403F")]
			[Address(RVA = "0x35F7280", Offset = "0x35F5880", VA = "0x1835F7280", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004040")]
			[Address(RVA = "0x35F7290", Offset = "0x35F5890", VA = "0x1835F7290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004041")]
		[Address(RVA = "0x35F72A0", Offset = "0x35F58A0", VA = "0x1835F72A0")]
		public MolotovWeaponController()
		{
		}

		// Token: 0x0400356A RID: 13674
		[Token(Token = "0x400356A")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private AmmoProperties _litAmmo;

		// Token: 0x0400356B RID: 13675
		[Token(Token = "0x400356B")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private AmmoProperties _unlitAmmo;

		// Token: 0x0400356C RID: 13676
		[Token(Token = "0x400356C")]
		[FieldOffset(Offset = "0x178")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _stimuliBrightness;

		// Token: 0x0400356D RID: 13677
		[Token(Token = "0x400356D")]
		[FieldOffset(Offset = "0x180")]
		[EventRef]
		[SerializeField]
		private string _onLightAudioEvent;

		// Token: 0x0400356E RID: 13678
		[Token(Token = "0x400356E")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private List<GameObject> _litObjects;
	}
}
