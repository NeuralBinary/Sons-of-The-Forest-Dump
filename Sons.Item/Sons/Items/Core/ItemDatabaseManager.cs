using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sons.Items.Core
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public static class ItemDatabaseManager
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000045")]
		public static List<ItemData> Items
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x30AF870", Offset = "0x30ADE70", VA = "0x1830AF870")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000046")]
		public static List<WeaponMod> WeaponMods
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x30AF8C0", Offset = "0x30ADEC0", VA = "0x1830AF8C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000047")]
		public static List<StatRecipe> StatRecipes
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x30AF9C0", Offset = "0x30ADFC0", VA = "0x1830AF9C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002730 File Offset: 0x00000930
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		public static bool IsBuildingAddressables
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x30AFAC0", Offset = "0x30AE0C0", VA = "0x1830AFAC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x30AFB00", Offset = "0x30AE100", VA = "0x1830AFB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x30AFB40", Offset = "0x30AE140", VA = "0x1830AFB40")]
		public static bool IsItemIdValid(int id)
		{
			return default(bool);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x30AFBC0", Offset = "0x30AE1C0", VA = "0x1830AFBC0")]
		public static bool TryFindItemById(int id, out ItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x30AFCE0", Offset = "0x30AE2E0", VA = "0x1830AFCE0")]
		public static ItemData ItemById(int id)
		{
			return null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x30AFD70", Offset = "0x30AE370", VA = "0x1830AFD70")]
		public static int ItemIndexById(int id)
		{
			return 0;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x30AFE90", Offset = "0x30AE490", VA = "0x1830AFE90")]
		public static int ItemIndexByName(string name)
		{
			return 0;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x30B0010", Offset = "0x30AE610", VA = "0x1830B0010")]
		public static int ItemIdByName(string name)
		{
			return 0;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x30B00E0", Offset = "0x30AE6E0", VA = "0x1830B00E0")]
		public static ItemData ItemByName(string name)
		{
			return null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x30B0400", Offset = "0x30AEA00", VA = "0x1830B0400")]
		public static IEnumerable<ItemData> ItemsByType(Types typeMask)
		{
			return null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x30B05D0", Offset = "0x30AEBD0", VA = "0x1830B05D0")]
		public static IEnumerable<ItemData> ItemsWithTag(string tag)
		{
			return null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x30B0720", Offset = "0x30AED20", VA = "0x1830B0720")]
		public static void Initialize()
		{
		}

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, ItemData> _itemsCache;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x8")]
		public static ItemDatabase _instance;
	}
}
