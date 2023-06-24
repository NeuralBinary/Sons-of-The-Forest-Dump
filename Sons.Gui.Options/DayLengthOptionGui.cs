using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[Serializable]
	public class DayLengthOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x06000066 RID: 102 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x303AEA0", Offset = "0x30394A0", VA = "0x18303AEA0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000012")]
		public override string SettingKey
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x303AED0", Offset = "0x30394D0", VA = "0x18303AED0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x303AF00", Offset = "0x3039500", VA = "0x18303AF00", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x303AF50", Offset = "0x3039550", VA = "0x18303AF50", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public DayLengthOptionGui()
		{
		}

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		private const string LabelText = "Day Length";
	}
}
