using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002CC RID: 716
	[Token(Token = "0x20002CC")]
	public class CutElementAnimationStateSequencer : AnimationStateSequencer
	{
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x0000C374 File Offset: 0x0000A574
		[Token(Token = "0x1700049C")]
		protected override Vector3 MoveToPos
		{
			[Token(Token = "0x60015F1")]
			[Address(RVA = "0x2E018A0", Offset = "0x2DFFEA0", VA = "0x182E018A0", Slot = "22")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x2E018C0", Offset = "0x2DFFEC0", VA = "0x182E018C0")]
		public CutElementAnimationStateSequencer(IPlayerBuildingModeAction buildAction, float autoMoveDistanceToPlacePos, bool useAimIK)
		{
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F3")]
		[Address(RVA = "0x2E01A80", Offset = "0x2E00080", VA = "0x182E01A80", Slot = "24")]
		protected override void SequenceStart()
		{
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x2E01E80", Offset = "0x2E00480", VA = "0x182E01E80", Slot = "27")]
		protected override void TargetStateBeginLiveUpdate()
		{
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x2E01ED0", Offset = "0x2E004D0", VA = "0x182E01ED0", Slot = "32")]
		protected override void TargetStateReachTriggerTime()
		{
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x2E01F50", Offset = "0x2E00550", VA = "0x182E01F50", Slot = "38")]
		protected override void FinalCleanup()
		{
		}

		// Token: 0x04000AD2 RID: 2770
		[Token(Token = "0x4000AD2")]
		[FieldOffset(Offset = "0x88")]
		private bool _useAimIK;

		// Token: 0x04000AD3 RID: 2771
		[Token(Token = "0x4000AD3")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 _moveToPos;
	}
}
