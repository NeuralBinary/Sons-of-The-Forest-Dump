using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000236 RID: 566
	[Token(Token = "0x2000236")]
	public class AddTrianglesMeshChange
	{
		// Token: 0x0600144D RID: 5197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600144D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public AddTrianglesMeshChange()
		{
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600144E")]
		[Address(RVA = "0x1E7EB30", Offset = "0x1E7D130", VA = "0x181E7EB30")]
		public void InitializeFromExisting(DMesh3 mesh, IEnumerable<int> added_v, IEnumerable<int> added_t)
		{
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600144F")]
		[Address(RVA = "0x1E7F140", Offset = "0x1E7D740", VA = "0x181E7F140")]
		public void Apply(DMesh3 mesh)
		{
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x1E7F850", Offset = "0x1E7DE50", VA = "0x181E7F850")]
		public void Revert(DMesh3 mesh)
		{
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001451")]
		[Address(RVA = "0x1E7FAA0", Offset = "0x1E7E0A0", VA = "0x181E7FAA0")]
		private void append_vertex(DMesh3 mesh, int vid)
		{
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001452")]
		[Address(RVA = "0x1E7FC30", Offset = "0x1E7E230", VA = "0x181E7FC30")]
		private void initialize_buffers(DMesh3 mesh)
		{
		}

		// Token: 0x04000974 RID: 2420
		[Token(Token = "0x4000974")]
		[FieldOffset(Offset = "0x10")]
		protected DVector<int> AddedV;

		// Token: 0x04000975 RID: 2421
		[Token(Token = "0x4000975")]
		[FieldOffset(Offset = "0x18")]
		protected DVector<Vector3d> Positions;

		// Token: 0x04000976 RID: 2422
		[Token(Token = "0x4000976")]
		[FieldOffset(Offset = "0x20")]
		protected DVector<Vector3f> Normals;

		// Token: 0x04000977 RID: 2423
		[Token(Token = "0x4000977")]
		[FieldOffset(Offset = "0x28")]
		protected DVector<Vector3f> Colors;

		// Token: 0x04000978 RID: 2424
		[Token(Token = "0x4000978")]
		[FieldOffset(Offset = "0x30")]
		protected DVector<Vector2f> UVs;

		// Token: 0x04000979 RID: 2425
		[Token(Token = "0x4000979")]
		[FieldOffset(Offset = "0x38")]
		protected DVector<int> AddedT;

		// Token: 0x0400097A RID: 2426
		[Token(Token = "0x400097A")]
		[FieldOffset(Offset = "0x40")]
		protected DVector<Index4i> Triangles;

		// Token: 0x0400097B RID: 2427
		[Token(Token = "0x400097B")]
		[FieldOffset(Offset = "0x48")]
		public Action<IEnumerable<int>, IEnumerable<int>> OnApplyF;

		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x400097C")]
		[FieldOffset(Offset = "0x50")]
		public Action<IEnumerable<int>, IEnumerable<int>> OnRevertF;
	}
}
