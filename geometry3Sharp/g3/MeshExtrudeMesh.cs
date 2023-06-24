using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002D6 RID: 726
	[Token(Token = "0x20002D6")]
	public class MeshExtrudeMesh
	{
		// Token: 0x0600191F RID: 6431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x1EF8D00", Offset = "0x1EF7300", VA = "0x181EF8D00")]
		public MeshExtrudeMesh(DMesh3 mesh)
		{
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x000126BC File Offset: 0x000108BC
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "4")]
		public virtual ValidationStatus Validate()
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000126D4 File Offset: 0x000108D4
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x1EF8F20", Offset = "0x1EF7520", VA = "0x181EF8F20", Slot = "5")]
		public virtual bool Extrude()
		{
			return default(bool);
		}

		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x18")]
		public SetGroupBehavior OffsetGroup;

		// Token: 0x04000CBD RID: 3261
		[Token(Token = "0x4000CBD")]
		[FieldOffset(Offset = "0x20")]
		public SetGroupBehavior StitchGroups;

		// Token: 0x04000CBE RID: 3262
		[Token(Token = "0x4000CBE")]
		[FieldOffset(Offset = "0x28")]
		public Func<Vector3d, Vector3f, int, Vector3d> ExtrudedPositionF;

		// Token: 0x04000CBF RID: 3263
		[Token(Token = "0x4000CBF")]
		[FieldOffset(Offset = "0x30")]
		public bool IsPositiveOffset;

		// Token: 0x04000CC0 RID: 3264
		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x38")]
		public MeshBoundaryLoops InitialLoops;

		// Token: 0x04000CC1 RID: 3265
		[Token(Token = "0x4000CC1")]
		[FieldOffset(Offset = "0x40")]
		public int[] InitialTriangles;

		// Token: 0x04000CC2 RID: 3266
		[Token(Token = "0x4000CC2")]
		[FieldOffset(Offset = "0x48")]
		public int[] InitialVertices;

		// Token: 0x04000CC3 RID: 3267
		[Token(Token = "0x4000CC3")]
		[FieldOffset(Offset = "0x50")]
		public IndexMap InitialToOffsetMapV;

		// Token: 0x04000CC4 RID: 3268
		[Token(Token = "0x4000CC4")]
		[FieldOffset(Offset = "0x58")]
		private List<int> OffsetTriangles;

		// Token: 0x04000CC5 RID: 3269
		[Token(Token = "0x4000CC5")]
		[FieldOffset(Offset = "0x60")]
		public int OffsetGroupID;

		// Token: 0x04000CC6 RID: 3270
		[Token(Token = "0x4000CC6")]
		[FieldOffset(Offset = "0x68")]
		public EdgeLoop[] NewLoops;

		// Token: 0x04000CC7 RID: 3271
		[Token(Token = "0x4000CC7")]
		[FieldOffset(Offset = "0x70")]
		public int[][] StitchTriangles;

		// Token: 0x04000CC8 RID: 3272
		[Token(Token = "0x4000CC8")]
		[FieldOffset(Offset = "0x78")]
		public int[] StitchGroupIDs;
	}
}
