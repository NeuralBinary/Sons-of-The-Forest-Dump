using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Weapon
{
	// Token: 0x02000841 RID: 2113
	[Token(Token = "0x2000841")]
	[AddComponentMenu("Sons/Items/FlaskController")]
	public class FlaskController : HeldControllerBase
	{
		// Token: 0x06003860 RID: 14432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003860")]
		[Address(RVA = "0x2EC8BC0", Offset = "0x2EC7BC0", VA = "0x182EC8BC0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003861")]
		[Address(RVA = "0x2EC8E90", Offset = "0x2EC7E90", VA = "0x182EC8E90", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003862")]
		[Address(RVA = "0x2EC8FD0", Offset = "0x2EC7FD0", VA = "0x182EC8FD0")]
		private void OnTryDrink(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003863")]
		[Address(RVA = "0x2EC8FA0", Offset = "0x2EC7FA0", VA = "0x182EC8FA0")]
		private void OnDrinkComplete()
		{
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x000107E8 File Offset: 0x0000E9E8
		[Token(Token = "0x6003864")]
		[Address(RVA = "0x2EC8E10", Offset = "0x2EC7E10", VA = "0x182EC8E10", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x00010800 File Offset: 0x0000EA00
		[Token(Token = "0x6003865")]
		[Address(RVA = "0x2D93A80", Offset = "0x2D92A80", VA = "0x182D93A80")]
		private bool IsInInventory()
		{
			return default(bool);
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003866")]
		[Address(RVA = "0x2EC61C0", Offset = "0x2EC51C0", VA = "0x182EC61C0")]
		public FlaskController()
		{
		}

		// Token: 0x0400302A RID: 12330
		[Token(Token = "0x400302A")]
		[FieldOffset(Offset = "0x70")]
		private VolumeContainerItemInstanceModule _module;
	}
}
