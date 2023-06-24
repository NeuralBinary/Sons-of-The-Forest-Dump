using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	internal class ControlCommandStart : ControlCommand
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x8D4E40", Offset = "0x8D3440", VA = "0x1808D4E40", Slot = "4")]
		public override void Run()
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public override void Done()
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x8D4E90", Offset = "0x8D3490", VA = "0x1808D4E90")]
		public ControlCommandStart()
		{
		}

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x28")]
		public BoltConfig Config;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x30")]
		public BoltNetworkModes Mode;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x38")]
		public UdpPlatform Platform;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x40")]
		public UdpEndPoint EndPoint;
	}
}
