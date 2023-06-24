using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[Serializable]
	public class PrecipitationFrequencyOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x0600008C RID: 140 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x303B630", Offset = "0x3039C30", VA = "0x18303B630", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700001A")]
		public override string SettingKey
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x303B660", Offset = "0x3039C60", VA = "0x18303B660", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x303B690", Offset = "0x3039C90", VA = "0x18303B690", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x303B6E0", Offset = "0x3039CE0", VA = "0x18303B6E0", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public PrecipitationFrequencyOptionGui()
		{
		}

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		private const string LabelText = "Precipitation Frequency";
	}
}
