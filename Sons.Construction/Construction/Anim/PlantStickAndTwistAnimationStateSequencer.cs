using System;
using Il2CppDummyDll;

namespace Construction.Anim
{
	// Token: 0x020002D7 RID: 727
	[Token(Token = "0x20002D7")]
	public class PlantStickAndTwistAnimationStateSequencer : AnimationStateSequencer
	{
		// Token: 0x06001645 RID: 5701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x2E09570", Offset = "0x2E07B70", VA = "0x182E09570")]
		public PlantStickAndTwistAnimationStateSequencer(IPlayerBuildingModeAction buildAction, LeftHandAccessories leftHandAccessory, float autoMoveDistanceToPlacePos)
		{
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x2E097F0", Offset = "0x2E07DF0", VA = "0x182E097F0", Slot = "26")]
		protected override void SequenceReady()
		{
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x2E09850", Offset = "0x2E07E50", VA = "0x182E09850", Slot = "27")]
		protected override void TargetStateBeginLiveUpdate()
		{
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x2E098A0", Offset = "0x2E07EA0", VA = "0x182E098A0", Slot = "32")]
		protected override void TargetStateReachTriggerTime()
		{
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001649")]
		[Address(RVA = "0x2E09990", Offset = "0x2E07F90", VA = "0x182E09990", Slot = "38")]
		protected override void FinalCleanup()
		{
		}

		// Token: 0x04000AEF RID: 2799
		[Token(Token = "0x4000AEF")]
		[FieldOffset(Offset = "0x88")]
		private LeftHandAccessories _leftHandAccessory;
	}
}
