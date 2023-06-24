using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	internal class NetworkProperty_NetworkId : NetworkProperty
	{
		// Token: 0x060005FF RID: 1535 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x8F68A0", Offset = "0x8F4EA0", VA = "0x1808F68A0", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x8F6940", Offset = "0x8F4F40", VA = "0x1808F6940", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x8F6A90", Offset = "0x8F5090", VA = "0x1808F6A90", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x8F3120", Offset = "0x8F1720", VA = "0x1808F3120", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x8F35A0", Offset = "0x8F1BA0", VA = "0x1808F35A0", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x8F36B0", Offset = "0x8F1CB0", VA = "0x1808F36B0", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_NetworkId()
		{
		}
	}
}
