using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	public struct AffineTransform
	{
		// Token: 0x0600072C RID: 1836 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x27D47A0", Offset = "0x27D2DA0", VA = "0x1827D47A0")]
		public AffineTransform(Vector4 translation, Quaternion rotation, Vector4 scale)
		{
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x27D47D0", Offset = "0x27D2DD0", VA = "0x1827D47D0")]
		public void FromTransform(Transform source, bool is2D = false)
		{
		}

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0x0")]
		public Vector4 translation;

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x10")]
		public Vector4 scale;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x20")]
		public Quaternion rotation;
	}
}
