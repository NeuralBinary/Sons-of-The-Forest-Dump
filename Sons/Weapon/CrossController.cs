using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008AB RID: 2219
	[Token(Token = "0x20008AB")]
	[AddComponentMenu("Sons/Items/CrossController")]
	public class CrossController : HeldControllerBase
	{
		// Token: 0x06003F3E RID: 16190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F3E")]
		[Address(RVA = "0x35E18D0", Offset = "0x35DFED0", VA = "0x1835E18D0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x000134D0 File Offset: 0x000116D0
		[Token(Token = "0x6003F3F")]
		[Address(RVA = "0x35E1B00", Offset = "0x35E0100", VA = "0x1835E1B00", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F40")]
		[Address(RVA = "0x35E1C20", Offset = "0x35E0220", VA = "0x1835E1C20", Slot = "10")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F41")]
		[Address(RVA = "0x35E1F40", Offset = "0x35E0540", VA = "0x1835E1F40")]
		private void CheckFireInput()
		{
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F42")]
		[Address(RVA = "0x35E2110", Offset = "0x35E0710", VA = "0x1835E2110")]
		private void OnItemActivated()
		{
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F43")]
		[Address(RVA = "0x35E22C0", Offset = "0x35E08C0", VA = "0x1835E22C0")]
		private void OnItemDeactivated()
		{
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F44")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CrossController()
		{
		}

		// Token: 0x040034CE RID: 13518
		[Token(Token = "0x40034CE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private EventStimuli _stimuliEvent;
	}
}
