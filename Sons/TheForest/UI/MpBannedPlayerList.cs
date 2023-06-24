using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.UI;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003F3 RID: 1011
	[Token(Token = "0x20003F3")]
	public class MpBannedPlayerList : MonoBehaviour
	{
		// Token: 0x06001B31 RID: 6961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B31")]
		[Address(RVA = "0x32B2E90", Offset = "0x32B1490", VA = "0x1832B2E90")]
		private void OnEnable()
		{
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B32")]
		[Address(RVA = "0x32B2EA0", Offset = "0x32B14A0", VA = "0x1832B2EA0")]
		public void Refresh()
		{
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B33")]
		[Address(RVA = "0x32B32D0", Offset = "0x32B18D0", VA = "0x1832B32D0")]
		public void UnBan(ulong steamid)
		{
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B34")]
		[Address(RVA = "0x32B3400", Offset = "0x32B1A00", VA = "0x1832B3400")]
		private void AddBannedPlayerRow(CoopKick.KickedPlayer kicked)
		{
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B35")]
		[Address(RVA = "0x32B39F0", Offset = "0x32B1FF0", VA = "0x1832B39F0")]
		private string GetRemainingTime(long timestamp)
		{
			return null;
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MpBannedPlayerList()
		{
		}

		// Token: 0x04001A6A RID: 6762
		[Token(Token = "0x4001A6A")]
		[FieldOffset(Offset = "0x20")]
		public BannedPlayerListRow _rowPrefab;

		// Token: 0x04001A6B RID: 6763
		[Token(Token = "0x4001A6B")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid _grid;

		// Token: 0x04001A6C RID: 6764
		[Token(Token = "0x4001A6C")]
		[FieldOffset(Offset = "0x30")]
		public UILabel _playerCount;
	}
}
