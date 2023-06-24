using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[Serializable]
	public class StartingSeasonOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x303B9F0", Offset = "0x3039FF0", VA = "0x18303B9F0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000021")]
		public override string SettingKey
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x303BA20", Offset = "0x303A020", VA = "0x18303BA20", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x303BA50", Offset = "0x303A050", VA = "0x18303BA50", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x303BAA0", Offset = "0x303A0A0", VA = "0x18303BAA0", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public StartingSeasonOptionGui()
		{
		}

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		private const string LabelText = "Starting Season";
	}
}
