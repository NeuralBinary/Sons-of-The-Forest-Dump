using System;
using System.Globalization;
using System.IO;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.IO
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	internal class DebugWriter
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private DebugWriter()
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700008A")]
		public static DebugWriter Session
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x24DC510", Offset = "0x24DAB10", VA = "0x1824DC510")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x24DC560", Offset = "0x24DAB60", VA = "0x1824DC560")]
		public void Start(string session)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x24DC760", Offset = "0x24DAD60", VA = "0x1824DC760")]
		public void Write(Mesh mesh, bool skip = false)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x24DC7E0", Offset = "0x24DADE0", VA = "0x1824DC7E0")]
		public void Finish()
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x24DC830", Offset = "0x24DAE30", VA = "0x1824DC830")]
		private void Finish(string path)
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x24DCCB0", Offset = "0x24DB2B0", VA = "0x1824DCCB0")]
		private void WriteGeometry(IPolygon geometry)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x24DCD40", Offset = "0x24DB340", VA = "0x1824DCD40")]
		private void WriteMesh(Mesh mesh, bool skip)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x24DE1D0", Offset = "0x24DC7D0", VA = "0x1824DE1D0")]
		private bool VerticesChanged(Mesh mesh)
		{
			return default(bool);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x24DE420", Offset = "0x24DCA20", VA = "0x1824DE420")]
		private void HashVertices(Mesh mesh)
		{
		}

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x0")]
		private static NumberFormatInfo nfi;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x10")]
		private int iteration;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x18")]
		private string session;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x20")]
		private StreamWriter stream;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x28")]
		private string tmpFile;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x30")]
		private int[] vertices;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x38")]
		private int triangles;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly DebugWriter instance;
	}
}
