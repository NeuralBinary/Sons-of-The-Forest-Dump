using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000A8 RID: 168
[Token(Token = "0x20000A8")]
public interface ICoopServerInfo : IState, IDisposable
{
	// Token: 0x17000405 RID: 1029
	// (get) Token: 0x06000746 RID: 1862
	// (set) Token: 0x06000747 RID: 1863
	[Token(Token = "0x17000405")]
	bool Started { [Token(Token = "0x6000746")] get; [Token(Token = "0x6000747")] set; }

	// Token: 0x17000406 RID: 1030
	// (get) Token: 0x06000748 RID: 1864
	// (set) Token: 0x06000749 RID: 1865
	[Token(Token = "0x17000406")]
	int ServerState { [Token(Token = "0x6000748")] get; [Token(Token = "0x6000749")] set; }

	// Token: 0x17000407 RID: 1031
	// (get) Token: 0x0600074A RID: 1866
	// (set) Token: 0x0600074B RID: 1867
	[Token(Token = "0x17000407")]
	string ServerName { [Token(Token = "0x600074A")] get; [Token(Token = "0x600074B")] set; }

	// Token: 0x17000408 RID: 1032
	// (get) Token: 0x0600074C RID: 1868
	// (set) Token: 0x0600074D RID: 1869
	[Token(Token = "0x17000408")]
	int MaxPlayers { [Token(Token = "0x600074C")] get; [Token(Token = "0x600074D")] set; }

	// Token: 0x17000409 RID: 1033
	// (get) Token: 0x0600074E RID: 1870
	// (set) Token: 0x0600074F RID: 1871
	[Token(Token = "0x17000409")]
	int PlayerCount { [Token(Token = "0x600074E")] get; [Token(Token = "0x600074F")] set; }

	// Token: 0x1700040A RID: 1034
	// (get) Token: 0x06000750 RID: 1872
	// (set) Token: 0x06000751 RID: 1873
	[Token(Token = "0x1700040A")]
	int CrashLocationIndex { [Token(Token = "0x6000750")] get; [Token(Token = "0x6000751")] set; }

	// Token: 0x1700040B RID: 1035
	// (get) Token: 0x06000752 RID: 1874
	// (set) Token: 0x06000753 RID: 1875
	[Token(Token = "0x1700040B")]
	float StartDayTime { [Token(Token = "0x6000752")] get; [Token(Token = "0x6000753")] set; }

	// Token: 0x1700040C RID: 1036
	// (get) Token: 0x06000754 RID: 1876
	// (set) Token: 0x06000755 RID: 1877
	[Token(Token = "0x1700040C")]
	bool AllowCheats { [Token(Token = "0x6000754")] get; [Token(Token = "0x6000755")] set; }

	// Token: 0x1700040D RID: 1037
	// (get) Token: 0x06000756 RID: 1878
	// (set) Token: 0x06000757 RID: 1879
	[Token(Token = "0x1700040D")]
	bool NoDestructionMode { [Token(Token = "0x6000756")] get; [Token(Token = "0x6000757")] set; }

	// Token: 0x1700040E RID: 1038
	// (get) Token: 0x06000758 RID: 1880
	// (set) Token: 0x06000759 RID: 1881
	[Token(Token = "0x1700040E")]
	bool RegrowMode { [Token(Token = "0x6000758")] get; [Token(Token = "0x6000759")] set; }

	// Token: 0x1700040F RID: 1039
	// (get) Token: 0x0600075A RID: 1882
	// (set) Token: 0x0600075B RID: 1883
	[Token(Token = "0x1700040F")]
	int DifficultyMode { [Token(Token = "0x600075A")] get; [Token(Token = "0x600075B")] set; }

	// Token: 0x17000410 RID: 1040
	// (get) Token: 0x0600075C RID: 1884
	// (set) Token: 0x0600075D RID: 1885
	[Token(Token = "0x17000410")]
	int UsedPlayerVariations { [Token(Token = "0x600075C")] get; [Token(Token = "0x600075D")] set; }

	// Token: 0x17000411 RID: 1041
	// (get) Token: 0x0600075E RID: 1886
	// (set) Token: 0x0600075F RID: 1887
	[Token(Token = "0x17000411")]
	int UsedPlayerClothingVariations { [Token(Token = "0x600075E")] get; [Token(Token = "0x600075F")] set; }

	// Token: 0x17000412 RID: 1042
	// (get) Token: 0x06000760 RID: 1888
	[Token(Token = "0x17000412")]
	NetworkArray_Integer Clients { [Token(Token = "0x6000760")] get; }

