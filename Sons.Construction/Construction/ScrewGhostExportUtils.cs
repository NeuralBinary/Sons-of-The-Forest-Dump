using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	public static class ScrewGhostExportUtils
	{
		// Token: 0x060005B9 RID: 1465 RVA: 0x00004694 File Offset: 0x00002894
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2E20530", Offset = "0x2E1EB30", VA = "0x182E20530")]
		public static bool TryGetPath(string fileName, out string fullPath)
		{
			return default(bool);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x2E206F0", Offset = "0x2E1ECF0", VA = "0x182E206F0")]
		public static void PrepareScrewPrefab(GameObject freeFormPrefabGo, StructureRecipe recipe, out StructureCraftingNode screwNode)
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2E20F60", Offset = "0x2E1F560", VA = "0x182E20F60")]
		private static void ProcessStructuresStages(GameObject freeFormGhostGo, bool creatingPrefab, out List<List<Structure>> structuresStages, out Bounds bounds)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x2E220D0", Offset = "0x2E206D0", VA = "0x182E220D0")]
		private static void InitFakePilarHelpers(List<FakePilarStructure> fakePilars, bool creatingPrefab)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2E22390", Offset = "0x2E20990", VA = "0x182E22390")]
		private static void InitNavmeshCut(List<List<Structure>> structuresStages)
		{
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2E22780", Offset = "0x2E20D80", VA = "0x182E22780")]
		private static GameObject GenerateScrewNodeGo(bool asPrefab)
		{
			return null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x2E22800", Offset = "0x2E20E00", VA = "0x182E22800")]
		public static void InitFreeFormGhostPrefab(GameObject freeFormGhostPrefab)
		{
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2E22890", Offset = "0x2E20E90", VA = "0x182E22890")]
		public static void InitGroundOffsetProvider(GameObject structureRoot, StructureCraftingNode screwNode)
		{
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private static void SetDirty(UnityEngine.Object obj)
		{
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2E22D20", Offset = "0x2E21320", VA = "0x182E22D20")]
		private static void SetNodeIngredients(StructureCraftingNode node, List<Dictionary<ItemData, List<StructureCraftingNodeIngredient>>> ingredientsLists)
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x2E23330", Offset = "0x2E21930", VA = "0x182E23330")]
		private static void SetRecipeIngredients(StructureRecipe recipe, List<Dictionary<ItemData, List<StructureCraftingNodeIngredient>>> ingredientsStages)
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x2E23E20", Offset = "0x2E22420", VA = "0x182E23E20")]
		private static void CleanUpUndesiredMonoBehaviours(Transform elementTr)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2E23F40", Offset = "0x2E22540", VA = "0x182E23F40")]
		private static void CleanUpTriggers(Transform elementTr)
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2E24070", Offset = "0x2E22670", VA = "0x182E24070")]
		private static void PrepareRenderersForScrewMaterialSwap(Transform elementTr, bool asPrefab)
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x2E24270", Offset = "0x2E22870", VA = "0x182E24270")]
		private static void SortStructuresBySupportStages(List<Structure> allStructures, List<List<Structure>> structuresStages)
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x2E24850", Offset = "0x2E22E50", VA = "0x182E24850")]
		private static void GenerateIngredientsPerItemPerStages(List<List<Structure>> structuresStages, out List<Dictionary<ItemData, List<StructureCraftingNodeIngredient>>> ingredientsPerItemPerStages)
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2E250B0", Offset = "0x2E236B0", VA = "0x182E250B0")]
		private static void GenerateScrewCraftingNodeIngredientComponent(Transform elementTr, ItemData item, Dictionary<ItemData, List<StructureCraftingNodeIngredient>> ingredientsPerItem)
		{
		}

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x0")]
		private static GameObject FreeFormGhostPrefab;
	}
}
