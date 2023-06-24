using System;
using System.Collections;
using System.Collections.Generic;
using Assemblies.Sons.Cinematics;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x02000685 RID: 1669
	[Token(Token = "0x2000685")]
	public class OpeningCutscene : Cutscene
	{
		// Token: 0x06002BBD RID: 11197 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		[Token(Token = "0x6002BBD")]
		[Address(RVA = "0x3415750", Offset = "0x3413D50", VA = "0x183415750")]
		public static int GetCrashIndex()
		{
			return 0;
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BBE")]
		[Address(RVA = "0x34157A0", Offset = "0x3413DA0", VA = "0x1834157A0")]
		private static void InitializeRandom()
		{
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BBF")]
		[Address(RVA = "0x3415890", Offset = "0x3413E90", VA = "0x183415890")]
		private static void OnQuit()
		{
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC0")]
		[Address(RVA = "0x34159D0", Offset = "0x3413FD0", VA = "0x1834159D0", Slot = "6")]
		internal override void InitializeHook()
		{
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC1")]
		[Address(RVA = "0x3415A60", Offset = "0x3414060", VA = "0x183415A60", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC2")]
		[Address(RVA = "0x34163C0", Offset = "0x34149C0", VA = "0x1834163C0")]
		private IEnumerator SetupPilotActor()
		{
			return null;
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC3")]
		[Address(RVA = "0x3416450", Offset = "0x3414A50", VA = "0x183416450")]
		public void TriggerOpeningCutscene()
		{
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC4")]
		[Address(RVA = "0x34164B0", Offset = "0x3414AB0", VA = "0x1834164B0")]
		private void RaiseTheCurtain()
		{
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC5")]
		[Address(RVA = "0x34164E0", Offset = "0x3414AE0", VA = "0x1834164E0")]
		private void Update()
		{
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC6")]
		[Address(RVA = "0x3416720", Offset = "0x3414D20", VA = "0x183416720", Slot = "13")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC7")]
		[Address(RVA = "0x34167B0", Offset = "0x3414DB0", VA = "0x1834167B0", Slot = "8")]
		protected override void PostOnDestroyHook()
		{
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC8")]
		[Address(RVA = "0x34168F0", Offset = "0x3414EF0", VA = "0x1834168F0", Slot = "5")]
		internal override void OnValidate()
		{
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC9")]
		[Address(RVA = "0x3416B90", Offset = "0x3415190", VA = "0x183416B90")]
		public void StartCrashSequence()
		{
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCA")]
		[Address(RVA = "0x3416DF0", Offset = "0x34153F0", VA = "0x183416DF0")]
		private void InitializeRainDropMaterials()
		{
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCB")]
		[Address(RVA = "0x3417260", Offset = "0x3415860", VA = "0x183417260")]
		private void SetRainDropMaterial(float amount)
		{
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCC")]
		[Address(RVA = "0x3417420", Offset = "0x3415A20", VA = "0x183417420")]
		public void TransitionToCrashCutscene()
		{
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCD")]
		[Address(RVA = "0x34175D0", Offset = "0x3415BD0", VA = "0x1834175D0")]
		public void ForceCrashScene(string crashSceneName)
		{
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCE")]
		[Address(RVA = "0x34176A0", Offset = "0x3415CA0", VA = "0x1834176A0")]
		public static void RegisterCrashIndexChanged(Action<int> action)
		{
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCF")]
		[Address(RVA = "0x34177F0", Offset = "0x3415DF0", VA = "0x1834177F0")]
		public static void UnregisterCrashIndexChanged(Action<int> action)
		{
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD0")]
		[Address(RVA = "0x3417940", Offset = "0x3415F40", VA = "0x183417940")]
		private void QueueUpCrashScene()
		{
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD1")]
		[Address(RVA = "0x3417960", Offset = "0x3415F60", VA = "0x183417960")]
		private string GetCutsceneName()
		{
			return null;
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD2")]
		[Address(RVA = "0x3417BA0", Offset = "0x34161A0", VA = "0x183417BA0")]
		public static void SetCrashIndexOverride(int value)
		{
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD3")]
		[Address(RVA = "0x3417C00", Offset = "0x3416200", VA = "0x183417C00")]
		public static void OnLoadedCrashIndex(int loadedCrashIndex)
		{
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		[Token(Token = "0x6002BD4")]
		[Address(RVA = "0x3417CA0", Offset = "0x34162A0", VA = "0x183417CA0")]
		public static int RefreshCrashIndex()
		{
			return 0;
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD5")]
		[Address(RVA = "0x3417E20", Offset = "0x3416420", VA = "0x183417E20")]
		private void CleanUpRainDropMaterials()
		{
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD6")]
		[Address(RVA = "0x3418010", Offset = "0x3416610", VA = "0x183418010")]
		private void EnableHelicopterRotate()
		{
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD7")]
		[Address(RVA = "0x3418180", Offset = "0x3416780", VA = "0x183418180")]
		public void StartManoeuvre()
		{
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD8")]
		[Address(RVA = "0x34183E0", Offset = "0x34169E0", VA = "0x1834183E0")]
		public void EndManoeuvre()
		{
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0x34184D0", Offset = "0x3416AD0", VA = "0x1834184D0")]
		private IEnumerator DelayRainDrops()
		{
			return null;
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BDA")]
		[Address(RVA = "0x3418560", Offset = "0x3416B60", VA = "0x183418560")]
		private IEnumerator WeatherWorker()
		{
			return null;
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDB")]
		[Address(RVA = "0x34185F0", Offset = "0x3416BF0", VA = "0x1834185F0")]
		public void TriggerHelicopterCrashAudio()
		{
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDC")]
		[Address(RVA = "0x3418670", Offset = "0x3416C70", VA = "0x183418670")]
		public void TriggerBulletHitA()
		{
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDD")]
		[Address(RVA = "0x3418730", Offset = "0x3416D30", VA = "0x183418730")]
		public void TriggerBulletHitB()
		{
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDE")]
		[Address(RVA = "0x34187F0", Offset = "0x3416DF0", VA = "0x1834187F0")]
		public static void SetCrashAliasOverride(string crashAliasOverride)
		{
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDF")]
		[Address(RVA = "0x34188A0", Offset = "0x3416EA0", VA = "0x1834188A0")]
		public OpeningCutscene()
		{
		}

		// Token: 0x040026A5 RID: 9893
		[Token(Token = "0x40026A5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _rainAmount;

		// Token: 0x040026A6 RID: 9894
		[Token(Token = "0x40026A6")]
		private const string OverrideCrashCutsceneNameKey = "OpeningCutscene.OverrideCrash";

		// Token: 0x040026A7 RID: 9895
		[Token(Token = "0x40026A7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _rootObject;

		// Token: 0x040026A8 RID: 9896
		[Token(Token = "0x40026A8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private FadeToBlack _fadeToBlack;

		// Token: 0x040026A9 RID: 9897
		[Token(Token = "0x40026A9")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _initialBlackScreenLength;

		// Token: 0x040026AA RID: 9898
		[Token(Token = "0x40026AA")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject HelicoptersCutSceneGo;

		// Token: 0x040026AB RID: 9899
		[Token(Token = "0x40026AB")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject HelicopterACutSceneGo;

		// Token: 0x040026AC RID: 9900
		[Token(Token = "0x40026AC")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject CrashFXGo;

		// Token: 0x040026AD RID: 9901
		[Token(Token = "0x40026AD")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject[] Clouds;

		// Token: 0x040026AE RID: 9902
		[Token(Token = "0x40026AE")]
		[FieldOffset(Offset = "0xE8")]
		[HideInInspector]
		[SerializeField]
		private GameObject _cloudsWorldGo;

		// Token: 0x040026AF RID: 9903
		[Token(Token = "0x40026AF")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Camera _cutSceneCamera;

		// Token: 0x040026B0 RID: 9904
		[Token(Token = "0x40026B0")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Animator _playerAnimator;

		// Token: 0x040026B1 RID: 9905
		[Token(Token = "0x40026B1")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Animator _tacti1Animator;

		// Token: 0x040026B2 RID: 9906
		[Token(Token = "0x40026B2")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Animator _tacti2Animator;

		// Token: 0x040026B3 RID: 9907
		[Token(Token = "0x40026B3")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Animator _pilotAnimator;

		// Token: 0x040026B4 RID: 9908
		[Token(Token = "0x40026B4")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		private Animator _helicopterAnimator;

		// Token: 0x040026B5 RID: 9909
		[Token(Token = "0x40026B5")]
		[FieldOffset(Offset = "0x120")]
		public float WaitForHelicopterRotationDelay;

		// Token: 0x040026B6 RID: 9910
		[Token(Token = "0x40026B6")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private bool RandomizeStartPosition;

		// Token: 0x040026B7 RID: 9911
		[Token(Token = "0x40026B7")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Material _rainDropMaterial;

		// Token: 0x040026B8 RID: 9912
		[Token(Token = "0x40026B8")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<GameObject> _helicopterCrashCutscenes;

		// Token: 0x040026B9 RID: 9913
		[Token(Token = "0x40026B9")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private bool _forceSpecificCrashScene;

		// Token: 0x040026BA RID: 9914
		[Token(Token = "0x40026BA")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private string _forcedCrashScene;

		// Token: 0x040026BB RID: 9915
		[Token(Token = "0x40026BB")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private GameObject _rainObject;

		// Token: 0x040026BC RID: 9916
		[Token(Token = "0x40026BC")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private float _rainDropDelay;

		// Token: 0x040026BD RID: 9917
		[Token(Token = "0x40026BD")]
		[FieldOffset(Offset = "0x154")]
		[SerializeField]
		private float _weatherDelay;

		// Token: 0x040026BE RID: 9918
		[Token(Token = "0x40026BE")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private float _pilotTalkDelay;

		// Token: 0x040026BF RID: 9919
		[Token(Token = "0x40026BF")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private IntroAudioController _introAudio;

		// Token: 0x040026C0 RID: 9920
		[Token(Token = "0x40026C0")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private GameObject _glassOrig;

		// Token: 0x040026C1 RID: 9921
		[Token(Token = "0x40026C1")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject _glassHitA;

		// Token: 0x040026C2 RID: 9922
		[Token(Token = "0x40026C2")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private GameObject _glassHitB;

		// Token: 0x040026C3 RID: 9923
		[Token(Token = "0x40026C3")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private IntroLaptopController _laptopController;

		// Token: 0x040026C4 RID: 9924
		[Token(Token = "0x40026C4")]
		[FieldOffset(Offset = "0x188")]
		private List<Material> _instancedRainDropMaterials;

		// Token: 0x040026C5 RID: 9925
		[Token(Token = "0x40026C5")]
		[FieldOffset(Offset = "0x190")]
		private float _rainDropAmountCurrent;

		// Token: 0x040026C6 RID: 9926
		[Token(Token = "0x40026C6")]
		[FieldOffset(Offset = "0x194")]
		private float _rainDropAmountGoal;

		// Token: 0x040026C7 RID: 9927
		[Token(Token = "0x40026C7")]
		[FieldOffset(Offset = "0x198")]
		private bool _resetMouseRange;

		// Token: 0x040026C8 RID: 9928
		[Token(Token = "0x40026C8")]
		[FieldOffset(Offset = "0x19C")]
		private float _waitTime;

		// Token: 0x040026C9 RID: 9929
		[Token(Token = "0x40026C9")]
		[FieldOffset(Offset = "0x1A0")]
		private bool _cutsceneHasBeenTriggered;

		// Token: 0x040026CA RID: 9930
		[Token(Token = "0x40026CA")]
		[FieldOffset(Offset = "0x8")]
		private static System.Random _sysRandom;

		// Token: 0x040026CB RID: 9931
		[Token(Token = "0x40026CB")]
		[FieldOffset(Offset = "0x10")]
		private static int _randomCrashIndex;

		// Token: 0x040026CC RID: 9932
		[Token(Token = "0x40026CC")]
		[FieldOffset(Offset = "0x14")]
		private static int _previousRandomCrashIndex;

		// Token: 0x040026CD RID: 9933
		[Token(Token = "0x40026CD")]
		[FieldOffset(Offset = "0x18")]
		private static Action<int> _onCrashIndexChanged;

		// Token: 0x040026CE RID: 9934
		[Token(Token = "0x40026CE")]
		[FieldOffset(Offset = "0x20")]
		private static int _overrideCrashIndex;

		// Token: 0x040026CF RID: 9935
		[Token(Token = "0x40026CF")]
		[FieldOffset(Offset = "0x28")]
		private static string _crashAliasOverride;

		// Token: 0x040026D0 RID: 9936
		[Token(Token = "0x40026D0")]
		[FieldOffset(Offset = "0x1A8")]
		private Coroutine _pilotTalkWorker;

		// Token: 0x040026D1 RID: 9937
		[Token(Token = "0x40026D1")]
		private const int CrashCutsceneCount = 3;
	}
}
