using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A5 RID: 421
[Token(Token = "0x20001A5")]
public class effectSpawnVolume : MonoBehaviour
{
	// Token: 0x06000C70 RID: 3184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C70")]
	[Address(RVA = "0x71EE50", Offset = "0x71D450", VA = "0x18071EE50")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C71")]
	[Address(RVA = "0x36E6590", Offset = "0x36E4B90", VA = "0x1836E6590")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x36E65A0", Offset = "0x36E4BA0", VA = "0x1836E65A0")]
	private void Update()
	{
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x36E6820", Offset = "0x36E4E20", VA = "0x1836E6820")]
	public effectSpawnVolume()
	{
	}

	// Token: 0x04000AEE RID: 2798
	[Token(Token = "0x4000AEE")]
	[FieldOffset(Offset = "0x20")]
	public Transform effectToSpawn;

	// Token: 0x04000AEF RID: 2799
	[Token(Token = "0x4000AEF")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 spawnPosition;

	// Token: 0x04000AF0 RID: 2800
	[Token(Token = "0x4000AF0")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 spawnRotation;

	// Token: 0x04000AF1 RID: 2801
	[Token(Token = "0x4000AF1")]
	[FieldOffset(Offset = "0x40")]
	public bool armed;
}
