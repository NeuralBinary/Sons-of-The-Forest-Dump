using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	public class ObiTriangleMeshContainer
	{
		// Token: 0x0600071E RID: 1822 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x27D3270", Offset = "0x27D1870", VA = "0x1827D3270")]
		public ObiTriangleMeshContainer()
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x27D3520", Offset = "0x27D1B20", VA = "0x1827D3520")]
		public ObiTriangleMeshHandle GetOrCreateTriangleMesh(Mesh source)
		{
			return null;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x27D3D20", Offset = "0x27D2320", VA = "0x1827D3D20")]
		public void DestroyTriangleMesh(ObiTriangleMeshHandle handle)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x27D4170", Offset = "0x27D2770", VA = "0x1827D4170")]
		public void Dispose()
		{
		}

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<Mesh, ObiTriangleMeshHandle> handles;

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0x18")]
		public ObiNativeTriangleMeshHeaderList headers;

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0x20")]
		public ObiNativeBIHNodeList bihNodes;

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0x28")]
		public ObiNativeTriangleList triangles;

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x30")]
		public ObiNativeVector3List vertices;
	}
}
