using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	internal class NetworkProperty_String : NetworkProperty
	{
		// Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x8F80C0", Offset = "0x8F66C0", VA = "0x1808F80C0")]
		public void AddStringSettings(StringEncodings encoding)
		{
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x8F80D0", Offset = "0x8F66D0", VA = "0x1808F80D0", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x8F82E0", Offset = "0x8F68E0", VA = "0x1808F82E0", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x8F83A0", Offset = "0x8F69A0", VA = "0x1808F83A0", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x8F8550", Offset = "0x8F6B50", VA = "0x1808F8550", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x8F85F0", Offset = "0x8F6BF0", VA = "0x1808F85F0", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x8F8770", Offset = "0x8F6D70", VA = "0x1808F8770", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_String()
		{
		}

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x48")]
		private PropertyStringSettings StringSettings;
	}
}
