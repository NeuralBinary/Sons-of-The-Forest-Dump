using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest
{
	// Token: 0x0200037F RID: 895
	[Token(Token = "0x200037F")]
	public class LogContent
	{
		// Token: 0x06001778 RID: 6008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001778")]
		[Address(RVA = "0x2CB46B0", Offset = "0x2CB36B0", VA = "0x182CB46B0")]
		public string GetWebEscapedToolTip()
		{
			return null;
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001779")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public LogContent()
		{
		}

		// Token: 0x04001694 RID: 5780
		[Token(Token = "0x4001694")]
		[FieldOffset(Offset = "0x10")]
		public GUIContent content;

		// Token: 0x04001695 RID: 5781
		[Token(Token = "0x4001695")]
		[FieldOffset(Offset = "0x18")]
		public LogType type;

		// Token: 0x04001696 RID: 5782
		[Token(Token = "0x4001696")]
		[FieldOffset(Offset = "0x1C")]
		public int amount;
	}
}
