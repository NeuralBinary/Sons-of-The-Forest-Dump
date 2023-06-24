using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002C9 RID: 713
	[Token(Token = "0x20002C9")]
	public abstract class AnimationStateSequencer : IAnimationSequencer
	{
		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x0000C23C File Offset: 0x0000A43C
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000490")]
		public bool WasTriggered
		{
			[Token(Token = "0x60015B8")]
			[Address(RVA = "0x2586760", Offset = "0x2584D60", VA = "0x182586760", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60015B9")]
			[Address(RVA = "0x2586770", Offset = "0x2584D70", VA = "0x182586770")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x0000C254 File Offset: 0x0000A454
		[Token(Token = "0x17000491")]
		public bool AnimEventsOnly
		{
			[Token(Token = "0x60015BA")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000492")]
		public ILayerBehaviourActivator[] LayerActivators
		{
			[Token(Token = "0x60015BB")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000493")]
		public ILayerBehaviourActivator[] LayerDisablers
		{
			[Token(Token = "0x60015BC")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x0000C26C File Offset: 0x0000A46C
		[Token(Token = "0x17000494")]
		public bool IsLiveUpdating
		{
			[Token(Token = "0x60015BD")]
			[Address(RVA = "0x2586740", Offset = "0x2584D40", VA = "0x182586740", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x0000C284 File Offset: 0x0000A484
		[Token(Token = "0x17000495")]
		protected virtual bool ShouldAutoMove
		{
			[Token(Token = "0x60015BE")]
			[Address(RVA = "0x2DFF3C0", Offset = "0x2DFD9C0", VA = "0x182DFF3C0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x0000C29C File Offset: 0x0000A49C
		[Token(Token = "0x17000496")]
		protected virtual Vector3 MoveToPos
		{
			[Token(Token = "0x60015BF")]
			[Address(RVA = "0x2DFF3E0", Offset = "0x2DFD9E0", VA = "0x182DFF3E0", Slot = "22")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x0000C2B4 File Offset: 0x0000A4B4
		[Token(Token = "0x17000497")]
		protected virtual Vector3 MoveLookAtPos
		{
			[Token(Token = "0x60015C0")]
			[Address(RVA = "0x2DFF3E0", Offset = "0x2DFD9E0", VA = "0x182DFF3E0", Slot = "23")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015C1")]
		[Address(RVA = "0x2DFF410", Offset = "0x2DFDA10", VA = "0x182DFF410")]
		protected AnimationStateSequencer(IPlayerBuildingModeAction buildAction)
		{
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60015C2")]
		[Address(RVA = "0x2DFF690", Offset = "0x2DFDC90", VA = "0x182DFF690", Slot = "4")]
		public IEnumerator StateSequencingRoutine()
		{
			return null;
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015C3")]
		[Address(RVA = "0x2DFF720", Offset = "0x2DFDD20", VA = "0x182DFF720")]
		protected void SetLayerActivators(bool onOff)
		{
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "24")]
		protected virtual void SequenceStart()
		{
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0000C2CC File Offset: 0x0000A4CC
		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "25")]
		protected virtual bool IsReady()
		{
			return default(bool);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		protected virtual void SequenceReady()
		{
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		protected virtual void TargetStateBeginLiveUpdate()
		{
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		protected virtual void TargetStateStopLiveUpdate()
		{
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "29")]
		protected virtual void TargetStateLiveUpdate()
		{
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
		[Token(Token = "0x17000498")]
		protected virtual bool CanPerformLiveLateUpdate
		{
			[Token(Token = "0x60015CA")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "31")]
		protected virtual void TargetStateLiveLateUpdate()
		{
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "32")]
		protected virtual void TargetStateReachTriggerTime()
		{
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "33")]
		protected virtual void TargetStateReachBouncePartialExitTime()
		{
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		[Token(Token = "0x17000499")]
		protected virtual bool CanPerformLivePostIkUpdate
		{
			[Token(Token = "0x60015CE")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "35")]
		protected virtual void TargetStateLivePostIkUpdate()
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x2DFF770", Offset = "0x2DFDD70", VA = "0x182DFF770", Slot = "36")]
		protected virtual void TargetStateBeginPerfectFinish()
		{
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "37")]
		protected virtual void SequenceCanceled()
		{
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "38")]
		protected virtual void FinalCleanup()
		{
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D3")]
		[Address(RVA = "0x2DFF7C0", Offset = "0x2DFDDC0", VA = "0x182DFF7C0", Slot = "5")]
		public void BeginLiveUpdate()
		{
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x2DFF820", Offset = "0x2DFDE20", VA = "0x182DFF820", Slot = "17")]
		public void StopLiveUpdate()
		{
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x2DFF880", Offset = "0x2DFDE80", VA = "0x182DFF880", Slot = "18")]
		public void BeginPerfectFinishIk()
		{
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620", Slot = "19")]
		public void SetTargetInfo(TargetInfo targetInfo)
		{
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x2DFF8D0", Offset = "0x2DFDED0", VA = "0x182DFF8D0", Slot = "6")]
		public void LiveUpdate()
		{
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x2DFF940", Offset = "0x2DFDF40", VA = "0x182DFF940", Slot = "7")]
		public void LateUpdate()
		{
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x2DFF9C0", Offset = "0x2DFDFC0", VA = "0x182DFF9C0", Slot = "9")]
		public void ReachedTriggerTime()
		{
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x2DFFA40", Offset = "0x2DFE040", VA = "0x182DFFA40", Slot = "10")]
		public void ReachedBouncePartialExitTime()
		{
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x2DFFAB0", Offset = "0x2DFE0B0", VA = "0x182DFFAB0")]
		private void SetControlParameter()
		{
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x2DFFB20", Offset = "0x2DFE120", VA = "0x182DFFB20")]
		private void ClearControlParameter()
		{
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x2DFFB90", Offset = "0x2DFE190", VA = "0x182DFFB90")]
		private void CheckAutoMove()
		{
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x2DFFE70", Offset = "0x2DFE470", VA = "0x182DFFE70")]
		private void CheckAutoRotation()
		{
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x2E00040", Offset = "0x2DFE640", VA = "0x182E00040", Slot = "8")]
		public void PostIkUpdate()
		{
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x2E000B0", Offset = "0x2DFE6B0", VA = "0x182E000B0", Slot = "20")]
		public void Cancel(bool forceCancel)
		{
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x2E00110", Offset = "0x2DFE710", VA = "0x182E00110", Slot = "11")]
		public void Terminate()
		{
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x0000C314 File Offset: 0x0000A514
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x2E00210", Offset = "0x2DFE810", VA = "0x182E00210")]
		protected bool TryShutdown()
		{
			return default(bool);
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x2E00230", Offset = "0x2DFE830", VA = "0x182E00230")]
		protected void CheckIfCanAutoMove(Vector3 highestMovePos, float maxHeightRange, out float moveHeight)
		{
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x0000C32C File Offset: 0x0000A52C
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x2E00630", Offset = "0x2DFEC30", VA = "0x182E00630")]
		[CompilerGenerated]
		private bool <StateSequencingRoutine>g__TransitioningToIdle|45_0()
		{
			return default(bool);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0000C344 File Offset: 0x0000A544
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x2E00740", Offset = "0x2DFED40", VA = "0x182E00740")]
		[CompilerGenerated]
		private bool <StateSequencingRoutine>g__ReachedTransitionThreshold|45_1(float normTimeThreshold)
		{
			return default(bool);
		}

		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4000AAE")]
		[FieldOffset(Offset = "0x10")]
		protected TargetInfo _targetInfo;

		// Token: 0x04000AAF RID: 2735
		[Token(Token = "0x4000AAF")]
		[FieldOffset(Offset = "0x18")]
		protected bool _animEventsOnly;

		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4000AB0")]
		[FieldOffset(Offset = "0x19")]
		protected bool _cameraFollowAnim;

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		[FieldOffset(Offset = "0x1A")]
		protected bool _skipFrameBeforeStart;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x1B")]
		protected bool _unEquipLeftHand;

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x1C")]
		protected bool _skipReEquipLeftHand;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x20")]
		protected int _layer;

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x24")]
		private readonly int _triggerStateParameter;

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x28")]
		protected int _targetState;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x2C")]
		protected float _failSafeTime;

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4000AB8")]
		[FieldOffset(Offset = "0x30")]
		protected float _autoMoveDuration;

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4000AB9")]
		[FieldOffset(Offset = "0x34")]
		protected float _autoMoveDistanceToPlacePos;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4000ABA")]
		[FieldOffset(Offset = "0x38")]
		protected bool _canAutoMove;

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		[FieldOffset(Offset = "0x40")]
		protected LayerBehaviourActivator[] _layerActivators;

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4000ABC")]
		[FieldOffset(Offset = "0x48")]
		protected LayerBehaviourActivator[] _layerDisablers;

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0x50")]
		protected float _targetStateTriggerNormalizedTime;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		[FieldOffset(Offset = "0x54")]
		protected float _targetStateLiveUpdateNormalizedTime;

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0x58")]
		protected float _targetStateCompletionNormalizedTime;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4000AC0")]
		[FieldOffset(Offset = "0x5C")]
		protected float _postStateCompletionNormalizedTime;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0x60")]
		protected readonly IPlayerBuildingModeAction _buildAction;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x68")]
		protected readonly Animator _animator;

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4000AC3")]
		[FieldOffset(Offset = "0x70")]
		protected readonly GameObject _rightHandItemsRoot;

		// Token: 0x04000AC4 RID: 2756
		[Token(Token = "0x4000AC4")]
		[FieldOffset(Offset = "0x78")]
		protected readonly IConstructionAnimationActor _actor;

		// Token: 0x04000AC5 RID: 2757
		[Token(Token = "0x4000AC5")]
		[FieldOffset(Offset = "0x80")]
		protected bool _isRunning;

		// Token: 0x04000AC6 RID: 2758
		[Token(Token = "0x4000AC6")]
		[FieldOffset(Offset = "0x81")]
		protected bool _isLiveUpdating;

		// Token: 0x04000AC7 RID: 2759
		[Token(Token = "0x4000AC7")]
		[FieldOffset(Offset = "0x82")]
		protected bool _rotateTowardsTarget;
	}
}
