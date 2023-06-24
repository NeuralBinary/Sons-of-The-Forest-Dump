using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	[Serializable]
	public struct SteamNetworkingMessage_t
	{
		// Token: 0x06000AF0 RID: 2800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x98CDC0", Offset = "0x98B3C0", VA = "0x18098CDC0")]
		public void Release()
		{
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x9557C0", Offset = "0x953DC0", VA = "0x1809557C0")]
		public static void Release(IntPtr pointer)
		{
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x000097DC File Offset: 0x000079DC
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x98CE10", Offset = "0x98B410", VA = "0x18098CE10")]
		public static SteamNetworkingMessage_t FromIntPtr(IntPtr pointer)
		{
			return default(SteamNetworkingMessage_t);
		}

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr m_pData;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4000AC0")]
		[FieldOffset(Offset = "0x8")]
		public int m_cbSize;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0xC")]
		public HSteamNetConnection m_conn;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x10")]
		public SteamNetworkingIdentity m_identityPeer;

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4000AC3")]
		[FieldOffset(Offset = "0x20")]
		public long m_nConnUserData;

		// Token: 0x04000AC4 RID: 2756
		[Token(Token = "0x4000AC4")]
		[FieldOffset(Offset = "0x28")]
		public SteamNetworkingMicroseconds m_usecTimeReceived;

		// Token: 0x04000AC5 RID: 2757
		[Token(Token = "0x4000AC5")]
		[FieldOffset(Offset = "0x30")]
		public long m_nMessageNumber;

		// Token: 0x04000AC6 RID: 2758
		[Token(Token = "0x4000AC6")]
		[FieldOffset(Offset = "0x38")]
		public IntPtr m_pfnFreeData;

		// Token: 0x04000AC7 RID: 2759
		[Token(Token = "0x4000AC7")]
		[FieldOffset(Offset = "0x40")]
		internal IntPtr m_pfnRelease;

		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4000AC8")]
		[FieldOffset(Offset = "0x48")]
		public int m_nChannel;

		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		[FieldOffset(Offset = "0x4C")]
		public int m_nFlags;

		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		[FieldOffset(Offset = "0x50")]
		public long m_nUserData;

		// Token: 0x04000ACB RID: 2763
		[Token(Token = "0x4000ACB")]
		[FieldOffset(Offset = "0x58")]
		public ushort m_idxLane;

		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4000ACC")]
		[FieldOffset(Offset = "0x5A")]
		public ushort _pad1__;
	}
}
