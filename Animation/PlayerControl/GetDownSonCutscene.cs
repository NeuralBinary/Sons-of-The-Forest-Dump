using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Gameplay;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008D7 RID: 2263
	[Token(Token = "0x20008D7")]
	[AddComponentMenu("Sons/Animation/GetDownSonCutscene")]
	public class GetDownSonCutscene : EndGameTriggeredCutscene
	{
		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06003D6F RID: 15727 RVA: 0x00011FA0 File Offset: 0x000101A0
		[Token(Token = "0x170007BA")]
		public override bool ShouldEquipPreviouslyHeldItems
		{
			[Token(Token = "0x6003D6F")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06003D70 RID: 15728 RVA: 0x00011FB8 File Offset: 0x000101B8
		[Token(Token = "0x170007BB")]
		public override bool HideRemotePlayers
		{
			[Token(Token = "0x6003D70")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06003D71 RID: 15729 RVA: 0x00011FD0 File Offset: 0x000101D0
		[Token(Token = "0x170007BC")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x6003D71")]
			[Address(RVA = "0x2F1CE60", Offset = "0x2F1BE60", VA = "0x182F1CE60", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06003D72 RID: 15730 RVA: 0x00011FE8 File Offset: 0x000101E8
		[Token(Token = "0x170007BD")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x6003D72")]
			[Address(RVA = "0x2F1CEC0", Offset = "0x2F1BEC0", VA = "0x182F1CEC0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D73")]
		[Address(RVA = "0x2F1C690", Offset = "0x2F1B690", VA = "0x182F1C690", Slot = "5")]
		internal override void OnValidate()
		{
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D74")]
		[Address(RVA = "0x2F1C5B0", Offset = "0x2F1B5B0", VA = "0x182F1C5B0", Slot = "23")]
		internal override void OnNormalizedTimeChanged(float value)
		{
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D75")]
		[Address(RVA = "0x2F1C7D0", Offset = "0x2F1B7D0", VA = "0x182F1C7D0", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D76")]
		[Address(RVA = "0x2F1C920", Offset = "0x2F1B920", VA = "0x182F1C920")]
		private void SetupEvents()
		{
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D77")]
		[Address(RVA = "0x2F1C340", Offset = "0x2F1B340", VA = "0x182F1C340", Slot = "31")]
		internal override void InteractionTriggered()
		{
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x00012000 File Offset: 0x00010200
		[Token(Token = "0x6003D78")]
		[Address(RVA = "0x2F1C740", Offset = "0x2F1B740", VA = "0x182F1C740", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x00012018 File Offset: 0x00010218
		[Token(Token = "0x6003D79")]
		[Address(RVA = "0x2F1C430", Offset = "0x2F1B430", VA = "0x182F1C430", Slot = "27")]
		internal override bool IsCutsceneReady()
		{
			return default(bool);
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7A")]
		[Address(RVA = "0x2F1C440", Offset = "0x2F1B440", VA = "0x182F1C440", Slot = "28")]
		internal override void OnCutsceneReady()
		{
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7B")]
		[Address(RVA = "0x2F1BEE0", Offset = "0x2F1AEE0", VA = "0x182F1BEE0", Slot = "29")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7C")]
		[Address(RVA = "0x2F1C260", Offset = "0x2F1B260", VA = "0x182F1C260")]
		public static void InitializeAxeProp(out GameObject axeGameObject, out ItemInstance axeItemInstance)
		{
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7D")]
		[Address(RVA = "0x2F1CDA0", Offset = "0x2F1BDA0", VA = "0x182F1CDA0")]
		private void ShowTacticalAxe()
		{
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7E")]
		[Address(RVA = "0x2F1C1A0", Offset = "0x2F1B1A0", VA = "0x182F1C1A0")]
		private void HideTacticalAxe()
		{
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7F")]
		[Address(RVA = "0x2F1CB90", Offset = "0x2F1BB90", VA = "0x182F1CB90")]
		public static void ShowTacticalAxe(ref GameObject axeGameObject, out ItemInstance axeItemInstance, Quaternion transformLocalRotation)
		{
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D80")]
		[Address(RVA = "0x2F1C1B0", Offset = "0x2F1B1B0", VA = "0x182F1C1B0")]
		public static void HideTacticalAxe(ref GameObject axeGameObject)
		{
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D81")]
		[Address(RVA = "0x2F1CDD0", Offset = "0x2F1BDD0", VA = "0x182F1CDD0")]
		public GetDownSonCutscene()
		{
		}

		// Token: 0x04004146 RID: 16710
		[Token(Token = "0x4004146")]
		[FieldOffset(Offset = "0x170")]
		[FormerlySerializedAs("_cutsceneAnimators")]
		[SerializeField]
		private List<Animator> _animators;

		// Token: 0x04004147 RID: 16711
		[Token(Token = "0x4004147")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private GenericInteraction _startCutsceneTrigger;

		// Token: 0x04004148 RID: 16712
		[Token(Token = "0x4004148")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Cutscene _nextCutscene;

		// Token: 0x04004149 RID: 16713
		[Token(Token = "0x4004149")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private GameObject _blackScreenCutGroup;

		// Token: 0x0400414A RID: 16714
		[Token(Token = "0x400414A")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Quaternion _tacticalAxeRotation;

		// Token: 0x0400414B RID: 16715
		[Token(Token = "0x400414B")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private float _blackCutNormalizedTime;

		// Token: 0x0400414C RID: 16716
		[Token(Token = "0x400414C")]
		[FieldOffset(Offset = "0x1A8")]
		private ItemInstance _axeItemInstance;

		// Token: 0x0400414D RID: 16717
		[Token(Token = "0x400414D")]
		[FieldOffset(Offset = "0x1B0")]
		private GameObject _axeGameObject;

		// Token: 0x0400414E RID: 16718
		[Token(Token = "0x400414E")]
		[FieldOffset(Offset = "0x1B8")]
		private AnimationEventReceiver _animationEventReceiver;
	}
}
