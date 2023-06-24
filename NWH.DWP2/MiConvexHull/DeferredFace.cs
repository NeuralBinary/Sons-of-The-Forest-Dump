using System;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	internal sealed class DeferredFace
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DeferredFace()
		{
		}

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x10")]
		public ConvexFaceInternal Face;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x18")]
		public ConvexFaceInternal Pivot;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x20")]
		public ConvexFaceInternal OldFace;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x28")]
		public int FaceIndex;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x2C")]
		public int PivotIndex;
	}
}
