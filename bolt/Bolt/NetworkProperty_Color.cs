using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	internal class NetworkProperty_Color : NetworkProperty
	{
		// Token: 0x06000593 RID: 1427 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x8F2830", Offset = "0x8F0E30", VA = "0x1808F2830", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x8F2840", Offset = "0x8F0E40", VA = "0x1808F2840", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x8F2A00", Offset = "0x8F1000", VA = "0x1808F2A00", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x8F2AB0", Offset = "0x8F10B0", VA = "0x1808F2AB0", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x8F2B50", Offset = "0x8F1150", VA = "0x1808F2B50", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x8F2C00", Offset = "0x8F1200", VA = "0x1808F2C00", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_Color()
		{
		}
	}
}
