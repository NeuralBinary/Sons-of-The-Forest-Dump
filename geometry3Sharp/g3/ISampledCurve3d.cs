using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	public interface ISampledCurve3d
	{
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000722 RID: 1826
		[Token(Token = "0x17000125")]
		int VertexCount { [Token(Token = "0x6000722")] get; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000723 RID: 1827
		[Token(Token = "0x17000126")]
		int SegmentCount { [Token(Token = "0x6000723")] get; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000724 RID: 1828
		[Token(Token = "0x17000127")]
		bool Closed { [Token(Token = "0x6000724")] get; }

		// Token: 0x06000725 RID: 1829
		[Token(Token = "0x6000725")]
		Vector3d GetVertex(int i);

		// Token: 0x06000726 RID: 1830
		[Token(Token = "0x6000726")]
		Segment3d GetSegment(int i);

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000727 RID: 1831
		[Token(Token = "0x17000128")]
		IEnumerable<Vector3d> Vertices { [Token(Token = "0x6000727")] get; }
	}
}
