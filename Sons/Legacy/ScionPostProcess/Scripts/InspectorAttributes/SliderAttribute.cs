using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes
{
	// Token: 0x020005A7 RID: 1447
	[Token(Token = "0x20005A7")]
	public class SliderAttribute : InspectorAttribute
	{
		// Token: 0x06002618 RID: 9752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002618")]
		[Address(RVA = "0xFC5D60", Offset = "0xFC4360", VA = "0x180FC5D60")]
		public SliderAttribute()
		{
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002619")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public SliderAttribute(string label)
		{
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261A")]
		[Address(RVA = "0x33A6460", Offset = "0x33A4A60", VA = "0x1833A6460")]
		public SliderAttribute(string label, float minValue, float maxValue)
		{
		}

		// Token: 0x04002246 RID: 8774
		[Token(Token = "0x4002246")]
		[FieldOffset(Offset = "0x48")]
		public float minValue;

		// Token: 0x04002247 RID: 8775
		[Token(Token = "0x4002247")]
		[FieldOffset(Offset = "0x4C")]
		public float maxValue;
	}
}
