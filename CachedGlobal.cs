using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A2 RID: 162
[Token(Token = "0x20000A2")]
internal struct CachedGlobal<T> where T : Component
{
	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000563 RID: 1379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000CC")]
	public T Component
	{
		[Token(Token = "0x6000563")]
		get
		{
			return null;
		}
	}

	// Token: 0x040004EA RID: 1258
	[Token(Token = "0x40004EA")]
	[FieldOffset(Offset = "0x0")]
	private T component;

	// Token: 0x040004EB RID: 1259
	[Token(Token = "0x40004EB")]
	[FieldOffset(Offset = "0x0")]
	private float lastCheck;
}
