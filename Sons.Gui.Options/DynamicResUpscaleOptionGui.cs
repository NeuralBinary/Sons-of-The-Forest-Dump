using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Serializable]
	public class DynamicResUpscaleOptionGui : CustomMenuOptionGui
	{
		// Token: 0x060000BD RID: 189 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x303BE40", Offset = "0x303A440", VA = "0x18303BE40", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000027")]
		public override string SettingKey
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x303BE70", Offset = "0x303A470", VA = "0x18303BE70", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x303BEA0", Offset = "0x303A4A0", VA = "0x18303BEA0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x303BEE0", Offset = "0x303A4E0", VA = "0x18303BEE0", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x303BF30", Offset = "0x303A530", VA = "0x18303BF30")]
		public void SetValueOff()
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x17000028")]
		public bool IsOn
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x303BF80", Offset = "0x303A580", VA = "0x18303BF80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x303C080", Offset = "0x303A680", VA = "0x18303C080")]
		public bool IsDlssOn()
		{
			return default(bool);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x303C1C0", Offset = "0x303A7C0", VA = "0x18303C1C0")]
		public bool IsFsrOn()
		{
			return default(bool);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x303C2C0", Offset = "0x303A8C0", VA = "0x18303C2C0")]
		public bool IsTaauOn()
		{
			return default(bool);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public DynamicResUpscaleOptionGui()
		{
		}

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		private const string LabelText = "Dynamic Resolution";
	}
}
