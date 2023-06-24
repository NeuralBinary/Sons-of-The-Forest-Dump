using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	public class ConstantPath : Path
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00005B94 File Offset: 0x00003D94
		[Token(Token = "0x1700013D")]
		public override bool FloodingPath
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x6D5CE0", Offset = "0x6D42E0", VA = "0x1806D5CE0")]
		public static ConstantPath Construct(Vector3 start, int maxGScore, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x6D5ED0", Offset = "0x6D44D0", VA = "0x1806D5ED0")]
		protected void Setup(Vector3 start, int maxGScore, OnPathDelegate callback)
		{
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x6D6060", Offset = "0x6D4660", VA = "0x1806D6060", Slot = "19")]
		protected override void OnEnterPool()
		{
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x6D60E0", Offset = "0x6D46E0", VA = "0x1806D60E0", Slot = "20")]
		protected override void Reset()
		{
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x6D62E0", Offset = "0x6D48E0", VA = "0x1806D62E0", Slot = "24")]
		protected override void Prepare()
		{
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x6D6410", Offset = "0x6D4A10", VA = "0x1806D6410", Slot = "26")]
		protected override void Initialize()
		{
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x6D66D0", Offset = "0x6D4CD0", VA = "0x1806D66D0", Slot = "25")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x6D67A0", Offset = "0x6D4DA0", VA = "0x1806D67A0", Slot = "27")]
		protected override void CalculateStep(long targetTick)
		{
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x6D69A0", Offset = "0x6D4FA0", VA = "0x1806D69A0")]
		public ConstantPath()
		{
		}

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public GraphNode startNode;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Vector3 startPoint;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public Vector3 originalStartPoint;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public List<GraphNode> allNodes;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public PathEndingCondition endingCondition;
	}
}
