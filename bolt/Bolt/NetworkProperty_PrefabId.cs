using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	internal class NetworkProperty_PrefabId : NetworkProperty
	{
		// Token: 0x06000606 RID: 1542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x8F6B40", Offset = "0x8F5140", VA = "0x1808F6B40", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x8F6BE0", Offset = "0x8F51E0", VA = "0x1808F6BE0", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x8F6D30", Offset = "0x8F5330", VA = "0x1808F6D30", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x8F2830", Offset = "0x8F0E30", VA = "0x1808F2830", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x8F6DE0", Offset = "0x8F53E0", VA = "0x1808F6DE0", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x8F6E90", Offset = "0x8F5490", VA = "0x1808F6E90", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_PrefabId()
		{
		}
	}
}
