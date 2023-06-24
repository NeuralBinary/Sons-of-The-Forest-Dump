using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	internal class NetworkProperty_Matrix4x4 : NetworkProperty
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x8F5EE0", Offset = "0x8F44E0", VA = "0x1808F5EE0", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x8F5FF0", Offset = "0x8F45F0", VA = "0x1808F5FF0", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x8F6270", Offset = "0x8F4870", VA = "0x1808F6270", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x8F6390", Offset = "0x8F4990", VA = "0x1808F6390", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x8F63A0", Offset = "0x8F49A0", VA = "0x1808F63A0", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x8F65B0", Offset = "0x8F4BB0", VA = "0x1808F65B0", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_Matrix4x4()
		{
		}
	}
}
