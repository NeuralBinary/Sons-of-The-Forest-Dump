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
	// Token: 0x02000877 RID: 2167
	[Token(Token = "0x2000877")]
	[AddComponentMenu("Sons/Items/TorchWeaponController")]
	public class TorchWeaponController : GenericMeleeWeaponController, IBurnable
	{
		// Token: 0x06003A03 RID: 14851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A03")]
		[Address(RVA = "0x2F08BC0", Offset = "0x2F07BC0", VA = "0x182F08BC0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, int itemId)
		{
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A04")]
		[Address(RVA = "0x2F09120", Offset = "0x2F08120", VA = "0x182F09120", Slot = "13")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A05")]
		[Address(RVA = "0x2F09250", Offset = "0x2F08250", VA = "0x182F09250", Slot = "28")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A06")]
		[Address(RVA = "0x2F09320", Offset = "0x2F08320", VA = "0x182F09320", Slot = "29")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A07")]
		[Address(RVA = "0x2F08F80", Offset = "0x2F07F80", VA = "0x182F08F80")]
		private void OnActivated()
		{
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A08")]
		[Address(RVA = "0x2F09480", Offset = "0x2F08480", VA = "0x182F09480", Slot = "17")]
		internal override void Update()
		{
		}

		// Token: 0x06003A09 RID: 14857 RVA: 0x00011028 File Offset: 0x0000F228
		[Token(Token = "0x6003A09")]
		[Address(RVA = "0x2F08E70", Offset = "0x2F07E70", VA = "0x182F08E70", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A0A")]
		[Address(RVA = "0x2F08940", Offset = "0x2F07940", VA = "0x182F08940", Slot = "33")]
		public void Burn()
		{
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A0B")]
		[Address(RVA = "0x2F08960", Offset = "0x2F07960", VA = "0x182F08960")]
		private void EnableLitObjects(bool enable)
		{
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A0C")]
		[Address(RVA = "0x2F08930", Offset = "0x2F07930", VA = "0x182F08930")]
		public void BlockKeepLitOnStash()
		{
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A0D")]
		[Address(RVA = "0x2F093F0", Offset = "0x2F083F0", VA = "0x182F093F0")]
		private void UpdateLightStimuli(bool lightActive)
		{
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06003A0E RID: 14862 RVA: 0x00011040 File Offset: 0x0000F240
		// (set) Token: 0x06003A0F RID: 14863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071F")]
		public bool IsBurning
		{
			[Token(Token = "0x6003A0E")]
			[Address(RVA = "0x2F096B0", Offset = "0x2F086B0", VA = "0x182F096B0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A0F")]
			[Address(RVA = "0x2F096C0", Offset = "0x2F086C0", VA = "0x182F096C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A10")]
		[Address(RVA = "0x2F09600", Offset = "0x2F08600", VA = "0x182F09600")]
		public TorchWeaponController()
		{
		}

		// Token: 0x0400312C RID: 12588
		[Token(Token = "0x400312C")]
		[FieldOffset(Offset = "0x178")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _stimuliBrightness;

		// Token: 0x0400312D RID: 12589
		[Token(Token = "0x400312D")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[EventRef]
		private string _onLightAudioEvent;

		// Token: 0x0400312E RID: 12590
		[Token(Token = "0x400312E")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private List<GameObject> _litObjects;

		// Token: 0x0400312F RID: 12591
		[Token(Token = "0x400312F")]
		[FieldOffset(Offset = "0x190")]
		private bool _blockKeepLitOnStash;
	}
}
