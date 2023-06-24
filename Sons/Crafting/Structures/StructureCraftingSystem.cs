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
	// Token: 0x020006D6 RID: 1750
	[Token(Token = "0x20006D6")]
	[AddComponentMenu("Sons/Crafting/Structures/StructureCraftingSystem")]
	public class StructureCraftingSystem : SingletonBehaviour<StructureCraftingSystem>, ISaveGameSerializer<StructureCraftingSystem.ScrewNodeStructuresData>
	{
		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002E32 RID: 11826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000622")]
		private string SerializedName
		{
			[Token(Token = "0x6002E32")]
			[Address(RVA = "0x3449340", Offset = "0x3447940", VA = "0x183449340", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		[Token(Token = "0x17000623")]
		private bool UniqueFile
		{
			[Token(Token = "0x6002E33")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002E34 RID: 11828 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		[Token(Token = "0x17000624")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6002E34")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x0000DA10 File Offset: 0x0000BC10
		[Token(Token = "0x17000625")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6002E35")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E36")]
		[Address(RVA = "0x3449370", Offset = "0x3447970", VA = "0x183449370", Slot = "11")]
		private StructureCraftingSystem.ScrewNodeStructuresData OnSerialize()
		{
			return null;
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E37")]
		[Address(RVA = "0x34497F0", Offset = "0x3447DF0", VA = "0x1834497F0", Slot = "12")]
		private void OnDeserialize(StructureCraftingSystem.ScrewNodeStructuresData data)
		{
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E38")]
		[Address(RVA = "0x3449BE0", Offset = "0x34481E0", VA = "0x183449BE0")]
		private void ClearAll()
		{
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000626")]
		public StructureCraftingNode ActiveStructureNode
		{
			[Token(Token = "0x6002E39")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E3A")]
			[Address(RVA = "0x675FB0", Offset = "0x6745B0", VA = "0x180675FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x0000DA28 File Offset: 0x0000BC28
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000627")]
		public bool InBuildMode
		{
			[Token(Token = "0x6002E3B")]
			[Address(RVA = "0x671150", Offset = "0x66F750", VA = "0x180671150")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E3C")]
			[Address(RVA = "0x671160", Offset = "0x66F760", VA = "0x180671160")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x0000DA40 File Offset: 0x0000BC40
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000628")]
		public bool InstantBuild
		{
			[Token(Token = "0x6002E3D")]
			[Address(RVA = "0x24F4A60", Offset = "0x24F3060", VA = "0x1824F4A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E3E")]
			[Address(RVA = "0x24F4A70", Offset = "0x24F3070", VA = "0x1824F4A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3F")]
		[Address(RVA = "0x31A3890", Offset = "0x31A1E90", VA = "0x1831A3890")]
		public void RefreshRequiredItemsUi()
		{
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E40")]
		[Address(RVA = "0x3449E60", Offset = "0x3448460", VA = "0x183449E60")]
		private void Update()
		{
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E41")]
		[Address(RVA = "0x3449E90", Offset = "0x3448490", VA = "0x183449E90")]
		private void Start()
		{
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E42")]
		[Address(RVA = "0x344A410", Offset = "0x3448A10", VA = "0x18344A410", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E43")]
		[Address(RVA = "0x31A3890", Offset = "0x31A1E90", VA = "0x1831A3890")]
		private void OnLocalizationChanged(Locale obj)
		{
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E44")]
		[Address(RVA = "0x31A3890", Offset = "0x31A1E90", VA = "0x1831A3890")]
		private void InventoryWasModified(ItemInstance arg0, int arg1)
		{
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E45")]
		[Address(RVA = "0x344AA10", Offset = "0x3449010", VA = "0x18344AA10")]
		private void UpdateRequiredCountUIForAllItems()
		{
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E46")]
		[Address(RVA = "0x344B0C0", Offset = "0x34496C0", VA = "0x18344B0C0")]
		private void ActivateAllGhosts(bool enable)
		{
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E47")]
		[Address(RVA = "0x344B230", Offset = "0x3449830", VA = "0x18344B230")]
		public void SetActiveStructureNode(StructureCraftingNode structureCraftingNode)
		{
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E48")]
		[Address(RVA = "0x344B680", Offset = "0x3449C80", VA = "0x18344B680")]
		private void OnStructureCompleteEvent()
		{
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E49")]
		[Address(RVA = "0x344B8B0", Offset = "0x3449EB0", VA = "0x18344B8B0")]
		public void NetworkPlaceStructureNode(PrefabId prefabId, Vector3 position, Quaternion rotation, WorldLocatorId treeId, bool instantBuild)
		{
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4A")]
		[Address(RVA = "0x344BA90", Offset = "0x344A090", VA = "0x18344BA90")]
		public void PlaceStructureNode(StructureRecipe structureRecipe, Vector3 position, Quaternion rotation, bool setActive = true, [Optional] WorldLocatorId supportingTreeId, bool instantBuild = false)
		{
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4B")]
		[Address(RVA = "0x344BDA0", Offset = "0x344A3A0", VA = "0x18344BDA0")]
		public static void RegisterStructure(StructureCraftingNode structureCraftingNode)
		{
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4C")]
		[Address(RVA = "0x344BE50", Offset = "0x344A450", VA = "0x18344BE50")]
		public static void UnregisterStructure(StructureCraftingNode structureCraftingNode)
		{
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x0000DA58 File Offset: 0x0000BC58
		[Token(Token = "0x6002E4D")]
		[Address(RVA = "0x344BF00", Offset = "0x344A500", VA = "0x18344BF00")]
		private bool InstantBookBuild(string param)
		{
			return default(bool);
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4E")]
		[Address(RVA = "0x24F4A70", Offset = "0x24F3070", VA = "0x1824F4A70")]
		private void InstantBookBuildInternal(bool enable)
		{
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4F")]
		[Address(RVA = "0x344BFC0", Offset = "0x344A5C0", VA = "0x18344BFC0")]
		public StructureCraftingSystem()
		{
		}

		// Token: 0x0400284E RID: 10318
		[Token(Token = "0x400284E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StructureRecipeDatabase _recipeDatabase;

		// Token: 0x0400284F RID: 10319
		[Token(Token = "0x400284F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<StructureCraftingNode> _activeStructureNodes;

		// Token: 0x04002850 RID: 10320
		[Token(Token = "0x4002850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Dictionary<int, int> _requiredItemCounts;

		// Token: 0x04002851 RID: 10321
		[Token(Token = "0x4002851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _ghostsAreActive;

		// Token: 0x04002852 RID: 10322
		[Token(Token = "0x4002852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PlayerInventory _inventory;

		// Token: 0x04002853 RID: 10323
		[Token(Token = "0x4002853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _refreshRequiredItemsUi;

		// Token: 0x04002854 RID: 10324
		[Token(Token = "0x4002854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> _requiredItemIds;

		// Token: 0x04002855 RID: 10325
		[Token(Token = "0x4002855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Action OnStructureComplete;

		// Token: 0x04002856 RID: 10326
		[Token(Token = "0x4002856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _isClearing;

		// Token: 0x020006D7 RID: 1751
		[Token(Token = "0x20006D7")]
		[Serializable]
		public class ScrewNodeStructuresData
		{
			// Token: 0x06002E50 RID: 11856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002E50")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ScrewNodeStructuresData()
			{
			}

			// Token: 0x0400285A RID: 10330
			[Token(Token = "0x400285A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public List<StructureCraftingSystem.ScrewNodeStructureData> _structures;
		}

		// Token: 0x020006D8 RID: 1752
		[Token(Token = "0x20006D8")]
		[Serializable]
		public class ScrewNodeStructureData
		{
			// Token: 0x06002E51 RID: 11857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002E51")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ScrewNodeStructureData()
			{
			}

			// Token: 0x0400285B RID: 10331
			[Token(Token = "0x400285B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public int Id;

			// Token: 0x0400285C RID: 10332
			[Token(Token = "0x400285C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[JsonProperty]
			public Vector3S Pos;

			// Token: 0x0400285D RID: 10333
			[Token(Token = "0x400285D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public Vector4S Rot;

			// Token: 0x0400285E RID: 10334
			[Token(Token = "0x400285E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[JsonProperty]
			public int Added;
		}
	}
}
