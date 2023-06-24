using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using TheForest.Utils;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x0200050A RID: 1290
	[Token(Token = "0x200050A")]
	public class TreeManager : SingletonBehaviour<TreeManager>
	{
		// Token: 0x06002191 RID: 8593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002191")]
		[Address(RVA = "0x332ADF0", Offset = "0x33293F0", VA = "0x18332ADF0")]
		private void Update()
		{
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00009D50 File Offset: 0x00007F50
		[Token(Token = "0x6002192")]
		[Address(RVA = "0x332AE00", Offset = "0x3329400", VA = "0x18332AE00")]
		private bool CheckInitialized()
		{
			return default(bool);
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002193")]
		[Address(RVA = "0x332AE30", Offset = "0x3329430", VA = "0x18332AE30")]
		private void Initialize()
		{
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002194")]
		[Address(RVA = "0x332B220", Offset = "0x3329820", VA = "0x18332B220")]
		public void OnTreeRemoved(WorldObjectLocator treeLocator)
		{
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002195")]
		[Address(RVA = "0x332B410", Offset = "0x3329A10", VA = "0x18332B410")]
		public void OnTreeRegrow(WorldObjectLocator treeLocator)
		{
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002196")]
		[Address(RVA = "0x332B550", Offset = "0x3329B50", VA = "0x18332B550")]
		public static void RegisterTreeStructure(WorldLocatorId locatorId)
		{
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002197")]
		[Address(RVA = "0x332B600", Offset = "0x3329C00", VA = "0x18332B600")]
		public static void UnRegisterTreeStructure(WorldLocatorId locatorId)
		{
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x00009D68 File Offset: 0x00007F68
		[Token(Token = "0x6002198")]
		[Address(RVA = "0x332B710", Offset = "0x3329D10", VA = "0x18332B710")]
		public bool HasStructure(WorldObjectLocator treeWo)
		{
			return default(bool);
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002199")]
		[Address(RVA = "0x332B790", Offset = "0x3329D90", VA = "0x18332B790")]
		private void CreateTreePositionGridIfNeeded()
		{
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600219A")]
		[Address(RVA = "0x332B960", Offset = "0x3329F60", VA = "0x18332B960")]
		public static void SetWorldObjectStateInRadius(Vector3 position, float radius, WorldObjectState newState)
		{
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600219B")]
		[Address(RVA = "0x332BA00", Offset = "0x332A000", VA = "0x18332BA00")]
		private void SetTreeStateInRadiusInternal(Vector3 position, float radius, WorldObjectState newState)
		{
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219C")]
		[Address(RVA = "0x332BCF0", Offset = "0x332A2F0", VA = "0x18332BCF0")]
		public WorldObjectLocator GetClosestTreeInSphere(Vector3 position, Vector3 spherePos, float sphereRadius)
		{
			return null;
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600219D")]
		[Address(RVA = "0x332BF90", Offset = "0x332A590", VA = "0x18332BF90")]
		public void GetTreesInSphere(List<WorldObjectLocator> trees, Vector3 spherePos, float sphereRadius)
		{
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600219E")]
		[Address(RVA = "0x332C1E0", Offset = "0x332A7E0", VA = "0x18332C1E0")]
		public void GetStumpsInSphere(List<WorldObjectLocator> trees, Vector3 spherePos, float sphereRadius)
		{
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00009D80 File Offset: 0x00007F80
		[Token(Token = "0x600219F")]
		[Address(RVA = "0x332C420", Offset = "0x332AA20", VA = "0x18332C420")]
		public int GetTreeCountInSphere(Vector3 position, float radius)
		{
			return 0;
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A0")]
		[Address(RVA = "0x332C510", Offset = "0x332AB10", VA = "0x18332C510")]
		public static void OnDrawDebug(float radius, string filter = "")
		{
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A1")]
		[Address(RVA = "0x332C590", Offset = "0x332AB90", VA = "0x18332C590")]
		public void OnDrawDebugInternal(float radius, string filter)
		{
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A2")]
		[Address(RVA = "0x332CEA0", Offset = "0x332B4A0", VA = "0x18332CEA0")]
		public TreeManager()
		{
		}

		// Token: 0x04001F16 RID: 7958
		[Token(Token = "0x4001F16")]
		[FieldOffset(Offset = "0x28")]
		private bool _initializedTrees;

		// Token: 0x04001F17 RID: 7959
		[Token(Token = "0x4001F17")]
		[FieldOffset(Offset = "0x2C")]
		private int _treeCount;

		// Token: 0x04001F18 RID: 7960
		[Token(Token = "0x4001F18")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _logPrefab;

		// Token: 0x04001F19 RID: 7961
		[Token(Token = "0x4001F19")]
		[FieldOffset(Offset = "0x38")]
		private VailLevelGrid _treePositionGrid;

		// Token: 0x04001F1A RID: 7962
		[Token(Token = "0x4001F1A")]
		[FieldOffset(Offset = "0x0")]
		private static List<WorldObjectLocator> _tempTreeList;

		// Token: 0x04001F1B RID: 7963
		[Token(Token = "0x4001F1B")]
		[FieldOffset(Offset = "0x40")]
		private TreeLodGrid _treeLodGridCache;

		// Token: 0x04001F1C RID: 7964
		[Token(Token = "0x4001F1C")]
		[FieldOffset(Offset = "0x48")]
		private readonly Dictionary<WorldLocatorId, int> _treeStructures;
	}
}
