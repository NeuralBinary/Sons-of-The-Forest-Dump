using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001B4 RID: 436
	[Token(Token = "0x20001B4")]
	[Serializable]
	public struct SteamDatagramRelayAuthTicket
	{
		// Token: 0x060009F8 RID: 2552 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void Clear()
		{
		}

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SteamNetworkingIdentity m_identityGameserver;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SteamNetworkingIdentity m_identityAuthorizedClient;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint m_unPublicIP;

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private RTime32 m_rtimeTicketExpiry;

		// Token: 0x04000A75 RID: 2677
		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SteamDatagramHostedAddress m_routing;

		// Token: 0x04000A76 RID: 2678
		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private uint m_nAppID;

		// Token: 0x04000A77 RID: 2679
		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int m_nRestrictToVirtualPort;

		// Token: 0x04000A78 RID: 2680
		[Token(Token = "0x4000A78")]
		private const int k_nMaxExtraFields = 16;

		// Token: 0x04000A79 RID: 2681
		[Token(Token = "0x4000A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_nExtraFields;

		// Token: 0x04000A7A RID: 2682
		[Token(Token = "0x4000A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SteamDatagramRelayAuthTicket.ExtraField[] m_vecExtraFields;

		// Token: 0x020001B5 RID: 437
		[Token(Token = "0x20001B5")]
		private struct ExtraField
		{
			// Token: 0x04000A7B RID: 2683
			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private SteamDatagramRelayAuthTicket.ExtraField.EType m_eType;

			// Token: 0x04000A7C RID: 2684
			[Token(Token = "0x4000A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private byte[] m_szName;

			// Token: 0x04000A7D RID: 2685
			[Token(Token = "0x4000A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private SteamDatagramRelayAuthTicket.ExtraField.OptionValue m_val;

			// Token: 0x020001B6 RID: 438
			[Token(Token = "0x20001B6")]
			private enum EType
			{
				// Token: 0x04000A7F RID: 2687
				[Token(Token = "0x4000A7F")]
				k_EType_String,
				// Token: 0x04000A80 RID: 2688
				[Token(Token = "0x4000A80")]
				k_EType_Int,
				// Token: 0x04000A81 RID: 2689
				[Token(Token = "0x4000A81")]
				k_EType_Fixed64
			}

			// Token: 0x020001B7 RID: 439
			[Token(Token = "0x20001B7")]
			[StructLayout(2)]
			private struct OptionValue
			{
				// Token: 0x04000A82 RID: 2690
				[Token(Token = "0x4000A82")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private byte[] m_szStringValue;

				// Token: 0x04000A83 RID: 2691
				[Token(Token = "0x4000A83")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private long m_nIntValue;

				// Token: 0x04000A84 RID: 2692
				[Token(Token = "0x4000A84")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private ulong m_nFixed64Value;
			}
		}
	}
}
