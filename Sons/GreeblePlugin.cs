using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020001BA RID: 442
[Token(Token = "0x20001BA")]
public static class GreeblePlugin
{
	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700017F")]
	private static SpawnPool Pool
	{
		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x36EE310", Offset = "0x36EC910", VA = "0x1836EE310")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x36EE390", Offset = "0x36EC990", VA = "0x1836EE390")]
	public static GameObject Instantiate(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0x36EE660", Offset = "0x36ECC60", VA = "0x1836EE660")]
	public static void Destroy(GameObject instance)
	{
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0x36EE810", Offset = "0x36ECE10", VA = "0x1836EE810")]
	public static void Remove(GameObject instance)
	{
	}

	// Token: 0x04000B8A RID: 2954
	[Token(Token = "0x4000B8A")]
	private const string PoolId = "Greebles";
}
