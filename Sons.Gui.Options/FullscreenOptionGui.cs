using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[Serializable]
	public class FullscreenOptionGui : CustomMenuOptionGui
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x303C580", Offset = "0x303AB80", VA = "0x18303C580", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700002D")]
		public override string SettingKey
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x303C5B0", Offset = "0x303ABB0", VA = "0x18303C5B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x303C5E0", Offset = "0x303ABE0", VA = "0x18303C5E0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x303C610", Offset = "0x303AC10", VA = "0x18303C610", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x1700002E")]
		internal override bool Localize
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public FullscreenOptionGui()
		{
		}

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		private const string LabelText = "Fullscreen";
	}
}
