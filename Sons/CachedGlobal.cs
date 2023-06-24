using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A1 RID: 161
[Token(Token = "0x20000A1")]
internal struct CachedGlobal<T> where T : Component
{
	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x0600058B RID: 1419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000D2")]
	public T Component
	{
		[Token(Token = "0x600058B")]
		get
		{
			return null;
		}
	}

	// Token: 0x04000507 RID: 1287
	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x0")]
	private T component;

	// Token: 0x04000508 RID: 1288
	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x0")]
	private float lastCheck;
}
