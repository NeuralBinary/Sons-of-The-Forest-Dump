using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	internal class NetworkProperty_Trigger : NetworkProperty_Mecanim
	{
		// Token: 0x06000641 RID: 1601 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x8FC790", Offset = "0x8FAD90", VA = "0x1808FC790", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x1700011F")]
		public override bool AllowCallbacks
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x17000120")]
		public override bool WantsOnFrameCloned
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x8FC7C0", Offset = "0x8FADC0", VA = "0x1808FC7C0", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x8FC800", Offset = "0x8FAE00", VA = "0x1808FC800", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x8FC950", Offset = "0x8FAF50", VA = "0x1808FC950", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x8FCAD0", Offset = "0x8FB0D0", VA = "0x1808FCAD0", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x8FCBA0", Offset = "0x8FB1A0", VA = "0x1808FCBA0", Slot = "19")]
		public override void OnSimulateAfter(NetworkObj obj)
		{
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x8FCC60", Offset = "0x8FB260", VA = "0x1808FCC60", Slot = "21")]
		public override void OnFrameCloned(NetworkObj obj, NetworkStorage storage)
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x8FCCE0", Offset = "0x8FB2E0", VA = "0x1808FCCE0")]
		private void MecanimPull(NetworkObj obj, NetworkStorage storage)
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x8FCFB0", Offset = "0x8FB5B0", VA = "0x1808FCFB0")]
		private void MecanimPush(NetworkObj obj, bool push)
		{
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_Trigger()
		{
		}
	}
}
