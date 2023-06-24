using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.Inventory
{
	// Token: 0x0200061A RID: 1562
	[Token(Token = "0x200061A")]
	public class ItemInstanceBoltDataToken : IProtocolToken
	{
		// Token: 0x06002895 RID: 10389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002895")]
		[Address(RVA = "0x33E0670", Offset = "0x33DEC70", VA = "0x1833E0670", Slot = "4")]
		public void Read(UdpPacket packet)
		{
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002896")]
		[Address(RVA = "0x33E09B0", Offset = "0x33DEFB0", VA = "0x1833E09B0", Slot = "5")]
		public void Write(UdpPacket packet)
		{
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002897")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ItemInstanceBoltDataToken()
		{
		}

		// Token: 0x04002487 RID: 9351
		[Token(Token = "0x4002487")]
		[FieldOffset(Offset = "0x10")]
		public ItemInstance ItemInstance;
	}
}
