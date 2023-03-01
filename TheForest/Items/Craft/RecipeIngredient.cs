using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace TheForest.Items.Craft
{
	// Token: 0x020004CA RID: 1226
	[Token(Token = "0x20004CA")]
	[Serializable]
	public class RecipeIngredient
	{
		// Token: 0x06001F81 RID: 8065 RVA: 0x00009180 File Offset: 0x00007380
		[Token(Token = "0x6001F81")]
		[Address(RVA = "0x2D30140", Offset = "0x2D2F140", VA = "0x182D30140", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00009198 File Offset: 0x00007398
		[Token(Token = "0x6001F82")]
		[Address(RVA = "0x1DD3570", Offset = "0x1DD2570", VA = "0x181DD3570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F83")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public RecipeIngredient()
		{
		}

		// Token: 0x04001D17 RID: 7447
		[Token(Token = "0x4001D17")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker]
		public int _itemID;

		// Token: 0x04001D18 RID: 7448
		[Token(Token = "0x4001D18")]
		[FieldOffset(Offset = "0x14")]
		public int _amount;
	}
}
