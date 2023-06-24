using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public static class SteamNetworkingMessages
	{
		// Token: 0x06000328 RID: 808 RVA: 0x00005C9C File Offset: 0x00003E9C
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x93B7B0", Offset = "0x939DB0", VA = "0x18093B7B0")]
		public static EResult SendMessageToUser(ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00005CB4 File Offset: 0x00003EB4
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x93B950", Offset = "0x939F50", VA = "0x18093B950")]
		public static int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr[] ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00005CCC File Offset: 0x00003ECC
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x93BA40", Offset = "0x93A040", VA = "0x18093BA40")]
		public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote)
		{
			return default(bool);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00005CE4 File Offset: 0x00003EE4
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x93BBB0", Offset = "0x93A1B0", VA = "0x18093BBB0")]
		public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote)
		{
			return default(bool);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00005CFC File Offset: 0x00003EFC
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x93BD20", Offset = "0x93A320", VA = "0x18093BD20")]
		public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel)
		{
			return default(bool);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00005D14 File Offset: 0x00003F14
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x93BEA0", Offset = "0x93A4A0", VA = "0x18093BEA0")]
		public static ESteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus)
		{
			return ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_None;
		}
	}
}
