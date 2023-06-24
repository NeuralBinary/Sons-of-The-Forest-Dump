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
	// Token: 0x0600008D RID: 141 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2F6CB50", Offset = "0x2F6B150", VA = "0x182F6CB50")]
	public static float GetHoursSinceMidnight()
	{
		return 0f;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2F6CD40", Offset = "0x2F6B340", VA = "0x182F6CD40")]
	public static void SetLocalPlayerTransform(Transform value)
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2F6CDF0", Offset = "0x2F6B3F0", VA = "0x182F6CDF0")]
	public static Transform GetLocalPlayerTransform()
	{
		return null;
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000090 RID: 144 RVA: 0x00002208 File Offset: 0x00000408
	[Token(Token = "0x17000009")]
	public bool HasAppliedChange
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x9938E0", Offset = "0x991EE0", VA = "0x1809938E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0", Slot = "13")]
	public void SetEventPath(string value)
	{
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
	public string GetEventPath()
	{
		return null;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2F6CE40", Offset = "0x2F6B440", VA = "0x182F6CE40", Slot = "12")]
	public void Play()
	{
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2F6CF50", Offset = "0x2F6B550", VA = "0x182F6CF50", Slot = "11")]
	public void Stop()
	{
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2F6D040", Offset = "0x2F6B640", VA = "0x182F6D040")]
	public void SetVolume(float volume)
	{
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2F6D080", Offset = "0x2F6B680", VA = "0x182F6D080")]
	public void SetDefaultParameter(float value)
	{
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2F6D090", Offset = "0x2F6B690", VA = "0x182F6D090")]
	public void SetParameter(string param, float value)
	{
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00002220 File Offset: 0x00000420
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2F6D150", Offset = "0x2F6B750", VA = "0x182F6D150")]
	public PLAYBACK_STATE getPlaybackState()
	{
		return PLAYBACK_STATE.PLAYING;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2F6D220", Offset = "0x2F6B820", VA = "0x182F6D220")]
	private void CalculateTriggerRadiusSquared()
	{
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2F6D410", Offset = "0x2F6BA10", VA = "0x182F6D410")]
	private void Start()
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2F6D410", Offset = "0x2F6BA10", VA = "0x182F6D410")]
	private void OnEnable()
	{
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2F6D430", Offset = "0x2F6BA30", VA = "0x182F6D430")]
	private void CheckRegistrationWithWorkScheduler()
	{
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2F6D590", Offset = "0x2F6BB90", VA = "0x182F6D590")]
	public void Activate()
	{
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002238 File Offset: 0x00000438
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2F6D930", Offset = "0x2F6BF30", VA = "0x182F6D930")]
	private bool StartEventByTrigger(Collider other)
	{
		return default(bool);
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2F6D9A0", Offset = "0x2F6BFA0", VA = "0x182F6D9A0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x2F6DAA0", Offset = "0x2F6C0A0", VA = "0x182F6DAA0")]
	private IEnumerator StartEventWhenStopped()
	{
		return null;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x2F6DB30", Offset = "0x2F6C130", VA = "0x182F6DB30")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2F6DC00", Offset = "0x2F6C200", VA = "0x182F6DC00")]
	private void OnDisable()
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2F6DD60", Offset = "0x2F6C360", VA = "0x182F6DD60")]
	private void TryGetEventDescription()
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2F6DEE0", Offset = "0x2F6C4E0", VA = "0x182F6DEE0")]
	private void CacheEventInstance()
	{
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2F6E070", Offset = "0x2F6C670", VA = "0x182F6E070")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x2F6E0C0", Offset = "0x2F6C6C0", VA = "0x182F6E0C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x2F6E2E0", Offset = "0x2F6C8E0", VA = "0x182F6E2E0")]
	public void StartEvent()
	{
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x2F6E550", Offset = "0x2F6CB50", VA = "0x182F6E550")]
	private void SetTimeAndWind()
	{
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x2F6E820", Offset = "0x2F6CE20", VA = "0x182F6E820")]
	private bool IsEventDescriptionValid()
	{
		return default(bool);
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002268 File Offset: 0x00000468
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2F6E830", Offset = "0x2F6CE30", VA = "0x182F6E830")]
	private bool IsEventInstanceValid()
	{
		return default(bool);
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x2F6E840", Offset = "0x2F6CE40", VA = "0x182F6E840")]
	private bool IsParameterValid(EventDescription description, string parameterName)
	{
		return default(bool);
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2F6E8A0", Offset = "0x2F6CEA0", VA = "0x182F6E8A0")]
	private bool ShouldCacheOnAwake()
	{
		return default(bool);
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2F6E8C0", Offset = "0x2F6CEC0", VA = "0x182F6E8C0")]
	private void Update()
	{
	}

	// Token: 0x060000AE RID: 174 RVA: 0x000022B0 File Offset: 0x000004B0
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x2F6EC70", Offset = "0x2F6D270", VA = "0x182F6EC70")]
	private static bool HasChanged(Transform target)
	{
		return default(bool);
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2F6EE80", Offset = "0x2F6D480", VA = "0x182F6EE80")]
	public void StopMoving()
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2F6EE90", Offset = "0x2F6D490", VA = "0x182F6EE90")]
	private void Update3DAttributes()
	{
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x000022C8 File Offset: 0x000004C8
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2F6EFC0", Offset = "0x2F6D5C0", VA = "0x182F6EFC0")]
	private RESULT ERRCHECK(RESULT result)
	{
		return RESULT.OK;
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x2F6EFE0", Offset = "0x2F6D5E0", VA = "0x182F6EFE0")]
	public void TransplantEventInstance(Transform parent)
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x2F6F230", Offset = "0x2F6D830", VA = "0x182F6F230")]
	public static GameObject CreateStartOnAwakeEmitter(Transform parent, string eventPath)
	{
		return null;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x2F6F310", Offset = "0x2F6D910", VA = "0x182F6F310")]
	public static GameObject CreateAmbientEmitter(Transform parent, Vector3 position, string eventPath)
	{
		return null;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2F6F3A0", Offset = "0x2F6D9A0", VA = "0x182F6F3A0")]
	private static GameObject CreateEmitter(Transform parent, Vector3 position, string eventPath, bool startEventOnAwake, bool startEventOnTriggerEnter)
	{
		return null;
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060000B6 RID: 182 RVA: 0x000022E0 File Offset: 0x000004E0
	// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700000A")]
	public bool ShouldDoMainThreadRefresh
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x12433F0", Offset = "0x12419F0", VA = "0x1812433F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1243400", Offset = "0x1241A00", VA = "0x181243400", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2F6F660", Offset = "0x2F6DC60", VA = "0x182F6F660", Slot = "6")]
	public void ThreadedRefresh()
	{
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x2F6F830", Offset = "0x2F6DE30", VA = "0x182F6F830", Slot = "7")]
	public void MainThreadRefresh()
	{
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x2F6F940", Offset = "0x2F6DF40", VA = "0x182F6F940", Slot = "8")]
	public string GetTaskName()
	{
		return null;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x9C5820", Offset = "0x9C3E20", VA = "0x1809C5820")]
	public void SetAppliedChange(bool value)
	{
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x2F6F970", Offset = "0x2F6DF70", VA = "0x182F6F970", Slot = "9")]
	public void EnableEmitter(bool value)
	{
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x2F6F9E0", Offset = "0x2F6DFE0", VA = "0x182F6F9E0", Slot = "10")]
	public void DestroyEmitter()
	{
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x2F6FA30", Offset = "0x2F6E030", VA = "0x182F6FA30")]
	public FMOD_StudioEventEmitter()
	{
	}

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x0")]
	private static float _cachedHoursSinceMidnight;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x4")]
	private static int _cachedHoursSinceMidnightFrame;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _forcedDisabled;

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x21")]
	private bool _appliedChange;

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("path")]
	[EventRef]
	[SerializeField]
	private string _eventPath;

	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x30")]
	public bool startEventOnAwake;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x31")]
	[FormerlySerializedAs("startEventOnTriggerEnter")]
	public bool _startEventUsingTriggerType;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private VailAudioManager.Noise _noiseStimuli;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool _dontUseWorkScheduler;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x3C")]
	public FMOD_StudioEventEmitter.TriggerType triggerType;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x40")]
	public bool allowFadeoutOnStop;

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x41")]
	public bool playOnceOnly;

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x48")]
	public Action<EventInstance> preStartAction;

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x50")]
	[Tooltip("For event velocity")]
	public Rigidbody customRigidbody;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x58")]
	[Tooltip("For SetDefaultParameter messages")]
	public string defaultParameterName;

	// Token: 0x040000B3 RID: 179
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x60")]
	[Tooltip("Send a PreprocessFMODEvent message before starting the event")]
	public bool sendPreprocessMessage;

	// Token: 0x040000B4 RID: 180
	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x8")]
	public static List<FMOD_StudioEventEmitter> sAwaitingBankLoad;

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x61")]
	public bool OverrideAttenuation;

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x64")]
	public float OverrideMinDistance;

	// Token: 0x040000B7 RID: 183
	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x68")]
	public float OverrideMaxDistance;

	// Token: 0x040000B8 RID: 184
	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x70")]
	private EventDescription eventDescription;

	// Token: 0x040000B9 RID: 185
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x78")]
	private float _eventTriggerRadiusSqr;

	// Token: 0x040000BA RID: 186
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x7C")]
	private bool withinTriggerRadius;

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x7D")]
	private bool isMoving;

	// Token: 0x040000BC RID: 188
	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x7E")]
	private bool shouldBeEnabled;

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 _cachedPosition;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x8C")]
	private int wsToken;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x90")]
	private EventInstance evt;

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x98")]
	private bool hasStarted;

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0xA0")]
	private List<Collider> playerColliders;

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000C2")]
	private const string TimeParameterName = "time";

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	private const string WindParameterName = "wind";

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0xA8")]
	private Rigidbody cachedRigidBody;

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x10")]
	private static bool isQuitting;

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x18")]
	private static Transform _localPlayerTransform;

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0xB0")]
	private bool _registeredOnLoadedBanksCallback;

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C8")]
	private const float LOAD_DISTANCE_FACTOR = 1.5f;

	// Token: 0x040000C9 RID: 201
	[Token(Token = "0x40000C9")]
	private const float UNLOAD_DISTANCE_FACTOR = 2f;

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000CA")]
	private const float ENABLE_DISTANCE_FACTOR = 1f;

	// Token: 0x040000CB RID: 203
	[Token(Token = "0x40000CB")]
	private const float DISABLE_DISTANCE_FACTOR = 1.1f;

	// Token: 0x040000CC RID: 204
	[Token(Token = "0x40000CC")]
	private const float LOAD_DISTANCE_FACTOR_SQUARED = 2.25f;

	// Token: 0x040000CD RID: 205
	[Token(Token = "0x40000CD")]
	private const float UNLOAD_DISTANCE_FACTOR_SQUARED = 4f;

	// Token: 0x040000CE RID: 206
	[Token(Token = "0x40000CE")]
	private const float ENABLE_DISTANCE_FACTOR_SQUARED = 1f;

	// Token: 0x040000CF RID: 207
	[Token(Token = "0x40000CF")]
	private const float DISABLE_DISTANCE_FACTOR_SQUARED = 1.21f;

	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public enum TriggerType
	{
		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		EventMaximumDistance,
		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		Collider
	}

	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[Serializable]
	public class Parameter
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Parameter()
		{
		}

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x18")]
		public float value;
	}
}
