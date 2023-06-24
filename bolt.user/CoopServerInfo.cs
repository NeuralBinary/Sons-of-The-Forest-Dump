using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000A9 RID: 169
[Token(Token = "0x20000A9")]
internal class CoopServerInfo : NetworkState, ICoopServerInfo, IState, IDisposable
{
	// Token: 0x0600077B RID: 1915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600077B")]
	[Address(RVA = "0x82C860", Offset = "0x82AE60", VA = "0x18082C860")]
	public CoopServerInfo()
	{
	}

	// Token: 0x17000422 RID: 1058
	// (get) Token: 0x0600077C RID: 1916 RVA: 0x00004C50 File Offset: 0x00002E50
	// (set) Token: 0x0600077D RID: 1917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000422")]
	public bool Started
	{
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10", Slot = "31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x7B4A70", Offset = "0x7B3070", VA = "0x1807B4A70", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x17000423 RID: 1059
	// (get) Token: 0x0600077E RID: 1918 RVA: 0x00004C68 File Offset: 0x00002E68
	// (set) Token: 0x0600077F RID: 1919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000423")]
	public int ServerState
	{
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50", Slot = "33")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x82C8C0", Offset = "0x82AEC0", VA = "0x18082C8C0", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x17000424 RID: 1060
	// (get) Token: 0x06000780 RID: 1920 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000781 RID: 1921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000424")]
	public string ServerName
	{
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x82C9C0", Offset = "0x82AFC0", VA = "0x18082C9C0", Slot = "35")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x82CA60", Offset = "0x82B060", VA = "0x18082CA60", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x17000425 RID: 1061
	// (get) Token: 0x06000782 RID: 1922 RVA: 0x00004C80 File Offset: 0x00002E80
	// (set) Token: 0x06000783 RID: 1923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000425")]
	public int MaxPlayers
	{
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40", Slot = "37")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x82CBF0", Offset = "0x82B1F0", VA = "0x18082CBF0", Slot = "38")]
		set
		{
		}
	}

	// Token: 0x17000426 RID: 1062
	// (get) Token: 0x06000784 RID: 1924 RVA: 0x00004C98 File Offset: 0x00002E98
	// (set) Token: 0x06000785 RID: 1925 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000426")]
	public int PlayerCount
	{
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500", Slot = "39")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x82CCE0", Offset = "0x82B2E0", VA = "0x18082CCE0", Slot = "40")]
		set
		{
		}
	}

	// Token: 0x17000427 RID: 1063
	// (get) Token: 0x06000786 RID: 1926 RVA: 0x00004CB0 File Offset: 0x00002EB0
	// (set) Token: 0x06000787 RID: 1927 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000427")]
	public int CrashLocationIndex
	{
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x7E1E00", Offset = "0x7E0400", VA = "0x1807E1E00", Slot = "41")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x82CDD0", Offset = "0x82B3D0", VA = "0x18082CDD0", Slot = "42")]
		set
		{
		}
	}

	// Token: 0x17000428 RID: 1064
	// (get) Token: 0x06000788 RID: 1928 RVA: 0x00004CC8 File Offset: 0x00002EC8
	// (set) Token: 0x06000789 RID: 1929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000428")]
	public float StartDayTime
	{
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x82CED0", Offset = "0x82B4D0", VA = "0x18082CED0", Slot = "43")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x82CF30", Offset = "0x82B530", VA = "0x18082CF30", Slot = "44")]
		set
		{
		}
	}

	// Token: 0x17000429 RID: 1065
	// (get) Token: 0x0600078A RID: 1930 RVA: 0x00004CE0 File Offset: 0x00002EE0
	// (set) Token: 0x0600078B RID: 1931 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000429")]
	public bool AllowCheats
	{
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x82D020", Offset = "0x82B620", VA = "0x18082D020", Slot = "45")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x82D080", Offset = "0x82B680", VA = "0x18082D080", Slot = "46")]
		set
		{
		}
	}

	// Token: 0x1700042A RID: 1066
	// (get) Token: 0x0600078C RID: 1932 RVA: 0x00004CF8 File Offset: 0x00002EF8
	// (set) Token: 0x0600078D RID: 1933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700042A")]
	public bool NoDestructionMode
	{
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x82D170", Offset = "0x82B770", VA = "0x18082D170", Slot = "47")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x82D1D0", Offset = "0x82B7D0", VA = "0x18082D1D0", Slot = "48")]
		set
		{
		}
	}

	// Token: 0x1700042B RID: 1067
	// (get) Token: 0x0600078E RID: 1934 RVA: 0x00004D10 File Offset: 0x00002F10
	// (set) Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700042B")]
	public bool RegrowMode
	{
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x82D2C0", Offset = "0x82B8C0", VA = "0x18082D2C0", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x82D320", Offset = "0x82B920", VA = "0x18082D320", Slot = "50")]
		set
		{
		}
	}

	// Token: 0x1700042C RID: 1068
	// (get) Token: 0x06000790 RID: 1936 RVA: 0x00004D28 File Offset: 0x00002F28
	// (set) Token: 0x06000791 RID: 1937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700042C")]
	public int DifficultyMode
	{
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x82D410", Offset = "0x82BA10", VA = "0x18082D410", Slot = "51")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x82D470", Offset = "0x82BA70", VA = "0x18082D470", Slot = "52")]
		set
		{
		}
	}

	// Token: 0x1700042D RID: 1069
	// (get) Token: 0x06000792 RID: 1938 RVA: 0x00004D40 File Offset: 0x00002F40
	// (set) Token: 0x06000793 RID: 1939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700042D")]
	public int UsedPlayerVariations
	{
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x82D570", Offset = "0x82BB70", VA = "0x18082D570", Slot = "53")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x82D5D0", Offset = "0x82BBD0", VA = "0x18082D5D0", Slot = "54")]
		set
		{
		}
	}

	// Token: 0x1700042E RID: 1070
	// (get) Token: 0x06000794 RID: 1940 RVA: 0x00004D58 File Offset: 0x00002F58
	// (set) Token: 0x06000795 RID: 1941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700042E")]
	public int UsedPlayerClothingVariations
	{
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x82D6C0", Offset = "0x82BCC0", VA = "0x18082D6C0", Slot = "55")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x82D720", Offset = "0x82BD20", VA = "0x18082D720", Slot = "56")]
		set
		{
		}
	}

	// Token: 0x1700042F RID: 1071
	// (get) Token: 0x06000796 RID: 1942 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700042F")]
	public NetworkArray_Integer Clients
	{
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x82D810", Offset = "0x82BE10", VA = "0x18082D810", Slot = "57")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000430 RID: 1072
	// (get) Token: 0x06000797 RID: 1943 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000430")]
	public NetworkArray_Integer ClientsColor
	{
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x82D8D0", Offset = "0x82BED0", VA = "0x18082D8D0", Slot = "58")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000431 RID: 1073
	// (get) Token: 0x06000798 RID: 1944 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000431")]
	public NetworkArray_ProtocolToken SteamIds
	{
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x82D990", Offset = "0x82BF90", VA = "0x18082D990", Slot = "59")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000432 RID: 1074
	// (get) Token: 0x06000799 RID: 1945 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000432")]
	public NetworkArray_Integer PlayerRoles
	{
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x82DA50", Offset = "0x82C050", VA = "0x18082DA50", Slot = "60")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000433 RID: 1075
	// (get) Token: 0x0600079A RID: 1946 RVA: 0x00004D70 File Offset: 0x00002F70
	// (set) Token: 0x0600079B RID: 1947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000433")]
	public bool RealisticPlayerDamage
	{
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x82DB10", Offset = "0x82C110", VA = "0x18082DB10", Slot = "61")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x82DB70", Offset = "0x82C170", VA = "0x18082DB70", Slot = "62")]
		set
		{
		}
	}

	// Token: 0x17000434 RID: 1076
	// (get) Token: 0x0600079C RID: 1948 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000434")]
	public NetworkArray_Integer IdObjectStates
	{
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x82DC60", Offset = "0x82C260", VA = "0x18082DC60", Slot = "63")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000435 RID: 1077
	// (get) Token: 0x0600079D RID: 1949 RVA: 0x00004D88 File Offset: 0x00002F88
	// (set) Token: 0x0600079E RID: 1950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000435")]
	public int StartingSeason
	{
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x82DD20", Offset = "0x82C320", VA = "0x18082DD20", Slot = "64")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x82DD80", Offset = "0x82C380", VA = "0x18082DD80", Slot = "65")]
		set
		{
		}
	}

	// Token: 0x17000436 RID: 1078
	// (get) Token: 0x0600079F RID: 1951 RVA: 0x00004DA0 File Offset: 0x00002FA0
	// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000436")]
	public int SeasonDurationGameSetting
	{
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x82DE80", Offset = "0x82C480", VA = "0x18082DE80", Slot = "66")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x82DEE0", Offset = "0x82C4E0", VA = "0x18082DEE0", Slot = "67")]
		set
		{
		}
	}

	// Token: 0x17000437 RID: 1079
	// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00004DB8 File Offset: 0x00002FB8
	// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000437")]
	public int DayLengthSetting
	{
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x82DFE0", Offset = "0x82C5E0", VA = "0x18082DFE0", Slot = "68")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x82E040", Offset = "0x82C640", VA = "0x18082E040", Slot = "69")]
		set
		{
		}
	}

	// Token: 0x17000438 RID: 1080
	// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00004DD0 File Offset: 0x00002FD0
	// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000438")]
	public int SurvivalDamageSetting
	{
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x82E140", Offset = "0x82C740", VA = "0x18082E140", Slot = "70")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x82E1A0", Offset = "0x82C7A0", VA = "0x18082E1A0", Slot = "71")]
		set
		{
		}
	}

	// Token: 0x17000439 RID: 1081
	// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00004DE8 File Offset: 0x00002FE8
	// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000439")]
	public int ConsumableEffectsSetting
	{
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x82E2A0", Offset = "0x82C8A0", VA = "0x18082E2A0", Slot = "72")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x82E300", Offset = "0x82C900", VA = "0x18082E300", Slot = "73")]
		set
		{
		}
	}

	// Token: 0x1700043A RID: 1082
	// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00004E00 File Offset: 0x00003000
	// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700043A")]
	public int EnemyDamageSetting
	{
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x82E400", Offset = "0x82CA00", VA = "0x18082E400", Slot = "74")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x82E460", Offset = "0x82CA60", VA = "0x18082E460", Slot = "75")]
		set
		{
		}
	}

	// Token: 0x1700043B RID: 1083
	// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00004E18 File Offset: 0x00003018
	// (set) Token: 0x060007AA RID: 1962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700043B")]
	public int EnemyHealthSetting
	{
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x82E560", Offset = "0x82CB60", VA = "0x18082E560", Slot = "76")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x82E5C0", Offset = "0x82CBC0", VA = "0x18082E5C0", Slot = "77")]
		set
		{
		}
	}

	// Token: 0x1700043C RID: 1084
	// (get) Token: 0x060007AB RID: 1963 RVA: 0x00004E30 File Offset: 0x00003030
	// (set) Token: 0x060007AC RID: 1964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700043C")]
	public int ColdPenaltySetting
	{
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x82E6C0", Offset = "0x82CCC0", VA = "0x18082E6C0", Slot = "78")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x82E720", Offset = "0x82CD20", VA = "0x18082E720", Slot = "79")]
		set
		{
		}
	}

	// Token: 0x1700043D RID: 1085
	// (get) Token: 0x060007AD RID: 1965 RVA: 0x00004E48 File Offset: 0x00003048
	// (set) Token: 0x060007AE RID: 1966 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700043D")]
	public bool ReducedFoodInContainersSetting
	{
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x82E820", Offset = "0x82CE20", VA = "0x18082E820", Slot = "80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x82E880", Offset = "0x82CE80", VA = "0x18082E880", Slot = "81")]
		set
		{
		}
	}

	// Token: 0x1700043E RID: 1086
	// (get) Token: 0x060007AF RID: 1967 RVA: 0x00004E60 File Offset: 0x00003060
	// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700043E")]
	public bool SingleUseContainersSetting
	{
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x82E970", Offset = "0x82CF70", VA = "0x18082E970", Slot = "82")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x82E9D0", Offset = "0x82CFD0", VA = "0x18082E9D0", Slot = "83")]
		set
		{
		}
	}
}
