using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations
{
	// Token: 0x020005B0 RID: 1456
	[Token(Token = "0x20005B0")]
	public class ButtonAttribute : DecorationAttribute
	{
		// Token: 0x06002628 RID: 9768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002628")]
		[Address(RVA = "0x33A6670", Offset = "0x33A4C70", VA = "0x1833A6670")]
		public ButtonAttribute(int order, string label, string callback)
		{
		}

		// Token: 0x04002252 RID: 8786
		[Token(Token = "0x4002252")]
		[FieldOffset(Offset = "0x20")]
		public readonly string label;

		// Token: 0x04002253 RID: 8787
		[Token(Token = "0x4002253")]
		[FieldOffset(Offset = "0x28")]
		public readonly string callback;

		// Token: 0x04002254 RID: 8788
		[Token(Token = "0x4002254")]
		[FieldOffset(Offset = "0x30")]
		public float width;

		// Token: 0x04002255 RID: 8789
		[Token(Token = "0x4002255")]
		[FieldOffset(Offset = "0x34")]
		public float height;

		// Token: 0x04002256 RID: 8790
		[Token(Token = "0x4002256")]
		[FieldOffset(Offset = "0x38")]
		public string tooltip;
	}
}
