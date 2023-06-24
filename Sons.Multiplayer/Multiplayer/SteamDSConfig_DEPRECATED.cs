using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Steamworks;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[Obsolete]
	public static class SteamDSConfig_DEPRECATED
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x1700004F")]
		public static bool IsServerSaving
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x30F2100", Offset = "0x30F0700", VA = "0x1830F2100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x17000050")]
		public static bool isDedicated
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x30F2160", Offset = "0x30F0760", VA = "0x1830F2160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x30F21F0", Offset = "0x30F07F0", VA = "0x1830F21F0")]
		public static void StartAutoSaveMode()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x30F2270", Offset = "0x30F0870", VA = "0x1830F2270")]
		public static void SaveGame()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x30F22D0", Offset = "0x30F08D0", VA = "0x1830F22D0")]
		public static void SetServerStatus(int status)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x30F23F0", Offset = "0x30F09F0", VA = "0x1830F23F0")]
		public static void ReceiveServerStatus(int status)
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x30F2450", Offset = "0x30F0A50", VA = "0x1830F2450")]
		private static ushort defaultShort(string key, ushort defaultValue)
		{
			return 0;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x30F2540", Offset = "0x30F0B40", VA = "0x1830F2540")]
		private static int defaultInt(string key, int defaultValue, int minValue, int maxValue)
		{
			return 0;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x30F25C0", Offset = "0x30F0BC0", VA = "0x1830F25C0")]
		private static int defaultInt(string key, int defaultValue, int minValue)
		{
			return 0;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x30F2630", Offset = "0x30F0C30", VA = "0x1830F2630")]
		private static int defaultInt(string key, int defaultValue)
		{
			return 0;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x30F27B0", Offset = "0x30F0DB0", VA = "0x1830F27B0")]
		private static bool defaultBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x30F2950", Offset = "0x30F0F50", VA = "0x1830F2950")]
		private static string defaultString(string key, string defaultValue = "")
		{
			return null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x30F2A30", Offset = "0x30F1030", VA = "0x1830F2A30")]
		public static string PasswordToHash(string password)
		{
			return null;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public static string ServerAddress
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x30F2A50", Offset = "0x30F1050", VA = "0x1830F2A50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x30F2AC0", Offset = "0x30F10C0", VA = "0x1830F2AC0")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00002EF8 File Offset: 0x000010F8
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		public static ushort ServerSteamPort
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x30F2B70", Offset = "0x30F1170", VA = "0x1830F2B70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x30F2BE0", Offset = "0x30F11E0", VA = "0x1830F2BE0")]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00002F10 File Offset: 0x00001110
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		public static ushort ServerGamePort
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x30F2C40", Offset = "0x30F1240", VA = "0x1830F2C40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x30F2CB0", Offset = "0x30F12B0", VA = "0x1830F2CB0")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00002F28 File Offset: 0x00001128
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000054")]
		public static ushort ServerQueryPort
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x30F2D10", Offset = "0x30F1310", VA = "0x1830F2D10")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x30F2D80", Offset = "0x30F1380", VA = "0x1830F2D80")]
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		public static string ServerName
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x30F2DE0", Offset = "0x30F13E0", VA = "0x1830F2DE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x30F2E50", Offset = "0x30F1450", VA = "0x1830F2E50")]
			set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00002F40 File Offset: 0x00001140
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		public static bool ServerVACEnabled
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x30F2F00", Offset = "0x30F1500", VA = "0x1830F2F00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x30F2F70", Offset = "0x30F1570", VA = "0x1830F2F70")]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public static string ServerPassword
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x30F2FD0", Offset = "0x30F15D0", VA = "0x1830F2FD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x30F3040", Offset = "0x30F1640", VA = "0x1830F3040")]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public static string ServerAdminPassword
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x30F3100", Offset = "0x30F1700", VA = "0x1830F3100")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x30F3170", Offset = "0x30F1770", VA = "0x1830F3170")]
			set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public static string ServerSteamAccount
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x30F3230", Offset = "0x30F1830", VA = "0x1830F3230")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x30F32A0", Offset = "0x30F18A0", VA = "0x1830F32A0")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00002F58 File Offset: 0x00001158
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public static int ServerPlayers
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x30F3360", Offset = "0x30F1960", VA = "0x1830F3360")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x30F3440", Offset = "0x30F1A40", VA = "0x1830F3440")]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00002F70 File Offset: 0x00001170
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		public static int GameAutoSaveIntervalMinutes
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x30F34D0", Offset = "0x30F1AD0", VA = "0x1830F34D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x30F35A0", Offset = "0x30F1BA0", VA = "0x1830F35A0")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		public static string GameDifficulty
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x30F3640", Offset = "0x30F1C40", VA = "0x1830F3640")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x30F36B0", Offset = "0x30F1CB0", VA = "0x1830F36B0")]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		public static string GameType
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x30F3770", Offset = "0x30F1D70", VA = "0x1830F3770")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x30F37E0", Offset = "0x30F1DE0", VA = "0x1830F37E0")]
			set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00002F88 File Offset: 0x00001188
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		public static int GameSaveSlot
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x30F38A0", Offset = "0x30F1EA0", VA = "0x1830F38A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x30F3910", Offset = "0x30F1F10", VA = "0x1830F3910")]
			set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00002FA0 File Offset: 0x000011A0
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		public static bool ShowLogs
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x30F3970", Offset = "0x30F1F70", VA = "0x1830F3970")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x30F39E0", Offset = "0x30F1FE0", VA = "0x1830F39E0")]
			set
			{
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		public static string SaveFolderPath
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x30F3A40", Offset = "0x30F2040", VA = "0x1830F3A40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x30F3AB0", Offset = "0x30F20B0", VA = "0x1830F3AB0")]
			set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00002FB8 File Offset: 0x000011B8
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		public static int TargetFpsIdle
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x30F3B70", Offset = "0x30F2170", VA = "0x1830F3B70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x30F3BE0", Offset = "0x30F21E0", VA = "0x1830F3BE0")]
			set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00002FD0 File Offset: 0x000011D0
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public static int TargetFpsActive
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x30F3C40", Offset = "0x30F2240", VA = "0x1830F3C40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x30F3CB0", Offset = "0x30F22B0", VA = "0x1830F3CB0")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00002FE8 File Offset: 0x000011E8
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public static bool VeganMode
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x30F3D10", Offset = "0x30F2310", VA = "0x1830F3D10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x30F3D80", Offset = "0x30F2380", VA = "0x1830F3D80")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00003000 File Offset: 0x00001200
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public static bool VegetarianMode
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x30F3DE0", Offset = "0x30F23E0", VA = "0x1830F3DE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x30F3E50", Offset = "0x30F2450", VA = "0x1830F3E50")]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00003018 File Offset: 0x00001218
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		public static bool ResetHolesMode
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x30F3EB0", Offset = "0x30F24B0", VA = "0x1830F3EB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x30F3F20", Offset = "0x30F2520", VA = "0x1830F3F20")]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00003030 File Offset: 0x00001230
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public static bool TreeRegrowMode
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x30F3F80", Offset = "0x30F2580", VA = "0x1830F3F80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x30F3FF0", Offset = "0x30F25F0", VA = "0x1830F3FF0")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00003048 File Offset: 0x00001248
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000067")]
		public static bool AllowBuildingDestruction
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x30F4050", Offset = "0x30F2650", VA = "0x1830F4050")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x30F40C0", Offset = "0x30F26C0", VA = "0x1830F40C0")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00003060 File Offset: 0x00001260
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000068")]
		public static bool AllowEnemiesCreative
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x30F4120", Offset = "0x30F2720", VA = "0x1830F4120")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x30F4190", Offset = "0x30F2790", VA = "0x1830F4190")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00003078 File Offset: 0x00001278
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000069")]
		public static bool AllowCheats
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x30F41F0", Offset = "0x30F27F0", VA = "0x1830F41F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x30F4260", Offset = "0x30F2860", VA = "0x1830F4260")]
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00003090 File Offset: 0x00001290
		// (set) Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		public static bool RealisticPlayerDamage
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x30F42C0", Offset = "0x30F28C0", VA = "0x1830F42C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x30F4330", Offset = "0x30F2930", VA = "0x1830F4330")]
			set
			{
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x30F4390", Offset = "0x30F2990", VA = "0x1830F4390")]
		public static string GetServerData(string key)
		{
			return null;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x30F4590", Offset = "0x30F2B90", VA = "0x1830F4590")]
		public static void LoadServerCfg()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x30F49E0", Offset = "0x30F2FE0", VA = "0x1830F49E0")]
		public static string[] GetServerCfg()
		{
			return null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x30F4AE0", Offset = "0x30F30E0", VA = "0x1830F4AE0")]
		public static string GetServerCfgPath()
		{
			return null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x30F4B40", Offset = "0x30F3140", VA = "0x1830F4B40")]
		public static string GetServerCfgDir()
		{
			return null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x30F4BC0", Offset = "0x30F31C0", VA = "0x1830F4BC0")]
		public static string[] CreateServerCfg()
		{
			return null;
		}

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x0")]
		public static bool IsDedicatedServer;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x8")]
		public static CoopSteamManagerDS manager;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x10")]
		public static string ProductName;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x18")]
		public static string ProductDescription;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x20")]
		public static string MapName;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x28")]
		public static string ServerVersion;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x30")]
		public static bool initialized;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x31")]
		public static bool connectedToSteam;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x38")]
		public static UdpPlatform udpPlatform;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x40")]
		public static UdpEndPoint EndPoint;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x48")]
		public static string ServerGUID;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x50")]
		public static bool isUsingDummyPlayer;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x58")]
		public static Dictionary<uint, CSteamID> clientConnectionInfo;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x60")]
		public static int currentServerStatus;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		public const int ServerStarting = -1;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		public const int ServerRunning = 0;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		public const int ServerSaving = 1;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x64")]
		public static EServerMode ServerAuthMode;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x68")]
		public static bool useLaunchDisplay;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x69")]
		public static bool noSteamClient;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x70")]
		private static string _serverAddress;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x78")]
		private static ushort _serverSteamPort;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x7A")]
		private static ushort _serverGamePort;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x7C")]
		private static ushort _serverQueryPort;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x80")]
		private static string _serverName;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x88")]
		private static bool _enableVAC;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x90")]
		private static string _serverPassword;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x98")]
		private static string _serverAdminPassword;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0xA0")]
		private static string _serverSteamAccount;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0xA8")]
		private static int _serverPlayers;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0xAC")]
		private static int _gameAutoSaveIntervalMinutes;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0xB0")]
		private static string _gameDifficulty;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0xB8")]
		private static string _gameType;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0xC0")]
		private static int _gameSaveSlot;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0xC4")]
		private static bool _showLogs;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0xC8")]
		private static string _saveFolderPath;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0xD0")]
		private static int _targetFpsIdle;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0xD4")]
		private static int _targetFpsActive;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0xD8")]
		public static int minAutoSaveTime;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0xDC")]
		public static int minPlayersPerServer;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0xE0")]
		public static int maxPlayersPerServer;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0xE4")]
		private static bool _veganMode;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0xE5")]
		private static bool _vegetarianMode;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0xE6")]
		private static bool _resetHolesMode;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0xE7")]
		private static bool _treeRegrowMode;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0xE8")]
		private static bool _allowbuildingdestruction;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0xE9")]
		private static bool _allowEnemiesCreativeMode;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0xEA")]
		private static bool _allowcheats;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0xEB")]
		private static bool _realisticPlayerDamage;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0xF0")]
		public static string serverConfigurationDir;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0xF8")]
		public static string serverConfigurationFile;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x100")]
		public static string ConfigFilePath;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x108")]
		public static bool ServerConfigLoaded;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x109")]
		public static bool UseServerConfigFile;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x110")]
		public static Dictionary<string, string> serverConfig;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x118")]
		public static string[] ServerDefaultData;
	}
}
