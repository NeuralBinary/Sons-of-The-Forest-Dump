using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200083C RID: 2108
	[Token(Token = "0x200083C")]
	[AddComponentMenu("Sons/Items/EmailPageController")]
	public class EmailPageController : HeldControllerBase
	{
		// Token: 0x06003831 RID: 14385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003831")]
		[Address(RVA = "0x2EC6460", Offset = "0x2EC5460", VA = "0x182EC6460")]
		private void Update()
		{
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003832")]
		[Address(RVA = "0x2EC6390", Offset = "0x2EC5390", VA = "0x182EC6390", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x00010740 File Offset: 0x0000E940
		[Token(Token = "0x6003833")]
		[Address(RVA = "0x2EC63E0", Offset = "0x2EC53E0", VA = "0x182EC63E0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003834")]
		[Address(RVA = "0x2EC61C0", Offset = "0x2EC51C0", VA = "0x182EC61C0")]
		public EmailPageController()
		{
		}
	}
}
