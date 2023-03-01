using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000873 RID: 2163
	[Token(Token = "0x2000873")]
	[AddComponentMenu("Sons/Items/TarpTutorialPageController")]
	public class TarpTutorialPageController : HeldControllerBase
	{
		// Token: 0x060039EB RID: 14827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EB")]
		[Address(RVA = "0x2F07790", Offset = "0x2F06790", VA = "0x182F07790", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EC")]
		[Address(RVA = "0x2F079A0", Offset = "0x2F069A0", VA = "0x182F079A0")]
		private void Update()
		{
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		[Token(Token = "0x60039ED")]
		[Address(RVA = "0x2F07920", Offset = "0x2F06920", VA = "0x182F07920", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EE")]
		[Address(RVA = "0x2D93B10", Offset = "0x2D92B10", VA = "0x182D93B10")]
		public TarpTutorialPageController()
		{
		}
	}
}
