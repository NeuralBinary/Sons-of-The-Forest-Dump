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
	// Token: 0x02000951 RID: 2385
	[Token(Token = "0x2000951")]
	[AddComponentMenu("Sons/Animation/GoldRoomCutscene")]
	public class GoldRoomCutscene : EndGameTriggeredCutscene
	{
		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06004509 RID: 17673 RVA: 0x000150C0 File Offset: 0x000132C0
		[Token(Token = "0x170008F5")]
		public int RoomAnimationStateHash
		{
			[Token(Token = "0x6004509")]
			[Address(RVA = "0x365D410", Offset = "0x365BA10", VA = "0x18365D410")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x0600450A RID: 17674 RVA: 0x000150D8 File Offset: 0x000132D8
		[Token(Token = "0x170008F6")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x600450A")]
			[Address(RVA = "0x365D470", Offset = "0x365BA70", VA = "0x18365D470", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x0600450B RID: 17675 RVA: 0x000150F0 File Offset: 0x000132F0
		[Token(Token = "0x170008F7")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x600450B")]
			[Address(RVA = "0x365D4D0", Offset = "0x365BAD0", VA = "0x18365D4D0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x0600450C RID: 17676 RVA: 0x00015108 File Offset: 0x00013308
		[Token(Token = "0x170008F8")]
		public int VirginiaMissingHash
		{
			[Token(Token = "0x600450C")]
			[Address(RVA = "0x365D530", Offset = "0x365BB30", VA = "0x18365D530")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x0600450D RID: 17677 RVA: 0x00015120 File Offset: 0x00013320
		[Token(Token = "0x170008F9")]
		public override bool HandlePlayerAnimationMoveEvents
		{
			[Token(Token = "0x600450D")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600450E")]
		[Address(RVA = "0x365D590", Offset = "0x365BB90", VA = "0x18365D590", Slot = "27")]
		internal override void UpdateHook()
		{
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600450F")]
		[Address(RVA = "0x365D910", Offset = "0x365BF10", VA = "0x18365D910", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004510")]
		[Address(RVA = "0x365D9A0", Offset = "0x365BFA0", VA = "0x18365D9A0", Slot = "34")]
		internal override void InteractionTriggered()
		{
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x00015138 File Offset: 0x00013338
		[Token(Token = "0x6004511")]
		[Address(RVA = "0x365DC20", Offset = "0x365C220", VA = "0x18365DC20", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x00015150 File Offset: 0x00013350
		[Token(Token = "0x6004512")]
		[Address(RVA = "0x3659BB0", Offset = "0x36581B0", VA = "0x183659BB0", Slot = "30")]
		internal override bool IsCutsceneReady()
		{
			return default(bool);
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004513")]
		[Address(RVA = "0x365DC50", Offset = "0x365C250", VA = "0x18365DC50", Slot = "31")]
		internal override void OnCutsceneReady()
		{
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004514")]
		[Address(RVA = "0x365E220", Offset = "0x365C820", VA = "0x18365E220", Slot = "32")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004515")]
		[Address(RVA = "0x365E2B0", Offset = "0x365C8B0", VA = "0x18365E2B0", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004516")]
		[Address(RVA = "0x365E2E0", Offset = "0x365C8E0", VA = "0x18365E2E0")]
		public GoldRoomCutscene()
		{
		}

		// Token: 0x040047B5 RID: 18357
		[Token(Token = "0x40047B5")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Animator _roomAnimator;

		// Token: 0x040047B6 RID: 18358
		[Token(Token = "0x40047B6")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Cutscene _nextCutscene;

		// Token: 0x040047B7 RID: 18359
		[Token(Token = "0x40047B7")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private GameObject _blackScreenCutGroup;

		// Token: 0x040047B8 RID: 18360
		[Token(Token = "0x40047B8")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private GameObject _robbyRoot;

		// Token: 0x040047B9 RID: 18361
		[Token(Token = "0x40047B9")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private GameObject _virginiaRoot;

		// Token: 0x040047BA RID: 18362
		[Token(Token = "0x40047BA")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private GenericInteraction _startCutsceneTrigger;

		// Token: 0x040047BB RID: 18363
		[Token(Token = "0x40047BB")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private List<AnimationSync> _syncToPlayer;

		// Token: 0x040047BC RID: 18364
		[Token(Token = "0x40047BC")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private TMP_Text _laptopCountdownTimer;

		// Token: 0x040047BD RID: 18365
		[Token(Token = "0x40047BD")]
		[FieldOffset(Offset = "0x1C8")]
		[FormerlySerializedAs("_laptopCountdownTimes")]
		[SerializeField]
		private float _laptopCountdownStartTime;

		// Token: 0x040047BE RID: 18366
		[Token(Token = "0x40047BE")]
		[FieldOffset(Offset = "0x1CC")]
		private float _startTime;

		// Token: 0x040047BF RID: 18367
		[Token(Token = "0x40047BF")]
		[FieldOffset(Offset = "0x1D0")]
		private bool _startedPlaying;
	}
}
