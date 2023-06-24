using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[Serializable]
	public class SleepingDelayOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x0600009E RID: 158 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x303B8F0", Offset = "0x3039EF0", VA = "0x18303B8F0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700001E")]
		public override string SettingKey
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x303B920", Offset = "0x3039F20", VA = "0x18303B920", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x303B950", Offset = "0x3039F50", VA = "0x18303B950", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x303B9A0", Offset = "0x3039FA0", VA = "0x18303B9A0", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x1700001F")]
		public override bool IsSettingVisible
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x17000020")]
		public override bool IsSettingEnabled
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public SleepingDelayOptionGui()
		{
		}

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		private const string LabelText = "Sleeping Delay";
	}
}
