using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class SpawnPoolPrewarmer : MonoBehaviour
{
	// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x28B0300", Offset = "0x28AE900", VA = "0x1828B0300")]
	private void Awake()
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x28B05F0", Offset = "0x28AEBF0", VA = "0x1828B05F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x28B0850", Offset = "0x28AEE50", VA = "0x1828B0850")]
	private IEnumerator SpawnInBackground()
	{
		return null;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x28B08E0", Offset = "0x28AEEE0", VA = "0x1828B08E0")]
	private IEnumerator HandleDespawn()
	{
		return null;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x28B0970", Offset = "0x28AEF70", VA = "0x1828B0970")]
	public List<GameObject> TakeEntries(string pool, string objName)
	{
		return null;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x28B0BD0", Offset = "0x28AF1D0", VA = "0x1828B0BD0")]
	public static List<GameObject> TakeEntriesFromInstance(string pool, string objName)
	{
		return null;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public SpawnPoolPrewarmer()
	{
	}

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x0")]
	public static SpawnPoolPrewarmer instance;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x20")]
	public Transform inactiveTransform;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x28")]
	public List<SpawnPoolEntry> entries;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x30")]
	private bool spawning;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x31")]
	private bool despawning;
}
