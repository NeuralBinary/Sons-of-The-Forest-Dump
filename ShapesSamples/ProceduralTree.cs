using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[ExecuteAlways]
	public class ProceduralTree : ImmediateModeShapeDrawer
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2A5C280", Offset = "0x2A5A880", VA = "0x182A5C280", Slot = "4")]
		public override void DrawShapes(Camera cam)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2A5C5B0", Offset = "0x2A5ABB0", VA = "0x182A5C5B0")]
		private void BranchFrom(Matrix4x4 mtx)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2A5CEA0", Offset = "0x2A5B4A0", VA = "0x182A5CEA0")]
		public ProceduralTree()
		{
		}

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 0.1f)]
		[Header("Line Style")]
		public float lineThickness;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x2C")]
		public Color lineColor;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x3C")]
		[Header("Tree shape")]
		public int seed;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x40")]
		[Range(1f, 2000f)]
		public int lineCount;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 4f)]
		public int branchesMin;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x48")]
		[Range(1f, 5f)]
		public int branchesMax;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float branchLengthMin;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float branchLengthMax;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x54")]
		[Range(0f, 3.1415927f)]
		public float maxAngDeviation;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x58")]
		public bool use3D;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x5C")]
		private int currentLineCount;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x60")]
		private readonly Queue<Matrix4x4> mtxQueue;
	}
}
