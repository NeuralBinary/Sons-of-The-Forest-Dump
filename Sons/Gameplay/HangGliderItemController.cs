using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000744 RID: 1860
	[Token(Token = "0x2000744")]
	[AddComponentMenu("Sons/Gameplay/HangGliderItemController")]
	public class HangGliderItemController : HeldControllerBase
	{
		// Token: 0x060031B7 RID: 12727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B7")]
		[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
		public Transform GetDriverTransform()
		{
			return null;
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B8")]
		[Address(RVA = "0x348FF80", Offset = "0x348E580", VA = "0x18348FF80", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B9")]
		[Address(RVA = "0x34901D0", Offset = "0x348E7D0", VA = "0x1834901D0")]
		private void OnDisable()
		{
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031BA")]
		[Address(RVA = "0x3490310", Offset = "0x348E910", VA = "0x183490310")]
		private void Update()
		{
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031BB")]
		[Address(RVA = "0x3490370", Offset = "0x348E970", VA = "0x183490370")]
		private void UpdateGliding(bool isGliding)
		{
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031BC")]
		[Address(RVA = "0x34905F0", Offset = "0x348EBF0", VA = "0x1834905F0")]
		private void UpdateProxy()
		{
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
		[Token(Token = "0x60031BD")]
		[Address(RVA = "0x34907D0", Offset = "0x348EDD0", VA = "0x1834907D0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031BE")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public HangGliderItemController()
		{
		}

		// Token: 0x04002AE9 RID: 10985
		[Token(Token = "0x4002AE9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _driverTransform;

		// Token: 0x04002AEA RID: 10986
		[Token(Token = "0x4002AEA")]
		[FieldOffset(Offset = "0x70")]
		private PlayerHangGliderAction _playerHangGliderAction;

		// Token: 0x04002AEB RID: 10987
		[Token(Token = "0x4002AEB")]
		[FieldOffset(Offset = "0x78")]
		private Animator _gliderAnimator;
	}
}
