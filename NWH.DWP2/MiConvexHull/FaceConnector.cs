using System;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	internal sealed class FaceConnector
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x271E950", Offset = "0x271CF50", VA = "0x18271E950")]
		public FaceConnector(int dimension)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x271E9E0", Offset = "0x271CFE0", VA = "0x18271E9E0")]
		public void Update(ConvexFaceInternal face, int edgeIndex, int dim)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x271EB40", Offset = "0x271D140", VA = "0x18271EB40")]
		public static bool AreConnectable(FaceConnector a, FaceConnector b, int dim)
		{
			return default(bool);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x271EBC0", Offset = "0x271D1C0", VA = "0x18271EBC0")]
		public static void Connect(FaceConnector a, FaceConnector b)
		{
		}

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x10")]
		public int EdgeIndex;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x18")]
		public ConvexFaceInternal Face;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x20")]
		public uint HashCode;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x28")]
		public FaceConnector Next;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x30")]
		public FaceConnector Previous;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x38")]
		public int[] Vertices;
	}
}
