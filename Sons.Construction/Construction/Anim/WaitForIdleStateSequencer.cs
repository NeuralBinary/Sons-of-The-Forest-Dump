using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002D8 RID: 728
	[Token(Token = "0x20002D8")]
	public class WaitForIdleStateSequencer : IAnimationSequencer
	{
		// Token: 0x0600164A RID: 5706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x2E09A80", Offset = "0x2E08080", VA = "0x182E09A80")]
		public WaitForIdleStateSequencer(IPlayerBuildingModeAction buildAction)
		{
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x2E09C20", Offset = "0x2E08220", VA = "0x182E09C20", Slot = "4")]
		private IEnumerator StateSequencingRoutine()
		{
			return null;
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x2E09CB0", Offset = "0x2E082B0", VA = "0x182E09CB0", Slot = "5")]
		private void BeginLiveUpdate()
		{
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		private void LiveUpdate()
		{
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		private void PostIkUpdate()
		{
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x2E09CF0", Offset = "0x2E082F0", VA = "0x182E09CF0", Slot = "9")]
		private void ReachedTriggerTime()
		{
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x2E09D30", Offset = "0x2E08330", VA = "0x182E09D30", Slot = "10")]
		private void ReachedBouncePartialExitTime()
		{
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "20")]
		public void Cancel(bool forceCancel)
		{
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x2E09D70", Offset = "0x2E08370", VA = "0x182E09D70", Slot = "11")]
		public void Terminate()
		{
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x0000C47C File Offset: 0x0000A67C
		[Token(Token = "0x170004A9")]
		private bool WasTriggered
		{
			[Token(Token = "0x6001654")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x0000C494 File Offset: 0x0000A694
		[Token(Token = "0x170004AA")]
		private bool AnimEventsOnly
		{
			[Token(Token = "0x6001655")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170004AB")]
		private ILayerBehaviourActivator[] LayerActivators
		{
			[Token(Token = "0x6001656")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170004AC")]
		private ILayerBehaviourActivator[] LayerDisablers
		{
			[Token(Token = "0x6001657")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		[Token(Token = "0x170004AD")]
		public bool IsLiveUpdating
		{
			[Token(Token = "0x6001658")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001659")]
		[Address(RVA = "0x2E09E10", Offset = "0x2E08410", VA = "0x182E09E10", Slot = "17")]
		private void StopLiveUpdate()
		{
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600165A")]
		[Address(RVA = "0x2E09E50", Offset = "0x2E08450", VA = "0x182E09E50", Slot = "18")]
		public void BeginPerfectFinishIk()
		{
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620", Slot = "19")]
		private void SetTargetInfo(TargetInfo targetInfo)
		{
		}

		// Token: 0x04000AF0 RID: 2800
		[Token(Token = "0x4000AF0")]
		[FieldOffset(Offset = "0x10")]
		private TargetInfo _targetInfo;

		// Token: 0x04000AF1 RID: 2801
		[Token(Token = "0x4000AF1")]
		[FieldOffset(Offset = "0x18")]
		private bool _animEventsOnly;

		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		[FieldOffset(Offset = "0x19")]
		private bool _unEquipLeftHand;

		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		[FieldOffset(Offset = "0x20")]
		private readonly IPlayerBuildingModeAction _buildAction;

		// Token: 0x04000AF4 RID: 2804
		[Token(Token = "0x4000AF4")]
		[FieldOffset(Offset = "0x28")]
		private readonly GameObject _rightHandItemsRoot;

		// Token: 0x04000AF5 RID: 2805
		[Token(Token = "0x4000AF5")]
		[FieldOffset(Offset = "0x30")]
		private readonly IConstructionAnimationActor _actor;
	}
}
