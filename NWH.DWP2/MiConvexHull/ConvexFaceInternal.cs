using System;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	internal sealed class ConvexFaceInternal
	{
		// Token: 0x060001EC RID: 492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x271EC40", Offset = "0x271D240", VA = "0x18271EC40")]
		public ConvexFaceInternal(int dimension, int index, IndexBuffer beyondList)
		{
		}

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x10")]
		public int[] AdjacentFaces;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x18")]
		public int FurthestVertex;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x1C")]
		public int Index;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x20")]
		public bool InList;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x21")]
		public bool IsNormalFlipped;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x28")]
		public ConvexFaceInternal Next;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x30")]
		public double[] Normal;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x38")]
		public double Offset;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x40")]
		public ConvexFaceInternal Previous;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x48")]
		public int Tag;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x50")]
		public int[] Vertices;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x58")]
		public IndexBuffer VerticesBeyond;
	}
}
