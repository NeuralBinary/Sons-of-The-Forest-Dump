using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[Serializable]
	public class DynamicRangeProfileOptionGui : CustomMenuOptionGui
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x303BC30", Offset = "0x303A230", VA = "0x18303BC30", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x303BC80", Offset = "0x303A280", VA = "0x18303BC80", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000024")]
		public override string SettingKey
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x303BCB0", Offset = "0x303A2B0", VA = "0x18303BCB0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x303BCE0", Offset = "0x303A2E0", VA = "0x18303BCE0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public DynamicRangeProfileOptionGui()
		{
		}

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		private const string LabelText = "Profiles";
	}
}
