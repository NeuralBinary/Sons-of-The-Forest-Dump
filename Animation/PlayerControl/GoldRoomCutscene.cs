using System;
using System.Collections.Generic;
using Endnight.Animation;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Gameplay;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008DA RID: 2266
	[Token(Token = "0x20008DA")]
	[AddComponentMenu("Sons/Animation/GoldRoomCutscene")]
	public class GoldRoomCutscene : EndGameTriggeredCutscene
	{
		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06003D9B RID: 15771 RVA: 0x000120F0 File Offset: 0x000102F0
		[Token(Token = "0x170007C4")]
		public int RoomAnimationStateHash
		{
			[Token(Token = "0x6003D9B")]
			[Address(RVA = "0x2F1F310", Offset = "0x2F1E310", VA = "0x182F1F310")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06003D9C RID: 15772 RVA: 0x00012108 File Offset: 0x00010308
		[Token(Token = "0x170007C5")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x6003D9C")]
			[Address(RVA = "0x2F1F370", Offset = "0x2F1E370", VA = "0x182F1F370", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06003D9D RID: 15773 RVA: 0x00012120 File Offset: 0x00010320
		[Token(Token = "0x170007C6")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x6003D9D")]
			[Address(RVA = "0x2F1F2B0", Offset = "0x2F1E2B0", VA = "0x182F1F2B0", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06003D9E RID: 15774 RVA: 0x00012138 File Offset: 0x00010338
		[Token(Token = "0x170007C7")]
		public int VirginiaMissingHash
		{
			[Token(Token = "0x6003D9E")]
			[Address(RVA = "0x2F1F3D0", Offset = "0x2F1E3D0", VA = "0x182F1F3D0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06003D9F RID: 15775 RVA: 0x00012150 File Offset: 0x00010350
		[Token(Token = "0x170007C8")]
		public override bool HandlePlayerAnimationMoveEvents
		{
			[Token(Token = "0x6003D9F")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA0")]
		[Address(RVA = "0x2F1EE70", Offset = "0x2F1DE70", VA = "0x182F1EE70", Slot = "24")]
		internal override void UpdateHook()
		{
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA1")]
		[Address(RVA = "0x2F1EDE0", Offset = "0x2F1DDE0", VA = "0x182F1EDE0", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA2")]
		[Address(RVA = "0x2F1E890", Offset = "0x2F1D890", VA = "0x182F1E890", Slot = "31")]
		internal override void InteractionTriggered()
		{
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x00012168 File Offset: 0x00010368
		[Token(Token = "0x6003DA3")]
		[Address(RVA = "0x2F0D8B0", Offset = "0x2F0C8B0", VA = "0x182F0D8B0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x00012180 File Offset: 0x00010380
		[Token(Token = "0x6003DA4")]
		[Address(RVA = "0x2F1C430", Offset = "0x2F1B430", VA = "0x182F1C430", Slot = "27")]
		internal override bool IsCutsceneReady()
		{
			return default(bool);
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA5")]
		[Address(RVA = "0x2F1EA00", Offset = "0x2F1DA00", VA = "0x182F1EA00", Slot = "28")]
		internal override void OnCutsceneReady()
		{
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA6")]
		[Address(RVA = "0x2F1E7D0", Offset = "0x2F1D7D0", VA = "0x182F1E7D0", Slot = "29")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA7")]
		[Address(RVA = "0x2F1F290", Offset = "0x2F1E290", VA = "0x182F1F290")]
		public GoldRoomCutscene()
		{
		}

		// Token: 0x04004166 RID: 16742
		[Token(Token = "0x4004166")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Animator _roomAnimator;

		// Token: 0x04004167 RID: 16743
		[Token(Token = "0x4004167")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Cutscene _nextCutscene;

		// Token: 0x04004168 RID: 16744
		[Token(Token = "0x4004168")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private GameObject _blackScreenCutGroup;

		// Token: 0x04004169 RID: 16745
		[Token(Token = "0x4004169")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private GameObject _robbyRoot;

		// Token: 0x0400416A RID: 16746
		[Token(Token = "0x400416A")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private GameObject _virginiaRoot;

		// Token: 0x0400416B RID: 16747
		[Token(Token = "0x400416B")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private GenericInteraction _startCutsceneTrigger;

		// Token: 0x0400416C RID: 16748
		[Token(Token = "0x400416C")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private List<AnimationSync> _syncToPlayer;

		// Token: 0x0400416D RID: 16749
		[Token(Token = "0x400416D")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private TMP_Text _laptopCountdownTimer;

		// Token: 0x0400416E RID: 16750
		[Token(Token = "0x400416E")]
		[FieldOffset(Offset = "0x1B0")]
		[FormerlySerializedAs("_laptopCountdownTimes")]
		[SerializeField]
		private float _laptopCountdownStartTime;

		// Token: 0x0400416F RID: 16751
		[Token(Token = "0x400416F")]
		[FieldOffset(Offset = "0x1B4")]
		private float _startTime;
	}
}
