using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sons.Loading
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class LoadScene : MonoBehaviour
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		private event Action _onComplete
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x30B2F60", Offset = "0x30B1560", VA = "0x1830B2F60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x30B3050", Offset = "0x30B1650", VA = "0x1830B3050")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x30B3140", Offset = "0x30B1740", VA = "0x1830B3140")]
		public static bool IsMainSceneLoadComplete()
		{
			return default(bool);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x17000001")]
		public static bool IsLoading
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x30B3180", Offset = "0x30B1780", VA = "0x1830B3180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
		private IReadOnlyList<string> GetSceneNames()
		{
			return null;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x17000002")]
		private float CurrentTime
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x30B31C0", Offset = "0x30B17C0", VA = "0x1830B31C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x17000003")]
		private bool ShowLoadSceneMode
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x30B3250", Offset = "0x30B1850", VA = "0x1830B3250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x17000004")]
		private int SceneCount
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x30B32A0", Offset = "0x30B18A0", VA = "0x1830B32A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x30B32E0", Offset = "0x30B18E0", VA = "0x1830B32E0")]
		private void VerifySceneNames()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x30B3A30", Offset = "0x30B2030", VA = "0x1830B3A30")]
		private void Update()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x30B3E70", Offset = "0x30B2470", VA = "0x1830B3E70")]
		private void LoadSync()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x30B4210", Offset = "0x30B2810", VA = "0x1830B4210")]
		private void CheckFinalizeExclusiveSingle()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x30B43C0", Offset = "0x30B29C0", VA = "0x1830B43C0")]
		private void LoadScenes()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x30B45B0", Offset = "0x30B2BB0", VA = "0x1830B45B0")]
		private void UpdateSceneLoadProgress()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x30B47D0", Offset = "0x30B2DD0", VA = "0x1830B47D0")]
		private AsyncOperation StartLoadAsync(string sceneName)
		{
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x30B4B50", Offset = "0x30B3150", VA = "0x1830B4B50")]
		private void SetupLoadLists()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x30B4F50", Offset = "0x30B3550", VA = "0x1830B4F50")]
		private void LoadExclusiveSingle()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x30B50F0", Offset = "0x30B36F0", VA = "0x1830B50F0")]
		private bool IsExclusiveSingleMode()
		{
			return default(bool);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x30B5140", Offset = "0x30B3740", VA = "0x1830B5140")]
		private bool DelayPassed()
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x30B5180", Offset = "0x30B3780", VA = "0x1830B5180")]
		private void ProtectHandOffGameObjects()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x30B5450", Offset = "0x30B3A50", VA = "0x1830B5450")]
		private void MoveHandOffGameObjects(Scene scene)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x30B56F0", Offset = "0x30B3CF0", VA = "0x1830B56F0")]
		private void UpdateFinalize()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x30B5BE0", Offset = "0x30B41E0", VA = "0x1830B5BE0")]
		private void OnTetrahedralizationCompleted()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x30B5C30", Offset = "0x30B4230", VA = "0x1830B5C30")]
		private bool WaitForCleanupDelay()
		{
			return default(bool);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x30B5C90", Offset = "0x30B4290", VA = "0x1830B5C90")]
		private void UpdatePreload()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x30B5DB0", Offset = "0x30B43B0", VA = "0x1830B5DB0")]
		public void DoLoad()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x30B5DC0", Offset = "0x30B43C0", VA = "0x1830B5DC0")]
		public void DoLoadInstant()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x30B5DD0", Offset = "0x30B43D0", VA = "0x1830B5DD0")]
		private void Initialize()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x30B62C0", Offset = "0x30B48C0", VA = "0x1830B62C0")]
		private void RemoveScenesByName(ref List<string> sceneNamesCache, List<string> getScenesToRemove)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x30B6470", Offset = "0x30B4A70", VA = "0x1830B6470")]
		private static List<string> GetScenesToRemove()
		{
			return null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x30B6670", Offset = "0x30B4C70", VA = "0x1830B6670")]
		private string GetSetId()
		{
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x30B66E0", Offset = "0x30B4CE0", VA = "0x1830B66E0")]
		private void DisableObjects()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x30B6AC0", Offset = "0x30B50C0", VA = "0x1830B6AC0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x30B6AD0", Offset = "0x30B50D0", VA = "0x1830B6AD0")]
		private void SetCompleted()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x30B6DF0", Offset = "0x30B53F0", VA = "0x1830B6DF0")]
		public static void SetCompleted(LoadSceneChecker checker)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x30B6F40", Offset = "0x30B5540", VA = "0x1830B6F40")]
		private void UpdateProgressIndicator()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x30B7190", Offset = "0x30B5790", VA = "0x1830B7190")]
		private void UpdateProgressInfo(string message)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x30B73A0", Offset = "0x30B59A0", VA = "0x1830B73A0")]
		public void Unregister(ISceneLoadingListener listener)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x30B74B0", Offset = "0x30B5AB0", VA = "0x1830B74B0")]
		public void Register(ISceneLoadingListener listener)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x30B2F60", Offset = "0x30B1560", VA = "0x1830B2F60")]
		public void RegisterOnComplete(Action action)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x30B7600", Offset = "0x30B5C00", VA = "0x1830B7600")]
		public LoadScene()
		{
		}

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		private const string DefaultSceneListKey = "Default";

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		private const string MainSceneListSettingsKey = "Loading.MainSceneListId";

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		private const string SceneListRemoveSettingsKey = "Loading.RemoveSceneList";

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isMainSceneLoad;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _useScaledTime;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _delay;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _cleanupDelay;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _automatic;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x30")]
		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private string _scene;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<string> _scenes;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _sceneListSettingsKey;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<NamedSceneList> _sceneSets;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LoadSceneMode _mode;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<GameObject> _disableGameObjects;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<GameObject> _handOffGameObjects;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<MonoBehaviour> _disableMonoBehaviours;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x70")]
		private List<ISceneLoadingListener> _loadingListeners;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x78")]
		private float _totalSceneLoadProgressPercent;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x7C")]
		private float _totalProgressPercent;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x80")]
		private List<float> _progressPercent;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x88")]
		private bool _startLoadSequence;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x90")]
		private List<GameObject> _objectsToUnload;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x98")]
		private List<AsyncOperation> _loadSceneAsync;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0xA0")]
		private float _startTime;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0xA4")]
		private float _preloadCompleted;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0xA8")]
		private bool _initialized;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0xA9")]
		private bool _processedHandOffGameObjects;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0xAA")]
		private bool _singleLoadStarted;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0xAC")]
		private Scene _thisScene;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0xB0")]
		private float _cleanupDelayWaitStart;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0xB4")]
		private bool _startedTetrahedralizeAsync;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0xB8")]
		private NamedSceneList _activeSceneList;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0xC0")]
		private List<string> _sceneNamesCache;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0xC8")]
		private bool _finishedTetrahedralizeAsync;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0xC9")]
		private bool _doLoadTest;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x0")]
		private static bool _isLoading;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0xD0")]
		private ProfilerMarker _sceneLoadSyncMarker;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x1")]
		private static bool _isMainSceneLoadComplete;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0xD8")]
		private bool _pauseLoading;
	}
}
