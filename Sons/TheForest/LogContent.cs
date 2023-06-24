using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest
{
	// Token: 0x02000371 RID: 881
	[Token(Token = "0x2000371")]
	public class LogContent
	{
		// Token: 0x060017B3 RID: 6067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B3")]
		[Address(RVA = "0x32742A0", Offset = "0x32728A0", VA = "0x1832742A0")]
		public string GetWebEscapedToolTip()
		{
			return null;
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LogContent()
		{
		}

		// Token: 0x040016B3 RID: 5811
		[Token(Token = "0x40016B3")]
		[FieldOffset(Offset = "0x10")]
		public GUIContent content;

		// Token: 0x040016B4 RID: 5812
		[Token(Token = "0x40016B4")]
		[FieldOffset(Offset = "0x18")]
		public LogType type;

		// Token: 0x040016B5 RID: 5813
		[Token(Token = "0x40016B5")]
		[FieldOffset(Offset = "0x1C")]
		public int amount;
	}
}
