using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
[Serializable]
public class SpawnPoolEntry
{
	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000045 RID: 69 RVA: 0x000020CA File Offset: 0x000002CA
	// (set) Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000010")]
	public List<GameObject> spawnedPrefabs
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x9D2340", Offset = "0x9D0940", VA = "0x1809D2340")]
	public SpawnPoolEntry(string poolName, GameObject prefab, int numToPrewarm)
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x28B11D0", Offset = "0x28AF7D0", VA = "0x1828B11D0")]
	public void HandleSpawn(Transform newParent)
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x28B1550", Offset = "0x28AFB50", VA = "0x1828B1550")]
	public void Cleanup()
	{
	}

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x10")]
	public string poolName;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x18")]
	public GameObject prefab;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x20")]
	public int numToPrewarm;
}
