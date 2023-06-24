using System;
using System.Text;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	internal struct PropertyStringSettings
	{
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000128")]
		public Encoding EncodingClass
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x8FEB60", Offset = "0x8FD160", VA = "0x1808FEB60")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x0")]
		public StringEncodings Encoding;
	}
}
