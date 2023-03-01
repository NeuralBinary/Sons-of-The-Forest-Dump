using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.FieldOfView;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008D4 RID: 2260
	[Token(Token = "0x20008D4")]
	public abstract class EndGameCutscene : Cutscene
	{
		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06003D37 RID: 15671
		[Token(Token = "0x170007AF")]
		public abstract int PlayerCutsceneStartHash
		{
			[Token(Token = "0x6003D37")]
			get;
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06003D38 RID: 15672
		[Token(Token = "0x170007B0")]
		public abstract int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x6003D38")]
			get;
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x00011E20 File Offset: 0x00010020
		[Token(Token = "0x170007B1")]
		public virtual bool HandlePlayerAnimationMoveEvents
		{
			[Token(Token = "0x6003D39")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06003D3A RID: 15674 RVA: 0x00011E38 File Offset: 0x00010038
		[Token(Token = "0x170007B2")]
		public virtual bool ShouldEquipPreviouslyHeldItems
		{
			[Token(Token = "0x6003D3A")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06003D3B RID: 15675 RVA: 0x00011E50 File Offset: 0x00010050
		[Token(Token = "0x170007B3")]
		public virtual bool ShouldAlignPlayer
		{
			[Token(Token = "0x6003D3B")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06003D3C RID: 15676 RVA: 0x00011E68 File Offset: 0x00010068
		[Token(Token = "0x170007B4")]
		public virtual bool ShouldStashHeldItems
		{
			[Token(Token = "0x6003D3C")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06003D3D RID: 15677 RVA: 0x00011E80 File Offset: 0x00010080
		[Token(Token = "0x170007B5")]
		public virtual bool IgnoreAnimatorState
		{
			[Token(Token = "0x6003D3D")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06003D3E RID: 15678 RVA: 0x00011E98 File Offset: 0x00010098
		[Token(Token = "0x170007B6")]
		public virtual bool HideRemotePlayers
		{
			[Token(Token = "0x6003D3E")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06003D3F RID: 15679 RVA: 0x00011EB0 File Offset: 0x000100B0
		[Token(Token = "0x170007B7")]
		public bool IsPreview
		{
			[Token(Token = "0x6003D3F")]
			[Address(RVA = "0x1047280", Offset = "0x1046280", VA = "0x181047280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D40")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "23")]
		internal virtual void OnNormalizedTimeChanged(float value)
		{
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x00011EC8 File Offset: 0x000100C8
		[Token(Token = "0x6003D41")]
		[Address(RVA = "0x2F18DB0", Offset = "0x2F17DB0", VA = "0x182F18DB0")]
		private bool CutsceneAlignPlayer()
		{
			return default(bool);
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D42")]
		[Address(RVA = "0x2F1A750", Offset = "0x2F19750", VA = "0x182F1A750")]
		protected void SetPlayerLocatorPosition(Vector3 position)
		{
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D43")]
		[Address(RVA = "0x2F1A790", Offset = "0x2F19790", VA = "0x182F1A790")]
		protected void SetPlayerLocatorRotation(Quaternion rotation)
		{
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x00011EE0 File Offset: 0x000100E0
		[Token(Token = "0x6003D44")]
		[Address(RVA = "0x2F1B5B0", Offset = "0x2F1A5B0", VA = "0x182F1B5B0")]
		internal static bool VirginiaMissingOrDead()
		{
			return default(bool);
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x00011EF8 File Offset: 0x000100F8
		[Token(Token = "0x6003D45")]
		[Address(RVA = "0x2F1A520", Offset = "0x2F19520", VA = "0x182F1A520")]
		internal static bool RobbyMissingOrDead()
		{
			return default(bool);
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D46")]
		[Address(RVA = "0x2F1B540", Offset = "0x2F1A540", VA = "0x182F1B540")]
		private void Update()
		{
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D47")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "24")]
		internal virtual void UpdateHook()
		{
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D48")]
		[Address(RVA = "0x2F191F0", Offset = "0x2F181F0", VA = "0x182F191F0", Slot = "25")]
		internal virtual void LateUpdate()
		{
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x00011F10 File Offset: 0x00010110
		[Token(Token = "0x6003D49")]
		[Address(RVA = "0x2F19090", Offset = "0x2F18090", VA = "0x182F19090")]
		public bool IsAnimatorPlayingSequence(Animator targetAnimator, int layerIndex, out float normalizedTime)
		{
			return default(bool);
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4A")]
		[Address(RVA = "0x2F1B370", Offset = "0x2F1A370", VA = "0x182F1B370")]
		private void UpdateSequence()
		{
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4B")]
		[Address(RVA = "0x2F1B250", Offset = "0x2F1A250", VA = "0x182F1B250")]
		internal void TriggerCutsceneEnd()
		{
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x00011F28 File Offset: 0x00010128
		[Token(Token = "0x6003D4C")]
		[Address(RVA = "0x2F18CA0", Offset = "0x2F17CA0", VA = "0x182F18CA0", Slot = "26")]
		internal virtual bool CheckIsStillPlaying()
		{
			return default(bool);
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4D")]
		[Address(RVA = "0x2F1B260", Offset = "0x2F1A260", VA = "0x182F1B260")]
		private void UpdatePlayerSequence(ref bool isStillPlaying)
		{
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4E")]
		[Address(RVA = "0x2F18F20", Offset = "0x2F17F20", VA = "0x182F18F20")]
		protected void DoAlignPlayer()
		{
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x00011F40 File Offset: 0x00010140
		[Token(Token = "0x6003D4F")]
		[Address(RVA = "0x2F19AB0", Offset = "0x2F18AB0", VA = "0x182F19AB0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x00011F58 File Offset: 0x00010158
		[Token(Token = "0x6003D50")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "27")]
		internal virtual bool IsCutsceneReady()
		{
			return default(bool);
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D51")]
		[Address(RVA = "0x2F18EB0", Offset = "0x2F17EB0", VA = "0x182F18EB0")]
		internal IEnumerator CutsceneReadyChecker()
		{
			return null;
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D52")]
		[Address(RVA = "0x2F19270", Offset = "0x2F18270", VA = "0x182F19270", Slot = "28")]
		internal virtual void OnCutsceneReady()
		{
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x2F18E10", Offset = "0x2F17E10", VA = "0x182F18E10", Slot = "29")]
		internal virtual void CutsceneEnded(CutsceneState obj)
		{
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D54")]
		[Address(RVA = "0x2F1A600", Offset = "0x2F19600", VA = "0x182F1A600")]
		private void SetObjectsEnabled(List<GameObject> targets, bool value)
		{
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D55")]
		[Address(RVA = "0x2F1ABF0", Offset = "0x2F19BF0", VA = "0x182F1ABF0")]
		internal void SetupPlayer()
		{
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D56")]
		[Address(RVA = "0x2F1A7C0", Offset = "0x2F197C0", VA = "0x182F1A7C0")]
		public static void SetPlayerLocked(bool locked)
		{
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D57")]
		[Address(RVA = "0x2F1A9B0", Offset = "0x2F199B0", VA = "0x182F1A9B0")]
		protected void SetupFov()
		{
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D58")]
		[Address(RVA = "0x2F19DA0", Offset = "0x2F18DA0", VA = "0x182F19DA0")]
		private void RevertFov()
		{
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x00011F70 File Offset: 0x00010170
		[Token(Token = "0x6003D59")]
		[Address(RVA = "0x2F191D0", Offset = "0x2F181D0", VA = "0x182F191D0")]
		private bool IsValidFov(float sourceFov)
		{
			return default(bool);
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5A")]
		[Address(RVA = "0x2F19E70", Offset = "0x2F18E70", VA = "0x182F19E70")]
		internal void RevertPlayer()
		{
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5B")]
		[Address(RVA = "0x2F1B750", Offset = "0x2F1A750", VA = "0x182F1B750")]
		internal void ZeroPlayerMovement()
		{
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5C")]
		[Address(RVA = "0x2F19570", Offset = "0x2F18570", VA = "0x182F19570")]
		private void OnPlayerAnimatorMove()
		{
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5D")]
		[Address(RVA = "0x2F19CA0", Offset = "0x2F18CA0", VA = "0x182F19CA0", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5E")]
		[Address(RVA = "0x2F19500", Offset = "0x2F18500", VA = "0x182F19500")]
		private void OnDisable()
		{
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5F")]
		[Address(RVA = "0x2F18FF0", Offset = "0x2F17FF0", VA = "0x182F18FF0")]
		public static void ForceVirginiaAlways(bool value)
		{
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D60")]
		[Address(RVA = "0x2F18F50", Offset = "0x2F17F50", VA = "0x182F18F50")]
		public static void ForceRobbyAlways(bool value)
		{
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D61")]
		[Address(RVA = "0x2F1B160", Offset = "0x2F1A160", VA = "0x182F1B160")]
		protected void StashHeldItems()
		{
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D62")]
		[Address(RVA = "0x2F1B990", Offset = "0x2F1A990", VA = "0x182F1B990")]
		protected EndGameCutscene()
		{
		}

		// Token: 0x04004120 RID: 16672
		[Token(Token = "0x4004120")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _isPreview;

		// Token: 0x04004121 RID: 16673
		[Token(Token = "0x4004121")]
		[FieldOffset(Offset = "0xB1")]
		[SerializeField]
		private bool _autoPlay;

		// Token: 0x04004122 RID: 16674
		[Token(Token = "0x4004122")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _fov;

		// Token: 0x04004123 RID: 16675
		[Token(Token = "0x4004123")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AnimationCurve _fovCurve;

		// Token: 0x04004124 RID: 16676
		[Token(Token = "0x4004124")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool _dontAnimatePlayer;

		// Token: 0x04004125 RID: 16677
		[Token(Token = "0x4004125")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Animator _trackedAnimator;

		// Token: 0x04004126 RID: 16678
		[Token(Token = "0x4004126")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private List<GameObject> _previewObjectsToEnable;

		// Token: 0x04004127 RID: 16679
		[Token(Token = "0x4004127")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private List<GameObject> _previewObjectsToDisable;

		// Token: 0x04004128 RID: 16680
		[Token(Token = "0x4004128")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[FormerlySerializedAs("_objectsToEnable")]
		private List<GameObject> _objectsToEnableOnStart;

		// Token: 0x04004129 RID: 16681
		[Token(Token = "0x4004129")]
		[FieldOffset(Offset = "0xE8")]
		[FormerlySerializedAs("_objectsToDisable")]
		[SerializeField]
		private List<GameObject> _objectsToDisableOnStart;

		// Token: 0x0400412A RID: 16682
		[Token(Token = "0x400412A")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private List<GameObject> _objectsToEnableOnEnd;

		// Token: 0x0400412B RID: 16683
		[Token(Token = "0x400412B")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private List<GameObject> _objectsToDisableOnEnd;

		// Token: 0x0400412C RID: 16684
		[Token(Token = "0x400412C")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Transform _playerLocator;

		// Token: 0x0400412D RID: 16685
		[Token(Token = "0x400412D")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Transform _playerEndLocator;

		// Token: 0x0400412E RID: 16686
		[Token(Token = "0x400412E")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private float _playingAlignTimer;

		// Token: 0x0400412F RID: 16687
		[Token(Token = "0x400412F")]
		[FieldOffset(Offset = "0x114")]
		private bool _cutsceneIsPlaying;

		// Token: 0x04004130 RID: 16688
		[Token(Token = "0x4004130")]
		[FieldOffset(Offset = "0x115")]
		private bool _alignPlayer;

		// Token: 0x04004131 RID: 16689
		[Token(Token = "0x4004131")]
		[FieldOffset(Offset = "0x116")]
		private bool _animatorStartedCutsceneAnimation;

		// Token: 0x04004132 RID: 16690
		[Token(Token = "0x4004132")]
		[FieldOffset(Offset = "0x117")]
		private bool _setCutsceneBool;

		// Token: 0x04004133 RID: 16691
		[Token(Token = "0x4004133")]
		[FieldOffset(Offset = "0x118")]
		private Vector3 _playerMovementOffset;

		// Token: 0x04004134 RID: 16692
		[Token(Token = "0x4004134")]
		[FieldOffset(Offset = "0x124")]
		private Quaternion _playerRotationOffset;

		// Token: 0x04004135 RID: 16693
		[Token(Token = "0x4004135")]
		[FieldOffset(Offset = "0x134")]
		private Vector3 _currentPlayerPosition;

		// Token: 0x04004136 RID: 16694
		[Token(Token = "0x4004136")]
		[FieldOffset(Offset = "0x140")]
		private Quaternion _currentPlayerRotation;

		// Token: 0x04004137 RID: 16695
		[Token(Token = "0x4004137")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ILayerBehaviourActivator[] EndCutsceneFullBodyOnSpineOffActivators;

		// Token: 0x04004138 RID: 16696
		[Token(Token = "0x4004138")]
		[FieldOffset(Offset = "0x150")]
		private float _currentNormalizedTime;

		// Token: 0x04004139 RID: 16697
		[Token(Token = "0x4004139")]
		[FieldOffset(Offset = "0x154")]
		private float _lastNormalizedTime;

		// Token: 0x0400413A RID: 16698
		[Token(Token = "0x400413A")]
		[FieldOffset(Offset = "0x158")]
		private FovManager _cameraFovManager;

		// Token: 0x0400413B RID: 16699
		[Token(Token = "0x400413B")]
		[FieldOffset(Offset = "0x8")]
		private static float _fovReturnSpeed;

		// Token: 0x0400413C RID: 16700
		[Token(Token = "0x400413C")]
		[FieldOffset(Offset = "0x160")]
		private float _cutsceneReadyTimeout;

		// Token: 0x0400413D RID: 16701
		[Token(Token = "0x400413D")]
		[FieldOffset(Offset = "0xC")]
		private static bool? _overrideVirginiaAlways;

		// Token: 0x0400413E RID: 16702
		[Token(Token = "0x400413E")]
		[FieldOffset(Offset = "0xE")]
		private static bool? _overrideRobbyAlways;

		// Token: 0x0400413F RID: 16703
		[Token(Token = "0x400413F")]
		[FieldOffset(Offset = "0x164")]
		private bool _trackedAnimatorIsPlayingSequence;
	}
}
