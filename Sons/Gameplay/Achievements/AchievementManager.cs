using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000886 RID: 2182
	[Token(Token = "0x2000886")]
	public class AchievementManager : MonoBehaviour
	{
		// Token: 0x06003E5E RID: 15966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5E")]
		[Address(RVA = "0x35D0AC0", Offset = "0x35CF0C0", VA = "0x1835D0AC0")]
		public void Initialize()
		{
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5F")]
		[Address(RVA = "0x35D0EF0", Offset = "0x35CF4F0", VA = "0x1835D0EF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E60")]
		[Address(RVA = "0x35D0F30", Offset = "0x35CF530", VA = "0x1835D0F30")]
		private void OnReceivedStats(UserStatsReceived_t info)
		{
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x00013110 File Offset: 0x00011310
		[Token(Token = "0x6003E61")]
		public bool TryGetAchievement<T>(out T outAchievement) where T : Achievement
		{
			return default(bool);
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x00013128 File Offset: 0x00011328
		[Token(Token = "0x6003E62")]
		[Address(RVA = "0x35D1130", Offset = "0x35CF730", VA = "0x1835D1130")]
		private bool DebugCommandResetAllAchievements(string arg)
		{
			return default(bool);
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x00013140 File Offset: 0x00011340
		[Token(Token = "0x6003E63")]
		[Address(RVA = "0x35D1390", Offset = "0x35CF990", VA = "0x1835D1390")]
		private bool DebugCommandResetAchievement(string arg)
		{
			return default(bool);
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x00013158 File Offset: 0x00011358
		[Token(Token = "0x6003E64")]
		[Address(RVA = "0x35D1610", Offset = "0x35CFC10", VA = "0x1835D1610")]
		private bool DebugCommandListAchievements(string arg)
		{
			return default(bool);
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E65")]
		[Address(RVA = "0x35D19B0", Offset = "0x35CFFB0", VA = "0x1835D19B0")]
		public AchievementManager()
		{
		}

		// Token: 0x0400346C RID: 13420
		[Token(Token = "0x400346C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Achievement> _achievements;

		// Token: 0x0400346D RID: 13421
		[Token(Token = "0x400346D")]
		[FieldOffset(Offset = "0x28")]
		private bool _isInitialized;

		// Token: 0x0400346E RID: 13422
		[Token(Token = "0x400346E")]
		[FieldOffset(Offset = "0x30")]
		private Callback<UserStatsReceived_t> _receivedStatsCallback;
	}
}
