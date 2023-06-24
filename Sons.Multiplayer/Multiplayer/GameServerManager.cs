using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Steamworks;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public static class GameServerManager
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x1700002C")]
		public static bool HasAutoJoinGameServer
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x30E4270", Offset = "0x30E2870", VA = "0x1830E4270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002D")]
		public static gameserveritem_t AutoJoinGameServer
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x30E4330", Offset = "0x30E2930", VA = "0x1830E4330")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x1700002E")]
		public static bool HasServerInstance
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x30E4380", Offset = "0x30E2980", VA = "0x1830E4380")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x1700002F")]
		public static bool IsDedicated
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x30E43E0", Offset = "0x30E29E0", VA = "0x1830E43E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x17000030")]
		public static bool IsDedicatedServer
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x30E4490", Offset = "0x30E2A90", VA = "0x1830E4490")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x17000031")]
		public static bool IsDedicatedClient
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x30E4510", Offset = "0x30E2B10", VA = "0x1830E4510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x17000032")]
		public static bool IsPasswordProtected
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x30E4590", Offset = "0x30E2B90", VA = "0x1830E4590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x30E4600", Offset = "0x30E2C00", VA = "0x1830E4600")]
		public static uint ComputeWeakPasswordHash(string password)
		{
			return 0U;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x17000033")]
		public static bool HasDedicatedState
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x30E4650", Offset = "0x30E2C50", VA = "0x1830E4650")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x30E46A0", Offset = "0x30E2CA0", VA = "0x1830E46A0")]
		public static void SetDedicatedState(bool isDedicated, bool isServer)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x30E4730", Offset = "0x30E2D30", VA = "0x1830E4730")]
		public static void ClearDedicatedState()
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x30E47B0", Offset = "0x30E2DB0", VA = "0x1830E47B0")]
		public static void RegisterClient(BoltConnection connection, CSteamID steamId, string name)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x30E4990", Offset = "0x30E2F90", VA = "0x1830E4990")]
		public static bool UnregisterClient(BoltConnection connection, out CSteamID steamId)
		{
			return default(bool);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x30E4B20", Offset = "0x30E3120", VA = "0x1830E4B20")]
		public static bool GetRegisteredClient(BoltConnection connection, out CSteamID steamId)
		{
			return default(bool);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x30E4C70", Offset = "0x30E3270", VA = "0x1830E4C70")]
		public static bool GetRegisteredClientBoltConnectionId(CSteamID steamId, out BoltConnection connection)
		{
			return default(bool);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x30E4F00", Offset = "0x30E3500", VA = "0x1830E4F00")]
		public static bool GetRegisteredClientName(CSteamID steamId, out string name)
		{
			return default(bool);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x30E5180", Offset = "0x30E3780", VA = "0x1830E5180")]
		public static UdpEndPoint GetEndpoint()
		{
			return default(UdpEndPoint);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x17000034")]
		public static bool DedicatedHost_DEPRECATED
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void SetDedicatedHost_DEPRECATED(bool value)
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00002898 File Offset: 0x00000A98
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public static bool Dedicated_DEPRECATED
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x30E52F0", Offset = "0x30E38F0", VA = "0x1830E52F0")]
		public static void SetServer(IGameServer server)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x30E5490", Offset = "0x30E3A90", VA = "0x1830E5490")]
		public static void Shutdown()
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x30E5790", Offset = "0x30E3D90", VA = "0x1830E5790")]
		public static void Update()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x30E5810", Offset = "0x30E3E10", VA = "0x1830E5810")]
		public static bool Start(Action connected, Action<string> failed)
		{
			return default(bool);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void SetAdmin_DEPRECATED(bool value)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x30E5920", Offset = "0x30E3F20", VA = "0x1830E5920")]
		public static void SetAutoJoin(gameserveritem_t gameServer)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x30E59D0", Offset = "0x30E3FD0", VA = "0x1830E59D0")]
		public static void ResetAutoJoin()
		{
		}

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x0")]
		private static IGameServer _serverInstance;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x8")]
		private static bool _isDedicated;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x9")]
		private static bool _isServer;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x10")]
		[TupleElementNames(new string[]
		{
			"name",
			"steamId"
		})]
		private static Dictionary<BoltConnection, ValueTuple<string, CSteamID>> _clientConnectionInfo;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x18")]
		private static bool _initialized;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x19")]
		private static bool _dedicatedStatusIsSetup;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x20")]
		private static gameserveritem_t _autoJoinGameServer;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x28")]
		public static bool IsVersionFilteringDisabled;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x30")]
		public static string IpAddress;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x38")]
		public static ushort GamePort;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x3A")]
		public static ushort QueryPort;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x3C")]
		public static CSteamID ServerId;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x44")]
		public static HAuthTicket SteamClientAuthTicket;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x48")]
		public static string Password;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x50")]
		public static int MaxPlayers;
	}
}
