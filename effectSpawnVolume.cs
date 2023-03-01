using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A6 RID: 422
[Token(Token = "0x20001A6")]
public class effectSpawnVolume : MonoBehaviour
{
	// Token: 0x06000C16 RID: 3094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C16")]
	[Address(RVA = "0x683D30", Offset = "0x682D30", VA = "0x180683D30")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C17")]
	[Address(RVA = "0x2F74910", Offset = "0x2F73910", VA = "0x182F74910")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C18")]
	[Address(RVA = "0x2F74920", Offset = "0x2F73920", VA = "0x182F74920")]
	private void Update()
	{
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x2F74AB0", Offset = "0x2F73AB0", VA = "0x182F74AB0")]
	public effectSpawnVolume()
	{
	}

	// Token: 0x04000AC3 RID: 2755
	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x20")]
	public Transform effectToSpawn;

	// Token: 0x04000AC4 RID: 2756
	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 spawnPosition;

	// Token: 0x04000AC5 RID: 2757
	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 spawnRotation;

	// Token: 0x04000AC6 RID: 2758
	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0x40")]
	public bool armed;
}
