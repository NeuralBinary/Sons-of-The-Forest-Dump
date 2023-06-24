using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Crafting
{
	// Token: 0x020006AF RID: 1711
	[Token(Token = "0x20006AF")]
	[CreateAssetMenu(fileName = "CraftingRecipe", menuName = "Sons/Crafting/Recipe")]
	public class CraftingRecipe : ScriptableObject
	{
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FE")]
		public string CraftCompleteAudioEvent
		{
			[Token(Token = "0x6002D43")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FF")]
		public string DuringCraftJingleAudioEvent
		{
			[Token(Token = "0x6002D44")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x0000D560 File Offset: 0x0000B760
		[Token(Token = "0x17000600")]
		public CraftingRecipe.Type RecipeType
		{
			[Token(Token = "0x6002D45")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return CraftingRecipe.Type.CraftNewItem;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000601")]
		public string Name
		{
			[Token(Token = "0x6002D46")]
			[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000602")]
		public List<CraftingIngredient> Ingredients
		{
			[Token(Token = "0x6002D47")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06002D48 RID: 11592 RVA: 0x0000D578 File Offset: 0x0000B778
		[Token(Token = "0x17000603")]
		public bool ForceNewItemInstance
		{
			[Token(Token = "0x6002D48")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D49")]
		[Address(RVA = "0x3433440", Offset = "0x3431A40", VA = "0x183433440")]
		public List<CraftingRecipe.ResultingItem> GenerateResultingItems()
		{
			return null;
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06002D4A RID: 11594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000604")]
		public string AnimationStateName
		{
			[Token(Token = "0x6002D4A")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06002D4B RID: 11595 RVA: 0x0000D590 File Offset: 0x0000B790
		[Token(Token = "0x17000605")]
		public bool HasCraftAnimation
		{
			[Token(Token = "0x6002D4B")]
			[Address(RVA = "0x34334A0", Offset = "0x3431AA0", VA = "0x1834334A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		[Token(Token = "0x6002D4C")]
		[Address(RVA = "0x34334C0", Offset = "0x3431AC0", VA = "0x1834334C0")]
		public bool HasIngredient(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		[Token(Token = "0x6002D4D")]
		[Address(RVA = "0x3433580", Offset = "0x3431B80", VA = "0x183433580")]
		public int RequiredCount(int itemId)
		{
			return 0;
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4E")]
		[Address(RVA = "0x3433660", Offset = "0x3431C60", VA = "0x183433660")]
		public void GenerateResultingItemList()
		{
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000606")]
		public WeaponMod WeaponMod
		{
			[Token(Token = "0x6002D4F")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D50")]
		[Address(RVA = "0x3433910", Offset = "0x3431F10", VA = "0x183433910")]
		public CraftingRecipe()
		{
		}

		// Token: 0x040027AD RID: 10157
		[Token(Token = "0x40027AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CraftingRecipe.Type _recipeType;

		// Token: 0x040027AE RID: 10158
		[Token(Token = "0x40027AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _animationStateName;

		// Token: 0x040027AF RID: 10159
		[Token(Token = "0x40027AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<CraftingIngredient> _ingredients;

		// Token: 0x040027B0 RID: 10160
		[Token(Token = "0x40027B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useContainerDataForResultingItems;

		// Token: 0x040027B1 RID: 10161
		[Token(Token = "0x40027B1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ContainerItemSpawnerData _containerItemData;

		// Token: 0x040027B2 RID: 10162
		[Token(Token = "0x40027B2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<CraftingRecipe.ResultingItem> _resultingItems;

		// Token: 0x040027B3 RID: 10163
		[Token(Token = "0x40027B3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _forceNewItemInstance;

		// Token: 0x040027B4 RID: 10164
		[Token(Token = "0x40027B4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[EventRef]
		private string _craftCompleteAudioEvent;

		// Token: 0x040027B5 RID: 10165
		[Token(Token = "0x40027B5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[EventRef]
		private string _duringCraftJingleAudioEvent;

		// Token: 0x040027B6 RID: 10166
		[Token(Token = "0x40027B6")]
		[FieldOffset(Offset = "0x60")]
		private List<CraftingRecipe.ResultingItem> _generatedResultingItems;

		// Token: 0x040027B7 RID: 10167
		[Token(Token = "0x40027B7")]
		[FieldOffset(Offset = "0x68")]
		[Space]
		[SerializeField]
		private WeaponMod _weaponMod;

		// Token: 0x020006B0 RID: 1712
		[Token(Token = "0x20006B0")]
		public enum Type
		{
			// Token: 0x040027B9 RID: 10169
			[Token(Token = "0x40027B9")]
			CraftNewItem,
			// Token: 0x040027BA RID: 10170
			[Token(Token = "0x40027BA")]
			ApplyWeaponMod,
			// Token: 0x040027BB RID: 10171
			[Token(Token = "0x40027BB")]
			DismantleWeaponMods
		}

		// Token: 0x020006B1 RID: 1713
		[Token(Token = "0x20006B1")]
		[Serializable]
		public class ResultingItem
		{
			// Token: 0x06002D51 RID: 11601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002D51")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ResultingItem()
			{
			}

			// Token: 0x040027BC RID: 10172
			[Token(Token = "0x40027BC")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker(Types.Craftable, true)]
			public int Id;
		}
	}
}
