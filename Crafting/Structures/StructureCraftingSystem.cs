using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Bolt;
using Endnight.Types;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Inventory;
using Sons.Save;
using Sons.TerrainDetail;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Localization;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007CA RID: 1994
	[Token(Token = "0x20007CA")]
	[AddComponentMenu("Sons/Crafting/Structures/StructureCraftingSystem")]
	public class StructureCraftingSystem : SingletonBehaviour<StructureCraftingSystem>, ISaveGameSerializer<StructureCraftingSystem.ScrewNodeStructuresData>
	{
		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B3")]
		private string SerializedName
		{
			[Token(Token = "0x600349E")]
			[Address(RVA = "0x2EA4390", Offset = "0x2EA3390", VA = "0x182EA4390", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600349F RID: 13471 RVA: 0x0000F060 File Offset: 0x0000D260
		[Token(Token = "0x170006B4")]
		private bool UniqueFile
		{
			[Token(Token = "0x600349F")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060034A0 RID: 13472 RVA: 0x0000F078 File Offset: 0x0000D278
		[Token(Token = "0x170006B5")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x60034A0")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060034A1 RID: 13473 RVA: 0x0000F090 File Offset: 0x0000D290
		[Token(Token = "0x170006B6")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x60034A1")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A2")]
		[Address(RVA = "0x2EA4050", Offset = "0x2EA3050", VA = "0x182EA4050", Slot = "11")]
		private StructureCraftingSystem.ScrewNodeStructuresData OnSerialize()
		{
			return null;
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A3")]
		[Address(RVA = "0x2EA3C80", Offset = "0x2EA2C80", VA = "0x182EA3C80", Slot = "12")]
		private void OnDeserialize(StructureCraftingSystem.ScrewNodeStructuresData data)
		{
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A4")]
		[Address(RVA = "0x2EA2D80", Offset = "0x2EA1D80", VA = "0x182EA2D80")]
		private void ClearAll()
		{
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060034A5 RID: 13477 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060034A6 RID: 13478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B7")]
		public StructureCraftingNode ActiveStructureNode
		{
			[Token(Token = "0x60034A5")]
			[Address(RVA = "0x5E4C40", Offset = "0x5E3C40", VA = "0x1805E4C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60034A6")]
			[Address(RVA = "0x5E4C50", Offset = "0x5E3C50", VA = "0x1805E4C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060034A7 RID: 13479 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		// (set) Token: 0x060034A8 RID: 13480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B8")]
		public bool InBuildMode
		{
			[Token(Token = "0x60034A7")]
			[Address(RVA = "0x5F0C80", Offset = "0x5EFC80", VA = "0x1805F0C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60034A8")]
			[Address(RVA = "0x5F0C90", Offset = "0x5EFC90", VA = "0x1805F0C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060034A9 RID: 13481 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		// (set) Token: 0x060034AA RID: 13482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B9")]
		public bool InstantBuild
		{
			[Token(Token = "0x60034A9")]
			[Address(RVA = "0x2115820", Offset = "0x2114820", VA = "0x182115820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60034AA")]
			[Address(RVA = "0x2115A70", Offset = "0x2114A70", VA = "0x182115A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AB")]
		[Address(RVA = "0x2B5B060", Offset = "0x2B5A060", VA = "0x182B5B060")]
		public void RefreshRequiredItemsUi()
		{
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AC")]
		[Address(RVA = "0x2EA4DD0", Offset = "0x2EA3DD0", VA = "0x182EA4DD0")]
		private void Update()
		{
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AD")]
		[Address(RVA = "0x2EA43C0", Offset = "0x2EA33C0", VA = "0x182EA43C0")]
		private void Start()
		{
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AE")]
		[Address(RVA = "0x2EA3200", Offset = "0x2EA2200", VA = "0x182EA3200", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AF")]
		[Address(RVA = "0x2B5B060", Offset = "0x2B5A060", VA = "0x182B5B060")]
		private void OnLocalizationChanged(Locale obj)
		{
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B0")]
		[Address(RVA = "0x2B5B060", Offset = "0x2B5A060", VA = "0x182B5B060")]
		private void InventoryWasModified(ItemInstance arg0, int arg1)
		{
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B1")]
		[Address(RVA = "0x2EA4860", Offset = "0x2EA3860", VA = "0x182EA4860")]
		private void UpdateRequiredCountUIForAllItems()
		{
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B2")]
		[Address(RVA = "0x2EA2C40", Offset = "0x2EA1C40", VA = "0x182EA2C40")]
		private void ActivateAllGhosts(bool enable)
		{
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B3")]
		[Address(RVA = "0x2EA3A20", Offset = "0x2EA2A20", VA = "0x182EA3A20")]
		public void SetActiveStructureNode(StructureCraftingNode structureCraftingNode)
		{
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B4")]
		[Address(RVA = "0x2EA3640", Offset = "0x2EA2640", VA = "0x182EA3640")]
		private void OnStructureCompleteEvent()
		{
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B5")]
		[Address(RVA = "0x2EA3080", Offset = "0x2EA2080", VA = "0x182EA3080")]
		public void NetworkPlaceStructureNode(PrefabId prefabId, Vector3 position, Quaternion rotation, WorldLocatorId treeId)
		{
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B6")]
		[Address(RVA = "0x2EA3760", Offset = "0x2EA2760", VA = "0x182EA3760")]
		public void PlaceStructureNode(StructureRecipe structureRecipe, Vector3 position, Quaternion rotation, bool setActive = true, [Optional] WorldLocatorId supportingTreeId)
		{
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B7")]
		[Address(RVA = "0x2EA0840", Offset = "0x2E9F840", VA = "0x182EA0840")]
		public static void RegisterStructure(StructureCraftingNode structureCraftingNode)
		{
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B8")]
		[Address(RVA = "0x2EA0780", Offset = "0x2E9F780", VA = "0x182EA0780")]
		public static void UnregisterStructure(StructureCraftingNode structureCraftingNode)
		{
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		[Token(Token = "0x60034B9")]
		[Address(RVA = "0x2EA2FC0", Offset = "0x2EA1FC0", VA = "0x182EA2FC0")]
		private bool InstantBookBuild(string param)
		{
			return default(bool);
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BA")]
		[Address(RVA = "0x2115A70", Offset = "0x2114A70", VA = "0x182115A70")]
		private void InstantBookBuildInternal(bool enable)
		{
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BB")]
		[Address(RVA = "0x2EA4E00", Offset = "0x2EA3E00", VA = "0x182EA4E00")]
		public StructureCraftingSystem()
		{
		}

		// Token: 0x04002D6A RID: 11626
		[Token(Token = "0x4002D6A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StructureRecipeDatabase _recipeDatabase;

		// Token: 0x04002D6B RID: 11627
		[Token(Token = "0x4002D6B")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<StructureCraftingNode> _activeStructureNodes;

		// Token: 0x04002D6C RID: 11628
		[Token(Token = "0x4002D6C")]
		[FieldOffset(Offset = "0x38")]
		private readonly Dictionary<int, int> _requiredItemCounts;

		// Token: 0x04002D6D RID: 11629
		[Token(Token = "0x4002D6D")]
		[FieldOffset(Offset = "0x40")]
		private bool _ghostsAreActive;

		// Token: 0x04002D6E RID: 11630
		[Token(Token = "0x4002D6E")]
		[FieldOffset(Offset = "0x48")]
		private PlayerInventory _inventory;

		// Token: 0x04002D6F RID: 11631
		[Token(Token = "0x4002D6F")]
		[FieldOffset(Offset = "0x50")]
		private bool _refreshRequiredItemsUi;

		// Token: 0x04002D70 RID: 11632
		[Token(Token = "0x4002D70")]
		[FieldOffset(Offset = "0x58")]
		private List<int> _requiredItemIds;

		// Token: 0x04002D71 RID: 11633
		[Token(Token = "0x4002D71")]
		[FieldOffset(Offset = "0x60")]
		public Action OnStructureComplete;

		// Token: 0x04002D72 RID: 11634
		[Token(Token = "0x4002D72")]
		[FieldOffset(Offset = "0x0")]
		private static bool _isClearing;

		// Token: 0x020007CB RID: 1995
		[Token(Token = "0x20007CB")]
		[Serializable]
		public class ScrewNodeStructuresData
		{
			// Token: 0x060034BC RID: 13500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60034BC")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ScrewNodeStructuresData()
			{
			}

			// Token: 0x04002D76 RID: 11638
			[Token(Token = "0x4002D76")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public List<StructureCraftingSystem.ScrewNodeStructureData> _structures;
		}

		// Token: 0x020007CC RID: 1996
		[Token(Token = "0x20007CC")]
		[Serializable]
		public class ScrewNodeStructureData
		{
			// Token: 0x060034BD RID: 13501 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60034BD")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ScrewNodeStructureData()
			{
			}

			// Token: 0x04002D77 RID: 11639
			[Token(Token = "0x4002D77")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public int Id;

			// Token: 0x04002D78 RID: 11640
			[Token(Token = "0x4002D78")]
			[FieldOffset(Offset = "0x14")]
			[JsonProperty]
			public Vector3S Pos;

			// Token: 0x04002D79 RID: 11641
			[Token(Token = "0x4002D79")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public Vector4S Rot;

			// Token: 0x04002D7A RID: 11642
			[Token(Token = "0x4002D7A")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty]
			public int Added;
		}
	}
}
