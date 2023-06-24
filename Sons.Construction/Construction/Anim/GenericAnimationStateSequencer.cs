using System;
using Il2CppDummyDll;

namespace Construction.Anim
{
	// Token: 0x020002CD RID: 717
	[Token(Token = "0x20002CD")]
	public class GenericAnimationStateSequencer : AnimationStateSequencer
	{
		// Token: 0x060015F7 RID: 5623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F7")]
		[Address(RVA = "0x2E02040", Offset = "0x2E00640", VA = "0x182E02040")]
		public GenericAnimationStateSequencer(IPlayerBuildingModeAction buildAction, LeftHandAccessories leftHandAccessory, float distanceToPlacePosition, bool stashLeftHand)
		{
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F8")]
		[Address(RVA = "0x2E02090", Offset = "0x2E00690", VA = "0x182E02090", Slot = "26")]
		protected override void SequenceReady()
		{
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F9")]
		[Address(RVA = "0x2E020F0", Offset = "0x2E006F0", VA = "0x182E020F0", Slot = "27")]
		protected override void TargetStateBeginLiveUpdate()
		{
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x2E02140", Offset = "0x2E00740", VA = "0x182E02140", Slot = "32")]
		protected override void TargetStateReachTriggerTime()
		{
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x2E02230", Offset = "0x2E00830", VA = "0x182E02230", Slot = "38")]
		protected override void FinalCleanup()
		{
		}

		// Token: 0x04000AD4 RID: 2772
		[Token(Token = "0x4000AD4")]
		[FieldOffset(Offset = "0x88")]
		private LeftHandAccessories _leftHandAccessory;
	}
}
