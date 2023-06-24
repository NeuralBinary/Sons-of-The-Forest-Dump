using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TheForest.Commons.Enums;

namespace TheForest.Utils
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	public static class SaveSlotUtils
	{
		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A66 RID: 6758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B7")]
		public static string UserId
		{
			[Token(Token = "0x6001A65")]
			[Address(RVA = "0x32A0040", Offset = "0x329E640", VA = "0x1832A0040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A66")]
			[Address(RVA = "0x32A0080", Offset = "0x329E680", VA = "0x1832A0080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x32A0110", Offset = "0x329E710", VA = "0x1832A0110")]
		public static void SetUserId(string userId)
		{
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x32A0120", Offset = "0x329E720", VA = "0x1832A0120")]
		public static string GetUserPath()
		{
			return null;
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x32A0360", Offset = "0x329E960", VA = "0x1832A0360")]
		public static string GetLocalSlotPath()
		{
			return null;
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x32A03F0", Offset = "0x329E9F0", VA = "0x1832A03F0")]
		public static string GetLocalSlotPath(Slots slot)
		{
			return null;
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x32A0480", Offset = "0x329EA80", VA = "0x1832A0480")]
		public static string GetLocalSlotPath(PlayerModes mode, Slots slot)
		{
			return null;
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x32A05C0", Offset = "0x329EBC0", VA = "0x1832A05C0")]
		public static string GetMpClientLocalPath()
		{
			return null;
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x32A0640", Offset = "0x329EC40", VA = "0x1832A0640")]
		public static string GetCloudSlotPath()
		{
			return null;
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x32A0740", Offset = "0x329ED40", VA = "0x1832A0740")]
		public static string GetCloudSlotPath(Slots slot)
		{
			return null;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x32A07D0", Offset = "0x329EDD0", VA = "0x1832A07D0")]
		public static string GetCloudSlotPath(PlayerModes mode, Slots slot)
		{
			return null;
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00008070 File Offset: 0x00006270
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x32A0890", Offset = "0x329EE90", VA = "0x1832A0890")]
		public static bool HasLocalFile(Slots slot, string filename)
		{
			return default(bool);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x32A08C0", Offset = "0x329EEC0", VA = "0x1832A08C0")]
		private static void DeleteDirectory(string target_dir)
		{
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x32A0B80", Offset = "0x329F180", VA = "0x1832A0B80")]
		public static void DeleteSlot(PlayerModes mode, Slots slot)
		{
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x32A0C50", Offset = "0x329F250", VA = "0x1832A0C50")]
		public static void CreateThumbnail()
		{
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x32A16B0", Offset = "0x329FCB0", VA = "0x1832A16B0")]
		public static HashSet<string> GetPreviouslyPlayedServers()
		{
			return null;
		}
	}
}
