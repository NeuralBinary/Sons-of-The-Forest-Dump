using System;
using System.Collections.Generic;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	public class RemoveOccludedTriangles
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1E0FA60", Offset = "0x1E0E060", VA = "0x181E0FA60", Slot = "4")]
		protected virtual bool Cancelled()
		{
			return default(bool);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1E0FAD0", Offset = "0x1E0E0D0", VA = "0x181E0FAD0")]
		public RemoveOccludedTriangles(DMesh3 mesh)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1E0FB40", Offset = "0x1E0E140", VA = "0x181E0FB40")]
		public RemoveOccludedTriangles(DMesh3 mesh, DMeshAABBTree3 spatial)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1E0FC10", Offset = "0x1E0E210", VA = "0x181E0FC10", Slot = "5")]
		public virtual bool Apply()
		{
			return default(bool);
		}

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x18")]
		public DMeshAABBTree3 Spatial;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x20")]
		public List<int> RemovedT;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x28")]
		public bool RemoveFailed;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x29")]
		public bool PerVertex;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x30")]
		public double NormalOffset;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x38")]
		public double WindingIsoValue;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x40")]
		public RemoveOccludedTriangles.CalculationMode InsideMode;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x48")]
		public ProgressCancel Progress;

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		public enum CalculationMode
		{
			// Token: 0x040000C7 RID: 199
			[Token(Token = "0x40000C7")]
			RayParity,
			// Token: 0x040000C8 RID: 200
			[Token(Token = "0x40000C8")]
			AnalyticWindingNumber,
			// Token: 0x040000C9 RID: 201
			[Token(Token = "0x40000C9")]
			FastWindingNumber,
			// Token: 0x040000CA RID: 202
			[Token(Token = "0x40000CA")]
			SimpleOcclusionTest
		}
	}
}
