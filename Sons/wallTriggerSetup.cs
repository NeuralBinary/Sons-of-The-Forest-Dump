using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000184 RID: 388
[Token(Token = "0x2000184")]
public class wallTriggerSetup : MonoBehaviour
{
	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00004E48 File Offset: 0x00003048
	// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700016F")]
	public bool BuildingSystemControllingWeaponClipBlend
	{
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00004E60 File Offset: 0x00003060
	[Token(Token = "0x17000170")]
	private bool ForceWeaponClipBlendToZero
	{
		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00004E78 File Offset: 0x00003078
	[Token(Token = "0x17000171")]
	public bool AtWall
	{
		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x36D7AF0", Offset = "0x36D60F0", VA = "0x1836D7AF0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0x36D7B40", Offset = "0x36D6140", VA = "0x1836D7B40")]
	private void OnValidate()
	{
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x00004E90 File Offset: 0x00003090
	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x36D7E30", Offset = "0x36D6430", VA = "0x1836D7E30")]
	private bool IsWallCollider(Collider other)
	{
		return default(bool);
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x36D80F0", Offset = "0x36D66F0", VA = "0x1836D80F0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x36D8180", Offset = "0x36D6780", VA = "0x1836D8180")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x36D81E0", Offset = "0x36D67E0", VA = "0x1836D81E0")]
	private void Update()
	{
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x36D85A0", Offset = "0x36D6BA0", VA = "0x1836D85A0")]
	public wallTriggerSetup()
	{
	}

	// Token: 0x04000A4D RID: 2637
	[Token(Token = "0x4000A4D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator _animator;

	// Token: 0x04000A4E RID: 2638
	[Token(Token = "0x4000A4E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _smoothTime;

	// Token: 0x04000A4F RID: 2639
	[Token(Token = "0x4000A4F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Collider _triggerCollider;

	// Token: 0x04000A50 RID: 2640
	[Token(Token = "0x4000A50")]
	[FieldOffset(Offset = "0x38")]
	private float _smoothVal;

	// Token: 0x04000A51 RID: 2641
	[Token(Token = "0x4000A51")]
	[FieldOffset(Offset = "0x3C")]
	private float _curVel;

	// Token: 0x04000A53 RID: 2643
	[Token(Token = "0x4000A53")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<Collider> _activeColliders;
}
