using System;
using System.Collections.Generic;
using FMOD;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
public class FMODCommon
{
	// Token: 0x0600004D RID: 77 RVA: 0x0000224C File Offset: 0x0000044C
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2FD6950", Offset = "0x2FD4F50", VA = "0x182FD6950")]
	public static float GetVoiceVolume()
	{
		return 0f;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2FD69A0", Offset = "0x2FD4FA0", VA = "0x182FD69A0")]
	public static void SetVoiceVolume(float value)
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002264 File Offset: 0x00000464
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2FD6A00", Offset = "0x2FD5000", VA = "0x182FD6A00")]
	public static float GetMusicVolume()
	{
		return 0f;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2FD6A50", Offset = "0x2FD5050", VA = "0x182FD6A50")]
	public static void SetMusicVolume(float value)
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0000227C File Offset: 0x0000047C
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2FD6AB0", Offset = "0x2FD50B0", VA = "0x182FD6AB0")]
	public static float GetSfxVolume()
	{
		return 0f;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2FD6B00", Offset = "0x2FD5100", VA = "0x182FD6B00")]
	public static void SetSfxVolume(float value)
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2FD6B60", Offset = "0x2FD5160", VA = "0x182FD6B60")]
	public static void SetHoursCached(float value)
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002294 File Offset: 0x00000494
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2FD6BC0", Offset = "0x2FD51C0", VA = "0x182FD6BC0")]
	public static EventInstance PlayOneshotNetworked(string path, Transform transform, FMODCommon.NetworkRole role)
	{
		return default(EventInstance);
	}

	// Token: 0x06000055 RID: 85 RVA: 0x000022AC File Offset: 0x000004AC
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2FD6CD0", Offset = "0x2FD52D0", VA = "0x182FD6CD0")]
	public static EventInstance PlayOneshot(string path, Transform transform)
	{
		return default(EventInstance);
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000022C4 File Offset: 0x000004C4
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2FD6DD0", Offset = "0x2FD53D0", VA = "0x182FD6DD0")]
	public static EventInstance PlayOneshot(string path, Vector3 position, FMODCommon.NetworkRole role, params object[] parameterValues)
	{
		return default(EventInstance);
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000022DC File Offset: 0x000004DC
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2FD6E70", Offset = "0x2FD5470", VA = "0x182FD6E70")]
	public static EventInstance PlayOneshot(string path, Vector3 position, params object[] parameterValues)
	{
		return default(EventInstance);
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000022F4 File Offset: 0x000004F4
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2FD6F00", Offset = "0x2FD5500", VA = "0x182FD6F00")]
	private static int GetParameterIndex(string eventPath, string parameterName)
	{
		return 0;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x0000230C File Offset: 0x0000050C
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2FD7030", Offset = "0x2FD5630", VA = "0x182FD7030")]
	private static EventInstance PlayOneshotInternal(string path, Vector3 position, FMODCommon.NetworkRole role, params object[] parameterValues)
	{
		return default(EventInstance);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2FD7260", Offset = "0x2FD5860", VA = "0x182FD7260")]
	private static void SetupOneShotBolt(string path, Vector3 position, FMODCommon.NetworkRole role, object[] parameterValues)
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2FD76B0", Offset = "0x2FD5CB0", VA = "0x182FD76B0")]
	private static void SetParameterValues(EventInstance instance, object[] parameterValues)
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2FD77E0", Offset = "0x2FD5DE0", VA = "0x182FD77E0")]
	public static void StopEvent(EventInstance instance)
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2FD7890", Offset = "0x2FD5E90", VA = "0x182FD7890")]
	public static void PreloadEvents(params string[] paths)
	{
	}

	// Token: 0x0600005E RID: 94 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2FD7920", Offset = "0x2FD5F20", VA = "0x182FD7920")]
	public static void UnloadEvents(params string[] paths)
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002324 File Offset: 0x00000524
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2FD79B0", Offset = "0x2FD5FB0", VA = "0x182FD79B0")]
	public static int CountChannels(ChannelGroup group)
	{
		return 0;
	}

	// Token: 0x06000060 RID: 96 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2FD7BB0", Offset = "0x2FD61B0", VA = "0x182FD7BB0")]
	public static void CleanupOneshotEvents(List<FMODCommon.OneshotEventInfo> oneshotEvents, bool useMaximumAge)
	{
	}

	// Token: 0x06000061 RID: 97 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2FD7F40", Offset = "0x2FD6540", VA = "0x182FD7F40")]
	private static void TryReleaseInstance(FMODCommon.OneshotEventInfo info)
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2FD7FF0", Offset = "0x2FD65F0", VA = "0x182FD7FF0")]
	private static void TryStopEventInstance(FMODCommon.OneshotEventInfo info)
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2FD80A0", Offset = "0x2FD66A0", VA = "0x182FD80A0")]
	public static void AdoptOneshotEvents(List<FMODCommon.OneshotEventInfo> oneshotEvents)
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2FD84B0", Offset = "0x2FD6AB0", VA = "0x182FD84B0")]
	private static void CleanupAdoptedEvents()
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2FD86B0", Offset = "0x2FD6CB0", VA = "0x182FD86B0")]
	public static void UpdateLoopingEvents(List<FMODCommon.LoopingEventInfo> loopingEvents, Animator animator, Transform transform)
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2FD8930", Offset = "0x2FD6F30", VA = "0x182FD8930")]
	public static void ReleaseEvent(EventInstance evt, STOP_MODE stopMode = STOP_MODE.IMMEDIATE)
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x0000233C File Offset: 0x0000053C
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2FD89D0", Offset = "0x2FD6FD0", VA = "0x182FD89D0")]
	public static bool ERRCHECK(RESULT result, UnityEngine.Object obj, string eventText = "", string detail = "")
	{
		return default(bool);
	}

	// Token: 0x06000068 RID: 104 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public FMODCommon()
	{
	}

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	private const float ONESHOT_MAXIMUM_AGE = 10f;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x0")]
	private static List<FMODCommon.OneshotEventInfo> adoptedEvents;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x8")]
	private static float lastCleanupTime;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0xC")]
	private static float _hoursCached;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x10")]
	private static float _voiceVolumeCached;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x14")]
	private static float _musicVolumeCached;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x18")]
	private static float _sfxVolumeCached;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	private const float CLEANUP_PERIOD = 1f;

	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public enum NetworkRole
	{
		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		None,
		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		Any,
		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		Server
	}

	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public struct OneshotEventInfo
	{
		// Token: 0x0600006A RID: 106 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2FD8CE0", Offset = "0x2FD72E0", VA = "0x182FD8CE0")]
		public OneshotEventInfo(string _path, EventInstance _instance, bool _useMaximumAge = true)
		{
		}

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		public string path;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x8")]
		public EventInstance instance;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x10")]
		public ChannelGroup channelGroup;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x18")]
		public bool hasStarted;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x1C")]
		public float startTime;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x20")]
		public bool useMaximumAge;
	}

	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class LoopingEventInfo
	{
		// Token: 0x0600006B RID: 107 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2FD8DA0", Offset = "0x2FD73A0", VA = "0x182FD8DA0")]
		public LoopingEventInfo(string _path, EventInstance _instance, int _startState, bool _autoStop)
		{
		}

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x10")]
		public string path;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x18")]
		public EventInstance instance;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x20")]
		public int startState;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x24")]
		public bool autoStop;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x28")]
		public int playCount;
	}
}
