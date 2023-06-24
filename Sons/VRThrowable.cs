using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BA RID: 698
[Token(Token = "0x20002BA")]
public class VRThrowable : MonoBehaviour
{
	// Token: 0x06001269 RID: 4713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001269")]
	[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
	private void Start()
	{
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126A")]
	[Address(RVA = "0x31DBD60", Offset = "0x31DA360", VA = "0x1831DBD60")]
	private void Update()
	{
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126B")]
	[Address(RVA = "0x31DBE80", Offset = "0x31DA480", VA = "0x1831DBE80")]
	private void ThrowProjectile()
	{
	}

	// Token: 0x0600126C RID: 4716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126C")]
	[Address(RVA = "0x31DC2C0", Offset = "0x31DA8C0", VA = "0x1831DC2C0")]
	public VRThrowable()
	{
	}

	// Token: 0x0400125A RID: 4698
	[Token(Token = "0x400125A")]
	[FieldOffset(Offset = "0x20")]
	private float MinThrowVelocity;

	// Token: 0x0400125B RID: 4699
	[Token(Token = "0x400125B")]
	[FieldOffset(Offset = "0x24")]
	public float ThrowForceMultiply;

	// Token: 0x0400125C RID: 4700
	[Token(Token = "0x400125C")]
	[FieldOffset(Offset = "0x28")]
	public bool IgnoreAngularVelocity;

	// Token: 0x0400125D RID: 4701
	[Token(Token = "0x400125D")]
	[FieldOffset(Offset = "0x29")]
	public bool SpearType;

	// Token: 0x0400125E RID: 4702
	[Token(Token = "0x400125E")]
	[FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public Vector3 lastThrowForce;

	// Token: 0x0400125F RID: 4703
	[Token(Token = "0x400125F")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Vector3 lastThrowForceAngular;

	// Token: 0x04001260 RID: 4704
	[Token(Token = "0x4001260")]
	[FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public Vector3 lastThrowPosition;

	// Token: 0x04001261 RID: 4705
	[Token(Token = "0x4001261")]
	[FieldOffset(Offset = "0x50")]
	private bool AllowThrowing;

	// Token: 0x04001262 RID: 4706
	[Token(Token = "0x4001262")]
	[FieldOffset(Offset = "0x51")]
	private bool checkThrowRelease;
}
