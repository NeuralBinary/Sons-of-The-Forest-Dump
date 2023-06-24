using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000317 RID: 791
	[Token(Token = "0x2000317")]
	public enum ValidationStatus
	{
		// Token: 0x04000DFB RID: 3579
		[Token(Token = "0x4000DFB")]
		Ok,
		// Token: 0x04000DFC RID: 3580
		[Token(Token = "0x4000DFC")]
		NotAVertex,
		// Token: 0x04000DFD RID: 3581
		[Token(Token = "0x4000DFD")]
		NotBoundaryVertex,
		// Token: 0x04000DFE RID: 3582
		[Token(Token = "0x4000DFE")]
		NotBoundaryEdge,
		// Token: 0x04000DFF RID: 3583
		[Token(Token = "0x4000DFF")]
		NotATriangle,
		// Token: 0x04000E00 RID: 3584
		[Token(Token = "0x4000E00")]
		VerticesNotConnectedByEdge,
		// Token: 0x04000E01 RID: 3585
		[Token(Token = "0x4000E01")]
		IncorrectLoopOrientation,
		// Token: 0x04000E02 RID: 3586
		[Token(Token = "0x4000E02")]
		DuplicateTriangles,
		// Token: 0x04000E03 RID: 3587
		[Token(Token = "0x4000E03")]
		NearDegenerateMeshEdges,
		// Token: 0x04000E04 RID: 3588
		[Token(Token = "0x4000E04")]
		NearDenegerateInputGeometry
	}
}
