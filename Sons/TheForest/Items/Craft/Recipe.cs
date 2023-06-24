using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Utils;
using UnityEngine;

namespace TheForest.Items.Craft
{
	// Token: 0x020004B8 RID: 1208
	[Token(Token = "0x20004B8")]
	[Serializable]
	public class Recipe
	{
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000472")]
		public string IngredientHash
		{
			[Token(Token = "0x6001FC2")]
			[Address(RVA = "0x330BCA0", Offset = "0x330A2A0", VA = "0x18330BCA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x000093C0 File Offset: 0x000075C0
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000473")]
		public bool CanCarryProduct
		{
			[Token(Token = "0x6001FC3")]
			[Address(RVA = "0x213CBA0", Offset = "0x213B1A0", VA = "0x18213CBA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FC4")]
			[Address(RVA = "0x28D8B60", Offset = "0x28D7160", VA = "0x1828D8B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0x330BD20", Offset = "0x330A320", VA = "0x18330BD20")]
		public static string IngredientsToRecipeHash(IEnumerable<RecipeIngredient> ingredients)
		{
			return null;
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x000093D8 File Offset: 0x000075D8
		[Token(Token = "0x6001FC6")]
		[Address(RVA = "0x330C110", Offset = "0x330A710", VA = "0x18330C110")]
		public bool HasIngredient(RecipeIngredient searchIngredient)
		{
			return default(bool);
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC7")]
		[Address(RVA = "0x330C230", Offset = "0x330A830", VA = "0x18330C230")]
		public void Refresh()
		{
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC8")]
		[Address(RVA = "0x330C290", Offset = "0x330A890", VA = "0x18330C290")]
		public string GetRecipeName()
		{
			return null;
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x000093F0 File Offset: 0x000075F0
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0x330C830", Offset = "0x330AE30", VA = "0x18330C830")]
		public bool IsWeaponModRecipe()
		{
			return default(bool);
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0x330C850", Offset = "0x330AE50", VA = "0x18330C850")]
		public Recipe()
		{
		}

		// Token: 0x04001D2F RID: 7471
		[Token(Token = "0x4001D2F")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public int _id;

		// Token: 0x04001D30 RID: 7472
		[Token(Token = "0x4001D30")]
		[FieldOffset(Offset = "0x14")]
		public Recipe.Types _type;

		// Token: 0x04001D31 RID: 7473
		[Token(Token = "0x4001D31")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public string _name;

		// Token: 0x04001D32 RID: 7474
		[Token(Token = "0x4001D32")]
		[FieldOffset(Offset = "0x20")]
		public Sons.Items.Core.Types _productItemType;

		// Token: 0x04001D33 RID: 7475
		[Token(Token = "0x4001D33")]
		[FieldOffset(Offset = "0x24")]
		[ItemIdPicker]
		public int _productItemID;

		// Token: 0x04001D34 RID: 7476
		[Token(Token = "0x4001D34")]
		[FieldOffset(Offset = "0x28")]
		public RandomRange _productItemAmount;

		// Token: 0x04001D35 RID: 7477
		[Token(Token = "0x4001D35")]
		[FieldOffset(Offset = "0x30")]
		public RecipeIngredient[] _ingredients;

		// Token: 0x04001D36 RID: 7478
		[Token(Token = "0x4001D36")]
		[FieldOffset(Offset = "0x38")]
		public WeaponMod[] _weaponMods;

		// Token: 0x04001D37 RID: 7479
		[Token(Token = "0x4001D37")]
		[FieldOffset(Offset = "0x40")]
		public bool _hasItemRequirement;

		// Token: 0x04001D38 RID: 7480
		[Token(Token = "0x4001D38")]
		[FieldOffset(Offset = "0x44")]
		[ItemIdPicker]
		public int _requiredItemId;

		// Token: 0x04001D39 RID: 7481
		[Token(Token = "0x4001D39")]
		[FieldOffset(Offset = "0x48")]
		public bool _hasItemRestriction;

		// Token: 0x04001D3A RID: 7482
		[Token(Token = "0x4001D3A")]
		[FieldOffset(Offset = "0x4C")]
		[ItemIdPicker]
		public int _restrictedItemId;

		// Token: 0x04001D3B RID: 7483
		[Token(Token = "0x4001D3B")]
		[FieldOffset(Offset = "0x50")]
		public bool _reloadWeapon;

		// Token: 0x04001D3C RID: 7484
		[Token(Token = "0x4001D3C")]
		[FieldOffset(Offset = "0x51")]
		public bool _batchUpgrade;

		// Token: 0x04001D3D RID: 7485
		[Token(Token = "0x4001D3D")]
		[FieldOffset(Offset = "0x52")]
		public bool _hidden;

		// Token: 0x04001D3E RID: 7486
		[Token(Token = "0x4001D3E")]
		[FieldOffset(Offset = "0x53")]
		public bool _forceUnique;

		// Token: 0x04001D3F RID: 7487
		[Token(Token = "0x4001D3F")]
		[FieldOffset(Offset = "0x58")]
		private string hash;

		// Token: 0x020004B9 RID: 1209
		[Token(Token = "0x20004B9")]
		public enum Types
		{
			// Token: 0x04001D42 RID: 7490
			[Token(Token = "0x4001D42")]
			Craft,
			// Token: 0x04001D43 RID: 7491
			[Token(Token = "0x4001D43")]
			Upgrade,
			// Token: 0x04001D44 RID: 7492
			[Token(Token = "0x4001D44")]
			Extension,
			// Token: 0x04001D45 RID: 7493
			[Token(Token = "0x4001D45")]
			WeaponMod
		}
	}
}
