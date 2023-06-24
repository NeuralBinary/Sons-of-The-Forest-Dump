using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
[Documentation]
public abstract class BoltSingletonPrefab<T> : MonoBehaviour where T : MonoBehaviour
{
	// Token: 0x1700001D RID: 29
	// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001D")]
	public static T instance
	{
		[Token(Token = "0x60000B1")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B2")]
	public static void Instantiate()
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B3")]
	protected BoltSingletonPrefab()
	{
	}

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x0")]
	private static T _instance;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x0")]
	protected static string _resourcePath;
}
