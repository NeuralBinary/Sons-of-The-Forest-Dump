using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200017A RID: 378
[Token(Token = "0x200017A")]
public class spawnItem : MonoBehaviour
{
	// Token: 0x06000B1E RID: 2846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x2F74FB0", Offset = "0x2F73FB0", VA = "0x182F74FB0")]
	private void invokePickupSpawn()
	{
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x2F74F40", Offset = "0x2F73F40", VA = "0x182F74F40")]
	public IEnumerator doPickupSpawn()
	{
		return null;
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public spawnItem()
	{
	}

	// Token: 0x040009E8 RID: 2536
	[Token(Token = "0x40009E8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] pickupSpawn;

	// Token: 0x040009E9 RID: 2537
	[Token(Token = "0x40009E9")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 pos;
}
