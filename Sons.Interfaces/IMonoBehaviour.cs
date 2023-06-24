using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public interface IMonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1
	[Token(Token = "0x17000001")]
	GameObject gameObject { [Token(Token = "0x6000001")] get; }

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000002 RID: 2
	[Token(Token = "0x17000002")]
	Transform transform { [Token(Token = "0x6000002")] get; }

	// Token: 0x06000003 RID: 3
	[Token(Token = "0x6000003")]
	bool TryGetComponent<T>(out T comp);
}
