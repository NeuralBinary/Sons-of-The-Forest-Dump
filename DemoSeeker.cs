using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020002ED RID: 749
[Token(Token = "0x20002ED")]
[RequireComponent(typeof(Projectile))]
[RequireComponent(typeof(SmoothLookAtConstraint))]
public class DemoSeeker : MonoBehaviour
{
	// Token: 0x06001325 RID: 4901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001325")]
	[Address(RVA = "0x2C62F30", Offset = "0x2C61F30", VA = "0x182C62F30")]
	private void Awake()
	{
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001326")]
	[Address(RVA = "0x2C632F0", Offset = "0x2C622F0", VA = "0x182C632F0")]
	private void OnLaunched()
	{
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001327")]
	[Address(RVA = "0x2C63110", Offset = "0x2C62110", VA = "0x182C63110")]
	private void OnLaunchedUpdate()
	{
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001328")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void OnDetonateProjectile(TargetList targets)
	{
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001329")]
	[Address(RVA = "0x2C63320", Offset = "0x2C62320", VA = "0x182C63320")]
	public DemoSeeker()
	{
	}

	// Token: 0x0400130C RID: 4876
	[Token(Token = "0x400130C")]
	[FieldOffset(Offset = "0x20")]
	public float maxVelocity;

	// Token: 0x0400130D RID: 4877
	[Token(Token = "0x400130D")]
	[FieldOffset(Offset = "0x24")]
	public float acceleration;

	// Token: 0x0400130E RID: 4878
	[Token(Token = "0x400130E")]
	[FieldOffset(Offset = "0x28")]
	private Transform xform;

	// Token: 0x0400130F RID: 4879
	[Token(Token = "0x400130F")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rbd;

	// Token: 0x04001310 RID: 4880
	[Token(Token = "0x4001310")]
	[FieldOffset(Offset = "0x38")]
	private SmoothLookAtConstraint lookConstraint;

	// Token: 0x04001311 RID: 4881
	[Token(Token = "0x4001311")]
	[FieldOffset(Offset = "0x40")]
	private Projectile projectile;

	// Token: 0x04001312 RID: 4882
	[Token(Token = "0x4001312")]
	[FieldOffset(Offset = "0x48")]
	private float minDrag;

	// Token: 0x04001313 RID: 4883
	[Token(Token = "0x4001313")]
	[FieldOffset(Offset = "0x4C")]
	private float drag;
}
