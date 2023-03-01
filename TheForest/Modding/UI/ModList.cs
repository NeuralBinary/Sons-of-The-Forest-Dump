using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using UnityEngine;

namespace TheForest.Modding.UI
{
	// Token: 0x0200049B RID: 1179
	[Token(Token = "0x200049B")]
	public class ModList : MonoBehaviour
	{
		// Token: 0x06001DEF RID: 7663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DEF")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF0")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void Refresh()
		{
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF1")]
		[Address(RVA = "0x2D131F0", Offset = "0x2D121F0", VA = "0x182D131F0")]
		private void ClearUI()
		{
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF2")]
		[Address(RVA = "0x2D13300", Offset = "0x2D12300", VA = "0x182D13300")]
		public ModList()
		{
		}

		// Token: 0x04001C2F RID: 7215
		[Token(Token = "0x4001C2F")]
		[FieldOffset(Offset = "0x20")]
		public string _dirPath;

		// Token: 0x04001C30 RID: 7216
		[Token(Token = "0x4001C30")]
		[FieldOffset(Offset = "0x28")]
		public ModRow _rowPrefab;

		// Token: 0x04001C31 RID: 7217
		[Token(Token = "0x4001C31")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid _grid;
	}
}
