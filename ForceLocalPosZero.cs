using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000DE RID: 222
[Token(Token = "0x20000DE")]
public class ForceLocalPosZero : MonoBehaviour
{
	// Token: 0x0600067E RID: 1662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067E")]
	[Address(RVA = "0x2E86E00", Offset = "0x2E85E00", VA = "0x182E86E00")]
	private void Start()
	{
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067F")]
	[Address(RVA = "0x2E86070", Offset = "0x2E85070", VA = "0x182E86070")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000680")]
	[Address(RVA = "0x2E86D40", Offset = "0x2E85D40", VA = "0x182E86D40")]
	private void OnEnable()
	{
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000681")]
	[Address(RVA = "0x2E86CB0", Offset = "0x2E85CB0", VA = "0x182E86CB0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000682")]
	[Address(RVA = "0x2E86FB0", Offset = "0x2E85FB0", VA = "0x182E86FB0")]
	private void unparent()
	{
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000683")]
	[Address(RVA = "0x2E86000", Offset = "0x2E85000", VA = "0x182E86000")]
	private void ForcedUpdate()
	{
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000684")]
	[Address(RVA = "0x2E86F20", Offset = "0x2E85F20", VA = "0x182E86F20")]
	public ForceLocalPosZero()
	{
	}

	// Token: 0x04000572 RID: 1394
	[Token(Token = "0x4000572")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform target;

	// Token: 0x04000573 RID: 1395
	[Token(Token = "0x4000573")]
	[FieldOffset(Offset = "0x28")]
	public float smoothTime;

	// Token: 0x04000574 RID: 1396
	[Token(Token = "0x4000574")]
	[FieldOffset(Offset = "0x2C")]
	public bool forcePositionUpdate;

	// Token: 0x04000575 RID: 1397
	[Token(Token = "0x4000575")]
	[FieldOffset(Offset = "0x2D")]
	public bool net;

	// Token: 0x04000576 RID: 1398
	[Token(Token = "0x4000576")]
	[FieldOffset(Offset = "0x2E")]
	public bool teleported;

	// Token: 0x04000577 RID: 1399
	[Token(Token = "0x4000577")]
	[FieldOffset(Offset = "0x30")]
	private readonly int deathTag;

	// Token: 0x04000578 RID: 1400
	[Token(Token = "0x4000578")]
	[FieldOffset(Offset = "0x34")]
	private readonly int getupTag;

	// Token: 0x04000579 RID: 1401
	[Token(Token = "0x4000579")]
	[FieldOffset(Offset = "0x38")]
	private Animator animator;

	// Token: 0x0400057A RID: 1402
	[Token(Token = "0x400057A")]
	[FieldOffset(Offset = "0x40")]
	private int layerMask;

	// Token: 0x0400057B RID: 1403
	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 localPos;

	// Token: 0x0400057C RID: 1404
	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 pos;

	// Token: 0x0400057D RID: 1405
	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x60")]
	private Transform tr;

	// Token: 0x0400057E RID: 1406
	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 velRef;
}
