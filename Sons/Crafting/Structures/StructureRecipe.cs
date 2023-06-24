using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006EB RID: 1771
	[Token(Token = "0x20006EB")]
	[CreateAssetMenu(fileName = "StructureRecipe", menuName = "Sons/Crafting/StructureRecipe")]
	public class StructureRecipe : ScriptableObject
	{
		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06002EE0 RID: 12000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063E")]
		public GameObject CompletedStructurePrefab
		{
			[Token(Token = "0x6002EE0")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063F")]
		public GameObject StructureNodePrefab
		{
			[Token(Token = "0x6002EE1")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06002EE2 RID: 12002 RVA: 0x0000DD70 File Offset: 0x0000BF70
		[Token(Token = "0x17000640")]
		public StructureRecipe.AnchorType Anchor
		{
			[Token(Token = "0x6002EE2")]
			[Address(RVA = "0x76BE00", Offset = "0x76A400", VA = "0x18076BE00")]
			get
			{
				return StructureRecipe.AnchorType.Bottom;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x0000DD88 File Offset: 0x0000BF88
		[Token(Token = "0x17000641")]
		public StructureRecipe.PlaceModeType PlaceMode
		{
			[Token(Token = "0x6002EE3")]
			[Address(RVA = "0x784B40", Offset = "0x783140", VA = "0x180784B40")]
			get
			{
				return StructureRecipe.PlaceModeType.Single;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06002EE4 RID: 12004 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		[Token(Token = "0x17000642")]
		public StructureRecipe.CategoryType Category
		{
			[Token(Token = "0x6002EE4")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return StructureRecipe.CategoryType.Traps;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		[Token(Token = "0x17000643")]
		public StructureRecipe.RelocateModeType RelocateMode
		{
			[Token(Token = "0x6002EE5")]
			[Address(RVA = "0xAFF330", Offset = "0xAFD930", VA = "0x180AFF330")]
			get
			{
				return StructureRecipe.RelocateModeType.Relocate;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000644")]
		public string CraftCompleteAudioEvent
		{
			[Token(Token = "0x6002EE6")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06002EE7 RID: 12007 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		[Token(Token = "0x17000645")]
		public int Id
		{
			[Token(Token = "0x6002EE7")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06002EE8 RID: 12008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000646")]
		public string DisplayName
		{
			[Token(Token = "0x6002EE8")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000647")]
		public string LocalizationId
		{
			[Token(Token = "0x6002EE9")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06002EEA RID: 12010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000648")]
		public string Name
		{
			[Token(Token = "0x6002EEA")]
			[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06002EEB RID: 12011 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		[Token(Token = "0x17000649")]
		public bool AlwaysOwned
		{
			[Token(Token = "0x6002EEB")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x0000DE00 File Offset: 0x0000C000
		[Token(Token = "0x1700064A")]
		public bool UseFreeFormStructure
		{
			[Token(Token = "0x6002EEC")]
			[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x0000DE18 File Offset: 0x0000C018
		[Token(Token = "0x1700064B")]
		public bool IsTreeStructure
		{
			[Token(Token = "0x6002EED")]
			[Address(RVA = "0x2866320", Offset = "0x2864920", VA = "0x182866320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x0000DE30 File Offset: 0x0000C030
		[Token(Token = "0x1700064C")]
		public float MinHeightAboveTree
		{
			[Token(Token = "0x6002EEE")]
			[Address(RVA = "0x23C25F0", Offset = "0x23C0BF0", VA = "0x1823C25F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x0000DE48 File Offset: 0x0000C048
		[Token(Token = "0x1700064D")]
		public float MaxHeightAboveTree
		{
			[Token(Token = "0x6002EEF")]
			[Address(RVA = "0x23C2610", Offset = "0x23C0C10", VA = "0x1823C2610")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x0000DE60 File Offset: 0x0000C060
		[Token(Token = "0x1700064E")]
		public bool AlignToSurface
		{
			[Token(Token = "0x6002EF0")]
			[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06002EF1 RID: 12017 RVA: 0x0000DE78 File Offset: 0x0000C078
		[Token(Token = "0x1700064F")]
		public bool CanBeRotated
		{
			[Token(Token = "0x6002EF1")]
			[Address(RVA = "0x2197B80", Offset = "0x2196180", VA = "0x182197B80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06002EF2 RID: 12018 RVA: 0x0000DE90 File Offset: 0x0000C090
		[Token(Token = "0x17000650")]
		public bool IsForcedUp
		{
			[Token(Token = "0x6002EF2")]
			[Address(RVA = "0x2DF83C0", Offset = "0x2DF69C0", VA = "0x182DF83C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		[Token(Token = "0x17000651")]
		public float ForceUpAngleThreshold
		{
			[Token(Token = "0x6002EF3")]
			[Address(RVA = "0x23FC6E0", Offset = "0x23FACE0", VA = "0x1823FC6E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		[Token(Token = "0x17000652")]
		public float MaxDistanceMultiplier
		{
			[Token(Token = "0x6002EF4")]
			[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		[Token(Token = "0x17000653")]
		public int RecipePageId
		{
			[Token(Token = "0x6002EF5")]
			[Address(RVA = "0x5FDAB0", Offset = "0x5FC0B0", VA = "0x1805FDAB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000654")]
		public Texture RecipeImage
		{
			[Token(Token = "0x6002EF6")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000655")]
		public List<StructureCraftingRecipeIngredient> Ingredients
		{
			[Token(Token = "0x6002EF7")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06002EF8 RID: 12024 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		[Token(Token = "0x17000656")]
		public int BoltPrefabId
		{
			[Token(Token = "0x6002EF8")]
			[Address(RVA = "0xAFF2A0", Offset = "0xAFD8A0", VA = "0x180AFF2A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x0000DF08 File Offset: 0x0000C108
		[Token(Token = "0x17000657")]
		public float MinPlaceDistance
		{
			[Token(Token = "0x6002EF9")]
			[Address(RVA = "0x5F1D10", Offset = "0x5F0310", VA = "0x1805F1D10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06002EFA RID: 12026 RVA: 0x0000DF20 File Offset: 0x0000C120
		[Token(Token = "0x17000658")]
		public int RelocateAnimHeldItemId
		{
			[Token(Token = "0x6002EFA")]
			[Address(RVA = "0xA03D80", Offset = "0xA02380", VA = "0x180A03D80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x0000DF38 File Offset: 0x0000C138
		[Token(Token = "0x17000659")]
		public Vector3 RelocateBonePos
		{
			[Token(Token = "0x6002EFB")]
			[Address(RVA = "0x6719D0", Offset = "0x66FFD0", VA = "0x1806719D0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x0000DF50 File Offset: 0x0000C150
		[Token(Token = "0x1700065A")]
		public Quaternion RelocateBoneRot
		{
			[Token(Token = "0x6002EFC")]
			[Address(RVA = "0x34577D0", Offset = "0x3455DD0", VA = "0x1834577D0")]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x0000DF68 File Offset: 0x0000C168
		[Token(Token = "0x1700065B")]
		public Vector3 RelocateBoneScale
		{
			[Token(Token = "0x6002EFD")]
			[Address(RVA = "0x1342920", Offset = "0x1340F20", VA = "0x181342920")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x0000DF80 File Offset: 0x0000C180
		[Token(Token = "0x1700065C")]
		public bool BlockDismantleInProximityWithPlayersOrActors
		{
			[Token(Token = "0x6002EFE")]
			[Address(RVA = "0x22711D0", Offset = "0x226F7D0", VA = "0x1822711D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EFF")]
		[Address(RVA = "0x34577E0", Offset = "0x3455DE0", VA = "0x1834577E0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F00")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetName(string displayName)
		{
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F01")]
		[Address(RVA = "0x34578F0", Offset = "0x3455EF0", VA = "0x1834578F0")]
		public GameObject SetCompletedStructurePrefab(GameObject value)
		{
			return null;
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F02")]
		[Address(RVA = "0x3457950", Offset = "0x3455F50", VA = "0x183457950")]
		public GameObject SetStructureNodePrefab(GameObject value)
		{
			return null;
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F03")]
		[Address(RVA = "0x15771E0", Offset = "0x15757E0", VA = "0x1815771E0")]
		public void SetUseFreeForm(bool useFreeForm)
		{
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F04")]
		[Address(RVA = "0x21BFA30", Offset = "0x21BE030", VA = "0x1821BFA30")]
		public void SetRecipePageId(int value)
		{
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x0000DF98 File Offset: 0x0000C198
		[Token(Token = "0x6002F05")]
		[Address(RVA = "0x34579B0", Offset = "0x3455FB0", VA = "0x1834579B0")]
		public bool HasIngredient(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		[Token(Token = "0x6002F06")]
		[Address(RVA = "0x3457A70", Offset = "0x3456070", VA = "0x183457A70")]
		public int RequiredCount(int itemId)
		{
			return 0;
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F07")]
		[Address(RVA = "0x3457B50", Offset = "0x3456150", VA = "0x183457B50")]
		public StructureRecipe()
		{
		}

		// Token: 0x040028A8 RID: 10408
		[Token(Token = "0x40028A8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _id;

		// Token: 0x040028A9 RID: 10409
		[Token(Token = "0x40028A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _displayName;

		// Token: 0x040028AA RID: 10410
		[Token(Token = "0x40028AA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _localizationId;

		// Token: 0x040028AB RID: 10411
		[Token(Token = "0x40028AB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Texture _recipeImage;

		// Token: 0x040028AC RID: 10412
		[Token(Token = "0x40028AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _alwaysOwned;

		// Token: 0x040028AD RID: 10413
		[Token(Token = "0x40028AD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _recipePageId;

		// Token: 0x040028AE RID: 10414
		[Token(Token = "0x40028AE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StructureRecipe.CategoryType _category;

		// Token: 0x040028AF RID: 10415
		[Token(Token = "0x40028AF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private StructureRecipe.AnchorType _anchor;

		// Token: 0x040028B0 RID: 10416
		[Token(Token = "0x40028B0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StructureRecipe.PlaceModeType _placeMode;

		// Token: 0x040028B1 RID: 10417
		[Token(Token = "0x40028B1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _minPlaceDistance;

		// Token: 0x040028B2 RID: 10418
		[Token(Token = "0x40028B2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _alignToSurface;

		// Token: 0x040028B3 RID: 10419
		[Token(Token = "0x40028B3")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _canBeRotated;

		// Token: 0x040028B4 RID: 10420
		[Token(Token = "0x40028B4")]
		[FieldOffset(Offset = "0x52")]
		[SerializeField]
		private bool _forceUp;

		// Token: 0x040028B5 RID: 10421
		[Token(Token = "0x40028B5")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _forceUpAngleThreshold;

		// Token: 0x040028B6 RID: 10422
		[Token(Token = "0x40028B6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _maxDistanceMultiplier;

		// Token: 0x040028B7 RID: 10423
		[Token(Token = "0x40028B7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<StructureCraftingRecipeIngredient> _ingredients;

		// Token: 0x040028B8 RID: 10424
		[Token(Token = "0x40028B8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _useFreeFormStructures;

		// Token: 0x040028B9 RID: 10425
		[Token(Token = "0x40028B9")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool _isTreeStructure;

		// Token: 0x040028BA RID: 10426
		[Token(Token = "0x40028BA")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _minHeightAboveTree;

		// Token: 0x040028BB RID: 10427
		[Token(Token = "0x40028BB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _maxHeightAboveTree;

		// Token: 0x040028BC RID: 10428
		[Token(Token = "0x40028BC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _structureNodePrefab;

		// Token: 0x040028BD RID: 10429
		[Token(Token = "0x40028BD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int _boltPrefabId;

		// Token: 0x040028BE RID: 10430
		[Token(Token = "0x40028BE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _builtPrefab;

		// Token: 0x040028BF RID: 10431
		[Token(Token = "0x40028BF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[EventRef]
		private string _craftCompleteAudioEvent;

		// Token: 0x040028C0 RID: 10432
		[Token(Token = "0x40028C0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private StructureRecipe.RelocateModeType _relocateMode;

		// Token: 0x040028C1 RID: 10433
		[Token(Token = "0x40028C1")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[ItemIdPicker]
		private int _relocateAnimHeldItemId;

		// Token: 0x040028C2 RID: 10434
		[Token(Token = "0x40028C2")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Vector3 _relocateBonePos;

		// Token: 0x040028C3 RID: 10435
		[Token(Token = "0x40028C3")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private Quaternion _relocateBoneRot;

		// Token: 0x040028C4 RID: 10436
		[Token(Token = "0x40028C4")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private Vector3 _relocateBoneScale;

		// Token: 0x040028C5 RID: 10437
		[Token(Token = "0x40028C5")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool _blockDismantleInProximityWithPlayersOrActors;

		// Token: 0x020006EC RID: 1772
		[Token(Token = "0x20006EC")]
		public enum CategoryType
		{
			// Token: 0x040028C7 RID: 10439
			[Token(Token = "0x40028C7")]
			Traps,
			// Token: 0x040028C8 RID: 10440
			[Token(Token = "0x40028C8")]
			Utility,
			// Token: 0x040028C9 RID: 10441
			[Token(Token = "0x40028C9")]
			Furniture,
			// Token: 0x040028CA RID: 10442
			[Token(Token = "0x40028CA")]
			Decoration,
			// Token: 0x040028CB RID: 10443
			[Token(Token = "0x40028CB")]
			Shelters
		}

		// Token: 0x020006ED RID: 1773
		[Token(Token = "0x20006ED")]
		public enum AnchorType
		{
			// Token: 0x040028CD RID: 10445
			[Token(Token = "0x40028CD")]
			Bottom,
			// Token: 0x040028CE RID: 10446
			[Token(Token = "0x40028CE")]
			Top,
			// Token: 0x040028CF RID: 10447
			[Token(Token = "0x40028CF")]
			Back
		}

		// Token: 0x020006EE RID: 1774
		[Token(Token = "0x20006EE")]
		public enum PlaceModeType
		{
			// Token: 0x040028D1 RID: 10449
			[Token(Token = "0x40028D1")]
			Single,
			// Token: 0x040028D2 RID: 10450
			[Token(Token = "0x40028D2")]
			Multiple,
			// Token: 0x040028D3 RID: 10451
			[Token(Token = "0x40028D3")]
			Tree
		}

		// Token: 0x020006EF RID: 1775
		[Token(Token = "0x20006EF")]
		public enum RelocateModeType
		{
			// Token: 0x040028D5 RID: 10453
			[Token(Token = "0x40028D5")]
			Relocate,
			// Token: 0x040028D6 RID: 10454
			[Token(Token = "0x40028D6")]
			Collapse
		}
	}
}
