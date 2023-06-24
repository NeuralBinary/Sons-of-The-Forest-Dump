using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008C5 RID: 2245
	[Token(Token = "0x20008C5")]
	[AddComponentMenu("Sons/Items/MaskAnimatorController")]
	public class MaskAnimatorController : HeldControllerBase
	{
		// Token: 0x06004005 RID: 16389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004005")]
		[Address(RVA = "0x35F1D10", Offset = "0x35F0310", VA = "0x1835F1D10", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004006")]
		[Address(RVA = "0x35F1FF0", Offset = "0x35F05F0", VA = "0x1835F1FF0")]
		private void Update()
		{
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x00013908 File Offset: 0x00011B08
		[Token(Token = "0x6004007")]
		[Address(RVA = "0x35F2110", Offset = "0x35F0710", VA = "0x1835F2110", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004008")]
		[Address(RVA = "0x35F2180", Offset = "0x35F0780", VA = "0x1835F2180")]
		private void OnItemActivated()
		{
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004009")]
		[Address(RVA = "0x35F2300", Offset = "0x35F0900", VA = "0x1835F2300")]
		private void OnItemDeactivated()
		{
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600400A")]
		[Address(RVA = "0x35F2480", Offset = "0x35F0A80", VA = "0x1835F2480")]
		private void OnDisable()
		{
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600400B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MaskAnimatorController()
		{
		}

		// Token: 0x04003554 RID: 13652
		[Token(Token = "0x4003554")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private EventStimuli _stimuliEvent;
	}
}
