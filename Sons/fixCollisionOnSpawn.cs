using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011B RID: 283
[Token(Token = "0x200011B")]
public class fixCollisionOnSpawn : MonoBehaviour
{
	// Token: 0x0600089E RID: 2206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089E")]
	[Address(RVA = "0x368A350", Offset = "0x3688950", VA = "0x18368A350")]
	private void OnEnable()
	{
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600089F")]
	[Address(RVA = "0x368A530", Offset = "0x3688B30", VA = "0x18368A530")]
	private IEnumerator fixGardenCollision()
	{
		return null;
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x368A5C0", Offset = "0x3688BC0", VA = "0x18368A5C0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x368A920", Offset = "0x3688F20", VA = "0x18368A920")]
	private IEnumerator repositionOtherRigidBody(Rigidbody targetRb)
	{
		return null;
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A2")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public fixCollisionOnSpawn()
	{
	}

	// Token: 0x040006E0 RID: 1760
	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0x20")]
	public bool fixGarden;

	// Token: 0x040006E1 RID: 1761
	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0x28")]
	private MeshCollider thisCollider;
}
