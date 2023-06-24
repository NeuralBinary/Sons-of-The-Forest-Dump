using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	internal class NetworkProperty_Color32 : NetworkProperty
	{
		// Token: 0x0600059A RID: 1434 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x8F2CF0", Offset = "0x8F12F0", VA = "0x1808F2CF0", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x8F2D90", Offset = "0x8F1390", VA = "0x1808F2D90", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x8F2F10", Offset = "0x8F1510", VA = "0x1808F2F10", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x8F2FC0", Offset = "0x8F15C0", VA = "0x1808F2FC0", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x8F2FD0", Offset = "0x8F15D0", VA = "0x1808F2FD0", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x8F3030", Offset = "0x8F1630", VA = "0x1808F3030", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_Color32()
		{
		}
	}
}
