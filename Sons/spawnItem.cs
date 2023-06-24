using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000179 RID: 377
[Token(Token = "0x2000179")]
public class spawnItem : MonoBehaviour
{
	// Token: 0x06000B77 RID: 2935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x36D1880", Offset = "0x36CFE80", VA = "0x1836D1880")]
	private void invokePickupSpawn()
	{
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x36D18C0", Offset = "0x36CFEC0", VA = "0x1836D18C0")]
	public IEnumerator doPickupSpawn()
	{
		return null;
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public spawnItem()
	{
	}

	// Token: 0x04000A11 RID: 2577
	[Token(Token = "0x4000A11")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] pickupSpawn;

	// Token: 0x04000A12 RID: 2578
	[Token(Token = "0x4000A12")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 pos;
}
