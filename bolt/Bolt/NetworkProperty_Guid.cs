using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	internal class NetworkProperty_Guid : NetworkProperty
	{
		// Token: 0x060005B5 RID: 1461 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x8F42E0", Offset = "0x8F28E0", VA = "0x1808F42E0", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x8F4380", Offset = "0x8F2980", VA = "0x1808F4380", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x8F4520", Offset = "0x8F2B20", VA = "0x1808F4520", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x8F2FC0", Offset = "0x8F15C0", VA = "0x1808F2FC0", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x8F45D0", Offset = "0x8F2BD0", VA = "0x1808F45D0", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x8F4660", Offset = "0x8F2C60", VA = "0x1808F4660", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_Guid()
		{
		}
	}
}
