using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000272 RID: 626
	[Token(Token = "0x2000272")]
	public class MeshRefinerBase
	{
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x00010C94 File Offset: 0x0000EE94
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700037E")]
		public double EdgeFlipTolerance
		{
			[Token(Token = "0x600160C")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600160D")]
			[Address(RVA = "0x1EA3230", Offset = "0x1EA1830", VA = "0x181EA3230")]
			set
			{
			}
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600160E")]
		[Address(RVA = "0x1EA32A0", Offset = "0x1EA18A0", VA = "0x181EA32A0")]
		public MeshRefinerBase(DMesh3 mesh)
		{
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600160F")]
		[Address(RVA = "0x1EA3300", Offset = "0x1EA1900", VA = "0x181EA3300")]
		protected MeshRefinerBase()
		{
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700037F")]
		public DMesh3 Mesh
		{
			[Token(Token = "0x6001610")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000380")]
		public MeshConstraints Constraints
		{
			[Token(Token = "0x6001611")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public void SetExternalConstraints(MeshConstraints cons)
		{
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00010CAC File Offset: 0x0000EEAC
		[Token(Token = "0x6001613")]
		[Address(RVA = "0x1EA3310", Offset = "0x1EA1910", VA = "0x181EA3310", Slot = "4")]
		protected virtual bool Cancelled()
		{
			return default(bool);
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00010CC4 File Offset: 0x0000EEC4
		[Token(Token = "0x6001614")]
		[Address(RVA = "0x1EA3380", Offset = "0x1EA1980", VA = "0x181EA3380")]
		protected double edge_flip_metric(ref Vector3d n0, ref Vector3d n1)
		{
			return 0.0;
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00010CDC File Offset: 0x0000EEDC
		[Token(Token = "0x6001615")]
		[Address(RVA = "0x1EA3440", Offset = "0x1EA1A40", VA = "0x181EA3440")]
		protected bool collapse_creates_flip_or_invalid(int vid, int vother, ref Vector3d newv, int tc, int td)
		{
			return default(bool);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		[Token(Token = "0x6001616")]
		[Address(RVA = "0x1EA3D30", Offset = "0x1EA2330", VA = "0x181EA3D30")]
		protected bool flip_inverts_normals(int a, int b, int c, int d, int t0)
		{
			return default(bool);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00010D0C File Offset: 0x0000EF0C
		[Token(Token = "0x6001617")]
		[Address(RVA = "0x1EA4530", Offset = "0x1EA2B30", VA = "0x181EA4530")]
		protected bool can_collapse_constraints(int eid, int a, int b, int c, int d, int tc, int td, out int collapse_to)
		{
			return default(bool);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00010D24 File Offset: 0x0000EF24
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x1EA4760", Offset = "0x1EA2D60", VA = "0x181EA4760")]
		protected bool can_collapse_vtx(int eid, int a, int b, out int collapse_to)
		{
			return default(bool);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00010D3C File Offset: 0x0000EF3C
		[Token(Token = "0x6001619")]
		[Address(RVA = "0x1EA48D0", Offset = "0x1EA2ED0", VA = "0x181EA48D0")]
		protected bool vertex_is_fixed(int vid)
		{
			return default(bool);
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00010D54 File Offset: 0x0000EF54
		[Token(Token = "0x600161A")]
		[Address(RVA = "0x1EA4900", Offset = "0x1EA2F00", VA = "0x181EA4900")]
		protected bool vertex_is_constrained(int vid)
		{
			return default(bool);
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00010D6C File Offset: 0x0000EF6C
		[Token(Token = "0x600161B")]
		[Address(RVA = "0x1EA4950", Offset = "0x1EA2F50", VA = "0x181EA4950")]
		protected VertexConstraint get_vertex_constraint(int vid)
		{
			return default(VertexConstraint);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00010D84 File Offset: 0x0000EF84
		[Token(Token = "0x600161C")]
		[Address(RVA = "0x1EA49E0", Offset = "0x1EA2FE0", VA = "0x181EA49E0")]
		protected bool get_vertex_constraint(int vid, ref VertexConstraint vc)
		{
			return default(bool);
		}

		// Token: 0x04000A62 RID: 2658
		[Token(Token = "0x4000A62")]
		[FieldOffset(Offset = "0x10")]
		protected DMesh3 mesh;

		// Token: 0x04000A63 RID: 2659
		[Token(Token = "0x4000A63")]
		[FieldOffset(Offset = "0x18")]
		protected MeshConstraints constraints;

		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4000A64")]
		[FieldOffset(Offset = "0x20")]
		public bool AllowCollapseFixedVertsWithSameSetID;

		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		[FieldOffset(Offset = "0x28")]
		protected double edge_flip_tol;

		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		[FieldOffset(Offset = "0x30")]
		public ProgressCancel Progress;
	}
}
