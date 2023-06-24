using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	public enum ESteamNetworkingConfigValue
	{
		// Token: 0x04000926 RID: 2342
		[Token(Token = "0x4000926")]
		k_ESteamNetworkingConfig_Invalid,
		// Token: 0x04000927 RID: 2343
		[Token(Token = "0x4000927")]
		k_ESteamNetworkingConfig_TimeoutInitial = 24,
		// Token: 0x04000928 RID: 2344
		[Token(Token = "0x4000928")]
		k_ESteamNetworkingConfig_TimeoutConnected,
		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x4000929")]
		k_ESteamNetworkingConfig_SendBufferSize = 9,
		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x400092A")]
		k_ESteamNetworkingConfig_ConnectionUserData = 40,
		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		k_ESteamNetworkingConfig_SendRateMin = 10,
		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		k_ESteamNetworkingConfig_SendRateMax,
		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		k_ESteamNetworkingConfig_NagleTime,
		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		k_ESteamNetworkingConfig_IP_AllowWithoutAuth = 23,
		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		k_ESteamNetworkingConfig_MTU_PacketSize = 32,
		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		k_ESteamNetworkingConfig_MTU_DataSize,
		// Token: 0x04000931 RID: 2353
		[Token(Token = "0x4000931")]
		k_ESteamNetworkingConfig_Unencrypted,
		// Token: 0x04000932 RID: 2354
		[Token(Token = "0x4000932")]
		k_ESteamNetworkingConfig_SymmetricConnect = 37,
		// Token: 0x04000933 RID: 2355
		[Token(Token = "0x4000933")]
		k_ESteamNetworkingConfig_LocalVirtualPort,
		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		k_ESteamNetworkingConfig_DualWifi_Enable,
		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		k_ESteamNetworkingConfig_EnableDiagnosticsUI = 46,
		// Token: 0x04000936 RID: 2358
		[Token(Token = "0x4000936")]
		k_ESteamNetworkingConfig_FakePacketLoss_Send = 2,
		// Token: 0x04000937 RID: 2359
		[Token(Token = "0x4000937")]
		k_ESteamNetworkingConfig_FakePacketLoss_Recv,
		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x4000938")]
		k_ESteamNetworkingConfig_FakePacketLag_Send,
		// Token: 0x04000939 RID: 2361
		[Token(Token = "0x4000939")]
		k_ESteamNetworkingConfig_FakePacketLag_Recv,
		// Token: 0x0400093A RID: 2362
		[Token(Token = "0x400093A")]
		k_ESteamNetworkingConfig_FakePacketReorder_Send,
		// Token: 0x0400093B RID: 2363
		[Token(Token = "0x400093B")]
		k_ESteamNetworkingConfig_FakePacketReorder_Recv,
		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		k_ESteamNetworkingConfig_FakePacketReorder_Time,
		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		k_ESteamNetworkingConfig_FakePacketDup_Send = 26,
		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		k_ESteamNetworkingConfig_FakePacketDup_Recv,
		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x400093F")]
		k_ESteamNetworkingConfig_FakePacketDup_TimeMax,
		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		k_ESteamNetworkingConfig_PacketTraceMaxBytes = 41,
		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		k_ESteamNetworkingConfig_FakeRateLimit_Send_Rate,
		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		k_ESteamNetworkingConfig_FakeRateLimit_Send_Burst,
		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x4000943")]
		k_ESteamNetworkingConfig_FakeRateLimit_Recv_Rate,
		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x4000944")]
		k_ESteamNetworkingConfig_FakeRateLimit_Recv_Burst,
		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x4000945")]
		k_ESteamNetworkingConfig_Callback_ConnectionStatusChanged = 201,
		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		k_ESteamNetworkingConfig_Callback_AuthStatusChanged,
		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		k_ESteamNetworkingConfig_Callback_RelayNetworkStatusChanged,
		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		k_ESteamNetworkingConfig_Callback_MessagesSessionRequest,
		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		k_ESteamNetworkingConfig_Callback_MessagesSessionFailed,
		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x400094A")]
		k_ESteamNetworkingConfig_Callback_CreateConnectionSignaling,
		// Token: 0x0400094B RID: 2379
		[Token(Token = "0x400094B")]
		k_ESteamNetworkingConfig_Callback_FakeIPResult,
		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		k_ESteamNetworkingConfig_P2P_STUN_ServerList = 103,
		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		k_ESteamNetworkingConfig_P2P_Transport_ICE_Enable,
		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		k_ESteamNetworkingConfig_P2P_Transport_ICE_Penalty,
		// Token: 0x0400094F RID: 2383
		[Token(Token = "0x400094F")]
		k_ESteamNetworkingConfig_P2P_Transport_SDR_Penalty,
		// Token: 0x04000950 RID: 2384
		[Token(Token = "0x4000950")]
		k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFailInitial = 19,
		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFail,
		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		k_ESteamNetworkingConfig_SDRClient_MinPingsBeforePingAccurate,
		// Token: 0x04000953 RID: 2387
		[Token(Token = "0x4000953")]
		k_ESteamNetworkingConfig_SDRClient_SingleSocket,
		// Token: 0x04000954 RID: 2388
		[Token(Token = "0x4000954")]
		k_ESteamNetworkingConfig_SDRClient_ForceRelayCluster = 29,
		// Token: 0x04000955 RID: 2389
		[Token(Token = "0x4000955")]
		k_ESteamNetworkingConfig_SDRClient_DebugTicketAddress,
		// Token: 0x04000956 RID: 2390
		[Token(Token = "0x4000956")]
		k_ESteamNetworkingConfig_SDRClient_ForceProxyAddr,
		// Token: 0x04000957 RID: 2391
		[Token(Token = "0x4000957")]
		k_ESteamNetworkingConfig_SDRClient_FakeClusterPing = 36,
		// Token: 0x04000958 RID: 2392
		[Token(Token = "0x4000958")]
		k_ESteamNetworkingConfig_LogLevel_AckRTT = 13,
		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x4000959")]
		k_ESteamNetworkingConfig_LogLevel_PacketDecode,
		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		k_ESteamNetworkingConfig_LogLevel_Message,
		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		k_ESteamNetworkingConfig_LogLevel_PacketGaps,
		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x400095C")]
		k_ESteamNetworkingConfig_LogLevel_P2PRendezvous,
		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x400095D")]
		k_ESteamNetworkingConfig_LogLevel_SDRRelayPings,
		// Token: 0x0400095E RID: 2398
		[Token(Token = "0x400095E")]
		k_ESteamNetworkingConfig_DELETED_EnumerateDevVars = 35,
		// Token: 0x0400095F RID: 2399
		[Token(Token = "0x400095F")]
		k_ESteamNetworkingConfigValue__Force32Bit = 2147483647
	}
}
