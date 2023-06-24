using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	[Serializable]
	public class VSyncOptionGui : CustomMenuOptionGui
	{
		// Token: 0x060002E6 RID: 742 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x3053670", Offset = "0x3051C70", VA = "0x183053670", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000090")]
		public override string SettingKey
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x30536A0", Offset = "0x3051CA0", VA = "0x1830536A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x30536D0", Offset = "0x3051CD0", VA = "0x1830536D0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000091")]
		internal override List<List<object>> LocalizationArgs
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x3053700", Offset = "0x3051D00", VA = "0x183053700", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x17000092")]
		internal override bool Localize
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x3053B20", Offset = "0x3052120", VA = "0x183053B20", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public VSyncOptionGui()
		{
		}

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		private const string LabelText = "VSync";
	}
}
