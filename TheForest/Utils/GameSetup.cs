using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TheForest.Commons.Enums;
using TheForest.Modding.Bridge.Interfaces;

namespace TheForest.Utils
{
	// Token: 0x020003BF RID: 959
	[Token(Token = "0x20003BF")]
	public static class GameSetup
	{
		// Token: 0x1700035C RID: 860
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x000079F8 File Offset: 0x00005BF8
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035C")]
		public static GameTypes Game
		{
			[Token(Token = "0x600192A")]
			[Address(RVA = "0x2CC63F0", Offset = "0x2CC53F0", VA = "0x182CC63F0")]
			[CompilerGenerated]
			get
			{
				return default(GameTypes);
			}
			[Token(Token = "0x600192B")]
			[Address(RVA = "0x2CC6CB0", Offset = "0x2CC5CB0", VA = "0x182CC6CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x00007A10 File Offset: 0x00005C10
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035D")]
		public static PlayerModes Mode
		{
			[Token(Token = "0x600192C")]
			[Address(RVA = "0x2CC6B10", Offset = "0x2CC5B10", VA = "0x182CC6B10")]
			[CompilerGenerated]
			get
			{
				return default(PlayerModes);
			}
			[Token(Token = "0x600192D")]
			[Address(RVA = "0x2CC6D70", Offset = "0x2CC5D70", VA = "0x182CC6D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x00007A28 File Offset: 0x00005C28
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035E")]
		public static DifficultyModes Difficulty
		{
			[Token(Token = "0x600192E")]
			[Address(RVA = "0x2CC63A0", Offset = "0x2CC53A0", VA = "0x182CC63A0")]
			[CompilerGenerated]
			get
			{
				return default(DifficultyModes);
			}
			[Token(Token = "0x600192F")]
			[Address(RVA = "0x2CC6C50", Offset = "0x2CC5C50", VA = "0x182CC6C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x00007A40 File Offset: 0x00005C40
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035F")]
		public static InitTypes Init
		{
			[Token(Token = "0x6001930")]
			[Address(RVA = "0x2CC6440", Offset = "0x2CC5440", VA = "0x182CC6440")]
			[CompilerGenerated]
			get
			{
				return default(InitTypes);
			}
			[Token(Token = "0x6001931")]
			[Address(RVA = "0x2CC6D10", Offset = "0x2CC5D10", VA = "0x182CC6D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x00007A58 File Offset: 0x00005C58
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000360")]
		public static MpTypes MpType
		{
			[Token(Token = "0x6001932")]
			[Address(RVA = "0x2CC6B60", Offset = "0x2CC5B60", VA = "0x182CC6B60")]
			[CompilerGenerated]
			get
			{
				return default(MpTypes);
			}
			[Token(Token = "0x6001933")]
			[Address(RVA = "0x2CC6DD0", Offset = "0x2CC5DD0", VA = "0x182CC6DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x00007A70 File Offset: 0x00005C70
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000361")]
		public static Slots Slot
		{
			[Token(Token = "0x6001934")]
			[Address(RVA = "0x2CC6C00", Offset = "0x2CC5C00", VA = "0x182CC6C00")]
			[CompilerGenerated]
			get
			{
				return default(Slots);
			}
			[Token(Token = "0x6001935")]
			[Address(RVA = "0x2CC6EA0", Offset = "0x2CC5EA0", VA = "0x182CC6EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000362")]
		public static string SaveUserId
		{
			[Token(Token = "0x6001936")]
			[Address(RVA = "0x2CC6BB0", Offset = "0x2CC5BB0", VA = "0x182CC6BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001937")]
			[Address(RVA = "0x2CC6E30", Offset = "0x2CC5E30", VA = "0x182CC6E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001939")]
		[Address(RVA = "0x2CC5F20", Offset = "0x2CC4F20", VA = "0x182CC5F20")]
		public static void SetGameType(GameTypes game)
		{
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193A")]
		[Address(RVA = "0x2CC6150", Offset = "0x2CC5150", VA = "0x182CC6150")]
		public static void SetPlayerMode(PlayerModes mode)
		{
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193B")]
		[Address(RVA = "0x2CC5E10", Offset = "0x2CC4E10", VA = "0x182CC5E10")]
		public static void SetDifficulty(DifficultyModes difficulty)
		{
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193C")]
		[Address(RVA = "0x2CC6030", Offset = "0x2CC5030", VA = "0x182CC6030")]
		public static void SetInitType(InitTypes init)
		{
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193D")]
		[Address(RVA = "0x2CC60C0", Offset = "0x2CC50C0", VA = "0x182CC60C0")]
		public static void SetMpType(MpTypes mpType)
		{
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x2CC61E0", Offset = "0x2CC51E0", VA = "0x182CC61E0")]
		public static void SetSlot(Slots slot)
		{
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x17000363")]
		public static bool IsStandardGame
		{
			[Token(Token = "0x600193F")]
			[Address(RVA = "0x2CC6A90", Offset = "0x2CC5A90", VA = "0x182CC6A90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[Token(Token = "0x17000364")]
		public static bool IsModGame
		{
			[Token(Token = "0x6001940")]
			[Address(RVA = "0x2CC6610", Offset = "0x2CC5610", VA = "0x182CC6610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[Token(Token = "0x17000365")]
		public static bool IsCreativeGame
		{
			[Token(Token = "0x6001941")]
			[Address(RVA = "0x2CC6490", Offset = "0x2CC5490", VA = "0x182CC6490")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[Token(Token = "0x17000366")]
		public static bool IsSinglePlayer
		{
			[Token(Token = "0x6001942")]
			[Address(RVA = "0x2CC6A10", Offset = "0x2CC5A10", VA = "0x182CC6A10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[Token(Token = "0x17000367")]
		public static bool IsMultiplayer
		{
			[Token(Token = "0x6001943")]
			[Address(RVA = "0x2CC6790", Offset = "0x2CC5790", VA = "0x182CC6790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x00007B00 File Offset: 0x00005D00
		[Token(Token = "0x17000368")]
		public static bool IsPeacefulMode
		{
			[Token(Token = "0x6001944")]
			[Address(RVA = "0x2CC6910", Offset = "0x2CC5910", VA = "0x182CC6910")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x00007B18 File Offset: 0x00005D18
		[Token(Token = "0x17000369")]
		public static bool IsNormalMode
		{
			[Token(Token = "0x6001945")]
			[Address(RVA = "0x2CC6890", Offset = "0x2CC5890", VA = "0x182CC6890")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x00007B30 File Offset: 0x00005D30
		[Token(Token = "0x1700036A")]
		public static bool IsHardMode
		{
			[Token(Token = "0x6001946")]
			[Address(RVA = "0x2CC6510", Offset = "0x2CC5510", VA = "0x182CC6510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x00007B48 File Offset: 0x00005D48
		[Token(Token = "0x1700036B")]
		public static bool IsHardSurvivalMode
		{
			[Token(Token = "0x6001947")]
			[Address(RVA = "0x2CC6590", Offset = "0x2CC5590", VA = "0x182CC6590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x00007B60 File Offset: 0x00005D60
		[Token(Token = "0x1700036C")]
		public static bool IsNewGame
		{
			[Token(Token = "0x6001948")]
			[Address(RVA = "0x2CC6810", Offset = "0x2CC5810", VA = "0x182CC6810")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x00007B78 File Offset: 0x00005D78
		[Token(Token = "0x1700036D")]
		public static bool IsSavedGame
		{
			[Token(Token = "0x6001949")]
			[Address(RVA = "0x2CC6990", Offset = "0x2CC5990", VA = "0x182CC6990")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x00007B90 File Offset: 0x00005D90
		[Token(Token = "0x1700036E")]
		public static bool IsMpServer
		{
			[Token(Token = "0x600194A")]
			[Address(RVA = "0x2CC6710", Offset = "0x2CC5710", VA = "0x182CC6710")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[Token(Token = "0x1700036F")]
		public static bool IsMpClient
		{
			[Token(Token = "0x600194B")]
			[Address(RVA = "0x2CC6690", Offset = "0x2CC5690", VA = "0x182CC6690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040018BF RID: 6335
		[Token(Token = "0x40018BF")]
		[FieldOffset(Offset = "0x0")]
		public static GameSetup.GameSetupBridge Bridge;

		// Token: 0x020003C0 RID: 960
		[Token(Token = "0x20003C0")]
		public class GameSetupBridge : IGameSetupBridge
		{
			// Token: 0x0600194C RID: 6476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600194C")]
			[Address(RVA = "0x2CC5A90", Offset = "0x2CC4A90", VA = "0x182CC5A90", Slot = "5")]
			public void SetGameType(GameTypes game)
			{
			}

			// Token: 0x0600194D RID: 6477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600194D")]
			[Address(RVA = "0x2CC5CC0", Offset = "0x2CC4CC0", VA = "0x182CC5CC0", Slot = "8")]
			public void SetPlayerMode(PlayerModes mode)
			{
			}

			// Token: 0x0600194E RID: 6478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600194E")]
			[Address(RVA = "0x2CC5980", Offset = "0x2CC4980", VA = "0x182CC5980", Slot = "4")]
			public void SetDifficulty(DifficultyModes difficulty)
			{
			}

			// Token: 0x0600194F RID: 6479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600194F")]
			[Address(RVA = "0x2CC5BA0", Offset = "0x2CC4BA0", VA = "0x182CC5BA0", Slot = "6")]
			public void SetInitType(InitTypes init)
			{
			}

			// Token: 0x06001950 RID: 6480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001950")]
			[Address(RVA = "0x2CC5C30", Offset = "0x2CC4C30", VA = "0x182CC5C30", Slot = "7")]
			public void SetMpType(MpTypes mpType)
			{
			}

			// Token: 0x06001951 RID: 6481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001951")]
			[Address(RVA = "0x2CC5D50", Offset = "0x2CC4D50", VA = "0x182CC5D50", Slot = "9")]
			public void SetSlot(Slots slot)
			{
			}

			// Token: 0x06001952 RID: 6482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001952")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public GameSetupBridge()
			{
			}
		}
	}
}
