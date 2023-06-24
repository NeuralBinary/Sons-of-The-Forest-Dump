using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000033 RID: 51
[Token(Token = "0x2000033")]
public interface IGardenPlotStructureState : IScrewStructureWithStorageState, IScrewStructureState, IState, IDisposable
{
	// Token: 0x17000070 RID: 112
	// (get) Token: 0x0600010E RID: 270
	// (set) Token: 0x0600010F RID: 271
	[Token(Token = "0x17000070")]
	bool IsBusy { [Token(Token = "0x600010E")] get; [Token(Token = "0x600010F")] set; }

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06000110 RID: 272
	// (set) Token: 0x06000111 RID: 273
	[Token(Token = "0x17000071")]
	bool HasPlant { [Token(Token = "0x6000110")] get; [Token(Token = "0x6000111")] set; }

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06000112 RID: 274
	// (set) Token: 0x06000113 RID: 275
	[Token(Token = "0x17000072")]
	bool IsGrowing { [Token(Token = "0x6000112")] get; [Token(Token = "0x6000113")] set; }

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06000114 RID: 276
	// (set) Token: 0x06000115 RID: 277
	[Token(Token = "0x17000073")]
	int SeedId { [Token(Token = "0x6000114")] get; [Token(Token = "0x6000115")] set; }

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06000116 RID: 278
	// (set) Token: 0x06000117 RID: 279
	[Token(Token = "0x17000074")]
	int HarvestType { [Token(Token = "0x6000116")] get; [Token(Token = "0x6000117")] set; }

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06000118 RID: 280
	// (set) Token: 0x06000119 RID: 281
	[Token(Token = "0x17000075")]
	float PlantGrowTimeRemaining { [Token(Token = "0x6000118")] get; [Token(Token = "0x6000119")] set; }

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x0600011A RID: 282
	[Token(Token = "0x17000076")]
	NetworkArray_Float ProduceGrowTimeRemaining { [Token(Token = "0x600011A")] get; }
}
