using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;

namespace Sons.Crafting
{
	// Token: 0x020007A3 RID: 1955
	[Token(Token = "0x20007A3")]
	[Serializable]
	public class CraftingIngredient
	{
		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060033C8 RID: 13256 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060033C9 RID: 13257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000690")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x60033C8")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60033C9")]
			[Address(RVA = "0x541240", Offset = "0x540240", VA = "0x180541240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CA")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public CraftingIngredient()
		{
		}

		// Token: 0x04002CD6 RID: 11478
		[Token(Token = "0x4002CD6")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker(4, true)]
		public int ItemId;

		// Token: 0x04002CD7 RID: 11479
		[Token(Token = "0x4002CD7")]
		[FieldOffset(Offset = "0x14")]
		public int Count;

		// Token: 0x04002CD8 RID: 11480
		[Token(Token = "0x4002CD8")]
		[FieldOffset(Offset = "0x18")]
		public bool IsReusable;
	}
}
