using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone Collider")]
public class DynamicBoneCollider : DynamicBoneColliderBase
{
	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0xA5A410", Offset = "0xA58A10", VA = "0x180A5A410")]
	private void OnValidate()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x6000024")]
	[Address(RVA = "0xA5A440", Offset = "0xA58A40", VA = "0x180A5A440", Slot = "4")]
	public override bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		return default(bool);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x6000025")]
	[Address(RVA = "0xA5AD10", Offset = "0xA59310", VA = "0x180A5AD10")]
	private static bool OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		return default(bool);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000026")]
	[Address(RVA = "0xA5AE50", Offset = "0xA59450", VA = "0x180A5AE50")]
	private static bool InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		return default(bool);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x6000027")]
	[Address(RVA = "0xA5AF80", Offset = "0xA59580", VA = "0x180A5AF80")]
	private static bool OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
		return default(bool);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x6000028")]
	[Address(RVA = "0xA5B2B0", Offset = "0xA598B0", VA = "0x180A5B2B0")]
	private static bool InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
		return default(bool);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000029")]
	[Address(RVA = "0xA5B5C0", Offset = "0xA59BC0", VA = "0x180A5B5C0")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0xA5BB90", Offset = "0xA5A190", VA = "0x180A5BB90")]
	public DynamicBoneCollider()
	{
	}

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x38")]
	[Tooltip("The radius of the sphere or capsule.")]
	public float m_Radius;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x3C")]
	[Tooltip("The height of the capsule.")]
	public float m_Height;
}
