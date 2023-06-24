using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000139 RID: 313
[Token(Token = "0x2000139")]
public class particleController : MonoBehaviour
{
	// Token: 0x0600091B RID: 2331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091B")]
	[Address(RVA = "0x36911F0", Offset = "0x368F7F0", VA = "0x1836911F0")]
	private void Start()
	{
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091C")]
	[Address(RVA = "0x36914D0", Offset = "0x368FAD0", VA = "0x1836914D0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091D")]
	[Address(RVA = "0x36915F0", Offset = "0x368FBF0", VA = "0x1836915F0")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091E")]
	[Address(RVA = "0x3691B00", Offset = "0x3690100", VA = "0x183691B00")]
	public particleController()
	{
	}

	// Token: 0x04000746 RID: 1862
	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0x20")]
	public bool applyLocalDrift;

	// Token: 0x04000747 RID: 1863
	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x24")]
	public float driftAmount;

	// Token: 0x04000748 RID: 1864
	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x28")]
	private Transform velocityTarget;

	// Token: 0x04000749 RID: 1865
	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 lastPos;

	// Token: 0x0400074A RID: 1866
	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem p;

	// Token: 0x0400074B RID: 1867
	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x48")]
	private ParticleSystem.Particle[] particles;
}
