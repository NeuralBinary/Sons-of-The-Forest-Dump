using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	internal class MpbCone : MetaMpb
	{
		// Token: 0x06000ABD RID: 2749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x2A3B330", Offset = "0x2A39930", VA = "0x182A3B330", Slot = "5")]
		protected override void TransferShapeProperties()
		{
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x2A3B3E0", Offset = "0x2A399E0", VA = "0x182A3B3E0")]
		public MpbCone()
		{
		}

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly List<float> length;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0xC8")]
		internal readonly List<float> radius;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0xD0")]
		internal readonly List<float> sizeSpace;
	}
}
