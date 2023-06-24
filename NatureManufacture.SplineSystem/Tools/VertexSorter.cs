using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Tools
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	public class VertexSorter
	{
		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x24C1F90", Offset = "0x24C0590", VA = "0x1824C1F90")]
		private VertexSorter(Vertex[] points, int seed)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x24C20B0", Offset = "0x24C06B0", VA = "0x1824C20B0")]
		public static void Sort(Vertex[] array, int seed = 57113)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x24C2140", Offset = "0x24C0740", VA = "0x1824C2140")]
		public static void Alternate(Vertex[] array, int length, int seed = 57113)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x24C2200", Offset = "0x24C0800", VA = "0x1824C2200")]
		private void QuickSort(int left, int right)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x24C2570", Offset = "0x24C0B70", VA = "0x1824C2570")]
		private void AlternateAxes(int left, int right, int axis)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x24C2630", Offset = "0x24C0C30", VA = "0x1824C2630")]
		private void VertexMedianX(int left, int right, int median)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x24C2960", Offset = "0x24C0F60", VA = "0x1824C2960")]
		private void VertexMedianY(int left, int right, int median)
		{
		}

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		private const int RANDOM_SEED = 57113;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x10")]
		private Random rand;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x18")]
		private Vertex[] points;
	}
}
