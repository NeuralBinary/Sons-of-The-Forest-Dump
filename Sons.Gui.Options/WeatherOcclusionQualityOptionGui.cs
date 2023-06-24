using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	[Serializable]
	public class WeatherOcclusionQualityOptionGui : HighMediumLowOptionGuiBase
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x3053C00", Offset = "0x3052200", VA = "0x183053C00", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000094")]
		public override string SettingKey
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x3053C30", Offset = "0x3052230", VA = "0x183053C30", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x3053C60", Offset = "0x3052260", VA = "0x183053C60", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public WeatherOcclusionQualityOptionGui()
		{
		}

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		private const string LabelText = "Weather Occlusion Quality";
	}
}
