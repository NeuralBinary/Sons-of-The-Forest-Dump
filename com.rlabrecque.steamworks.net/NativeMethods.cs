using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	internal static class NativeMethods
	{
		// Token: 0x06000494 RID: 1172
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x951450", Offset = "0x94FA50", VA = "0x180951450")]
		[PreserveSig]
		public static extern bool SteamAPI_Init();

		// Token: 0x06000495 RID: 1173
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x9514C0", Offset = "0x94FAC0", VA = "0x1809514C0")]
		[PreserveSig]
		public static extern void SteamAPI_Shutdown();

		// Token: 0x06000496 RID: 1174
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x951530", Offset = "0x94FB30", VA = "0x180951530")]
		[PreserveSig]
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

		// Token: 0x06000497 RID: 1175
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x9515B0", Offset = "0x94FBB0", VA = "0x1809515B0")]
		[PreserveSig]
		public static extern void SteamAPI_ReleaseCurrentThreadMemory();

		// Token: 0x06000498 RID: 1176
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x951620", Offset = "0x94FC20", VA = "0x180951620")]
		[PreserveSig]
		public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID);

		// Token: 0x06000499 RID: 1177
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x9516C0", Offset = "0x94FCC0", VA = "0x1809516C0")]
		[PreserveSig]
		public static extern void SteamAPI_SetMiniDumpComment(InteropHelp.UTF8StringHandle pchMsg);

		// Token: 0x0600049A RID: 1178
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x951780", Offset = "0x94FD80", VA = "0x180951780")]
		[PreserveSig]
		public static extern void SteamAPI_RunCallbacks();

		// Token: 0x0600049B RID: 1179
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x9517F0", Offset = "0x94FDF0", VA = "0x1809517F0")]
		[PreserveSig]
		public static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback);

		// Token: 0x0600049C RID: 1180
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x951880", Offset = "0x94FE80", VA = "0x180951880")]
		[PreserveSig]
		public static extern void SteamAPI_UnregisterCallback(IntPtr pCallback);

		// Token: 0x0600049D RID: 1181
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x951900", Offset = "0x94FF00", VA = "0x180951900")]
		[PreserveSig]
		public static extern void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall);

		// Token: 0x0600049E RID: 1182
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x951990", Offset = "0x94FF90", VA = "0x180951990")]
		[PreserveSig]
		public static extern void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall);

		// Token: 0x0600049F RID: 1183
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x951A20", Offset = "0x950020", VA = "0x180951A20")]
		[PreserveSig]
		public static extern bool SteamAPI_IsSteamRunning();

		// Token: 0x060004A0 RID: 1184
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x951A90", Offset = "0x950090", VA = "0x180951A90")]
		[PreserveSig]
		public static extern int SteamAPI_GetSteamInstallPath();

		// Token: 0x060004A1 RID: 1185
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x951B00", Offset = "0x950100", VA = "0x180951B00")]
		[PreserveSig]
		public static extern int SteamAPI_GetHSteamPipe();

		// Token: 0x060004A2 RID: 1186
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x951B70", Offset = "0x950170", VA = "0x180951B70")]
		[PreserveSig]
		public static extern void SteamAPI_SetTryCatchCallbacks(bool bTryCatchCallbacks);

		// Token: 0x060004A3 RID: 1187
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x951BF0", Offset = "0x9501F0", VA = "0x180951BF0")]
		[PreserveSig]
		public static extern int SteamAPI_GetHSteamUser();

		// Token: 0x060004A4 RID: 1188
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x951C60", Offset = "0x950260", VA = "0x180951C60")]
		[PreserveSig]
		public static extern IntPtr SteamInternal_ContextInit(IntPtr pContextInitData);

		// Token: 0x060004A5 RID: 1189
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x951CE0", Offset = "0x9502E0", VA = "0x180951CE0")]
		[PreserveSig]
		public static extern IntPtr SteamInternal_CreateInterface(InteropHelp.UTF8StringHandle ver);

		// Token: 0x060004A6 RID: 1190
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x951DB0", Offset = "0x9503B0", VA = "0x180951DB0")]
		[PreserveSig]
		public static extern IntPtr SteamInternal_FindOrCreateUserInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion);

		// Token: 0x060004A7 RID: 1191
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x951E90", Offset = "0x950490", VA = "0x180951E90")]
		[PreserveSig]
		public static extern IntPtr SteamInternal_FindOrCreateGameServerInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion);

		// Token: 0x060004A8 RID: 1192
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x951F70", Offset = "0x950570", VA = "0x180951F70")]
		[PreserveSig]
		public static extern void SteamAPI_UseBreakpadCrashHandler(InteropHelp.UTF8StringHandle pchVersion, InteropHelp.UTF8StringHandle pchDate, InteropHelp.UTF8StringHandle pchTime, bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback);

		// Token: 0x060004A9 RID: 1193
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x952140", Offset = "0x950740", VA = "0x180952140")]
		[PreserveSig]
		public static extern void SteamAPI_SetBreakpadAppID(uint unAppID);

		// Token: 0x060004AA RID: 1194
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x9521C0", Offset = "0x9507C0", VA = "0x1809521C0")]
		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_Init();

		// Token: 0x060004AB RID: 1195
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x952230", Offset = "0x950830", VA = "0x180952230")]
		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe);

		// Token: 0x060004AC RID: 1196
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x9522B0", Offset = "0x9508B0", VA = "0x1809522B0")]
		[PreserveSig]
		public static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, IntPtr pCallbackMsg);

		// Token: 0x060004AD RID: 1197
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x952340", Offset = "0x950940", VA = "0x180952340")]
		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe);

		// Token: 0x060004AE RID: 1198
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x9523C0", Offset = "0x9509C0", VA = "0x1809523C0")]
		[PreserveSig]
		public static extern bool SteamAPI_ManualDispatch_GetAPICallResult(HSteamPipe hSteamPipe, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		// Token: 0x060004AF RID: 1199
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x9524A0", Offset = "0x950AA0", VA = "0x1809524A0")]
		[PreserveSig]
		public static extern void SteamGameServer_Shutdown();

		// Token: 0x060004B0 RID: 1200
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x952510", Offset = "0x950B10", VA = "0x180952510")]
		[PreserveSig]
		public static extern void SteamGameServer_RunCallbacks();

		// Token: 0x060004B1 RID: 1201
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x952580", Offset = "0x950B80", VA = "0x180952580")]
		[PreserveSig]
		public static extern void SteamGameServer_ReleaseCurrentThreadMemory();

		// Token: 0x060004B2 RID: 1202
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x9525F0", Offset = "0x950BF0", VA = "0x1809525F0")]
		[PreserveSig]
		public static extern bool SteamGameServer_BSecure();

		// Token: 0x060004B3 RID: 1203
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x952660", Offset = "0x950C60", VA = "0x180952660")]
		[PreserveSig]
		public static extern ulong SteamGameServer_GetSteamID();

		// Token: 0x060004B4 RID: 1204
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x9526D0", Offset = "0x950CD0", VA = "0x1809526D0")]
		[PreserveSig]
		public static extern int SteamGameServer_GetHSteamPipe();

		// Token: 0x060004B5 RID: 1205
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x952740", Offset = "0x950D40", VA = "0x180952740")]
		[PreserveSig]
		public static extern int SteamGameServer_GetHSteamUser();

		// Token: 0x060004B6 RID: 1206
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x9527B0", Offset = "0x950DB0", VA = "0x1809527B0")]
		[PreserveSig]
		public static extern bool SteamInternal_GameServer_Init(uint unIP, ushort usPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString);

		// Token: 0x060004B7 RID: 1207
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x9528D0", Offset = "0x950ED0", VA = "0x1809528D0")]
		[PreserveSig]
		public static extern IntPtr SteamClient();

		// Token: 0x060004B8 RID: 1208
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x952940", Offset = "0x950F40", VA = "0x180952940")]
		[PreserveSig]
		public static extern IntPtr SteamGameServerClient();

		// Token: 0x060004B9 RID: 1209
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_Clear(ref SteamNetworkingIPAddr self);

		// Token: 0x060004BA RID: 1210
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x952AB0", Offset = "0x9510B0", VA = "0x180952AB0")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsIPv6AllZeros(ref SteamNetworkingIPAddr self);

		// Token: 0x060004BB RID: 1211
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x952BD0", Offset = "0x9511D0", VA = "0x180952BD0")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv6(ref SteamNetworkingIPAddr self, [In] [Out] byte[] ipv6, ushort nPort);

		// Token: 0x060004BC RID: 1212
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x952D00", Offset = "0x951300", VA = "0x180952D00")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv4(ref SteamNetworkingIPAddr self, uint nIP, ushort nPort);

		// Token: 0x060004BD RID: 1213
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x952E20", Offset = "0x951420", VA = "0x180952E20")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsIPv4(ref SteamNetworkingIPAddr self);

		// Token: 0x060004BE RID: 1214
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x952F40", Offset = "0x951540", VA = "0x180952F40")]
		[PreserveSig]
		public static extern uint SteamAPI_SteamNetworkingIPAddr_GetIPv4(ref SteamNetworkingIPAddr self);

		// Token: 0x060004BF RID: 1215
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x953060", Offset = "0x951660", VA = "0x180953060")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv6LocalHost(ref SteamNetworkingIPAddr self, ushort nPort);

		// Token: 0x060004C0 RID: 1216
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x953180", Offset = "0x951780", VA = "0x180953180")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsLocalHost(ref SteamNetworkingIPAddr self);

		// Token: 0x060004C1 RID: 1217
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x9532A0", Offset = "0x9518A0", VA = "0x1809532A0")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr self, IntPtr buf, uint cbBuf, bool bWithPort);

		// Token: 0x060004C2 RID: 1218
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x9533D0", Offset = "0x9519D0", VA = "0x1809533D0")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_ParseString(ref SteamNetworkingIPAddr self, InteropHelp.UTF8StringHandle pszStr);

		// Token: 0x060004C3 RID: 1219
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x953550", Offset = "0x951B50", VA = "0x180953550")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsEqualTo(ref SteamNetworkingIPAddr self, ref SteamNetworkingIPAddr x);

		// Token: 0x060004C4 RID: 1220
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x953700", Offset = "0x951D00", VA = "0x180953700")]
		[PreserveSig]
		public static extern ESteamNetworkingFakeIPType SteamAPI_SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr self);

		// Token: 0x060004C5 RID: 1221
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x953820", Offset = "0x951E20", VA = "0x180953820")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsFakeIP(ref SteamNetworkingIPAddr self);

		// Token: 0x060004C6 RID: 1222
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x953940", Offset = "0x951F40", VA = "0x180953940")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_Clear(ref SteamNetworkingIdentity self);

		// Token: 0x060004C7 RID: 1223
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x953A70", Offset = "0x952070", VA = "0x180953A70")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsInvalid(ref SteamNetworkingIdentity self);

		// Token: 0x060004C8 RID: 1224
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x953BA0", Offset = "0x9521A0", VA = "0x180953BA0")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetSteamID(ref SteamNetworkingIdentity self, ulong steamID);

		// Token: 0x060004C9 RID: 1225
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x953CE0", Offset = "0x9522E0", VA = "0x180953CE0")]
		[PreserveSig]
		public static extern ulong SteamAPI_SteamNetworkingIdentity_GetSteamID(ref SteamNetworkingIdentity self);

		// Token: 0x060004CA RID: 1226
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x953E10", Offset = "0x952410", VA = "0x180953E10")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetSteamID64(ref SteamNetworkingIdentity self, ulong steamID);

		// Token: 0x060004CB RID: 1227
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x953F50", Offset = "0x952550", VA = "0x180953F50")]
		[PreserveSig]
		public static extern ulong SteamAPI_SteamNetworkingIdentity_GetSteamID64(ref SteamNetworkingIdentity self);

		// Token: 0x060004CC RID: 1228
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x954080", Offset = "0x952680", VA = "0x180954080")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_SetXboxPairwiseID(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszString);

		// Token: 0x060004CD RID: 1229
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x954210", Offset = "0x952810", VA = "0x180954210")]
		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetXboxPairwiseID(ref SteamNetworkingIdentity self);

		// Token: 0x060004CE RID: 1230
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x954340", Offset = "0x952940", VA = "0x180954340")]
		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_SetIPAddr(ref SteamNetworkingIdentity self, ref SteamNetworkingIPAddr addr);

		// Token: 0x060004CF RID: 1231
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x954520", Offset = "0x952B20", VA = "0x180954520")]
		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetIPAddr(ref SteamNetworkingIdentity self);

		// Token: 0x060004D0 RID: 1232
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x954650", Offset = "0x952C50", VA = "0x180954650")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetIPv4Addr(ref SteamNetworkingIdentity self, uint nIPv4, ushort nPort);

		// Token: 0x060004D1 RID: 1233
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x954790", Offset = "0x952D90", VA = "0x180954790")]
		[PreserveSig]
		public static extern uint SteamAPI_SteamNetworkingIdentity_GetIPv4(ref SteamNetworkingIdentity self);

		// Token: 0x060004D2 RID: 1234
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x9548C0", Offset = "0x952EC0", VA = "0x1809548C0")]
		[PreserveSig]
		public static extern ESteamNetworkingFakeIPType SteamAPI_SteamNetworkingIdentity_GetFakeIPType(ref SteamNetworkingIdentity self);

		// Token: 0x060004D3 RID: 1235
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x9549F0", Offset = "0x952FF0", VA = "0x1809549F0")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsFakeIP(ref SteamNetworkingIdentity self);

		// Token: 0x060004D4 RID: 1236
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x954B20", Offset = "0x953120", VA = "0x180954B20")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetLocalHost(ref SteamNetworkingIdentity self);

		// Token: 0x060004D5 RID: 1237
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x954C50", Offset = "0x953250", VA = "0x180954C50")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsLocalHost(ref SteamNetworkingIdentity self);

		// Token: 0x060004D6 RID: 1238
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x954D80", Offset = "0x953380", VA = "0x180954D80")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_SetGenericString(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszString);

		// Token: 0x060004D7 RID: 1239
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x954F10", Offset = "0x953510", VA = "0x180954F10")]
		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericString(ref SteamNetworkingIdentity self);

		// Token: 0x060004D8 RID: 1240
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x955040", Offset = "0x953640", VA = "0x180955040")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_SetGenericBytes(ref SteamNetworkingIdentity self, [In] [Out] byte[] data, uint cbLen);

		// Token: 0x060004D9 RID: 1241
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x9551A0", Offset = "0x9537A0", VA = "0x1809551A0")]
		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericBytes(ref SteamNetworkingIdentity self, out int cbLen);

		// Token: 0x060004DA RID: 1242
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x9552E0", Offset = "0x9538E0", VA = "0x1809552E0")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsEqualTo(ref SteamNetworkingIdentity self, ref SteamNetworkingIdentity x);

		// Token: 0x060004DB RID: 1243
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x9554F0", Offset = "0x953AF0", VA = "0x1809554F0")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity self, IntPtr buf, uint cbBuf);

		// Token: 0x060004DC RID: 1244
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x955630", Offset = "0x953C30", VA = "0x180955630")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_ParseString(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszStr);

		// Token: 0x060004DD RID: 1245
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x9557C0", Offset = "0x953DC0", VA = "0x1809557C0")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingMessage_t_Release(IntPtr self);

		// Token: 0x060004DE RID: 1246
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x955840", Offset = "0x953E40", VA = "0x180955840")]
		[PreserveSig]
		public static extern bool SteamAPI_ISteamNetworkingConnectionSignaling_SendSignal(ref ISteamNetworkingConnectionSignaling self, HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg);

		// Token: 0x060004DF RID: 1247
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x9559F0", Offset = "0x953FF0", VA = "0x1809559F0")]
		[PreserveSig]
		public static extern void SteamAPI_ISteamNetworkingConnectionSignaling_Release(ref ISteamNetworkingConnectionSignaling self);

		// Token: 0x060004E0 RID: 1248
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x955A70", Offset = "0x954070", VA = "0x180955A70")]
		[PreserveSig]
		public static extern IntPtr SteamAPI_ISteamNetworkingSignalingRecvContext_OnConnectRequest(ref ISteamNetworkingSignalingRecvContext self, HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort);

		// Token: 0x060004E1 RID: 1249
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x955BD0", Offset = "0x9541D0", VA = "0x180955BD0")]
		[PreserveSig]
		public static extern void SteamAPI_ISteamNetworkingSignalingRecvContext_SendRejectionSignal(ref ISteamNetworkingSignalingRecvContext self, ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg);

		// Token: 0x060004E2 RID: 1250
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x955D20", Offset = "0x954320", VA = "0x180955D20")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BDecryptTicket([In] [Out] byte[] rgubTicketEncrypted, uint cubTicketEncrypted, [In] [Out] byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey);

		// Token: 0x060004E3 RID: 1251
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x955E10", Offset = "0x954410", VA = "0x180955E10")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BIsTicketForApp([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		// Token: 0x060004E4 RID: 1252
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x955EB0", Offset = "0x9544B0", VA = "0x180955EB0")]
		[PreserveSig]
		public static extern uint SteamEncryptedAppTicket_GetTicketIssueTime([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x060004E5 RID: 1253
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x955F40", Offset = "0x954540", VA = "0x180955F40")]
		[PreserveSig]
		public static extern void SteamEncryptedAppTicket_GetTicketSteamID([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID);

		// Token: 0x060004E6 RID: 1254
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x955FE0", Offset = "0x9545E0", VA = "0x180955FE0")]
		[PreserveSig]
		public static extern uint SteamEncryptedAppTicket_GetTicketAppID([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x060004E7 RID: 1255
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x956070", Offset = "0x954670", VA = "0x180956070")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BUserOwnsAppInTicket([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		// Token: 0x060004E8 RID: 1256
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x956110", Offset = "0x954710", VA = "0x180956110")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BUserIsVacBanned([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x060004E9 RID: 1257
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x9561B0", Offset = "0x9547B0", VA = "0x1809561B0")]
		[PreserveSig]
		public static extern IntPtr SteamEncryptedAppTicket_GetUserVariableData([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData);

		// Token: 0x060004EA RID: 1258
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x956250", Offset = "0x954850", VA = "0x180956250")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BIsTicketSigned([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, [In] [Out] byte[] pubRSAKey, uint cubRSAKey);

		// Token: 0x060004EB RID: 1259
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x956310", Offset = "0x954910", VA = "0x180956310")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BIsLicenseBorrowed([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x060004EC RID: 1260
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x9563B0", Offset = "0x9549B0", VA = "0x1809563B0")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BIsLicenseTemporary([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x060004ED RID: 1261
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x956450", Offset = "0x954A50", VA = "0x180956450")]
		[PreserveSig]
		public static extern uint ISteamAppList_GetNumInstalledApps(IntPtr instancePtr);

		// Token: 0x060004EE RID: 1262
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x9564D0", Offset = "0x954AD0", VA = "0x1809564D0")]
		[PreserveSig]
		public static extern uint ISteamAppList_GetInstalledApps(IntPtr instancePtr, [In] [Out] AppId_t[] pvecAppID, uint unMaxAppIDs);

		// Token: 0x060004EF RID: 1263
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x956570", Offset = "0x954B70", VA = "0x180956570")]
		[PreserveSig]
		public static extern int ISteamAppList_GetAppName(IntPtr instancePtr, AppId_t nAppID, IntPtr pchName, int cchNameMax);

		// Token: 0x060004F0 RID: 1264
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x956610", Offset = "0x954C10", VA = "0x180956610")]
		[PreserveSig]
		public static extern int ISteamAppList_GetAppInstallDir(IntPtr instancePtr, AppId_t nAppID, IntPtr pchDirectory, int cchNameMax);

		// Token: 0x060004F1 RID: 1265
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x9566B0", Offset = "0x954CB0", VA = "0x1809566B0")]
		[PreserveSig]
		public static extern int ISteamAppList_GetAppBuildId(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x060004F2 RID: 1266
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x956740", Offset = "0x954D40", VA = "0x180956740")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsSubscribed(IntPtr instancePtr);

		// Token: 0x060004F3 RID: 1267
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x9567C0", Offset = "0x954DC0", VA = "0x1809567C0")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsLowViolence(IntPtr instancePtr);

		// Token: 0x060004F4 RID: 1268
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x956840", Offset = "0x954E40", VA = "0x180956840")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsCybercafe(IntPtr instancePtr);

		// Token: 0x060004F5 RID: 1269
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x9568C0", Offset = "0x954EC0", VA = "0x1809568C0")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsVACBanned(IntPtr instancePtr);

		// Token: 0x060004F6 RID: 1270
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x956940", Offset = "0x954F40", VA = "0x180956940")]
		[PreserveSig]
		public static extern IntPtr ISteamApps_GetCurrentGameLanguage(IntPtr instancePtr);

		// Token: 0x060004F7 RID: 1271
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x9569C0", Offset = "0x954FC0", VA = "0x1809569C0")]
		[PreserveSig]
		public static extern IntPtr ISteamApps_GetAvailableGameLanguages(IntPtr instancePtr);

		// Token: 0x060004F8 RID: 1272
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x956A40", Offset = "0x955040", VA = "0x180956A40")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsSubscribedApp(IntPtr instancePtr, AppId_t appID);

		// Token: 0x060004F9 RID: 1273
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x956AD0", Offset = "0x9550D0", VA = "0x180956AD0")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsDlcInstalled(IntPtr instancePtr, AppId_t appID);

		// Token: 0x060004FA RID: 1274
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x956B60", Offset = "0x955160", VA = "0x180956B60")]
		[PreserveSig]
		public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x060004FB RID: 1275
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x956BF0", Offset = "0x9551F0", VA = "0x180956BF0")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend(IntPtr instancePtr);

		// Token: 0x060004FC RID: 1276
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x956C70", Offset = "0x955270", VA = "0x180956C70")]
		[PreserveSig]
		public static extern int ISteamApps_GetDLCCount(IntPtr instancePtr);

		// Token: 0x060004FD RID: 1277
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x956CF0", Offset = "0x9552F0", VA = "0x180956CF0")]
		[PreserveSig]
		public static extern bool ISteamApps_BGetDLCDataByIndex(IntPtr instancePtr, int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize);

		// Token: 0x060004FE RID: 1278
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x956DD0", Offset = "0x9553D0", VA = "0x180956DD0")]
		[PreserveSig]
		public static extern void ISteamApps_InstallDLC(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x060004FF RID: 1279
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x956E60", Offset = "0x955460", VA = "0x180956E60")]
		[PreserveSig]
		public static extern void ISteamApps_UninstallDLC(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x06000500 RID: 1280
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x956EF0", Offset = "0x9554F0", VA = "0x180956EF0")]
		[PreserveSig]
		public static extern void ISteamApps_RequestAppProofOfPurchaseKey(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x06000501 RID: 1281
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x956F80", Offset = "0x955580", VA = "0x180956F80")]
		[PreserveSig]
		public static extern bool ISteamApps_GetCurrentBetaName(IntPtr instancePtr, IntPtr pchName, int cchNameBufferSize);

		// Token: 0x06000502 RID: 1282
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x957020", Offset = "0x955620", VA = "0x180957020")]
		[PreserveSig]
		public static extern bool ISteamApps_MarkContentCorrupt(IntPtr instancePtr, bool bMissingFilesOnly);

		// Token: 0x06000503 RID: 1283
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x9570B0", Offset = "0x9556B0", VA = "0x1809570B0")]
		[PreserveSig]
		public static extern uint ISteamApps_GetInstalledDepots(IntPtr instancePtr, AppId_t appID, [In] [Out] DepotId_t[] pvecDepots, uint cMaxDepots);

		// Token: 0x06000504 RID: 1284
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x957160", Offset = "0x955760", VA = "0x180957160")]
		[PreserveSig]
		public static extern uint ISteamApps_GetAppInstallDir(IntPtr instancePtr, AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize);

		// Token: 0x06000505 RID: 1285
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x957200", Offset = "0x955800", VA = "0x180957200")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsAppInstalled(IntPtr instancePtr, AppId_t appID);

		// Token: 0x06000506 RID: 1286
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x957290", Offset = "0x955890", VA = "0x180957290")]
		[PreserveSig]
		public static extern ulong ISteamApps_GetAppOwner(IntPtr instancePtr);

		// Token: 0x06000507 RID: 1287
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x957310", Offset = "0x955910", VA = "0x180957310")]
		[PreserveSig]
		public static extern IntPtr ISteamApps_GetLaunchQueryParam(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x06000508 RID: 1288
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x9573F0", Offset = "0x9559F0", VA = "0x1809573F0")]
		[PreserveSig]
		public static extern bool ISteamApps_GetDlcDownloadProgress(IntPtr instancePtr, AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		// Token: 0x06000509 RID: 1289
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x9574A0", Offset = "0x955AA0", VA = "0x1809574A0")]
		[PreserveSig]
		public static extern int ISteamApps_GetAppBuildId(IntPtr instancePtr);

		// Token: 0x0600050A RID: 1290
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x957520", Offset = "0x955B20", VA = "0x180957520")]
		[PreserveSig]
		public static extern void ISteamApps_RequestAllProofOfPurchaseKeys(IntPtr instancePtr);

		// Token: 0x0600050B RID: 1291
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x9575A0", Offset = "0x955BA0", VA = "0x1809575A0")]
		[PreserveSig]
		public static extern ulong ISteamApps_GetFileDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszFileName);

		// Token: 0x0600050C RID: 1292
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x957680", Offset = "0x955C80", VA = "0x180957680")]
		[PreserveSig]
		public static extern int ISteamApps_GetLaunchCommandLine(IntPtr instancePtr, IntPtr pszCommandLine, int cubCommandLine);

		// Token: 0x0600050D RID: 1293
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x957720", Offset = "0x955D20", VA = "0x180957720")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsSubscribedFromFamilySharing(IntPtr instancePtr);

		// Token: 0x0600050E RID: 1294
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x9577A0", Offset = "0x955DA0", VA = "0x1809577A0")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsTimedTrial(IntPtr instancePtr, out uint punSecondsAllowed, out uint punSecondsPlayed);

		// Token: 0x0600050F RID: 1295
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x957840", Offset = "0x955E40", VA = "0x180957840")]
		[PreserveSig]
		public static extern int ISteamClient_CreateSteamPipe(IntPtr instancePtr);

		// Token: 0x06000510 RID: 1296
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x9578C0", Offset = "0x955EC0", VA = "0x1809578C0")]
		[PreserveSig]
		public static extern bool ISteamClient_BReleaseSteamPipe(IntPtr instancePtr, HSteamPipe hSteamPipe);

		// Token: 0x06000511 RID: 1297
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x957950", Offset = "0x955F50", VA = "0x180957950")]
		[PreserveSig]
		public static extern int ISteamClient_ConnectToGlobalUser(IntPtr instancePtr, HSteamPipe hSteamPipe);

		// Token: 0x06000512 RID: 1298
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x9579E0", Offset = "0x955FE0", VA = "0x1809579E0")]
		[PreserveSig]
		public static extern int ISteamClient_CreateLocalUser(IntPtr instancePtr, out HSteamPipe phSteamPipe, EAccountType eAccountType);

		// Token: 0x06000513 RID: 1299
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x957A80", Offset = "0x956080", VA = "0x180957A80")]
		[PreserveSig]
		public static extern void ISteamClient_ReleaseUser(IntPtr instancePtr, HSteamPipe hSteamPipe, HSteamUser hUser);

		// Token: 0x06000514 RID: 1300
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x957B20", Offset = "0x956120", VA = "0x180957B20")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000515 RID: 1301
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x957C10", Offset = "0x956210", VA = "0x180957C10")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGameServer(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000516 RID: 1302
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x957D00", Offset = "0x956300", VA = "0x180957D00")]
		[PreserveSig]
		public static extern void ISteamClient_SetLocalIPBinding(IntPtr instancePtr, ref SteamIPAddress_t unIP, ushort usPort);

		// Token: 0x06000517 RID: 1303
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x957DA0", Offset = "0x9563A0", VA = "0x180957DA0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000518 RID: 1304
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x957E90", Offset = "0x956490", VA = "0x180957E90")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000519 RID: 1305
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x957F70", Offset = "0x956570", VA = "0x180957F70")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600051A RID: 1306
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x958060", Offset = "0x956660", VA = "0x180958060")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600051B RID: 1307
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x958150", Offset = "0x956750", VA = "0x180958150")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGenericInterface(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600051C RID: 1308
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x958240", Offset = "0x956840", VA = "0x180958240")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600051D RID: 1309
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x958330", Offset = "0x956930", VA = "0x180958330")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGameServerStats(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600051E RID: 1310
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x958420", Offset = "0x956A20", VA = "0x180958420")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600051F RID: 1311
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x958510", Offset = "0x956B10", VA = "0x180958510")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000520 RID: 1312
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x958600", Offset = "0x956C00", VA = "0x180958600")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000521 RID: 1313
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x9586F0", Offset = "0x956CF0", VA = "0x1809586F0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000522 RID: 1314
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x9587E0", Offset = "0x956DE0", VA = "0x1809587E0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGameSearch(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000523 RID: 1315
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x9588D0", Offset = "0x956ED0", VA = "0x1809588D0")]
		[PreserveSig]
		public static extern uint ISteamClient_GetIPCCallCount(IntPtr instancePtr);

		// Token: 0x06000524 RID: 1316
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x958950", Offset = "0x956F50", VA = "0x180958950")]
		[PreserveSig]
		public static extern void ISteamClient_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		// Token: 0x06000525 RID: 1317
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x9589F0", Offset = "0x956FF0", VA = "0x1809589F0")]
		[PreserveSig]
		public static extern bool ISteamClient_BShutdownIfAllPipesClosed(IntPtr instancePtr);

		// Token: 0x06000526 RID: 1318
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x958A70", Offset = "0x957070", VA = "0x180958A70")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000527 RID: 1319
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x958B60", Offset = "0x957160", VA = "0x180958B60")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamController(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000528 RID: 1320
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x958C50", Offset = "0x957250", VA = "0x180958C50")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000529 RID: 1321
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x958D40", Offset = "0x957340", VA = "0x180958D40")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamAppList(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600052A RID: 1322
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x958E30", Offset = "0x957430", VA = "0x180958E30")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600052B RID: 1323
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x958F20", Offset = "0x957520", VA = "0x180958F20")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600052C RID: 1324
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x959010", Offset = "0x957610", VA = "0x180959010")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600052D RID: 1325
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x959100", Offset = "0x957700", VA = "0x180959100")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600052E RID: 1326
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x9591F0", Offset = "0x9577F0", VA = "0x1809591F0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600052F RID: 1327
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x9592E0", Offset = "0x9578E0", VA = "0x1809592E0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000530 RID: 1328
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x9593D0", Offset = "0x9579D0", VA = "0x1809593D0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamInput(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000531 RID: 1329
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x9594C0", Offset = "0x957AC0", VA = "0x1809594C0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamParties(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000532 RID: 1330
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x9595B0", Offset = "0x957BB0", VA = "0x1809595B0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamRemotePlay(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000533 RID: 1331
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x9596A0", Offset = "0x957CA0", VA = "0x1809596A0")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr);

		// Token: 0x06000534 RID: 1332
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x959720", Offset = "0x957D20", VA = "0x180959720")]
		[PreserveSig]
		public static extern ulong ISteamFriends_SetPersonaName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchPersonaName);

		// Token: 0x06000535 RID: 1333
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x959800", Offset = "0x957E00", VA = "0x180959800")]
		[PreserveSig]
		public static extern EPersonaState ISteamFriends_GetPersonaState(IntPtr instancePtr);

		// Token: 0x06000536 RID: 1334
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x959880", Offset = "0x957E80", VA = "0x180959880")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendCount(IntPtr instancePtr, EFriendFlags iFriendFlags);

		// Token: 0x06000537 RID: 1335
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x959910", Offset = "0x957F10", VA = "0x180959910")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetFriendByIndex(IntPtr instancePtr, int iFriend, EFriendFlags iFriendFlags);

		// Token: 0x06000538 RID: 1336
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x9599B0", Offset = "0x957FB0", VA = "0x1809599B0")]
		[PreserveSig]
		public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000539 RID: 1337
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x959A40", Offset = "0x958040", VA = "0x180959A40")]
		[PreserveSig]
		public static extern EPersonaState ISteamFriends_GetFriendPersonaState(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x0600053A RID: 1338
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x959AD0", Offset = "0x9580D0", VA = "0x180959AD0")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendPersonaName(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x0600053B RID: 1339
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x959B60", Offset = "0x958160", VA = "0x180959B60")]
		[PreserveSig]
		public static extern bool ISteamFriends_GetFriendGamePlayed(IntPtr instancePtr, CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo);

		// Token: 0x0600053C RID: 1340
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x959C00", Offset = "0x958200", VA = "0x180959C00")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendPersonaNameHistory(IntPtr instancePtr, CSteamID steamIDFriend, int iPersonaName);

		// Token: 0x0600053D RID: 1341
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x959CA0", Offset = "0x9582A0", VA = "0x180959CA0")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendSteamLevel(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x0600053E RID: 1342
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x959D30", Offset = "0x958330", VA = "0x180959D30")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetPlayerNickname(IntPtr instancePtr, CSteamID steamIDPlayer);

		// Token: 0x0600053F RID: 1343
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x959DC0", Offset = "0x9583C0", VA = "0x180959DC0")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendsGroupCount(IntPtr instancePtr);

		// Token: 0x06000540 RID: 1344
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x959E40", Offset = "0x958440", VA = "0x180959E40")]
		[PreserveSig]
		public static extern short ISteamFriends_GetFriendsGroupIDByIndex(IntPtr instancePtr, int iFG);

		// Token: 0x06000541 RID: 1345
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x959ED0", Offset = "0x9584D0", VA = "0x180959ED0")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendsGroupName(IntPtr instancePtr, FriendsGroupID_t friendsGroupID);

		// Token: 0x06000542 RID: 1346
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x959F60", Offset = "0x958560", VA = "0x180959F60")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendsGroupMembersCount(IntPtr instancePtr, FriendsGroupID_t friendsGroupID);

		// Token: 0x06000543 RID: 1347
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x959FF0", Offset = "0x9585F0", VA = "0x180959FF0")]
		[PreserveSig]
		public static extern void ISteamFriends_GetFriendsGroupMembersList(IntPtr instancePtr, FriendsGroupID_t friendsGroupID, [In] [Out] CSteamID[] pOutSteamIDMembers, int nMembersCount);

		// Token: 0x06000544 RID: 1348
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x95A0A0", Offset = "0x9586A0", VA = "0x18095A0A0")]
		[PreserveSig]
		public static extern bool ISteamFriends_HasFriend(IntPtr instancePtr, CSteamID steamIDFriend, EFriendFlags iFriendFlags);

		// Token: 0x06000545 RID: 1349
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x95A140", Offset = "0x958740", VA = "0x18095A140")]
		[PreserveSig]
		public static extern int ISteamFriends_GetClanCount(IntPtr instancePtr);

		// Token: 0x06000546 RID: 1350
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x95A1C0", Offset = "0x9587C0", VA = "0x18095A1C0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetClanByIndex(IntPtr instancePtr, int iClan);

		// Token: 0x06000547 RID: 1351
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x95A250", Offset = "0x958850", VA = "0x18095A250")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetClanName(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x06000548 RID: 1352
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x95A2E0", Offset = "0x9588E0", VA = "0x18095A2E0")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetClanTag(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x06000549 RID: 1353
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x95A370", Offset = "0x958970", VA = "0x18095A370")]
		[PreserveSig]
		public static extern bool ISteamFriends_GetClanActivityCounts(IntPtr instancePtr, CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting);

		// Token: 0x0600054A RID: 1354
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x95A430", Offset = "0x958A30", VA = "0x18095A430")]
		[PreserveSig]
		public static extern ulong ISteamFriends_DownloadClanActivityCounts(IntPtr instancePtr, [In] [Out] CSteamID[] psteamIDClans, int cClansToRequest);

		// Token: 0x0600054B RID: 1355
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x95A4D0", Offset = "0x958AD0", VA = "0x18095A4D0")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendCountFromSource(IntPtr instancePtr, CSteamID steamIDSource);

		// Token: 0x0600054C RID: 1356
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x95A560", Offset = "0x958B60", VA = "0x18095A560")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetFriendFromSourceByIndex(IntPtr instancePtr, CSteamID steamIDSource, int iFriend);

		// Token: 0x0600054D RID: 1357
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x95A600", Offset = "0x958C00", VA = "0x18095A600")]
		[PreserveSig]
		public static extern bool ISteamFriends_IsUserInSource(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDSource);

		// Token: 0x0600054E RID: 1358
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x95A6A0", Offset = "0x958CA0", VA = "0x18095A6A0")]
		[PreserveSig]
		public static extern void ISteamFriends_SetInGameVoiceSpeaking(IntPtr instancePtr, CSteamID steamIDUser, bool bSpeaking);

		// Token: 0x0600054F RID: 1359
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x95A740", Offset = "0x958D40", VA = "0x18095A740")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlay(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog);

		// Token: 0x06000550 RID: 1360
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x95A810", Offset = "0x958E10", VA = "0x18095A810")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayToUser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog, CSteamID steamID);

		// Token: 0x06000551 RID: 1361
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x95A8F0", Offset = "0x958EF0", VA = "0x18095A8F0")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayToWebPage(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchURL, EActivateGameOverlayToWebPageMode eMode);

		// Token: 0x06000552 RID: 1362
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x95A9D0", Offset = "0x958FD0", VA = "0x18095A9D0")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayToStore(IntPtr instancePtr, AppId_t nAppID, EOverlayToStoreFlag eFlag);

		// Token: 0x06000553 RID: 1363
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x95AA70", Offset = "0x959070", VA = "0x18095AA70")]
		[PreserveSig]
		public static extern void ISteamFriends_SetPlayedWith(IntPtr instancePtr, CSteamID steamIDUserPlayedWith);

		// Token: 0x06000554 RID: 1364
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x95AB00", Offset = "0x959100", VA = "0x18095AB00")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000555 RID: 1365
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x95AB90", Offset = "0x959190", VA = "0x18095AB90")]
		[PreserveSig]
		public static extern int ISteamFriends_GetSmallFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000556 RID: 1366
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x95AC20", Offset = "0x959220", VA = "0x18095AC20")]
		[PreserveSig]
		public static extern int ISteamFriends_GetMediumFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000557 RID: 1367
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x95ACB0", Offset = "0x9592B0", VA = "0x18095ACB0")]
		[PreserveSig]
		public static extern int ISteamFriends_GetLargeFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000558 RID: 1368
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x95AD40", Offset = "0x959340", VA = "0x18095AD40")]
		[PreserveSig]
		public static extern bool ISteamFriends_RequestUserInformation(IntPtr instancePtr, CSteamID steamIDUser, bool bRequireNameOnly);

		// Token: 0x06000559 RID: 1369
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x95ADE0", Offset = "0x9593E0", VA = "0x18095ADE0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_RequestClanOfficerList(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600055A RID: 1370
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x95AE70", Offset = "0x959470", VA = "0x18095AE70")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetClanOwner(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600055B RID: 1371
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x95AF00", Offset = "0x959500", VA = "0x18095AF00")]
		[PreserveSig]
		public static extern int ISteamFriends_GetClanOfficerCount(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600055C RID: 1372
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x95AF90", Offset = "0x959590", VA = "0x18095AF90")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetClanOfficerByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iOfficer);

		// Token: 0x0600055D RID: 1373
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x95B030", Offset = "0x959630", VA = "0x18095B030")]
		[PreserveSig]
		public static extern uint ISteamFriends_GetUserRestrictions(IntPtr instancePtr);

		// Token: 0x0600055E RID: 1374
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x95B0B0", Offset = "0x9596B0", VA = "0x18095B0B0")]
		[PreserveSig]
		public static extern bool ISteamFriends_SetRichPresence(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x0600055F RID: 1375
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x95B200", Offset = "0x959800", VA = "0x18095B200")]
		[PreserveSig]
		public static extern void ISteamFriends_ClearRichPresence(IntPtr instancePtr);

		// Token: 0x06000560 RID: 1376
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x95B280", Offset = "0x959880", VA = "0x18095B280")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x06000561 RID: 1377
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x95B370", Offset = "0x959970", VA = "0x18095B370")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000562 RID: 1378
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x95B400", Offset = "0x959A00", VA = "0x18095B400")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(IntPtr instancePtr, CSteamID steamIDFriend, int iKey);

		// Token: 0x06000563 RID: 1379
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x95B4A0", Offset = "0x959AA0", VA = "0x18095B4A0")]
		[PreserveSig]
		public static extern void ISteamFriends_RequestFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000564 RID: 1380
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x95B530", Offset = "0x959B30", VA = "0x18095B530")]
		[PreserveSig]
		public static extern bool ISteamFriends_InviteUserToGame(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchConnectString);

		// Token: 0x06000565 RID: 1381
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x95B620", Offset = "0x959C20", VA = "0x18095B620")]
		[PreserveSig]
		public static extern int ISteamFriends_GetCoplayFriendCount(IntPtr instancePtr);

		// Token: 0x06000566 RID: 1382
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x95B6A0", Offset = "0x959CA0", VA = "0x18095B6A0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetCoplayFriend(IntPtr instancePtr, int iCoplayFriend);

		// Token: 0x06000567 RID: 1383
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x95B730", Offset = "0x959D30", VA = "0x18095B730")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendCoplayTime(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000568 RID: 1384
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x95B7C0", Offset = "0x959DC0", VA = "0x18095B7C0")]
		[PreserveSig]
		public static extern uint ISteamFriends_GetFriendCoplayGame(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000569 RID: 1385
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x95B850", Offset = "0x959E50", VA = "0x18095B850")]
		[PreserveSig]
		public static extern ulong ISteamFriends_JoinClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600056A RID: 1386
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x95B8E0", Offset = "0x959EE0", VA = "0x18095B8E0")]
		[PreserveSig]
		public static extern bool ISteamFriends_LeaveClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600056B RID: 1387
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x95B970", Offset = "0x959F70", VA = "0x18095B970")]
		[PreserveSig]
		public static extern int ISteamFriends_GetClanChatMemberCount(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600056C RID: 1388
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x95BA00", Offset = "0x95A000", VA = "0x18095BA00")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetChatMemberByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iUser);

		// Token: 0x0600056D RID: 1389
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x95BAA0", Offset = "0x95A0A0", VA = "0x18095BAA0")]
		[PreserveSig]
		public static extern bool ISteamFriends_SendClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, InteropHelp.UTF8StringHandle pchText);

		// Token: 0x0600056E RID: 1390
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x95BB90", Offset = "0x95A190", VA = "0x18095BB90")]
		[PreserveSig]
		public static extern int ISteamFriends_GetClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter);

		// Token: 0x0600056F RID: 1391
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x95BC40", Offset = "0x95A240", VA = "0x18095BC40")]
		[PreserveSig]
		public static extern bool ISteamFriends_IsClanChatAdmin(IntPtr instancePtr, CSteamID steamIDClanChat, CSteamID steamIDUser);

		// Token: 0x06000570 RID: 1392
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x95BCE0", Offset = "0x95A2E0", VA = "0x18095BCE0")]
		[PreserveSig]
		public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		// Token: 0x06000571 RID: 1393
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x95BD70", Offset = "0x95A370", VA = "0x18095BD70")]
		[PreserveSig]
		public static extern bool ISteamFriends_OpenClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		// Token: 0x06000572 RID: 1394
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x95BE00", Offset = "0x95A400", VA = "0x18095BE00")]
		[PreserveSig]
		public static extern bool ISteamFriends_CloseClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		// Token: 0x06000573 RID: 1395
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x95BE90", Offset = "0x95A490", VA = "0x18095BE90")]
		[PreserveSig]
		public static extern bool ISteamFriends_SetListenForFriendsMessages(IntPtr instancePtr, bool bInterceptEnabled);

		// Token: 0x06000574 RID: 1396
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x95BF20", Offset = "0x95A520", VA = "0x18095BF20")]
		[PreserveSig]
		public static extern bool ISteamFriends_ReplyToFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchMsgToSend);

		// Token: 0x06000575 RID: 1397
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x95C010", Offset = "0x95A610", VA = "0x18095C010")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType);

		// Token: 0x06000576 RID: 1398
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x95C0C0", Offset = "0x95A6C0", VA = "0x18095C0C0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetFollowerCount(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x06000577 RID: 1399
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x95C150", Offset = "0x95A750", VA = "0x18095C150")]
		[PreserveSig]
		public static extern ulong ISteamFriends_IsFollowing(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x06000578 RID: 1400
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x95C1E0", Offset = "0x95A7E0", VA = "0x18095C1E0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_EnumerateFollowingList(IntPtr instancePtr, uint unStartIndex);

		// Token: 0x06000579 RID: 1401
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x95C270", Offset = "0x95A870", VA = "0x18095C270")]
		[PreserveSig]
		public static extern bool ISteamFriends_IsClanPublic(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600057A RID: 1402
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x95C300", Offset = "0x95A900", VA = "0x18095C300")]
		[PreserveSig]
		public static extern bool ISteamFriends_IsClanOfficialGameGroup(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600057B RID: 1403
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x95C390", Offset = "0x95A990", VA = "0x18095C390")]
		[PreserveSig]
		public static extern int ISteamFriends_GetNumChatsWithUnreadPriorityMessages(IntPtr instancePtr);

		// Token: 0x0600057C RID: 1404
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x95C410", Offset = "0x95AA10", VA = "0x18095C410")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayRemotePlayTogetherInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x0600057D RID: 1405
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x95C4A0", Offset = "0x95AAA0", VA = "0x18095C4A0")]
		[PreserveSig]
		public static extern bool ISteamFriends_RegisterProtocolInOverlayBrowser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchProtocol);

		// Token: 0x0600057E RID: 1406
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x95C580", Offset = "0x95AB80", VA = "0x18095C580")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialogConnectString(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchConnectString);

		// Token: 0x0600057F RID: 1407
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x95C650", Offset = "0x95AC50", VA = "0x18095C650")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetProduct(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszProduct);

		// Token: 0x06000580 RID: 1408
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x95C720", Offset = "0x95AD20", VA = "0x18095C720")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetGameDescription(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszGameDescription);

		// Token: 0x06000581 RID: 1409
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x95C7F0", Offset = "0x95ADF0", VA = "0x18095C7F0")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetModDir(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszModDir);

		// Token: 0x06000582 RID: 1410
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x95C8C0", Offset = "0x95AEC0", VA = "0x18095C8C0")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetDedicatedServer(IntPtr instancePtr, bool bDedicated);

		// Token: 0x06000583 RID: 1411
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x95C950", Offset = "0x95AF50", VA = "0x18095C950")]
		[PreserveSig]
		public static extern void ISteamGameServer_LogOn(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszToken);

		// Token: 0x06000584 RID: 1412
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x95CA20", Offset = "0x95B020", VA = "0x18095CA20")]
		[PreserveSig]
		public static extern void ISteamGameServer_LogOnAnonymous(IntPtr instancePtr);

		// Token: 0x06000585 RID: 1413
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x95CAA0", Offset = "0x95B0A0", VA = "0x18095CAA0")]
		[PreserveSig]
		public static extern void ISteamGameServer_LogOff(IntPtr instancePtr);

		// Token: 0x06000586 RID: 1414
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x95CB20", Offset = "0x95B120", VA = "0x18095CB20")]
		[PreserveSig]
		public static extern bool ISteamGameServer_BLoggedOn(IntPtr instancePtr);

		// Token: 0x06000587 RID: 1415
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x95CBA0", Offset = "0x95B1A0", VA = "0x18095CBA0")]
		[PreserveSig]
		public static extern bool ISteamGameServer_BSecure(IntPtr instancePtr);

		// Token: 0x06000588 RID: 1416
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x95CC20", Offset = "0x95B220", VA = "0x18095CC20")]
		[PreserveSig]
		public static extern ulong ISteamGameServer_GetSteamID(IntPtr instancePtr);

		// Token: 0x06000589 RID: 1417
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x95CCA0", Offset = "0x95B2A0", VA = "0x18095CCA0")]
		[PreserveSig]
		public static extern bool ISteamGameServer_WasRestartRequested(IntPtr instancePtr);

		// Token: 0x0600058A RID: 1418
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x95CD20", Offset = "0x95B320", VA = "0x18095CD20")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetMaxPlayerCount(IntPtr instancePtr, int cPlayersMax);

		// Token: 0x0600058B RID: 1419
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x95CDB0", Offset = "0x95B3B0", VA = "0x18095CDB0")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetBotPlayerCount(IntPtr instancePtr, int cBotplayers);

		// Token: 0x0600058C RID: 1420
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x95CE40", Offset = "0x95B440", VA = "0x18095CE40")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszServerName);

		// Token: 0x0600058D RID: 1421
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x95CF10", Offset = "0x95B510", VA = "0x18095CF10")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetMapName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszMapName);

		// Token: 0x0600058E RID: 1422
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x95CFE0", Offset = "0x95B5E0", VA = "0x18095CFE0")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetPasswordProtected(IntPtr instancePtr, bool bPasswordProtected);

		// Token: 0x0600058F RID: 1423
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x95D070", Offset = "0x95B670", VA = "0x18095D070")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetSpectatorPort(IntPtr instancePtr, ushort unSpectatorPort);

		// Token: 0x06000590 RID: 1424
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x95D100", Offset = "0x95B700", VA = "0x18095D100")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetSpectatorServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszSpectatorServerName);

		// Token: 0x06000591 RID: 1425
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x95D1D0", Offset = "0x95B7D0", VA = "0x18095D1D0")]
		[PreserveSig]
		public static extern void ISteamGameServer_ClearAllKeyValues(IntPtr instancePtr);

		// Token: 0x06000592 RID: 1426
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x95D250", Offset = "0x95B850", VA = "0x18095D250")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetKeyValue(IntPtr instancePtr, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		// Token: 0x06000593 RID: 1427
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x95D390", Offset = "0x95B990", VA = "0x18095D390")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetGameTags(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameTags);

		// Token: 0x06000594 RID: 1428
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x95D460", Offset = "0x95BA60", VA = "0x18095D460")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetGameData(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameData);

		// Token: 0x06000595 RID: 1429
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x95D530", Offset = "0x95BB30", VA = "0x18095D530")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetRegion(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszRegion);

		// Token: 0x06000596 RID: 1430
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x95D600", Offset = "0x95BC00", VA = "0x18095D600")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetAdvertiseServerActive(IntPtr instancePtr, bool bActive);

		// Token: 0x06000597 RID: 1431
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x95D690", Offset = "0x95BC90", VA = "0x18095D690")]
		[PreserveSig]
		public static extern uint ISteamGameServer_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		// Token: 0x06000598 RID: 1432
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x95D740", Offset = "0x95BD40", VA = "0x18095D740")]
		[PreserveSig]
		public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		// Token: 0x06000599 RID: 1433
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x95D7F0", Offset = "0x95BDF0", VA = "0x18095D7F0")]
		[PreserveSig]
		public static extern void ISteamGameServer_EndAuthSession(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x0600059A RID: 1434
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x95D880", Offset = "0x95BE80", VA = "0x18095D880")]
		[PreserveSig]
		public static extern void ISteamGameServer_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket);

		// Token: 0x0600059B RID: 1435
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x95D910", Offset = "0x95BF10", VA = "0x18095D910")]
		[PreserveSig]
		public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID);

		// Token: 0x0600059C RID: 1436
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x95D9B0", Offset = "0x95BFB0", VA = "0x18095D9B0")]
		[PreserveSig]
		public static extern bool ISteamGameServer_RequestUserGroupStatus(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDGroup);

		// Token: 0x0600059D RID: 1437
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x95DA50", Offset = "0x95C050", VA = "0x18095DA50")]
		[PreserveSig]
		public static extern void ISteamGameServer_GetGameplayStats(IntPtr instancePtr);

		// Token: 0x0600059E RID: 1438
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x95DAD0", Offset = "0x95C0D0", VA = "0x18095DAD0")]
		[PreserveSig]
		public static extern ulong ISteamGameServer_GetServerReputation(IntPtr instancePtr);

		// Token: 0x0600059F RID: 1439
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x95DB50", Offset = "0x95C150", VA = "0x18095DB50")]
		[PreserveSig]
		public static extern SteamIPAddress_t ISteamGameServer_GetPublicIP(IntPtr instancePtr);

		// Token: 0x060005A0 RID: 1440
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x95DBF0", Offset = "0x95C1F0", VA = "0x18095DBF0")]
		[PreserveSig]
		public static extern bool ISteamGameServer_HandleIncomingPacket(IntPtr instancePtr, byte[] pData, int cbData, uint srcIP, ushort srcPort);

		// Token: 0x060005A1 RID: 1441
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x95DCC0", Offset = "0x95C2C0", VA = "0x18095DCC0")]
		[PreserveSig]
		public static extern int ISteamGameServer_GetNextOutgoingPacket(IntPtr instancePtr, byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort);

		// Token: 0x060005A2 RID: 1442
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x95DD70", Offset = "0x95C370", VA = "0x18095DD70")]
		[PreserveSig]
		public static extern ulong ISteamGameServer_AssociateWithClan(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x060005A3 RID: 1443
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x95DE00", Offset = "0x95C400", VA = "0x18095DE00")]
		[PreserveSig]
		public static extern ulong ISteamGameServer_ComputeNewPlayerCompatibility(IntPtr instancePtr, CSteamID steamIDNewPlayer);

		// Token: 0x060005A4 RID: 1444
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x95DE90", Offset = "0x95C490", VA = "0x18095DE90")]
		[PreserveSig]
		public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate_DEPRECATED(IntPtr instancePtr, uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser);

		// Token: 0x060005A5 RID: 1445
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x95DF50", Offset = "0x95C550", VA = "0x18095DF50")]
		[PreserveSig]
		public static extern ulong ISteamGameServer_CreateUnauthenticatedUserConnection(IntPtr instancePtr);

		// Token: 0x060005A6 RID: 1446
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x95DFD0", Offset = "0x95C5D0", VA = "0x18095DFD0")]
		[PreserveSig]
		public static extern void ISteamGameServer_SendUserDisconnect_DEPRECATED(IntPtr instancePtr, CSteamID steamIDUser);

		// Token: 0x060005A7 RID: 1447
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x95E060", Offset = "0x95C660", VA = "0x18095E060")]
		[PreserveSig]
		public static extern bool ISteamGameServer_BUpdateUserData(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchPlayerName, uint uScore);

		// Token: 0x060005A8 RID: 1448
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x95E160", Offset = "0x95C760", VA = "0x18095E160")]
		[PreserveSig]
		public static extern ulong ISteamGameServerStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		// Token: 0x060005A9 RID: 1449
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x95E1F0", Offset = "0x95C7F0", VA = "0x18095E1F0")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		// Token: 0x060005AA RID: 1450
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x95E2F0", Offset = "0x95C8F0", VA = "0x18095E2F0")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		// Token: 0x060005AB RID: 1451
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x95E3F0", Offset = "0x95C9F0", VA = "0x18095E3F0")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		// Token: 0x060005AC RID: 1452
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x95E510", Offset = "0x95CB10", VA = "0x18095E510")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_SetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, int nData);

		// Token: 0x060005AD RID: 1453
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x95E610", Offset = "0x95CC10", VA = "0x18095E610")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_SetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float fData);

		// Token: 0x060005AE RID: 1454
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x95E710", Offset = "0x95CD10", VA = "0x18095E710")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		// Token: 0x060005AF RID: 1455
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x95E820", Offset = "0x95CE20", VA = "0x18095E820")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_SetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x060005B0 RID: 1456
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x95E910", Offset = "0x95CF10", VA = "0x18095E910")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_ClearUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x060005B1 RID: 1457
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x95EA00", Offset = "0x95D000", VA = "0x18095EA00")]
		[PreserveSig]
		public static extern ulong ISteamGameServerStats_StoreUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		// Token: 0x060005B2 RID: 1458
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x95EA90", Offset = "0x95D090", VA = "0x18095EA90")]
		[PreserveSig]
		public static extern bool ISteamHTMLSurface_Init(IntPtr instancePtr);

		// Token: 0x060005B3 RID: 1459
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x95EB10", Offset = "0x95D110", VA = "0x18095EB10")]
		[PreserveSig]
		public static extern bool ISteamHTMLSurface_Shutdown(IntPtr instancePtr);

		// Token: 0x060005B4 RID: 1460
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x95EB90", Offset = "0x95D190", VA = "0x18095EB90")]
		[PreserveSig]
		public static extern ulong ISteamHTMLSurface_CreateBrowser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchUserAgent, InteropHelp.UTF8StringHandle pchUserCSS);

		// Token: 0x060005B5 RID: 1461
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x95ECD0", Offset = "0x95D2D0", VA = "0x18095ECD0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_RemoveBrowser(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005B6 RID: 1462
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x95ED60", Offset = "0x95D360", VA = "0x18095ED60")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_LoadURL(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchURL, InteropHelp.UTF8StringHandle pchPostData);

		// Token: 0x060005B7 RID: 1463
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x95EEB0", Offset = "0x95D4B0", VA = "0x18095EEB0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetSize(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);

		// Token: 0x060005B8 RID: 1464
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x95EF50", Offset = "0x95D550", VA = "0x18095EF50")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_StopLoad(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005B9 RID: 1465
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x95EFE0", Offset = "0x95D5E0", VA = "0x18095EFE0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_Reload(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005BA RID: 1466
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x95F070", Offset = "0x95D670", VA = "0x18095F070")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_GoBack(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005BB RID: 1467
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x95F100", Offset = "0x95D700", VA = "0x18095F100")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_GoForward(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005BC RID: 1468
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x95F190", Offset = "0x95D790", VA = "0x18095F190")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_AddHeader(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x060005BD RID: 1469
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x95F2E0", Offset = "0x95D8E0", VA = "0x18095F2E0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_ExecuteJavascript(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchScript);

		// Token: 0x060005BE RID: 1470
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x95F3C0", Offset = "0x95D9C0", VA = "0x18095F3C0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		// Token: 0x060005BF RID: 1471
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x95F460", Offset = "0x95DA60", VA = "0x18095F460")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		// Token: 0x060005C0 RID: 1472
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x95F500", Offset = "0x95DB00", VA = "0x18095F500")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseDoubleClick(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		// Token: 0x060005C1 RID: 1473
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x95F5A0", Offset = "0x95DBA0", VA = "0x18095F5A0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseMove(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y);

		// Token: 0x060005C2 RID: 1474
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x95F640", Offset = "0x95DC40", VA = "0x18095F640")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseWheel(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int nDelta);

		// Token: 0x060005C3 RID: 1475
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x95F6E0", Offset = "0x95DCE0", VA = "0x18095F6E0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_KeyDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey);

		// Token: 0x060005C4 RID: 1476
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x95F7A0", Offset = "0x95DDA0", VA = "0x18095F7A0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_KeyUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		// Token: 0x060005C5 RID: 1477
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x95F840", Offset = "0x95DE40", VA = "0x18095F840")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_KeyChar(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers);

		// Token: 0x060005C6 RID: 1478
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x95F8E0", Offset = "0x95DEE0", VA = "0x18095F8E0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetHorizontalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		// Token: 0x060005C7 RID: 1479
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x95F980", Offset = "0x95DF80", VA = "0x18095F980")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetVerticalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		// Token: 0x060005C8 RID: 1480
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x95FA20", Offset = "0x95E020", VA = "0x18095FA20")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetKeyFocus(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bHasKeyFocus);

		// Token: 0x060005C9 RID: 1481
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x95FAC0", Offset = "0x95E0C0", VA = "0x18095FAC0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_ViewSource(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005CA RID: 1482
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x95FB50", Offset = "0x95E150", VA = "0x18095FB50")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_CopyToClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005CB RID: 1483
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x95FBE0", Offset = "0x95E1E0", VA = "0x18095FBE0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_PasteFromClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005CC RID: 1484
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x95FC70", Offset = "0x95E270", VA = "0x18095FC70")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_Find(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchSearchStr, bool bCurrentlyInFind, bool bReverse);

		// Token: 0x060005CD RID: 1485
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x95FD80", Offset = "0x95E380", VA = "0x18095FD80")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_StopFind(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005CE RID: 1486
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x95FE10", Offset = "0x95E410", VA = "0x18095FE10")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_GetLinkAtPosition(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y);

		// Token: 0x060005CF RID: 1487
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x95FEB0", Offset = "0x95E4B0", VA = "0x18095FEB0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetCookie(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchHostname, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue, InteropHelp.UTF8StringHandle pchPath, uint nExpires, bool bSecure, bool bHTTPOnly);

		// Token: 0x060005D0 RID: 1488
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x960100", Offset = "0x95E700", VA = "0x180960100")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetPageScaleFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);

		// Token: 0x060005D1 RID: 1489
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x9601B0", Offset = "0x95E7B0", VA = "0x1809601B0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetBackgroundMode(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bBackgroundMode);

		// Token: 0x060005D2 RID: 1490
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x960250", Offset = "0x95E850", VA = "0x180960250")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetDPIScalingFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flDPIScaling);

		// Token: 0x060005D3 RID: 1491
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x9602F0", Offset = "0x95E8F0", VA = "0x1809602F0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_OpenDeveloperTools(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005D4 RID: 1492
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x960380", Offset = "0x95E980", VA = "0x180960380")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_AllowStartRequest(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bAllowed);

		// Token: 0x060005D5 RID: 1493
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x960420", Offset = "0x95EA20", VA = "0x180960420")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_JSDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bResult);

		// Token: 0x060005D6 RID: 1494
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x9604C0", Offset = "0x95EAC0", VA = "0x1809604C0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_FileLoadDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles);

		// Token: 0x060005D7 RID: 1495
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x960560", Offset = "0x95EB60", VA = "0x180960560")]
		[PreserveSig]
		public static extern uint ISteamHTTP_CreateHTTPRequest(IntPtr instancePtr, EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL);

		// Token: 0x060005D8 RID: 1496
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x960640", Offset = "0x95EC40", VA = "0x180960640")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestContextValue(IntPtr instancePtr, HTTPRequestHandle hRequest, ulong ulContextValue);

		// Token: 0x060005D9 RID: 1497
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x9606E0", Offset = "0x95ECE0", VA = "0x1809606E0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		// Token: 0x060005DA RID: 1498
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x960780", Offset = "0x95ED80", VA = "0x180960780")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue);

		// Token: 0x060005DB RID: 1499
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x9608E0", Offset = "0x95EEE0", VA = "0x1809608E0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue);

		// Token: 0x060005DC RID: 1500
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x960A40", Offset = "0x95F040", VA = "0x180960A40")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SendHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		// Token: 0x060005DD RID: 1501
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x960AE0", Offset = "0x95F0E0", VA = "0x180960AE0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		// Token: 0x060005DE RID: 1502
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x960B80", Offset = "0x95F180", VA = "0x180960B80")]
		[PreserveSig]
		public static extern bool ISteamHTTP_DeferHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		// Token: 0x060005DF RID: 1503
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x960C10", Offset = "0x95F210", VA = "0x180960C10")]
		[PreserveSig]
		public static extern bool ISteamHTTP_PrioritizeHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		// Token: 0x060005E0 RID: 1504
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x960CA0", Offset = "0x95F2A0", VA = "0x180960CA0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize);

		// Token: 0x060005E1 RID: 1505
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x960D90", Offset = "0x95F390", VA = "0x180960D90")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize);

		// Token: 0x060005E2 RID: 1506
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x960EB0", Offset = "0x95F4B0", VA = "0x180960EB0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPResponseBodySize(IntPtr instancePtr, HTTPRequestHandle hRequest, out uint unBodySize);

		// Token: 0x060005E3 RID: 1507
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x960F50", Offset = "0x95F550", VA = "0x180960F50")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize);

		// Token: 0x060005E4 RID: 1508
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x961000", Offset = "0x95F600", VA = "0x180961000")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize);

		// Token: 0x060005E5 RID: 1509
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x9610C0", Offset = "0x95F6C0", VA = "0x1809610C0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_ReleaseHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		// Token: 0x060005E6 RID: 1510
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x961150", Offset = "0x95F750", VA = "0x180961150")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(IntPtr instancePtr, HTTPRequestHandle hRequest, out float pflPercentOut);

		// Token: 0x060005E7 RID: 1511
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x9611F0", Offset = "0x95F7F0", VA = "0x1809611F0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, byte[] pubBody, uint unBodyLen);

		// Token: 0x060005E8 RID: 1512
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x961310", Offset = "0x95F910", VA = "0x180961310")]
		[PreserveSig]
		public static extern uint ISteamHTTP_CreateCookieContainer(IntPtr instancePtr, bool bAllowResponsesToModify);

		// Token: 0x060005E9 RID: 1513
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x9613A0", Offset = "0x95F9A0", VA = "0x1809613A0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_ReleaseCookieContainer(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer);

		// Token: 0x060005EA RID: 1514
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x961430", Offset = "0x95FA30", VA = "0x180961430")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetCookie(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie);

		// Token: 0x060005EB RID: 1515
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x961600", Offset = "0x95FC00", VA = "0x180961600")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestCookieContainer(IntPtr instancePtr, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		// Token: 0x060005EC RID: 1516
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x9616A0", Offset = "0x95FCA0", VA = "0x1809616A0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestUserAgentInfo(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo);

		// Token: 0x060005ED RID: 1517
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x961790", Offset = "0x95FD90", VA = "0x180961790")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(IntPtr instancePtr, HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);

		// Token: 0x060005EE RID: 1518
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x961830", Offset = "0x95FE30", VA = "0x180961830")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unMilliseconds);

		// Token: 0x060005EF RID: 1519
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x9618D0", Offset = "0x95FED0", VA = "0x1809618D0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPRequestWasTimedOut(IntPtr instancePtr, HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		// Token: 0x060005F0 RID: 1520
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x961980", Offset = "0x95FF80", VA = "0x180961980")]
		[PreserveSig]
		public static extern bool ISteamInput_Init(IntPtr instancePtr, bool bExplicitlyCallRunFrame);

		// Token: 0x060005F1 RID: 1521
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x961A10", Offset = "0x960010", VA = "0x180961A10")]
		[PreserveSig]
		public static extern bool ISteamInput_Shutdown(IntPtr instancePtr);

		// Token: 0x060005F2 RID: 1522
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x961A90", Offset = "0x960090", VA = "0x180961A90")]
		[PreserveSig]
		public static extern bool ISteamInput_SetInputActionManifestFilePath(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchInputActionManifestAbsolutePath);

		// Token: 0x060005F3 RID: 1523
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x961B70", Offset = "0x960170", VA = "0x180961B70")]
		[PreserveSig]
		public static extern void ISteamInput_RunFrame(IntPtr instancePtr, bool bReservedValue);

		// Token: 0x060005F4 RID: 1524
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x961C00", Offset = "0x960200", VA = "0x180961C00")]
		[PreserveSig]
		public static extern bool ISteamInput_BWaitForData(IntPtr instancePtr, bool bWaitForever, uint unTimeout);

		// Token: 0x060005F5 RID: 1525
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x961CA0", Offset = "0x9602A0", VA = "0x180961CA0")]
		[PreserveSig]
		public static extern bool ISteamInput_BNewDataAvailable(IntPtr instancePtr);

		// Token: 0x060005F6 RID: 1526
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x961D20", Offset = "0x960320", VA = "0x180961D20")]
		[PreserveSig]
		public static extern int ISteamInput_GetConnectedControllers(IntPtr instancePtr, [In] [Out] InputHandle_t[] handlesOut);

		// Token: 0x060005F7 RID: 1527
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x961DC0", Offset = "0x9603C0", VA = "0x180961DC0")]
		[PreserveSig]
		public static extern void ISteamInput_EnableDeviceCallbacks(IntPtr instancePtr);

		// Token: 0x060005F8 RID: 1528
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x961E40", Offset = "0x960440", VA = "0x180961E40")]
		[PreserveSig]
		public static extern void ISteamInput_EnableActionEventCallbacks(IntPtr instancePtr, SteamInputActionEventCallbackPointer pCallback);

		// Token: 0x060005F9 RID: 1529
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x961EE0", Offset = "0x9604E0", VA = "0x180961EE0")]
		[PreserveSig]
		public static extern ulong ISteamInput_GetActionSetHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionSetName);

		// Token: 0x060005FA RID: 1530
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x961FC0", Offset = "0x9605C0", VA = "0x180961FC0")]
		[PreserveSig]
		public static extern void ISteamInput_ActivateActionSet(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle);

		// Token: 0x060005FB RID: 1531
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x962060", Offset = "0x960660", VA = "0x180962060")]
		[PreserveSig]
		public static extern ulong ISteamInput_GetCurrentActionSet(IntPtr instancePtr, InputHandle_t inputHandle);

		// Token: 0x060005FC RID: 1532
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x9620F0", Offset = "0x9606F0", VA = "0x1809620F0")]
		[PreserveSig]
		public static extern void ISteamInput_ActivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle);

		// Token: 0x060005FD RID: 1533
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x962190", Offset = "0x960790", VA = "0x180962190")]
		[PreserveSig]
		public static extern void ISteamInput_DeactivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle);

		// Token: 0x060005FE RID: 1534
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x962230", Offset = "0x960830", VA = "0x180962230")]
		[PreserveSig]
		public static extern void ISteamInput_DeactivateAllActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle);

		// Token: 0x060005FF RID: 1535
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x9622C0", Offset = "0x9608C0", VA = "0x1809622C0")]
		[PreserveSig]
		public static extern int ISteamInput_GetActiveActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle, [In] [Out] InputActionSetHandle_t[] handlesOut);

		// Token: 0x06000600 RID: 1536
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x962360", Offset = "0x960960", VA = "0x180962360")]
		[PreserveSig]
		public static extern ulong ISteamInput_GetDigitalActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName);

		// Token: 0x06000601 RID: 1537
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x962440", Offset = "0x960A40", VA = "0x180962440")]
		[PreserveSig]
		public static extern InputDigitalActionData_t ISteamInput_GetDigitalActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle);

		// Token: 0x06000602 RID: 1538
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x9624E0", Offset = "0x960AE0", VA = "0x1809624E0")]
		[PreserveSig]
		public static extern int ISteamInput_GetDigitalActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, [In] [Out] EInputActionOrigin[] originsOut);

		// Token: 0x06000603 RID: 1539
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x9625B0", Offset = "0x960BB0", VA = "0x1809625B0")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetStringForDigitalActionName(IntPtr instancePtr, InputDigitalActionHandle_t eActionHandle);

		// Token: 0x06000604 RID: 1540
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x962640", Offset = "0x960C40", VA = "0x180962640")]
		[PreserveSig]
		public static extern ulong ISteamInput_GetAnalogActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName);

		// Token: 0x06000605 RID: 1541
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x962720", Offset = "0x960D20", VA = "0x180962720")]
		[PreserveSig]
		public static extern InputAnalogActionData_t ISteamInput_GetAnalogActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle);

		// Token: 0x06000606 RID: 1542
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x9627E0", Offset = "0x960DE0", VA = "0x1809627E0")]
		[PreserveSig]
		public static extern int ISteamInput_GetAnalogActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, [In] [Out] EInputActionOrigin[] originsOut);

		// Token: 0x06000607 RID: 1543
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x9628B0", Offset = "0x960EB0", VA = "0x1809628B0")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetGlyphPNGForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, uint unFlags);

		// Token: 0x06000608 RID: 1544
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x962950", Offset = "0x960F50", VA = "0x180962950")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetGlyphSVGForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin, uint unFlags);

		// Token: 0x06000609 RID: 1545
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x9629F0", Offset = "0x960FF0", VA = "0x1809629F0")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetGlyphForActionOrigin_Legacy(IntPtr instancePtr, EInputActionOrigin eOrigin);

		// Token: 0x0600060A RID: 1546
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x962A80", Offset = "0x961080", VA = "0x180962A80")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetStringForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin);

		// Token: 0x0600060B RID: 1547
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x962B10", Offset = "0x961110", VA = "0x180962B10")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetStringForAnalogActionName(IntPtr instancePtr, InputAnalogActionHandle_t eActionHandle);

		// Token: 0x0600060C RID: 1548
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x962BA0", Offset = "0x9611A0", VA = "0x180962BA0")]
		[PreserveSig]
		public static extern void ISteamInput_StopAnalogActionMomentum(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t eAction);

		// Token: 0x0600060D RID: 1549
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x962C40", Offset = "0x961240", VA = "0x180962C40")]
		[PreserveSig]
		public static extern InputMotionData_t ISteamInput_GetMotionData(IntPtr instancePtr, InputHandle_t inputHandle);

		// Token: 0x0600060E RID: 1550
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x962CF0", Offset = "0x9612F0", VA = "0x180962CF0")]
		[PreserveSig]
		public static extern void ISteamInput_TriggerVibration(IntPtr instancePtr, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed);

		// Token: 0x0600060F RID: 1551
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x962DA0", Offset = "0x9613A0", VA = "0x180962DA0")]
		[PreserveSig]
		public static extern void ISteamInput_TriggerVibrationExtended(IntPtr instancePtr, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed);

		// Token: 0x06000610 RID: 1552
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x962E70", Offset = "0x961470", VA = "0x180962E70")]
		[PreserveSig]
		public static extern void ISteamInput_TriggerSimpleHapticEvent(IntPtr instancePtr, InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB);

		// Token: 0x06000611 RID: 1553
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x962F50", Offset = "0x961550", VA = "0x180962F50")]
		[PreserveSig]
		public static extern void ISteamInput_SetLEDColor(IntPtr instancePtr, InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);

		// Token: 0x06000612 RID: 1554
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x963010", Offset = "0x961610", VA = "0x180963010")]
		[PreserveSig]
		public static extern void ISteamInput_Legacy_TriggerHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec);

		// Token: 0x06000613 RID: 1555
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x9630C0", Offset = "0x9616C0", VA = "0x1809630C0")]
		[PreserveSig]
		public static extern void ISteamInput_Legacy_TriggerRepeatedHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);

		// Token: 0x06000614 RID: 1556
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x963190", Offset = "0x961790", VA = "0x180963190")]
		[PreserveSig]
		public static extern bool ISteamInput_ShowBindingPanel(IntPtr instancePtr, InputHandle_t inputHandle);

		// Token: 0x06000615 RID: 1557
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x963220", Offset = "0x961820", VA = "0x180963220")]
		[PreserveSig]
		public static extern ESteamInputType ISteamInput_GetInputTypeForHandle(IntPtr instancePtr, InputHandle_t inputHandle);

		// Token: 0x06000616 RID: 1558
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x9632B0", Offset = "0x9618B0", VA = "0x1809632B0")]
		[PreserveSig]
		public static extern ulong ISteamInput_GetControllerForGamepadIndex(IntPtr instancePtr, int nIndex);

		// Token: 0x06000617 RID: 1559
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x963340", Offset = "0x961940", VA = "0x180963340")]
		[PreserveSig]
		public static extern int ISteamInput_GetGamepadIndexForController(IntPtr instancePtr, InputHandle_t ulinputHandle);

		// Token: 0x06000618 RID: 1560
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x9633D0", Offset = "0x9619D0", VA = "0x1809633D0")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetStringForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin);

		// Token: 0x06000619 RID: 1561
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x963460", Offset = "0x961A60", VA = "0x180963460")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetGlyphForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin);

		// Token: 0x0600061A RID: 1562
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x9634F0", Offset = "0x961AF0", VA = "0x1809634F0")]
		[PreserveSig]
		public static extern EInputActionOrigin ISteamInput_GetActionOriginFromXboxOrigin(IntPtr instancePtr, InputHandle_t inputHandle, EXboxOrigin eOrigin);

		// Token: 0x0600061B RID: 1563
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x963590", Offset = "0x961B90", VA = "0x180963590")]
		[PreserveSig]
		public static extern EInputActionOrigin ISteamInput_TranslateActionOrigin(IntPtr instancePtr, ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin);

		// Token: 0x0600061C RID: 1564
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x963630", Offset = "0x961C30", VA = "0x180963630")]
		[PreserveSig]
		public static extern bool ISteamInput_GetDeviceBindingRevision(IntPtr instancePtr, InputHandle_t inputHandle, out int pMajor, out int pMinor);

		// Token: 0x0600061D RID: 1565
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x9636E0", Offset = "0x961CE0", VA = "0x1809636E0")]
		[PreserveSig]
		public static extern uint ISteamInput_GetRemotePlaySessionID(IntPtr instancePtr, InputHandle_t inputHandle);

		// Token: 0x0600061E RID: 1566
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x963770", Offset = "0x961D70", VA = "0x180963770")]
		[PreserveSig]
		public static extern ushort ISteamInput_GetSessionInputConfigurationSettings(IntPtr instancePtr);

		// Token: 0x0600061F RID: 1567
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x9637F0", Offset = "0x961DF0", VA = "0x1809637F0")]
		[PreserveSig]
		public static extern EResult ISteamInventory_GetResultStatus(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		// Token: 0x06000620 RID: 1568
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x963880", Offset = "0x961E80", VA = "0x180963880")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetResultItems(IntPtr instancePtr, SteamInventoryResult_t resultHandle, [In] [Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		// Token: 0x06000621 RID: 1569
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x963930", Offset = "0x961F30", VA = "0x180963930")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetResultItemProperty(IntPtr instancePtr, SteamInventoryResult_t resultHandle, uint unItemIndex, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		// Token: 0x06000622 RID: 1570
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x963A50", Offset = "0x962050", VA = "0x180963A50")]
		[PreserveSig]
		public static extern uint ISteamInventory_GetResultTimestamp(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		// Token: 0x06000623 RID: 1571
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x963AE0", Offset = "0x9620E0", VA = "0x180963AE0")]
		[PreserveSig]
		public static extern bool ISteamInventory_CheckResultSteamID(IntPtr instancePtr, SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		// Token: 0x06000624 RID: 1572
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x963B80", Offset = "0x962180", VA = "0x180963B80")]
		[PreserveSig]
		public static extern void ISteamInventory_DestroyResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		// Token: 0x06000625 RID: 1573
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x963C10", Offset = "0x962210", VA = "0x180963C10")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetAllItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle);

		// Token: 0x06000626 RID: 1574
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x963CA0", Offset = "0x9622A0", VA = "0x180963CA0")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetItemsByID(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		// Token: 0x06000627 RID: 1575
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x963D60", Offset = "0x962360", VA = "0x180963D60")]
		[PreserveSig]
		public static extern bool ISteamInventory_SerializeResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize);

		// Token: 0x06000628 RID: 1576
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x963E10", Offset = "0x962410", VA = "0x180963E10")]
		[PreserveSig]
		public static extern bool ISteamInventory_DeserializeResult(IntPtr instancePtr, out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE);

		// Token: 0x06000629 RID: 1577
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x963ED0", Offset = "0x9624D0", VA = "0x180963ED0")]
		[PreserveSig]
		public static extern bool ISteamInventory_GenerateItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemDef_t[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength);

		// Token: 0x0600062A RID: 1578
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x963FA0", Offset = "0x9625A0", VA = "0x180963FA0")]
		[PreserveSig]
		public static extern bool ISteamInventory_GrantPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle);

		// Token: 0x0600062B RID: 1579
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x964030", Offset = "0x962630", VA = "0x180964030")]
		[PreserveSig]
		public static extern bool ISteamInventory_AddPromoItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		// Token: 0x0600062C RID: 1580
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x9640D0", Offset = "0x9626D0", VA = "0x1809640D0")]
		[PreserveSig]
		public static extern bool ISteamInventory_AddPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		// Token: 0x0600062D RID: 1581
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x964190", Offset = "0x962790", VA = "0x180964190")]
		[PreserveSig]
		public static extern bool ISteamInventory_ConsumeItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		// Token: 0x0600062E RID: 1582
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x964240", Offset = "0x962840", VA = "0x180964240")]
		[PreserveSig]
		public static extern bool ISteamInventory_ExchangeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemDef_t[] pArrayGenerate, [In] [Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] SteamItemInstanceID_t[] pArrayDestroy, [In] [Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		// Token: 0x0600062F RID: 1583
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x964350", Offset = "0x962950", VA = "0x180964350")]
		[PreserveSig]
		public static extern bool ISteamInventory_TransferItemQuantity(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		// Token: 0x06000630 RID: 1584
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x964410", Offset = "0x962A10", VA = "0x180964410")]
		[PreserveSig]
		public static extern void ISteamInventory_SendItemDropHeartbeat(IntPtr instancePtr);

		// Token: 0x06000631 RID: 1585
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x964490", Offset = "0x962A90", VA = "0x180964490")]
		[PreserveSig]
		public static extern bool ISteamInventory_TriggerItemDrop(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		// Token: 0x06000632 RID: 1586
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x964530", Offset = "0x962B30", VA = "0x180964530")]
		[PreserveSig]
		public static extern bool ISteamInventory_TradeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In] [Out] SteamItemInstanceID_t[] pArrayGive, [In] [Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In] [Out] SteamItemInstanceID_t[] pArrayGet, [In] [Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		// Token: 0x06000633 RID: 1587
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x964650", Offset = "0x962C50", VA = "0x180964650")]
		[PreserveSig]
		public static extern bool ISteamInventory_LoadItemDefinitions(IntPtr instancePtr);

		// Token: 0x06000634 RID: 1588
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x9646D0", Offset = "0x962CD0", VA = "0x1809646D0")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetItemDefinitionIDs(IntPtr instancePtr, [In] [Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		// Token: 0x06000635 RID: 1589
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x964780", Offset = "0x962D80", VA = "0x180964780")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetItemDefinitionProperty(IntPtr instancePtr, SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		// Token: 0x06000636 RID: 1590
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x964890", Offset = "0x962E90", VA = "0x180964890")]
		[PreserveSig]
		public static extern ulong ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x06000637 RID: 1591
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x964920", Offset = "0x962F20", VA = "0x180964920")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetEligiblePromoItemDefinitionIDs(IntPtr instancePtr, CSteamID steamID, [In] [Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		// Token: 0x06000638 RID: 1592
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x9649E0", Offset = "0x962FE0", VA = "0x1809649E0")]
		[PreserveSig]
		public static extern ulong ISteamInventory_StartPurchase(IntPtr instancePtr, [In] [Out] SteamItemDef_t[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength);

		// Token: 0x06000639 RID: 1593
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x964AA0", Offset = "0x9630A0", VA = "0x180964AA0")]
		[PreserveSig]
		public static extern ulong ISteamInventory_RequestPrices(IntPtr instancePtr);

		// Token: 0x0600063A RID: 1594
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x964B20", Offset = "0x963120", VA = "0x180964B20")]
		[PreserveSig]
		public static extern uint ISteamInventory_GetNumItemsWithPrices(IntPtr instancePtr);

		// Token: 0x0600063B RID: 1595
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x964BA0", Offset = "0x9631A0", VA = "0x180964BA0")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetItemsWithPrices(IntPtr instancePtr, [In] [Out] SteamItemDef_t[] pArrayItemDefs, [In] [Out] ulong[] pCurrentPrices, [In] [Out] ulong[] pBasePrices, uint unArrayLength);

		// Token: 0x0600063C RID: 1596
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x964C80", Offset = "0x963280", VA = "0x180964C80")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetItemPrice(IntPtr instancePtr, SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice);

		// Token: 0x0600063D RID: 1597
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x964D30", Offset = "0x963330", VA = "0x180964D30")]
		[PreserveSig]
		public static extern ulong ISteamInventory_StartUpdateProperties(IntPtr instancePtr);

		// Token: 0x0600063E RID: 1598
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x964DB0", Offset = "0x9633B0", VA = "0x180964DB0")]
		[PreserveSig]
		public static extern bool ISteamInventory_RemoveProperty(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName);

		// Token: 0x0600063F RID: 1599
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x964EB0", Offset = "0x9634B0", VA = "0x180964EB0")]
		[PreserveSig]
		public static extern bool ISteamInventory_SetPropertyString(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, InteropHelp.UTF8StringHandle pchPropertyValue);

		// Token: 0x06000640 RID: 1600
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x965030", Offset = "0x963630", VA = "0x180965030")]
		[PreserveSig]
		public static extern bool ISteamInventory_SetPropertyBool(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, bool bValue);

		// Token: 0x06000641 RID: 1601
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x965140", Offset = "0x963740", VA = "0x180965140")]
		[PreserveSig]
		public static extern bool ISteamInventory_SetPropertyInt64(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, long nValue);

		// Token: 0x06000642 RID: 1602
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x965250", Offset = "0x963850", VA = "0x180965250")]
		[PreserveSig]
		public static extern bool ISteamInventory_SetPropertyFloat(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, float flValue);

		// Token: 0x06000643 RID: 1603
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x965360", Offset = "0x963960", VA = "0x180965360")]
		[PreserveSig]
		public static extern bool ISteamInventory_SubmitUpdateProperties(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle);

		// Token: 0x06000644 RID: 1604
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x965400", Offset = "0x963A00", VA = "0x180965400")]
		[PreserveSig]
		public static extern bool ISteamInventory_InspectItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, InteropHelp.UTF8StringHandle pchItemToken);

		// Token: 0x06000645 RID: 1605
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x9654F0", Offset = "0x963AF0", VA = "0x1809654F0")]
		[PreserveSig]
		public static extern int ISteamMatchmaking_GetFavoriteGameCount(IntPtr instancePtr);

		// Token: 0x06000646 RID: 1606
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x965570", Offset = "0x963B70", VA = "0x180965570")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_GetFavoriteGame(IntPtr instancePtr, int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer);

		// Token: 0x06000647 RID: 1607
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x965650", Offset = "0x963C50", VA = "0x180965650")]
		[PreserveSig]
		public static extern int ISteamMatchmaking_AddFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);

		// Token: 0x06000648 RID: 1608
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x965710", Offset = "0x963D10", VA = "0x180965710")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_RemoveFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);

		// Token: 0x06000649 RID: 1609
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x9657E0", Offset = "0x963DE0", VA = "0x1809657E0")]
		[PreserveSig]
		public static extern ulong ISteamMatchmaking_RequestLobbyList(IntPtr instancePtr);

		// Token: 0x0600064A RID: 1610
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x965860", Offset = "0x963E60", VA = "0x180965860")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, InteropHelp.UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType);

		// Token: 0x0600064B RID: 1611
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x9659B0", Offset = "0x963FB0", VA = "0x1809659B0")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType);

		// Token: 0x0600064C RID: 1612
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x965AA0", Offset = "0x9640A0", VA = "0x180965AA0")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo);

		// Token: 0x0600064D RID: 1613
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x965B80", Offset = "0x964180", VA = "0x180965B80")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(IntPtr instancePtr, int nSlotsAvailable);

		// Token: 0x0600064E RID: 1614
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x965C10", Offset = "0x964210", VA = "0x180965C10")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(IntPtr instancePtr, ELobbyDistanceFilter eLobbyDistanceFilter);

		// Token: 0x0600064F RID: 1615
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x965CA0", Offset = "0x9642A0", VA = "0x180965CA0")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(IntPtr instancePtr, int cMaxResults);

		// Token: 0x06000650 RID: 1616
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x965D30", Offset = "0x964330", VA = "0x180965D30")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000651 RID: 1617
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x965DC0", Offset = "0x9643C0", VA = "0x180965DC0")]
		[PreserveSig]
		public static extern ulong ISteamMatchmaking_GetLobbyByIndex(IntPtr instancePtr, int iLobby);

		// Token: 0x06000652 RID: 1618
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x965E50", Offset = "0x964450", VA = "0x180965E50")]
		[PreserveSig]
		public static extern ulong ISteamMatchmaking_CreateLobby(IntPtr instancePtr, ELobbyType eLobbyType, int cMaxMembers);

		// Token: 0x06000653 RID: 1619
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x965EF0", Offset = "0x9644F0", VA = "0x180965EF0")]
		[PreserveSig]
		public static extern ulong ISteamMatchmaking_JoinLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000654 RID: 1620
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x965F80", Offset = "0x964580", VA = "0x180965F80")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_LeaveLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000655 RID: 1621
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x966010", Offset = "0x964610", VA = "0x180966010")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_InviteUserToLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDInvitee);

		// Token: 0x06000656 RID: 1622
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x9660B0", Offset = "0x9646B0", VA = "0x1809660B0")]
		[PreserveSig]
		public static extern int ISteamMatchmaking_GetNumLobbyMembers(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000657 RID: 1623
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x966140", Offset = "0x964740", VA = "0x180966140")]
		[PreserveSig]
		public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iMember);

		// Token: 0x06000658 RID: 1624
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x9661E0", Offset = "0x9647E0", VA = "0x1809661E0")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmaking_GetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x06000659 RID: 1625
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x9662D0", Offset = "0x9648D0", VA = "0x1809662D0")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x0600065A RID: 1626
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x966430", Offset = "0x964A30", VA = "0x180966430")]
		[PreserveSig]
		public static extern int ISteamMatchmaking_GetLobbyDataCount(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x0600065B RID: 1627
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x9664C0", Offset = "0x964AC0", VA = "0x1809664C0")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize);

		// Token: 0x0600065C RID: 1628
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x966590", Offset = "0x964B90", VA = "0x180966590")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_DeleteLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x0600065D RID: 1629
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x966680", Offset = "0x964C80", VA = "0x180966680")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmaking_GetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x0600065E RID: 1630
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x966770", Offset = "0x964D70", VA = "0x180966770")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_SetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x0600065F RID: 1631
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x9668C0", Offset = "0x964EC0", VA = "0x1809668C0")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SendLobbyChatMsg(IntPtr instancePtr, CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody);

		// Token: 0x06000660 RID: 1632
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x966980", Offset = "0x964F80", VA = "0x180966980")]
		[PreserveSig]
		public static extern int ISteamMatchmaking_GetLobbyChatEntry(IntPtr instancePtr, CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType);

		// Token: 0x06000661 RID: 1633
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x966A50", Offset = "0x965050", VA = "0x180966A50")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_RequestLobbyData(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000662 RID: 1634
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x966AE0", Offset = "0x9650E0", VA = "0x180966AE0")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_SetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer);

		// Token: 0x06000663 RID: 1635
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x966B90", Offset = "0x965190", VA = "0x180966B90")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_GetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer);

		// Token: 0x06000664 RID: 1636
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x966C50", Offset = "0x965250", VA = "0x180966C50")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby, int cMaxMembers);

		// Token: 0x06000665 RID: 1637
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x966CF0", Offset = "0x9652F0", VA = "0x180966CF0")]
		[PreserveSig]
		public static extern int ISteamMatchmaking_GetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000666 RID: 1638
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x966D80", Offset = "0x965380", VA = "0x180966D80")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyType(IntPtr instancePtr, CSteamID steamIDLobby, ELobbyType eLobbyType);

		// Token: 0x06000667 RID: 1639
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x966E20", Offset = "0x965420", VA = "0x180966E20")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyJoinable(IntPtr instancePtr, CSteamID steamIDLobby, bool bLobbyJoinable);

		// Token: 0x06000668 RID: 1640
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x966EC0", Offset = "0x9654C0", VA = "0x180966EC0")]
		[PreserveSig]
		public static extern ulong ISteamMatchmaking_GetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000669 RID: 1641
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x966F50", Offset = "0x965550", VA = "0x180966F50")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDNewOwner);

		// Token: 0x0600066A RID: 1642
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x966FF0", Offset = "0x9655F0", VA = "0x180966FF0")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLinkedLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDLobbyDependent);

		// Token: 0x0600066B RID: 1643
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x967090", Offset = "0x965690", VA = "0x180967090")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestInternetServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x0600066C RID: 1644
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x967140", Offset = "0x965740", VA = "0x180967140")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestLANServerList(IntPtr instancePtr, AppId_t iApp, IntPtr pRequestServersResponse);

		// Token: 0x0600066D RID: 1645
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x9671E0", Offset = "0x9657E0", VA = "0x1809671E0")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestFriendsServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x0600066E RID: 1646
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x967290", Offset = "0x965890", VA = "0x180967290")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x0600066F RID: 1647
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x967340", Offset = "0x965940", VA = "0x180967340")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestHistoryServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x06000670 RID: 1648
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x9673F0", Offset = "0x9659F0", VA = "0x1809673F0")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x06000671 RID: 1649
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x9674A0", Offset = "0x965AA0", VA = "0x1809674A0")]
		[PreserveSig]
		public static extern void ISteamMatchmakingServers_ReleaseRequest(IntPtr instancePtr, HServerListRequest hServerListRequest);

		// Token: 0x06000672 RID: 1650
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x967530", Offset = "0x965B30", VA = "0x180967530")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(IntPtr instancePtr, HServerListRequest hRequest, int iServer);

		// Token: 0x06000673 RID: 1651
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x9675D0", Offset = "0x965BD0", VA = "0x1809675D0")]
		[PreserveSig]
		public static extern void ISteamMatchmakingServers_CancelQuery(IntPtr instancePtr, HServerListRequest hRequest);

		// Token: 0x06000674 RID: 1652
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x967660", Offset = "0x965C60", VA = "0x180967660")]
		[PreserveSig]
		public static extern void ISteamMatchmakingServers_RefreshQuery(IntPtr instancePtr, HServerListRequest hRequest);

		// Token: 0x06000675 RID: 1653
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x9676F0", Offset = "0x965CF0", VA = "0x1809676F0")]
		[PreserveSig]
		public static extern bool ISteamMatchmakingServers_IsRefreshing(IntPtr instancePtr, HServerListRequest hRequest);

		// Token: 0x06000676 RID: 1654
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x967780", Offset = "0x965D80", VA = "0x180967780")]
		[PreserveSig]
		public static extern int ISteamMatchmakingServers_GetServerCount(IntPtr instancePtr, HServerListRequest hRequest);

		// Token: 0x06000677 RID: 1655
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x967810", Offset = "0x965E10", VA = "0x180967810")]
		[PreserveSig]
		public static extern void ISteamMatchmakingServers_RefreshServer(IntPtr instancePtr, HServerListRequest hRequest, int iServer);

		// Token: 0x06000678 RID: 1656
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x9678B0", Offset = "0x965EB0", VA = "0x1809678B0")]
		[PreserveSig]
		public static extern int ISteamMatchmakingServers_PingServer(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		// Token: 0x06000679 RID: 1657
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x967960", Offset = "0x965F60", VA = "0x180967960")]
		[PreserveSig]
		public static extern int ISteamMatchmakingServers_PlayerDetails(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		// Token: 0x0600067A RID: 1658
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x967A10", Offset = "0x966010", VA = "0x180967A10")]
		[PreserveSig]
		public static extern int ISteamMatchmakingServers_ServerRules(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		// Token: 0x0600067B RID: 1659
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x967AC0", Offset = "0x9660C0", VA = "0x180967AC0")]
		[PreserveSig]
		public static extern void ISteamMatchmakingServers_CancelServerQuery(IntPtr instancePtr, HServerQuery hServerQuery);

		// Token: 0x0600067C RID: 1660
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x967B50", Offset = "0x966150", VA = "0x180967B50")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_AddGameSearchParams(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToFind, InteropHelp.UTF8StringHandle pchValuesToFind);

		// Token: 0x0600067D RID: 1661
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x967C90", Offset = "0x966290", VA = "0x180967C90")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SearchForGameWithLobby(IntPtr instancePtr, CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax);

		// Token: 0x0600067E RID: 1662
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x967D40", Offset = "0x966340", VA = "0x180967D40")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SearchForGameSolo(IntPtr instancePtr, int nPlayerMin, int nPlayerMax);

		// Token: 0x0600067F RID: 1663
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x967DE0", Offset = "0x9663E0", VA = "0x180967DE0")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_AcceptGame(IntPtr instancePtr);

		// Token: 0x06000680 RID: 1664
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x967E60", Offset = "0x966460", VA = "0x180967E60")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_DeclineGame(IntPtr instancePtr);

		// Token: 0x06000681 RID: 1665
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x967EE0", Offset = "0x9664E0", VA = "0x180967EE0")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_RetrieveConnectionDetails(IntPtr instancePtr, CSteamID steamIDHost, IntPtr pchConnectionDetails, int cubConnectionDetails);

		// Token: 0x06000682 RID: 1666
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x967F90", Offset = "0x966590", VA = "0x180967F90")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_EndGameSearch(IntPtr instancePtr);

		// Token: 0x06000683 RID: 1667
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x968010", Offset = "0x966610", VA = "0x180968010")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SetGameHostParams(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x06000684 RID: 1668
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x968150", Offset = "0x966750", VA = "0x180968150")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SetConnectionDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchConnectionDetails, int cubConnectionDetails);

		// Token: 0x06000685 RID: 1669
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x968230", Offset = "0x966830", VA = "0x180968230")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_RequestPlayersForGame(IntPtr instancePtr, int nPlayerMin, int nPlayerMax, int nMaxTeamSize);

		// Token: 0x06000686 RID: 1670
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x9682D0", Offset = "0x9668D0", VA = "0x1809682D0")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_HostConfirmGameStart(IntPtr instancePtr, ulong ullUniqueGameID);

		// Token: 0x06000687 RID: 1671
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x968360", Offset = "0x966960", VA = "0x180968360")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_CancelRequestPlayersForGame(IntPtr instancePtr);

		// Token: 0x06000688 RID: 1672
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x9683E0", Offset = "0x9669E0", VA = "0x1809683E0")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SubmitPlayerResult(IntPtr instancePtr, ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult);

		// Token: 0x06000689 RID: 1673
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x968490", Offset = "0x966A90", VA = "0x180968490")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_EndGame(IntPtr instancePtr, ulong ullUniqueGameID);

		// Token: 0x0600068A RID: 1674
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x968520", Offset = "0x966B20", VA = "0x180968520")]
		[PreserveSig]
		public static extern uint ISteamParties_GetNumActiveBeacons(IntPtr instancePtr);

		// Token: 0x0600068B RID: 1675
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x9685A0", Offset = "0x966BA0", VA = "0x1809685A0")]
		[PreserveSig]
		public static extern ulong ISteamParties_GetBeaconByIndex(IntPtr instancePtr, uint unIndex);

		// Token: 0x0600068C RID: 1676
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x968630", Offset = "0x966C30", VA = "0x180968630")]
		[PreserveSig]
		public static extern bool ISteamParties_GetBeaconDetails(IntPtr instancePtr, PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, IntPtr pchMetadata, int cchMetadata);

		// Token: 0x0600068D RID: 1677
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x968700", Offset = "0x966D00", VA = "0x180968700")]
		[PreserveSig]
		public static extern ulong ISteamParties_JoinParty(IntPtr instancePtr, PartyBeaconID_t ulBeaconID);

		// Token: 0x0600068E RID: 1678
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x968790", Offset = "0x966D90", VA = "0x180968790")]
		[PreserveSig]
		public static extern bool ISteamParties_GetNumAvailableBeaconLocations(IntPtr instancePtr, out uint puNumLocations);

		// Token: 0x0600068F RID: 1679
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x968820", Offset = "0x966E20", VA = "0x180968820")]
		[PreserveSig]
		public static extern bool ISteamParties_GetAvailableBeaconLocations(IntPtr instancePtr, [In] [Out] SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations);

		// Token: 0x06000690 RID: 1680
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x9688D0", Offset = "0x966ED0", VA = "0x1809688D0")]
		[PreserveSig]
		public static extern ulong ISteamParties_CreateBeacon(IntPtr instancePtr, uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, InteropHelp.UTF8StringHandle pchConnectString, InteropHelp.UTF8StringHandle pchMetadata);

		// Token: 0x06000691 RID: 1681
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x968A50", Offset = "0x967050", VA = "0x180968A50")]
		[PreserveSig]
		public static extern void ISteamParties_OnReservationCompleted(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser);

		// Token: 0x06000692 RID: 1682
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x968AF0", Offset = "0x9670F0", VA = "0x180968AF0")]
		[PreserveSig]
		public static extern void ISteamParties_CancelReservation(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser);

		// Token: 0x06000693 RID: 1683
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x968B90", Offset = "0x967190", VA = "0x180968B90")]
		[PreserveSig]
		public static extern ulong ISteamParties_ChangeNumOpenSlots(IntPtr instancePtr, PartyBeaconID_t ulBeacon, uint unOpenSlots);

		// Token: 0x06000694 RID: 1684
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x968C30", Offset = "0x967230", VA = "0x180968C30")]
		[PreserveSig]
		public static extern bool ISteamParties_DestroyBeacon(IntPtr instancePtr, PartyBeaconID_t ulBeacon);

		// Token: 0x06000695 RID: 1685
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x968CC0", Offset = "0x9672C0", VA = "0x180968CC0")]
		[PreserveSig]
		public static extern bool ISteamParties_GetBeaconLocationData(IntPtr instancePtr, SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, IntPtr pchDataStringOut, int cchDataStringOut);

		// Token: 0x06000696 RID: 1686
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x968D80", Offset = "0x967380", VA = "0x180968D80")]
		[PreserveSig]
		public static extern bool ISteamMusic_BIsEnabled(IntPtr instancePtr);

		// Token: 0x06000697 RID: 1687
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x968E00", Offset = "0x967400", VA = "0x180968E00")]
		[PreserveSig]
		public static extern bool ISteamMusic_BIsPlaying(IntPtr instancePtr);

		// Token: 0x06000698 RID: 1688
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x968E80", Offset = "0x967480", VA = "0x180968E80")]
		[PreserveSig]
		public static extern AudioPlayback_Status ISteamMusic_GetPlaybackStatus(IntPtr instancePtr);

		// Token: 0x06000699 RID: 1689
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x968F00", Offset = "0x967500", VA = "0x180968F00")]
		[PreserveSig]
		public static extern void ISteamMusic_Play(IntPtr instancePtr);

		// Token: 0x0600069A RID: 1690
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x968F80", Offset = "0x967580", VA = "0x180968F80")]
		[PreserveSig]
		public static extern void ISteamMusic_Pause(IntPtr instancePtr);

		// Token: 0x0600069B RID: 1691
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x969000", Offset = "0x967600", VA = "0x180969000")]
		[PreserveSig]
		public static extern void ISteamMusic_PlayPrevious(IntPtr instancePtr);

		// Token: 0x0600069C RID: 1692
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x969080", Offset = "0x967680", VA = "0x180969080")]
		[PreserveSig]
		public static extern void ISteamMusic_PlayNext(IntPtr instancePtr);

		// Token: 0x0600069D RID: 1693
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x969100", Offset = "0x967700", VA = "0x180969100")]
		[PreserveSig]
		public static extern void ISteamMusic_SetVolume(IntPtr instancePtr, float flVolume);

		// Token: 0x0600069E RID: 1694
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x969190", Offset = "0x967790", VA = "0x180969190")]
		[PreserveSig]
		public static extern float ISteamMusic_GetVolume(IntPtr instancePtr);

		// Token: 0x0600069F RID: 1695
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x969210", Offset = "0x967810", VA = "0x180969210")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_RegisterSteamMusicRemote(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x060006A0 RID: 1696
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x9692F0", Offset = "0x9678F0", VA = "0x1809692F0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_DeregisterSteamMusicRemote(IntPtr instancePtr);

		// Token: 0x060006A1 RID: 1697
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x969370", Offset = "0x967970", VA = "0x180969370")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_BIsCurrentMusicRemote(IntPtr instancePtr);

		// Token: 0x060006A2 RID: 1698
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x9693F0", Offset = "0x9679F0", VA = "0x1809693F0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_BActivationSuccess(IntPtr instancePtr, bool bValue);

		// Token: 0x060006A3 RID: 1699
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x969480", Offset = "0x967A80", VA = "0x180969480")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetDisplayName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDisplayName);

		// Token: 0x060006A4 RID: 1700
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x969560", Offset = "0x967B60", VA = "0x180969560")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetPNGIcon_64x64(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength);

		// Token: 0x060006A5 RID: 1701
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x969610", Offset = "0x967C10", VA = "0x180969610")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnablePlayPrevious(IntPtr instancePtr, bool bValue);

		// Token: 0x060006A6 RID: 1702
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x9696A0", Offset = "0x967CA0", VA = "0x1809696A0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnablePlayNext(IntPtr instancePtr, bool bValue);

		// Token: 0x060006A7 RID: 1703
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x969730", Offset = "0x967D30", VA = "0x180969730")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnableShuffled(IntPtr instancePtr, bool bValue);

		// Token: 0x060006A8 RID: 1704
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x9697C0", Offset = "0x967DC0", VA = "0x1809697C0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnableLooped(IntPtr instancePtr, bool bValue);

		// Token: 0x060006A9 RID: 1705
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x969850", Offset = "0x967E50", VA = "0x180969850")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnableQueue(IntPtr instancePtr, bool bValue);

		// Token: 0x060006AA RID: 1706
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x9698E0", Offset = "0x967EE0", VA = "0x1809698E0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnablePlaylists(IntPtr instancePtr, bool bValue);

		// Token: 0x060006AB RID: 1707
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x969970", Offset = "0x967F70", VA = "0x180969970")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdatePlaybackStatus(IntPtr instancePtr, AudioPlayback_Status nStatus);

		// Token: 0x060006AC RID: 1708
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x969A00", Offset = "0x968000", VA = "0x180969A00")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateShuffled(IntPtr instancePtr, bool bValue);

		// Token: 0x060006AD RID: 1709
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x969A90", Offset = "0x968090", VA = "0x180969A90")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateLooped(IntPtr instancePtr, bool bValue);

		// Token: 0x060006AE RID: 1710
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x969B20", Offset = "0x968120", VA = "0x180969B20")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateVolume(IntPtr instancePtr, float flValue);

		// Token: 0x060006AF RID: 1711
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x969BB0", Offset = "0x9681B0", VA = "0x180969BB0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_CurrentEntryWillChange(IntPtr instancePtr);

		// Token: 0x060006B0 RID: 1712
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x969C30", Offset = "0x968230", VA = "0x180969C30")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_CurrentEntryIsAvailable(IntPtr instancePtr, bool bAvailable);

		// Token: 0x060006B1 RID: 1713
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x969CC0", Offset = "0x9682C0", VA = "0x180969CC0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryText(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchText);

		// Token: 0x060006B2 RID: 1714
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x969DA0", Offset = "0x9683A0", VA = "0x180969DA0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(IntPtr instancePtr, int nValue);

		// Token: 0x060006B3 RID: 1715
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x969E30", Offset = "0x968430", VA = "0x180969E30")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryCoverArt(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength);

		// Token: 0x060006B4 RID: 1716
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x969EE0", Offset = "0x9684E0", VA = "0x180969EE0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_CurrentEntryDidChange(IntPtr instancePtr);

		// Token: 0x060006B5 RID: 1717
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x969F60", Offset = "0x968560", VA = "0x180969F60")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_QueueWillChange(IntPtr instancePtr);

		// Token: 0x060006B6 RID: 1718
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x969FE0", Offset = "0x9685E0", VA = "0x180969FE0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_ResetQueueEntries(IntPtr instancePtr);

		// Token: 0x060006B7 RID: 1719
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x96A060", Offset = "0x968660", VA = "0x18096A060")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetQueueEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		// Token: 0x060006B8 RID: 1720
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x96A160", Offset = "0x968760", VA = "0x18096A160")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetCurrentQueueEntry(IntPtr instancePtr, int nID);

		// Token: 0x060006B9 RID: 1721
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x96A1F0", Offset = "0x9687F0", VA = "0x18096A1F0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_QueueDidChange(IntPtr instancePtr);

		// Token: 0x060006BA RID: 1722
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x96A270", Offset = "0x968870", VA = "0x18096A270")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_PlaylistWillChange(IntPtr instancePtr);

		// Token: 0x060006BB RID: 1723
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x96A2F0", Offset = "0x9688F0", VA = "0x18096A2F0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_ResetPlaylistEntries(IntPtr instancePtr);

		// Token: 0x060006BC RID: 1724
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x96A370", Offset = "0x968970", VA = "0x18096A370")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetPlaylistEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		// Token: 0x060006BD RID: 1725
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x96A470", Offset = "0x968A70", VA = "0x18096A470")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetCurrentPlaylistEntry(IntPtr instancePtr, int nID);

		// Token: 0x060006BE RID: 1726
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x96A500", Offset = "0x968B00", VA = "0x18096A500")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_PlaylistDidChange(IntPtr instancePtr);

		// Token: 0x060006BF RID: 1727
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x96A580", Offset = "0x968B80", VA = "0x18096A580")]
		[PreserveSig]
		public static extern bool ISteamNetworking_SendP2PPacket(IntPtr instancePtr, CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		// Token: 0x060006C0 RID: 1728
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x96A650", Offset = "0x968C50", VA = "0x18096A650")]
		[PreserveSig]
		public static extern bool ISteamNetworking_IsP2PPacketAvailable(IntPtr instancePtr, out uint pcubMsgSize, int nChannel);

		// Token: 0x060006C1 RID: 1729
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x96A6F0", Offset = "0x968CF0", VA = "0x18096A6F0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_ReadP2PPacket(IntPtr instancePtr, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		// Token: 0x060006C2 RID: 1730
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x96A7C0", Offset = "0x968DC0", VA = "0x18096A7C0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		// Token: 0x060006C3 RID: 1731
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x96A850", Offset = "0x968E50", VA = "0x18096A850")]
		[PreserveSig]
		public static extern bool ISteamNetworking_CloseP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		// Token: 0x060006C4 RID: 1732
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x96A8E0", Offset = "0x968EE0", VA = "0x18096A8E0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_CloseP2PChannelWithUser(IntPtr instancePtr, CSteamID steamIDRemote, int nChannel);

		// Token: 0x060006C5 RID: 1733
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x96A980", Offset = "0x968F80", VA = "0x18096A980")]
		[PreserveSig]
		public static extern bool ISteamNetworking_GetP2PSessionState(IntPtr instancePtr, CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		// Token: 0x060006C6 RID: 1734
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x96AA20", Offset = "0x969020", VA = "0x18096AA20")]
		[PreserveSig]
		public static extern bool ISteamNetworking_AllowP2PPacketRelay(IntPtr instancePtr, bool bAllow);

		// Token: 0x060006C7 RID: 1735
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x96AAB0", Offset = "0x9690B0", VA = "0x18096AAB0")]
		[PreserveSig]
		public static extern uint ISteamNetworking_CreateListenSocket(IntPtr instancePtr, int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay);

		// Token: 0x060006C8 RID: 1736
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x96AB80", Offset = "0x969180", VA = "0x18096AB80")]
		[PreserveSig]
		public static extern uint ISteamNetworking_CreateP2PConnectionSocket(IntPtr instancePtr, CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);

		// Token: 0x060006C9 RID: 1737
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x96AC40", Offset = "0x969240", VA = "0x18096AC40")]
		[PreserveSig]
		public static extern uint ISteamNetworking_CreateConnectionSocket(IntPtr instancePtr, SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec);

		// Token: 0x060006CA RID: 1738
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x96AD00", Offset = "0x969300", VA = "0x18096AD00")]
		[PreserveSig]
		public static extern bool ISteamNetworking_DestroySocket(IntPtr instancePtr, SNetSocket_t hSocket, bool bNotifyRemoteEnd);

		// Token: 0x060006CB RID: 1739
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x96ADA0", Offset = "0x9693A0", VA = "0x18096ADA0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_DestroyListenSocket(IntPtr instancePtr, SNetListenSocket_t hSocket, bool bNotifyRemoteEnd);

		// Token: 0x060006CC RID: 1740
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x96AE40", Offset = "0x969440", VA = "0x18096AE40")]
		[PreserveSig]
		public static extern bool ISteamNetworking_SendDataOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable);

		// Token: 0x060006CD RID: 1741
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x96AF00", Offset = "0x969500", VA = "0x18096AF00")]
		[PreserveSig]
		public static extern bool ISteamNetworking_IsDataAvailableOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, out uint pcubMsgSize);

		// Token: 0x060006CE RID: 1742
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x96AFA0", Offset = "0x9695A0", VA = "0x18096AFA0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_RetrieveDataFromSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize);

		// Token: 0x060006CF RID: 1743
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x96B060", Offset = "0x969660", VA = "0x18096B060")]
		[PreserveSig]
		public static extern bool ISteamNetworking_IsDataAvailable(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		// Token: 0x060006D0 RID: 1744
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x96B110", Offset = "0x969710", VA = "0x18096B110")]
		[PreserveSig]
		public static extern bool ISteamNetworking_RetrieveData(IntPtr instancePtr, SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		// Token: 0x060006D1 RID: 1745
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x96B1E0", Offset = "0x9697E0", VA = "0x18096B1E0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_GetSocketInfo(IntPtr instancePtr, SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote);

		// Token: 0x060006D2 RID: 1746
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x96B2B0", Offset = "0x9698B0", VA = "0x18096B2B0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_GetListenSocketInfo(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort);

		// Token: 0x060006D3 RID: 1747
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x96B360", Offset = "0x969960", VA = "0x18096B360")]
		[PreserveSig]
		public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(IntPtr instancePtr, SNetSocket_t hSocket);

		// Token: 0x060006D4 RID: 1748
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x96B3F0", Offset = "0x9699F0", VA = "0x18096B3F0")]
		[PreserveSig]
		public static extern int ISteamNetworking_GetMaxPacketSize(IntPtr instancePtr, SNetSocket_t hSocket);

		// Token: 0x060006D5 RID: 1749
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x96B480", Offset = "0x969A80", VA = "0x18096B480")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingMessages_SendMessageToUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel);

		// Token: 0x060006D6 RID: 1750
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x96B5F0", Offset = "0x969BF0", VA = "0x18096B5F0")]
		[PreserveSig]
		public static extern int ISteamNetworkingMessages_ReceiveMessagesOnChannel(IntPtr instancePtr, int nLocalChannel, [In] [Out] IntPtr[] ppOutMessages, int nMaxMessages);

		// Token: 0x060006D7 RID: 1751
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x96B6A0", Offset = "0x969CA0", VA = "0x18096B6A0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingMessages_AcceptSessionWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote);

		// Token: 0x060006D8 RID: 1752
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x96B7E0", Offset = "0x969DE0", VA = "0x18096B7E0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingMessages_CloseSessionWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote);

		// Token: 0x060006D9 RID: 1753
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x96B920", Offset = "0x969F20", VA = "0x18096B920")]
		[PreserveSig]
		public static extern bool ISteamNetworkingMessages_CloseChannelWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nLocalChannel);

		// Token: 0x060006DA RID: 1754
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x96BA70", Offset = "0x96A070", VA = "0x18096BA70")]
		[PreserveSig]
		public static extern ESteamNetworkingConnectionState ISteamNetworkingMessages_GetSessionConnectionInfo(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus);

		// Token: 0x060006DB RID: 1755
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x96BD90", Offset = "0x96A390", VA = "0x18096BD90")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreateListenSocketIP(IntPtr instancePtr, ref SteamNetworkingIPAddr localAddress, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x060006DC RID: 1756
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x96BED0", Offset = "0x96A4D0", VA = "0x18096BED0")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_ConnectByIPAddress(IntPtr instancePtr, ref SteamNetworkingIPAddr address, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x060006DD RID: 1757
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x96C010", Offset = "0x96A610", VA = "0x18096C010")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreateListenSocketP2P(IntPtr instancePtr, int nLocalVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x060006DE RID: 1758
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x96C0C0", Offset = "0x96A6C0", VA = "0x18096C0C0")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_ConnectP2P(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x060006DF RID: 1759
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x96C230", Offset = "0x96A830", VA = "0x18096C230")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_AcceptConnection(IntPtr instancePtr, HSteamNetConnection hConn);

		// Token: 0x060006E0 RID: 1760
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x96C2C0", Offset = "0x96A8C0", VA = "0x18096C2C0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_CloseConnection(IntPtr instancePtr, HSteamNetConnection hPeer, int nReason, InteropHelp.UTF8StringHandle pszDebug, bool bEnableLinger);

		// Token: 0x060006E1 RID: 1761
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x96C3D0", Offset = "0x96A9D0", VA = "0x18096C3D0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_CloseListenSocket(IntPtr instancePtr, HSteamListenSocket hSocket);

		// Token: 0x060006E2 RID: 1762
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x96C460", Offset = "0x96AA60", VA = "0x18096C460")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_SetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer, long nUserData);

		// Token: 0x060006E3 RID: 1763
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x96C500", Offset = "0x96AB00", VA = "0x18096C500")]
		[PreserveSig]
		public static extern long ISteamNetworkingSockets_GetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer);

		// Token: 0x060006E4 RID: 1764
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x96C590", Offset = "0x96AB90", VA = "0x18096C590")]
		[PreserveSig]
		public static extern void ISteamNetworkingSockets_SetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, InteropHelp.UTF8StringHandle pszName);

		// Token: 0x060006E5 RID: 1765
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x96C670", Offset = "0x96AC70", VA = "0x18096C670")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, IntPtr pszName, int nMaxLen);

		// Token: 0x060006E6 RID: 1766
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x96C720", Offset = "0x96AD20", VA = "0x18096C720")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_SendMessageToConnection(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber);

		// Token: 0x060006E7 RID: 1767
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x96C7D0", Offset = "0x96ADD0", VA = "0x18096C7D0")]
		[PreserveSig]
		public static extern void ISteamNetworkingSockets_SendMessages(IntPtr instancePtr, int nMessages, [In] [Out] SteamNetworkingMessage_t[] pMessages, [In] [Out] long[] pOutMessageNumberOrResult);

		// Token: 0x060006E8 RID: 1768
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x96CBD0", Offset = "0x96B1D0", VA = "0x18096CBD0")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_FlushMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn);

		// Token: 0x060006E9 RID: 1769
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x96CC60", Offset = "0x96B260", VA = "0x18096CC60")]
		[PreserveSig]
		public static extern int ISteamNetworkingSockets_ReceiveMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn, [In] [Out] IntPtr[] ppOutMessages, int nMaxMessages);

		// Token: 0x060006EA RID: 1770
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x96CD10", Offset = "0x96B310", VA = "0x18096CD10")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetConnectionInfo(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo);

		// Token: 0x060006EB RID: 1771
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x96CEA0", Offset = "0x96B4A0", VA = "0x18096CEA0")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_GetConnectionRealTimeStatus(IntPtr instancePtr, HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes);

		// Token: 0x060006EC RID: 1772
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x96D360", Offset = "0x96B960", VA = "0x18096D360")]
		[PreserveSig]
		public static extern int ISteamNetworkingSockets_GetDetailedConnectionStatus(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pszBuf, int cbBuf);

		// Token: 0x060006ED RID: 1773
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x96D400", Offset = "0x96BA00", VA = "0x18096D400")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetListenSocketAddress(IntPtr instancePtr, HSteamListenSocket hSocket, out SteamNetworkingIPAddr address);

		// Token: 0x060006EE RID: 1774
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x96D510", Offset = "0x96BB10", VA = "0x18096D510")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_CreateSocketPair(IntPtr instancePtr, out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2);

		// Token: 0x060006EF RID: 1775
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x96D760", Offset = "0x96BD60", VA = "0x18096D760")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_ConfigureConnectionLanes(IntPtr instancePtr, HSteamNetConnection hConn, int nNumLanes, out int pLanePriorities, out ushort pLaneWeights);

		// Token: 0x060006F0 RID: 1776
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x96D810", Offset = "0x96BE10", VA = "0x18096D810")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetIdentity(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity);

		// Token: 0x060006F1 RID: 1777
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x96D960", Offset = "0x96BF60", VA = "0x18096D960")]
		[PreserveSig]
		public static extern ESteamNetworkingAvailability ISteamNetworkingSockets_InitAuthentication(IntPtr instancePtr);

		// Token: 0x060006F2 RID: 1778
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x96D9E0", Offset = "0x96BFE0", VA = "0x18096D9E0")]
		[PreserveSig]
		public static extern ESteamNetworkingAvailability ISteamNetworkingSockets_GetAuthenticationStatus(IntPtr instancePtr, out SteamNetAuthenticationStatus_t pDetails);

		// Token: 0x060006F3 RID: 1779
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x96DBC0", Offset = "0x96C1C0", VA = "0x18096DBC0")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreatePollGroup(IntPtr instancePtr);

		// Token: 0x060006F4 RID: 1780
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x96DC40", Offset = "0x96C240", VA = "0x18096DC40")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_DestroyPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup);

		// Token: 0x060006F5 RID: 1781
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x96DCD0", Offset = "0x96C2D0", VA = "0x18096DCD0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_SetConnectionPollGroup(IntPtr instancePtr, HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup);

		// Token: 0x060006F6 RID: 1782
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x96DD70", Offset = "0x96C370", VA = "0x18096DD70")]
		[PreserveSig]
		public static extern int ISteamNetworkingSockets_ReceiveMessagesOnPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup, [In] [Out] IntPtr[] ppOutMessages, int nMaxMessages);

		// Token: 0x060006F7 RID: 1783
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x96DE20", Offset = "0x96C420", VA = "0x18096DE20")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_ReceivedRelayAuthTicket(IntPtr instancePtr, IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket);

		// Token: 0x060006F8 RID: 1784
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x96DFB0", Offset = "0x96C5B0", VA = "0x18096DFB0")]
		[PreserveSig]
		public static extern int ISteamNetworkingSockets_FindRelayAuthTicketForServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket);

		// Token: 0x060006F9 RID: 1785
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x96E1D0", Offset = "0x96C7D0", VA = "0x18096E1D0")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_ConnectToHostedDedicatedServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x060006FA RID: 1786
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x96E340", Offset = "0x96C940", VA = "0x18096E340")]
		[PreserveSig]
		public static extern ushort ISteamNetworkingSockets_GetHostedDedicatedServerPort(IntPtr instancePtr);

		// Token: 0x060006FB RID: 1787
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x96E3C0", Offset = "0x96C9C0", VA = "0x18096E3C0")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_GetHostedDedicatedServerPOPID(IntPtr instancePtr);

		// Token: 0x060006FC RID: 1788
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x96E440", Offset = "0x96CA40", VA = "0x18096E440")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_GetHostedDedicatedServerAddress(IntPtr instancePtr, out SteamDatagramHostedAddress pRouting);

		// Token: 0x060006FD RID: 1789
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x96E590", Offset = "0x96CB90", VA = "0x18096E590")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreateHostedDedicatedServerListenSocket(IntPtr instancePtr, int nLocalVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x060006FE RID: 1790
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x96E640", Offset = "0x96CC40", VA = "0x18096E640")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_GetGameCoordinatorServerLogin(IntPtr instancePtr, IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob);

		// Token: 0x060006FF RID: 1791
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x96E6F0", Offset = "0x96CCF0", VA = "0x18096E6F0")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_ConnectP2PCustomSignaling(IntPtr instancePtr, out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x06000700 RID: 1792
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x96E870", Offset = "0x96CE70", VA = "0x18096E870")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_ReceivedP2PCustomSignal(IntPtr instancePtr, IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext);

		// Token: 0x06000701 RID: 1793
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x96E920", Offset = "0x96CF20", VA = "0x18096E920")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetCertificateRequest(IntPtr instancePtr, out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg);

		// Token: 0x06000702 RID: 1794
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x96EA50", Offset = "0x96D050", VA = "0x18096EA50")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_SetCertificate(IntPtr instancePtr, IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg);

		// Token: 0x06000703 RID: 1795
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x96EB80", Offset = "0x96D180", VA = "0x18096EB80")]
		[PreserveSig]
		public static extern void ISteamNetworkingSockets_ResetIdentity(IntPtr instancePtr, ref SteamNetworkingIdentity pIdentity);

		// Token: 0x06000704 RID: 1796
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x96ECC0", Offset = "0x96D2C0", VA = "0x18096ECC0")]
		[PreserveSig]
		public static extern void ISteamNetworkingSockets_RunCallbacks(IntPtr instancePtr);

		// Token: 0x06000705 RID: 1797
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x96ED40", Offset = "0x96D340", VA = "0x18096ED40")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_BeginAsyncRequestFakeIP(IntPtr instancePtr, int nNumPorts);

		// Token: 0x06000706 RID: 1798
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x96EDD0", Offset = "0x96D3D0", VA = "0x18096EDD0")]
		[PreserveSig]
		public static extern void ISteamNetworkingSockets_GetFakeIP(IntPtr instancePtr, int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo);

		// Token: 0x06000707 RID: 1799
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x96F0A0", Offset = "0x96D6A0", VA = "0x18096F0A0")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreateListenSocketP2PFakeIP(IntPtr instancePtr, int idxFakePort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x06000708 RID: 1800
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x96F150", Offset = "0x96D750", VA = "0x18096F150")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_GetRemoteFakeIPForConnection(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr);

		// Token: 0x06000709 RID: 1801
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x96F260", Offset = "0x96D860", VA = "0x18096F260")]
		[PreserveSig]
		public static extern IntPtr ISteamNetworkingSockets_CreateFakeUDPPort(IntPtr instancePtr, int idxFakeServerPort);

		// Token: 0x0600070A RID: 1802
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x96F2F0", Offset = "0x96D8F0", VA = "0x18096F2F0")]
		[PreserveSig]
		public static extern IntPtr ISteamNetworkingUtils_AllocateMessage(IntPtr instancePtr, int cbAllocateBuffer);

		// Token: 0x0600070B RID: 1803
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x96F380", Offset = "0x96D980", VA = "0x18096F380")]
		[PreserveSig]
		public static extern void ISteamNetworkingUtils_InitRelayNetworkAccess(IntPtr instancePtr);

		// Token: 0x0600070C RID: 1804
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x96F400", Offset = "0x96DA00", VA = "0x18096F400")]
		[PreserveSig]
		public static extern ESteamNetworkingAvailability ISteamNetworkingUtils_GetRelayNetworkStatus(IntPtr instancePtr, out SteamRelayNetworkStatus_t pDetails);

		// Token: 0x0600070D RID: 1805
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x96F620", Offset = "0x96DC20", VA = "0x18096F620")]
		[PreserveSig]
		public static extern float ISteamNetworkingUtils_GetLocalPingLocation(IntPtr instancePtr, out SteamNetworkPingLocation_t result);

		// Token: 0x0600070E RID: 1806
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x96F750", Offset = "0x96DD50", VA = "0x18096F750")]
		[PreserveSig]
		public static extern int ISteamNetworkingUtils_EstimatePingTimeBetweenTwoLocations(IntPtr instancePtr, ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2);

		// Token: 0x0600070F RID: 1807
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x96F9F0", Offset = "0x96DFF0", VA = "0x18096F9F0")]
		[PreserveSig]
		public static extern int ISteamNetworkingUtils_EstimatePingTimeFromLocalHost(IntPtr instancePtr, ref SteamNetworkPingLocation_t remoteLocation);

		// Token: 0x06000710 RID: 1808
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x96FB70", Offset = "0x96E170", VA = "0x18096FB70")]
		[PreserveSig]
		public static extern void ISteamNetworkingUtils_ConvertPingLocationToString(IntPtr instancePtr, ref SteamNetworkPingLocation_t location, IntPtr pszBuf, int cchBufSize);

		// Token: 0x06000711 RID: 1809
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x96FD10", Offset = "0x96E310", VA = "0x18096FD10")]
		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_ParsePingLocationString(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszString, out SteamNetworkPingLocation_t result);

		// Token: 0x06000712 RID: 1810
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x96FE90", Offset = "0x96E490", VA = "0x18096FE90")]
		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_CheckPingDataUpToDate(IntPtr instancePtr, float flMaxAgeSeconds);

		// Token: 0x06000713 RID: 1811
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x96FF20", Offset = "0x96E520", VA = "0x18096FF20")]
		[PreserveSig]
		public static extern int ISteamNetworkingUtils_GetPingToDataCenter(IntPtr instancePtr, SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP);

		// Token: 0x06000714 RID: 1812
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x96FFC0", Offset = "0x96E5C0", VA = "0x18096FFC0")]
		[PreserveSig]
		public static extern int ISteamNetworkingUtils_GetDirectPingToPOP(IntPtr instancePtr, SteamNetworkingPOPID popID);

		// Token: 0x06000715 RID: 1813
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x970050", Offset = "0x96E650", VA = "0x180970050")]
		[PreserveSig]
		public static extern int ISteamNetworkingUtils_GetPOPCount(IntPtr instancePtr);

		// Token: 0x06000716 RID: 1814
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x9700D0", Offset = "0x96E6D0", VA = "0x1809700D0")]
		[PreserveSig]
		public static extern int ISteamNetworkingUtils_GetPOPList(IntPtr instancePtr, out SteamNetworkingPOPID list, int nListSz);

		// Token: 0x06000717 RID: 1815
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x970170", Offset = "0x96E770", VA = "0x180970170")]
		[PreserveSig]
		public static extern long ISteamNetworkingUtils_GetLocalTimestamp(IntPtr instancePtr);

		// Token: 0x06000718 RID: 1816
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x9701F0", Offset = "0x96E7F0", VA = "0x1809701F0")]
		[PreserveSig]
		public static extern void ISteamNetworkingUtils_SetDebugOutputFunction(IntPtr instancePtr, ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc);

		// Token: 0x06000719 RID: 1817
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x970290", Offset = "0x96E890", VA = "0x180970290")]
		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_IsFakeIPv4(IntPtr instancePtr, uint nIPv4);

		// Token: 0x0600071A RID: 1818
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x970320", Offset = "0x96E920", VA = "0x180970320")]
		[PreserveSig]
		public static extern ESteamNetworkingFakeIPType ISteamNetworkingUtils_GetIPv4FakeIPType(IntPtr instancePtr, uint nIPv4);

		// Token: 0x0600071B RID: 1819
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x9703B0", Offset = "0x96E9B0", VA = "0x1809703B0")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingUtils_GetRealIdentityForFakeIP(IntPtr instancePtr, ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity);

		// Token: 0x0600071C RID: 1820
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x970590", Offset = "0x96EB90", VA = "0x180970590")]
		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_SetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg);

		// Token: 0x0600071D RID: 1821
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x970650", Offset = "0x96EC50", VA = "0x180970650")]
		[PreserveSig]
		public static extern ESteamNetworkingGetConfigValueResult ISteamNetworkingUtils_GetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult);

		// Token: 0x0600071E RID: 1822
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x970700", Offset = "0x96ED00", VA = "0x180970700")]
		[PreserveSig]
		public static extern IntPtr ISteamNetworkingUtils_GetConfigValueInfo(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope);

		// Token: 0x0600071F RID: 1823
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x9707A0", Offset = "0x96EDA0", VA = "0x1809707A0")]
		[PreserveSig]
		public static extern ESteamNetworkingConfigValue ISteamNetworkingUtils_IterateGenericEditableConfigValues(IntPtr instancePtr, ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars);

		// Token: 0x06000720 RID: 1824
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x970840", Offset = "0x96EE40", VA = "0x180970840")]
		[PreserveSig]
		public static extern void ISteamNetworkingUtils_SteamNetworkingIPAddr_ToString(IntPtr instancePtr, ref SteamNetworkingIPAddr addr, IntPtr buf, uint cbBuf, bool bWithPort);

		// Token: 0x06000721 RID: 1825
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x970970", Offset = "0x96EF70", VA = "0x180970970")]
		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_SteamNetworkingIPAddr_ParseString(IntPtr instancePtr, out SteamNetworkingIPAddr pAddr, InteropHelp.UTF8StringHandle pszStr);

		// Token: 0x06000722 RID: 1826
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x970AE0", Offset = "0x96F0E0", VA = "0x180970AE0")]
		[PreserveSig]
		public static extern ESteamNetworkingFakeIPType ISteamNetworkingUtils_SteamNetworkingIPAddr_GetFakeIPType(IntPtr instancePtr, ref SteamNetworkingIPAddr addr);

		// Token: 0x06000723 RID: 1827
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x970C00", Offset = "0x96F200", VA = "0x180970C00")]
		[PreserveSig]
		public static extern void ISteamNetworkingUtils_SteamNetworkingIdentity_ToString(IntPtr instancePtr, ref SteamNetworkingIdentity identity, IntPtr buf, uint cbBuf);

		// Token: 0x06000724 RID: 1828
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x970D50", Offset = "0x96F350", VA = "0x180970D50")]
		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_SteamNetworkingIdentity_ParseString(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity, InteropHelp.UTF8StringHandle pszStr);

		// Token: 0x06000725 RID: 1829
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x970EE0", Offset = "0x96F4E0", VA = "0x180970EE0")]
		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsParentalLockEnabled(IntPtr instancePtr);

		// Token: 0x06000726 RID: 1830
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x970F60", Offset = "0x96F560", VA = "0x180970F60")]
		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsParentalLockLocked(IntPtr instancePtr);

		// Token: 0x06000727 RID: 1831
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x970FE0", Offset = "0x96F5E0", VA = "0x180970FE0")]
		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsAppBlocked(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x06000728 RID: 1832
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x971070", Offset = "0x96F670", VA = "0x180971070")]
		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsAppInBlockList(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x06000729 RID: 1833
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x971100", Offset = "0x96F700", VA = "0x180971100")]
		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsFeatureBlocked(IntPtr instancePtr, EParentalFeature eFeature);

		// Token: 0x0600072A RID: 1834
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x971190", Offset = "0x96F790", VA = "0x180971190")]
		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsFeatureInBlockList(IntPtr instancePtr, EParentalFeature eFeature);

		// Token: 0x0600072B RID: 1835
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x971220", Offset = "0x96F820", VA = "0x180971220")]
		[PreserveSig]
		public static extern uint ISteamRemotePlay_GetSessionCount(IntPtr instancePtr);

		// Token: 0x0600072C RID: 1836
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x9712A0", Offset = "0x96F8A0", VA = "0x1809712A0")]
		[PreserveSig]
		public static extern uint ISteamRemotePlay_GetSessionID(IntPtr instancePtr, int iSessionIndex);

		// Token: 0x0600072D RID: 1837
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x971330", Offset = "0x96F930", VA = "0x180971330")]
		[PreserveSig]
		public static extern ulong ISteamRemotePlay_GetSessionSteamID(IntPtr instancePtr, RemotePlaySessionID_t unSessionID);

		// Token: 0x0600072E RID: 1838
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x9713C0", Offset = "0x96F9C0", VA = "0x1809713C0")]
		[PreserveSig]
		public static extern IntPtr ISteamRemotePlay_GetSessionClientName(IntPtr instancePtr, RemotePlaySessionID_t unSessionID);

		// Token: 0x0600072F RID: 1839
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x971450", Offset = "0x96FA50", VA = "0x180971450")]
		[PreserveSig]
		public static extern ESteamDeviceFormFactor ISteamRemotePlay_GetSessionClientFormFactor(IntPtr instancePtr, RemotePlaySessionID_t unSessionID);

		// Token: 0x06000730 RID: 1840
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x9714E0", Offset = "0x96FAE0", VA = "0x1809714E0")]
		[PreserveSig]
		public static extern bool ISteamRemotePlay_BGetSessionClientResolution(IntPtr instancePtr, RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY);

		// Token: 0x06000731 RID: 1841
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x971590", Offset = "0x96FB90", VA = "0x180971590")]
		[PreserveSig]
		public static extern bool ISteamRemotePlay_BSendRemotePlayTogetherInvite(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000732 RID: 1842
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x971620", Offset = "0x96FC20", VA = "0x180971620")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWrite(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubData);

		// Token: 0x06000733 RID: 1843
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x971720", Offset = "0x96FD20", VA = "0x180971720")]
		[PreserveSig]
		public static extern int ISteamRemoteStorage_FileRead(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubDataToRead);

		// Token: 0x06000734 RID: 1844
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x971820", Offset = "0x96FE20", VA = "0x180971820")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_FileWriteAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, uint cubData);

		// Token: 0x06000735 RID: 1845
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x971920", Offset = "0x96FF20", VA = "0x180971920")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_FileReadAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, uint nOffset, uint cubToRead);

		// Token: 0x06000736 RID: 1846
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x971A10", Offset = "0x970010", VA = "0x180971A10")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileReadAsyncComplete(IntPtr instancePtr, SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead);

		// Token: 0x06000737 RID: 1847
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x971AD0", Offset = "0x9700D0", VA = "0x180971AD0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileForget(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000738 RID: 1848
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x971BB0", Offset = "0x9701B0", VA = "0x180971BB0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileDelete(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000739 RID: 1849
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x971C90", Offset = "0x970290", VA = "0x180971C90")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_FileShare(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x0600073A RID: 1850
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x971D70", Offset = "0x970370", VA = "0x180971D70")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_SetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);

		// Token: 0x0600073B RID: 1851
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x971E60", Offset = "0x970460", VA = "0x180971E60")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_FileWriteStreamOpen(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x0600073C RID: 1852
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x971F40", Offset = "0x970540", VA = "0x180971F40")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData);

		// Token: 0x0600073D RID: 1853
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x972000", Offset = "0x970600", VA = "0x180972000")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWriteStreamClose(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle);

		// Token: 0x0600073E RID: 1854
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x972090", Offset = "0x970690", VA = "0x180972090")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle);

		// Token: 0x0600073F RID: 1855
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x972120", Offset = "0x970720", VA = "0x180972120")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileExists(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000740 RID: 1856
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x972200", Offset = "0x970800", VA = "0x180972200")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FilePersisted(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000741 RID: 1857
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x9722E0", Offset = "0x9708E0", VA = "0x1809722E0")]
		[PreserveSig]
		public static extern int ISteamRemoteStorage_GetFileSize(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000742 RID: 1858
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x9723C0", Offset = "0x9709C0", VA = "0x1809723C0")]
		[PreserveSig]
		public static extern long ISteamRemoteStorage_GetFileTimestamp(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000743 RID: 1859
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x9724A0", Offset = "0x970AA0", VA = "0x1809724A0")]
		[PreserveSig]
		public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000744 RID: 1860
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x972580", Offset = "0x970B80", VA = "0x180972580")]
		[PreserveSig]
		public static extern int ISteamRemoteStorage_GetFileCount(IntPtr instancePtr);

		// Token: 0x06000745 RID: 1861
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x972600", Offset = "0x970C00", VA = "0x180972600")]
		[PreserveSig]
		public static extern IntPtr ISteamRemoteStorage_GetFileNameAndSize(IntPtr instancePtr, int iFile, out int pnFileSizeInBytes);

		// Token: 0x06000746 RID: 1862
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x9726A0", Offset = "0x970CA0", VA = "0x1809726A0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_GetQuota(IntPtr instancePtr, out ulong pnTotalBytes, out ulong puAvailableBytes);

		// Token: 0x06000747 RID: 1863
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x972740", Offset = "0x970D40", VA = "0x180972740")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount(IntPtr instancePtr);

		// Token: 0x06000748 RID: 1864
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x9727C0", Offset = "0x970DC0", VA = "0x1809727C0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp(IntPtr instancePtr);

		// Token: 0x06000749 RID: 1865
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x972840", Offset = "0x970E40", VA = "0x180972840")]
		[PreserveSig]
		public static extern void ISteamRemoteStorage_SetCloudEnabledForApp(IntPtr instancePtr, bool bEnabled);

		// Token: 0x0600074A RID: 1866
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x9728D0", Offset = "0x970ED0", VA = "0x1809728D0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_UGCDownload(IntPtr instancePtr, UGCHandle_t hContent, uint unPriority);

		// Token: 0x0600074B RID: 1867
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x972970", Offset = "0x970F70", VA = "0x180972970")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(IntPtr instancePtr, UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected);

		// Token: 0x0600074C RID: 1868
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x972A20", Offset = "0x971020", VA = "0x180972A20")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_GetUGCDetails(IntPtr instancePtr, UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner);

		// Token: 0x0600074D RID: 1869
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x972AF0", Offset = "0x9710F0", VA = "0x180972AF0")]
		[PreserveSig]
		public static extern int ISteamRemoteStorage_UGCRead(IntPtr instancePtr, UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction);

		// Token: 0x0600074E RID: 1870
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x972BA0", Offset = "0x9711A0", VA = "0x180972BA0")]
		[PreserveSig]
		public static extern int ISteamRemoteStorage_GetCachedUGCCount(IntPtr instancePtr);

		// Token: 0x0600074F RID: 1871
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x972C20", Offset = "0x971220", VA = "0x180972C20")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_GetCachedUGCHandle(IntPtr instancePtr, int iCachedContent);

		// Token: 0x06000750 RID: 1872
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x972CB0", Offset = "0x9712B0", VA = "0x180972CB0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_PublishWorkshopFile(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType);

		// Token: 0x06000751 RID: 1873
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x972F20", Offset = "0x971520", VA = "0x180972F20")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x06000752 RID: 1874
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x972FB0", Offset = "0x9715B0", VA = "0x180972FB0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000753 RID: 1875
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x9730A0", Offset = "0x9716A0", VA = "0x1809730A0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchPreviewFile);

		// Token: 0x06000754 RID: 1876
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x973190", Offset = "0x971790", VA = "0x180973190")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchTitle);

		// Token: 0x06000755 RID: 1877
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x973280", Offset = "0x971880", VA = "0x180973280")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchDescription);

		// Token: 0x06000756 RID: 1878
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x973370", Offset = "0x971970", VA = "0x180973370")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility);

		// Token: 0x06000757 RID: 1879
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x973410", Offset = "0x971A10", VA = "0x180973410")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, IntPtr pTags);

		// Token: 0x06000758 RID: 1880
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x9734B0", Offset = "0x971AB0", VA = "0x1809734B0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_CommitPublishedFileUpdate(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle);

		// Token: 0x06000759 RID: 1881
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x973540", Offset = "0x971B40", VA = "0x180973540")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_GetPublishedFileDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld);

		// Token: 0x0600075A RID: 1882
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x9735E0", Offset = "0x971BE0", VA = "0x1809735E0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_DeletePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x0600075B RID: 1883
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x973670", Offset = "0x971C70", VA = "0x180973670")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(IntPtr instancePtr, uint unStartIndex);

		// Token: 0x0600075C RID: 1884
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x973700", Offset = "0x971D00", VA = "0x180973700")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_SubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x0600075D RID: 1885
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x973790", Offset = "0x971D90", VA = "0x180973790")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(IntPtr instancePtr, uint unStartIndex);

		// Token: 0x0600075E RID: 1886
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x973820", Offset = "0x971E20", VA = "0x180973820")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_UnsubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x0600075F RID: 1887
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x9738B0", Offset = "0x971EB0", VA = "0x1809738B0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchChangeDescription);

		// Token: 0x06000760 RID: 1888
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x9739A0", Offset = "0x971FA0", VA = "0x1809739A0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x06000761 RID: 1889
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x973A30", Offset = "0x972030", VA = "0x180973A30")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, bool bVoteUp);

		// Token: 0x06000762 RID: 1890
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x973AD0", Offset = "0x9720D0", VA = "0x180973AD0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x06000763 RID: 1891
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x973B60", Offset = "0x972160", VA = "0x180973B60")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(IntPtr instancePtr, CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags);

		// Token: 0x06000764 RID: 1892
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x973C10", Offset = "0x972210", VA = "0x180973C10")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_PublishVideo(IntPtr instancePtr, EWorkshopVideoProvider eVideoProvider, InteropHelp.UTF8StringHandle pchVideoAccount, InteropHelp.UTF8StringHandle pchVideoIdentifier, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags);

		// Token: 0x06000765 RID: 1893
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x973EB0", Offset = "0x9724B0", VA = "0x180973EB0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_SetUserPublishedFileAction(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction);

		// Token: 0x06000766 RID: 1894
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x973F50", Offset = "0x972550", VA = "0x180973F50")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(IntPtr instancePtr, EWorkshopFileAction eAction, uint unStartIndex);

		// Token: 0x06000767 RID: 1895
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x973FF0", Offset = "0x9725F0", VA = "0x180973FF0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(IntPtr instancePtr, EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags);

		// Token: 0x06000768 RID: 1896
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x9740A0", Offset = "0x9726A0", VA = "0x1809740A0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_UGCDownloadToLocation(IntPtr instancePtr, UGCHandle_t hContent, InteropHelp.UTF8StringHandle pchLocation, uint unPriority);

		// Token: 0x06000769 RID: 1897
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x974190", Offset = "0x972790", VA = "0x180974190")]
		[PreserveSig]
		public static extern int ISteamRemoteStorage_GetLocalFileChangeCount(IntPtr instancePtr);

		// Token: 0x0600076A RID: 1898
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x974210", Offset = "0x972810", VA = "0x180974210")]
		[PreserveSig]
		public static extern IntPtr ISteamRemoteStorage_GetLocalFileChange(IntPtr instancePtr, int iFile, out ERemoteStorageLocalFileChange pEChangeType, out ERemoteStorageFilePathType pEFilePathType);

		// Token: 0x0600076B RID: 1899
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x9742B0", Offset = "0x9728B0", VA = "0x1809742B0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_BeginFileWriteBatch(IntPtr instancePtr);

		// Token: 0x0600076C RID: 1900
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x974330", Offset = "0x972930", VA = "0x180974330")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_EndFileWriteBatch(IntPtr instancePtr);

		// Token: 0x0600076D RID: 1901
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x9743B0", Offset = "0x9729B0", VA = "0x1809743B0")]
		[PreserveSig]
		public static extern uint ISteamScreenshots_WriteScreenshot(IntPtr instancePtr, byte[] pubRGB, uint cubRGB, int nWidth, int nHeight);

		// Token: 0x0600076E RID: 1902
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x974460", Offset = "0x972A60", VA = "0x180974460")]
		[PreserveSig]
		public static extern uint ISteamScreenshots_AddScreenshotToLibrary(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight);

		// Token: 0x0600076F RID: 1903
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x9745C0", Offset = "0x972BC0", VA = "0x1809745C0")]
		[PreserveSig]
		public static extern void ISteamScreenshots_TriggerScreenshot(IntPtr instancePtr);

		// Token: 0x06000770 RID: 1904
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x974640", Offset = "0x972C40", VA = "0x180974640")]
		[PreserveSig]
		public static extern void ISteamScreenshots_HookScreenshots(IntPtr instancePtr, bool bHook);

		// Token: 0x06000771 RID: 1905
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x9746D0", Offset = "0x972CD0", VA = "0x1809746D0")]
		[PreserveSig]
		public static extern bool ISteamScreenshots_SetLocation(IntPtr instancePtr, ScreenshotHandle hScreenshot, InteropHelp.UTF8StringHandle pchLocation);

		// Token: 0x06000772 RID: 1906
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x9747C0", Offset = "0x972DC0", VA = "0x1809747C0")]
		[PreserveSig]
		public static extern bool ISteamScreenshots_TagUser(IntPtr instancePtr, ScreenshotHandle hScreenshot, CSteamID steamID);

		// Token: 0x06000773 RID: 1907
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x974860", Offset = "0x972E60", VA = "0x180974860")]
		[PreserveSig]
		public static extern bool ISteamScreenshots_TagPublishedFile(IntPtr instancePtr, ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID);

		// Token: 0x06000774 RID: 1908
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x974900", Offset = "0x972F00", VA = "0x180974900")]
		[PreserveSig]
		public static extern bool ISteamScreenshots_IsScreenshotsHooked(IntPtr instancePtr);

		// Token: 0x06000775 RID: 1909
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x974980", Offset = "0x972F80", VA = "0x180974980")]
		[PreserveSig]
		public static extern uint ISteamScreenshots_AddVRScreenshotToLibrary(IntPtr instancePtr, EVRScreenshotType eType, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchVRFilename);

		// Token: 0x06000776 RID: 1910
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x974AD0", Offset = "0x9730D0", VA = "0x180974AD0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_CreateQueryUserUGCRequest(IntPtr instancePtr, AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		// Token: 0x06000777 RID: 1911
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x974B80", Offset = "0x973180", VA = "0x180974B80")]
		[PreserveSig]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequestPage(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		// Token: 0x06000778 RID: 1912
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x974C30", Offset = "0x973230", VA = "0x180974C30")]
		[PreserveSig]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequestCursor(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, InteropHelp.UTF8StringHandle pchCursor);

		// Token: 0x06000779 RID: 1913
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x974D50", Offset = "0x973350", VA = "0x180974D50")]
		[PreserveSig]
		public static extern ulong ISteamUGC_CreateQueryUGCDetailsRequest(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		// Token: 0x0600077A RID: 1914
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x974DF0", Offset = "0x9733F0", VA = "0x180974DF0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_SendQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle);

		// Token: 0x0600077B RID: 1915
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x974E80", Offset = "0x973480", VA = "0x180974E80")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCResult(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		// Token: 0x0600077C RID: 1916
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x975040", Offset = "0x973640", VA = "0x180975040")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetQueryUGCNumTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		// Token: 0x0600077D RID: 1917
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x9750E0", Offset = "0x9736E0", VA = "0x1809750E0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize);

		// Token: 0x0600077E RID: 1918
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x9751B0", Offset = "0x9737B0", VA = "0x1809751B0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCTagDisplayName(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize);

		// Token: 0x0600077F RID: 1919
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x975280", Offset = "0x973880", VA = "0x180975280")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCPreviewURL(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		// Token: 0x06000780 RID: 1920
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x975340", Offset = "0x973940", VA = "0x180975340")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		// Token: 0x06000781 RID: 1921
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x975400", Offset = "0x973A00", VA = "0x180975400")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCChildren(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		// Token: 0x06000782 RID: 1922
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x9754C0", Offset = "0x973AC0", VA = "0x1809754C0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCStatistic(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue);

		// Token: 0x06000783 RID: 1923
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x975580", Offset = "0x973B80", VA = "0x180975580")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		// Token: 0x06000784 RID: 1924
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x975620", Offset = "0x973C20", VA = "0x180975620")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCAdditionalPreview(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType);

		// Token: 0x06000785 RID: 1925
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x975710", Offset = "0x973D10", VA = "0x180975710")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetQueryUGCNumKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		// Token: 0x06000786 RID: 1926
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x9757B0", Offset = "0x973DB0", VA = "0x1809757B0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		// Token: 0x06000787 RID: 1927
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x975890", Offset = "0x973E90", VA = "0x180975890")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryFirstUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, InteropHelp.UTF8StringHandle pchKey, IntPtr pchValue, uint cchValueSize);

		// Token: 0x06000788 RID: 1928
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x9759B0", Offset = "0x973FB0", VA = "0x1809759B0")]
		[PreserveSig]
		public static extern bool ISteamUGC_ReleaseQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle);

		// Token: 0x06000789 RID: 1929
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x975A40", Offset = "0x974040", VA = "0x180975A40")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddRequiredTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		// Token: 0x0600078A RID: 1930
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x975B30", Offset = "0x974130", VA = "0x180975B30")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddRequiredTagGroup(IntPtr instancePtr, UGCQueryHandle_t handle, IntPtr pTagGroups);

		// Token: 0x0600078B RID: 1931
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x975BD0", Offset = "0x9741D0", VA = "0x180975BD0")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddExcludedTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		// Token: 0x0600078C RID: 1932
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x975CC0", Offset = "0x9742C0", VA = "0x180975CC0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnOnlyIDs(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnOnlyIDs);

		// Token: 0x0600078D RID: 1933
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x975D60", Offset = "0x974360", VA = "0x180975D60")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnKeyValueTags);

		// Token: 0x0600078E RID: 1934
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x975E00", Offset = "0x974400", VA = "0x180975E00")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnLongDescription(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnLongDescription);

		// Token: 0x0600078F RID: 1935
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x975EA0", Offset = "0x9744A0", VA = "0x180975EA0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnMetadata);

		// Token: 0x06000790 RID: 1936
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x975F40", Offset = "0x974540", VA = "0x180975F40")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnChildren(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnChildren);

		// Token: 0x06000791 RID: 1937
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x975FE0", Offset = "0x9745E0", VA = "0x180975FE0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews);

		// Token: 0x06000792 RID: 1938
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x976080", Offset = "0x974680", VA = "0x180976080")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnTotalOnly(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnTotalOnly);

		// Token: 0x06000793 RID: 1939
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x976120", Offset = "0x974720", VA = "0x180976120")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnPlaytimeStats(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays);

		// Token: 0x06000794 RID: 1940
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x9761C0", Offset = "0x9747C0", VA = "0x1809761C0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetLanguage(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		// Token: 0x06000795 RID: 1941
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x9762B0", Offset = "0x9748B0", VA = "0x1809762B0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetAllowCachedResponse(IntPtr instancePtr, UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		// Token: 0x06000796 RID: 1942
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x976350", Offset = "0x974950", VA = "0x180976350")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetCloudFileNameFilter(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName);

		// Token: 0x06000797 RID: 1943
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x976440", Offset = "0x974A40", VA = "0x180976440")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetMatchAnyTag(IntPtr instancePtr, UGCQueryHandle_t handle, bool bMatchAnyTag);

		// Token: 0x06000798 RID: 1944
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x9764E0", Offset = "0x974AE0", VA = "0x1809764E0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetSearchText(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText);

		// Token: 0x06000799 RID: 1945
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x9765D0", Offset = "0x974BD0", VA = "0x1809765D0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetRankedByTrendDays(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays);

		// Token: 0x0600079A RID: 1946
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x976670", Offset = "0x974C70", VA = "0x180976670")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetTimeCreatedDateRange(IntPtr instancePtr, UGCQueryHandle_t handle, uint rtStart, uint rtEnd);

		// Token: 0x0600079B RID: 1947
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x976720", Offset = "0x974D20", VA = "0x180976720")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetTimeUpdatedDateRange(IntPtr instancePtr, UGCQueryHandle_t handle, uint rtStart, uint rtEnd);

		// Token: 0x0600079C RID: 1948
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x9767D0", Offset = "0x974DD0", VA = "0x1809767D0")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddRequiredKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		// Token: 0x0600079D RID: 1949
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x976930", Offset = "0x974F30", VA = "0x180976930")]
		[PreserveSig]
		public static extern ulong ISteamUGC_RequestUGCDetails(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		// Token: 0x0600079E RID: 1950
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x9769D0", Offset = "0x974FD0", VA = "0x1809769D0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_CreateItem(IntPtr instancePtr, AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		// Token: 0x0600079F RID: 1951
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x976A70", Offset = "0x975070", VA = "0x180976A70")]
		[PreserveSig]
		public static extern ulong ISteamUGC_StartItemUpdate(IntPtr instancePtr, AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007A0 RID: 1952
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x976B10", Offset = "0x975110", VA = "0x180976B10")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemTitle(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle);

		// Token: 0x060007A1 RID: 1953
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x976C00", Offset = "0x975200", VA = "0x180976C00")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemDescription(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription);

		// Token: 0x060007A2 RID: 1954
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x976CF0", Offset = "0x9752F0", VA = "0x180976CF0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemUpdateLanguage(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		// Token: 0x060007A3 RID: 1955
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x976DE0", Offset = "0x9753E0", VA = "0x180976DE0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemMetadata(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData);

		// Token: 0x060007A4 RID: 1956
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x976ED0", Offset = "0x9754D0", VA = "0x180976ED0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemVisibility(IntPtr instancePtr, UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		// Token: 0x060007A5 RID: 1957
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x976F70", Offset = "0x975570", VA = "0x180976F70")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemTags(IntPtr instancePtr, UGCUpdateHandle_t updateHandle, IntPtr pTags);

		// Token: 0x060007A6 RID: 1958
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x977010", Offset = "0x975610", VA = "0x180977010")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemContent(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder);

		// Token: 0x060007A7 RID: 1959
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x977100", Offset = "0x975700", VA = "0x180977100")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile);

		// Token: 0x060007A8 RID: 1960
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x9771F0", Offset = "0x9757F0", VA = "0x1809771F0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetAllowLegacyUpload(IntPtr instancePtr, UGCUpdateHandle_t handle, bool bAllowLegacyUpload);

		// Token: 0x060007A9 RID: 1961
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x977290", Offset = "0x975890", VA = "0x180977290")]
		[PreserveSig]
		public static extern bool ISteamUGC_RemoveAllItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle);

		// Token: 0x060007AA RID: 1962
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x977320", Offset = "0x975920", VA = "0x180977320")]
		[PreserveSig]
		public static extern bool ISteamUGC_RemoveItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x060007AB RID: 1963
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x977410", Offset = "0x975A10", VA = "0x180977410")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddItemKeyValueTag(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x060007AC RID: 1964
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x977570", Offset = "0x975B70", VA = "0x180977570")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile, EItemPreviewType type);

		// Token: 0x060007AD RID: 1965
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x977670", Offset = "0x975C70", VA = "0x180977670")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszVideoID);

		// Token: 0x060007AE RID: 1966
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x977760", Offset = "0x975D60", VA = "0x180977760")]
		[PreserveSig]
		public static extern bool ISteamUGC_UpdateItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszPreviewFile);

		// Token: 0x060007AF RID: 1967
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x977860", Offset = "0x975E60", VA = "0x180977860")]
		[PreserveSig]
		public static extern bool ISteamUGC_UpdateItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszVideoID);

		// Token: 0x060007B0 RID: 1968
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x977960", Offset = "0x975F60", VA = "0x180977960")]
		[PreserveSig]
		public static extern bool ISteamUGC_RemoveItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index);

		// Token: 0x060007B1 RID: 1969
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x977A00", Offset = "0x976000", VA = "0x180977A00")]
		[PreserveSig]
		public static extern ulong ISteamUGC_SubmitItemUpdate(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote);

		// Token: 0x060007B2 RID: 1970
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x977AF0", Offset = "0x9760F0", VA = "0x180977AF0")]
		[PreserveSig]
		public static extern EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(IntPtr instancePtr, UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		// Token: 0x060007B3 RID: 1971
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x977BA0", Offset = "0x9761A0", VA = "0x180977BA0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_SetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bVoteUp);

		// Token: 0x060007B4 RID: 1972
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x977C40", Offset = "0x976240", VA = "0x180977C40")]
		[PreserveSig]
		public static extern ulong ISteamUGC_GetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007B5 RID: 1973
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x977CD0", Offset = "0x9762D0", VA = "0x180977CD0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_AddItemToFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007B6 RID: 1974
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x977D70", Offset = "0x976370", VA = "0x180977D70")]
		[PreserveSig]
		public static extern ulong ISteamUGC_RemoveItemFromFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007B7 RID: 1975
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x977E10", Offset = "0x976410", VA = "0x180977E10")]
		[PreserveSig]
		public static extern ulong ISteamUGC_SubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007B8 RID: 1976
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x977EA0", Offset = "0x9764A0", VA = "0x180977EA0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_UnsubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007B9 RID: 1977
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x977F30", Offset = "0x976530", VA = "0x180977F30")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetNumSubscribedItems(IntPtr instancePtr);

		// Token: 0x060007BA RID: 1978
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x977FB0", Offset = "0x9765B0", VA = "0x180977FB0")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetSubscribedItems(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		// Token: 0x060007BB RID: 1979
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x978050", Offset = "0x976650", VA = "0x180978050")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetItemState(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007BC RID: 1980
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x9780E0", Offset = "0x9766E0", VA = "0x1809780E0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetItemInstallInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp);

		// Token: 0x060007BD RID: 1981
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x9781B0", Offset = "0x9767B0", VA = "0x1809781B0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetItemDownloadInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		// Token: 0x060007BE RID: 1982
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x978260", Offset = "0x976860", VA = "0x180978260")]
		[PreserveSig]
		public static extern bool ISteamUGC_DownloadItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bHighPriority);

		// Token: 0x060007BF RID: 1983
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x978300", Offset = "0x976900", VA = "0x180978300")]
		[PreserveSig]
		public static extern bool ISteamUGC_BInitWorkshopForGameServer(IntPtr instancePtr, DepotId_t unWorkshopDepotID, InteropHelp.UTF8StringHandle pszFolder);

		// Token: 0x060007C0 RID: 1984
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x9783F0", Offset = "0x9769F0", VA = "0x1809783F0")]
		[PreserveSig]
		public static extern void ISteamUGC_SuspendDownloads(IntPtr instancePtr, bool bSuspend);

		// Token: 0x060007C1 RID: 1985
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x978480", Offset = "0x976A80", VA = "0x180978480")]
		[PreserveSig]
		public static extern ulong ISteamUGC_StartPlaytimeTracking(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		// Token: 0x060007C2 RID: 1986
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x978520", Offset = "0x976B20", VA = "0x180978520")]
		[PreserveSig]
		public static extern ulong ISteamUGC_StopPlaytimeTracking(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		// Token: 0x060007C3 RID: 1987
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x9785C0", Offset = "0x976BC0", VA = "0x1809785C0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_StopPlaytimeTrackingForAllItems(IntPtr instancePtr);

		// Token: 0x060007C4 RID: 1988
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x978640", Offset = "0x976C40", VA = "0x180978640")]
		[PreserveSig]
		public static extern ulong ISteamUGC_AddDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

		// Token: 0x060007C5 RID: 1989
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x9786E0", Offset = "0x976CE0", VA = "0x1809786E0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_RemoveDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

		// Token: 0x060007C6 RID: 1990
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x978780", Offset = "0x976D80", VA = "0x180978780")]
		[PreserveSig]
		public static extern ulong ISteamUGC_AddAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

		// Token: 0x060007C7 RID: 1991
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x978820", Offset = "0x976E20", VA = "0x180978820")]
		[PreserveSig]
		public static extern ulong ISteamUGC_RemoveAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

		// Token: 0x060007C8 RID: 1992
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x9788C0", Offset = "0x976EC0", VA = "0x1809788C0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_GetAppDependencies(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007C9 RID: 1993
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x978950", Offset = "0x976F50", VA = "0x180978950")]
		[PreserveSig]
		public static extern ulong ISteamUGC_DeleteItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007CA RID: 1994
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x9789E0", Offset = "0x976FE0", VA = "0x1809789E0")]
		[PreserveSig]
		public static extern bool ISteamUGC_ShowWorkshopEULA(IntPtr instancePtr);

		// Token: 0x060007CB RID: 1995
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x978A60", Offset = "0x977060", VA = "0x180978A60")]
		[PreserveSig]
		public static extern ulong ISteamUGC_GetWorkshopEULAStatus(IntPtr instancePtr);

		// Token: 0x060007CC RID: 1996
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x978AE0", Offset = "0x9770E0", VA = "0x180978AE0")]
		[PreserveSig]
		public static extern int ISteamUser_GetHSteamUser(IntPtr instancePtr);

		// Token: 0x060007CD RID: 1997
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x978B60", Offset = "0x977160", VA = "0x180978B60")]
		[PreserveSig]
		public static extern bool ISteamUser_BLoggedOn(IntPtr instancePtr);

		// Token: 0x060007CE RID: 1998
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x978BE0", Offset = "0x9771E0", VA = "0x180978BE0")]
		[PreserveSig]
		public static extern ulong ISteamUser_GetSteamID(IntPtr instancePtr);

		// Token: 0x060007CF RID: 1999
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x978C60", Offset = "0x977260", VA = "0x180978C60")]
		[PreserveSig]
		public static extern int ISteamUser_InitiateGameConnection_DEPRECATED(IntPtr instancePtr, byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure);

		// Token: 0x060007D0 RID: 2000
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x978D30", Offset = "0x977330", VA = "0x180978D30")]
		[PreserveSig]
		public static extern void ISteamUser_TerminateGameConnection_DEPRECATED(IntPtr instancePtr, uint unIPServer, ushort usPortServer);

		// Token: 0x060007D1 RID: 2001
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x978DD0", Offset = "0x9773D0", VA = "0x180978DD0")]
		[PreserveSig]
		public static extern void ISteamUser_TrackAppUsageEvent(IntPtr instancePtr, CGameID gameID, int eAppUsageEvent, InteropHelp.UTF8StringHandle pchExtraInfo);

		// Token: 0x060007D2 RID: 2002
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x978EC0", Offset = "0x9774C0", VA = "0x180978EC0")]
		[PreserveSig]
		public static extern bool ISteamUser_GetUserDataFolder(IntPtr instancePtr, IntPtr pchBuffer, int cubBuffer);

		// Token: 0x060007D3 RID: 2003
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x978F60", Offset = "0x977560", VA = "0x180978F60")]
		[PreserveSig]
		public static extern void ISteamUser_StartVoiceRecording(IntPtr instancePtr);

		// Token: 0x060007D4 RID: 2004
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x978FE0", Offset = "0x9775E0", VA = "0x180978FE0")]
		[PreserveSig]
		public static extern void ISteamUser_StopVoiceRecording(IntPtr instancePtr);

		// Token: 0x060007D5 RID: 2005
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x979060", Offset = "0x977660", VA = "0x180979060")]
		[PreserveSig]
		public static extern EVoiceResult ISteamUser_GetAvailableVoice(IntPtr instancePtr, out uint pcbCompressed, IntPtr pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		// Token: 0x060007D6 RID: 2006
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x979110", Offset = "0x977710", VA = "0x180979110")]
		[PreserveSig]
		public static extern EVoiceResult ISteamUser_GetVoice(IntPtr instancePtr, bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, IntPtr nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		// Token: 0x060007D7 RID: 2007
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x9791E0", Offset = "0x9777E0", VA = "0x1809791E0")]
		[PreserveSig]
		public static extern EVoiceResult ISteamUser_DecompressVoice(IntPtr instancePtr, byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate);

		// Token: 0x060007D8 RID: 2008
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x9792A0", Offset = "0x9778A0", VA = "0x1809792A0")]
		[PreserveSig]
		public static extern uint ISteamUser_GetVoiceOptimalSampleRate(IntPtr instancePtr);

		// Token: 0x060007D9 RID: 2009
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x979320", Offset = "0x977920", VA = "0x180979320")]
		[PreserveSig]
		public static extern uint ISteamUser_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		// Token: 0x060007DA RID: 2010
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x9793D0", Offset = "0x9779D0", VA = "0x1809793D0")]
		[PreserveSig]
		public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		// Token: 0x060007DB RID: 2011
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x979480", Offset = "0x977A80", VA = "0x180979480")]
		[PreserveSig]
		public static extern void ISteamUser_EndAuthSession(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x060007DC RID: 2012
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x979510", Offset = "0x977B10", VA = "0x180979510")]
		[PreserveSig]
		public static extern void ISteamUser_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket);

		// Token: 0x060007DD RID: 2013
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x9795A0", Offset = "0x977BA0", VA = "0x1809795A0")]
		[PreserveSig]
		public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID);

		// Token: 0x060007DE RID: 2014
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x979640", Offset = "0x977C40", VA = "0x180979640")]
		[PreserveSig]
		public static extern bool ISteamUser_BIsBehindNAT(IntPtr instancePtr);

		// Token: 0x060007DF RID: 2015
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x9796C0", Offset = "0x977CC0", VA = "0x1809796C0")]
		[PreserveSig]
		public static extern void ISteamUser_AdvertiseGame(IntPtr instancePtr, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer);

		// Token: 0x060007E0 RID: 2016
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x979770", Offset = "0x977D70", VA = "0x180979770")]
		[PreserveSig]
		public static extern ulong ISteamUser_RequestEncryptedAppTicket(IntPtr instancePtr, byte[] pDataToInclude, int cbDataToInclude);

		// Token: 0x060007E1 RID: 2017
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x979810", Offset = "0x977E10", VA = "0x180979810")]
		[PreserveSig]
		public static extern bool ISteamUser_GetEncryptedAppTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		// Token: 0x060007E2 RID: 2018
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x9798D0", Offset = "0x977ED0", VA = "0x1809798D0")]
		[PreserveSig]
		public static extern int ISteamUser_GetGameBadgeLevel(IntPtr instancePtr, int nSeries, bool bFoil);

		// Token: 0x060007E3 RID: 2019
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x979970", Offset = "0x977F70", VA = "0x180979970")]
		[PreserveSig]
		public static extern int ISteamUser_GetPlayerSteamLevel(IntPtr instancePtr);

		// Token: 0x060007E4 RID: 2020
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x9799F0", Offset = "0x977FF0", VA = "0x1809799F0")]
		[PreserveSig]
		public static extern ulong ISteamUser_RequestStoreAuthURL(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchRedirectURL);

		// Token: 0x060007E5 RID: 2021
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x979AD0", Offset = "0x9780D0", VA = "0x180979AD0")]
		[PreserveSig]
		public static extern bool ISteamUser_BIsPhoneVerified(IntPtr instancePtr);

		// Token: 0x060007E6 RID: 2022
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x979B50", Offset = "0x978150", VA = "0x180979B50")]
		[PreserveSig]
		public static extern bool ISteamUser_BIsTwoFactorEnabled(IntPtr instancePtr);

		// Token: 0x060007E7 RID: 2023
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x979BD0", Offset = "0x9781D0", VA = "0x180979BD0")]
		[PreserveSig]
		public static extern bool ISteamUser_BIsPhoneIdentifying(IntPtr instancePtr);

		// Token: 0x060007E8 RID: 2024
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x979C50", Offset = "0x978250", VA = "0x180979C50")]
		[PreserveSig]
		public static extern bool ISteamUser_BIsPhoneRequiringVerification(IntPtr instancePtr);

		// Token: 0x060007E9 RID: 2025
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x979CD0", Offset = "0x9782D0", VA = "0x180979CD0")]
		[PreserveSig]
		public static extern ulong ISteamUser_GetMarketEligibility(IntPtr instancePtr);

		// Token: 0x060007EA RID: 2026
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x979D50", Offset = "0x978350", VA = "0x180979D50")]
		[PreserveSig]
		public static extern ulong ISteamUser_GetDurationControl(IntPtr instancePtr);

		// Token: 0x060007EB RID: 2027
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x979DD0", Offset = "0x9783D0", VA = "0x180979DD0")]
		[PreserveSig]
		public static extern bool ISteamUser_BSetDurationControlOnlineState(IntPtr instancePtr, EDurationControlOnlineState eNewState);

		// Token: 0x060007EC RID: 2028
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x979E60", Offset = "0x978460", VA = "0x180979E60")]
		[PreserveSig]
		public static extern bool ISteamUserStats_RequestCurrentStats(IntPtr instancePtr);

		// Token: 0x060007ED RID: 2029
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x979EE0", Offset = "0x9784E0", VA = "0x180979EE0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pData);

		// Token: 0x060007EE RID: 2030
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x979FD0", Offset = "0x9785D0", VA = "0x180979FD0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pData);

		// Token: 0x060007EF RID: 2031
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x97A0C0", Offset = "0x9786C0", VA = "0x18097A0C0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_SetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, int nData);

		// Token: 0x060007F0 RID: 2032
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x97A1B0", Offset = "0x9787B0", VA = "0x18097A1B0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_SetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float fData);

		// Token: 0x060007F1 RID: 2033
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x97A2A0", Offset = "0x9788A0", VA = "0x18097A2A0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_UpdateAvgRateStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		// Token: 0x060007F2 RID: 2034
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x97A3B0", Offset = "0x9789B0", VA = "0x18097A3B0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		// Token: 0x060007F3 RID: 2035
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x97A4B0", Offset = "0x978AB0", VA = "0x18097A4B0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_SetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x060007F4 RID: 2036
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x97A590", Offset = "0x978B90", VA = "0x18097A590")]
		[PreserveSig]
		public static extern bool ISteamUserStats_ClearAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x060007F5 RID: 2037
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x97A670", Offset = "0x978C70", VA = "0x18097A670")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		// Token: 0x060007F6 RID: 2038
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x97A780", Offset = "0x978D80", VA = "0x18097A780")]
		[PreserveSig]
		public static extern bool ISteamUserStats_StoreStats(IntPtr instancePtr);

		// Token: 0x060007F7 RID: 2039
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x97A800", Offset = "0x978E00", VA = "0x18097A800")]
		[PreserveSig]
		public static extern int ISteamUserStats_GetAchievementIcon(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x060007F8 RID: 2040
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x97A8E0", Offset = "0x978EE0", VA = "0x18097A8E0")]
		[PreserveSig]
		public static extern IntPtr ISteamUserStats_GetAchievementDisplayAttribute(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x060007F9 RID: 2041
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x97AA20", Offset = "0x979020", VA = "0x18097AA20")]
		[PreserveSig]
		public static extern bool ISteamUserStats_IndicateAchievementProgress(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress);

		// Token: 0x060007FA RID: 2042
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x97AB20", Offset = "0x979120", VA = "0x18097AB20")]
		[PreserveSig]
		public static extern uint ISteamUserStats_GetNumAchievements(IntPtr instancePtr);

		// Token: 0x060007FB RID: 2043
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x97ABA0", Offset = "0x9791A0", VA = "0x18097ABA0")]
		[PreserveSig]
		public static extern IntPtr ISteamUserStats_GetAchievementName(IntPtr instancePtr, uint iAchievement);

		// Token: 0x060007FC RID: 2044
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x97AC30", Offset = "0x979230", VA = "0x18097AC30")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		// Token: 0x060007FD RID: 2045
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x97ACC0", Offset = "0x9792C0", VA = "0x18097ACC0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		// Token: 0x060007FE RID: 2046
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x97ADC0", Offset = "0x9793C0", VA = "0x18097ADC0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		// Token: 0x060007FF RID: 2047
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x97AEC0", Offset = "0x9794C0", VA = "0x18097AEC0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		// Token: 0x06000800 RID: 2048
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x97AFE0", Offset = "0x9795E0", VA = "0x18097AFE0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		// Token: 0x06000801 RID: 2049
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x97B110", Offset = "0x979710", VA = "0x18097B110")]
		[PreserveSig]
		public static extern bool ISteamUserStats_ResetAllStats(IntPtr instancePtr, bool bAchievementsToo);

		// Token: 0x06000802 RID: 2050
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x97B1A0", Offset = "0x9797A0", VA = "0x18097B1A0")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_FindOrCreateLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType);

		// Token: 0x06000803 RID: 2051
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x97B290", Offset = "0x979890", VA = "0x18097B290")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_FindLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName);

		// Token: 0x06000804 RID: 2052
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x97B370", Offset = "0x979970", VA = "0x18097B370")]
		[PreserveSig]
		public static extern IntPtr ISteamUserStats_GetLeaderboardName(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		// Token: 0x06000805 RID: 2053
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x97B400", Offset = "0x979A00", VA = "0x18097B400")]
		[PreserveSig]
		public static extern int ISteamUserStats_GetLeaderboardEntryCount(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		// Token: 0x06000806 RID: 2054
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x97B490", Offset = "0x979A90", VA = "0x18097B490")]
		[PreserveSig]
		public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		// Token: 0x06000807 RID: 2055
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x97B520", Offset = "0x979B20", VA = "0x18097B520")]
		[PreserveSig]
		public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		// Token: 0x06000808 RID: 2056
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x97B5B0", Offset = "0x979BB0", VA = "0x18097B5B0")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntries(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

		// Token: 0x06000809 RID: 2057
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x97B660", Offset = "0x979C60", VA = "0x18097B660")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, [In] [Out] CSteamID[] prgUsers, int cUsers);

		// Token: 0x0600080A RID: 2058
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x97B710", Offset = "0x979D10", VA = "0x18097B710")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(IntPtr instancePtr, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, [In] [Out] int[] pDetails, int cDetailsMax);

		// Token: 0x0600080B RID: 2059
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x97B7E0", Offset = "0x979DE0", VA = "0x18097B7E0")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_UploadLeaderboardScore(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In] [Out] int[] pScoreDetails, int cScoreDetailsCount);

		// Token: 0x0600080C RID: 2060
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x97B8B0", Offset = "0x979EB0", VA = "0x18097B8B0")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_AttachLeaderboardUGC(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

		// Token: 0x0600080D RID: 2061
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x97B950", Offset = "0x979F50", VA = "0x18097B950")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_GetNumberOfCurrentPlayers(IntPtr instancePtr);

		// Token: 0x0600080E RID: 2062
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x97B9D0", Offset = "0x979FD0", VA = "0x18097B9D0")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_RequestGlobalAchievementPercentages(IntPtr instancePtr);

		// Token: 0x0600080F RID: 2063
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x97BA50", Offset = "0x97A050", VA = "0x18097BA50")]
		[PreserveSig]
		public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr instancePtr, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		// Token: 0x06000810 RID: 2064
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x97BB20", Offset = "0x97A120", VA = "0x18097BB20")]
		[PreserveSig]
		public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(IntPtr instancePtr, int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		// Token: 0x06000811 RID: 2065
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x97BC00", Offset = "0x97A200", VA = "0x18097BC00")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievementAchievedPercent(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pflPercent);

		// Token: 0x06000812 RID: 2066
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x97BCF0", Offset = "0x97A2F0", VA = "0x18097BCF0")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_RequestGlobalStats(IntPtr instancePtr, int nHistoryDays);

		// Token: 0x06000813 RID: 2067
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x97BD80", Offset = "0x97A380", VA = "0x18097BD80")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetGlobalStatInt64(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out long pData);

		// Token: 0x06000814 RID: 2068
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x97BE70", Offset = "0x97A470", VA = "0x18097BE70")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetGlobalStatDouble(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out double pData);

		// Token: 0x06000815 RID: 2069
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x97BF60", Offset = "0x97A560", VA = "0x18097BF60")]
		[PreserveSig]
		public static extern int ISteamUserStats_GetGlobalStatHistoryInt64(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In] [Out] long[] pData, uint cubData);

		// Token: 0x06000816 RID: 2070
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x97C060", Offset = "0x97A660", VA = "0x18097C060")]
		[PreserveSig]
		public static extern int ISteamUserStats_GetGlobalStatHistoryDouble(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In] [Out] double[] pData, uint cubData);

		// Token: 0x06000817 RID: 2071
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x97C160", Offset = "0x97A760", VA = "0x18097C160")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievementProgressLimitsInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pnMinProgress, out int pnMaxProgress);

		// Token: 0x06000818 RID: 2072
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x97C260", Offset = "0x97A860", VA = "0x18097C260")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievementProgressLimitsFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pfMinProgress, out float pfMaxProgress);

		// Token: 0x06000819 RID: 2073
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x97C360", Offset = "0x97A960", VA = "0x18097C360")]
		[PreserveSig]
		public static extern uint ISteamUtils_GetSecondsSinceAppActive(IntPtr instancePtr);

		// Token: 0x0600081A RID: 2074
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x97C3E0", Offset = "0x97A9E0", VA = "0x18097C3E0")]
		[PreserveSig]
		public static extern uint ISteamUtils_GetSecondsSinceComputerActive(IntPtr instancePtr);

		// Token: 0x0600081B RID: 2075
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x97C460", Offset = "0x97AA60", VA = "0x18097C460")]
		[PreserveSig]
		public static extern EUniverse ISteamUtils_GetConnectedUniverse(IntPtr instancePtr);

		// Token: 0x0600081C RID: 2076
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x97C4E0", Offset = "0x97AAE0", VA = "0x18097C4E0")]
		[PreserveSig]
		public static extern uint ISteamUtils_GetServerRealTime(IntPtr instancePtr);

		// Token: 0x0600081D RID: 2077
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x97C560", Offset = "0x97AB60", VA = "0x18097C560")]
		[PreserveSig]
		public static extern IntPtr ISteamUtils_GetIPCountry(IntPtr instancePtr);

		// Token: 0x0600081E RID: 2078
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x97C5E0", Offset = "0x97ABE0", VA = "0x18097C5E0")]
		[PreserveSig]
		public static extern bool ISteamUtils_GetImageSize(IntPtr instancePtr, int iImage, out uint pnWidth, out uint pnHeight);

		// Token: 0x0600081F RID: 2079
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x97C690", Offset = "0x97AC90", VA = "0x18097C690")]
		[PreserveSig]
		public static extern bool ISteamUtils_GetImageRGBA(IntPtr instancePtr, int iImage, byte[] pubDest, int nDestBufferSize);

		// Token: 0x06000820 RID: 2080
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x97C740", Offset = "0x97AD40", VA = "0x18097C740")]
		[PreserveSig]
		public static extern byte ISteamUtils_GetCurrentBatteryPower(IntPtr instancePtr);

		// Token: 0x06000821 RID: 2081
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x97C7C0", Offset = "0x97ADC0", VA = "0x18097C7C0")]
		[PreserveSig]
		public static extern uint ISteamUtils_GetAppID(IntPtr instancePtr);

		// Token: 0x06000822 RID: 2082
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x97C840", Offset = "0x97AE40", VA = "0x18097C840")]
		[PreserveSig]
		public static extern void ISteamUtils_SetOverlayNotificationPosition(IntPtr instancePtr, ENotificationPosition eNotificationPosition);

		// Token: 0x06000823 RID: 2083
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x97C8D0", Offset = "0x97AED0", VA = "0x18097C8D0")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsAPICallCompleted(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, out bool pbFailed);

		// Token: 0x06000824 RID: 2084
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x97C980", Offset = "0x97AF80", VA = "0x18097C980")]
		[PreserveSig]
		public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(IntPtr instancePtr, SteamAPICall_t hSteamAPICall);

		// Token: 0x06000825 RID: 2085
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x97CA10", Offset = "0x97B010", VA = "0x18097CA10")]
		[PreserveSig]
		public static extern bool ISteamUtils_GetAPICallResult(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		// Token: 0x06000826 RID: 2086
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x97CAF0", Offset = "0x97B0F0", VA = "0x18097CAF0")]
		[PreserveSig]
		public static extern uint ISteamUtils_GetIPCCallCount(IntPtr instancePtr);

		// Token: 0x06000827 RID: 2087
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x97CB70", Offset = "0x97B170", VA = "0x18097CB70")]
		[PreserveSig]
		public static extern void ISteamUtils_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		// Token: 0x06000828 RID: 2088
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x97CC10", Offset = "0x97B210", VA = "0x18097CC10")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsOverlayEnabled(IntPtr instancePtr);

		// Token: 0x06000829 RID: 2089
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x97CC90", Offset = "0x97B290", VA = "0x18097CC90")]
		[PreserveSig]
		public static extern bool ISteamUtils_BOverlayNeedsPresent(IntPtr instancePtr);

		// Token: 0x0600082A RID: 2090
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x97CD10", Offset = "0x97B310", VA = "0x18097CD10")]
		[PreserveSig]
		public static extern ulong ISteamUtils_CheckFileSignature(IntPtr instancePtr, InteropHelp.UTF8StringHandle szFileName);

		// Token: 0x0600082B RID: 2091
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x97CDF0", Offset = "0x97B3F0", VA = "0x18097CDF0")]
		[PreserveSig]
		public static extern bool ISteamUtils_ShowGamepadTextInput(IntPtr instancePtr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText);

		// Token: 0x0600082C RID: 2092
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x97CF80", Offset = "0x97B580", VA = "0x18097CF80")]
		[PreserveSig]
		public static extern uint ISteamUtils_GetEnteredGamepadTextLength(IntPtr instancePtr);

		// Token: 0x0600082D RID: 2093
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x97D000", Offset = "0x97B600", VA = "0x18097D000")]
		[PreserveSig]
		public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr instancePtr, IntPtr pchText, uint cchText);

		// Token: 0x0600082E RID: 2094
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x97D0A0", Offset = "0x97B6A0", VA = "0x18097D0A0")]
		[PreserveSig]
		public static extern IntPtr ISteamUtils_GetSteamUILanguage(IntPtr instancePtr);

		// Token: 0x0600082F RID: 2095
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x97D120", Offset = "0x97B720", VA = "0x18097D120")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsSteamRunningInVR(IntPtr instancePtr);

		// Token: 0x06000830 RID: 2096
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x97D1A0", Offset = "0x97B7A0", VA = "0x18097D1A0")]
		[PreserveSig]
		public static extern void ISteamUtils_SetOverlayNotificationInset(IntPtr instancePtr, int nHorizontalInset, int nVerticalInset);

		// Token: 0x06000831 RID: 2097
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x97D240", Offset = "0x97B840", VA = "0x18097D240")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsSteamInBigPictureMode(IntPtr instancePtr);

		// Token: 0x06000832 RID: 2098
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x97D2C0", Offset = "0x97B8C0", VA = "0x18097D2C0")]
		[PreserveSig]
		public static extern void ISteamUtils_StartVRDashboard(IntPtr instancePtr);

		// Token: 0x06000833 RID: 2099
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x97D340", Offset = "0x97B940", VA = "0x18097D340")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsVRHeadsetStreamingEnabled(IntPtr instancePtr);

		// Token: 0x06000834 RID: 2100
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x97D3C0", Offset = "0x97B9C0", VA = "0x18097D3C0")]
		[PreserveSig]
		public static extern void ISteamUtils_SetVRHeadsetStreamingEnabled(IntPtr instancePtr, bool bEnabled);

		// Token: 0x06000835 RID: 2101
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x97D450", Offset = "0x97BA50", VA = "0x18097D450")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsSteamChinaLauncher(IntPtr instancePtr);

		// Token: 0x06000836 RID: 2102
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x97D4D0", Offset = "0x97BAD0", VA = "0x18097D4D0")]
		[PreserveSig]
		public static extern bool ISteamUtils_InitFilterText(IntPtr instancePtr, uint unFilterOptions);

		// Token: 0x06000837 RID: 2103
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x97D560", Offset = "0x97BB60", VA = "0x18097D560")]
		[PreserveSig]
		public static extern int ISteamUtils_FilterText(IntPtr instancePtr, ETextFilteringContext eContext, CSteamID sourceSteamID, InteropHelp.UTF8StringHandle pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText);

		// Token: 0x06000838 RID: 2104
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x97D670", Offset = "0x97BC70", VA = "0x18097D670")]
		[PreserveSig]
		public static extern ESteamIPv6ConnectivityState ISteamUtils_GetIPv6ConnectivityState(IntPtr instancePtr, ESteamIPv6ConnectivityProtocol eProtocol);

		// Token: 0x06000839 RID: 2105
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x97D700", Offset = "0x97BD00", VA = "0x18097D700")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsSteamRunningOnSteamDeck(IntPtr instancePtr);

		// Token: 0x0600083A RID: 2106
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x97D780", Offset = "0x97BD80", VA = "0x18097D780")]
		[PreserveSig]
		public static extern bool ISteamUtils_ShowFloatingGamepadTextInput(IntPtr instancePtr, EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight);

		// Token: 0x0600083B RID: 2107
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x97D840", Offset = "0x97BE40", VA = "0x18097D840")]
		[PreserveSig]
		public static extern void ISteamUtils_SetGameLauncherMode(IntPtr instancePtr, bool bLauncherMode);

		// Token: 0x0600083C RID: 2108
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x97D8D0", Offset = "0x97BED0", VA = "0x18097D8D0")]
		[PreserveSig]
		public static extern bool ISteamUtils_DismissFloatingGamepadTextInput(IntPtr instancePtr);

		// Token: 0x0600083D RID: 2109
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x97D950", Offset = "0x97BF50", VA = "0x18097D950")]
		[PreserveSig]
		public static extern void ISteamVideo_GetVideoURL(IntPtr instancePtr, AppId_t unVideoAppID);

		// Token: 0x0600083E RID: 2110
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x97D9E0", Offset = "0x97BFE0", VA = "0x18097D9E0")]
		[PreserveSig]
		public static extern bool ISteamVideo_IsBroadcasting(IntPtr instancePtr, out int pnNumViewers);

		// Token: 0x0600083F RID: 2111
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x97DA70", Offset = "0x97C070", VA = "0x18097DA70")]
		[PreserveSig]
		public static extern void ISteamVideo_GetOPFSettings(IntPtr instancePtr, AppId_t unVideoAppID);

		// Token: 0x06000840 RID: 2112
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x97DB00", Offset = "0x97C100", VA = "0x18097DB00")]
		[PreserveSig]
		public static extern bool ISteamVideo_GetOPFStringForApp(IntPtr instancePtr, AppId_t unVideoAppID, IntPtr pchBuffer, ref int pnBufferSize);

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		internal const string NativeLibraryName = "steam_api64";

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		internal const string NativeLibrary_SDKEncryptedAppTicket = "sdkencryptedappticket64";
	}
}
