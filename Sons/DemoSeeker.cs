using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020002E1 RID: 737
[Token(Token = "0x20002E1")]
[RequireComponent(typeof(SmoothLookAtConstraint))]
[RequireComponent(typeof(Projectile))]
public class DemoSeeker : MonoBehaviour
{
	// Token: 0x0600135B RID: 4955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135B")]
	[Address(RVA = "0x31F4350", Offset = "0x31F2950", VA = "0x1831F4350")]
	private void Awake()
	{
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135C")]
	[Address(RVA = "0x31F4670", Offset = "0x31F2C70", VA = "0x1831F4670")]
	private void OnLaunched()
	{
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135D")]
	[Address(RVA = "0x31F46E0", Offset = "0x31F2CE0", VA = "0x1831F46E0")]
	private void OnLaunchedUpdate()
	{
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnDetonateProjectile(TargetList targets)
	{
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135F")]
	[Address(RVA = "0x31F4A00", Offset = "0x31F3000", VA = "0x1831F4A00")]
	public DemoSeeker()
	{
	}

	// Token: 0x04001334 RID: 4916
	[Token(Token = "0x4001334")]
	[FieldOffset(Offset = "0x20")]
	public float maxVelocity;

	// Token: 0x04001335 RID: 4917
	[Token(Token = "0x4001335")]
	[FieldOffset(Offset = "0x24")]
	public float acceleration;

	// Token: 0x04001336 RID: 4918
	[Token(Token = "0x4001336")]
	[FieldOffset(Offset = "0x28")]
	private Transform xform;

	// Token: 0x04001337 RID: 4919
	[Token(Token = "0x4001337")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rbd;

	// Token: 0x04001338 RID: 4920
	[Token(Token = "0x4001338")]
	[FieldOffset(Offset = "0x38")]
	private SmoothLookAtConstraint lookConstraint;

	// Token: 0x04001339 RID: 4921
	[Token(Token = "0x4001339")]
	[FieldOffset(Offset = "0x40")]
	private Projectile projectile;

	// Token: 0x0400133A RID: 4922
	[Token(Token = "0x400133A")]
	[FieldOffset(Offset = "0x48")]
	private float minDrag;

	// Token: 0x0400133B RID: 4923
	[Token(Token = "0x400133B")]
	[FieldOffset(Offset = "0x4C")]
	private float drag;
}
