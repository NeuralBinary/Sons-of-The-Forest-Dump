using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations
{
	// Token: 0x020005B1 RID: 1457
	[Token(Token = "0x20005B1")]
	public abstract class HelpBoxAttribute : DecorationAttribute
	{
		// Token: 0x06002629 RID: 9769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002629")]
		[Address(RVA = "0x33A6740", Offset = "0x33A4D40", VA = "0x1833A6740")]
		public HelpBoxAttribute(int order, string message)
		{
		}

		// Token: 0x04002257 RID: 8791
		[Token(Token = "0x4002257")]
		[FieldOffset(Offset = "0x20")]
		public readonly string message;

		// Token: 0x04002258 RID: 8792
		[Token(Token = "0x4002258")]
		[FieldOffset(Offset = "0x28")]
		public float width;
	}
}
