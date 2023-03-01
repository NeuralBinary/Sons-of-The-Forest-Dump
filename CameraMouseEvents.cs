using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D9 RID: 473
[Token(Token = "0x20001D9")]
public class CameraMouseEvents : MonoBehaviour
{
	// Token: 0x06000D31 RID: 3377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D31")]
	[Address(RVA = "0x2F7F0C0", Offset = "0x2F7E0C0", VA = "0x182F7F0C0")]
	private void Awake()
	{
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D32")]
	[Address(RVA = "0x2F7F8F0", Offset = "0x2F7E8F0", VA = "0x182F7F8F0")]
	private void Update()
	{
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D33")]
	[Address(RVA = "0x2F7F1D0", Offset = "0x2F7E1D0", VA = "0x182F7F1D0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D34")]
	[Address(RVA = "0x2F7F2B0", Offset = "0x2F7E2B0", VA = "0x182F7F2B0")]
	private void SpawnDebugRay(Vector3 outterPos, Vector3 dir, Color col, float size, float length)
	{
	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D35")]
	[Address(RVA = "0x2F7FFA0", Offset = "0x2F7EFA0", VA = "0x182F7FFA0")]
	public CameraMouseEvents()
	{
	}

	// Token: 0x04000C2D RID: 3117
	[Token(Token = "0x4000C2D")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask layerMask;

	// Token: 0x04000C2E RID: 3118
	[Token(Token = "0x4000C2E")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _detectRange;

	// Token: 0x04000C2F RID: 3119
	[Token(Token = "0x4000C2F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _rayAngleThreshold;

	// Token: 0x04000C30 RID: 3120
	[Token(Token = "0x4000C30")]
	[FieldOffset(Offset = "0x2C")]
	public bool useSpherecast;

	// Token: 0x04000C31 RID: 3121
	[Token(Token = "0x4000C31")]
	[FieldOffset(Offset = "0x30")]
	public float radius;

	// Token: 0x04000C32 RID: 3122
	[Token(Token = "0x4000C32")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public bool _overrideRay;

	// Token: 0x04000C33 RID: 3123
	[Token(Token = "0x4000C33")]
	[FieldOffset(Offset = "0x38")]
	public Transform RayOverride;

	// Token: 0x04000C34 RID: 3124
	[Token(Token = "0x4000C34")]
	[FieldOffset(Offset = "0x40")]
	public bool RayOverrideVrOnly;

	// Token: 0x04000C35 RID: 3125
	[Token(Token = "0x4000C35")]
	[FieldOffset(Offset = "0x41")]
	public bool _showDebugRay;

	// Token: 0x04000C36 RID: 3126
	[Token(Token = "0x4000C36")]
	[FieldOffset(Offset = "0x44")]
	public Color RayColor;

	// Token: 0x04000C37 RID: 3127
	[Token(Token = "0x4000C37")]
	[FieldOffset(Offset = "0x54")]
	public float RaySize;

	// Token: 0x04000C38 RID: 3128
	[Token(Token = "0x4000C38")]
	[FieldOffset(Offset = "0x58")]
	private GameObject _selectedObject;

	// Token: 0x04000C39 RID: 3129
	[Token(Token = "0x4000C39")]
	[FieldOffset(Offset = "0x60")]
	private bool _isMouseDown;

	// Token: 0x04000C3A RID: 3130
	[Token(Token = "0x4000C3A")]
	[FieldOffset(Offset = "0x68")]
	private Camera _camera;

	// Token: 0x04000C3B RID: 3131
	[Token(Token = "0x4000C3B")]
	[FieldOffset(Offset = "0x70")]
	private Ray _previousRay;

	// Token: 0x04000C3C RID: 3132
	[Token(Token = "0x4000C3C")]
	[FieldOffset(Offset = "0x88")]
	private Transform mouseEventDebugSphere;

	// Token: 0x04000C3D RID: 3133
	[Token(Token = "0x4000C3D")]
	[FieldOffset(Offset = "0x90")]
	private Transform mouseEventDebugCylinder;
}
