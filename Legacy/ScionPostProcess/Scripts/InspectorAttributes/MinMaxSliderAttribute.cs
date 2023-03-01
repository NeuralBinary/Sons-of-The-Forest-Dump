using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes
{
	// Token: 0x0200059B RID: 1435
	[Token(Token = "0x200059B")]
	public class MinMaxSliderAttribute : InspectorAttribute
	{
		// Token: 0x06002522 RID: 9506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002522")]
		[Address(RVA = "0x2D85710", Offset = "0x2D84710", VA = "0x182D85710")]
		public MinMaxSliderAttribute()
		{
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002523")]
		[Address(RVA = "0x2D85670", Offset = "0x2D84670", VA = "0x182D85670")]
		public MinMaxSliderAttribute(string label)
		{
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002524")]
		[Address(RVA = "0x2D856B0", Offset = "0x2D846B0", VA = "0x182D856B0")]
		public MinMaxSliderAttribute(string label, float minValue, float maxValue)
		{
		}

		// Token: 0x04002176 RID: 8566
		[Token(Token = "0x4002176")]
		[FieldOffset(Offset = "0x48")]
		public float minValue;

		// Token: 0x04002177 RID: 8567
		[Token(Token = "0x4002177")]
		[FieldOffset(Offset = "0x4C")]
		public float maxValue;

		// Token: 0x04002178 RID: 8568
		[Token(Token = "0x4002178")]
		[FieldOffset(Offset = "0x50")]
		public bool showFields;
	}
}
