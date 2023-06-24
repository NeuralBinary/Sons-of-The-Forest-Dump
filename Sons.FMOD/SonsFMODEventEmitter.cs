using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200001D RID: 29
[Token(Token = "0x200001D")]
[AddComponentMenu("Sons/FMOD/Sons FMOD Event Emitter")]
public class SonsFMODEventEmitter : FMODUnity.EventHandler, IFMODEmitter
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000248C File Offset: 0x0000068C
	[Token(Token = "0x17000004")]
	public EventDescription EventDescription
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
		get
		{
			return default(EventDescription);
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x060000B2 RID: 178 RVA: 0x000024A4 File Offset: 0x000006A4
	[Token(Token = "0x17000005")]
	public EventInstance EventInstance
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
		get
		{
			return default(EventInstance);
		}
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
	public string GetEventPath()
	{
		return null;
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x060000B4 RID: 180 RVA: 0x000024BC File Offset: 0x000006BC
	[Token(Token = "0x17000006")]
	public float CachedMinDistance
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x23C25F0", Offset = "0x23C0BF0", VA = "0x1823C25F0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x060000B5 RID: 181 RVA: 0x000024D4 File Offset: 0x000006D4
	[Token(Token = "0x17000007")]
	public float CachedMaxDistance
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x23C2610", Offset = "0x23C0C10", VA = "0x1823C2610")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x2FE0E50", Offset = "0x2FDF450", VA = "0x182FE0E50")]
	private void Start()
	{
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2FE0F00", Offset = "0x2FDF500", VA = "0x182FE0F00")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2FE0F10", Offset = "0x2FDF510", VA = "0x182FE0F10")]
	private void OnDestroy()
	{
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x2FE0FA0", Offset = "0x2FDF5A0", VA = "0x182FE0FA0", Slot = "18")]
	protected override void HandleGameEvent(EmitterGameEvent gameEvent)
	{
	}

	// Token: 0x060000BA RID: 186 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x2FE1030", Offset = "0x2FDF630", VA = "0x182FE1030")]
	private void Lookup()
	{
	}

	// Token: 0x060000BB RID: 187 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x2715B10", Offset = "0x2714110", VA = "0x182715B10")]
	public void SetVolume(float volume)
	{
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x2FE1180", Offset = "0x2FDF780", VA = "0x182FE1180", Slot = "22")]
	public void Play()
	{
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x2FE1780", Offset = "0x2FDFD80", VA = "0x182FE1780")]
	private void Update()
	{
	}

	// Token: 0x060000BE RID: 190 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x2FE17D0", Offset = "0x2FDFDD0", VA = "0x182FE17D0")]
	private void Update3DAttributes()
	{
	}

	// Token: 0x060000BF RID: 191 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x2FE1A20", Offset = "0x2FE0020", VA = "0x182FE1A20", Slot = "23")]
	public void SetEventPath(string eventPath)
	{
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x2FE1A80", Offset = "0x2FE0080", VA = "0x182FE1A80", Slot = "21")]
	public void Stop()
	{
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x2FE1AF0", Offset = "0x2FE00F0", VA = "0x182FE1AF0")]
	public void SetParameter(string name, float value, bool ignoreseekspeed = false)
	{
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2FE1B50", Offset = "0x2FE0150", VA = "0x182FE1B50")]
	public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
	{
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x2FE1BB0", Offset = "0x2FE01B0", VA = "0x182FE1BB0", Slot = "5")]
	protected override void OnDisable()
	{
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x000024EC File Offset: 0x000006EC
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x2FE1BF0", Offset = "0x2FE01F0", VA = "0x182FE1BF0")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x2FE1CA0", Offset = "0x2FE02A0", VA = "0x182FE1CA0", Slot = "19")]
	public void EnableEmitter(bool value)
	{
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x2FE1D20", Offset = "0x2FE0320", VA = "0x182FE1D20", Slot = "20")]
	public void DestroyEmitter()
	{
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2FE1D70", Offset = "0x2FE0370", VA = "0x182FE1D70")]
	public void UpdateCachedAttenuation(float minDistance, float maxDistance)
	{
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x2FE1D80", Offset = "0x2FE0380", VA = "0x182FE1D80")]
	public SonsFMODEventEmitter()
	{
	}

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("Event")]
	[EventRef]
	private string _eventPath;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _baseVolume;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x34")]
	public EmitterGameEvent PlayEvent;

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x38")]
	public EmitterGameEvent StopEvent;

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x3C")]
	public bool AllowFadeout;

	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x3D")]
	public bool TriggerOnce;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x3E")]
	public bool Preload;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x40")]
	public ParamRef[] Params;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x48")]
	public bool OverrideAttenuation;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x4C")]
	public float OverrideMinDistance;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x50")]
	public float OverrideMaxDistance;

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool _oneInstance;

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x55")]
	[SerializeField]
	private bool _stopOnDisable;

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x58")]
	protected EventDescription eventDescription;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x60")]
	protected EventInstance instance;

	// Token: 0x040000B3 RID: 179
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x68")]
	private bool hasTriggered;

	// Token: 0x040000B4 RID: 180
	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x69")]
	private bool isQuitting;

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x6A")]
	private bool isOneshot;

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x6B")]
	private bool _isPlaying;

	// Token: 0x040000B7 RID: 183
	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float _cachedMinDistance;

	// Token: 0x040000B8 RID: 184
	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float _cachedMaxDistance;

	// Token: 0x040000B9 RID: 185
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private bool _followTransform;

	// Token: 0x040000BA RID: 186
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x78")]
	private Rigidbody _rigidBody;

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000BB")]
	private const string SnapshotString = "snapshot";
}
