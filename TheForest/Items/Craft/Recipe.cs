using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Utils;
using UnityEngine;

namespace TheForest.Items.Craft
{
	// Token: 0x020004C3 RID: 1219
	[Token(Token = "0x20004C3")]
	[Serializable]
	public class Recipe
	{
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000463")]
		public string IngredientHash
		{
			[Token(Token = "0x6001F5E")]
			[Address(RVA = "0x2D309D0", Offset = "0x2D2F9D0", VA = "0x182D309D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x00009060 File Offset: 0x00007260
		// (set) Token: 0x06001F60 RID: 8032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000464")]
		public bool CanCarryProduct
		{
			[Token(Token = "0x6001F5F")]
			[Address(RVA = "0x1DD5070", Offset = "0x1DD4070", VA = "0x181DD5070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F60")]
			[Address(RVA = "0x2445CD0", Offset = "0x2444CD0", VA = "0x182445CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F61")]
		[Address(RVA = "0x2D30730", Offset = "0x2D2F730", VA = "0x182D30730")]
		public static string IngredientsToRecipeHash(IEnumerable<RecipeIngredient> ingredients)
		{
			return null;
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x6001F62")]
		[Address(RVA = "0x2D30640", Offset = "0x2D2F640", VA = "0x182D30640")]
		public bool HasIngredient(RecipeIngredient searchIngredient)
		{
			return default(bool);
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F63")]
		[Address(RVA = "0x2D30980", Offset = "0x2D2F980", VA = "0x182D30980")]
		public void Refresh()
		{
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x2D30240", Offset = "0x2D2F240", VA = "0x182D30240")]
		public string GetRecipeName()
		{
			return null;
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x2D30960", Offset = "0x2D2F960", VA = "0x182D30960")]
		public bool IsWeaponModRecipe()
		{
			return default(bool);
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x2D309B0", Offset = "0x2D2F9B0", VA = "0x182D309B0")]
		public Recipe()
		{
		}

		// Token: 0x04001CF3 RID: 7411
		[Token(Token = "0x4001CF3")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public int _id;

		// Token: 0x04001CF4 RID: 7412
		[Token(Token = "0x4001CF4")]
		[FieldOffset(Offset = "0x14")]
		public Recipe.Types _type;

		// Token: 0x04001CF5 RID: 7413
		[Token(Token = "0x4001CF5")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public string _name;

		// Token: 0x04001CF6 RID: 7414
		[Token(Token = "0x4001CF6")]
		[FieldOffset(Offset = "0x20")]
		public Sons.Items.Core.Types _productItemType;

		// Token: 0x04001CF7 RID: 7415
		[Token(Token = "0x4001CF7")]
		[FieldOffset(Offset = "0x24")]
		[ItemIdPicker]
		public int _productItemID;

		// Token: 0x04001CF8 RID: 7416
		[Token(Token = "0x4001CF8")]
		[FieldOffset(Offset = "0x28")]
		public RandomRange _productItemAmount;

		// Token: 0x04001CF9 RID: 7417
		[Token(Token = "0x4001CF9")]
		[FieldOffset(Offset = "0x30")]
		public RecipeIngredient[] _ingredients;

		// Token: 0x04001CFA RID: 7418
		[Token(Token = "0x4001CFA")]
		[FieldOffset(Offset = "0x38")]
		public WeaponMod[] _weaponMods;

		// Token: 0x04001CFB RID: 7419
		[Token(Token = "0x4001CFB")]
		[FieldOffset(Offset = "0x40")]
		public bool _hasItemRequirement;

		// Token: 0x04001CFC RID: 7420
		[Token(Token = "0x4001CFC")]
		[FieldOffset(Offset = "0x44")]
		[ItemIdPicker]
		public int _requiredItemId;

		// Token: 0x04001CFD RID: 7421
		[Token(Token = "0x4001CFD")]
		[FieldOffset(Offset = "0x48")]
		public bool _hasItemRestriction;

		// Token: 0x04001CFE RID: 7422
		[Token(Token = "0x4001CFE")]
		[FieldOffset(Offset = "0x4C")]
		[ItemIdPicker]
		public int _restrictedItemId;

		// Token: 0x04001CFF RID: 7423
		[Token(Token = "0x4001CFF")]
		[FieldOffset(Offset = "0x50")]
		public bool _reloadWeapon;

		// Token: 0x04001D00 RID: 7424
		[Token(Token = "0x4001D00")]
		[FieldOffset(Offset = "0x51")]
		public bool _batchUpgrade;

		// Token: 0x04001D01 RID: 7425
		[Token(Token = "0x4001D01")]
		[FieldOffset(Offset = "0x52")]
		public bool _hidden;

		// Token: 0x04001D02 RID: 7426
		[Token(Token = "0x4001D02")]
		[FieldOffset(Offset = "0x53")]
		public bool _forceUnique;

		// Token: 0x04001D03 RID: 7427
		[Token(Token = "0x4001D03")]
		[FieldOffset(Offset = "0x58")]
		private string hash;

		// Token: 0x020004C4 RID: 1220
		[Token(Token = "0x20004C4")]
		public enum Types
		{
			// Token: 0x04001D06 RID: 7430
			[Token(Token = "0x4001D06")]
			Craft,
			// Token: 0x04001D07 RID: 7431
			[Token(Token = "0x4001D07")]
			Upgrade,
			// Token: 0x04001D08 RID: 7432
			[Token(Token = "0x4001D08")]
			Extension,
			// Token: 0x04001D09 RID: 7433
			[Token(Token = "0x4001D09")]
			WeaponMod
		}
	}
}
