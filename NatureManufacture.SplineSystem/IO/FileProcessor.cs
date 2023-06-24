using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Meshing;

namespace TriangleNet.IO
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	public static class FileProcessor
	{
		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x24DE8E0", Offset = "0x24DCEE0", VA = "0x1824DE8E0")]
		public static void Add(IFileFormat format)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x24DE9A0", Offset = "0x24DCFA0", VA = "0x1824DE9A0")]
		public static bool IsSupported(string file)
		{
			return default(bool);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x24DEB40", Offset = "0x24DD140", VA = "0x1824DEB40")]
		public static IPolygon Read(string filename)
		{
			return null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x24DED70", Offset = "0x24DD370", VA = "0x1824DED70")]
		public static void Write(IPolygon polygon, string filename)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x24DEFD0", Offset = "0x24DD5D0", VA = "0x1824DEFD0")]
		public static IMesh Import(string filename)
		{
			return null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x24DF200", Offset = "0x24DD800", VA = "0x1824DF200")]
		public static void Write(IMesh mesh, string filename)
		{
		}

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x0")]
		private static List<IFileFormat> formats;
	}
}
