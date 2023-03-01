using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007DC RID: 2012
	[Token(Token = "0x20007DC")]
	[Serializable]
	public class StructureCraftingRecipeIngredient
	{
		// Token: 0x0600353B RID: 13627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353B")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public StructureCraftingRecipeIngredient()
		{
		}

		// Token: 0x04002DB4 RID: 11700
		[Token(Token = "0x4002DB4")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker(true)]
		public int ItemId;

		// Token: 0x04002DB5 RID: 11701
		[Token(Token = "0x4002DB5")]
		[FieldOffset(Offset = "0x14")]
		public int Count;
	}
}
