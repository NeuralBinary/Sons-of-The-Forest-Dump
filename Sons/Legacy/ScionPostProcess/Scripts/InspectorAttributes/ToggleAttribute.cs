using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes
{
	// Token: 0x020005A8 RID: 1448
	[Token(Token = "0x20005A8")]
	public class ToggleAttribute : InspectorAttribute
	{
		// Token: 0x0600261B RID: 9755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261B")]
		[Address(RVA = "0xFC5D60", Offset = "0xFC4360", VA = "0x180FC5D60")]
		public ToggleAttribute()
		{
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261C")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public ToggleAttribute(string label)
		{
		}

		// Token: 0x04002248 RID: 8776
		[Token(Token = "0x4002248")]
		[FieldOffset(Offset = "0x48")]
		public bool flipped;
	}
}
