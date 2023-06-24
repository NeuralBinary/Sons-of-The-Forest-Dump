using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	internal class NetworkProperty_Vector : NetworkProperty
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x17000121")]
		public override bool WantsOnSimulateBefore
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x8F37B0", Offset = "0x8F1DB0", VA = "0x1808F37B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x8FD430", Offset = "0x8FBA30", VA = "0x1808FD430", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x8FD4E0", Offset = "0x8FBAE0", VA = "0x1808FD4E0", Slot = "14")]
		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x8FD6A0", Offset = "0x8FBCA0", VA = "0x1808FD6A0")]
		public void Settings_Vector(PropertyFloatCompressionSettings x, PropertyFloatCompressionSettings y, PropertyFloatCompressionSettings z, bool strict)
		{
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x8FD700", Offset = "0x8FBD00", VA = "0x1808FD700", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x8FD7B0", Offset = "0x8FBDB0", VA = "0x1808FD7B0", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x8FD7C0", Offset = "0x8FBDC0", VA = "0x1808FD7C0", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x8FD840", Offset = "0x8FBE40", VA = "0x1808FD840", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x8FD980", Offset = "0x8FBF80", VA = "0x1808FD980", Slot = "24")]
		public override void SmoothCommandCorrection(NetworkObj obj, NetworkStorage from, NetworkStorage to, NetworkStorage storage, float t)
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x8FDC20", Offset = "0x8FC220", VA = "0x1808FDC20", Slot = "18")]
		public override void OnSimulateBefore(NetworkObj obj)
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_Vector()
		{
		}

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x48")]
		private PropertyVectorCompressionSettings Compression;
	}
}
