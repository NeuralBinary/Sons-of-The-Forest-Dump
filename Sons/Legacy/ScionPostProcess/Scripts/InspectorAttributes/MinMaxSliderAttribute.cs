using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes
{
	// Token: 0x020005AB RID: 1451
	[Token(Token = "0x20005AB")]
	public class MinMaxSliderAttribute : InspectorAttribute
	{
		// Token: 0x06002621 RID: 9761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002621")]
		[Address(RVA = "0x33A64C0", Offset = "0x33A4AC0", VA = "0x1833A64C0")]
		public MinMaxSliderAttribute()
		{
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002622")]
		[Address(RVA = "0x33A6520", Offset = "0x33A4B20", VA = "0x1833A6520")]
		public MinMaxSliderAttribute(string label)
		{
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002623")]
		[Address(RVA = "0x33A6580", Offset = "0x33A4B80", VA = "0x1833A6580")]
		public MinMaxSliderAttribute(string label, float minValue, float maxValue)
		{
		}

		// Token: 0x0400224A RID: 8778
		[Token(Token = "0x400224A")]
		[FieldOffset(Offset = "0x48")]
		public float minValue;

		// Token: 0x0400224B RID: 8779
		[Token(Token = "0x400224B")]
		[FieldOffset(Offset = "0x4C")]
		public float maxValue;

		// Token: 0x0400224C RID: 8780
		[Token(Token = "0x400224C")]
		[FieldOffset(Offset = "0x50")]
		public bool showFields;
	}
}
