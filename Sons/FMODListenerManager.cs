using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000018 RID: 24
[Token(Token = "0x2000018")]
public class FMODListenerManager : MonoBehaviour
{
	// Token: 0x0600006D RID: 109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2F6A3B0", Offset = "0x2F689B0", VA = "0x182F6A3B0")]
	public static void SetLogging(bool value)
	{
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2F6A410", Offset = "0x2F68A10", VA = "0x182F6A410")]
	private void Update()
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2F6A420", Offset = "0x2F68A20", VA = "0x182F6A420")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2F6A430", Offset = "0x2F68A30", VA = "0x182F6A430")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x2F6A440", Offset = "0x2F68A40", VA = "0x182F6A440")]
	private void DoUpdate()
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x2F6ABF0", Offset = "0x2F691F0", VA = "0x182F6ABF0")]
	private bool IsSceneLoaderRunning()
	{
		return default(bool);
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2F6AC90", Offset = "0x2F69290", VA = "0x182F6AC90")]
	private void SetLocation(Vector3 newPos, Quaternion newRotation)
	{
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x2F6AEA0", Offset = "0x2F694A0", VA = "0x182F6AEA0")]
	private void RecordHistory(Vector3 newPos, Quaternion newRotation)
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2F6B120", Offset = "0x2F69720", VA = "0x182F6B120")]
	private void Awake()
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2F6B3C0", Offset = "0x2F699C0", VA = "0x182F6B3C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2F6B580", Offset = "0x2F69B80", VA = "0x182F6B580")]
	public static void Register(FMODListenerTarget target)
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2F6B770", Offset = "0x2F69D70", VA = "0x182F6B770")]
	private void DrawDebug()
	{
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2F6BD20", Offset = "0x2F6A320", VA = "0x182F6BD20")]
	public static void Unregister(FMODListenerTarget target)
	{
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2F6BE50", Offset = "0x2F6A450", VA = "0x182F6BE50")]
	public FMODListenerManager()
	{
	}

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Quaternion DefaultRotation;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x10")]
	public static readonly Vector3 DefaultPosition;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private FMODListenerManager.UpdateTick _updateTick;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool _lockPitchAndRoll;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x25")]
	[SerializeField]
	[FormerlySerializedAs("_drawGizmos")]
	private bool _drawDebug;

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _drawDebugMaxCount;

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x20")]
	private static List<FMODListenerTarget> _targets;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x28")]
	private static FMODListenerManager _instance;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x30")]
	private List<Vector3> _positions;

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x38")]
	private List<Quaternion> _rotations;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x40")]
	private Transform _previousBestTransform;

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x30")]
	private static bool _logging;

	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public enum UpdateTick
	{
		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		Update,
		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		LateUpdate,
		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		FixedUpdate
	}
}
