using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000B1 RID: 177
[Token(Token = "0x20000B1")]
public interface IFireState : IFreeFormStructureState, IState, IDisposable
{
	// Token: 0x1700045F RID: 1119
	// (get) Token: 0x060007F6 RID: 2038
	// (set) Token: 0x060007F7 RID: 2039
	[Token(Token = "0x1700045F")]
	bool Lit { [Token(Token = "0x60007F6")] get; [Token(Token = "0x60007F7")] set; }

	// Token: 0x17000460 RID: 1120
	// (get) Token: 0x060007F8 RID: 2040
	// (set) Token: 0x060007F9 RID: 2041
	[Token(Token = "0x17000460")]
	float Fuel { [Token(Token = "0x60007F8")] get; [Token(Token = "0x60007F9")] set; }

	// Token: 0x17000461 RID: 1121
	// (get) Token: 0x060007FA RID: 2042
	// (set) Token: 0x060007FB RID: 2043
	[Token(Token = "0x17000461")]
	Action OnFuelAdded { [Token(Token = "0x60007FA")] get; [Token(Token = "0x60007FB")] set; }

	// Token: 0x17000462 RID: 1122
	// (get) Token: 0x060007FC RID: 2044
	[Token(Token = "0x17000462")]
	StoredItemsData CookingStorage { [Token(Token = "0x60007FC")] get; }

	// Token: 0x17000463 RID: 1123
	// (get) Token: 0x060007FD RID: 2045
	[Token(Token = "0x17000463")]
	NetworkArray_Integer SlotAvailability { [Token(Token = "0x60007FD")] get; }

	// Token: 0x17000464 RID: 1124
	// (get) Token: 0x060007FE RID: 2046
	// (set) Token: 0x060007FF RID: 2047
	[Token(Token = "0x17000464")]
	bool HasCookingPot { [Token(Token = "0x60007FE")] get; [Token(Token = "0x60007FF")] set; }

	// Token: 0x17000465 RID: 1125
	// (get) Token: 0x06000800 RID: 2048
	// (set) Token: 0x06000801 RID: 2049
	[Token(Token = "0x17000465")]
	bool IsCooking { [Token(Token = "0x6000800")] get; [Token(Token = "0x6000801")] set; }

	// Token: 0x17000466 RID: 1126
	// (get) Token: 0x06000802 RID: 2050
	// (set) Token: 0x06000803 RID: 2051
	[Token(Token = "0x17000466")]
	bool IsDoneCooking { [Token(Token = "0x6000802")] get; [Token(Token = "0x6000803")] set; }

	// Token: 0x17000467 RID: 1127
	// (get) Token: 0x06000804 RID: 2052
	// (set) Token: 0x06000805 RID: 2053
	[Token(Token = "0x17000467")]
	bool IsBusy { [Token(Token = "0x6000804")] get; [Token(Token = "0x6000805")] set; }

	// Token: 0x17000468 RID: 1128
	// (get) Token: 0x06000806 RID: 2054
	// (set) Token: 0x06000807 RID: 2055
	[Token(Token = "0x17000468")]
	int RecipeId { [Token(Token = "0x6000806")] get; [Token(Token = "0x6000807")] set; }

	// Token: 0x17000469 RID: 1129
	// (get) Token: 0x06000808 RID: 2056
	// (set) Token: 0x06000809 RID: 2057
	[Token(Token = "0x17000469")]
	float CurrentLiquidVolume { [Token(Token = "0x6000808")] get; [Token(Token = "0x6000809")] set; }

	// Token: 0x0600080A RID: 2058
	[Token(Token = "0x600080A")]
	void FuelAdded();
}
