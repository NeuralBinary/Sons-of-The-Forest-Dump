using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200086A RID: 2154
	[Token(Token = "0x200086A")]
	[AddComponentMenu("Sons/Items/SledController")]
	public class SledController : HeldControllerBase
	{
		// Token: 0x060039B2 RID: 14770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B2")]
		[Address(RVA = "0x2ECFCB0", Offset = "0x2ECECB0", VA = "0x182ECFCB0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, int itemId)
		{
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B3")]
		[Address(RVA = "0x2F05170", Offset = "0x2F04170", VA = "0x182F05170", Slot = "10")]
		internal virtual void Update()
		{
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B4")]
		[Address(RVA = "0x2F05090", Offset = "0x2F04090", VA = "0x182F05090")]
		private void OnDisable()
		{
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x00010E90 File Offset: 0x0000F090
		[Token(Token = "0x60039B5")]
		[Address(RVA = "0x2F05010", Offset = "0x2F04010", VA = "0x182F05010", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B6")]
		[Address(RVA = "0x2D93B10", Offset = "0x2D92B10", VA = "0x182D93B10")]
		public SledController()
		{
		}
	}
}
