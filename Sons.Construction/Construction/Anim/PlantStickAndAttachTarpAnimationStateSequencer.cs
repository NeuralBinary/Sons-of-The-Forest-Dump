using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002D6 RID: 726
	[Token(Token = "0x20002D6")]
	public class PlantStickAndAttachTarpAnimationStateSequencer : AnimationStateSequencer
	{
		// Token: 0x0600163A RID: 5690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x2E06F70", Offset = "0x2E05570", VA = "0x182E06F70")]
		public PlantStickAndAttachTarpAnimationStateSequencer(IPlayerBuildingModeAction buildAction, IkFakeBone attachTarpLookAt, GameObject stickClothCollider, float autoMoveDistanceToPlacePos)
		{
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x2E072C0", Offset = "0x2E058C0", VA = "0x182E072C0", Slot = "24")]
		protected override void SequenceStart()
		{
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		protected override void SequenceReady()
		{
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0000C44C File Offset: 0x0000A64C
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x2E07340", Offset = "0x2E05940", VA = "0x182E07340", Slot = "25")]
		protected override bool IsReady()
		{
			return default(bool);
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x2E075B0", Offset = "0x2E05BB0", VA = "0x182E075B0", Slot = "27")]
		protected override void TargetStateBeginLiveUpdate()
		{
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x2E081C0", Offset = "0x2E067C0", VA = "0x182E081C0", Slot = "29")]
		protected override void TargetStateLiveUpdate()
		{
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x0000C464 File Offset: 0x0000A664
		[Token(Token = "0x170004A8")]
		protected override bool CanPerformLivePostIkUpdate
		{
			[Token(Token = "0x6001640")]
			[Address(RVA = "0x2E02A80", Offset = "0x2E01080", VA = "0x182E02A80", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x2E08220", Offset = "0x2E06820", VA = "0x182E08220", Slot = "35")]
		protected override void TargetStateLivePostIkUpdate()
		{
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001642")]
		[Address(RVA = "0x2E084F0", Offset = "0x2E06AF0", VA = "0x182E084F0", Slot = "32")]
		protected override void TargetStateReachTriggerTime()
		{
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001643")]
		[Address(RVA = "0x2E08A40", Offset = "0x2E07040", VA = "0x182E08A40", Slot = "37")]
		protected override void SequenceCanceled()
		{
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x2E08DD0", Offset = "0x2E073D0", VA = "0x182E08DD0", Slot = "38")]
		protected override void FinalCleanup()
		{
		}

		// Token: 0x04000AEB RID: 2795
		[Token(Token = "0x4000AEB")]
		[FieldOffset(Offset = "0x88")]
		private readonly IkFakeBone _attachTarpLookAt;

		// Token: 0x04000AEC RID: 2796
		[Token(Token = "0x4000AEC")]
		[FieldOffset(Offset = "0x90")]
		private readonly GameObject _stickClothCollider;

		// Token: 0x04000AED RID: 2797
		[Token(Token = "0x4000AED")]
		[FieldOffset(Offset = "0x98")]
		private GameObject _stickClothColliderInstance;

		// Token: 0x04000AEE RID: 2798
		[Token(Token = "0x4000AEE")]
		[FieldOffset(Offset = "0xA0")]
		private bool _waitingForStickEquip;
	}
}
