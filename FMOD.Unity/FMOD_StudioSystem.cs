using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FMOD;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class FMOD_StudioSystem : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000002 RID: 2 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000001")]
	public static bool HasLoadedBanks
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xB07DB0", Offset = "0xB063B0", VA = "0x180B07DB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xB07E00", Offset = "0xB06400", VA = "0x180B07E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
	// (remove) Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x14000001")]
	public static event Action OnLoadedBanksCallback
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xB07E60", Offset = "0xB06460", VA = "0x180B07E60")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xB07FB0", Offset = "0xB065B0", VA = "0x180B07FB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000005")]
	[Address(RVA = "0xB08100", Offset = "0xB06700", VA = "0x180B08100")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void ClearStatics()
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000006")]
	[Address(RVA = "0xB081B0", Offset = "0xB067B0", VA = "0x180B081B0")]
	private static void UnloadBanks()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000007")]
	[Address(RVA = "0xB084B0", Offset = "0xB06AB0", VA = "0x180B084B0")]
	private void LoadBanks()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000008")]
	[Address(RVA = "0xB08730", Offset = "0xB06D30", VA = "0x180B08730")]
	private static void LoadBank(string path, out RESULT loadResult)
	{
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000009 RID: 9 RVA: 0x00002068 File Offset: 0x00000268
	[Token(Token = "0x17000002")]
	public FMOD.System CoreSystem
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		get
		{
			return default(FMOD.System);
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600000A RID: 10 RVA: 0x00002080 File Offset: 0x00000280
	// (set) Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000003")]
	public bool LiveUpdateEnabled
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x98F610", Offset = "0x98DC10", VA = "0x18098F610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x98F620", Offset = "0x98DC20", VA = "0x18098F620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600000C RID: 12 RVA: 0x00002098 File Offset: 0x00000298
	// (set) Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000004")]
	public static bool ForceFmodOff
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0xB08BA0", Offset = "0xB071A0", VA = "0x180B08BA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0xB08BF0", Offset = "0xB071F0", VA = "0x180B08BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600000E RID: 14 RVA: 0x000020B0 File Offset: 0x000002B0
	// (set) Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000005")]
	public static bool FmodDSClientOff
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0xB08C50", Offset = "0xB07250", VA = "0x180B08C50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0xB08CA0", Offset = "0xB072A0", VA = "0x180B08CA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000020C8 File Offset: 0x000002C8
	[Token(Token = "0x6000010")]
	[Address(RVA = "0xB08D00", Offset = "0xB07300", VA = "0x180B08D00")]
	public static int SetVoiceCount(int value)
	{
		return 0;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000020E0 File Offset: 0x000002E0
	[Token(Token = "0x6000011")]
	[Address(RVA = "0xB08D60", Offset = "0xB07360", VA = "0x180B08D60")]
	public static bool IsValid()
	{
		return default(bool);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000020F8 File Offset: 0x000002F8
	[Token(Token = "0x6000012")]
	[Address(RVA = "0xB08EC0", Offset = "0xB074C0", VA = "0x180B08EC0")]
	public static bool TryGetInstance(out FMOD_StudioSystem studioSystemInstance, bool createInstance = false)
	{
		return default(bool);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000013")]
	[Address(RVA = "0xB09410", Offset = "0xB07A10", VA = "0x180B09410")]
	private static void CleanUpExisting()
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000210E File Offset: 0x0000030E
	[Token(Token = "0x6000014")]
	[Address(RVA = "0xB096C0", Offset = "0xB07CC0", VA = "0x180B096C0")]
	public List<string> DumpAllEvents()
	{
		return null;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002114 File Offset: 0x00000314
	[Token(Token = "0x6000015")]
	[Address(RVA = "0xB09AA0", Offset = "0xB080A0", VA = "0x180B09AA0")]
	public EventDescription GetEventDescription(string path, bool warnIfNotFound = true)
	{
		return default(EventDescription);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0000212C File Offset: 0x0000032C
	[Token(Token = "0x6000016")]
	[Address(RVA = "0xB09D40", Offset = "0xB08340", VA = "0x180B09D40")]
	public static bool PreloadEvent(string path)
	{
		return default(bool);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002144 File Offset: 0x00000344
	[Token(Token = "0x6000017")]
	[Address(RVA = "0xB09DA0", Offset = "0xB083A0", VA = "0x180B09DA0")]
	public static bool TryPreloadEvent(string path)
	{
		return default(bool);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000215C File Offset: 0x0000035C
	[Token(Token = "0x6000018")]
	[Address(RVA = "0xB09E00", Offset = "0xB08400", VA = "0x180B09E00")]
	public static bool PreloadEvent(string path, int preloadCount, bool warnIfNotFound = true)
	{
		return default(bool);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000019")]
	[Address(RVA = "0xB0A0C0", Offset = "0xB086C0", VA = "0x180B0A0C0")]
	public static void UnPreloadEvent(string path)
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600001A")]
	[Address(RVA = "0xB0A110", Offset = "0xB08710", VA = "0x180B0A110")]
	public static void UnPreloadEvent(string path, int unloadCount)
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002174 File Offset: 0x00000374
	[Token(Token = "0x600001B")]
	[Address(RVA = "0xB0A390", Offset = "0xB08990", VA = "0x180B0A390")]
	public EventInstance GetEvent(string path)
	{
		return default(EventInstance);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0000218C File Offset: 0x0000038C
	[Token(Token = "0x600001C")]
	[Address(RVA = "0xB0A830", Offset = "0xB08E30", VA = "0x180B0A830")]
	public EventInstance PlayOneShot(string path, Vector3 position, [Optional] FMOD_StudioSystem.ProcessEventInstanceDelegate eventSetup)
	{
		return default(EventInstance);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000021A4 File Offset: 0x000003A4
	[Token(Token = "0x600001D")]
	[Address(RVA = "0xB0A870", Offset = "0xB08E70", VA = "0x180B0A870")]
	private EventInstance PlayOneShot(string path, Vector3 position, float volume, [Optional] FMOD_StudioSystem.ProcessEventInstanceDelegate eventSetup)
	{
		return default(EventInstance);
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000021BC File Offset: 0x000003BC
	[Token(Token = "0x600001E")]
	[Address(RVA = "0xB0AAE0", Offset = "0xB090E0", VA = "0x180B0AAE0")]
	public bool ShouldBeCulled(string path, Vector3 position)
	{
		return default(bool);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600001F")]
	[Address(RVA = "0xB0ADE0", Offset = "0xB093E0", VA = "0x180B0ADE0")]
	private void Init()
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000020")]
	[Address(RVA = "0xB0B5A0", Offset = "0xB09BA0", VA = "0x180B0B5A0")]
	private void Awake()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000021")]
	[Address(RVA = "0xB0BB40", Offset = "0xB0A140", VA = "0x180B0BB40")]
	private void Update()
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000022")]
	[Address(RVA = "0xB0BBB0", Offset = "0xB0A1B0", VA = "0x180B0BBB0")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000023 RID: 35 RVA: 0x000021D4 File Offset: 0x000003D4
	[Token(Token = "0x17000006")]
	public static bool HasBanksLoaded
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0xB0BCB0", Offset = "0xB0A2B0", VA = "0x180B0BCB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000024")]
	[Address(RVA = "0xB0BDF0", Offset = "0xB0A3F0", VA = "0x180B0BDF0")]
	public static void PauseAllEvents(bool paused)
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000025")]
	[Address(RVA = "0xB0C0A0", Offset = "0xB0A6A0", VA = "0x180B0C0A0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000021EC File Offset: 0x000003EC
	[Token(Token = "0x6000026")]
	[Address(RVA = "0xB0C0F0", Offset = "0xB0A6F0", VA = "0x180B0C0F0")]
	private static bool ERRCHECK(RESULT result)
	{
		return default(bool);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000027")]
	[Address(RVA = "0xB0C190", Offset = "0xB0A790", VA = "0x180B0C190")]
	public FMOD_StudioSystem()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _banksUnloaded;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, Bank> _loadedBanks;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	public const string VoiceCountSettingKey = "Audio.VoiceCount";

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FMOD.Studio.System System;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private FMOD.System _coreSystem;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<string, EventDescription> eventDescriptions;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isInitialized;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static FMOD_StudioSystem _instance;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private long[] cachedPointers;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static bool _isShuttingDown;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static int _voiceCount;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	private const float DISTANCE_CULL_BUFFER = 20f;

	// Token: 0x02000003 RID: 3
	// (Invoke) Token: 0x0600002A RID: 42
	[Token(Token = "0x2000003")]
	public delegate bool ProcessEventInstanceDelegate(EventInstance instance);
}
