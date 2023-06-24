using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D8 RID: 472
[Token(Token = "0x20001D8")]
public class CameraMouseEvents : MonoBehaviour
{
	// Token: 0x06000D8C RID: 3468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0x3703080", Offset = "0x3701680", VA = "0x183703080")]
	private void Awake()
	{
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x37032B0", Offset = "0x37018B0", VA = "0x1837032B0")]
	private void Update()
	{
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x3703D10", Offset = "0x3702310", VA = "0x183703D10")]
	private void OnDisable()
	{
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x3703EA0", Offset = "0x37024A0", VA = "0x183703EA0")]
	private void SpawnDebugRay(Vector3 outterPos, Vector3 dir, Color col, float size, float length)
	{
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x3704AF0", Offset = "0x37030F0", VA = "0x183704AF0")]
	public CameraMouseEvents()
	{
	}

	// Token: 0x04000C5C RID: 3164
	[Token(Token = "0x4000C5C")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask layerMask;

	// Token: 0x04000C5D RID: 3165
	[Token(Token = "0x4000C5D")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _detectRange;

	// Token: 0x04000C5E RID: 3166
	[Token(Token = "0x4000C5E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _rayAngleThreshold;

	// Token: 0x04000C5F RID: 3167
	[Token(Token = "0x4000C5F")]
	[FieldOffset(Offset = "0x2C")]
	public bool useSpherecast;

	// Token: 0x04000C60 RID: 3168
	[Token(Token = "0x4000C60")]
	[FieldOffset(Offset = "0x30")]
	public float radius;

	// Token: 0x04000C61 RID: 3169
	[Token(Token = "0x4000C61")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public bool _overrideRay;

	// Token: 0x04000C62 RID: 3170
	[Token(Token = "0x4000C62")]
	[FieldOffset(Offset = "0x38")]
	public Transform RayOverride;

	// Token: 0x04000C63 RID: 3171
	[Token(Token = "0x4000C63")]
	[FieldOffset(Offset = "0x40")]
	public bool RayOverrideVrOnly;

	// Token: 0x04000C64 RID: 3172
	[Token(Token = "0x4000C64")]
	[FieldOffset(Offset = "0x41")]
	public bool _showDebugRay;

	// Token: 0x04000C65 RID: 3173
	[Token(Token = "0x4000C65")]
	[FieldOffset(Offset = "0x44")]
	public Color RayColor;

	// Token: 0x04000C66 RID: 3174
	[Token(Token = "0x4000C66")]
	[FieldOffset(Offset = "0x54")]
	public float RaySize;

	// Token: 0x04000C67 RID: 3175
	[Token(Token = "0x4000C67")]
	[FieldOffset(Offset = "0x58")]
	private GameObject _selectedObject;

	// Token: 0x04000C68 RID: 3176
	[Token(Token = "0x4000C68")]
	[FieldOffset(Offset = "0x60")]
	private bool _isMouseDown;

	// Token: 0x04000C69 RID: 3177
	[Token(Token = "0x4000C69")]
	[FieldOffset(Offset = "0x68")]
	private Camera _camera;

	// Token: 0x04000C6A RID: 3178
	[Token(Token = "0x4000C6A")]
	[FieldOffset(Offset = "0x70")]
	private Ray _previousRay;

	// Token: 0x04000C6B RID: 3179
	[Token(Token = "0x4000C6B")]
	[FieldOffset(Offset = "0x88")]
	private Transform mouseEventDebugSphere;

	// Token: 0x04000C6C RID: 3180
	[Token(Token = "0x4000C6C")]
	[FieldOffset(Offset = "0x90")]
	private Transform mouseEventDebugCylinder;
}
