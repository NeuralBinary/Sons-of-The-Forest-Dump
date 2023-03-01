using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011E RID: 286
[Token(Token = "0x200011E")]
public class fixCollisionOnSpawn : MonoBehaviour
{
	// Token: 0x06000857 RID: 2135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000857")]
	[Address(RVA = "0x2F47F90", Offset = "0x2F46F90", VA = "0x182F47F90")]
	private void OnEnable()
	{
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000858")]
	[Address(RVA = "0x2F48220", Offset = "0x2F47220", VA = "0x182F48220")]
	private IEnumerator fixGardenCollision()
	{
		return null;
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000859")]
	[Address(RVA = "0x2F48080", Offset = "0x2F47080", VA = "0x182F48080")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085A")]
	[Address(RVA = "0x2F48290", Offset = "0x2F47290", VA = "0x182F48290")]
	private IEnumerator repositionOtherRigidBody(Rigidbody targetRb)
	{
		return null;
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085B")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public fixCollisionOnSpawn()
	{
	}

	// Token: 0x040006C4 RID: 1732
	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0x20")]
	public bool fixGarden;

	// Token: 0x040006C5 RID: 1733
	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0x28")]
	private MeshCollider thisCollider;
}
