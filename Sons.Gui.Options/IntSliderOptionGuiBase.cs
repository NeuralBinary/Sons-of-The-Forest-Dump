using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	public abstract class IntSliderOptionGuiBase : FloatSliderOptionGuiBase
	{
		// Token: 0x06000227 RID: 551 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "31")]
		public override bool RoundToInteger()
		{
			return default(bool);
		}

		// Token: 0x06000228 RID: 552
		[Token(Token = "0x6000228")]
		internal abstract int GetMinIntValue();

		// Token: 0x06000229 RID: 553
		[Token(Token = "0x6000229")]
		internal abstract int GetMaxIntValue();

		// Token: 0x0600022A RID: 554 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x304F930", Offset = "0x304DF30", VA = "0x18304F930", Slot = "37")]
		internal override float GetMinFloatValue()
		{
			return 0f;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x304F960", Offset = "0x304DF60", VA = "0x18304F960", Slot = "38")]
		internal override float GetMaxFloatValue()
		{
			return 0f;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		protected IntSliderOptionGuiBase()
		{
		}
	}
}
