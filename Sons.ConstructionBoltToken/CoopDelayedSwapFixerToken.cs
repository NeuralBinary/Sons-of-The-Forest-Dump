using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.ConstructionBoltToken
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class CoopDelayedSwapFixerToken : IProtocolToken
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2DBDAE0", Offset = "0x2DBC0E0", VA = "0x182DBDAE0", Slot = "5")]
		private void Write(UdpPacket packet)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2DBDB30", Offset = "0x2DBC130", VA = "0x182DBDB30", Slot = "4")]
		private void Read(UdpPacket packet)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CoopDelayedSwapFixerToken()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		public int SwapNum;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		public BoltEntity From;
	}
}
