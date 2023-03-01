using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000018 RID: 24
[Token(Token = "0x2000018")]
public class FMODListenerManager : MonoBehaviour
{
	// Token: 0x06000064 RID: 100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x29A1930", Offset = "0x29A0930", VA = "0x1829A1930")]
	public static void SetLogging(bool value)
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x29A1AC0", Offset = "0x29A0AC0", VA = "0x1829A1AC0")]
	private void Update()
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x29A11C0", Offset = "0x29A01C0", VA = "0x1829A11C0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x29A1140", Offset = "0x29A0140", VA = "0x1829A1140")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x29A0810", Offset = "0x299F810", VA = "0x1829A0810")]
	private void DoUpdate()
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x29A1150", Offset = "0x29A0150", VA = "0x1829A1150")]
	private bool IsSceneLoaderRunning()
	{
		return default(bool);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x29A1640", Offset = "0x29A0640", VA = "0x1829A1640")]
	private void SetLocation(Vector3 newPos, Quaternion newRotation)
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x29A12B0", Offset = "0x29A02B0", VA = "0x1829A12B0")]
	private void RecordHistory(Vector3 newPos, Quaternion newRotation)
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x29A06C0", Offset = "0x299F6C0", VA = "0x1829A06C0")]
	private void Awake()
	{
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x29A11D0", Offset = "0x29A01D0", VA = "0x1829A11D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x29A1470", Offset = "0x29A0470", VA = "0x1829A1470")]
	public static void Register(FMODListenerTarget target)
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x29A0D70", Offset = "0x299FD70", VA = "0x1829A0D70")]
	private void DrawDebug()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x29A1990", Offset = "0x29A0990", VA = "0x1829A1990")]
	public static void Unregister(FMODListenerTarget target)
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x29A1B70", Offset = "0x29A0B70", VA = "0x1829A1B70")]
	public FMODListenerManager()
	{
	}

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Quaternion DefaultRotation;

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x10")]
	public static readonly Vector3 DefaultPosition;

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private FMODListenerManager.UpdateTick _updateTick;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool _lockPitchAndRoll;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x25")]
	[SerializeField]
	[FormerlySerializedAs("_drawGizmos")]
	private bool _drawDebug;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _drawDebugMaxCount;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x20")]
	private static List<FMODListenerTarget> _targets;

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x28")]
	private static FMODListenerManager _instance;

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x30")]
	private List<Vector3> _positions;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x38")]
	private List<Quaternion> _rotations;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x40")]
	private Transform _previousBestTransform;

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x30")]
	private static bool _logging;

	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public enum UpdateTick
	{
		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		Update,
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		LateUpdate,
		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		FixedUpdate
	}
}
