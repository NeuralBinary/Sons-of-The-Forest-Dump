using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations
{
	// Token: 0x020005A0 RID: 1440
	[Token(Token = "0x20005A0")]
	public class ButtonAttribute : DecorationAttribute
	{
		// Token: 0x06002529 RID: 9513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002529")]
		[Address(RVA = "0x2D7C040", Offset = "0x2D7B040", VA = "0x182D7C040")]
		public ButtonAttribute(int order, string label, string callback)
		{
		}

		// Token: 0x0400217E RID: 8574
		[Token(Token = "0x400217E")]
		[FieldOffset(Offset = "0x20")]
		public readonly string label;

		// Token: 0x0400217F RID: 8575
		[Token(Token = "0x400217F")]
		[FieldOffset(Offset = "0x28")]
		public readonly string callback;

		// Token: 0x04002180 RID: 8576
		[Token(Token = "0x4002180")]
		[FieldOffset(Offset = "0x30")]
		public float width;

		// Token: 0x04002181 RID: 8577
		[Token(Token = "0x4002181")]
		[FieldOffset(Offset = "0x34")]
		public float height;

		// Token: 0x04002182 RID: 8578
		[Token(Token = "0x4002182")]
		[FieldOffset(Offset = "0x38")]
		public string tooltip;
	}
}
