using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	internal class MpbSphere : MetaMpb
	{
		// Token: 0x06000B03 RID: 2819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x2A3E350", Offset = "0x2A3C950", VA = "0x182A3E350", Slot = "5")]
		protected override void TransferShapeProperties()
		{
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x2A3E3E0", Offset = "0x2A3C9E0", VA = "0x182A3E3E0")]
		public MpbSphere()
		{
		}

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly List<float> radius;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0xC8")]
		internal readonly List<float> radiusSpace;
	}
}
