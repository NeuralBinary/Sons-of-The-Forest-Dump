using System;
using System.Collections;
using Assemblies.Sons.Cinematics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Cutscenes
{
	// Token: 0x02000667 RID: 1639
	[Token(Token = "0x2000667")]
	public abstract class CrashCutsceneBase : Cutscene
	{
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06002AA4 RID: 10916
		[Token(Token = "0x17000595")]
		public abstract int PlayerBadGuyIntroHash { [Token(Token = "0x6002AA4")] get; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06002AA5 RID: 10917
		[Token(Token = "0x17000596")]
		public abstract int PlayerProxyCrashTagHash { [Token(Token = "0x6002AA5")] get; }

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002AA6 RID: 10918
		[Token(Token = "0x17000597")]
		public abstract int StandUpFromCrashIndex { [Token(Token = "0x6002AA6")] get; }

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000598")]
		internal FMOD_StudioEventEmitter HelicopterAudioEmitter
		{
			[Token(Token = "0x6002AA7")]
			[Address(RVA = "0x1359C20", Offset = "0x1358220", VA = "0x181359C20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002AA8 RID: 10920 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		[Token(Token = "0x17000599")]
		internal CrashCutsceneState State
		{
			[Token(Token = "0x6002AA8")]
			[Address(RVA = "0x2866360", Offset = "0x2864960", VA = "0x182866360")]
			get
			{
				return CrashCutsceneState.None;
			}
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0x33FF0C0", Offset = "0x33FD6C0", VA = "0x1833FF0C0")]
		internal void SetState(CrashCutsceneState crashStarted)
		{
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06002AAA RID: 10922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059A")]
		internal Animator PlayerProxyAnimator
		{
			[Token(Token = "0x6002AAA")]
			[Address(RVA = "0x8DF560", Offset = "0x8DDB60", VA = "0x1808DF560")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06002AAB RID: 10923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059B")]
		public override string SaveId
		{
			[Token(Token = "0x6002AAB")]
			[Address(RVA = "0xA03D90", Offset = "0xA02390", VA = "0x180A03D90", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAC")]
		[Address(RVA = "0x33FF0D0", Offset = "0x33FD6D0", VA = "0x1833FF0D0", Slot = "5")]
		internal override void OnValidate()
		{
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAD")]
		[Address(RVA = "0x33FF2D0", Offset = "0x33FD8D0", VA = "0x1833FF2D0", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		[Token(Token = "0x6002AAE")]
		[Address(RVA = "0x33FFC20", Offset = "0x33FE220", VA = "0x1833FFC20", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAF")]
		[Address(RVA = "0x33FFCB0", Offset = "0x33FE2B0", VA = "0x1833FFCB0", Slot = "10")]
		public override void OnCutsceneQueued()
		{
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB0")]
		[Address(RVA = "0x33FFD20", Offset = "0x33FE320", VA = "0x1833FFD20", Slot = "18")]
		public virtual void ShowOnLoad()
		{
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB1")]
		[Address(RVA = "0x33FFE50", Offset = "0x33FE450", VA = "0x1833FFE50")]
		internal void HidePlayerProxy()
		{
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB2")]
		[Address(RVA = "0x33FFF70", Offset = "0x33FE570", VA = "0x1833FFF70", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB3")]
		[Address(RVA = "0x3400140", Offset = "0x33FE740", VA = "0x183400140")]
		public void TriggerBlackScreen()
		{
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0x3400190", Offset = "0x33FE790", VA = "0x183400190", Slot = "12")]
		public override void Skip()
		{
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0x34001C0", Offset = "0x33FE7C0", VA = "0x1834001C0")]
		protected void DisableFireSpread(GameObject parent)
		{
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB6")]
		[Address(RVA = "0x3400270", Offset = "0x33FE870", VA = "0x183400270")]
		private void SpawnPickups(bool isLoad = false)
		{
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB7")]
		[Address(RVA = "0x3400480", Offset = "0x33FEA80", VA = "0x183400480")]
		internal void ShowBadGuyActor()
		{
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB8")]
		[Address(RVA = "0x34005A0", Offset = "0x33FEBA0", VA = "0x1834005A0")]
		internal void HideBadGuyActor()
		{
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB9")]
		[Address(RVA = "0x34006C0", Offset = "0x33FECC0", VA = "0x1834006C0")]
		internal void RemoveBadGuyActor()
		{
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABA")]
		[Address(RVA = "0x34007B0", Offset = "0x33FEDB0", VA = "0x1834007B0")]
		private IEnumerator WaitForPlayerProxyOrSkip()
		{
			return null;
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABB")]
		[Address(RVA = "0x3400840", Offset = "0x33FEE40", VA = "0x183400840")]
		private IEnumerator WaitForPlayerProxyAnimations()
		{
			return null;
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABC")]
		[Address(RVA = "0x34008D0", Offset = "0x33FEED0", VA = "0x1834008D0")]
		private void BadGuyIntroSetup()
		{
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABD")]
		[Address(RVA = "0x34013F0", Offset = "0x33FF9F0", VA = "0x1834013F0")]
		internal IEnumerator CrashWakeUpWorker()
		{
			return null;
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABE")]
		[Address(RVA = "0x3401480", Offset = "0x33FFA80", VA = "0x183401480")]
		private IEnumerator BadGuyIntroWorker()
		{
			return null;
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0x3401510", Offset = "0x33FFB10", VA = "0x183401510")]
		private void CrashWakeUpFinalize()
		{
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0x3401D70", Offset = "0x3400370", VA = "0x183401D70")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0x3402040", Offset = "0x3400640", VA = "0x183402040", Slot = "13")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC2")]
		[Address(RVA = "0x3402160", Offset = "0x3400760", VA = "0x183402160")]
		private void SpawnCrashedHelicopter()
		{
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC3")]
		[Address(RVA = "0x3402360", Offset = "0x3400960", VA = "0x183402360")]
		private void RemoveHelicopterActor()
		{
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC4")]
		[Address(RVA = "0x3402450", Offset = "0x3400A50", VA = "0x183402450")]
		private void HideHelicopterActor()
		{
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC5")]
		[Address(RVA = "0x3402570", Offset = "0x3400B70", VA = "0x183402570")]
		public void StopHelicopterEngineAudio()
		{
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC6")]
		[Address(RVA = "0x34025B0", Offset = "0x3400BB0", VA = "0x1834025B0")]
		public void StopRainAudio()
		{
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC7")]
		[Address(RVA = "0x34025E0", Offset = "0x3400BE0", VA = "0x1834025E0")]
		public void TrySpawnRobby()
		{
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC8")]
		[Address(RVA = "0x3402960", Offset = "0x3400F60", VA = "0x183402960")]
		public void ScaleHackHelicopter()
		{
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC9")]
		[Address(RVA = "0x3402A00", Offset = "0x3401000", VA = "0x183402A00")]
		private IEnumerator ScaleHack()
		{
			return null;
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACA")]
		[Address(RVA = "0x3402A90", Offset = "0x3401090", VA = "0x183402A90")]
		protected CrashCutsceneBase()
		{
		}

		// Token: 0x040025E2 RID: 9698
		[Token(Token = "0x40025E2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _saveId;

		// Token: 0x040025E3 RID: 9699
		[Token(Token = "0x40025E3")]
		[FieldOffset(Offset = "0xB8")]
		[FormerlySerializedAs("_fadeToBlack")]
		[SerializeField]
		protected FadeToBlack _cutSceneFadeToBlack;

		// Token: 0x040025E4 RID: 9700
		[Token(Token = "0x40025E4")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[FormerlySerializedAs("_crashLocation")]
		protected Transform _playerSpawnLocation;

		// Token: 0x040025E5 RID: 9701
		[Token(Token = "0x40025E5")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		protected GameObject _helicopterActorGameObject;

		// Token: 0x040025E6 RID: 9702
		[Token(Token = "0x40025E6")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private bool _hideHelicopterActor;

		// Token: 0x040025E7 RID: 9703
		[Token(Token = "0x40025E7")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		protected Transform _helicopterSpawnLocation;

		// Token: 0x040025E8 RID: 9704
		[Token(Token = "0x40025E8")]
		[FieldOffset(Offset = "0xE0")]
		[FormerlySerializedAs("CrashedHelicopterGo")]
		[SerializeField]
		protected GameObject _crashedHelicopterGo;

		// Token: 0x040025E9 RID: 9705
		[Token(Token = "0x40025E9")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		protected bool _disableFireSpreadForCrashSite;

		// Token: 0x040025EA RID: 9706
		[Token(Token = "0x40025EA")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _placedPickups;

		// Token: 0x040025EB RID: 9707
		[Token(Token = "0x40025EB")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Transform _robbySpawnLocation;

		// Token: 0x040025EC RID: 9708
		[Token(Token = "0x40025EC")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _playerProxyRoot;

		// Token: 0x040025ED RID: 9709
		[Token(Token = "0x40025ED")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private FMOD_StudioEventEmitter _rainAudioEmitter;

		// Token: 0x040025EE RID: 9710
		[Token(Token = "0x40025EE")]
		[FieldOffset(Offset = "0x110")]
		[FormerlySerializedAs("_playerAnimator")]
		[SerializeField]
		private Animator _playerProxyAnimator;

		// Token: 0x040025EF RID: 9711
		[Token(Token = "0x40025EF")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _badGuyGameObject;

		// Token: 0x040025F0 RID: 9712
		[Token(Token = "0x40025F0")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private FMOD_StudioEventEmitter _helicopterAudioEmitter;

		// Token: 0x040025F1 RID: 9713
		[Token(Token = "0x40025F1")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected Transform _scaleHackModel;

		// Token: 0x040025F2 RID: 9714
		[Token(Token = "0x40025F2")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected float _scaleHackStartingScale;

		// Token: 0x040025F3 RID: 9715
		[Token(Token = "0x40025F3")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		private float _scaleHackAmount;

		// Token: 0x040025F4 RID: 9716
		[Token(Token = "0x40025F4")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private float _scaleHackTargetScale;

		// Token: 0x040025F5 RID: 9717
		[Token(Token = "0x40025F5")]
		[FieldOffset(Offset = "0x140")]
		private Coroutine _waitForPlayerProxyOrSkipCoroutine;

		// Token: 0x040025F6 RID: 9718
		[Token(Token = "0x40025F6")]
		[FieldOffset(Offset = "0x148")]
		private FadeToBlack _playerFadeToBlackCached;

		// Token: 0x040025F7 RID: 9719
		[Token(Token = "0x40025F7")]
		[FieldOffset(Offset = "0x150")]
		private bool _skipToBadGuyIntro;

		// Token: 0x040025F8 RID: 9720
		[Token(Token = "0x40025F8")]
		[FieldOffset(Offset = "0x151")]
		private bool _skipToFinalize;

		// Token: 0x040025F9 RID: 9721
		[Token(Token = "0x40025F9")]
		[FieldOffset(Offset = "0x154")]
		public float OpenInventoryTutorialRange;

		// Token: 0x040025FA RID: 9722
		[Token(Token = "0x40025FA")]
		[FieldOffset(Offset = "0x158")]
		public float CutToBlackScreenDelay;

		// Token: 0x040025FB RID: 9723
		[Token(Token = "0x40025FB")]
		[FieldOffset(Offset = "0x15C")]
		private bool _spawnedPickups;

		// Token: 0x040025FC RID: 9724
		[Token(Token = "0x40025FC")]
		[FieldOffset(Offset = "0x15D")]
		private bool _robbySpawned;

		// Token: 0x040025FD RID: 9725
		[Token(Token = "0x40025FD")]
		[FieldOffset(Offset = "0x160")]
		private float _badGuyIntroKnockoutTime;

		// Token: 0x040025FE RID: 9726
		[Token(Token = "0x40025FE")]
		[FieldOffset(Offset = "0x168")]
		private Coroutine _badGuyIntroCoroutine;

		// Token: 0x040025FF RID: 9727
		[Token(Token = "0x40025FF")]
		[FieldOffset(Offset = "0x170")]
		private CrashCutsceneState _state;

		// Token: 0x04002600 RID: 9728
		[Token(Token = "0x4002600")]
		[FieldOffset(Offset = "0x178")]
		private Camera _cutSceneCamera;

		// Token: 0x04002601 RID: 9729
		[Token(Token = "0x4002601")]
		[FieldOffset(Offset = "0x180")]
		private Coroutine _waitForPlayerProxyAnimationsCoroutine;

		// Token: 0x04002602 RID: 9730
		[Token(Token = "0x4002602")]
		[FieldOffset(Offset = "0x188")]
		private Coroutine _crashWakeUpCoroutine;
	}
}
