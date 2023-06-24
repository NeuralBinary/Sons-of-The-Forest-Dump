using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TheForest.Commons.Enums;
using TheForest.Modding.Bridge.Interfaces;

namespace TheForest.Utils
{
	// Token: 0x020003B1 RID: 945
	[Token(Token = "0x20003B1")]
	public static class GameSetup
	{
		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x00007C68 File Offset: 0x00005E68
		// (set) Token: 0x06001966 RID: 6502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000364")]
		public static GameTypes Game
		{
			[Token(Token = "0x6001965")]
			[Address(RVA = "0x32934D0", Offset = "0x3291AD0", VA = "0x1832934D0")]
			[CompilerGenerated]
			get
			{
				return GameTypes.Standard;
			}
			[Token(Token = "0x6001966")]
			[Address(RVA = "0x3293520", Offset = "0x3291B20", VA = "0x183293520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x00007C80 File Offset: 0x00005E80
		// (set) Token: 0x06001968 RID: 6504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000365")]
		public static PlayerModes Mode
		{
			[Token(Token = "0x6001967")]
			[Address(RVA = "0x3293580", Offset = "0x3291B80", VA = "0x183293580")]
			[CompilerGenerated]
			get
			{
				return PlayerModes.SinglePlayer;
			}
			[Token(Token = "0x6001968")]
			[Address(RVA = "0x32935D0", Offset = "0x3291BD0", VA = "0x1832935D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x00007C98 File Offset: 0x00005E98
		// (set) Token: 0x0600196A RID: 6506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000366")]
		public static DifficultyModes Difficulty
		{
			[Token(Token = "0x6001969")]
			[Address(RVA = "0x3293630", Offset = "0x3291C30", VA = "0x183293630")]
			[CompilerGenerated]
			get
			{
				return DifficultyModes.Peaceful;
			}
			[Token(Token = "0x600196A")]
			[Address(RVA = "0x3293680", Offset = "0x3291C80", VA = "0x183293680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x00007CB0 File Offset: 0x00005EB0
		// (set) Token: 0x0600196C RID: 6508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000367")]
		public static InitTypes Init
		{
			[Token(Token = "0x600196B")]
			[Address(RVA = "0x32936E0", Offset = "0x3291CE0", VA = "0x1832936E0")]
			[CompilerGenerated]
			get
			{
				return InitTypes.New;
			}
			[Token(Token = "0x600196C")]
			[Address(RVA = "0x3293730", Offset = "0x3291D30", VA = "0x183293730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x00007CC8 File Offset: 0x00005EC8
		// (set) Token: 0x0600196E RID: 6510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000368")]
		public static MpTypes MpType
		{
			[Token(Token = "0x600196D")]
			[Address(RVA = "0x3293790", Offset = "0x3291D90", VA = "0x183293790")]
			[CompilerGenerated]
			get
			{
				return MpTypes.Server;
			}
			[Token(Token = "0x600196E")]
			[Address(RVA = "0x32937E0", Offset = "0x3291DE0", VA = "0x1832937E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x00007CE0 File Offset: 0x00005EE0
		// (set) Token: 0x06001970 RID: 6512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000369")]
		public static Slots Slot
		{
			[Token(Token = "0x600196F")]
			[Address(RVA = "0x3293840", Offset = "0x3291E40", VA = "0x183293840")]
			[CompilerGenerated]
			get
			{
				return (Slots)0;
			}
			[Token(Token = "0x6001970")]
			[Address(RVA = "0x3293890", Offset = "0x3291E90", VA = "0x183293890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036A")]
		public static string SaveUserId
		{
			[Token(Token = "0x6001971")]
			[Address(RVA = "0x32938F0", Offset = "0x3291EF0", VA = "0x1832938F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001972")]
			[Address(RVA = "0x3293940", Offset = "0x3291F40", VA = "0x183293940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x3293AA0", Offset = "0x32920A0", VA = "0x183293AA0")]
		public static void SetGameType(GameTypes game)
		{
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x3293BB0", Offset = "0x32921B0", VA = "0x183293BB0")]
		public static void SetPlayerMode(PlayerModes mode)
		{
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x3293C40", Offset = "0x3292240", VA = "0x183293C40")]
		public static void SetDifficulty(DifficultyModes difficulty)
		{
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001977")]
		[Address(RVA = "0x3293D50", Offset = "0x3292350", VA = "0x183293D50")]
		public static void SetInitType(InitTypes init)
		{
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001978")]
		[Address(RVA = "0x3293DE0", Offset = "0x32923E0", VA = "0x183293DE0")]
		public static void SetMpType(MpTypes mpType)
		{
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x3293E70", Offset = "0x3292470", VA = "0x183293E70")]
		public static void SetSlot(Slots slot)
		{
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x1700036B")]
		public static bool IsStandardGame
		{
			[Token(Token = "0x600197A")]
			[Address(RVA = "0x3293FE0", Offset = "0x32925E0", VA = "0x183293FE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x1700036C")]
		public static bool IsModGame
		{
			[Token(Token = "0x600197B")]
			[Address(RVA = "0x3294060", Offset = "0x3292660", VA = "0x183294060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x1700036D")]
		public static bool IsCreativeGame
		{
			[Token(Token = "0x600197C")]
			[Address(RVA = "0x32940E0", Offset = "0x32926E0", VA = "0x1832940E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x1700036E")]
		public static bool IsSinglePlayer
		{
			[Token(Token = "0x600197D")]
			[Address(RVA = "0x3294160", Offset = "0x3292760", VA = "0x183294160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x1700036F")]
		public static bool IsMultiplayer
		{
			[Token(Token = "0x600197E")]
			[Address(RVA = "0x32941E0", Offset = "0x32927E0", VA = "0x1832941E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x00007D70 File Offset: 0x00005F70
		[Token(Token = "0x17000370")]
		public static bool IsPeacefulMode
		{
			[Token(Token = "0x600197F")]
			[Address(RVA = "0x3294260", Offset = "0x3292860", VA = "0x183294260")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x00007D88 File Offset: 0x00005F88
		[Token(Token = "0x17000371")]
		public static bool IsNormalMode
		{
			[Token(Token = "0x6001980")]
			[Address(RVA = "0x32942E0", Offset = "0x32928E0", VA = "0x1832942E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x00007DA0 File Offset: 0x00005FA0
		[Token(Token = "0x17000372")]
		public static bool IsHardMode
		{
			[Token(Token = "0x6001981")]
			[Address(RVA = "0x3294360", Offset = "0x3292960", VA = "0x183294360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x17000373")]
		public static bool IsHardSurvivalMode
		{
			[Token(Token = "0x6001982")]
			[Address(RVA = "0x32943E0", Offset = "0x32929E0", VA = "0x1832943E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[Token(Token = "0x17000374")]
		public static bool IsNewGame
		{
			[Token(Token = "0x6001983")]
			[Address(RVA = "0x3294460", Offset = "0x3292A60", VA = "0x183294460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[Token(Token = "0x17000375")]
		public static bool IsSavedGame
		{
			[Token(Token = "0x6001984")]
			[Address(RVA = "0x32944E0", Offset = "0x3292AE0", VA = "0x1832944E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x00007E00 File Offset: 0x00006000
		[Token(Token = "0x17000376")]
		public static bool IsMpServer
		{
			[Token(Token = "0x6001985")]
			[Address(RVA = "0x3294560", Offset = "0x3292B60", VA = "0x183294560")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x00007E18 File Offset: 0x00006018
		[Token(Token = "0x17000377")]
		public static bool IsMpClient
		{
			[Token(Token = "0x6001986")]
			[Address(RVA = "0x32945E0", Offset = "0x3292BE0", VA = "0x1832945E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040018DE RID: 6366
		[Token(Token = "0x40018DE")]
		[FieldOffset(Offset = "0x0")]
		public static GameSetup.GameSetupBridge Bridge;

		// Token: 0x020003B2 RID: 946
		[Token(Token = "0x20003B2")]
		public class GameSetupBridge : IGameSetupBridge
		{
			// Token: 0x06001987 RID: 6535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001987")]
			[Address(RVA = "0x3294660", Offset = "0x3292C60", VA = "0x183294660", Slot = "5")]
			public void SetGameType(GameTypes game)
			{
			}

			// Token: 0x06001988 RID: 6536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001988")]
			[Address(RVA = "0x3294770", Offset = "0x3292D70", VA = "0x183294770", Slot = "8")]
			public void SetPlayerMode(PlayerModes mode)
			{
			}

			// Token: 0x06001989 RID: 6537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001989")]
			[Address(RVA = "0x3294800", Offset = "0x3292E00", VA = "0x183294800", Slot = "4")]
			public void SetDifficulty(DifficultyModes difficulty)
			{
			}

			// Token: 0x0600198A RID: 6538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600198A")]
			[Address(RVA = "0x3294910", Offset = "0x3292F10", VA = "0x183294910", Slot = "6")]
			public void SetInitType(InitTypes init)
			{
			}

			// Token: 0x0600198B RID: 6539 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600198B")]
			[Address(RVA = "0x32949A0", Offset = "0x3292FA0", VA = "0x1832949A0", Slot = "7")]
			public void SetMpType(MpTypes mpType)
			{
			}

			// Token: 0x0600198C RID: 6540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600198C")]
			[Address(RVA = "0x3294A30", Offset = "0x3293030", VA = "0x183294A30", Slot = "9")]
			public void SetSlot(Slots slot)
			{
			}

			// Token: 0x0600198D RID: 6541 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600198D")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public GameSetupBridge()
			{
			}
		}
	}
}
