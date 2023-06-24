using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200002D RID: 45
[Token(Token = "0x200002D")]
public interface IVailWorldState : IState, IDisposable
{
	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060000ED RID: 237
	// (set) Token: 0x060000EE RID: 238
	[Token(Token = "0x17000060")]
	int OpenCaveMask { [Token(Token = "0x60000ED")] get; [Token(Token = "0x60000EE")] set; }

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060000EF RID: 239
	// (set) Token: 0x060000F0 RID: 240
	[Token(Token = "0x17000061")]
	int WorldFlags { [Token(Token = "0x60000EF")] get; [Token(Token = "0x60000F0")] set; }
}
