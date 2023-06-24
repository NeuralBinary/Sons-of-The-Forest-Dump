using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	public class ABPath : Path
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00005B34 File Offset: 0x00003D34
		[Token(Token = "0x1700013C")]
		protected virtual bool hasEndPoint
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x6D2B40", Offset = "0x6D1140", VA = "0x1806D2B40")]
		public ABPath()
		{
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x6D2B90", Offset = "0x6D1190", VA = "0x1806D2B90")]
		public static ABPath Construct(Vector3 start, Vector3 end, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x6D2CB0", Offset = "0x6D12B0", VA = "0x1806D2CB0")]
		protected void Setup(Vector3 start, Vector3 end, OnPathDelegate callbackDelegate)
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x6D2D40", Offset = "0x6D1340", VA = "0x1806D2D40")]
		public static ABPath FakePath(List<Vector3> vectorPath, [Optional] List<GraphNode> nodePath)
		{
			return null;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x6D3150", Offset = "0x6D1750", VA = "0x1806D3150")]
		protected void UpdateStartEnd(Vector3 start, Vector3 end)
		{
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00005B4C File Offset: 0x00003D4C
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x6D3320", Offset = "0x6D1920", VA = "0x1806D3320", Slot = "18")]
		public override uint GetConnectionSpecialCost(GraphNode a, GraphNode b, uint currentCost)
		{
			return 0U;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x6D37C0", Offset = "0x6D1DC0", VA = "0x1806D37C0", Slot = "20")]
		protected override void Reset()
		{
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00005B64 File Offset: 0x00003D64
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x6D3AB0", Offset = "0x6D20B0", VA = "0x1806D3AB0", Slot = "29")]
		protected virtual bool EndPointGridGraphSpecialCase(GraphNode closestWalkableEndNode)
		{
			return default(bool);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x6D41F0", Offset = "0x6D27F0", VA = "0x1806D41F0")]
		private void SetFlagOnSurroundingGridNodes(GridNode gridNode, int flag, bool flagState)
		{
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x6D44E0", Offset = "0x6D2AE0", VA = "0x1806D44E0", Slot = "24")]
		protected override void Prepare()
		{
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x6D49B0", Offset = "0x6D2FB0", VA = "0x1806D49B0", Slot = "30")]
		protected virtual void CompletePathIfStartIsValidTarget()
		{
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x6D4A90", Offset = "0x6D3090", VA = "0x1806D4A90", Slot = "26")]
		protected override void Initialize()
		{
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x6D4E20", Offset = "0x6D3420", VA = "0x1806D4E20", Slot = "25")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x6D4F70", Offset = "0x6D3570", VA = "0x1806D4F70")]
		private void CompletePartial(PathNode node)
		{
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x6D5070", Offset = "0x6D3670", VA = "0x1806D5070")]
		private void CompleteWith(GraphNode node)
		{
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x6D51E0", Offset = "0x6D37E0", VA = "0x1806D51E0", Slot = "27")]
		protected override void CalculateStep(long targetTick)
		{
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x6D5430", Offset = "0x6D3A30", VA = "0x1806D5430", Slot = "22")]
		protected override string DebugString(PathLog logMode)
		{
			return null;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00005B7C File Offset: 0x00003D7C
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x6D5780", Offset = "0x6D3D80", VA = "0x1806D5780")]
		[Obsolete]
		public Vector3 GetMovementVector(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public GraphNode startNode;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public GraphNode endNode;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Vector3 originalStartPoint;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public Vector3 originalEndPoint;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Vector3 startPoint;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public Vector3 endPoint;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Int3 startIntPoint;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public bool calculatePartial;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		protected PathNode partialBestTarget;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected int[] endNodeCosts;

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private GridNode gridSpecialCaseNode;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly NNConstraint NNConstraintNone;
	}
}
