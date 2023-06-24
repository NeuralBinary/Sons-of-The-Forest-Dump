using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using UnityEngine;

namespace TheForest.Modding.UI
{
	// Token: 0x02000490 RID: 1168
	[Token(Token = "0x2000490")]
	public class ModList : MonoBehaviour
	{
		// Token: 0x06001E3F RID: 7743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnEnable()
		{
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void Refresh()
		{
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x32EF330", Offset = "0x32ED930", VA = "0x1832EF330")]
		private void ClearUI()
		{
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x32EF650", Offset = "0x32EDC50", VA = "0x1832EF650")]
		public ModList()
		{
		}

		// Token: 0x04001C5F RID: 7263
		[Token(Token = "0x4001C5F")]
		[FieldOffset(Offset = "0x20")]
		public string _dirPath;

		// Token: 0x04001C60 RID: 7264
		[Token(Token = "0x4001C60")]
		[FieldOffset(Offset = "0x28")]
		public ModRow _rowPrefab;

		// Token: 0x04001C61 RID: 7265
		[Token(Token = "0x4001C61")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid _grid;
	}
}
