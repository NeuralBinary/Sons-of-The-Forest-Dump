using System;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest.Utils
{
	// Token: 0x020003DC RID: 988
	[Token(Token = "0x20003DC")]
	public class TreeLodGrid : SingletonBehaviour<TreeLodGrid>
	{
		// Token: 0x06001A70 RID: 6768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x2CF0AA0", Offset = "0x2CEFAA0", VA = "0x182CF0AA0", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x2CF1540", Offset = "0x2CF0540", VA = "0x182CF1540")]
		private void Update()
		{
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x2CF1430", Offset = "0x2CF0430", VA = "0x182CF1430")]
		private void UpdateTreeOcclusionBonusRatio(float ratio)
		{
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x2CF0270", Offset = "0x2CEF270", VA = "0x182CF0270")]
		private void OnDisable()
		{
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x2CF0310", Offset = "0x2CEF310", VA = "0x182CF0310")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x2CF0F70", Offset = "0x2CEFF70", VA = "0x182CF0F70")]
		public void RegisterCutDownTree(Vector3 treePos)
		{
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x2CF10E0", Offset = "0x2CF00E0", VA = "0x182CF10E0")]
		public void RegisterTreeRegrowth(Vector3 treePos)
		{
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A77")]
		[Address(RVA = "0x2CF01C0", Offset = "0x2CEF1C0", VA = "0x182CF01C0")]
		private void InitGrid()
		{
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A78")]
		[Address(RVA = "0x2CF0D10", Offset = "0x2CEFD10", VA = "0x182CF0D10")]
		private void RebuildRayDirections()
		{
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A79")]
		[Address(RVA = "0x2CF13D0", Offset = "0x2CF03D0", VA = "0x182CF13D0")]
		private void SumTreeOcclusion(int treeCount)
		{
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00007E30 File Offset: 0x00006030
		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x2CEFDD0", Offset = "0x2CEEDD0", VA = "0x182CEFDD0")]
		private float CalcCellLodRatio(int x, int y)
		{
			return default(float);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x2CF0AB0", Offset = "0x2CEFAB0", VA = "0x182CF0AB0")]
		private void RayCast2DCells(int x1, int y1, int x2, int y2)
		{
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x2CF17B0", Offset = "0x2CF07B0", VA = "0x182CF17B0")]
		private int WorldToGridX(float xPosition)
		{
			return default(int);
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0x2CF1840", Offset = "0x2CF0840", VA = "0x182CF1840")]
		private int WorldToGridY(float zPosition)
		{
			return default(int);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00007E78 File Offset: 0x00006078
		[Token(Token = "0x6001A7E")]
		[Address(RVA = "0x2CF1790", Offset = "0x2CF0790", VA = "0x182CF1790")]
		private int WorldToGridXRounded(float xPosition)
		{
			return default(int);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x2CF1820", Offset = "0x2CF0820", VA = "0x182CF1820")]
		private int WorldToGridYRounded(float zPosition)
		{
			return default(int);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00007EA8 File Offset: 0x000060A8
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x2CF0180", Offset = "0x2CEF180", VA = "0x182CF0180")]
		private float GridToWorldX(float xPosition)
		{
			return default(float);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00007EC0 File Offset: 0x000060C0
		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x2CF01A0", Offset = "0x2CEF1A0", VA = "0x182CF01A0")]
		private float GridToWorldY(float yPosition)
		{
			return default(float);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A82")]
		[Address(RVA = "0x2CF1230", Offset = "0x2CF0230", VA = "0x182CF1230")]
		public static void RegisterTree(Vector3 worldPosition)
		{
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x2CF18B0", Offset = "0x2CF08B0", VA = "0x182CF18B0")]
		public TreeLodGrid()
		{
		}

		// Token: 0x0400198F RID: 6543
		[Token(Token = "0x400198F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _gridSize;

		// Token: 0x04001990 RID: 6544
		[Token(Token = "0x4001990")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _gridWorldSize;

		// Token: 0x04001991 RID: 6545
		[Token(Token = "0x4001991")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _maxDistance;

		// Token: 0x04001992 RID: 6546
		[Token(Token = "0x4001992")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _maxTreeDensity;

		// Token: 0x04001993 RID: 6547
		[Token(Token = "0x4001993")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _occlusionRayNormalizeRatio;

		// Token: 0x04001994 RID: 6548
		[Token(Token = "0x4001994")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _treeCountOffset;

		// Token: 0x04001995 RID: 6549
		[Token(Token = "0x4001995")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _openRayThreshold;

		// Token: 0x04001996 RID: 6550
		[Token(Token = "0x4001996")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int _directionCounts;

		// Token: 0x04001997 RID: 6551
		[Token(Token = "0x4001997")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Range(1f, 5f)]
		private float _openDirsOutputContribution;

		// Token: 0x04001998 RID: 6552
		[Token(Token = "0x4001998")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _minOutput;

		// Token: 0x04001999 RID: 6553
		[Token(Token = "0x4001999")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _maxOutput;

		// Token: 0x0400199A RID: 6554
		[Token(Token = "0x400199A")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _downSpeed;

		// Token: 0x0400199B RID: 6555
		[Token(Token = "0x400199B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _upSpeed;

		// Token: 0x0400199C RID: 6556
		[Token(Token = "0x400199C")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool _updateTreeOcclusionBonusRatio;

		// Token: 0x0400199D RID: 6557
		[Token(Token = "0x400199D")]
		[FieldOffset(Offset = "0x5D")]
		[Header("Commands")]
		[SerializeField]
		private bool _refreshGrid;

		// Token: 0x0400199E RID: 6558
		[Token(Token = "0x400199E")]
		[FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _gizmosAlphaOffset;

		// Token: 0x0400199F RID: 6559
		[Token(Token = "0x400199F")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[Range(1f, 10f)]
		private int _cellValueGroups;

		// Token: 0x040019A0 RID: 6560
		[Token(Token = "0x40019A0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _showDensityGrid;

		// Token: 0x040019A1 RID: 6561
		[Token(Token = "0x40019A1")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool _showDistanceCircles;

		// Token: 0x040019A2 RID: 6562
		[Token(Token = "0x40019A2")]
		[FieldOffset(Offset = "0x6A")]
		[SerializeField]
		private bool _showEmptyCells;

		// Token: 0x040019A3 RID: 6563
		[Token(Token = "0x40019A3")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Color _fromColor;

		// Token: 0x040019A4 RID: 6564
		[Token(Token = "0x40019A4")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Color _toColor;

		// Token: 0x040019A5 RID: 6565
		[Token(Token = "0x40019A5")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private int _gizmoBoxHeight;

		// Token: 0x040019A6 RID: 6566
		[Token(Token = "0x40019A6")]
		[FieldOffset(Offset = "0x90")]
		[FormerlySerializedAs("TreeDensityUnscaled")]
		[SerializeField]
		private float _treeDensityUnscaled;

		// Token: 0x040019A7 RID: 6567
		[Token(Token = "0x40019A7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string _playerSearch;

		// Token: 0x040019A8 RID: 6568
		[Token(Token = "0x40019A8")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3[] _rayDirections;

		// Token: 0x040019A9 RID: 6569
		[Token(Token = "0x40019A9")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 _offset;

		// Token: 0x040019AA RID: 6570
		[Token(Token = "0x40019AA")]
		[FieldOffset(Offset = "0xB4")]
		private int _highestCellTreeCount;

		// Token: 0x040019AB RID: 6571
		[Token(Token = "0x40019AB")]
		[FieldOffset(Offset = "0xB8")]
		private float _rayOcclusionStrength;

		// Token: 0x040019AC RID: 6572
		[Token(Token = "0x40019AC")]
		[FieldOffset(Offset = "0xBC")]
		private bool _isGizmo;

		// Token: 0x040019AD RID: 6573
		[Token(Token = "0x40019AD")]
		[FieldOffset(Offset = "0xC0")]
		private int[,] _treeGrid;

		// Token: 0x040019AE RID: 6574
		[Token(Token = "0x40019AE")]
		[FieldOffset(Offset = "0xC8")]
		private int _cachedMaxDistance;

		// Token: 0x040019AF RID: 6575
		[Token(Token = "0x40019AF")]
		[FieldOffset(Offset = "0xCC")]
		private int _cachedDirectionCounts;

		// Token: 0x040019B0 RID: 6576
		[Token(Token = "0x40019B0")]
		[FieldOffset(Offset = "0xD0")]
		private bool _collectedTreesFromWorldData;
	}
}
