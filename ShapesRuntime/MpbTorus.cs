using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	internal class MpbTorus : MetaMpb
	{
		// Token: 0x06000B05 RID: 2821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x2A3E4E0", Offset = "0x2A3CAE0", VA = "0x182A3E4E0", Slot = "5")]
		protected override void TransferShapeProperties()
		{
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x2A3E630", Offset = "0x2A3CC30", VA = "0x182A3E630")]
		public MpbTorus()
		{
		}

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly List<float> angleEnd;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0xC8")]
		internal readonly List<float> angleStart;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0xD0")]
		internal readonly List<float> radius;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0xD8")]
		internal readonly List<float> radiusSpace;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0xE0")]
		internal readonly List<float> scaleMode;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0xE8")]
		internal readonly List<float> thickness;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0xF0")]
		internal readonly List<float> thicknessSpace;
	}
}
