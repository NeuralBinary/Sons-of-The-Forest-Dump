using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.FieldOfView;
using Sons.Save;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000949 RID: 2377
	[Token(Token = "0x2000949")]
	public abstract class EndGameCutscene : PlayerStateSyncedCutscene
	{
		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x0600448F RID: 17551
		[Token(Token = "0x170008DD")]
		public abstract int PlayerCutsceneStartHash { [Token(Token = "0x600448F")] get; }

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06004490 RID: 17552
		[Token(Token = "0x170008DE")]
		public abstract int TrackedAnimatorCutsceneStateHash { [Token(Token = "0x6004490")] get; }

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x00014DA8 File Offset: 0x00012FA8
		[Token(Token = "0x170008DF")]
		public virtual bool HandlePlayerAnimationMoveEvents
		{
			[Token(Token = "0x6004491")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06004492 RID: 17554 RVA: 0x00014DC0 File Offset: 0x00012FC0
		[Token(Token = "0x170008E0")]
		public virtual bool ShouldEquipPreviouslyHeldItems
		{
			[Token(Token = "0x6004492")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x00014DD8 File Offset: 0x00012FD8
		[Token(Token = "0x170008E1")]
		public virtual bool ShouldAlignPlayer
		{
			[Token(Token = "0x6004493")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06004494 RID: 17556 RVA: 0x00014DF0 File Offset: 0x00012FF0
		[Token(Token = "0x170008E2")]
		public virtual bool ShouldStashHeldItems
		{
			[Token(Token = "0x6004494")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x00014E08 File Offset: 0x00013008
		[Token(Token = "0x170008E3")]
		public virtual bool IgnoreAnimatorState
		{
			[Token(Token = "0x6004495")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06004496 RID: 17558 RVA: 0x00014E20 File Offset: 0x00013020
		[Token(Token = "0x170008E4")]
		public virtual bool HideRemotePlayers
		{
			[Token(Token = "0x6004496")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x00014E38 File Offset: 0x00013038
		[Token(Token = "0x170008E5")]
		public bool IsPreview
		{
			[Token(Token = "0x6004497")]
			[Address(RVA = "0xA03DA0", Offset = "0xA023A0", VA = "0x180A03DA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004498")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		internal virtual void OnNormalizedTimeChanged(float value)
		{
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06004499 RID: 17561 RVA: 0x00014E50 File Offset: 0x00013050
		[Token(Token = "0x170008E6")]
		protected bool WasPlayed
		{
			[Token(Token = "0x6004499")]
			[Address(RVA = "0x3654730", Offset = "0x3652D30", VA = "0x183654730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x00014E68 File Offset: 0x00013068
		[Token(Token = "0x600449A")]
		[Address(RVA = "0x3654740", Offset = "0x3652D40", VA = "0x183654740")]
		private bool CutsceneAlignPlayer()
		{
			return default(bool);
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449B")]
		[Address(RVA = "0x36547A0", Offset = "0x3652DA0", VA = "0x1836547A0")]
		protected void SetPlayerLocatorPosition(Vector3 position)
		{
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449C")]
		[Address(RVA = "0x3654820", Offset = "0x3652E20", VA = "0x183654820")]
		protected void SetPlayerLocatorRotation(Quaternion rotation)
		{
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x00014E80 File Offset: 0x00013080
		[Token(Token = "0x600449D")]
		[Address(RVA = "0x3654890", Offset = "0x3652E90", VA = "0x183654890")]
		internal static bool VirginiaMissingOrDead()
		{
			return default(bool);
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x00014E98 File Offset: 0x00013098
		[Token(Token = "0x600449E")]
		[Address(RVA = "0x3654B30", Offset = "0x3653130", VA = "0x183654B30")]
		internal static bool RobbyMissingOrDead()
		{
			return default(bool);
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449F")]
		[Address(RVA = "0x3654D10", Offset = "0x3653310", VA = "0x183654D10", Slot = "17")]
		protected override void InitializeState(NamedIntData saveValue)
		{
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A0")]
		[Address(RVA = "0x3654D30", Offset = "0x3653330", VA = "0x183654D30", Slot = "16")]
		protected override void AppliedState(NamedIntData saveValue)
		{
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A1")]
		[Address(RVA = "0x3654DC0", Offset = "0x36533C0", VA = "0x183654DC0")]
		private void RefreshCutsceneStateVisuals()
		{
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A2")]
		[Address(RVA = "0x3654E00", Offset = "0x3653400", VA = "0x183654E00")]
		private void SetCutsceneState(CutsceneState saveValueSaveValue)
		{
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A3")]
		[Address(RVA = "0x3654E30", Offset = "0x3653430", VA = "0x183654E30")]
		private void Update()
		{
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		internal virtual void UpdateHook()
		{
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A5")]
		[Address(RVA = "0x3654EA0", Offset = "0x36534A0", VA = "0x183654EA0", Slot = "28")]
		internal virtual void LateUpdate()
		{
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x00014EB0 File Offset: 0x000130B0
		[Token(Token = "0x60044A6")]
		[Address(RVA = "0x3654F00", Offset = "0x3653500", VA = "0x183654F00")]
		public bool IsAnimatorPlayingSequence(Animator targetAnimator, int layerIndex, out float normalizedTime)
		{
			return default(bool);
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A7")]
		[Address(RVA = "0x36550A0", Offset = "0x36536A0", VA = "0x1836550A0")]
		private void UpdateSequence()
		{
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A8")]
		[Address(RVA = "0x36552C0", Offset = "0x36538C0", VA = "0x1836552C0")]
		internal void TriggerCutsceneEnd()
		{
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x00014EC8 File Offset: 0x000130C8
		[Token(Token = "0x60044A9")]
		[Address(RVA = "0x3655320", Offset = "0x3653920", VA = "0x183655320", Slot = "29")]
		internal virtual bool CheckIsStillPlaying()
		{
			return default(bool);
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AA")]
		[Address(RVA = "0x3655430", Offset = "0x3653A30", VA = "0x183655430")]
		private void UpdatePlayerSequence(ref bool isStillPlaying)
		{
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AB")]
		[Address(RVA = "0x3655540", Offset = "0x3653B40", VA = "0x183655540")]
		protected void DoAlignPlayer()
		{
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x00014EE0 File Offset: 0x000130E0
		[Token(Token = "0x60044AC")]
		[Address(RVA = "0x3655660", Offset = "0x3653C60", VA = "0x183655660", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x00014EF8 File Offset: 0x000130F8
		[Token(Token = "0x60044AD")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "30")]
		internal virtual bool IsCutsceneReady()
		{
			return default(bool);
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044AE")]
		[Address(RVA = "0x3655940", Offset = "0x3653F40", VA = "0x183655940")]
		internal IEnumerator CutsceneReadyChecker()
		{
			return null;
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AF")]
		[Address(RVA = "0x36559D0", Offset = "0x3653FD0", VA = "0x1836559D0", Slot = "31")]
		internal virtual void OnCutsceneReady()
		{
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B0")]
		[Address(RVA = "0x3655E30", Offset = "0x3654430", VA = "0x183655E30", Slot = "32")]
		internal virtual void CutsceneEnded(CutsceneState obj)
		{
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B1")]
		[Address(RVA = "0x3656060", Offset = "0x3654660", VA = "0x183656060")]
		private void SetObjectsEnabled(List<GameObject> targets, bool value)
		{
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B2")]
		[Address(RVA = "0x3656240", Offset = "0x3654840", VA = "0x183656240")]
		internal void SetupPlayer()
		{
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B3")]
		[Address(RVA = "0x3656890", Offset = "0x3654E90", VA = "0x183656890")]
		public static void SetPlayerLocked(bool locked)
		{
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B4")]
		[Address(RVA = "0x3656B40", Offset = "0x3655140", VA = "0x183656B40")]
		protected void SetupFov()
		{
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B5")]
		[Address(RVA = "0x3656E70", Offset = "0x3655470", VA = "0x183656E70")]
		private void RevertFov()
		{
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x00014F10 File Offset: 0x00013110
		[Token(Token = "0x60044B6")]
		[Address(RVA = "0x3656FA0", Offset = "0x36555A0", VA = "0x183656FA0")]
		private bool IsValidFov(float sourceFov)
		{
			return default(bool);
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B7")]
		[Address(RVA = "0x3656FD0", Offset = "0x36555D0", VA = "0x183656FD0")]
		internal void RevertPlayer()
		{
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B8")]
		[Address(RVA = "0x36578F0", Offset = "0x3655EF0", VA = "0x1836578F0")]
		internal void ZeroPlayerMovement()
		{
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B9")]
		[Address(RVA = "0x3657980", Offset = "0x3655F80", VA = "0x183657980")]
		private void OnPlayerAnimatorMove()
		{
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BA")]
		[Address(RVA = "0x3657D30", Offset = "0x3656330", VA = "0x183657D30", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BB")]
		[Address(RVA = "0x3657F20", Offset = "0x3656520", VA = "0x183657F20")]
		private void OnDisable()
		{
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BC")]
		[Address(RVA = "0x3657FC0", Offset = "0x36565C0", VA = "0x183657FC0")]
		public static void ForceVirginiaAlways(bool value)
		{
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BD")]
		[Address(RVA = "0x3658030", Offset = "0x3656630", VA = "0x183658030")]
		public static void ForceRobbyAlways(bool value)
		{
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BE")]
		[Address(RVA = "0x36580A0", Offset = "0x36566A0", VA = "0x1836580A0")]
		protected void StashHeldItems()
		{
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BF")]
		[Address(RVA = "0x3658230", Offset = "0x3656830", VA = "0x183658230")]
		protected EndGameCutscene()
		{
		}

		// Token: 0x04004766 RID: 18278
		[Token(Token = "0x4004766")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool _isPreview;

		// Token: 0x04004767 RID: 18279
		[Token(Token = "0x4004767")]
		[FieldOffset(Offset = "0xC1")]
		[SerializeField]
		private bool _autoPlay;

		// Token: 0x04004768 RID: 18280
		[Token(Token = "0x4004768")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float _fov;

		// Token: 0x04004769 RID: 18281
		[Token(Token = "0x4004769")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private AnimationCurve _fovCurve;

		// Token: 0x0400476A RID: 18282
		[Token(Token = "0x400476A")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private bool _dontAnimatePlayer;

		// Token: 0x0400476B RID: 18283
		[Token(Token = "0x400476B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Animator _trackedAnimator;

		// Token: 0x0400476C RID: 18284
		[Token(Token = "0x400476C")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private List<GameObject> _previewObjectsToEnable;

		// Token: 0x0400476D RID: 18285
		[Token(Token = "0x400476D")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private List<GameObject> _previewObjectsToDisable;

		// Token: 0x0400476E RID: 18286
		[Token(Token = "0x400476E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[FormerlySerializedAs("_objectsToEnable")]
		private List<GameObject> _objectsToEnableOnStart;

		// Token: 0x0400476F RID: 18287
		[Token(Token = "0x400476F")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[FormerlySerializedAs("_objectsToDisable")]
		private List<GameObject> _objectsToDisableOnStart;

		// Token: 0x04004770 RID: 18288
		[Token(Token = "0x4004770")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private List<GameObject> _objectsToEnableOnEnd;

		// Token: 0x04004771 RID: 18289
		[Token(Token = "0x4004771")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private List<GameObject> _objectsToDisableOnEnd;

		// Token: 0x04004772 RID: 18290
		[Token(Token = "0x4004772")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Transform _playerLocator;

		// Token: 0x04004773 RID: 18291
		[Token(Token = "0x4004773")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Transform _playerEndLocator;

		// Token: 0x04004774 RID: 18292
		[Token(Token = "0x4004774")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _playingAlignTimer;

		// Token: 0x04004775 RID: 18293
		[Token(Token = "0x4004775")]
		[FieldOffset(Offset = "0x124")]
		private bool _cutsceneIsPlaying;

		// Token: 0x04004776 RID: 18294
		[Token(Token = "0x4004776")]
		[FieldOffset(Offset = "0x125")]
		private bool _alignPlayer;

		// Token: 0x04004777 RID: 18295
		[Token(Token = "0x4004777")]
		[FieldOffset(Offset = "0x126")]
		private bool _animatorStartedCutsceneAnimation;

		// Token: 0x04004778 RID: 18296
		[Token(Token = "0x4004778")]
		[FieldOffset(Offset = "0x127")]
		private bool _setCutsceneBool;

		// Token: 0x04004779 RID: 18297
		[Token(Token = "0x4004779")]
		[FieldOffset(Offset = "0x128")]
		private Vector3 _playerMovementOffset;

		// Token: 0x0400477A RID: 18298
		[Token(Token = "0x400477A")]
		[FieldOffset(Offset = "0x134")]
		private Quaternion _playerRotationOffset;

		// Token: 0x0400477B RID: 18299
		[Token(Token = "0x400477B")]
		[FieldOffset(Offset = "0x144")]
		private Vector3 _currentPlayerPosition;

		// Token: 0x0400477C RID: 18300
		[Token(Token = "0x400477C")]
		[FieldOffset(Offset = "0x150")]
		private Quaternion _currentPlayerRotation;

		// Token: 0x0400477D RID: 18301
		[Token(Token = "0x400477D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ILayerBehaviourActivator[] EndCutsceneFullBodyOnSpineOffActivators;

		// Token: 0x0400477E RID: 18302
		[Token(Token = "0x400477E")]
		[FieldOffset(Offset = "0x160")]
		private float _currentNormalizedTime;

		// Token: 0x0400477F RID: 18303
		[Token(Token = "0x400477F")]
		[FieldOffset(Offset = "0x164")]
		private float _lastNormalizedTime;

		// Token: 0x04004780 RID: 18304
		[Token(Token = "0x4004780")]
		[FieldOffset(Offset = "0x168")]
		private FovManager _cameraFovManager;

		// Token: 0x04004781 RID: 18305
		[Token(Token = "0x4004781")]
		[FieldOffset(Offset = "0x8")]
		private static float _fovReturnSpeed;

		// Token: 0x04004782 RID: 18306
		[Token(Token = "0x4004782")]
		[FieldOffset(Offset = "0x170")]
		private float _cutsceneReadyTimeout;

		// Token: 0x04004783 RID: 18307
		[Token(Token = "0x4004783")]
		[FieldOffset(Offset = "0xC")]
		private static bool? _overrideVirginiaAlways;

		// Token: 0x04004784 RID: 18308
		[Token(Token = "0x4004784")]
		[FieldOffset(Offset = "0xE")]
		private static bool? _overrideRobbyAlways;

		// Token: 0x04004785 RID: 18309
		[Token(Token = "0x4004785")]
		[FieldOffset(Offset = "0x174")]
		private bool _trackedAnimatorIsPlayingSequence;

		// Token: 0x04004786 RID: 18310
		[Token(Token = "0x4004786")]
		[FieldOffset(Offset = "0x178")]
		private CutsceneState _cutsceneState;
	}
}
