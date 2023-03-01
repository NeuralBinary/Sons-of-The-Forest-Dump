using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200072A RID: 1834
	[Token(Token = "0x200072A")]
	public class AchievementManager : MonoBehaviour
	{
		// Token: 0x06002FF2 RID: 12274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF2")]
		[Address(RVA = "0x2E211D0", Offset = "0x2E201D0", VA = "0x182E211D0")]
		public void Initialize()
		{
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF3")]
		[Address(RVA = "0x2E21400", Offset = "0x2E20400", VA = "0x182E21400")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF4")]
		[Address(RVA = "0x2E21450", Offset = "0x2E20450", VA = "0x182E21450")]
		private void OnReceivedStats(UserStatsReceived_t info)
		{
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		[Token(Token = "0x6002FF5")]
		public bool TryGetAchievement<T>(out T outAchievement) where T : Achievement
		{
			return default(bool);
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x0000DC08 File Offset: 0x0000BE08
		[Token(Token = "0x6002FF6")]
		[Address(RVA = "0x2E21050", Offset = "0x2E20050", VA = "0x182E21050")]
		private bool DebugCommandResetAllAchievements(string arg)
		{
			return default(bool);
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x0000DC20 File Offset: 0x0000BE20
		[Token(Token = "0x6002FF7")]
		[Address(RVA = "0x2E20E60", Offset = "0x2E1FE60", VA = "0x182E20E60")]
		private bool DebugCommandResetAchievement(string arg)
		{
			return default(bool);
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x0000DC38 File Offset: 0x0000BE38
		[Token(Token = "0x6002FF8")]
		[Address(RVA = "0x2E20BB0", Offset = "0x2E1FBB0", VA = "0x182E20BB0")]
		private bool DebugCommandListAchievements(string arg)
		{
			return default(bool);
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x2E215C0", Offset = "0x2E205C0", VA = "0x182E215C0")]
		public AchievementManager()
		{
		}

		// Token: 0x04002A3F RID: 10815
		[Token(Token = "0x4002A3F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Achievement> _achievements;

		// Token: 0x04002A40 RID: 10816
		[Token(Token = "0x4002A40")]
		[FieldOffset(Offset = "0x28")]
		private bool _isInitialized;

		// Token: 0x04002A41 RID: 10817
		[Token(Token = "0x4002A41")]
		[FieldOffset(Offset = "0x30")]
		private Callback<UserStatsReceived_t> _receivedStatsCallback;
	}
}
