using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	internal class NetworkProperty_Float : NetworkProperty_Mecanim
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x17000110")]
		public override bool WantsOnSimulateBefore
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x8F37B0", Offset = "0x8F1DB0", VA = "0x1808F37B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x8F37C0", Offset = "0x8F1DC0", VA = "0x1808F37C0", Slot = "18")]
		public override void OnSimulateBefore(NetworkObj obj)
		{
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x8F3A30", Offset = "0x8F2030", VA = "0x1808F3A30", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x8F3B90", Offset = "0x8F2190", VA = "0x1808F3B90", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x8F3C40", Offset = "0x8F2240", VA = "0x1808F3C40")]
		public void Settings_Float(PropertyFloatCompressionSettings compression)
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x7C3310", Offset = "0x7C1910", VA = "0x1807C3310")]
		public void Settings_Float(PropertyFloatSettings settings)
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x784B50", Offset = "0x783150", VA = "0x180784B50", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x8F3C50", Offset = "0x8F2250", VA = "0x1808F3C50", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x8F3CF0", Offset = "0x8F22F0", VA = "0x1808F3CF0", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x8F3D90", Offset = "0x8F2390", VA = "0x1808F3D90", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x8F3E60", Offset = "0x8F2460", VA = "0x1808F3E60", Slot = "25")]
		protected override void PullMecanimValue(NetworkState state)
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x8F40A0", Offset = "0x8F26A0", VA = "0x1808F40A0", Slot = "26")]
		protected override void PushMecanimValue(NetworkState state)
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_Float()
		{
		}

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x58")]
		private PropertyFloatSettings Settings;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x5C")]
		private PropertyFloatCompressionSettings Compression;
	}
}
