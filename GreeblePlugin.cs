using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020001BB RID: 443
[Token(Token = "0x20001BB")]
public static class GreeblePlugin
{
	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000176")]
	private static SpawnPool Pool
	{
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x2F68B90", Offset = "0x2F67B90", VA = "0x182F68B90")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0x2F686D0", Offset = "0x2F676D0", VA = "0x182F686D0")]
	public static GameObject Instantiate(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x2F68620", Offset = "0x2F67620", VA = "0x182F68620")]
	public static void Destroy(GameObject instance)
	{
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x2F68B00", Offset = "0x2F67B00", VA = "0x182F68B00")]
	public static void Remove(GameObject instance)
	{
	}

	// Token: 0x04000B5B RID: 2907
	[Token(Token = "0x4000B5B")]
	private const string PoolId = "Greebles";
}
