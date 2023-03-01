using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x020006E5 RID: 1765
	[Token(Token = "0x20006E5")]
	[Serializable]
	public class TreeCutGrid : ISerializationCallbackReceiver
	{
		// Token: 0x06002D46 RID: 11590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D46")]
		[Address(RVA = "0x2E184F0", Offset = "0x2E174F0", VA = "0x182E184F0")]
		public void CountCellRemoval(int Id)
		{
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D47")]
		[Address(RVA = "0x2E18AE0", Offset = "0x2E17AE0", VA = "0x182E18AE0")]
		public void ResetCount()
		{
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		[Token(Token = "0x6002D48")]
		[Address(RVA = "0x2E18590", Offset = "0x2E17590", VA = "0x182E18590")]
		public float GetRemovedPercent()
		{
			return default(float);
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D49")]
		[Address(RVA = "0x2E18580", Offset = "0x2E17580", VA = "0x182E18580")]
		public void Finished()
		{
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4A")]
		[Address(RVA = "0x2E18AD0", Offset = "0x2E17AD0", VA = "0x182E18AD0")]
		public void OnValidate()
		{
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4B")]
		[Address(RVA = "0x2E18AD0", Offset = "0x2E17AD0", VA = "0x182E18AD0")]
		private void InitializeGrid()
		{
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4C")]
		[Address(RVA = "0x2E18430", Offset = "0x2E17430", VA = "0x182E18430")]
		private void CalculateCellCount()
		{
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4D")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4E")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4F")]
		[Address(RVA = "0x2E185C0", Offset = "0x2E175C0", VA = "0x182E185C0")]
		public void GridFromTransforms(GameObject cellGroup, Material blockMaterial, TreeCutManager manager)
		{
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D50")]
		[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
		public List<TreeCutCell> GetCells()
		{
			return null;
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D51")]
		[Address(RVA = "0x2E18AF0", Offset = "0x2E17AF0", VA = "0x182E18AF0")]
		public void SetManager(TreeCutManager treeCutManager)
		{
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D52")]
		[Address(RVA = "0x2E18C00", Offset = "0x2E17C00", VA = "0x182E18C00")]
		public TreeCutGrid()
		{
		}

		// Token: 0x04002876 RID: 10358
		[Token(Token = "0x4002876")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _layers;

		// Token: 0x04002877 RID: 10359
		[Token(Token = "0x4002877")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int _rings;

		// Token: 0x04002878 RID: 10360
		[Token(Token = "0x4002878")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _segments;

		// Token: 0x04002879 RID: 10361
		[Token(Token = "0x4002879")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _cellCount;

		// Token: 0x0400287A RID: 10362
		[Token(Token = "0x400287A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _layerCellCount;

		// Token: 0x0400287B RID: 10363
		[Token(Token = "0x400287B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _removedCount;

		// Token: 0x0400287C RID: 10364
		[Token(Token = "0x400287C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _removedPercent;

		// Token: 0x0400287D RID: 10365
		[Token(Token = "0x400287D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<TreeCutCell> _cells;
	}
}
