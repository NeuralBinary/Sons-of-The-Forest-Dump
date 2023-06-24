using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	public abstract class FloatSliderOptionGuiBase : FloatOptionGui
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x17000057")]
		internal virtual float BaseSliderOffsetValue
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "36")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "31")]
		public override bool RoundToInteger()
		{
			return default(bool);
		}

		// Token: 0x060001FC RID: 508
		[Token(Token = "0x60001FC")]
		internal abstract float GetMinFloatValue();

		// Token: 0x060001FD RID: 509
		[Token(Token = "0x60001FD")]
		internal abstract float GetMaxFloatValue();

		// Token: 0x060001FE RID: 510 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x304DB60", Offset = "0x304C160", VA = "0x18304DB60", Slot = "33")]
		internal override float GetMinValue()
		{
			return 0f;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x304DB80", Offset = "0x304C180", VA = "0x18304DB80", Slot = "34")]
		internal override float GetMaxValue()
		{
			return 0f;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x304DBA0", Offset = "0x304C1A0", VA = "0x18304DBA0", Slot = "5")]
		public override void Initialize()
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x304DE50", Offset = "0x304C450", VA = "0x18304DE50", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x304E220", Offset = "0x304C820", VA = "0x18304E220")]
		private void FilterValueReadout(ref float sliderValue)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		protected FloatSliderOptionGuiBase()
		{
		}

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x88")]
		private LinkSliderToText _linkedSliderToText;
	}
}
