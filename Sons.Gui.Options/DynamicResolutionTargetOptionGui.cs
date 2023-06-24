using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[Serializable]
	public class DynamicResolutionTargetOptionGui : CustomMenuOptionGui
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x303BD40", Offset = "0x303A340", VA = "0x18303BD40", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x303BD90", Offset = "0x303A390", VA = "0x18303BD90", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x17000025")]
		internal override bool Localize
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000026")]
		public override string SettingKey
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x303BDC0", Offset = "0x303A3C0", VA = "0x18303BDC0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x303BDF0", Offset = "0x303A3F0", VA = "0x18303BDF0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public DynamicResolutionTargetOptionGui()
		{
		}

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		private const string LabelText = "Dynamic Resolution Target";
	}
}
