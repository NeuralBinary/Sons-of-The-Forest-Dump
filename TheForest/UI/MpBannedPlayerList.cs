using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.UI;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000401 RID: 1025
	[Token(Token = "0x2000401")]
	public class MpBannedPlayerList : MonoBehaviour
	{
		// Token: 0x06001AF3 RID: 6899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x2CE7000", Offset = "0x2CE6000", VA = "0x182CE7000")]
		private void OnEnable()
		{
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF4")]
		[Address(RVA = "0x2CE7010", Offset = "0x2CE6010", VA = "0x182CE7010")]
		public void Refresh()
		{
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x2CE71E0", Offset = "0x2CE61E0", VA = "0x182CE71E0")]
		public void UnBan(ulong steamid)
		{
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x2CE6910", Offset = "0x2CE5910", VA = "0x182CE6910")]
		private void AddBannedPlayerRow(CoopKick.KickedPlayer kicked)
		{
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x2CE6CB0", Offset = "0x2CE5CB0", VA = "0x182CE6CB0")]
		private string GetRemainingTime(long timestamp)
		{
			return null;
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public MpBannedPlayerList()
		{
		}

		// Token: 0x04001A46 RID: 6726
		[Token(Token = "0x4001A46")]
		[FieldOffset(Offset = "0x20")]
		public BannedPlayerListRow _rowPrefab;

		// Token: 0x04001A47 RID: 6727
		[Token(Token = "0x4001A47")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid _grid;

		// Token: 0x04001A48 RID: 6728
		[Token(Token = "0x4001A48")]
		[FieldOffset(Offset = "0x30")]
		public UILabel _playerCount;
	}
}
