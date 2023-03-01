using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using TheForest.Utils.WorkSchedulerInterfaces;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200001C RID: 28
[Token(Token = "0x200001C")]
public class FMOD_StudioEventEmitter : MonoBehaviour, IThreadSafeTask, IFMODEmitter
{
	// Token: 0x06000084 RID: 132 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x29A3910", Offset = "0x29A2910", VA = "0x1829A3910")]
	public static float GetHoursSinceMidnight()
	{
		return default(float);
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x29A44A0", Offset = "0x29A34A0", VA = "0x1829A44A0")]
	public static void SetLocalPlayerTransform(Transform value)
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x29A3950", Offset = "0x29A2950", VA = "0x1829A3950")]
	public static Transform GetLocalPlayerTransform()
	{
		return null;
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000087 RID: 135 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x17000009")]
	public bool HasAppliedChange
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x873BD0", Offset = "0x872BD0", VA = "0x180873BD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270", Slot = "13")]
	public void SetEventPath(string value)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
	public string GetEventPath()
	{
		return null;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x29A42C0", Offset = "0x29A32C0", VA = "0x1829A42C0", Slot = "12")]
	public void Play()
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x29A4AA0", Offset = "0x29A3AA0", VA = "0x1829A4AA0", Slot = "11")]
	public void Stop()
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x29A46F0", Offset = "0x29A36F0", VA = "0x1829A46F0")]
	public void SetVolume(float volume)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x29A43E0", Offset = "0x29A33E0", VA = "0x1829A43E0")]
	public void SetDefaultParameter(float value)
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x29A4510", Offset = "0x29A3510", VA = "0x1829A4510")]
	public void SetParameter(string param, float value)
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002208 File Offset: 0x00000408
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x29A54D0", Offset = "0x29A44D0", VA = "0x1829A54D0")]
	public PLAYBACK_STATE getPlaybackState()
	{
		return default(PLAYBACK_STATE);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x29A3400", Offset = "0x29A2400", VA = "0x1829A3400")]
	private void CalculateTriggerRadiusSquared()
	{
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x29A40C0", Offset = "0x29A30C0", VA = "0x1829A40C0")]
	private void Start()
	{
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x29A40C0", Offset = "0x29A30C0", VA = "0x1829A40C0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x29A3550", Offset = "0x29A2550", VA = "0x1829A3550")]
	private void CheckRegistrationWithWorkScheduler()
	{
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x29A2E50", Offset = "0x29A1E50", VA = "0x1829A2E50")]
	public void Activate()
	{
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002220 File Offset: 0x00000420
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x29A4750", Offset = "0x29A3750", VA = "0x1829A4750")]
	private bool StartEventByTrigger(Collider other)
	{
		return default(bool);
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x29A40E0", Offset = "0x29A30E0", VA = "0x1829A40E0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x29A47C0", Offset = "0x29A37C0", VA = "0x1829A47C0")]
	private IEnumerator StartEventWhenStopped()
	{
		return null;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x29A41F0", Offset = "0x29A31F0", VA = "0x1829A41F0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x29A3DC0", Offset = "0x29A2DC0", VA = "0x1829A3DC0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x29A4DF0", Offset = "0x29A3DF0", VA = "0x1829A4DF0")]
	private void TryGetEventDescription()
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x29A3280", Offset = "0x29A2280", VA = "0x1829A3280")]
	private void CacheEventInstance()
	{
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x29A3BB0", Offset = "0x29A2BB0", VA = "0x1829A3BB0")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x29A3C00", Offset = "0x29A2C00", VA = "0x1829A3C00")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x29A4830", Offset = "0x29A3830", VA = "0x1829A4830")]
	public void StartEvent()
	{
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x29A45D0", Offset = "0x29A35D0", VA = "0x1829A45D0")]
	private void SetTimeAndWind()
	{
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002238 File Offset: 0x00000438
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x29A3AB0", Offset = "0x29A2AB0", VA = "0x1829A3AB0")]
	private bool IsEventDescriptionValid()
	{
		return default(bool);
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x29A3AC0", Offset = "0x29A2AC0", VA = "0x1829A3AC0")]
	private bool IsEventInstanceValid()
	{
		return default(bool);
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002268 File Offset: 0x00000468
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x29A3AD0", Offset = "0x29A2AD0", VA = "0x1829A3AD0")]
	private bool IsParameterValid(EventDescription description, string parameterName)
	{
		return default(bool);
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x29A4730", Offset = "0x29A3730", VA = "0x1829A4730")]
	private bool ShouldCacheOnAwake()
	{
		return default(bool);
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x29A5000", Offset = "0x29A4000", VA = "0x1829A5000")]
	private void Update()
	{
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x29A39D0", Offset = "0x29A29D0", VA = "0x1829A39D0")]
	private static bool HasChanged(Transform target)
	{
		return default(bool);
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x29A4A90", Offset = "0x29A3A90", VA = "0x1829A4A90")]
	public void StopMoving()
	{
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x29A4F70", Offset = "0x29A3F70", VA = "0x1829A4F70")]
	private void Update3DAttributes()
	{
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x000022B0 File Offset: 0x000004B0
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x29A38B0", Offset = "0x29A28B0", VA = "0x1829A38B0")]
	private RESULT ERRCHECK(RESULT result)
	{
		return default(RESULT);
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x29A4CD0", Offset = "0x29A3CD0", VA = "0x1829A4CD0")]
	public void TransplantEventInstance(Transform parent)
	{
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x29A37B0", Offset = "0x29A27B0", VA = "0x1829A37B0")]
	public static GameObject CreateStartOnAwakeEmitter(Transform parent, string eventPath)
	{
		return null;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x29A35D0", Offset = "0x29A25D0", VA = "0x1829A35D0")]
	public static GameObject CreateAmbientEmitter(Transform parent, Vector3 position, string eventPath)
	{
		return null;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x29A3660", Offset = "0x29A2660", VA = "0x1829A3660")]
	private static GameObject CreateEmitter(Transform parent, Vector3 position, string eventPath, bool startEventOnAwake, bool startEventOnTriggerEnter)
	{
		return null;
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060000AD RID: 173 RVA: 0x000022C8 File Offset: 0x000004C8
	// (set) Token: 0x060000AE RID: 174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700000A")]
	public bool ShouldDoMainThreadRefresh
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1047270", Offset = "0x1046270", VA = "0x181047270", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1047290", Offset = "0x1046290", VA = "0x181047290", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x29A4B60", Offset = "0x29A3B60", VA = "0x1829A4B60", Slot = "6")]
	public void ThreadedRefresh()
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x29A3B30", Offset = "0x29A2B30", VA = "0x1829A3B30", Slot = "7")]
	public void MainThreadRefresh()
	{
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x29A39A0", Offset = "0x29A29A0", VA = "0x1829A39A0", Slot = "8")]
	public string GetTaskName()
	{
		return null;
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1DDA7A0", Offset = "0x1DD97A0", VA = "0x181DDA7A0")]
	public void SetAppliedChange(bool value)
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x29A38D0", Offset = "0x29A28D0", VA = "0x1829A38D0", Slot = "9")]
	public void EnableEmitter(bool value)
	{
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x29A3860", Offset = "0x29A2860", VA = "0x1829A3860", Slot = "10")]
	public void DestroyEmitter()
	{
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x29A53E0", Offset = "0x29A43E0", VA = "0x1829A53E0")]
	public FMOD_StudioEventEmitter()
	{
	}

	// Token: 0x040000A2 RID: 162
	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x0")]
	private static float _cachedHoursSinceMidnight;

	// Token: 0x040000A3 RID: 163
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x4")]
	private static int _cachedHoursSinceMidnightFrame;

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _forcedDisabled;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x21")]
	private bool _appliedChange;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("path")]
	[EventRef]
	[SerializeField]
	private string _eventPath;

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x30")]
	public bool startEventOnAwake;

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x31")]
	[FormerlySerializedAs("startEventOnTriggerEnter")]
	public bool _startEventUsingTriggerType;

	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private VailAudioManager.Noise _noiseStimuli;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool _dontUseWorkScheduler;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x3C")]
	public FMOD_StudioEventEmitter.TriggerType triggerType;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x40")]
	public bool allowFadeoutOnStop;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x41")]
	public bool playOnceOnly;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x48")]
	public Action<EventInstance> preStartAction;

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x50")]
	[Tooltip("For event velocity")]
	public Rigidbody customRigidbody;

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x58")]
	[Tooltip("For SetDefaultParameter messages")]
	public string defaultParameterName;

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x60")]
	[Tooltip("Send a PreprocessFMODEvent message before starting the event")]
	public bool sendPreprocessMessage;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x8")]
	public static List<FMOD_StudioEventEmitter> sAwaitingBankLoad;

	// Token: 0x040000B3 RID: 179
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x61")]
	public bool OverrideAttenuation;

	// Token: 0x040000B4 RID: 180
	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x64")]
	public float OverrideMinDistance;

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x68")]
	public float OverrideMaxDistance;

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x70")]
	private EventDescription eventDescription;

	// Token: 0x040000B7 RID: 183
	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x78")]
	private float _eventTriggerRadiusSqr;

	// Token: 0x040000B8 RID: 184
	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x7C")]
	private bool withinTriggerRadius;

	// Token: 0x040000B9 RID: 185
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x7D")]
	private bool isMoving;

	// Token: 0x040000BA RID: 186
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x7E")]
	private bool shouldBeEnabled;

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 _cachedPosition;

	// Token: 0x040000BC RID: 188
	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x8C")]
	private int wsToken;

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x90")]
	private EventInstance evt;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x98")]
	private bool hasStarted;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0xA0")]
	private List<Collider> playerColliders;

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000C0")]
	private const string TimeParameterName = "time";

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000C1")]
	private const string WindParameterName = "wind";

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0xA8")]
	private Rigidbody cachedRigidBody;

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x10")]
	private static bool isQuitting;

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x18")]
	private static Transform _localPlayerTransform;

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0xB0")]
	private bool _registeredOnLoadedBanksCallback;

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	private const float LOAD_DISTANCE_FACTOR = 1.5f;

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C7")]
	private const float UNLOAD_DISTANCE_FACTOR = 2f;

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C8")]
	private const float ENABLE_DISTANCE_FACTOR = 1f;

	// Token: 0x040000C9 RID: 201
	[Token(Token = "0x40000C9")]
	private const float DISABLE_DISTANCE_FACTOR = 1.1f;

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000CA")]
	private const float LOAD_DISTANCE_FACTOR_SQUARED = 2.25f;

	// Token: 0x040000CB RID: 203
	[Token(Token = "0x40000CB")]
	private const float UNLOAD_DISTANCE_FACTOR_SQUARED = 4f;

	// Token: 0x040000CC RID: 204
	[Token(Token = "0x40000CC")]
	private const float ENABLE_DISTANCE_FACTOR_SQUARED = 1f;

	// Token: 0x040000CD RID: 205
	[Token(Token = "0x40000CD")]
	private const float DISABLE_DISTANCE_FACTOR_SQUARED = 1.21f;

	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public enum TriggerType
	{
		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		EventMaximumDistance,
		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		Collider
	}

	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[Serializable]
	public class Parameter
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public Parameter()
		{
		}

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x18")]
		public float value;
	}
}
