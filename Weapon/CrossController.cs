using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200083B RID: 2107
	[Token(Token = "0x200083B")]
	[AddComponentMenu("Sons/Items/CrossController")]
	public class CrossController : HeldControllerBase
	{
		// Token: 0x0600382A RID: 14378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382A")]
		[Address(RVA = "0x2EC5BC0", Offset = "0x2EC4BC0", VA = "0x182EC5BC0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x00010728 File Offset: 0x0000E928
		[Token(Token = "0x600382B")]
		[Address(RVA = "0x2EC5D40", Offset = "0x2EC4D40", VA = "0x182EC5D40", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382C")]
		[Address(RVA = "0x2EC5F60", Offset = "0x2EC4F60", VA = "0x182EC5F60", Slot = "10")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382D")]
		[Address(RVA = "0x2EC5A50", Offset = "0x2EC4A50", VA = "0x182EC5A50")]
		private void CheckFireInput()
		{
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382E")]
		[Address(RVA = "0x2EC5E10", Offset = "0x2EC4E10", VA = "0x182EC5E10")]
		private void OnItemActivated()
		{
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382F")]
		[Address(RVA = "0x2EC5EE0", Offset = "0x2EC4EE0", VA = "0x182EC5EE0")]
		private void OnItemDeactivated()
		{
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003830")]
		[Address(RVA = "0x2EC61C0", Offset = "0x2EC51C0", VA = "0x182EC61C0")]
		public CrossController()
		{
		}

		// Token: 0x04003008 RID: 12296
		[Token(Token = "0x4003008")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private EventStimuli _stimuliEvent;
	}
}
