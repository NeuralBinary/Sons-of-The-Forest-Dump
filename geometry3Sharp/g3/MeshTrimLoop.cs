using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002F8 RID: 760
	[Token(Token = "0x20002F8")]
	public class MeshTrimLoop
	{
		// Token: 0x060019BB RID: 6587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019BB")]
		[Address(RVA = "0x1F106C0", Offset = "0x1F0ECC0", VA = "0x181F106C0")]
		public MeshTrimLoop(DMesh3 mesh, DCurve3 trimline, int tSeedTID, [Optional] DMeshAABBTree3 spatial)
		{
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019BC")]
		[Address(RVA = "0x1F10910", Offset = "0x1F0EF10", VA = "0x181F10910")]
		public MeshTrimLoop(DMesh3 mesh, DCurve3 trimline, Vector3d vSeedPt, [Optional] DMeshAABBTree3 spatial)
		{
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00012BB4 File Offset: 0x00010DB4
		[Token(Token = "0x60019BD")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "4")]
		public virtual ValidationStatus Validate()
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x00012BCC File Offset: 0x00010DCC
		[Token(Token = "0x60019BE")]
		[Address(RVA = "0x1F10B60", Offset = "0x1F0F160", VA = "0x181F10B60", Slot = "5")]
		public virtual bool Trim()
		{
			return default(bool);
		}

		// Token: 0x04000D7C RID: 3452
		[Token(Token = "0x4000D7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000D7D RID: 3453
		[Token(Token = "0x4000D7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DMeshAABBTree3 Spatial;

		// Token: 0x04000D7E RID: 3454
		[Token(Token = "0x4000D7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DCurve3 TrimLine;

		// Token: 0x04000D7F RID: 3455
		[Token(Token = "0x4000D7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int RemeshBorderRings;

		// Token: 0x04000D80 RID: 3456
		[Token(Token = "0x4000D80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double SmoothingAlpha;

		// Token: 0x04000D81 RID: 3457
		[Token(Token = "0x4000D81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public double TargetEdgeLength;

		// Token: 0x04000D82 RID: 3458
		[Token(Token = "0x4000D82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int RemeshRounds;

		// Token: 0x04000D83 RID: 3459
		[Token(Token = "0x4000D83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int seed_tri;

		// Token: 0x04000D84 RID: 3460
		[Token(Token = "0x4000D84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3d seed_pt;
	}
}
