using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007DF RID: 2015
	[Token(Token = "0x20007DF")]
	[CreateAssetMenu(fileName = "StructureRecipe", menuName = "Sons/Crafting/StructureRecipe")]
	public class StructureRecipe : ScriptableObject
	{
		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600354B RID: 13643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CF")]
		public GameObject CompletedStructurePrefab
		{
			[Token(Token = "0x600354B")]
			[Address(RVA = "0x7B2340", Offset = "0x7B1340", VA = "0x1807B2340")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D0")]
		public GameObject StructureNodePrefab
		{
			[Token(Token = "0x600354C")]
			[Address(RVA = "0x5B3100", Offset = "0x5B2100", VA = "0x1805B3100")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x0600354D RID: 13645 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		[Token(Token = "0x170006D1")]
		public StructureRecipe.AnchorType Anchor
		{
			[Token(Token = "0x600354D")]
			[Address(RVA = "0x6B72D0", Offset = "0x6B62D0", VA = "0x1806B72D0")]
			get
			{
				return StructureRecipe.AnchorType.Bottom;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x0600354E RID: 13646 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		[Token(Token = "0x170006D2")]
		public StructureRecipe.PlaceModeType PlaceMode
		{
			[Token(Token = "0x600354E")]
			[Address(RVA = "0x6B72E0", Offset = "0x6B62E0", VA = "0x1806B72E0")]
			get
			{
				return StructureRecipe.PlaceModeType.Single;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600354F RID: 13647 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		[Token(Token = "0x170006D3")]
		public StructureRecipe.CategoryType Category
		{
			[Token(Token = "0x600354F")]
			[Address(RVA = "0x5F1A10", Offset = "0x5F0A10", VA = "0x1805F1A10")]
			get
			{
				return StructureRecipe.CategoryType.Traps;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06003550 RID: 13648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D4")]
		public string CraftCompleteAudioEvent
		{
			[Token(Token = "0x6003550")]
			[Address(RVA = "0x582960", Offset = "0x581960", VA = "0x180582960")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06003551 RID: 13649 RVA: 0x0000F408 File Offset: 0x0000D608
		[Token(Token = "0x170006D5")]
		public int Id
		{
			[Token(Token = "0x6003551")]
			[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D6")]
		public string DisplayName
		{
			[Token(Token = "0x6003552")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06003553 RID: 13651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D7")]
		public string LocalizationId
		{
			[Token(Token = "0x6003553")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06003554 RID: 13652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D8")]
		public string Name
		{
			[Token(Token = "0x6003554")]
			[Address(RVA = "0x28E6AF0", Offset = "0x28E5AF0", VA = "0x1828E6AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06003555 RID: 13653 RVA: 0x0000F420 File Offset: 0x0000D620
		[Token(Token = "0x170006D9")]
		public bool AlwaysOwned
		{
			[Token(Token = "0x6003555")]
			[Address(RVA = "0x576470", Offset = "0x575470", VA = "0x180576470")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x0000F438 File Offset: 0x0000D638
		[Token(Token = "0x170006DA")]
		public bool UseFreeFormStructure
		{
			[Token(Token = "0x6003556")]
			[Address(RVA = "0x1E52250", Offset = "0x1E51250", VA = "0x181E52250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06003557 RID: 13655 RVA: 0x0000F450 File Offset: 0x0000D650
		[Token(Token = "0x170006DB")]
		public bool IsTreeStructure
		{
			[Token(Token = "0x6003557")]
			[Address(RVA = "0x23E0830", Offset = "0x23DF830", VA = "0x1823E0830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x0000F468 File Offset: 0x0000D668
		[Token(Token = "0x170006DC")]
		public float MinHeightAboveTree
		{
			[Token(Token = "0x6003558")]
			[Address(RVA = "0x204B160", Offset = "0x204A160", VA = "0x18204B160")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06003559 RID: 13657 RVA: 0x0000F480 File Offset: 0x0000D680
		[Token(Token = "0x170006DD")]
		public float MaxHeightAboveTree
		{
			[Token(Token = "0x6003559")]
			[Address(RVA = "0x20452E0", Offset = "0x20442E0", VA = "0x1820452E0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x0000F498 File Offset: 0x0000D698
		[Token(Token = "0x170006DE")]
		public bool AlignToSurface
		{
			[Token(Token = "0x600355A")]
			[Address(RVA = "0x5829E0", Offset = "0x5819E0", VA = "0x1805829E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		[Token(Token = "0x170006DF")]
		public bool CanBeRotated
		{
			[Token(Token = "0x600355B")]
			[Address(RVA = "0x1E489E0", Offset = "0x1E479E0", VA = "0x181E489E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		[Token(Token = "0x170006E0")]
		public bool IsForcedUp
		{
			[Token(Token = "0x600355C")]
			[Address(RVA = "0x2871DC0", Offset = "0x2870DC0", VA = "0x182871DC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x0600355D RID: 13661 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		[Token(Token = "0x170006E1")]
		public float ForceUpAngleThreshold
		{
			[Token(Token = "0x600355D")]
			[Address(RVA = "0x203EB70", Offset = "0x203DB70", VA = "0x18203EB70")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		[Token(Token = "0x170006E2")]
		public float MaxDistanceMultiplier
		{
			[Token(Token = "0x600355E")]
			[Address(RVA = "0x20480A0", Offset = "0x20470A0", VA = "0x1820480A0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600355F RID: 13663 RVA: 0x0000F510 File Offset: 0x0000D710
		[Token(Token = "0x170006E3")]
		public int RecipePageId
		{
			[Token(Token = "0x600355F")]
			[Address(RVA = "0x5763E0", Offset = "0x5753E0", VA = "0x1805763E0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06003560 RID: 13664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E4")]
		public Texture RecipeImage
		{
			[Token(Token = "0x6003560")]
			[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06003561 RID: 13665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E5")]
		public List<StructureCraftingRecipeIngredient> Ingredients
		{
			[Token(Token = "0x6003561")]
			[Address(RVA = "0x5A2410", Offset = "0x5A1410", VA = "0x1805A2410")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x0000F528 File Offset: 0x0000D728
		[Token(Token = "0x170006E6")]
		public int BoltPrefabId
		{
			[Token(Token = "0x6003562")]
			[Address(RVA = "0x986680", Offset = "0x985680", VA = "0x180986680")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06003563 RID: 13667 RVA: 0x0000F540 File Offset: 0x0000D740
		[Token(Token = "0x170006E7")]
		public float MinPlaceDistance
		{
			[Token(Token = "0x6003563")]
			[Address(RVA = "0x5808F0", Offset = "0x57F8F0", VA = "0x1805808F0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003564")]
		[Address(RVA = "0x2EA5DD0", Offset = "0x2EA4DD0", VA = "0x182EA5DD0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003565")]
		[Address(RVA = "0x541240", Offset = "0x540240", VA = "0x180541240")]
		public void SetName(string displayName)
		{
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003566")]
		[Address(RVA = "0x2EA5F70", Offset = "0x2EA4F70", VA = "0x182EA5F70")]
		public GameObject SetCompletedStructurePrefab(GameObject value)
		{
			return null;
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003567")]
		[Address(RVA = "0x2EA5FB0", Offset = "0x2EA4FB0", VA = "0x182EA5FB0")]
		public GameObject SetStructureNodePrefab(GameObject value)
		{
			return null;
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003568")]
		[Address(RVA = "0x1E52300", Offset = "0x1E51300", VA = "0x181E52300")]
		public void SetUseFreeForm(bool useFreeForm)
		{
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003569")]
		[Address(RVA = "0x2EA5FA0", Offset = "0x2EA4FA0", VA = "0x182EA5FA0")]
		public void SetRecipePageId(int value)
		{
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x0000F558 File Offset: 0x0000D758
		[Token(Token = "0x600356A")]
		[Address(RVA = "0x2EA5D00", Offset = "0x2EA4D00", VA = "0x182EA5D00")]
		public bool HasIngredient(int itemId)
		{
			return default(bool);
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x0000F570 File Offset: 0x0000D770
		[Token(Token = "0x600356B")]
		[Address(RVA = "0x2EA5E80", Offset = "0x2EA4E80", VA = "0x182EA5E80")]
		public int RequiredCount(int itemId)
		{
			return default(int);
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356C")]
		[Address(RVA = "0x2EA5FD0", Offset = "0x2EA4FD0", VA = "0x182EA5FD0")]
		public StructureRecipe()
		{
		}

		// Token: 0x04002DC5 RID: 11717
		[Token(Token = "0x4002DC5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _id;

		// Token: 0x04002DC6 RID: 11718
		[Token(Token = "0x4002DC6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _displayName;

		// Token: 0x04002DC7 RID: 11719
		[Token(Token = "0x4002DC7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _localizationId;

		// Token: 0x04002DC8 RID: 11720
		[Token(Token = "0x4002DC8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Texture _recipeImage;

		// Token: 0x04002DC9 RID: 11721
		[Token(Token = "0x4002DC9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _alwaysOwned;

		// Token: 0x04002DCA RID: 11722
		[Token(Token = "0x4002DCA")]
		[FieldOffset(Offset = "0x3C")]
		[ItemIdPicker(true)]
		[SerializeField]
		private int _recipePageId;

		// Token: 0x04002DCB RID: 11723
		[Token(Token = "0x4002DCB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StructureRecipe.CategoryType _category;

		// Token: 0x04002DCC RID: 11724
		[Token(Token = "0x4002DCC")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private StructureRecipe.AnchorType _anchor;

		// Token: 0x04002DCD RID: 11725
		[Token(Token = "0x4002DCD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StructureRecipe.PlaceModeType _placeMode;

		// Token: 0x04002DCE RID: 11726
		[Token(Token = "0x4002DCE")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _minPlaceDistance;

		// Token: 0x04002DCF RID: 11727
		[Token(Token = "0x4002DCF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _alignToSurface;

		// Token: 0x04002DD0 RID: 11728
		[Token(Token = "0x4002DD0")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _canBeRotated;

		// Token: 0x04002DD1 RID: 11729
		[Token(Token = "0x4002DD1")]
		[FieldOffset(Offset = "0x52")]
		[SerializeField]
		private bool _forceUp;

		// Token: 0x04002DD2 RID: 11730
		[Token(Token = "0x4002DD2")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _forceUpAngleThreshold;

		// Token: 0x04002DD3 RID: 11731
		[Token(Token = "0x4002DD3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _maxDistanceMultiplier;

		// Token: 0x04002DD4 RID: 11732
		[Token(Token = "0x4002DD4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<StructureCraftingRecipeIngredient> _ingredients;

		// Token: 0x04002DD5 RID: 11733
		[Token(Token = "0x4002DD5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _useFreeFormStructures;

		// Token: 0x04002DD6 RID: 11734
		[Token(Token = "0x4002DD6")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool _isTreeStructure;

		// Token: 0x04002DD7 RID: 11735
		[Token(Token = "0x4002DD7")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _minHeightAboveTree;

		// Token: 0x04002DD8 RID: 11736
		[Token(Token = "0x4002DD8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _maxHeightAboveTree;

		// Token: 0x04002DD9 RID: 11737
		[Token(Token = "0x4002DD9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _structureNodePrefab;

		// Token: 0x04002DDA RID: 11738
		[Token(Token = "0x4002DDA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int _boltPrefabId;

		// Token: 0x04002DDB RID: 11739
		[Token(Token = "0x4002DDB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _builtPrefab;

		// Token: 0x04002DDC RID: 11740
		[Token(Token = "0x4002DDC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[EventRef]
		private string _craftCompleteAudioEvent;

		// Token: 0x020007E0 RID: 2016
		[Token(Token = "0x20007E0")]
		public enum CategoryType
		{
			// Token: 0x04002DDE RID: 11742
			[Token(Token = "0x4002DDE")]
			Traps,
			// Token: 0x04002DDF RID: 11743
			[Token(Token = "0x4002DDF")]
			Utility,
			// Token: 0x04002DE0 RID: 11744
			[Token(Token = "0x4002DE0")]
			Furniture,
			// Token: 0x04002DE1 RID: 11745
			[Token(Token = "0x4002DE1")]
			Decoration,
			// Token: 0x04002DE2 RID: 11746
			[Token(Token = "0x4002DE2")]
			Shelters
		}

		// Token: 0x020007E1 RID: 2017
		[Token(Token = "0x20007E1")]
		public enum AnchorType
		{
			// Token: 0x04002DE4 RID: 11748
			[Token(Token = "0x4002DE4")]
			Bottom,
			// Token: 0x04002DE5 RID: 11749
			[Token(Token = "0x4002DE5")]
			Top,
			// Token: 0x04002DE6 RID: 11750
			[Token(Token = "0x4002DE6")]
			Back
		}

		// Token: 0x020007E2 RID: 2018
		[Token(Token = "0x20007E2")]
		public enum PlaceModeType
		{
			// Token: 0x04002DE8 RID: 11752
			[Token(Token = "0x4002DE8")]
			Single,
			// Token: 0x04002DE9 RID: 11753
			[Token(Token = "0x4002DE9")]
			Multiple,
			// Token: 0x04002DEA RID: 11754
			[Token(Token = "0x4002DEA")]
			Tree
		}
	}
}
