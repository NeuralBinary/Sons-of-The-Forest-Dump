using System;
using Il2CppDummyDll;

namespace Construction.Anim
{
	// Token: 0x020002D3 RID: 723
	[Token(Token = "0x20002D3")]
	public class PlaceFloorAnimationStateSequencer : AnimationStateSequencer
	{
		// Token: 0x0600162E RID: 5678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x2E06330", Offset = "0x2E04930", VA = "0x182E06330")]
		public PlaceFloorAnimationStateSequencer(IPlayerBuildingModeAction buildAction, RightHandAccessories rightHandAccessory)
		{
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x2E066A0", Offset = "0x2E04CA0", VA = "0x182E066A0", Slot = "24")]
		protected override void SequenceStart()
		{
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x2E06770", Offset = "0x2E04D70", VA = "0x182E06770", Slot = "26")]
		protected override void SequenceReady()
		{
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x2E06820", Offset = "0x2E04E20", VA = "0x182E06820", Slot = "27")]
		protected override void TargetStateBeginLiveUpdate()
		{
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x2E06920", Offset = "0x2E04F20", VA = "0x182E06920", Slot = "32")]
		protected override void TargetStateReachTriggerTime()
		{
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001633")]
		[Address(RVA = "0x2E069D0", Offset = "0x2E04FD0", VA = "0x182E069D0", Slot = "38")]
		protected override void FinalCleanup()
		{
		}

		// Token: 0x04000AEA RID: 2794
		[Token(Token = "0x4000AEA")]
		[FieldOffset(Offset = "0x88")]
		private RightHandAccessories _rightHandAccessory;
	}
}
