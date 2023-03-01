using System;
using System.Collections;
using System.Collections.Generic;
using Assemblies.Sons.Cinematics;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x0200077A RID: 1914
	[Token(Token = "0x200077A")]
	public class OpeningCutscene : Cutscene, IQuitHandler
	{
		// Token: 0x06003246 RID: 12870 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		[Token(Token = "0x6003246")]
		[Address(RVA = "0x2E4ACE0", Offset = "0x2E49CE0", VA = "0x182E4ACE0")]
		public static int GetCrashIndex()
		{
			return default(int);
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003247")]
		[Address(RVA = "0x2E4B3A0", Offset = "0x2E4A3A0", VA = "0x182E4B3A0")]
		private static void InitializeRandom()
		{
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003248")]
		[Address(RVA = "0x2E4B540", Offset = "0x2E4A540", VA = "0x182E4B540", Slot = "15")]
		public void OnQuit()
		{
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003249")]
		[Address(RVA = "0x2E4B080", Offset = "0x2E4A080", VA = "0x182E4B080", Slot = "6")]
		internal override void InitializeHook()
		{
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600324A")]
		[Address(RVA = "0x2E4B800", Offset = "0x2E4A800", VA = "0x182E4B800", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600324B")]
		[Address(RVA = "0x2E4C2E0", Offset = "0x2E4B2E0", VA = "0x182E4C2E0")]
		private IEnumerator SetupPilotActor()
		{
			return null;
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600324C")]
		[Address(RVA = "0x2E4C8B0", Offset = "0x2E4B8B0", VA = "0x182E4C8B0")]
		public void TriggerOpeningCutscene()
		{
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600324D")]
		[Address(RVA = "0x2E4BDF0", Offset = "0x2E4ADF0", VA = "0x182E4BDF0")]
		private void RaiseTheCurtain()
		{
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600324E")]
		[Address(RVA = "0x2E4C9F0", Offset = "0x2E4B9F0", VA = "0x182E4C9F0")]
		private void Update()
		{
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600324F")]
		[Address(RVA = "0x2E4AA80", Offset = "0x2E49A80", VA = "0x182E4AA80", Slot = "13")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003250")]
		[Address(RVA = "0x2E4B730", Offset = "0x2E4A730", VA = "0x182E4B730", Slot = "8")]
		protected override void PostOnDestroyHook()
		{
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003251")]
		[Address(RVA = "0x2E4B610", Offset = "0x2E4A610", VA = "0x182E4B610", Slot = "5")]
		internal override void OnValidate()
		{
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003252")]
		[Address(RVA = "0x2E4C350", Offset = "0x2E4B350", VA = "0x182E4C350")]
		public void StartCrashSequence()
		{
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003253")]
		[Address(RVA = "0x2E4B0D0", Offset = "0x2E4A0D0", VA = "0x182E4B0D0")]
		private void InitializeRainDropMaterials()
		{
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003254")]
		[Address(RVA = "0x2E4C180", Offset = "0x2E4B180", VA = "0x182E4C180")]
		private void SetRainDropMaterial(float amount)
		{
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003255")]
		[Address(RVA = "0x2E4C640", Offset = "0x2E4B640", VA = "0x182E4C640")]
		public void TransitionToCrashCutscene()
		{
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003256")]
		[Address(RVA = "0x2E4AC70", Offset = "0x2E49C70", VA = "0x182E4AC70")]
		public void ForceCrashScene(string crashSceneName)
		{
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003257")]
		[Address(RVA = "0x2E4BFA0", Offset = "0x2E4AFA0", VA = "0x182E4BFA0")]
		public static void RegisterCrashIndexChanged(Action<int> action)
		{
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003258")]
		[Address(RVA = "0x2E4C8E0", Offset = "0x2E4B8E0", VA = "0x182E4C8E0")]
		public static void UnregisterCrashIndexChanged(Action<int> action)
		{
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003259")]
		[Address(RVA = "0x2E4BDD0", Offset = "0x2E4ADD0", VA = "0x182E4BDD0")]
		private void QueueUpCrashScene()
		{
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325A")]
		[Address(RVA = "0x2E4AD30", Offset = "0x2E49D30", VA = "0x182E4AD30")]
		private string GetCutsceneName()
		{
			return null;
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600325B")]
		[Address(RVA = "0x2E4C120", Offset = "0x2E4B120", VA = "0x182E4C120")]
		public static void SetCrashIndexOverride(int value)
		{
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600325C")]
		[Address(RVA = "0x2E4B4A0", Offset = "0x2E4A4A0", VA = "0x182E4B4A0")]
		public static void OnLoadedCrashIndex(int loadedCrashIndex)
		{
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x0000E610 File Offset: 0x0000C810
		[Token(Token = "0x600325D")]
		[Address(RVA = "0x2E4BE20", Offset = "0x2E4AE20", VA = "0x182E4BE20")]
		public static int RefreshCrashIndex()
		{
			return default(int);
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600325E")]
		[Address(RVA = "0x2E4A930", Offset = "0x2E49930", VA = "0x182E4A930")]
		private void CleanUpRainDropMaterials()
		{
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600325F")]
		[Address(RVA = "0x2E4AB40", Offset = "0x2E49B40", VA = "0x182E4AB40")]
		private void EnableHelicopterRotate()
		{
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003260")]
		[Address(RVA = "0x2E4C4B0", Offset = "0x2E4B4B0", VA = "0x182E4C4B0")]
		public void StartManoeuvre()
		{
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003261")]
		[Address(RVA = "0x2E4ABE0", Offset = "0x2E49BE0", VA = "0x182E4ABE0")]
		public void EndManoeuvre()
		{
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003262")]
		[Address(RVA = "0x2E4AAD0", Offset = "0x2E49AD0", VA = "0x182E4AAD0")]
		private IEnumerator DelayRainDrops()
		{
			return null;
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003263")]
		[Address(RVA = "0x2E4CB00", Offset = "0x2E4BB00", VA = "0x182E4CB00")]
		private IEnumerator WeatherWorker()
		{
			return null;
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003264")]
		[Address(RVA = "0x2E4C7A0", Offset = "0x2E4B7A0", VA = "0x182E4C7A0")]
		public void TriggerHelicopterCrashAudio()
		{
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003265")]
		[Address(RVA = "0x2E4C720", Offset = "0x2E4B720", VA = "0x182E4C720")]
		public void TriggerBulletHitA()
		{
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003266")]
		[Address(RVA = "0x2E4C760", Offset = "0x2E4B760", VA = "0x182E4C760")]
		public void TriggerBulletHitB()
		{
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003267")]
		[Address(RVA = "0x2E4C0B0", Offset = "0x2E4B0B0", VA = "0x182E4C0B0")]
		public static void SetCrashAliasOverride(string crashAliasOverride)
		{
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003268")]
		[Address(RVA = "0x2E4CC00", Offset = "0x2E4BC00", VA = "0x182E4CC00")]
		public OpeningCutscene()
		{
		}

		// Token: 0x04002BD2 RID: 11218
		[Token(Token = "0x4002BD2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _rainAmount;

		// Token: 0x04002BD3 RID: 11219
		[Token(Token = "0x4002BD3")]
		private const string OverrideCrashCutsceneNameKey = "OpeningCutscene.OverrideCrash";

		// Token: 0x04002BD4 RID: 11220
		[Token(Token = "0x4002BD4")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _rootObject;

		// Token: 0x04002BD5 RID: 11221
		[Token(Token = "0x4002BD5")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private FadeToBlack _fadeToBlack;

		// Token: 0x04002BD6 RID: 11222
		[Token(Token = "0x4002BD6")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _initialBlackScreenLength;

		// Token: 0x04002BD7 RID: 11223
		[Token(Token = "0x4002BD7")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject HelicoptersCutSceneGo;

		// Token: 0x04002BD8 RID: 11224
		[Token(Token = "0x4002BD8")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject HelicopterACutSceneGo;

		// Token: 0x04002BD9 RID: 11225
		[Token(Token = "0x4002BD9")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject CrashFXGo;

		// Token: 0x04002BDA RID: 11226
		[Token(Token = "0x4002BDA")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject[] Clouds;

		// Token: 0x04002BDB RID: 11227
		[Token(Token = "0x4002BDB")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[HideInInspector]
		private GameObject _cloudsWorldGo;

		// Token: 0x04002BDC RID: 11228
		[Token(Token = "0x4002BDC")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Camera _cutSceneCamera;

		// Token: 0x04002BDD RID: 11229
		[Token(Token = "0x4002BDD")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Animator _playerAnimator;

		// Token: 0x04002BDE RID: 11230
		[Token(Token = "0x4002BDE")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Animator _tacti1Animator;

		// Token: 0x04002BDF RID: 11231
		[Token(Token = "0x4002BDF")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Animator _tacti2Animator;

		// Token: 0x04002BE0 RID: 11232
		[Token(Token = "0x4002BE0")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Animator _pilotAnimator;

		// Token: 0x04002BE1 RID: 11233
		[Token(Token = "0x4002BE1")]
		[FieldOffset(Offset = "0x118")]
		[HideInInspector]
		[SerializeField]
		private Animator _helicopterAnimator;

		// Token: 0x04002BE2 RID: 11234
		[Token(Token = "0x4002BE2")]
		[FieldOffset(Offset = "0x120")]
		public float WaitForHelicopterRotationDelay;

		// Token: 0x04002BE3 RID: 11235
		[Token(Token = "0x4002BE3")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private bool RandomizeStartPosition;

		// Token: 0x04002BE4 RID: 11236
		[Token(Token = "0x4002BE4")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Material _rainDropMaterial;

		// Token: 0x04002BE5 RID: 11237
		[Token(Token = "0x4002BE5")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<GameObject> _helicopterCrashCutscenes;

		// Token: 0x04002BE6 RID: 11238
		[Token(Token = "0x4002BE6")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private bool _forceSpecificCrashScene;

		// Token: 0x04002BE7 RID: 11239
		[Token(Token = "0x4002BE7")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private string _forcedCrashScene;

		// Token: 0x04002BE8 RID: 11240
		[Token(Token = "0x4002BE8")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private GameObject _rainObject;

		// Token: 0x04002BE9 RID: 11241
		[Token(Token = "0x4002BE9")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private float _rainDropDelay;

		// Token: 0x04002BEA RID: 11242
		[Token(Token = "0x4002BEA")]
		[FieldOffset(Offset = "0x154")]
		[SerializeField]
		private float _weatherDelay;

		// Token: 0x04002BEB RID: 11243
		[Token(Token = "0x4002BEB")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private float _pilotTalkDelay;

		// Token: 0x04002BEC RID: 11244
		[Token(Token = "0x4002BEC")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private IntroAudioController _introAudio;

		// Token: 0x04002BED RID: 11245
		[Token(Token = "0x4002BED")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private GameObject _glassOrig;

		// Token: 0x04002BEE RID: 11246
		[Token(Token = "0x4002BEE")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject _glassHitA;

		// Token: 0x04002BEF RID: 11247
		[Token(Token = "0x4002BEF")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private GameObject _glassHitB;

		// Token: 0x04002BF0 RID: 11248
		[Token(Token = "0x4002BF0")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private IntroLaptopController _laptopController;

		// Token: 0x04002BF1 RID: 11249
		[Token(Token = "0x4002BF1")]
		[FieldOffset(Offset = "0x188")]
		private List<Material> _instancedRainDropMaterials;

		// Token: 0x04002BF2 RID: 11250
		[Token(Token = "0x4002BF2")]
		[FieldOffset(Offset = "0x190")]
		private float _rainDropAmountCurrent;

		// Token: 0x04002BF3 RID: 11251
		[Token(Token = "0x4002BF3")]
		[FieldOffset(Offset = "0x194")]
		private float _rainDropAmountGoal;

		// Token: 0x04002BF4 RID: 11252
		[Token(Token = "0x4002BF4")]
		[FieldOffset(Offset = "0x198")]
		private bool _resetMouseRange;

		// Token: 0x04002BF5 RID: 11253
		[Token(Token = "0x4002BF5")]
		[FieldOffset(Offset = "0x19C")]
		private float _waitTime;

		// Token: 0x04002BF6 RID: 11254
		[Token(Token = "0x4002BF6")]
		[FieldOffset(Offset = "0x1A0")]
		private bool _cutsceneHasBeenTriggered;

		// Token: 0x04002BF7 RID: 11255
		[Token(Token = "0x4002BF7")]
		[FieldOffset(Offset = "0x8")]
		private static Random _sysRandom;

		// Token: 0x04002BF8 RID: 11256
		[Token(Token = "0x4002BF8")]
		[FieldOffset(Offset = "0x10")]
		private static int _randomCrashIndex;

		// Token: 0x04002BF9 RID: 11257
		[Token(Token = "0x4002BF9")]
		[FieldOffset(Offset = "0x14")]
		private static int _previousRandomCrashIndex;

		// Token: 0x04002BFA RID: 11258
		[Token(Token = "0x4002BFA")]
		[FieldOffset(Offset = "0x18")]
		private static Action<int> _onCrashIndexChanged;

		// Token: 0x04002BFB RID: 11259
		[Token(Token = "0x4002BFB")]
		[FieldOffset(Offset = "0x20")]
		private static int _overrideCrashIndex;

		// Token: 0x04002BFC RID: 11260
		[Token(Token = "0x4002BFC")]
		[FieldOffset(Offset = "0x28")]
		private static string _crashAliasOverride;

		// Token: 0x04002BFD RID: 11261
		[Token(Token = "0x4002BFD")]
		[FieldOffset(Offset = "0x1A8")]
		private Coroutine _pilotTalkWorker;

		// Token: 0x04002BFE RID: 11262
		[Token(Token = "0x4002BFE")]
		private const int CrashCutsceneCount = 3;
	}
}
