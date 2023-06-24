using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008AC RID: 2220
	[Token(Token = "0x20008AC")]
	[AddComponentMenu("Sons/Items/EmailPageController")]
	public class EmailPageController : HeldControllerBase
	{
		// Token: 0x06003F45 RID: 16197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F45")]
		[Address(RVA = "0x35E23D0", Offset = "0x35E09D0", VA = "0x1835E23D0")]
		private void Update()
		{
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F46")]
		[Address(RVA = "0x35E2530", Offset = "0x35E0B30", VA = "0x1835E2530")]
		private void OnDisable()
		{
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F47")]
		[Address(RVA = "0x35E2590", Offset = "0x35E0B90", VA = "0x1835E2590", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x000134E8 File Offset: 0x000116E8
		[Token(Token = "0x6003F48")]
		[Address(RVA = "0x35E25E0", Offset = "0x35E0BE0", VA = "0x1835E25E0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F49")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public EmailPageController()
		{
		}
	}
}
