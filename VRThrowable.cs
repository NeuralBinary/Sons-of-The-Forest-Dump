using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C6 RID: 710
[Token(Token = "0x20002C6")]
public class VRThrowable : MonoBehaviour
{
	// Token: 0x06001234 RID: 4660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001234")]
	[Address(RVA = "0x21F6BA0", Offset = "0x21F5BA0", VA = "0x1821F6BA0")]
	private void Start()
	{
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001235")]
	[Address(RVA = "0x2B8E040", Offset = "0x2B8D040", VA = "0x182B8E040")]
	private void Update()
	{
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001236")]
	[Address(RVA = "0x2B8DCD0", Offset = "0x2B8CCD0", VA = "0x182B8DCD0")]
	private void ThrowProjectile()
	{
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001237")]
	[Address(RVA = "0x2B8E160", Offset = "0x2B8D160", VA = "0x182B8E160")]
	public VRThrowable()
	{
	}

	// Token: 0x04001233 RID: 4659
	[Token(Token = "0x4001233")]
	[FieldOffset(Offset = "0x20")]
	private float MinThrowVelocity;

	// Token: 0x04001234 RID: 4660
	[Token(Token = "0x4001234")]
	[FieldOffset(Offset = "0x24")]
	public float ThrowForceMultiply;

	// Token: 0x04001235 RID: 4661
	[Token(Token = "0x4001235")]
	[FieldOffset(Offset = "0x28")]
	public bool IgnoreAngularVelocity;

	// Token: 0x04001236 RID: 4662
	[Token(Token = "0x4001236")]
	[FieldOffset(Offset = "0x29")]
	public bool SpearType;

	// Token: 0x04001237 RID: 4663
	[Token(Token = "0x4001237")]
	[FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public Vector3 lastThrowForce;

	// Token: 0x04001238 RID: 4664
	[Token(Token = "0x4001238")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Vector3 lastThrowForceAngular;

	// Token: 0x04001239 RID: 4665
	[Token(Token = "0x4001239")]
	[FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public Vector3 lastThrowPosition;

	// Token: 0x0400123A RID: 4666
	[Token(Token = "0x400123A")]
	[FieldOffset(Offset = "0x50")]
	private bool AllowThrowing;

	// Token: 0x0400123B RID: 4667
	[Token(Token = "0x400123B")]
	[FieldOffset(Offset = "0x51")]
	private bool checkThrowRelease;
}
