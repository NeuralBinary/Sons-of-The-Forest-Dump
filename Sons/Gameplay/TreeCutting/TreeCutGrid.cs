using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x02000831 RID: 2097
	[Token(Token = "0x2000831")]
	[Serializable]
	public class TreeCutGrid : ISerializationCallbackReceiver
	{
		// Token: 0x06003B28 RID: 15144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B28")]
		[Address(RVA = "0x35872A0", Offset = "0x35858A0", VA = "0x1835872A0")]
		public void CountCellRemoval(int Id)
		{
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B29")]
		[Address(RVA = "0x3587340", Offset = "0x3585940", VA = "0x183587340")]
		public void ResetCount()
		{
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00012138 File Offset: 0x00010338
		[Token(Token = "0x6003B2A")]
		[Address(RVA = "0x3587350", Offset = "0x3585950", VA = "0x183587350")]
		public float GetRemovedPercent()
		{
			return 0f;
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2B")]
		[Address(RVA = "0x3587380", Offset = "0x3585980", VA = "0x183587380")]
		public void Finished()
		{
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2C")]
		[Address(RVA = "0x3587390", Offset = "0x3585990", VA = "0x183587390")]
		public void OnValidate()
		{
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2D")]
		[Address(RVA = "0x3587390", Offset = "0x3585990", VA = "0x183587390")]
		private void InitializeGrid()
		{
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2E")]
		[Address(RVA = "0x35873A0", Offset = "0x35859A0", VA = "0x1835873A0")]
		private void CalculateCellCount()
		{
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B30")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B31")]
		[Address(RVA = "0x3587460", Offset = "0x3585A60", VA = "0x183587460")]
		public void GridFromTransforms(GameObject cellGroup, Material blockMaterial, TreeCutManager manager)
		{
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B32")]
		[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
		public List<TreeCutCell> GetCells()
		{
			return null;
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B33")]
		[Address(RVA = "0x3587AB0", Offset = "0x35860B0", VA = "0x183587AB0")]
		public void SetManager(TreeCutManager treeCutManager)
		{
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B34")]
		[Address(RVA = "0x3587BF0", Offset = "0x35861F0", VA = "0x183587BF0")]
		public TreeCutGrid()
		{
		}

		// Token: 0x04003252 RID: 12882
		[Token(Token = "0x4003252")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _layers;

		// Token: 0x04003253 RID: 12883
		[Token(Token = "0x4003253")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int _rings;

		// Token: 0x04003254 RID: 12884
		[Token(Token = "0x4003254")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _segments;

		// Token: 0x04003255 RID: 12885
		[Token(Token = "0x4003255")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _cellCount;

		// Token: 0x04003256 RID: 12886
		[Token(Token = "0x4003256")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _layerCellCount;

		// Token: 0x04003257 RID: 12887
		[Token(Token = "0x4003257")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _removedCount;

		// Token: 0x04003258 RID: 12888
		[Token(Token = "0x4003258")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _removedPercent;

		// Token: 0x04003259 RID: 12889
		[Token(Token = "0x4003259")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<TreeCutCell> _cells;
	}
}
