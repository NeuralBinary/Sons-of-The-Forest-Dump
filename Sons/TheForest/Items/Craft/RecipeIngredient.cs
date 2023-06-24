using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace TheForest.Items.Craft
{
	// Token: 0x020004BF RID: 1215
	[Token(Token = "0x20004BF")]
	[Serializable]
	public class RecipeIngredient
	{
		// Token: 0x06001FE5 RID: 8165 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x330D7A0", Offset = "0x330BDA0", VA = "0x18330D7A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x2134470", Offset = "0x2132A70", VA = "0x182134470", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public RecipeIngredient()
		{
		}

		// Token: 0x04001D53 RID: 7507
		[Token(Token = "0x4001D53")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker]
		public int _itemID;

		// Token: 0x04001D54 RID: 7508
		[Token(Token = "0x4001D54")]
		[FieldOffset(Offset = "0x14")]
		public int _amount;
	}
}
