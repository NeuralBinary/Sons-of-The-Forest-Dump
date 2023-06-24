using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.IO
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public class TriangleWriter
	{
		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x24E2FC0", Offset = "0x24E15C0", VA = "0x1824E2FC0")]
		public void Write(Mesh mesh, string filename)
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x24E3080", Offset = "0x24E1680", VA = "0x1824E3080")]
		public void WriteNodes(Mesh mesh, string filename)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x24E3170", Offset = "0x24E1770", VA = "0x1824E3170")]
		private void WriteNodes(StreamWriter writer, Mesh mesh)
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x24E3760", Offset = "0x24E1D60", VA = "0x1824E3760")]
		private void WriteNodes(StreamWriter writer, IEnumerable<Vertex> nodes, bool markers, int attribs, bool jettison)
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x24E3A90", Offset = "0x24E2090", VA = "0x1824E3A90")]
		public void WriteElements(Mesh mesh, string filename)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x24E43E0", Offset = "0x24E29E0", VA = "0x1824E43E0")]
		public void WritePoly(IPolygon polygon, string filename)
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x24E5700", Offset = "0x24E3D00", VA = "0x1824E5700")]
		public void WritePoly(Mesh mesh, string filename)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x24E5720", Offset = "0x24E3D20", VA = "0x1824E5720")]
		public void WritePoly(Mesh mesh, string filename, bool writeNodes)
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x24E69F0", Offset = "0x24E4FF0", VA = "0x1824E69F0")]
		public void WriteEdges(Mesh mesh, string filename)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x24E75E0", Offset = "0x24E5BE0", VA = "0x1824E75E0")]
		public void WriteNeighbors(Mesh mesh, string filename)
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TriangleWriter()
		{
		}

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x0")]
		private static NumberFormatInfo nfi;
	}
}
