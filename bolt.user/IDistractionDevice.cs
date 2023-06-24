using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200004E RID: 78
[Token(Token = "0x200004E")]
public interface IDistractionDevice : IDynamicPickup, IState, IDisposable
{
	// Token: 0x17000186 RID: 390
	// (get) Token: 0x060002F1 RID: 753
	// (set) Token: 0x060002F2 RID: 754
	[Token(Token = "0x17000186")]
	int MusicTrack { [Token(Token = "0x60002F1")] get; [Token(Token = "0x60002F2")] set; }
}
