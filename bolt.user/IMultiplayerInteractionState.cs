using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000045 RID: 69
[Token(Token = "0x2000045")]
public interface IMultiplayerInteractionState : IState, IDisposable
{
	// Token: 0x1700016B RID: 363
	// (get) Token: 0x060002B4 RID: 692
	// (set) Token: 0x060002B5 RID: 693
	[Token(Token = "0x1700016B")]
	string InteractionId { [Token(Token = "0x60002B4")] get; [Token(Token = "0x60002B5")] set; }

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x060002B6 RID: 694
	// (set) Token: 0x060002B7 RID: 695
	[Token(Token = "0x1700016C")]
	bool Ready { [Token(Token = "0x60002B6")] get; [Token(Token = "0x60002B7")] set; }

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x060002B8 RID: 696
	[Token(Token = "0x1700016D")]
	NetworkArray_Objects<NetworkConnectionId> ActivePlayers { [Token(Token = "0x60002B8")] get; }

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x060002B9 RID: 697
	// (set) Token: 0x060002BA RID: 698
	[Token(Token = "0x1700016E")]
	int LastPerformed { [Token(Token = "0x60002B9")] get; [Token(Token = "0x60002BA")] set; }
}
