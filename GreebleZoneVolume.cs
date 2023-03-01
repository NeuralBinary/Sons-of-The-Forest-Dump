using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C8 RID: 456
[Token(Token = "0x20001C8")]
[ExecuteInEditMode]
[RequireComponent(typeof(SphereCollider))]
public class GreebleZoneVolume : MonoBehaviour
{
	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x000052F8 File Offset: 0x000034F8
	[Token(Token = "0x17000186")]
	public Color GizmoColor
	{
		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0xDBE440", Offset = "0xDBD440", VA = "0x180DBE440")]
		get
		{
			return default(Color);
		}
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0x261B460", Offset = "0x261A460", VA = "0x18261B460")]
	private void Awake()
	{
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000187")]
	public SphereCollider Collider
	{
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x2F89280", Offset = "0x2F88280", VA = "0x182F89280")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x00005310 File Offset: 0x00003510
	// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000188")]
	public float Radius
	{
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x567910", Offset = "0x566910", VA = "0x180567910")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x567970", Offset = "0x566970", VA = "0x180567970")]
		set
		{
		}
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00005328 File Offset: 0x00003528
	[Token(Token = "0x17000189")]
	public float RadiusSquared
	{
		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x2F89330", Offset = "0x2F88330", VA = "0x182F89330")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0x2F89260", Offset = "0x2F88260", VA = "0x182F89260")]
	public GreebleZoneVolume()
	{
	}

	// Token: 0x04000BC1 RID: 3009
	[Token(Token = "0x4000BC1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _dontLinkToParent;

	// Token: 0x04000BC2 RID: 3010
	[Token(Token = "0x4000BC2")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Range(1f, 500f)]
	private float _radius;

	// Token: 0x04000BC3 RID: 3011
	[Token(Token = "0x4000BC3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Color _gizmoColor;

	// Token: 0x04000BC4 RID: 3012
	[Token(Token = "0x4000BC4")]
	[FieldOffset(Offset = "0x38")]
	private SphereCollider _sphereCollider;

	// Token: 0x04000BC5 RID: 3013
	[Token(Token = "0x4000BC5")]
	[FieldOffset(Offset = "0x40")]
	private Transform _transform;

	// Token: 0x04000BC6 RID: 3014
	[Token(Token = "0x4000BC6")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 _previousPosition;
}
