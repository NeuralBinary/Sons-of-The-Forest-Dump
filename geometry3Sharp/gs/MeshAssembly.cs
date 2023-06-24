using System;
using System.Collections.Generic;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class MeshAssembly
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1E00610", Offset = "0x1DFEC10", VA = "0x181E00610")]
		public MeshAssembly(DMesh3 sourceMesh)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1E007A0", Offset = "0x1DFEDA0", VA = "0x181E007A0")]
		public void Decompose()
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1E007B0", Offset = "0x1DFEDB0", VA = "0x181E007B0")]
		private void process()
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1E00C60", Offset = "0x1DFF260", VA = "0x181E00C60")]
		private List<DMesh3> process_solids(List<DMesh3> solid_components)
		{
			return null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x69AE00", Offset = "0x699400", VA = "0x18069AE00")]
		private List<DMesh3> process_solids_novoid(List<DMesh3> solid_components)
		{
			return null;
		}

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 SourceMesh;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x18")]
		public bool HasNoVoids;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x20")]
		public List<DMesh3> ClosedSolids;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x28")]
		public List<DMesh3> OpenMeshes;
	}
}
