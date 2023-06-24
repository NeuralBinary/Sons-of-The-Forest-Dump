using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	internal class NetworkProperty_ProtocolToken : NetworkProperty
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x8F6F50", Offset = "0x8F5550", VA = "0x1808F6F50", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x8F7160", Offset = "0x8F5760", VA = "0x1808F7160", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x8F7230", Offset = "0x8F5830", VA = "0x1808F7230", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x8F7380", Offset = "0x8F5980", VA = "0x1808F7380", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x8F7750", Offset = "0x8F5D50", VA = "0x1808F7750", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_ProtocolToken()
		{
		}
	}
}
