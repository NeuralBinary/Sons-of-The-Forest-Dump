using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	public class FloodPath : Path
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00005BC4 File Offset: 0x00003DC4
		[Token(Token = "0x1700013E")]
		public override bool FloodingPath
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00005BDC File Offset: 0x00003DDC
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x6D6E70", Offset = "0x6D5470", VA = "0x1806D6E70")]
		public bool HasPathTo(GraphNode node)
		{
			return default(bool);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x6D6EF0", Offset = "0x6D54F0", VA = "0x1806D6EF0")]
		public GraphNode GetParent(GraphNode node)
		{
			return null;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x6D6F50", Offset = "0x6D5550", VA = "0x1806D6F50")]
		public FloodPath()
		{
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x6D6FA0", Offset = "0x6D55A0", VA = "0x1806D6FA0")]
		public static FloodPath Construct(Vector3 start, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x6D70A0", Offset = "0x6D56A0", VA = "0x1806D70A0")]
		public static FloodPath Construct(GraphNode start, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x6D7300", Offset = "0x6D5900", VA = "0x1806D7300")]
		protected void Setup(Vector3 start, OnPathDelegate callback)
		{
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x6D7390", Offset = "0x6D5990", VA = "0x1806D7390")]
		protected void Setup(GraphNode start, OnPathDelegate callback)
		{
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x6D7530", Offset = "0x6D5B30", VA = "0x1806D7530", Slot = "20")]
		protected override void Reset()
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x6D76D0", Offset = "0x6D5CD0", VA = "0x1806D76D0", Slot = "24")]
		protected override void Prepare()
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x6D7920", Offset = "0x6D5F20", VA = "0x1806D7920", Slot = "26")]
		protected override void Initialize()
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x6D7BC0", Offset = "0x6D61C0", VA = "0x1806D7BC0", Slot = "27")]
		protected override void CalculateStep(long targetTick)
		{
		}

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector3 originalStartPoint;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public Vector3 startPoint;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public GraphNode startNode;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public bool saveParents;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Dictionary<GraphNode, GraphNode> parents;
	}
}
