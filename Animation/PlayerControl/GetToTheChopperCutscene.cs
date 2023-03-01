using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using Sons.Cutscenes;
using Sons.Gameplay;
using Sons.Loading;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008D9 RID: 2265
	[Token(Token = "0x20008D9")]
	[AddComponentMenu("Sons/Animation/GetToTheChopperCutscene")]
	public class GetToTheChopperCutscene : EndGameCutscene
	{
		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06003D8D RID: 15757 RVA: 0x00012090 File Offset: 0x00010290
		[Token(Token = "0x170007C1")]
		public override bool HandlePlayerAnimationMoveEvents
		{
			[Token(Token = "0x6003D8D")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06003D8E RID: 15758 RVA: 0x000120A8 File Offset: 0x000102A8
		[Token(Token = "0x170007C2")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x6003D8E")]
			[Address(RVA = "0x2F1E710", Offset = "0x2F1D710", VA = "0x182F1E710", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x000120C0 File Offset: 0x000102C0
		[Token(Token = "0x170007C3")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x6003D8F")]
			[Address(RVA = "0x2F1E770", Offset = "0x2F1D770", VA = "0x182F1E770", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D90")]
		[Address(RVA = "0x2F1E5B0", Offset = "0x2F1D5B0", VA = "0x182F1E5B0", Slot = "24")]
		internal override void UpdateHook()
		{
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x000120D8 File Offset: 0x000102D8
		[Token(Token = "0x6003D91")]
		[Address(RVA = "0x2F1DE80", Offset = "0x2F1CE80", VA = "0x182F1DE80", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D92")]
		[Address(RVA = "0x2F1DA30", Offset = "0x2F1CA30", VA = "0x182F1DA30", Slot = "29")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D93")]
		[Address(RVA = "0x2F1E160", Offset = "0x2F1D160", VA = "0x182F1E160")]
		private void ShowContinuePrompt()
		{
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D94")]
		[Address(RVA = "0x2F1DCA0", Offset = "0x2F1CCA0", VA = "0x182F1DCA0")]
		private void EnableContinueColliders(bool value)
		{
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D95")]
		[Address(RVA = "0x2F1E020", Offset = "0x2F1D020", VA = "0x182F1E020")]
		public void SelectLeaveIsland()
		{
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D96")]
		[Address(RVA = "0x2F1DEE0", Offset = "0x2F1CEE0", VA = "0x182F1DEE0")]
		public void SelectContinue()
		{
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D97")]
		[Address(RVA = "0x2F1DED0", Offset = "0x2F1CED0", VA = "0x182F1DED0")]
		private void SelectContinue(PickUp pickUp)
		{
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D98")]
		[Address(RVA = "0x2F1DAF0", Offset = "0x2F1CAF0", VA = "0x182F1DAF0")]
		private void DisableTriggers()
		{
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D99")]
		[Address(RVA = "0x2F1DE00", Offset = "0x2F1CE00", VA = "0x182F1DE00")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9A")]
		[Address(RVA = "0x2F1E660", Offset = "0x2F1D660", VA = "0x182F1E660")]
		public GetToTheChopperCutscene()
		{
		}

		// Token: 0x04004157 RID: 16727
		[Token(Token = "0x4004157")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		protected LayerMask _triggerLayerMask;

		// Token: 0x04004158 RID: 16728
		[Token(Token = "0x4004158")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject _blackScreenCutGroup;

		// Token: 0x04004159 RID: 16729
		[Token(Token = "0x4004159")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private LoadScene _loadScene;

		// Token: 0x0400415A RID: 16730
		[Token(Token = "0x400415A")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[FormerlySerializedAs("_nextCutscene")]
		private ChopperExitCutscene _chopperExitCutscene;

		// Token: 0x0400415B RID: 16731
		[Token(Token = "0x400415B")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private ChopperGroupLeaveIsland _chopperGroupLeaveIslandCutscene;

		// Token: 0x0400415C RID: 16732
		[Token(Token = "0x400415C")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private GenericInteraction _escapeTrigger;

		// Token: 0x0400415D RID: 16733
		[Token(Token = "0x400415D")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private DroppedInventoryItemsPickup _droppedInventoryItemsPickup;

		// Token: 0x0400415E RID: 16734
		[Token(Token = "0x400415E")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private GameObject _droppedInventoryRoot;

		// Token: 0x0400415F RID: 16735
		[Token(Token = "0x400415F")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private List<Collider> _continueTriggerColliders;

		// Token: 0x04004160 RID: 16736
		[Token(Token = "0x4004160")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private LookAtIK _timmyLookAt;

		// Token: 0x04004161 RID: 16737
		[Token(Token = "0x4004161")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private LookAtIK _timmysDadLookAt;

		// Token: 0x04004162 RID: 16738
		[Token(Token = "0x4004162")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private float _blackScreenHoldDelay;

		// Token: 0x04004163 RID: 16739
		[Token(Token = "0x4004163")]
		[FieldOffset(Offset = "0x1C4")]
		private float _startTime;

		// Token: 0x04004164 RID: 16740
		[Token(Token = "0x4004164")]
		[FieldOffset(Offset = "0x1C8")]
		private bool _disabledInitialBlackScreen;

		// Token: 0x04004165 RID: 16741
		[Token(Token = "0x4004165")]
		[FieldOffset(Offset = "0x1C9")]
		private bool _hasDisabledLookAts;
	}
}
