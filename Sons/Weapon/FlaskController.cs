using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Weapon
{
	// Token: 0x020008B1 RID: 2225
	[Token(Token = "0x20008B1")]
	[AddComponentMenu("Sons/Items/FlaskController")]
	public class FlaskController : HeldControllerBase
	{
		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06003F75 RID: 16245 RVA: 0x00013590 File Offset: 0x00011790
		[Token(Token = "0x1700082D")]
		public int NumberOfUses
		{
			[Token(Token = "0x6003F75")]
			[Address(RVA = "0x8DCFC0", Offset = "0x8DB5C0", VA = "0x1808DCFC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F76")]
		[Address(RVA = "0x35E5B50", Offset = "0x35E4150", VA = "0x1835E5B50", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F77")]
		[Address(RVA = "0x35E6000", Offset = "0x35E4600", VA = "0x1835E6000", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F78")]
		[Address(RVA = "0x35E6420", Offset = "0x35E4A20", VA = "0x1835E6420")]
		private void OnActivated()
		{
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F79")]
		[Address(RVA = "0x35E65D0", Offset = "0x35E4BD0", VA = "0x1835E65D0")]
		private void OnTryDrink(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F7A")]
		[Address(RVA = "0x35E6810", Offset = "0x35E4E10", VA = "0x1835E6810")]
		private void OnDumpOut(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F7B")]
		[Address(RVA = "0x35E69B0", Offset = "0x35E4FB0", VA = "0x1835E69B0")]
		private void OnDrinkComplete()
		{
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x000135A8 File Offset: 0x000117A8
		[Token(Token = "0x6003F7C")]
		[Address(RVA = "0x35E69F0", Offset = "0x35E4FF0", VA = "0x1835E69F0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x000135C0 File Offset: 0x000117C0
		[Token(Token = "0x6003F7D")]
		[Address(RVA = "0x2F67C40", Offset = "0x2F66240", VA = "0x182F67C40")]
		private bool IsInInventory()
		{
			return default(bool);
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F7E")]
		[Address(RVA = "0x35E6B10", Offset = "0x35E5110", VA = "0x1835E6B10")]
		public FlaskController()
		{
		}

		// Token: 0x040034F0 RID: 13552
		[Token(Token = "0x40034F0")]
		[FieldOffset(Offset = "0x68")]
		private VolumeContainerItemInstanceModule _module;

		// Token: 0x040034F1 RID: 13553
		[Token(Token = "0x40034F1")]
		[FieldOffset(Offset = "0x70")]
		[Min(0f)]
		[SerializeField]
		private int _numberOfUses;
	}
}
