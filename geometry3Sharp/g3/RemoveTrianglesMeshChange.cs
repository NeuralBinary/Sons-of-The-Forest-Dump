using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000235")]
	public class RemoveTrianglesMeshChange
	{
		// Token: 0x06001446 RID: 5190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001446")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public RemoveTrianglesMeshChange()
		{
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001447")]
		[Address(RVA = "0x1E7CF80", Offset = "0x1E7B580", VA = "0x181E7CF80")]
		public void InitializeFromApply(DMesh3 mesh, IEnumerable<int> triangles)
		{
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001448")]
		[Address(RVA = "0x1E7D310", Offset = "0x1E7B910", VA = "0x181E7D310")]
		public void InitializeFromExisting(DMesh3 mesh, IEnumerable<int> remove_t)
		{
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001449")]
		[Address(RVA = "0x1E7DC10", Offset = "0x1E7C210", VA = "0x181E7DC10")]
		public void Apply(DMesh3 mesh)
		{
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600144A")]
		[Address(RVA = "0x1E7DE60", Offset = "0x1E7C460", VA = "0x181E7DE60")]
		public void Revert(DMesh3 mesh)
		{
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0000FEE4 File Offset: 0x0000E0E4
		[Token(Token = "0x600144B")]
		[Address(RVA = "0x1E7E570", Offset = "0x1E7CB70", VA = "0x181E7E570")]
		private bool save_vertex(DMesh3 mesh, int vid, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600144C")]
		[Address(RVA = "0x1E7E740", Offset = "0x1E7CD40", VA = "0x181E7E740")]
		private void initialize_buffers(DMesh3 mesh)
		{
		}

		// Token: 0x0400096B RID: 2411
		[Token(Token = "0x400096B")]
		[FieldOffset(Offset = "0x10")]
		protected DVector<int> RemovedV;

		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x18")]
		protected DVector<Vector3d> Positions;

		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x20")]
		protected DVector<Vector3f> Normals;

		// Token: 0x0400096E RID: 2414
		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0x28")]
		protected DVector<Vector3f> Colors;

		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x30")]
		protected DVector<Vector2f> UVs;

		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x38")]
		protected DVector<int> RemovedT;

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x40")]
		protected DVector<Index4i> Triangles;

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x48")]
		public Action<IEnumerable<int>, IEnumerable<int>> OnApplyF;

		// Token: 0x04000973 RID: 2419
		[Token(Token = "0x4000973")]
		[FieldOffset(Offset = "0x50")]
		public Action<IEnumerable<int>, IEnumerable<int>> OnRevertF;
	}
}
