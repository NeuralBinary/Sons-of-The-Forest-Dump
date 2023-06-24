using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000021 RID: 33
[Token(Token = "0x2000021")]
public interface IMolotovState : IRigidbodyState, IState, IDisposable
{
	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060000AF RID: 175
	// (set) Token: 0x060000B0 RID: 176
	[Token(Token = "0x17000046")]
	bool Broken { [Token(Token = "0x60000AF")] get; [Token(Token = "0x60000B0")] set; }

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060000B1 RID: 177
	// (set) Token: 0x060000B2 RID: 178
	[Token(Token = "0x17000047")]
	bool Wet { [Token(Token = "0x60000B1")] get; [Token(Token = "0x60000B2")] set; }
}
