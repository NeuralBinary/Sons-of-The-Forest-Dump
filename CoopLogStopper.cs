using System;
using System.Collections;
using Il2CppDummyDll;
using TheForest.Utils.Physics;
using UnityEngine;

// Token: 0x020000BF RID: 191
[Token(Token = "0x20000BF")]
[AddComponentMenu("Endnight/TheForest/Coop/CoopLogStopper")]
public class CoopLogStopper : MonoBehaviour, IOnCollisionEnterProxy, IOnCollisionExitProxy
{
	// Token: 0x060005E3 RID: 1507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x2E78420", Offset = "0x2E77420", VA = "0x182E78420")]
	private void OnSpawned()
	{
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x2E78210", Offset = "0x2E77210", VA = "0x182E78210")]
	private void OnEnable()
	{
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x2E77FA0", Offset = "0x2E76FA0", VA = "0x182E77FA0", Slot = "4")]
	public void OnCollisionEnterProxied(Collision collision)
	{
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x2E780D0", Offset = "0x2E770D0", VA = "0x182E780D0", Slot = "5")]
	public void OnCollisionExitProxied(Collision collision)
	{
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x2E78430", Offset = "0x2E77430", VA = "0x182E78430")]
	private IEnumerator Stop()
	{
		return null;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x2E77F30", Offset = "0x2E76F30", VA = "0x182E77F30")]
	private IEnumerator FixClientCollision()
	{
		return null;
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public CoopLogStopper()
	{
	}

	// Token: 0x0400052B RID: 1323
	[Token(Token = "0x400052B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody rb;

	// Token: 0x0400052C RID: 1324
	[Token(Token = "0x400052C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Collider rbCollider;

	// Token: 0x0400052D RID: 1325
	[Token(Token = "0x400052D")]
	[FieldOffset(Offset = "0x30")]
	private bool stopping;
}
