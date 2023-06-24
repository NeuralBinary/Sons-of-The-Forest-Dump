using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F6 RID: 246
[Token(Token = "0x20000F6")]
public class alignMolotovFire : MonoBehaviour
{
	// Token: 0x06000791 RID: 1937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000791")]
	[Address(RVA = "0x3678C60", Offset = "0x3677260", VA = "0x183678C60")]
	private void Awake()
	{
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000792")]
	[Address(RVA = "0x34B1170", Offset = "0x34AF770", VA = "0x1834B1170")]
	private void Start()
	{
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000793")]
	[Address(RVA = "0x3678D80", Offset = "0x3677380", VA = "0x183678D80")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000794")]
	[Address(RVA = "0x3679AB0", Offset = "0x36780B0", VA = "0x183679AB0")]
	public alignMolotovFire()
	{
	}

	// Token: 0x04000603 RID: 1539
	[Token(Token = "0x4000603")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x04000604 RID: 1540
	[Token(Token = "0x4000604")]
	[FieldOffset(Offset = "0x28")]
	public Transform followTarget;

	// Token: 0x04000605 RID: 1541
	[Token(Token = "0x4000605")]
	[FieldOffset(Offset = "0x30")]
	public Transform dummyTarget;

	// Token: 0x04000606 RID: 1542
	[Token(Token = "0x4000606")]
	[FieldOffset(Offset = "0x38")]
	public float xOffset;

	// Token: 0x04000607 RID: 1543
	[Token(Token = "0x4000607")]
	[FieldOffset(Offset = "0x40")]
	private Transform origParent;

	// Token: 0x04000608 RID: 1544
	[Token(Token = "0x4000608")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 pos;

	// Token: 0x04000609 RID: 1545
	[Token(Token = "0x4000609")]
	[FieldOffset(Offset = "0x54")]
	public float smoothTime;

	// Token: 0x0400060A RID: 1546
	[Token(Token = "0x400060A")]
	[FieldOffset(Offset = "0x58")]
	public float followDistance;

	// Token: 0x0400060B RID: 1547
	[Token(Token = "0x400060B")]
	[FieldOffset(Offset = "0x5C")]
	public bool net;
}
