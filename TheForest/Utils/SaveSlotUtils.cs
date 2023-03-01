using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TheForest.Commons.Enums;

namespace TheForest.Utils
{
	// Token: 0x020003D3 RID: 979
	[Token(Token = "0x20003D3")]
	public static class SaveSlotUtils
	{
		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A25 RID: 6693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AD")]
		public static string UserId
		{
			[Token(Token = "0x6001A24")]
			[Address(RVA = "0x2CEC0C0", Offset = "0x2CEB0C0", VA = "0x182CEC0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A25")]
			[Address(RVA = "0x2CEC100", Offset = "0x2CEB100", VA = "0x182CEC100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A26")]
		[Address(RVA = "0x2CEC060", Offset = "0x2CEB060", VA = "0x182CEC060")]
		public static void SetUserId(string userId)
		{
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A27")]
		[Address(RVA = "0x2CEBB90", Offset = "0x2CEAB90", VA = "0x182CEBB90")]
		public static string GetUserPath()
		{
			return null;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A28")]
		[Address(RVA = "0x2CEB760", Offset = "0x2CEA760", VA = "0x182CEB760")]
		public static string GetLocalSlotPath()
		{
			return null;
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A29")]
		[Address(RVA = "0x2CEB950", Offset = "0x2CEA950", VA = "0x182CEB950")]
		public static string GetLocalSlotPath(Slots slot)
		{
			return null;
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0x2CEB7F0", Offset = "0x2CEA7F0", VA = "0x182CEB7F0")]
		public static string GetLocalSlotPath(PlayerModes mode, Slots slot)
		{
			return null;
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2B")]
		[Address(RVA = "0x2CEB9E0", Offset = "0x2CEA9E0", VA = "0x182CEB9E0")]
		public static string GetMpClientLocalPath()
		{
			return null;
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0x2CEB510", Offset = "0x2CEA510", VA = "0x182CEB510")]
		public static string GetCloudSlotPath()
		{
			return null;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2D")]
		[Address(RVA = "0x2CEB6D0", Offset = "0x2CEA6D0", VA = "0x182CEB6D0")]
		public static string GetCloudSlotPath(Slots slot)
		{
			return null;
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0x2CEB610", Offset = "0x2CEA610", VA = "0x182CEB610")]
		public static string GetCloudSlotPath(PlayerModes mode, Slots slot)
		{
			return null;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[Token(Token = "0x6001A2F")]
		[Address(RVA = "0x2CEBD50", Offset = "0x2CEAD50", VA = "0x182CEBD50")]
		public static bool HasLocalFile(Slots slot, string filename)
		{
			return default(bool);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A30")]
		[Address(RVA = "0x2CEB360", Offset = "0x2CEA360", VA = "0x182CEB360")]
		private static void DeleteDirectory(string target_dir)
		{
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A31")]
		[Address(RVA = "0x2CEB440", Offset = "0x2CEA440", VA = "0x182CEB440")]
		public static void DeleteSlot(PlayerModes mode, Slots slot)
		{
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A32")]
		[Address(RVA = "0x2CEAD40", Offset = "0x2CE9D40", VA = "0x182CEAD40")]
		public static void CreateThumbnail()
		{
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A33")]
		[Address(RVA = "0x2CEBF40", Offset = "0x2CEAF40", VA = "0x182CEBF40")]
		public static void SaveHostGameGUID()
		{
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x2CEBD80", Offset = "0x2CEAD80", VA = "0x182CEBD80")]
		public static void LoadHostGameGUID()
		{
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x2CEBE30", Offset = "0x2CEAE30", VA = "0x182CEBE30")]
		public static void SaveGameDifficulty()
		{
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x2CEBA60", Offset = "0x2CEAA60", VA = "0x182CEBA60")]
		public static HashSet<string> GetPreviouslyPlayedServers()
		{
			return null;
		}
	}
}
