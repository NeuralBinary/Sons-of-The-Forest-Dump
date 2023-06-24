using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	internal class MpbPolyline2D : MetaMpb
	{
		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x2A3CD10", Offset = "0x2A3B310", VA = "0x182A3CD10", Slot = "5")]
		protected override void TransferShapeProperties()
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x2A3CDF0", Offset = "0x2A3B3F0", VA = "0x182A3CDF0")]
		public MpbPolyline2D()
		{
		}

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly List<float> alignment;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0xC8")]
		internal readonly List<float> scaleMode;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0xD0")]
		internal readonly List<float> thickness;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0xD8")]
		internal readonly List<float> thicknessSpace;
	}
}
