using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	internal class NetworkProperty_Bool : NetworkProperty_Mecanim
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x8F57B0", Offset = "0x8F3DB0", VA = "0x1808F57B0", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x8F5900", Offset = "0x8F3F00", VA = "0x1808F5900", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x8F59B0", Offset = "0x8F3FB0", VA = "0x1808F59B0", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x8F5A50", Offset = "0x8F4050", VA = "0x1808F5A50", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x8F5AD0", Offset = "0x8F40D0", VA = "0x1808F5AD0", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x8F5B50", Offset = "0x8F4150", VA = "0x1808F5B50", Slot = "25")]
		protected override void PullMecanimValue(NetworkState state)
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x8F5D70", Offset = "0x8F4370", VA = "0x1808F5D70", Slot = "26")]
		protected override void PushMecanimValue(NetworkState state)
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_Bool()
		{
		}
	}
}
