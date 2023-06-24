using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.ConstructionBoltToken
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class HeldScrewStructureProxyToken : IProtocolToken
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2DBEA60", Offset = "0x2DBD060", VA = "0x182DBEA60", Slot = "5")]
		private void Write(UdpPacket packet)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2DBEA80", Offset = "0x2DBD080", VA = "0x182DBEA80", Slot = "4")]
		private void Read(UdpPacket packet)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public HeldScrewStructureProxyToken()
		{
		}

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x10")]
		public BoltEntity TargetPlayer;
	}
}
