using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	internal class NetworkProperty_Quaternion : NetworkProperty
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x1700011A")]
		public override bool WantsOnSimulateBefore
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x8F37B0", Offset = "0x8F1DB0", VA = "0x1808F37B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x8F7820", Offset = "0x8F5E20", VA = "0x1808F7820")]
		public void Settings_Quaternion(PropertyFloatCompressionSettings compression, bool strict)
		{
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x8F7890", Offset = "0x8F5E90", VA = "0x1808F7890")]
		public void Settings_QuaternionEuler(PropertyFloatCompressionSettings x, PropertyFloatCompressionSettings y, PropertyFloatCompressionSettings z, bool strict)
		{
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x8F7950", Offset = "0x8F5F50", VA = "0x1808F7950", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x8F7B00", Offset = "0x8F6100", VA = "0x1808F7B00", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x8F7BB0", Offset = "0x8F61B0", VA = "0x1808F7BB0", Slot = "16")]
		public override void OnInit(NetworkObj obj)
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x8F7C50", Offset = "0x8F6250", VA = "0x1808F7C50", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x8F7CF0", Offset = "0x8F62F0", VA = "0x1808F7CF0", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x8F7D10", Offset = "0x8F6310", VA = "0x1808F7D10", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x8F7D80", Offset = "0x8F6380", VA = "0x1808F7D80", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x8F7E50", Offset = "0x8F6450", VA = "0x1808F7E50", Slot = "18")]
		public override void OnSimulateBefore(NetworkObj obj)
		{
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_Quaternion()
		{
		}

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x48")]
		private PropertyQuaternionCompression Compression;
	}
}
