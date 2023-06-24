using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200001E RID: 30
[Token(Token = "0x200001E")]
public interface IStorageContainerState : IRigidbodyState, IState, IDisposable
{
	// Token: 0x1700003E RID: 62
	// (get) Token: 0x0600009D RID: 157
	// (set) Token: 0x0600009E RID: 158
	[Token(Token = "0x1700003E")]
	bool IsOpen { [Token(Token = "0x600009D")] get; [Token(Token = "0x600009E")] set; }

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x0600009F RID: 159
	// (set) Token: 0x060000A0 RID: 160
	[Token(Token = "0x1700003F")]
	int ContentsSeed { [Token(Token = "0x600009F")] get; [Token(Token = "0x60000A0")] set; }
}
