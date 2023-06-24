using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	public class ReadOptions
	{
		// Token: 0x06000B19 RID: 2841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x200ACF0", Offset = "0x20092F0", VA = "0x18200ACF0")]
		public ReadOptions()
		{
		}

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x10")]
		public bool ReadMaterials;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x18")]
		public CommandArgumentSet CustomFlags;

		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ReadOptions Defaults;
	}
}
