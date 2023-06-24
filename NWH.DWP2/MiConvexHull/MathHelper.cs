using System;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	internal class MathHelper
	{
		// Token: 0x060001ED RID: 493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x271EE30", Offset = "0x271D430", VA = "0x18271EE30")]
		internal MathHelper(int dimension, double[] positions)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002F9C File Offset: 0x0000119C
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x271F130", Offset = "0x271D730", VA = "0x18271F130")]
		internal bool CalculateFacePlane(ConvexFaceInternal face, double[] center)
		{
			return default(bool);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002FB4 File Offset: 0x000011B4
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x271F2D0", Offset = "0x271D8D0", VA = "0x18271F2D0")]
		internal double GetVertexDistance(int v, ConvexFaceInternal f)
		{
			return 0.0;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x271F350", Offset = "0x271D950", VA = "0x18271F350")]
		internal double[] VectorBetweenVertices(int toIndex, int fromIndex)
		{
			return null;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x271F430", Offset = "0x271DA30", VA = "0x18271F430")]
		private void VectorBetweenVertices(int toIndex, int fromIndex, double[] target)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x271F4D0", Offset = "0x271DAD0", VA = "0x18271F4D0")]
		private static void LUFactor(double[] data, int order, int[] ipiv, double[] vecLUcolj)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x271F800", Offset = "0x271DE00", VA = "0x18271F800")]
		private void FindNormalVector(int[] vertices, double[] normalData)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x271FA00", Offset = "0x271E000", VA = "0x18271FA00")]
		private void FindNormalVector2D(int[] vertices, double[] normal)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x271FBA0", Offset = "0x271E1A0", VA = "0x18271FBA0")]
		private void FindNormalVector3D(int[] vertices, double[] normal)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x271FEC0", Offset = "0x271E4C0", VA = "0x18271FEC0")]
		private void FindNormalVector4D(int[] vertices, double[] normal)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2720410", Offset = "0x271EA10", VA = "0x182720410")]
		private void FindNormalVectorND(int[] vertices, double[] normal)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2720690", Offset = "0x271EC90", VA = "0x182720690")]
		internal double GetSimplexVolume(double[][] edgeVectors, int lastIndex, double bigNumber)
		{
			return 0.0;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002FE4 File Offset: 0x000011E4
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2720860", Offset = "0x271EE60", VA = "0x182720860")]
		private double DeterminantDestructive(double[] A)
		{
			return 0.0;
		}

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x10")]
		private readonly int Dimension;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x18")]
		private readonly int[] matrixPivots;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x20")]
		private readonly double[] nDMatrix;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x28")]
		private readonly double[] nDNormalHelperVector;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x30")]
		private readonly double[] ntX;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x38")]
		private readonly double[] ntY;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x40")]
		private readonly double[] ntZ;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x48")]
		private readonly double[] PositionData;
	}
}
