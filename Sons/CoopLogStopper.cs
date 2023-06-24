using System;
using System.Collections;
using Il2CppDummyDll;
using TheForest.Utils.Physics;
using UnityEngine;

// Token: 0x020000BD RID: 189
[Token(Token = "0x20000BD")]
[AddComponentMenu("Endnight/TheForest/Coop/CoopLogStopper")]
public class CoopLogStopper : MonoBehaviour, IOnCollisionEnterProxy, IOnCollisionExitProxy
{
	// Token: 0x06000619 RID: 1561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000619")]
	[Address(RVA = "0x35125D0", Offset = "0x3510BD0", VA = "0x1835125D0")]
	private void OnSpawned()
	{
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061A")]
	[Address(RVA = "0x35125E0", Offset = "0x3510BE0", VA = "0x1835125E0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061B")]
	[Address(RVA = "0x3512A10", Offset = "0x3511010", VA = "0x183512A10", Slot = "4")]
	public void OnCollisionEnterProxied(Collision collision)
	{
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061C")]
	[Address(RVA = "0x3512C10", Offset = "0x3511210", VA = "0x183512C10", Slot = "5")]
	public void OnCollisionExitProxied(Collision collision)
	{
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061D")]
	[Address(RVA = "0x3512E70", Offset = "0x3511470", VA = "0x183512E70")]
	private IEnumerator Stop()
	{
		return null;
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061E")]
	[Address(RVA = "0x3512F00", Offset = "0x3511500", VA = "0x183512F00")]
	private IEnumerator FixClientCollision()
	{
		return null;
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061F")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public CoopLogStopper()
	{
	}

	// Token: 0x04000545 RID: 1349
	[Token(Token = "0x4000545")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody rb;

	// Token: 0x04000546 RID: 1350
	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Collider rbCollider;

	// Token: 0x04000547 RID: 1351
	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0x30")]
	private bool stopping;
}
