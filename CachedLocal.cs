using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A3 RID: 163
[Token(Token = "0x20000A3")]
internal struct CachedLocal<T> where T : Component
{
	// Token: 0x06000564 RID: 1380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000564")]
	public CachedLocal(GameObject gameObject)
	{
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000CD")]
	public T Component
	{
		[Token(Token = "0x6000565")]
		get
		{
			return null;
		}
	}

	// Token: 0x040004EC RID: 1260
	[Token(Token = "0x40004EC")]
	[FieldOffset(Offset = "0x0")]
	private T component;

	// Token: 0x040004ED RID: 1261
	[Token(Token = "0x40004ED")]
	[FieldOffset(Offset = "0x0")]
	private GameObject go;
}
