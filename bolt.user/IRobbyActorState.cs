using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000A2 RID: 162
[Token(Token = "0x20000A2")]
public interface IRobbyActorState : IMecanimVailActorState, IWorldCharacter, IState, IDisposable
{
	// Token: 0x170003D2 RID: 978
	// (get) Token: 0x060006E0 RID: 1760
	// (set) Token: 0x060006E1 RID: 1761
	[Token(Token = "0x170003D2")]
	int Injured { [Token(Token = "0x60006E0")] get; [Token(Token = "0x60006E1")] set; }

	// Token: 0x170003D3 RID: 979
	// (get) Token: 0x060006E2 RID: 1762
	// (set) Token: 0x060006E3 RID: 1763
	[Token(Token = "0x170003D3")]
	bool ShowAxe { [Token(Token = "0x60006E2")] get; [Token(Token = "0x60006E3")] set; }

	// Token: 0x170003D4 RID: 980
	// (get) Token: 0x060006E4 RID: 1764
	// (set) Token: 0x060006E5 RID: 1765
	[Token(Token = "0x170003D4")]
	int Race { [Token(Token = "0x60006E4")] get; [Token(Token = "0x60006E5")] set; }

	// Token: 0x170003D5 RID: 981
	// (get) Token: 0x060006E6 RID: 1766
	[Token(Token = "0x170003D5")]
	NetworkArray_Integer ClothingIds { [Token(Token = "0x60006E6")] get; }
}
