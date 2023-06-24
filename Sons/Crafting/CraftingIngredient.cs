using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;

namespace Sons.Crafting
{
	// Token: 0x020006AE RID: 1710
	[Token(Token = "0x20006AE")]
	[Serializable]
	public class CraftingIngredient
	{
		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D41 RID: 11585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FD")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x6002D40")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D41")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D42")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CraftingIngredient()
		{
		}

		// Token: 0x040027A9 RID: 10153
		[Token(Token = "0x40027A9")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker(true)]
		public int ItemId;

		// Token: 0x040027AA RID: 10154
		[Token(Token = "0x40027AA")]
		[FieldOffset(Offset = "0x14")]
		public int Count;

		// Token: 0x040027AB RID: 10155
		[Token(Token = "0x40027AB")]
		[FieldOffset(Offset = "0x18")]
		public bool IsReusable;
	}
}
