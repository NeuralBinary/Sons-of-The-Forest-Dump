using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[Serializable]
	public class FovOffsetOptionGui : IntSliderOptionGuiBase
	{
		// Token: 0x060000CF RID: 207 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x303C500", Offset = "0x303AB00", VA = "0x18303C500", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700002B")]
		public override string SettingKey
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x303C530", Offset = "0x303AB30", VA = "0x18303C530", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x1700002C")]
		internal override float BaseSliderOffsetValue
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x303C560", Offset = "0x303AB60", VA = "0x18303C560", Slot = "36")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x303C570", Offset = "0x303AB70", VA = "0x18303C570", Slot = "39")]
		internal override int GetMinIntValue()
		{
			return 0;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xE59CE0", Offset = "0xE582E0", VA = "0x180E59CE0", Slot = "40")]
		internal override int GetMaxIntValue()
		{
			return 0;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public FovOffsetOptionGui()
		{
		}

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		private const string LabelText = "FOV";
	}
}
