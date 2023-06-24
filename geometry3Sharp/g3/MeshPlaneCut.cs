using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002F6 RID: 758
	[Token(Token = "0x20002F6")]
	public class MeshPlaneCut
	{
		// Token: 0x060019B3 RID: 6579 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019B3")]
		[Address(RVA = "0x1F0ED20", Offset = "0x1F0D320", VA = "0x181F0ED20")]
		public MeshPlaneCut(DMesh3 mesh, Vector3d origin, Vector3d normal)
		{
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00012B54 File Offset: 0x00010D54
		[Token(Token = "0x60019B4")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "4")]
		public virtual ValidationStatus Validate()
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00012B6C File Offset: 0x00010D6C
		[Token(Token = "0x60019B5")]
		[Address(RVA = "0x1F0EDC0", Offset = "0x1F0D3C0", VA = "0x181F0EDC0", Slot = "5")]
		public virtual bool Cut()
		{
			return default(bool);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019B6")]
		[Address(RVA = "0x1F0FD50", Offset = "0x1F0E350", VA = "0x181F0FD50")]
		protected void collapse_degenerate_edges(HashSet<int> OnCutEdges, HashSet<int> ZeroEdges)
		{
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00012B84 File Offset: 0x00010D84
		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x1F101A0", Offset = "0x1F0E7A0", VA = "0x181F101A0")]
		public bool FillHoles(int constantGroupID = -1)
		{
			return default(bool);
		}

		// Token: 0x04000D6C RID: 3436
		[Token(Token = "0x4000D6C")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000D6D RID: 3437
		[Token(Token = "0x4000D6D")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d PlaneOrigin;

		// Token: 0x04000D6E RID: 3438
		[Token(Token = "0x4000D6E")]
		[FieldOffset(Offset = "0x30")]
		public Vector3d PlaneNormal;

		// Token: 0x04000D6F RID: 3439
		[Token(Token = "0x4000D6F")]
		[FieldOffset(Offset = "0x48")]
		public bool CollapseDegenerateEdgesOnCut;

		// Token: 0x04000D70 RID: 3440
		[Token(Token = "0x4000D70")]
		[FieldOffset(Offset = "0x50")]
		public double DegenerateEdgeTol;

		// Token: 0x04000D71 RID: 3441
		[Token(Token = "0x4000D71")]
		[FieldOffset(Offset = "0x58")]
		public MeshFaceSelection CutFaceSet;

		// Token: 0x04000D72 RID: 3442
		[Token(Token = "0x4000D72")]
		[FieldOffset(Offset = "0x60")]
		public List<EdgeLoop> CutLoops;

		// Token: 0x04000D73 RID: 3443
		[Token(Token = "0x4000D73")]
		[FieldOffset(Offset = "0x68")]
		public List<EdgeSpan> CutSpans;

		// Token: 0x04000D74 RID: 3444
		[Token(Token = "0x4000D74")]
		[FieldOffset(Offset = "0x70")]
		public bool CutLoopsFailed;

		// Token: 0x04000D75 RID: 3445
		[Token(Token = "0x4000D75")]
		[FieldOffset(Offset = "0x71")]
		public bool FoundOpenSpans;

		// Token: 0x04000D76 RID: 3446
		[Token(Token = "0x4000D76")]
		[FieldOffset(Offset = "0x78")]
		public List<int[]> LoopFillTriangles;
	}
}
