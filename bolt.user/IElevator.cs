using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000039 RID: 57
[Token(Token = "0x2000039")]
public interface IElevator : IState, IDisposable
{
	// Token: 0x1700008E RID: 142
	// (get) Token: 0x0600014B RID: 331
	// (set) Token: 0x0600014C RID: 332
	[Token(Token = "0x1700008E")]
	bool Locked { [Token(Token = "0x600014B")] get; [Token(Token = "0x600014C")] set; }

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x0600014D RID: 333
	// (set) Token: 0x0600014E RID: 334
	[Token(Token = "0x1700008F")]
	int Door { [Token(Token = "0x600014D")] get; [Token(Token = "0x600014E")] set; }

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x0600014F RID: 335
	// (set) Token: 0x06000150 RID: 336
	[Token(Token = "0x17000090")]
	int Location { [Token(Token = "0x600014F")] get; [Token(Token = "0x6000150")] set; }

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000151 RID: 337
	// (set) Token: 0x06000152 RID: 338
	[Token(Token = "0x17000091")]
	string SpawnId { [Token(Token = "0x6000151")] get; [Token(Token = "0x6000152")] set; }

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000153 RID: 339
	// (set) Token: 0x06000154 RID: 340
	[Token(Token = "0x17000092")]
	int PlayerCount { [Token(Token = "0x6000153")] get; [Token(Token = "0x6000154")] set; }
}
