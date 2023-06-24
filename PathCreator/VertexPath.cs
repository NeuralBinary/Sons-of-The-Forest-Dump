using System;
using Il2CppDummyDll;
using PathCreation.Utility;
using UnityEngine;

namespace PathCreation
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class VertexPath
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x282E180", Offset = "0x282C780", VA = "0x18282E180")]
		public VertexPath(BezierPath bezierPath, Transform transform, float maxAngleError = 0.3f, float minVertexDst = 0f)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x282E1F0", Offset = "0x282C7F0", VA = "0x18282E1F0")]
		public VertexPath(BezierPath bezierPath, Transform transform, float vertexSpacing)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x282E250", Offset = "0x282C850", VA = "0x18282E250")]
		private VertexPath(BezierPath bezierPath, VertexPathUtility.PathSplitData pathSplitData, Transform transform)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
		public void UpdateTransform(Transform transform)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x17000012")]
		public int NumPoints
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x13161C0", Offset = "0x13147C0", VA = "0x1813161C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x282F560", Offset = "0x282DB60", VA = "0x18282F560")]
		public Vector3 GetTangent(int index)
		{
			return default(Vector3);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x282F690", Offset = "0x282DC90", VA = "0x18282F690")]
		public Vector3 GetNormal(int index)
		{
			return default(Vector3);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x282F7C0", Offset = "0x282DDC0", VA = "0x18282F7C0")]
		public Vector3 GetPoint(int index)
		{
			return default(Vector3);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x282F8F0", Offset = "0x282DEF0", VA = "0x18282F8F0")]
		public Vector3 GetPointAtDistance(float dst, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Vector3);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x282FA10", Offset = "0x282E010", VA = "0x18282FA10")]
		public Vector3 GetDirectionAtDistance(float dst, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Vector3);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x282FA50", Offset = "0x282E050", VA = "0x18282FA50")]
		public Vector3 GetNormalAtDistance(float dst, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Vector3);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x282FA90", Offset = "0x282E090", VA = "0x18282FA90")]
		public Quaternion GetRotationAtDistance(float dst, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Quaternion);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x282FAC0", Offset = "0x282E0C0", VA = "0x18282FAC0")]
		public Vector3 GetPointAtTime(float t, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Vector3);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x282FBD0", Offset = "0x282E1D0", VA = "0x18282FBD0")]
		public Vector3 GetDirection(float t, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Vector3);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x282FDC0", Offset = "0x282E3C0", VA = "0x18282FDC0")]
		public Vector3 GetNormal(float t, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Vector3);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x282FFB0", Offset = "0x282E5B0", VA = "0x18282FFB0")]
		public Quaternion GetRotation(float t, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Quaternion);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2830370", Offset = "0x282E970", VA = "0x182830370")]
		public Vector3 GetClosestPointOnPath(Vector3 worldPoint)
		{
			return default(Vector3);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2830490", Offset = "0x282EA90", VA = "0x182830490")]
		public float GetClosestTimeOnPath(Vector3 worldPoint)
		{
			return 0f;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2830550", Offset = "0x282EB50", VA = "0x182830550")]
		public float GetClosestDistanceAlongPath(Vector3 worldPoint)
		{
			return 0f;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2830610", Offset = "0x282EC10", VA = "0x182830610")]
		private VertexPath.TimeOnPathData CalculatePercentOnPathData(float t, EndOfPathInstruction endOfPathInstruction)
		{
			return default(VertexPath.TimeOnPathData);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x28307A0", Offset = "0x282EDA0", VA = "0x1828307A0")]
		public VertexPath.TimeOnPathData CalculateClosestPointOnPathData(Vector3 worldPoint)
		{
			return default(VertexPath.TimeOnPathData);
		}

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x10")]
		public readonly PathSpace space;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x14")]
		public readonly bool isClosedLoop;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x18")]
		public readonly Vector3[] localPoints;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x20")]
		public readonly Vector3[] localTangents;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x28")]
		public readonly Vector3[] localNormals;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x30")]
		public readonly float[] times;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x38")]
		public readonly float length;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x40")]
		public readonly float[] cumulativeLengthAtEachVertex;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x48")]
		public readonly Bounds bounds;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x60")]
		public readonly Vector3 up;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		private const int accuracy = 10;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		private const float minVertexSpacing = 0.01f;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x70")]
		private Transform transform;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x78")]
		private MathUtility.PosRotScale t_PosRotScale;

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		public struct TimeOnPathData
		{
			// Token: 0x0600006C RID: 108 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x15D3F70", Offset = "0x15D2570", VA = "0x1815D3F70")]
			public TimeOnPathData(int prev, int next, float percentBetweenIndices)
			{
			}

			// Token: 0x04000068 RID: 104
			[Token(Token = "0x4000068")]
			[FieldOffset(Offset = "0x0")]
			public readonly int previousIndex;

			// Token: 0x04000069 RID: 105
			[Token(Token = "0x4000069")]
			[FieldOffset(Offset = "0x4")]
			public readonly int nextIndex;

			// Token: 0x0400006A RID: 106
			[Token(Token = "0x400006A")]
			[FieldOffset(Offset = "0x8")]
			public readonly float percentBetweenIndices;
		}
	}
}
