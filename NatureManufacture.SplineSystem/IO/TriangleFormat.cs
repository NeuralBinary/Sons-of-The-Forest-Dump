using System;
using System.IO;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Meshing;

namespace TriangleNet.IO
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	public class TriangleFormat : IPolygonFormat, IFileFormat, IMeshFormat
	{
		// Token: 0x06000315 RID: 789 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x24DF540", Offset = "0x24DDB40", VA = "0x1824DF540", Slot = "7")]
		public bool IsSupported(string file)
		{
			return default(bool);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x24DF690", Offset = "0x24DDC90", VA = "0x1824DF690", Slot = "8")]
		public IMesh Import(string filename)
		{
			return null;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x24DFC20", Offset = "0x24DE220", VA = "0x1824DFC20", Slot = "9")]
		public void Write(IMesh mesh, string filename)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x24DFDA0", Offset = "0x24DE3A0", VA = "0x1824DFDA0", Slot = "10")]
		public void Write(IMesh mesh, Stream stream)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x24DFDE0", Offset = "0x24DE3E0", VA = "0x1824DFDE0", Slot = "4")]
		public IPolygon Read(string filename)
		{
			return null;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x24DFFB0", Offset = "0x24DE5B0", VA = "0x1824DFFB0", Slot = "5")]
		public void Write(IPolygon polygon, string filename)
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x24E0010", Offset = "0x24DE610", VA = "0x1824E0010", Slot = "6")]
		public void Write(IPolygon polygon, Stream stream)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TriangleFormat()
		{
		}
	}
}
