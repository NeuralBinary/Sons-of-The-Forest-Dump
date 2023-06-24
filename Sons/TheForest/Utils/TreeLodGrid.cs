using System;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest.Utils
{
	// Token: 0x020003CE RID: 974
	[Token(Token = "0x20003CE")]
	public class TreeLodGrid : SingletonBehaviour<TreeLodGrid>
	{
		// Token: 0x06001AAE RID: 6830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAE")]
		[Address(RVA = "0x32A6410", Offset = "0x32A4A10", VA = "0x1832A6410", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAF")]
		[Address(RVA = "0x32A6420", Offset = "0x32A4A20", VA = "0x1832A6420")]
		private void Update()
		{
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB0")]
		[Address(RVA = "0x32A65B0", Offset = "0x32A4BB0", VA = "0x1832A65B0")]
		private void UpdateTreeOcclusionBonusRatio(float ratio)
		{
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB1")]
		[Address(RVA = "0x32A6670", Offset = "0x32A4C70", VA = "0x1832A6670")]
		private void OnDisable()
		{
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB2")]
		[Address(RVA = "0x32A66D0", Offset = "0x32A4CD0", VA = "0x1832A66D0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB3")]
		[Address(RVA = "0x32A73F0", Offset = "0x32A59F0", VA = "0x1832A73F0")]
		public void RegisterCutDownTree(Vector3 treePos)
		{
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB4")]
		[Address(RVA = "0x32A74D0", Offset = "0x32A5AD0", VA = "0x1832A74D0")]
		public void RegisterTreeRegrowth(Vector3 treePos)
		{
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB5")]
		[Address(RVA = "0x32A75A0", Offset = "0x32A5BA0", VA = "0x1832A75A0")]
		private void InitGrid()
		{
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB6")]
		[Address(RVA = "0x32A76A0", Offset = "0x32A5CA0", VA = "0x1832A76A0")]
		private void RebuildRayDirections()
		{
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB7")]
		[Address(RVA = "0x32A7930", Offset = "0x32A5F30", VA = "0x1832A7930")]
		private void SumTreeOcclusion(int treeCount)
		{
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000080B8 File Offset: 0x000062B8
		[Token(Token = "0x6001AB8")]
		[Address(RVA = "0x32A7990", Offset = "0x32A5F90", VA = "0x1832A7990")]
		private float CalcCellLodRatio(int x, int y)
		{
			return 0f;
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB9")]
		[Address(RVA = "0x32A7DE0", Offset = "0x32A63E0", VA = "0x1832A7DE0")]
		private void RayCast2DCells(int x1, int y1, int x2, int y2)
		{
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000080D0 File Offset: 0x000062D0
		[Token(Token = "0x6001ABA")]
		[Address(RVA = "0x32A8040", Offset = "0x32A6640", VA = "0x1832A8040")]
		private int WorldToGridX(float xPosition)
		{
			return 0;
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x000080E8 File Offset: 0x000062E8
		[Token(Token = "0x6001ABB")]
		[Address(RVA = "0x32A8060", Offset = "0x32A6660", VA = "0x1832A8060")]
		private int WorldToGridY(float zPosition)
		{
			return 0;
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x00008100 File Offset: 0x00006300
		[Token(Token = "0x6001ABC")]
		[Address(RVA = "0x32A8080", Offset = "0x32A6680", VA = "0x1832A8080")]
		private int WorldToGridXRounded(float xPosition)
		{
			return 0;
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00008118 File Offset: 0x00006318
		[Token(Token = "0x6001ABD")]
		[Address(RVA = "0x32A80A0", Offset = "0x32A66A0", VA = "0x1832A80A0")]
		private int WorldToGridYRounded(float zPosition)
		{
			return 0;
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00008130 File Offset: 0x00006330
		[Token(Token = "0x6001ABE")]
		[Address(RVA = "0x32A80C0", Offset = "0x32A66C0", VA = "0x1832A80C0")]
		private float GridToWorldX(float xPosition)
		{
			return 0f;
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x00008148 File Offset: 0x00006348
		[Token(Token = "0x6001ABF")]
		[Address(RVA = "0x32A80E0", Offset = "0x32A66E0", VA = "0x1832A80E0")]
		private float GridToWorldY(float yPosition)
		{
			return 0f;
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC0")]
		[Address(RVA = "0x32A8100", Offset = "0x32A6700", VA = "0x1832A8100")]
		public static void RegisterTree(Vector3 worldPosition)
		{
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC1")]
		[Address(RVA = "0x32A8180", Offset = "0x32A6780", VA = "0x1832A8180")]
		public TreeLodGrid()
		{
		}

		// Token: 0x040019B3 RID: 6579
		[Token(Token = "0x40019B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _gridSize;

		// Token: 0x040019B4 RID: 6580
		[Token(Token = "0x40019B4")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _gridWorldSize;

		// Token: 0x040019B5 RID: 6581
		[Token(Token = "0x40019B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _maxDistance;

		// Token: 0x040019B6 RID: 6582
		[Token(Token = "0x40019B6")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _maxTreeDensity;

		// Token: 0x040019B7 RID: 6583
		[Token(Token = "0x40019B7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _occlusionRayNormalizeRatio;

		// Token: 0x040019B8 RID: 6584
		[Token(Token = "0x40019B8")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _treeCountOffset;

		// Token: 0x040019B9 RID: 6585
		[Token(Token = "0x40019B9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _openRayThreshold;

		// Token: 0x040019BA RID: 6586
		[Token(Token = "0x40019BA")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int _directionCounts;

		// Token: 0x040019BB RID: 6587
		[Token(Token = "0x40019BB")]
		[FieldOffset(Offset = "0x48")]
		[Range(1f, 5f)]
		[SerializeField]
		private float _openDirsOutputContribution;

		// Token: 0x040019BC RID: 6588
		[Token(Token = "0x40019BC")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _minOutput;

		// Token: 0x040019BD RID: 6589
		[Token(Token = "0x40019BD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _maxOutput;

		// Token: 0x040019BE RID: 6590
		[Token(Token = "0x40019BE")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _downSpeed;

		// Token: 0x040019BF RID: 6591
		[Token(Token = "0x40019BF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _upSpeed;

		// Token: 0x040019C0 RID: 6592
		[Token(Token = "0x40019C0")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool _updateTreeOcclusionBonusRatio;

		// Token: 0x040019C1 RID: 6593
		[Token(Token = "0x40019C1")]
		[FieldOffset(Offset = "0x5D")]
		[SerializeField]
		[Header("Commands")]
		private bool _refreshGrid;

		// Token: 0x040019C2 RID: 6594
		[Token(Token = "0x40019C2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _gizmosAlphaOffset;

		// Token: 0x040019C3 RID: 6595
		[Token(Token = "0x40019C3")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[Range(1f, 10f)]
		private int _cellValueGroups;

		// Token: 0x040019C4 RID: 6596
		[Token(Token = "0x40019C4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _showDensityGrid;

		// Token: 0x040019C5 RID: 6597
		[Token(Token = "0x40019C5")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool _showDistanceCircles;

		// Token: 0x040019C6 RID: 6598
		[Token(Token = "0x40019C6")]
		[FieldOffset(Offset = "0x6A")]
		[SerializeField]
		private bool _showEmptyCells;

		// Token: 0x040019C7 RID: 6599
		[Token(Token = "0x40019C7")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Color _fromColor;

		// Token: 0x040019C8 RID: 6600
		[Token(Token = "0x40019C8")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Color _toColor;

		// Token: 0x040019C9 RID: 6601
		[Token(Token = "0x40019C9")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private int _gizmoBoxHeight;

		// Token: 0x040019CA RID: 6602
		[Token(Token = "0x40019CA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[FormerlySerializedAs("TreeDensityUnscaled")]
		private float _treeDensityUnscaled;

		// Token: 0x040019CB RID: 6603
		[Token(Token = "0x40019CB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string _playerSearch;

		// Token: 0x040019CC RID: 6604
		[Token(Token = "0x40019CC")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3[] _rayDirections;

		// Token: 0x040019CD RID: 6605
		[Token(Token = "0x40019CD")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 _offset;

		// Token: 0x040019CE RID: 6606
		[Token(Token = "0x40019CE")]
		[FieldOffset(Offset = "0xB4")]
		private int _highestCellTreeCount;

		// Token: 0x040019CF RID: 6607
		[Token(Token = "0x40019CF")]
		[FieldOffset(Offset = "0xB8")]
		private float _rayOcclusionStrength;

		// Token: 0x040019D0 RID: 6608
		[Token(Token = "0x40019D0")]
		[FieldOffset(Offset = "0xBC")]
		private bool _isGizmo;

		// Token: 0x040019D1 RID: 6609
		[Token(Token = "0x40019D1")]
		[FieldOffset(Offset = "0xC0")]
		private int[,] _treeGrid;

		// Token: 0x040019D2 RID: 6610
		[Token(Token = "0x40019D2")]
		[FieldOffset(Offset = "0xC8")]
		private int _cachedMaxDistance;

		// Token: 0x040019D3 RID: 6611
		[Token(Token = "0x40019D3")]
		[FieldOffset(Offset = "0xCC")]
		private int _cachedDirectionCounts;

		// Token: 0x040019D4 RID: 6612
		[Token(Token = "0x40019D4")]
		[FieldOffset(Offset = "0xD0")]
		private bool _collectedTreesFromWorldData;
	}
}
