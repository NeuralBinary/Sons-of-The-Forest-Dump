using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A2 RID: 162
[Token(Token = "0x20000A2")]
internal struct CachedLocal<T> where T : Component
{
	// Token: 0x0600058C RID: 1420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058C")]
	public CachedLocal(GameObject gameObject)
	{
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x0600058D RID: 1421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000D3")]
	public T Component
	{
		[Token(Token = "0x600058D")]
		get
		{
			return null;
		}
	}

	// Token: 0x04000509 RID: 1289
	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x0")]
	private T component;

	// Token: 0x0400050A RID: 1290
	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x0")]
	private GameObject go;
}
