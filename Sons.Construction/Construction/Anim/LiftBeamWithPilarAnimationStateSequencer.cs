using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20002CE")]
	public class LiftBeamWithPilarAnimationStateSequencer : AnimationStateSequencer
	{
		// Token: 0x060015FC RID: 5628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x2E022E0", Offset = "0x2E008E0", VA = "0x182E022E0")]
		public LiftBeamWithPilarAnimationStateSequencer(IPlayerBuildingModeAction buildAction, GameObject repositioningBeamLookAt, float autoMoveDistanceToPlacePos)
		{
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x2E025D0", Offset = "0x2E00BD0", VA = "0x182E025D0", Slot = "24")]
		protected override void SequenceStart()
		{
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x0000C38C File Offset: 0x0000A58C
		[Token(Token = "0x1700049D")]
		protected override bool CanPerformLiveLateUpdate
		{
			[Token(Token = "0x60015FE")]
			[Address(RVA = "0x2E02A80", Offset = "0x2E01080", VA = "0x182E02A80", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x2E02AA0", Offset = "0x2E010A0", VA = "0x182E02AA0", Slot = "36")]
		protected override void TargetStateBeginPerfectFinish()
		{
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x2E02B20", Offset = "0x2E01120", VA = "0x182E02B20")]
		private void MakeRightHeldRendererFinishPerfect(TargetInfo targetInfo, float ikDelay, float ikSmoothDuration)
		{
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x2E02D20", Offset = "0x2E01320", VA = "0x182E02D20", Slot = "31")]
		protected override void TargetStateLiveLateUpdate()
		{
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x2E031F0", Offset = "0x2E017F0", VA = "0x182E031F0", Slot = "28")]
		protected override void TargetStateStopLiveUpdate()
		{
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x2E03210", Offset = "0x2E01810", VA = "0x182E03210", Slot = "32")]
		protected override void TargetStateReachTriggerTime()
		{
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001604")]
		[Address(RVA = "0x2E03320", Offset = "0x2E01920", VA = "0x182E03320", Slot = "37")]
		protected override void SequenceCanceled()
		{
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x2E03470", Offset = "0x2E01A70", VA = "0x182E03470", Slot = "38")]
		protected override void FinalCleanup()
		{
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x2E03750", Offset = "0x2E01D50", VA = "0x182E03750")]
		[CompilerGenerated]
		private void <MakeRightHeldRendererFinishPerfect>g__QuarterLogPerfectFinish|7_0(ref LiftBeamWithPilarAnimationStateSequencer.<>c__DisplayClass7_0 A_1)
		{
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x2E03B90", Offset = "0x2E02190", VA = "0x182E03B90")]
		[CompilerGenerated]
		private void <MakeRightHeldRendererFinishPerfect>g__FullLogPerfectFinis|7_1(ref LiftBeamWithPilarAnimationStateSequencer.<>c__DisplayClass7_0 A_1)
		{
		}

		// Token: 0x04000AD5 RID: 2773
		[Token(Token = "0x4000AD5")]
		[FieldOffset(Offset = "0x88")]
		private GameObject _repositioningBeamLookAt;

		// Token: 0x04000AD6 RID: 2774
		[Token(Token = "0x4000AD6")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 _nextPilarPos;
	}
}
