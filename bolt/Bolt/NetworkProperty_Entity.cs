using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	internal class NetworkProperty_Entity : NetworkProperty
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x8F3120", Offset = "0x8F1720", VA = "0x1808F3120", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x8F3130", Offset = "0x8F1730", VA = "0x1808F3130", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x8F33F0", Offset = "0x8F19F0", VA = "0x1808F33F0", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x8F34B0", Offset = "0x8F1AB0", VA = "0x1808F34B0", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x8F35A0", Offset = "0x8F1BA0", VA = "0x1808F35A0", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x8F36B0", Offset = "0x8F1CB0", VA = "0x1808F36B0", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_Entity()
		{
		}
	}
}
