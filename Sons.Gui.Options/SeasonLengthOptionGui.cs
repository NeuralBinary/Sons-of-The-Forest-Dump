using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	[Serializable]
	public class SeasonLengthOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x06000095 RID: 149 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x303B790", Offset = "0x3039D90", VA = "0x18303B790", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700001C")]
		public override string SettingKey
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x303B7C0", Offset = "0x3039DC0", VA = "0x18303B7C0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x303B7F0", Offset = "0x3039DF0", VA = "0x18303B7F0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x303B840", Offset = "0x3039E40", VA = "0x18303B840", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public SeasonLengthOptionGui()
		{
		}

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		private const string LabelText = "Season Length";
	}
}