	// Token: 0x17000413 RID: 1043
	// (get) Token: 0x06000761 RID: 1889
	[Token(Token = "0x17000413")]
	NetworkArray_Integer ClientsColor { [Token(Token = "0x6000761")] get; }

	// Token: 0x17000414 RID: 1044
	// (get) Token: 0x06000762 RID: 1890
	[Token(Token = "0x17000414")]
	NetworkArray_ProtocolToken SteamIds { [Token(Token = "0x6000762")] get; }

	// Token: 0x17000415 RID: 1045
	// (get) Token: 0x06000763 RID: 1891
	[Token(Token = "0x17000415")]
	NetworkArray_Integer PlayerRoles { [Token(Token = "0x6000763")] get; }

	// Token: 0x17000416 RID: 1046
	// (get) Token: 0x06000764 RID: 1892
	// (set) Token: 0x06000765 RID: 1893
	[Token(Token = "0x17000416")]
	bool RealisticPlayerDamage { [Token(Token = "0x6000764")] get; [Token(Token = "0x6000765")] set; }

	// Token: 0x17000417 RID: 1047
	// (get) Token: 0x06000766 RID: 1894
	[Token(Token = "0x17000417")]
	NetworkArray_Integer IdObjectStates { [Token(Token = "0x6000766")] get; }

	// Token: 0x17000418 RID: 1048
	// (get) Token: 0x06000767 RID: 1895
	// (set) Token: 0x06000768 RID: 1896
	[Token(Token = "0x17000418")]
	int StartingSeason { [Token(Token = "0x6000767")] get; [Token(Token = "0x6000768")] set; }

	// Token: 0x17000419 RID: 1049
	// (get) Token: 0x06000769 RID: 1897
	// (set) Token: 0x0600076A RID: 1898
	[Token(Token = "0x17000419")]
	int SeasonDurationGameSetting { [Token(Token = "0x6000769")] get; [Token(Token = "0x600076A")] set; }

	// Token: 0x1700041A RID: 1050
	// (get) Token: 0x0600076B RID: 1899
	// (set) Token: 0x0600076C RID: 1900
	[Token(Token = "0x1700041A")]
	int DayLengthSetting { [Token(Token = "0x600076B")] get; [Token(Token = "0x600076C")] set; }

	// Token: 0x1700041B RID: 1051
	// (get) Token: 0x0600076D RID: 1901
	// (set) Token: 0x0600076E RID: 1902
	[Token(Token = "0x1700041B")]
	int SurvivalDamageSetting { [Token(Token = "0x600076D")] get; [Token(Token = "0x600076E")] set; }

	// Token: 0x1700041C RID: 1052
	// (get) Token: 0x0600076F RID: 1903
	// (set) Token: 0x06000770 RID: 1904
	[Token(Token = "0x1700041C")]
	int ConsumableEffectsSetting { [Token(Token = "0x600076F")] get; [Token(Token = "0x6000770")] set; }

	// Token: 0x1700041D RID: 1053
	// (get) Token: 0x06000771 RID: 1905
	// (set) Token: 0x06000772 RID: 1906
	[Token(Token = "0x1700041D")]
	int EnemyDamageSetting { [Token(Token = "0x6000771")] get; [Token(Token = "0x6000772")] set; }

	// Token: 0x1700041E RID: 1054
	// (get) Token: 0x06000773 RID: 1907
	// (set) Token: 0x06000774 RID: 1908
	[Token(Token = "0x1700041E")]
	int EnemyHealthSetting { [Token(Token = "0x6000773")] get; [Token(Token = "0x6000774")] set; }

	// Token: 0x1700041F RID: 1055
	// (get) Token: 0x06000775 RID: 1909
	// (set) Token: 0x06000776 RID: 1910
	[Token(Token = "0x1700041F")]
	int ColdPenaltySetting { [Token(Token = "0x6000775")] get; [Token(Token = "0x6000776")] set; }

	// Token: 0x17000420 RID: 1056
	// (get) Token: 0x06000777 RID: 1911
	// (set) Token: 0x06000778 RID: 1912
	[Token(Token = "0x17000420")]
	bool ReducedFoodInContainersSetting { [Token(Token = "0x6000777")] get; [Token(Token = "0x6000778")] set; }

	// Token: 0x17000421 RID: 1057
	// (get) Token: 0x06000779 RID: 1913
	// (set) Token: 0x0600077A RID: 1914
	[Token(Token = "0x17000421")]
	bool SingleUseContainersSetting { [Token(Token = "0x6000779")] get; [Token(Token = "0x600077A")] set; }
}
