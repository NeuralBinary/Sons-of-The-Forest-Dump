using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using TheForest.Utils;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x02000505 RID: 1285
	[Token(Token = "0x2000505")]
	public class TreeManager : SingletonBehaviour<TreeManager>
	{
		// Token: 0x060020C7 RID: 8391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C7")]
		[Address(RVA = "0x2D35AF0", Offset = "0x2D34AF0", VA = "0x182D35AF0")]
		private void Update()
		{
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x000097B0 File Offset: 0x000079B0
		[Token(Token = "0x60020C8")]
		[Address(RVA = "0x2D33FE0", Offset = "0x2D32FE0", VA = "0x182D33FE0")]
		private bool CheckInitialized()
		{
			return default(bool);
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x2D34860", Offset = "0x2D33860", VA = "0x182D34860")]
		private void Initialize()
		{
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CA")]
		[Address(RVA = "0x2D35110", Offset = "0x2D34110", VA = "0x182D35110")]
		public void OnTreeRemoved(WorldObjectLocator treeLocator)
		{
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CB")]
		[Address(RVA = "0x2D35030", Offset = "0x2D34030", VA = "0x182D35030")]
		public void OnTreeRegrow(WorldObjectLocator treeLocator)
		{
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CC")]
		[Address(RVA = "0x2D34010", Offset = "0x2D33010", VA = "0x182D34010")]
		private void CreateTreePositionGridIfNeeded()
		{
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x2D35490", Offset = "0x2D34490", VA = "0x182D35490")]
		public static void SetWorldObjectStateInRadius(Vector3 position, float radius, WorldObjectState newState)
		{
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x2D351F0", Offset = "0x2D341F0", VA = "0x182D351F0")]
		private void SetTreeStateInRadiusInternal(Vector3 position, float radius, WorldObjectState newState)
		{
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x2D340D0", Offset = "0x2D330D0", VA = "0x182D340D0")]
		public WorldObjectLocator GetClosestTreeInSphere(Vector3 position, Vector3 spherePos, float sphereRadius)
		{
			return null;
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x2D34640", Offset = "0x2D33640", VA = "0x182D34640")]
		public void GetTreesInSphere(List<WorldObjectLocator> trees, Vector3 spherePos, float sphereRadius)
		{
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x2D34330", Offset = "0x2D33330", VA = "0x182D34330")]
		public void GetStumpsInSphere(List<WorldObjectLocator> trees, Vector3 spherePos, float sphereRadius)
		{
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x000097C8 File Offset: 0x000079C8
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x2D34550", Offset = "0x2D33550", VA = "0x182D34550")]
		public int GetTreeCountInSphere(Vector3 position, float radius)
		{
			return default(int);
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x2D35A40", Offset = "0x2D34A40", VA = "0x182D35A40")]
		public static void SpawnLogs(Vector3 position, Vector3 fallDir, int logCount)
		{
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x2D35530", Offset = "0x2D34530", VA = "0x182D35530")]
		public void SpawnLogsInternal(Vector3 position, Vector3 fallDir, int logCount)
		{
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x2D34FB0", Offset = "0x2D33FB0", VA = "0x182D34FB0")]
		public static void OnDrawDebug(float radius, string filter = "")
		{
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x2D34AD0", Offset = "0x2D33AD0", VA = "0x182D34AD0")]
		public void OnDrawDebugInternal(float radius, string filter)
		{
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x2D35B90", Offset = "0x2D34B90", VA = "0x182D35B90")]
		public TreeManager()
		{
		}

		// Token: 0x04001E79 RID: 7801
		[Token(Token = "0x4001E79")]
		[FieldOffset(Offset = "0x28")]
		private bool _initializedTrees;

		// Token: 0x04001E7A RID: 7802
		[Token(Token = "0x4001E7A")]
		[FieldOffset(Offset = "0x2C")]
		private int _treeCount;

		// Token: 0x04001E7B RID: 7803
		[Token(Token = "0x4001E7B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _logPrefab;

		// Token: 0x04001E7C RID: 7804
		[Token(Token = "0x4001E7C")]
		[FieldOffset(Offset = "0x38")]
		private VailLevelGrid _treePositionGrid;

		// Token: 0x04001E7D RID: 7805
		[Token(Token = "0x4001E7D")]
		[FieldOffset(Offset = "0x0")]
		private static List<WorldObjectLocator> _tempTreeList;

		// Token: 0x04001E7E RID: 7806
		[Token(Token = "0x4001E7E")]
		[FieldOffset(Offset = "0x40")]
		private TreeLodGrid _treeLodGridCache;
	}
}
