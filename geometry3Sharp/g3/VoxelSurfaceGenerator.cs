using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002C7 RID: 711
	[Token(Token = "0x20002C7")]
	public class VoxelSurfaceGenerator
	{
		// Token: 0x060018E3 RID: 6371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x1EEBE60", Offset = "0x1EEA460", VA = "0x181EEBE60")]
		private void append_mesh()
		{
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x1EEC0E0", Offset = "0x1EEA6E0", VA = "0x181EEC0E0")]
		private void check_counts_or_append(int newV, int newT)
		{
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018E5")]
		[Address(RVA = "0x1EEC1C0", Offset = "0x1EEA7C0", VA = "0x181EEC1C0")]
		public void Generate()
		{
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018E6")]
		[Address(RVA = "0x1EECE60", Offset = "0x1EEB460", VA = "0x181EECE60")]
		public VoxelSurfaceGenerator()
		{
		}

		// Token: 0x04000C4D RID: 3149
		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0x10")]
		public IBinaryVoxelGrid Voxels;

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		[FieldOffset(Offset = "0x18")]
		public bool SkipInteriorFaces;

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		[FieldOffset(Offset = "0x19")]
		public bool CapAtBoundary;

		// Token: 0x04000C50 RID: 3152
		[Token(Token = "0x4000C50")]
		[FieldOffset(Offset = "0x1A")]
		public bool Clockwise;

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		[FieldOffset(Offset = "0x20")]
		public Func<Vector3i, Colorf> ColorSourceF;

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x28")]
		public int MaxMeshElementCount;

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0x30")]
		public List<DMesh3> Meshes;

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x38")]
		private DMesh3 cur_mesh;
	}
}
