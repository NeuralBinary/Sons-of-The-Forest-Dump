using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200003C RID: 60
[Token(Token = "0x200003C")]
public interface IWorldCharacter : IState, IDisposable
{
	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000168 RID: 360
	// (set) Token: 0x06000169 RID: 361
	[Token(Token = "0x1700009B")]
	float CharacterScale { [Token(Token = "0x6000168")] get; [Token(Token = "0x6000169")] set; }

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x0600016A RID: 362
	[Token(Token = "0x1700009C")]
	NetworkArray_Integer MecanimLayerHashes { [Token(Token = "0x600016A")] get; }

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x0600016B RID: 363
	[Token(Token = "0x1700009D")]
	NetworkArray_Float MecanimLayerWeights { [Token(Token = "0x600016B")] get; }

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x0600016C RID: 364
	[Token(Token = "0x1700009E")]
	NetworkArray_Float MecanimLayerTimes { [Token(Token = "0x600016C")] get; }

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x0600016D RID: 365
	// (set) Token: 0x0600016E RID: 366
	[Token(Token = "0x1700009F")]
	float MecanimSpeed { [Token(Token = "0x600016D")] get; [Token(Token = "0x600016E")] set; }
}
