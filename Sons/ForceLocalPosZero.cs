using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000DC RID: 220
[Token(Token = "0x20000DC")]
public class ForceLocalPosZero : MonoBehaviour
{
	// Token: 0x060006C8 RID: 1736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x3524750", Offset = "0x3522D50", VA = "0x183524750")]
	private void Start()
	{
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x3524A80", Offset = "0x3523080", VA = "0x183524A80")]
	private void LateUpdate()
	{
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x3525E40", Offset = "0x3524440", VA = "0x183525E40")]
	private void OnEnable()
	{
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x3525FB0", Offset = "0x35245B0", VA = "0x183525FB0")]
	private void OnDisable()
	{
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x35260E0", Offset = "0x35246E0", VA = "0x1835260E0")]
	private void unparent()
	{
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x3526110", Offset = "0x3524710", VA = "0x183526110")]
	private void ForcedUpdate()
	{
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x3526240", Offset = "0x3524840", VA = "0x183526240")]
	public void ClearOffset()
	{
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x3526480", Offset = "0x3524A80", VA = "0x183526480")]
	public ForceLocalPosZero()
	{
	}

	// Token: 0x0400058F RID: 1423
	[Token(Token = "0x400058F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform target;

	// Token: 0x04000590 RID: 1424
	[Token(Token = "0x4000590")]
	[FieldOffset(Offset = "0x28")]
	public float smoothTime;

	// Token: 0x04000591 RID: 1425
	[Token(Token = "0x4000591")]
	[FieldOffset(Offset = "0x2C")]
	public bool forcePositionUpdate;

	// Token: 0x04000592 RID: 1426
	[Token(Token = "0x4000592")]
	[FieldOffset(Offset = "0x2D")]
	public bool net;

	// Token: 0x04000593 RID: 1427
	[Token(Token = "0x4000593")]
	[FieldOffset(Offset = "0x2E")]
	public bool teleported;

	// Token: 0x04000594 RID: 1428
	[Token(Token = "0x4000594")]
	[FieldOffset(Offset = "0x30")]
	private readonly int deathTag;

	// Token: 0x04000595 RID: 1429
	[Token(Token = "0x4000595")]
	[FieldOffset(Offset = "0x34")]
	private readonly int getupTag;

	// Token: 0x04000596 RID: 1430
	[Token(Token = "0x4000596")]
	[FieldOffset(Offset = "0x38")]
	private Animator animator;

	// Token: 0x04000597 RID: 1431
	[Token(Token = "0x4000597")]
	[FieldOffset(Offset = "0x40")]
	private int layerMask;

	// Token: 0x04000598 RID: 1432
	[Token(Token = "0x4000598")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 localPos;

	// Token: 0x04000599 RID: 1433
	[Token(Token = "0x4000599")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 pos;

	// Token: 0x0400059A RID: 1434
	[Token(Token = "0x400059A")]
	[FieldOffset(Offset = "0x60")]
	private Transform tr;

	// Token: 0x0400059B RID: 1435
	[Token(Token = "0x400059B")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 velRef;
}
