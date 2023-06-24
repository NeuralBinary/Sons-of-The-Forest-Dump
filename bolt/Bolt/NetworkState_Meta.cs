using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	internal abstract class NetworkState_Meta : NetworkObj_Meta
	{
		// Token: 0x06000679 RID: 1657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
		protected NetworkState_Meta()
		{
		}

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x78")]
		public int PropertyIdBits;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x7C")]
		public int PacketMaxBits;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x80")]
		public int PacketMaxProperties;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x84")]
		public int PacketMaxPropertiesBits;
	}
}
