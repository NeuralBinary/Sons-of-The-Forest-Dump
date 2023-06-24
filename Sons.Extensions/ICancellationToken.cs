using System;
using Il2CppDummyDll;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public interface ICancellationToken
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000008 RID: 8
	[Token(Token = "0x17000003")]
	bool Cancelled { [Token(Token = "0x6000008")] get; }

	// Token: 0x06000009 RID: 9
	[Token(Token = "0x6000009")]
	void Start();
}
