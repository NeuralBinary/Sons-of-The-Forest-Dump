using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	[Serializable]
	public struct TextStyle
	{
		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TextStyle defaultTextStyle;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x0")]
		public TMP_FontAsset font;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x8")]
		public float size;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0xC")]
		public FontStyles style;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x10")]
		public TextAlign alignment;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x14")]
		public float characterSpacing;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x18")]
		public float wordSpacing;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x1C")]
		public float lineSpacing;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x20")]
		public float paragraphSpacing;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x24")]
		public Vector4 margins;
	}
}
