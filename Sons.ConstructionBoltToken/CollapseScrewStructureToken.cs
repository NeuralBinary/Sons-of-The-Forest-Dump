using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.ConstructionBoltToken
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class CollapseScrewStructureToken : IProtocolToken
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		private void Write(UdpPacket packet)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		private void Read(UdpPacket packet)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CollapseScrewStructureToken()
		{
		}
	}
}
