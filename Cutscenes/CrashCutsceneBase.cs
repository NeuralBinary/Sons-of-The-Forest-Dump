using System;
using System.Collections;
using Assemblies.Sons.Cinematics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Cutscenes
{
	// Token: 0x0200075C RID: 1884
	[Token(Token = "0x200075C")]
	public abstract class CrashCutsceneBase : Cutscene
	{
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x0600312F RID: 12591
		[Token(Token = "0x1700062A")]
		public abstract int PlayerBadGuyIntroHash
		{
			[Token(Token = "0x600312F")]
			get;
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06003130 RID: 12592
		[Token(Token = "0x1700062B")]
		public abstract int PlayerProxyCrashTagHash
		{
			[Token(Token = "0x6003130")]
			get;
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06003131 RID: 12593
		[Token(Token = "0x1700062C")]
		public abstract int StandUpFromCrashIndex
		{
			[Token(Token = "0x6003131")]
			get;
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062D")]
		internal FMOD_StudioEventEmitter HelicopterAudioEmitter
		{
			[Token(Token = "0x6003132")]
			[Address(RVA = "0x217F670", Offset = "0x217E670", VA = "0x18217F670")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06003133 RID: 12595 RVA: 0x0000E130 File Offset: 0x0000C330
		[Token(Token = "0x1700062E")]
		internal CrashCutsceneState State
		{
			[Token(Token = "0x6003133")]
			[Address(RVA = "0x23E0F90", Offset = "0x23DFF90", VA = "0x1823E0F90")]
			get
			{
				return CrashCutsceneState.None;
			}
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003134")]
		[Address(RVA = "0x2E3E520", Offset = "0x2E3D520", VA = "0x182E3E520")]
		internal void SetState(CrashCutsceneState crashStarted)
		{
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06003135 RID: 12597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062F")]
		internal Animator PlayerProxyAnimator
		{
			[Token(Token = "0x6003135")]
			[Address(RVA = "0x7B98D0", Offset = "0x7B88D0", VA = "0x1807B98D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000630")]
		public override string SaveId
		{
			[Token(Token = "0x6003136")]
			[Address(RVA = "0x8C25D0", Offset = "0x8C15D0", VA = "0x1808C25D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003137")]
		[Address(RVA = "0x2E3DBC0", Offset = "0x2E3CBC0", VA = "0x182E3DBC0", Slot = "5")]
		internal override void OnValidate()
		{
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003138")]
		[Address(RVA = "0x2E3DD40", Offset = "0x2E3CD40", VA = "0x182E3DD40", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x0000E148 File Offset: 0x0000C348
		[Token(Token = "0x6003139")]
		[Address(RVA = "0x2E3DCB0", Offset = "0x2E3CCB0", VA = "0x182E3DCB0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313A")]
		[Address(RVA = "0x2E3DB50", Offset = "0x2E3CB50", VA = "0x182E3DB50", Slot = "10")]
		public override void OnCutsceneQueued()
		{
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313B")]
		[Address(RVA = "0x2E3E5B0", Offset = "0x2E3D5B0", VA = "0x182E3E5B0", Slot = "18")]
		public virtual void ShowOnLoad()
		{
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313C")]
		[Address(RVA = "0x2E3D9A0", Offset = "0x2E3C9A0", VA = "0x182E3D9A0")]
		internal void HidePlayerProxy()
		{
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313D")]
		[Address(RVA = "0x2E3E300", Offset = "0x2E3D300", VA = "0x182E3E300", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313E")]
		[Address(RVA = "0x2E3E930", Offset = "0x2E3D930", VA = "0x182E3E930")]
		public void TriggerBlackScreen()
		{
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313F")]
		[Address(RVA = "0x2E3E5E0", Offset = "0x2E3D5E0", VA = "0x182E3E5E0", Slot = "12")]
		public override void Skip()
		{
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003140")]
		[Address(RVA = "0x2E3D800", Offset = "0x2E3C800", VA = "0x182E3D800")]
		protected void DisableFireSpread(GameObject parent)
		{
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003141")]
		[Address(RVA = "0x2E3E780", Offset = "0x2E3D780", VA = "0x182E3E780")]
		private void SpawnPickups(bool isLoad = false)
		{
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003142")]
		[Address(RVA = "0x2E3E530", Offset = "0x2E3D530", VA = "0x182E3E530")]
		internal void ShowBadGuyActor()
		{
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003143")]
		[Address(RVA = "0x2E3D8A0", Offset = "0x2E3C8A0", VA = "0x182E3D8A0")]
		internal void HideBadGuyActor()
		{
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003144")]
		[Address(RVA = "0x2E3E1E0", Offset = "0x2E3D1E0", VA = "0x182E3E1E0")]
		internal void RemoveBadGuyActor()
		{
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003145")]
		[Address(RVA = "0x2E3EB30", Offset = "0x2E3DB30", VA = "0x182E3EB30", Slot = "19")]
		internal virtual IEnumerator WaitForPlayerProxyOrSkip()
		{
			return null;
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003146")]
		[Address(RVA = "0x2E3EAC0", Offset = "0x2E3DAC0", VA = "0x182E3EAC0")]
		private IEnumerator WaitForPlayerProxyAnimations()
		{
			return null;
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003147")]
		[Address(RVA = "0x2E3CAD0", Offset = "0x2E3BAD0", VA = "0x182E3CAD0")]
		private void BadGuyIntroSetup()
		{
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003148")]
		[Address(RVA = "0x2E3D790", Offset = "0x2E3C790", VA = "0x182E3D790")]
		internal IEnumerator CrashWakeUpWorker()
		{
			return null;
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003149")]
		[Address(RVA = "0x2E3D1E0", Offset = "0x2E3C1E0", VA = "0x182E3D1E0")]
		private IEnumerator BadGuyIntroWorker()
		{
			return null;
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600314A")]
		[Address(RVA = "0x2E3D310", Offset = "0x2E3C310", VA = "0x182E3D310")]
		private void CrashWakeUpFinalize()
		{
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600314B")]
		[Address(RVA = "0x2E3DA20", Offset = "0x2E3CA20", VA = "0x182E3DA20")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600314C")]
		[Address(RVA = "0x2E3D250", Offset = "0x2E3C250", VA = "0x182E3D250", Slot = "13")]
		protected override void Cleanup()
		{
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600314D")]
		[Address(RVA = "0x2E3E610", Offset = "0x2E3D610", VA = "0x182E3E610")]
		private void SpawnCrashedHelicopter()
		{
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600314E")]
		[Address(RVA = "0x2E3E270", Offset = "0x2E3D270", VA = "0x182E3E270")]
		private void RemoveHelicopterActor()
		{
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600314F")]
		[Address(RVA = "0x2E3D920", Offset = "0x2E3C920", VA = "0x182E3D920")]
		private void HideHelicopterActor()
		{
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003150")]
		[Address(RVA = "0x2E3E8C0", Offset = "0x2E3D8C0", VA = "0x182E3E8C0")]
		public void StopHelicopterEngineAudio()
		{
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003151")]
		[Address(RVA = "0x2E3E900", Offset = "0x2E3D900", VA = "0x182E3E900")]
		public void StopRainAudio()
		{
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003152")]
		[Address(RVA = "0x2E3E970", Offset = "0x2E3D970", VA = "0x182E3E970")]
		public void TrySpawnRobby()
		{
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003153")]
		[Address(RVA = "0x2E3E440", Offset = "0x2E3D440", VA = "0x182E3E440")]
		public void ScaleHackHelicopter()
		{
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003154")]
		[Address(RVA = "0x2E3E4B0", Offset = "0x2E3D4B0", VA = "0x182E3E4B0")]
		private IEnumerator ScaleHack()
		{
			return null;
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003155")]
		[Address(RVA = "0x2E3EBA0", Offset = "0x2E3DBA0", VA = "0x182E3EBA0")]
		protected CrashCutsceneBase()
		{
		}

		// Token: 0x04002B11 RID: 11025
		[Token(Token = "0x4002B11")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _saveId;

		// Token: 0x04002B12 RID: 11026
		[Token(Token = "0x4002B12")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[FormerlySerializedAs("_fadeToBlack")]
		protected FadeToBlack _cutSceneFadeToBlack;

		// Token: 0x04002B13 RID: 11027
		[Token(Token = "0x4002B13")]
		[FieldOffset(Offset = "0xC0")]
		[FormerlySerializedAs("_crashLocation")]
		[SerializeField]
		protected Transform _playerSpawnLocation;

		// Token: 0x04002B14 RID: 11028
		[Token(Token = "0x4002B14")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		protected GameObject _helicopterActorGameObject;

		// Token: 0x04002B15 RID: 11029
		[Token(Token = "0x4002B15")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private bool _hideHelicopterActor;

		// Token: 0x04002B16 RID: 11030
		[Token(Token = "0x4002B16")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		protected Transform _helicopterSpawnLocation;

		// Token: 0x04002B17 RID: 11031
		[Token(Token = "0x4002B17")]
		[FieldOffset(Offset = "0xE0")]
		[FormerlySerializedAs("CrashedHelicopterGo")]
		[SerializeField]
		protected GameObject _crashedHelicopterGo;

		// Token: 0x04002B18 RID: 11032
		[Token(Token = "0x4002B18")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		protected bool _disableFireSpreadForCrashSite;

		// Token: 0x04002B19 RID: 11033
		[Token(Token = "0x4002B19")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _placedPickups;

		// Token: 0x04002B1A RID: 11034
		[Token(Token = "0x4002B1A")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Transform _robbySpawnLocation;

		// Token: 0x04002B1B RID: 11035
		[Token(Token = "0x4002B1B")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _playerProxyRoot;

		// Token: 0x04002B1C RID: 11036
		[Token(Token = "0x4002B1C")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private FMOD_StudioEventEmitter _rainAudioEmitter;

		// Token: 0x04002B1D RID: 11037
		[Token(Token = "0x4002B1D")]
		[FieldOffset(Offset = "0x110")]
		[FormerlySerializedAs("_playerAnimator")]
		[SerializeField]
		private Animator _playerProxyAnimator;

		// Token: 0x04002B1E RID: 11038
		[Token(Token = "0x4002B1E")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _badGuyGameObject;

		// Token: 0x04002B1F RID: 11039
		[Token(Token = "0x4002B1F")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private FMOD_StudioEventEmitter _helicopterAudioEmitter;

		// Token: 0x04002B20 RID: 11040
		[Token(Token = "0x4002B20")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected Transform _scaleHackModel;

		// Token: 0x04002B21 RID: 11041
		[Token(Token = "0x4002B21")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected float _scaleHackStartingScale;

		// Token: 0x04002B22 RID: 11042
		[Token(Token = "0x4002B22")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		private float _scaleHackAmount;

		// Token: 0x04002B23 RID: 11043
		[Token(Token = "0x4002B23")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private float _scaleHackTargetScale;

		// Token: 0x04002B24 RID: 11044
		[Token(Token = "0x4002B24")]
		[FieldOffset(Offset = "0x140")]
		private Coroutine _waitForPlayerProxyOrSkipCoroutine;

		// Token: 0x04002B25 RID: 11045
		[Token(Token = "0x4002B25")]
		[FieldOffset(Offset = "0x148")]
		private FadeToBlack _playerFadeToBlackCached;

		// Token: 0x04002B26 RID: 11046
		[Token(Token = "0x4002B26")]
		[FieldOffset(Offset = "0x150")]
		private bool _skipToBadGuyIntro;

		// Token: 0x04002B27 RID: 11047
		[Token(Token = "0x4002B27")]
		[FieldOffset(Offset = "0x151")]
		private bool _skipToFinalize;

		// Token: 0x04002B28 RID: 11048
		[Token(Token = "0x4002B28")]
		[FieldOffset(Offset = "0x154")]
		public float OpenInventoryTutorialRange;

		// Token: 0x04002B29 RID: 11049
		[Token(Token = "0x4002B29")]
		[FieldOffset(Offset = "0x158")]
		public float CutToBlackScreenDelay;

		// Token: 0x04002B2A RID: 11050
		[Token(Token = "0x4002B2A")]
		[FieldOffset(Offset = "0x15C")]
		private bool _spawnedPickups;

		// Token: 0x04002B2B RID: 11051
		[Token(Token = "0x4002B2B")]
		[FieldOffset(Offset = "0x15D")]
		private bool _robbySpawned;

		// Token: 0x04002B2C RID: 11052
		[Token(Token = "0x4002B2C")]
		[FieldOffset(Offset = "0x160")]
		private float _badGuyIntroKnockoutTime;

		// Token: 0x04002B2D RID: 11053
		[Token(Token = "0x4002B2D")]
		[FieldOffset(Offset = "0x168")]
		private Coroutine _badGuyIntroCoroutine;

		// Token: 0x04002B2E RID: 11054
		[Token(Token = "0x4002B2E")]
		[FieldOffset(Offset = "0x170")]
		private CrashCutsceneState _state;

		// Token: 0x04002B2F RID: 11055
		[Token(Token = "0x4002B2F")]
		[FieldOffset(Offset = "0x178")]
		private Camera _cutSceneCamera;

		// Token: 0x04002B30 RID: 11056
		[Token(Token = "0x4002B30")]
		[FieldOffset(Offset = "0x180")]
		private Coroutine _waitForPlayerProxyAnimationsCoroutine;

		// Token: 0x04002B31 RID: 11057
		[Token(Token = "0x4002B31")]
		[FieldOffset(Offset = "0x188")]
		private Coroutine _crashWakeUpCoroutine;
	}
}
