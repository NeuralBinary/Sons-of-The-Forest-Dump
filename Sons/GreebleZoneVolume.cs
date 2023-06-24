using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C7 RID: 455
[Token(Token = "0x20001C7")]
[ExecuteInEditMode]
[RequireComponent(typeof(SphereCollider))]
public class GreebleZoneVolume : MonoBehaviour
{
	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00005538 File Offset: 0x00003738
	[Token(Token = "0x1700018F")]
	public Color GizmoColor
	{
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0xFAFF70", Offset = "0xFAE570", VA = "0x180FAFF70")]
		get
		{
			return default(Color);
		}
	}

	// Token: 0x06000D3E RID: 3390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3E")]
	[Address(RVA = "0x2AECD90", Offset = "0x2AEB390", VA = "0x182AECD90")]
	private void Awake()
	{
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000190")]
	public SphereCollider Collider
	{
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x36FB660", Offset = "0x36F9C60", VA = "0x1836FB660")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00005550 File Offset: 0x00003750
	// (set) Token: 0x06000D41 RID: 3393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000191")]
	public float Radius
	{
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
		set
		{
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00005568 File Offset: 0x00003768
	[Token(Token = "0x17000192")]
	public float RadiusSquared
	{
		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x36FB7F0", Offset = "0x36F9DF0", VA = "0x1836FB7F0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D43")]
	[Address(RVA = "0x36FB800", Offset = "0x36F9E00", VA = "0x1836FB800")]
	public GreebleZoneVolume()
	{
	}

	// Token: 0x04000BF0 RID: 3056
	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _dontLinkToParent;

	// Token: 0x04000BF1 RID: 3057
	[Token(Token = "0x4000BF1")]
	[FieldOffset(Offset = "0x24")]
	[Range(1f, 500f)]
	[SerializeField]
	private float _radius;

	// Token: 0x04000BF2 RID: 3058
	[Token(Token = "0x4000BF2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Color _gizmoColor;

	// Token: 0x04000BF3 RID: 3059
	[Token(Token = "0x4000BF3")]
	[FieldOffset(Offset = "0x38")]
	private SphereCollider _sphereCollider;

	// Token: 0x04000BF4 RID: 3060
	[Token(Token = "0x4000BF4")]
	[FieldOffset(Offset = "0x40")]
	private Transform _transform;

	// Token: 0x04000BF5 RID: 3061
	[Token(Token = "0x4000BF5")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 _previousPosition;
}
