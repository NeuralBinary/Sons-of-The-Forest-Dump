using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000185 RID: 389
[Token(Token = "0x2000185")]
public class wallTriggerSetup : MonoBehaviour
{
	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00004C20 File Offset: 0x00002E20
	// (set) Token: 0x06000B5A RID: 2906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000166")]
	public bool BuildingSystemControllingWeaponClipBlend
	{
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x5F2450", Offset = "0x5F1450", VA = "0x1805F2450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x5F2460", Offset = "0x5F1460", VA = "0x1805F2460")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00004C38 File Offset: 0x00002E38
	[Token(Token = "0x17000167")]
	private bool ForceWeaponClipBlendToZero
	{
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x5F2450", Offset = "0x5F1450", VA = "0x1805F2450")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00004C50 File Offset: 0x00002E50
	[Token(Token = "0x17000168")]
	public bool AtWall
	{
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x2F79330", Offset = "0x2F78330", VA = "0x182F79330")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0x2F78EF0", Offset = "0x2F77EF0", VA = "0x182F78EF0")]
	private void OnValidate()
	{
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x00004C68 File Offset: 0x00002E68
	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0x2F78C20", Offset = "0x2F77C20", VA = "0x182F78C20")]
	private bool IsWallCollider(Collider other)
	{
		return default(bool);
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x2F78E00", Offset = "0x2F77E00", VA = "0x182F78E00")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x2F78E90", Offset = "0x2F77E90", VA = "0x182F78E90")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x2F79000", Offset = "0x2F78000", VA = "0x182F79000")]
	private void Update()
	{
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x2F792B0", Offset = "0x2F782B0", VA = "0x182F792B0")]
	public wallTriggerSetup()
	{
	}

	// Token: 0x04000A24 RID: 2596
	[Token(Token = "0x4000A24")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator _animator;

	// Token: 0x04000A25 RID: 2597
	[Token(Token = "0x4000A25")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _smoothTime;

	// Token: 0x04000A26 RID: 2598
	[Token(Token = "0x4000A26")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Collider _triggerCollider;

	// Token: 0x04000A27 RID: 2599
	[Token(Token = "0x4000A27")]
	[FieldOffset(Offset = "0x38")]
	private float _smoothVal;

	// Token: 0x04000A28 RID: 2600
	[Token(Token = "0x4000A28")]
	[FieldOffset(Offset = "0x3C")]
	private float _curVel;

	// Token: 0x04000A2A RID: 2602
	[Token(Token = "0x4000A2A")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<Collider> _activeColliders;
}
