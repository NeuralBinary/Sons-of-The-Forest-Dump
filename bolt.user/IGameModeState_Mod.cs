using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000036 RID: 54
[Token(Token = "0x2000036")]
public interface IGameModeState_Mod : IGameModeState, IState, IDisposable
{
	// Token: 0x17000085 RID: 133
	// (get) Token: 0x06000136 RID: 310
	// (set) Token: 0x06000137 RID: 311
	[Token(Token = "0x17000085")]
	Guid ModId { [Token(Token = "0x6000136")] get; [Token(Token = "0x6000137")] set; }
}
