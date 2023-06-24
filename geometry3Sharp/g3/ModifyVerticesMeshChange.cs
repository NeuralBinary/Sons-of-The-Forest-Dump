using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000233")]
	public class ModifyVerticesMeshChange
	{
		// Token: 0x0600143E RID: 5182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x1E7BEB0", Offset = "0x1E7A4B0", VA = "0x181E7BEB0")]
		public ModifyVerticesMeshChange(DMesh3 mesh, MeshComponents wantComponents = MeshComponents.All)
		{
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0000FECC File Offset: 0x0000E0CC
		[Token(Token = "0x600143F")]
		[Address(RVA = "0x1E7BEC0", Offset = "0x1E7A4C0", VA = "0x181E7BEC0")]
		public int AppendNewVertex(DMesh3 mesh, int vid)
		{
			return 0;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001440")]
		[Address(RVA = "0x1E7C2D0", Offset = "0x1E7A8D0", VA = "0x181E7C2D0")]
		public void Apply(DMesh3 mesh)
		{
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001441")]
		[Address(RVA = "0x1E7C5E0", Offset = "0x1E7ABE0", VA = "0x181E7C5E0")]
		public void Revert(DMesh3 mesh)
		{
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001442")]
		[Address(RVA = "0x1E7C910", Offset = "0x1E7AF10", VA = "0x181E7C910")]
		private void initialize_buffers(DMesh3 mesh, MeshComponents components)
		{
		}

		// Token: 0x04000956 RID: 2390
		[Token(Token = "0x4000956")]
		[FieldOffset(Offset = "0x10")]
		public DVector<int> ModifiedV;

		// Token: 0x04000957 RID: 2391
		[Token(Token = "0x4000957")]
		[FieldOffset(Offset = "0x18")]
		public DVector<Vector3d> OldPositions;

		// Token: 0x04000958 RID: 2392
		[Token(Token = "0x4000958")]
		[FieldOffset(Offset = "0x20")]
		public DVector<Vector3d> NewPositions;

		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x4000959")]
		[FieldOffset(Offset = "0x28")]
		public DVector<Vector3f> OldNormals;

		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		[FieldOffset(Offset = "0x30")]
		public DVector<Vector3f> NewNormals;

		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		[FieldOffset(Offset = "0x38")]
		public DVector<Vector3f> OldColors;

		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x400095C")]
		[FieldOffset(Offset = "0x40")]
		public DVector<Vector3f> NewColors;

		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x400095D")]
		[FieldOffset(Offset = "0x48")]
		public DVector<Vector2f> OldUVs;

		// Token: 0x0400095E RID: 2398
		[Token(Token = "0x400095E")]
		[FieldOffset(Offset = "0x50")]
		public DVector<Vector2f> NewUVs;

		// Token: 0x0400095F RID: 2399
		[Token(Token = "0x400095F")]
		[FieldOffset(Offset = "0x58")]
		public Action<ModifyVerticesMeshChange> OnApplyF;

		// Token: 0x04000960 RID: 2400
		[Token(Token = "0x4000960")]
		[FieldOffset(Offset = "0x60")]
		public Action<ModifyVerticesMeshChange> OnRevertF;
	}
}
