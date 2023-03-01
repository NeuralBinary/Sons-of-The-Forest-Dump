using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations
{
	// Token: 0x020005A1 RID: 1441
	[Token(Token = "0x20005A1")]
	public abstract class HelpBoxAttribute : DecorationAttribute
	{
		// Token: 0x0600252A RID: 9514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252A")]
		[Address(RVA = "0x2D82F90", Offset = "0x2D81F90", VA = "0x182D82F90")]
		public HelpBoxAttribute(int order, string message)
		{
		}

		// Token: 0x04002183 RID: 8579
		[Token(Token = "0x4002183")]
		[FieldOffset(Offset = "0x20")]
		public readonly string message;

		// Token: 0x04002184 RID: 8580
		[Token(Token = "0x4002184")]
		[FieldOffset(Offset = "0x28")]
		public float width;
	}
}
