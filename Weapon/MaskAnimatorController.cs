using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000855 RID: 2133
	[Token(Token = "0x2000855")]
	[AddComponentMenu("Sons/Items/MaskAnimatorController")]
	public class MaskAnimatorController : HeldControllerBase
	{
		// Token: 0x060038EB RID: 14571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038EB")]
		[Address(RVA = "0x2ECFF60", Offset = "0x2ECEF60", VA = "0x182ECFF60", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038EC")]
		[Address(RVA = "0x2ED03D0", Offset = "0x2ECF3D0", VA = "0x182ED03D0")]
		private void Update()
		{
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x00010B30 File Offset: 0x0000ED30
		[Token(Token = "0x60038ED")]
		[Address(RVA = "0x2ED0120", Offset = "0x2ECF120", VA = "0x182ED0120", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038EE")]
		[Address(RVA = "0x2ED0210", Offset = "0x2ECF210", VA = "0x182ED0210")]
		private void OnItemActivated()
		{
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038EF")]
		[Address(RVA = "0x2ED02F0", Offset = "0x2ECF2F0", VA = "0x182ED02F0")]
		private void OnItemDeactivated()
		{
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F0")]
		[Address(RVA = "0x2ED01A0", Offset = "0x2ECF1A0", VA = "0x182ED01A0")]
		private void OnDisable()
		{
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F1")]
		[Address(RVA = "0x2EC61C0", Offset = "0x2EC51C0", VA = "0x182EC61C0")]
		public MaskAnimatorController()
		{
		}

		// Token: 0x0400308E RID: 12430
		[Token(Token = "0x400308E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private EventStimuli _stimuliEvent;
	}
}
