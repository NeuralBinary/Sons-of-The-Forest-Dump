using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	public class MultiTargetPath : ABPath
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00005C24 File Offset: 0x00003E24
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000140")]
		public bool inverted
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x6D86D0", Offset = "0x6D6CD0", VA = "0x1806D86D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x6D86E0", Offset = "0x6D6CE0", VA = "0x1806D86E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x6D86F0", Offset = "0x6D6CF0", VA = "0x1806D86F0")]
		public MultiTargetPath()
		{
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x6D8790", Offset = "0x6D6D90", VA = "0x1806D8790")]
		public static MultiTargetPath Construct(Vector3[] startPoints, Vector3 target, OnPathDelegate[] callbackDelegates, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x6D87E0", Offset = "0x6D6DE0", VA = "0x1806D87E0")]
		public static MultiTargetPath Construct(Vector3 start, Vector3[] targets, OnPathDelegate[] callbackDelegates, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x6D88B0", Offset = "0x6D6EB0", VA = "0x1806D88B0")]
		protected void Setup(Vector3 start, Vector3[] targets, OnPathDelegate[] callbackDelegates, OnPathDelegate callback)
		{
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x6D8CB0", Offset = "0x6D72B0", VA = "0x1806D8CB0", Slot = "20")]
		protected override void Reset()
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x6D8D00", Offset = "0x6D7300", VA = "0x1806D8D00", Slot = "19")]
		protected override void OnEnterPool()
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x6D9150", Offset = "0x6D7750", VA = "0x1806D9150")]
		private void ChooseShortestPath()
		{
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x6D9280", Offset = "0x6D7880", VA = "0x1806D9280")]
		private void SetPathParametersForReturn(int target)
		{
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x6D9550", Offset = "0x6D7B50", VA = "0x1806D9550", Slot = "23")]
		protected override void ReturnPath()
		{
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x6D9810", Offset = "0x6D7E10", VA = "0x1806D9810")]
		protected void FoundTarget(PathNode nodeR, int i)
		{
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x6D9AC0", Offset = "0x6D80C0", VA = "0x1806D9AC0")]
		protected void RebuildOpenList()
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x6D9BA0", Offset = "0x6D81A0", VA = "0x1806D9BA0", Slot = "24")]
		protected override void Prepare()
		{
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x6DA3F0", Offset = "0x6D89F0", VA = "0x1806DA3F0")]
		private void RecalculateHTarget(bool firstTime)
		{
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x6DAD70", Offset = "0x6D9370", VA = "0x1806DAD70", Slot = "26")]
		protected override void Initialize()
		{
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x6DB0A0", Offset = "0x6D96A0", VA = "0x1806DB0A0", Slot = "25")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x6DB270", Offset = "0x6D9870", VA = "0x1806DB270")]
		private void ResetFlags()
		{
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x6DB310", Offset = "0x6D9910", VA = "0x1806DB310", Slot = "27")]
		protected override void CalculateStep(long targetTick)
		{
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x6DB4E0", Offset = "0x6D9AE0", VA = "0x1806DB4E0", Slot = "21")]
		protected override void Trace(PathNode node)
		{
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x6DB750", Offset = "0x6D9D50", VA = "0x1806DB750", Slot = "22")]
		protected override string DebugString(PathLog logMode)
		{
			return null;
		}

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public OnPathDelegate[] callbacks;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public GraphNode[] targetNodes;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected int targetNodeCount;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public bool[] targetsFound;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Vector3[] targetPoints;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public Vector3[] originalTargetPoints;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public List<Vector3>[] vectorPaths;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public List<GraphNode>[] nodePaths;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool pathsForAll;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public int chosenTarget;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int sequentialTarget;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public MultiTargetPath.HeuristicMode heuristicMode;

		// Token: 0x020000F3 RID: 243
		[Token(Token = "0x20000F3")]
		public enum HeuristicMode
		{
			// Token: 0x040005A5 RID: 1445
			[Token(Token = "0x40005A5")]
			None,
			// Token: 0x040005A6 RID: 1446
			[Token(Token = "0x40005A6")]
			Average,
			// Token: 0x040005A7 RID: 1447
			[Token(Token = "0x40005A7")]
			MovingAverage,
			// Token: 0x040005A8 RID: 1448
			[Token(Token = "0x40005A8")]
			Midpoint,
			// Token: 0x040005A9 RID: 1449
			[Token(Token = "0x40005A9")]
			MovingMidpoint,
			// Token: 0x040005AA RID: 1450
			[Token(Token = "0x40005AA")]
			Sequential
		}
	}
}
