using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002D0 RID: 720
	[Token(Token = "0x20002D0")]
	public class LiftBeamWithStrutAnimationStateSequencer : AnimationStateSequencer
	{
		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		[Token(Token = "0x1700049E")]
		protected override Vector3 MoveToPos
		{
			[Token(Token = "0x6001608")]
			[Address(RVA = "0x2A224C0", Offset = "0x2A20AC0", VA = "0x182A224C0", Slot = "22")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x0000C3BC File Offset: 0x0000A5BC
		[Token(Token = "0x1700049F")]
		protected override Vector3 MoveLookAtPos
		{
			[Token(Token = "0x6001609")]
			[Address(RVA = "0x2A22570", Offset = "0x2A20B70", VA = "0x182A22570", Slot = "23")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x2E040B0", Offset = "0x2E026B0", VA = "0x182E040B0")]
		public LiftBeamWithStrutAnimationStateSequencer(IPlayerBuildingModeAction buildAction, GameObject repositioningBeamLookAtRight, GameObject repositioningBeamLookAtLeft, float autoMoveDistanceToPlacePos)
		{
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x2E043D0", Offset = "0x2E029D0", VA = "0x182E043D0", Slot = "24")]
		protected override void SequenceStart()
		{
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		[Token(Token = "0x170004A0")]
		protected override bool CanPerformLiveLateUpdate
		{
			[Token(Token = "0x600160C")]
			[Address(RVA = "0x2E02A80", Offset = "0x2E01080", VA = "0x182E02A80", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600160D")]
		[Address(RVA = "0x2E04BA0", Offset = "0x2E031A0", VA = "0x182E04BA0", Slot = "36")]
		protected override void TargetStateBeginPerfectFinish()
		{
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600160E")]
		[Address(RVA = "0x2E04BD0", Offset = "0x2E031D0", VA = "0x182E04BD0")]
		private void MakeRightHeldRendererFinishPerfect(TargetInfo targetInfo, float ikDelay, float ikSmoothDuration)
		{
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600160F")]
		[Address(RVA = "0x2E052F0", Offset = "0x2E038F0", VA = "0x182E052F0", Slot = "27")]
		protected override void TargetStateBeginLiveUpdate()
		{
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x2E054B0", Offset = "0x2E03AB0", VA = "0x182E054B0", Slot = "31")]
		protected override void TargetStateLiveLateUpdate()
		{
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x2E031F0", Offset = "0x2E017F0", VA = "0x182E031F0", Slot = "28")]
		protected override void TargetStateStopLiveUpdate()
		{
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x2E05A00", Offset = "0x2E04000", VA = "0x182E05A00", Slot = "32")]
		protected override void TargetStateReachTriggerTime()
		{
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001613")]
		[Address(RVA = "0x2E05B20", Offset = "0x2E04120", VA = "0x182E05B20", Slot = "37")]
		protected override void SequenceCanceled()
		{
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001614")]
		[Address(RVA = "0x2E05C70", Offset = "0x2E04270", VA = "0x182E05C70", Slot = "38")]
		protected override void FinalCleanup()
		{
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001615")]
		[Address(RVA = "0x2E05DF0", Offset = "0x2E043F0", VA = "0x182E05DF0")]
		[CompilerGenerated]
		private void <SequenceStart>g__SetPillarHeight|12_0()
		{
		}

		// Token: 0x04000ADD RID: 2781
		[Token(Token = "0x4000ADD")]
		[FieldOffset(Offset = "0x88")]
		private GameObject _repositioningBeamLookAt;

		// Token: 0x04000ADE RID: 2782
		[Token(Token = "0x4000ADE")]
		[FieldOffset(Offset = "0x90")]
		private GameObject _repositioningBeamLookAtRight;

		// Token: 0x04000ADF RID: 2783
		[Token(Token = "0x4000ADF")]
		[FieldOffset(Offset = "0x98")]
		private GameObject _repositioningBeamLookAtLeft;

		// Token: 0x04000AE0 RID: 2784
		[Token(Token = "0x4000AE0")]
		[FieldOffset(Offset = "0xA0")]
		private Transform _animTr;

		// Token: 0x04000AE1 RID: 2785
		[Token(Token = "0x4000AE1")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 _moveToPos;

		// Token: 0x04000AE2 RID: 2786
		[Token(Token = "0x4000AE2")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 _moveLookAtPos;

		// Token: 0x04000AE3 RID: 2787
		[Token(Token = "0x4000AE3")]
		[FieldOffset(Offset = "0xC0")]
		private bool _isRightMost;
	}
}
