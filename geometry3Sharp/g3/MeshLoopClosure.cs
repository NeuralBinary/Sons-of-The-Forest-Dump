using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002EA RID: 746
	[Token(Token = "0x20002EA")]
	public class MeshLoopClosure
	{
		// Token: 0x06001975 RID: 6517 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x1F07290", Offset = "0x1F05890", VA = "0x181F07290")]
		public MeshLoopClosure(DMesh3 mesh, EdgeLoop border_loop)
		{
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x0001292C File Offset: 0x00010B2C
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x1F07350", Offset = "0x1F05950", VA = "0x181F07350", Slot = "4")]
		public virtual ValidationStatus Validate()
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00012944 File Offset: 0x00010B44
		[Token(Token = "0x6001977")]
		[Address(RVA = "0x1F074C0", Offset = "0x1F05AC0", VA = "0x181F074C0", Slot = "5")]
		public virtual bool Close()
		{
			return default(bool);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001978")]
		[Address(RVA = "0x1F074E0", Offset = "0x1F05AE0", VA = "0x181F074E0")]
		public void Close_Flat()
		{
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x1F08180", Offset = "0x1F06780", VA = "0x181F08180")]
		public static void smooth_region(DMesh3 mesh, IEnumerable<int> vertices, int nRings)
		{
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x1F08370", Offset = "0x1F06970", VA = "0x181F08370")]
		public static void smooth_loop(DMesh3 mesh, EdgeLoop loop, int nRings)
		{
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600197B")]
		[Address(RVA = "0x1F08640", Offset = "0x1F06C40", VA = "0x181F08640")]
		public static void cleanup_boundary(DMesh3 mesh, EdgeLoop loop, double target_edge_len, out List<int> result_edges, int nRings = 3)
		{
		}

		// Token: 0x04000D35 RID: 3381
		[Token(Token = "0x4000D35")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000D36 RID: 3382
		[Token(Token = "0x4000D36")]
		[FieldOffset(Offset = "0x18")]
		public EdgeLoop InitialBorderLoop;

		// Token: 0x04000D37 RID: 3383
		[Token(Token = "0x4000D37")]
		[FieldOffset(Offset = "0x20")]
		public Frame3f FlatClosePlane;

		// Token: 0x04000D38 RID: 3384
		[Token(Token = "0x4000D38")]
		[FieldOffset(Offset = "0x40")]
		public double TargetEdgeLen;

		// Token: 0x04000D39 RID: 3385
		[Token(Token = "0x4000D39")]
		[FieldOffset(Offset = "0x48")]
		public int ExtrudeGroup;

		// Token: 0x04000D3A RID: 3386
		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x4C")]
		public int FillGroup;
	}
}
