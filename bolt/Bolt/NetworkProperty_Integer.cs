using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	internal class NetworkProperty_Integer : NetworkProperty_Mecanim
	{
		// Token: 0x060005BC RID: 1468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x7C32E0", Offset = "0x7C18E0", VA = "0x1807C32E0")]
		public void Settings_Integer(PropertyIntCompressionSettings compression)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x8F47B0", Offset = "0x8F2DB0", VA = "0x1808F47B0", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x8F4900", Offset = "0x8F2F00", VA = "0x1808F4900", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x8F49B0", Offset = "0x8F2FB0", VA = "0x1808F49B0", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x8F4A50", Offset = "0x8F3050", VA = "0x1808F4A50", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x8F4AC0", Offset = "0x8F30C0", VA = "0x1808F4AC0", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x8F4B40", Offset = "0x8F3140", VA = "0x1808F4B40", Slot = "25")]
		protected override void PullMecanimValue(NetworkState state)
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x8F4D60", Offset = "0x8F3360", VA = "0x1808F4D60", Slot = "26")]
		protected override void PushMecanimValue(NetworkState state)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_Integer()
		{
		}

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x58")]
		private PropertyIntCompressionSettings Compression;
	}
}
