using System;
using System.IO;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.IO
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public interface IPolygonFormat : IFileFormat
	{
		// Token: 0x06000312 RID: 786
		[Token(Token = "0x6000312")]
		IPolygon Read(string filename);

		// Token: 0x06000313 RID: 787
		[Token(Token = "0x6000313")]
		void Write(IPolygon polygon, string filename);

		// Token: 0x06000314 RID: 788
		[Token(Token = "0x6000314")]
		void Write(IPolygon polygon, Stream stream);
	}
}
