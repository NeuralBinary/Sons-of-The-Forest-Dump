using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes
{
	// Token: 0x02000597 RID: 1431
	[Token(Token = "0x2000597")]
	public class SliderAttribute : InspectorAttribute
	{
		// Token: 0x06002519 RID: 9497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002519")]
		[Address(RVA = "0x2D82F60", Offset = "0x2D81F60", VA = "0x182D82F60")]
		public SliderAttribute()
		{
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251A")]
		[Address(RVA = "0x8FF070", Offset = "0x8FE070", VA = "0x1808FF070")]
		public SliderAttribute(string label)
		{
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251B")]
		[Address(RVA = "0x2D8FB30", Offset = "0x2D8EB30", VA = "0x182D8FB30")]
		public SliderAttribute(string label, float minValue, float maxValue)
		{
		}

		// Token: 0x04002172 RID: 8562
		[Token(Token = "0x4002172")]
		[FieldOffset(Offset = "0x48")]
		public float minValue;

		// Token: 0x04002173 RID: 8563
		[Token(Token = "0x4002173")]
		[FieldOffset(Offset = "0x4C")]
		public float maxValue;
	}
}
