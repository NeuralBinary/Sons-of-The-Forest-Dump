using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008DA RID: 2266
	[Token(Token = "0x20008DA")]
	[AddComponentMenu("Sons/Items/SledController")]
	public class SledController : HeldControllerBase
	{
		// Token: 0x060040D6 RID: 16598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040D6")]
		[Address(RVA = "0x35F19D0", Offset = "0x35EFFD0", VA = "0x1835F19D0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040D7")]
		[Address(RVA = "0x3606E70", Offset = "0x3605470", VA = "0x183606E70", Slot = "10")]
		internal virtual void Update()
		{
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040D8")]
		[Address(RVA = "0x3607090", Offset = "0x3605690", VA = "0x183607090")]
		private void OnDisable()
		{
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x00013D10 File Offset: 0x00011F10
		[Token(Token = "0x60040D9")]
		[Address(RVA = "0x36071B0", Offset = "0x36057B0", VA = "0x1836071B0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040DA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SledController()
		{
		}
	}
}
