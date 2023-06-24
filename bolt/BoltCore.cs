using System;
using System.Collections.Generic;
using System.Diagnostics;
using Bolt;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

// Token: 0x0200002A RID: 42
[Token(Token = "0x200002A")]
internal static class BoltCore
{
	// Token: 0x17000043 RID: 67
	// (get) Token: 0x0600013A RID: 314 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000043")]
	internal static IEnumerable<Entity> _entities
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x788C60", Offset = "0x787260", VA = "0x180788C60")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x0600013B RID: 315 RVA: 0x000025E0 File Offset: 0x000007E0
	[Token(Token = "0x17000044")]
	public static bool isDebugMode
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x0600013C RID: 316 RVA: 0x000025F8 File Offset: 0x000007F8
	[Token(Token = "0x17000045")]
	public static int loadedScene
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x788CB0", Offset = "0x7872B0", VA = "0x180788CB0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x0600013D RID: 317 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000046")]
	public static string loadedSceneName
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x788D00", Offset = "0x787300", VA = "0x180788D00")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x0600013E RID: 318 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000047")]
	public static GameObject globalObject
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x788D90", Offset = "0x787390", VA = "0x180788D90")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x0600013F RID: 319 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000048")]
	public static IEnumerable<BoltEntity> entities
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x788DF0", Offset = "0x7873F0", VA = "0x180788DF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000140 RID: 320 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000049")]
	public static IEnumerable<BoltConnection> connections
	{
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x788FA0", Offset = "0x7875A0", VA = "0x180788FA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000141 RID: 321 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700004A")]
	public static IEnumerable<BoltConnection> clients
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x788FF0", Offset = "0x7875F0", VA = "0x180788FF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000142 RID: 322 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700004B")]
	public static BoltConnection server
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x7891A0", Offset = "0x7877A0", VA = "0x1807891A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06000143 RID: 323 RVA: 0x00002610 File Offset: 0x00000810
	[Token(Token = "0x1700004C")]
	public static int frame
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x789350", Offset = "0x787950", VA = "0x180789350")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06000144 RID: 324 RVA: 0x00002628 File Offset: 0x00000828
	[Token(Token = "0x1700004D")]
	public static int framesPerSecond
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x7893A0", Offset = "0x7879A0", VA = "0x1807893A0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000145 RID: 325 RVA: 0x00002640 File Offset: 0x00000840
	[Token(Token = "0x1700004E")]
	public static int serverFrame
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x789400", Offset = "0x787A00", VA = "0x180789400")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000146 RID: 326 RVA: 0x00002658 File Offset: 0x00000858
	[Token(Token = "0x1700004F")]
	public static float serverTime
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x7894D0", Offset = "0x787AD0", VA = "0x1807894D0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000147 RID: 327 RVA: 0x00002670 File Offset: 0x00000870
	[Token(Token = "0x17000050")]
	public static float time
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x789580", Offset = "0x787B80", VA = "0x180789580")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000148 RID: 328 RVA: 0x00002688 File Offset: 0x00000888
	[Token(Token = "0x17000051")]
	public static float frameBeginTime
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x7895D0", Offset = "0x787BD0", VA = "0x1807895D0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000149 RID: 329 RVA: 0x000026A0 File Offset: 0x000008A0
	[Token(Token = "0x17000052")]
	public static float frameDeltaTime
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x789620", Offset = "0x787C20", VA = "0x180789620")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x0600014A RID: 330 RVA: 0x000026B8 File Offset: 0x000008B8
	[Token(Token = "0x17000053")]
	public static float frameAlpha
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x789670", Offset = "0x787C70", VA = "0x180789670")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600014B RID: 331 RVA: 0x000026D0 File Offset: 0x000008D0
	[Token(Token = "0x17000054")]
	public static bool isClient
	{
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x789790", Offset = "0x787D90", VA = "0x180789790")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600014C RID: 332 RVA: 0x000026E8 File Offset: 0x000008E8
	[Token(Token = "0x17000055")]
	public static bool isServer
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x789840", Offset = "0x787E40", VA = "0x180789840")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600014D RID: 333 RVA: 0x00002700 File Offset: 0x00000900
	[Token(Token = "0x17000056")]
	internal static int localSendRate
	{
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x7898F0", Offset = "0x787EF0", VA = "0x1807898F0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600014E RID: 334 RVA: 0x00002718 File Offset: 0x00000918
	[Token(Token = "0x17000057")]
	internal static int remoteSendRate
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x7899B0", Offset = "0x787FB0", VA = "0x1807899B0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x0600014F RID: 335 RVA: 0x00002730 File Offset: 0x00000930
	[Token(Token = "0x17000058")]
	internal static int localInterpolationDelay
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x789A70", Offset = "0x788070", VA = "0x180789A70")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000150 RID: 336 RVA: 0x00002748 File Offset: 0x00000948
	[Token(Token = "0x17000059")]
	internal static int localInterpolationDelayMin
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x789B30", Offset = "0x788130", VA = "0x180789B30")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000151 RID: 337 RVA: 0x00002760 File Offset: 0x00000960
	[Token(Token = "0x1700005A")]
	internal static int localInterpolationDelayMax
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x789BF0", Offset = "0x7881F0", VA = "0x180789BF0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000152 RID: 338 RVA: 0x00002778 File Offset: 0x00000978
	[Token(Token = "0x1700005B")]
	internal static bool hasSocket
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x789CB0", Offset = "0x7882B0", VA = "0x180789CB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x789D10", Offset = "0x788310", VA = "0x180789D10")]
	public static void Destroy(BoltEntity entity, IProtocolToken detachToken)
	{
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x789E00", Offset = "0x788400", VA = "0x180789E00")]
	internal static void DestroyForce(Entity entity)
	{
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x789EF0", Offset = "0x7884F0", VA = "0x180789EF0")]
	internal static BoltEntity Instantiate(PrefabId prefabId, TypeId serializerId, Vector3 position, Quaternion rotation, InstantiateFlags instanceFlags, BoltConnection controller, IProtocolToken attachToken)
	{
		return null;
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000156")]
	[Address(RVA = "0x78A140", Offset = "0x788740", VA = "0x18078A140")]
	internal static GameObject Attach(GameObject gameObject, EntityFlags flags)
	{
		return null;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x78A1A0", Offset = "0x7887A0", VA = "0x18078A1A0")]
	internal static GameObject Attach(GameObject gameObject, EntityFlags flags, IProtocolToken attachToken)
	{
		return null;
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x78A420", Offset = "0x788A20", VA = "0x18078A420")]
	internal static GameObject Attach(GameObject gameObject, TypeId serializerId, EntityFlags flags, IProtocolToken attachToken)
	{
		return null;
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000159")]
	[Address(RVA = "0x78A570", Offset = "0x788B70", VA = "0x18078A570")]
	public static void Detach(BoltEntity entity, IProtocolToken detachToken)
	{
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600015A")]
	[Address(RVA = "0x78A6A0", Offset = "0x788CA0", VA = "0x18078A6A0")]
	public static Entity FindEntity(NetworkId id)
	{
		return null;
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015B")]
	[Address(RVA = "0x78A8C0", Offset = "0x788EC0", VA = "0x18078A8C0")]
	public static void LoadScene(int index, IProtocolToken token)
	{
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x78A9E0", Offset = "0x788FE0", VA = "0x18078A9E0")]
	internal static void LoadSceneInternal(SceneLoadState loading)
	{
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015D")]
	[Address(RVA = "0x78ABF0", Offset = "0x7891F0", VA = "0x18078ABF0")]
	public static void Shutdown()
	{
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600015E")]
	[Address(RVA = "0x78AE50", Offset = "0x789450", VA = "0x18078AE50")]
	public static UdpSession[] GetSessions()
	{
		return null;
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015F")]
	[Address(RVA = "0x78AED0", Offset = "0x7894D0", VA = "0x18078AED0")]
	public static void Connect(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x78B0C0", Offset = "0x7896C0", VA = "0x18078B0C0")]
	public static void Connect(UdpSession session, IProtocolToken token)
	{
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x78B300", Offset = "0x789900", VA = "0x18078B300")]
	public static void SetHostInfo(string serverName, bool dedicated, IProtocolToken token)
	{
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x78B550", Offset = "0x789B50", VA = "0x18078B550")]
	public static void EnableLanBroadcast(UdpIPv4Address local, UdpIPv4Address broadcast, ushort port)
	{
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000163")]
	[Address(RVA = "0x78B5E0", Offset = "0x789BE0", VA = "0x18078B5E0")]
	public static void DisableLanBroadcast()
	{
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000164")]
	[Address(RVA = "0x78B720", Offset = "0x789D20", VA = "0x18078B720")]
	private static void AdjustEstimatedRemoteFrames()
	{
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x78B8D0", Offset = "0x789ED0", VA = "0x18078B8D0")]
	private static void StepNonControlledRemoteEntities()
	{
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x78BAC0", Offset = "0x78A0C0", VA = "0x18078BAC0")]
	private static void PollNetwork()
	{
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x78C910", Offset = "0x78AF10", VA = "0x18078C910")]
	private static void Udp_MasterServerNatProbeResult(UdpEventMasterServerNatFeatures ev)
	{
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000168")]
	[Address(RVA = "0x78C970", Offset = "0x78AF70", VA = "0x18078C970")]
	private static void Udp_MasterServerConnectFailed(UdpEventMasterServerConnectFailed ev)
	{
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000169")]
	[Address(RVA = "0x78C9D0", Offset = "0x78AFD0", VA = "0x18078C9D0")]
	private static void Udp_MasterServerDisconnected(UdpEventMasterServerDisconnected ev)
	{
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x78CA30", Offset = "0x78B030", VA = "0x18078CA30")]
	private static void Udp_MasterServerConnected(UdpEventMasterServerConnected ev)
	{
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x78CA90", Offset = "0x78B090", VA = "0x18078CA90")]
	private static void Udp_SessionConnectFailed(UdpEventSessionConnectFailed ev)
	{
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016C")]
	[Address(RVA = "0x78CB10", Offset = "0x78B110", VA = "0x18078CB10")]
	private static void Udp_SessionListUpdated(UdpEvent ev)
	{
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016D")]
	[Address(RVA = "0x78CC60", Offset = "0x78B260", VA = "0x18078CC60")]
	private static void Udp_StreamDataReceived(UdpEvent ev)
	{
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016E")]
	[Address(RVA = "0x78CDE0", Offset = "0x78B3E0", VA = "0x18078CDE0")]
	private static void Udp_PacketReceived(UdpEvent ev)
	{
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016F")]
	[Address(RVA = "0x78CF60", Offset = "0x78B560", VA = "0x18078CF60")]
	private static void Udp_PacketDelivered(UdpEvent ev)
	{
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x78D1B0", Offset = "0x78B7B0", VA = "0x18078D1B0")]
	private static void Udp_PacketLost(UdpEvent ev)
	{
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000171")]
	[Address(RVA = "0x78D400", Offset = "0x78BA00", VA = "0x18078D400")]
	private static void Udp_ConnectAttempt(UdpEventConnectAttempt ev)
	{
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000172")]
	[Address(RVA = "0x78D480", Offset = "0x78BA80", VA = "0x18078D480")]
	private static void Udp_SocketStartupFailed(UdpEventStartFailed ev)
	{
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x78D530", Offset = "0x78BB30", VA = "0x18078D530")]
	private static void Udp_SocketStartupDone(UdpEventStartDone ev)
	{
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000174")]
	[Address(RVA = "0x78D6A0", Offset = "0x78BCA0", VA = "0x18078D6A0")]
	private static void Udp_ConnectFailed(UdpEventConnectFailed ev)
	{
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000175")]
	[Address(RVA = "0x78D780", Offset = "0x78BD80", VA = "0x18078D780")]
	private static void Udp_ConnectRefused(UdpEventConnectRefused ev)
	{
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000176")]
	[Address(RVA = "0x78D860", Offset = "0x78BE60", VA = "0x18078D860")]
	private static void Udp_ConnectRequest(UdpEventConnectRequest ev)
	{
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x78D8E0", Offset = "0x78BEE0", VA = "0x18078D8E0")]
	public static void AcceptConnection(UdpEndPoint endpoint, object userToken, IProtocolToken acceptToken)
	{
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x78DB60", Offset = "0x78C160", VA = "0x18078DB60")]
	public static void RefuseConnection(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000179")]
	[Address(RVA = "0x78DD80", Offset = "0x78C380", VA = "0x18078DD80")]
	internal static void Send()
	{
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x78E430", Offset = "0x78CA30", VA = "0x18078E430")]
	private static void UpdateUPnP()
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x78E6C0", Offset = "0x78CCC0", VA = "0x18078E6C0")]
	internal static void Poll()
	{
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x78EB80", Offset = "0x78D180", VA = "0x18078EB80")]
	internal static void FreezeProxies()
	{
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x78EE10", Offset = "0x78D410", VA = "0x18078EE10")]
	private static void InvokeRemoteSceneCallbacks()
	{
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x78F110", Offset = "0x78D710", VA = "0x18078F110")]
	private static void Udp_Connected(UdpConnection udp)
	{
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017F")]
	[Address(RVA = "0x78F770", Offset = "0x78DD70", VA = "0x18078F770")]
	private static void Udp_Disconnect(UdpConnection udp)
	{
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x78F990", Offset = "0x78DF90", VA = "0x18078F990")]
	internal static void UpdateActiveGlobalBehaviours(int index)
	{
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x78FE40", Offset = "0x78E440", VA = "0x18078FE40")]
	private static Component CreateGlobalBehaviour(Type t)
	{
		return null;
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x790090", Offset = "0x78E690", VA = "0x180790090")]
	private static void DeleteGlobalBehaviour(Type t)
	{
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x7902B0", Offset = "0x78E8B0", VA = "0x1807902B0")]
	private static void UnityLogCallback(string condition, string stackTrace, LogType type)
	{
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x790330", Offset = "0x78E930", VA = "0x180790330")]
	internal static void Initialize(BoltNetworkModes mode, UdpEndPoint endpoint, BoltConfig config, UdpPlatform udpPlatform, string autoloadscene)
	{
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private static void UdpLogWriter(uint level, string message)
	{
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x7907C0", Offset = "0x78EDC0", VA = "0x1807907C0")]
	internal static void SceneLoadBegin(SceneLoadState state)
	{
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x790BF0", Offset = "0x78F1F0", VA = "0x180790BF0")]
	internal static void SceneLoadDone(SceneLoadState state)
	{
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x790DC0", Offset = "0x78F3C0", VA = "0x180790DC0")]
	internal static void UpdateSceneObjectsLookup()
	{
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x7914E0", Offset = "0x78FAE0", VA = "0x1807914E0")]
	internal static GameObject FindSceneObject(UniqueId uniqueId)
	{
		return null;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x791660", Offset = "0x78FC60", VA = "0x180791660")]
	internal static UdpPacket AllocateUdpPacket()
	{
		return null;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002790 File Offset: 0x00000990
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x7916D0", Offset = "0x78FCD0", VA = "0x1807916D0")]
	internal static UdpChannelName CreateStreamChannel(string name, UdpChannelMode mode, int priority)
	{
		return default(UdpChannelName);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x791810", Offset = "0x78FE10", VA = "0x180791810")]
	internal static void Update()
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x791980", Offset = "0x78FF80", VA = "0x180791980")]
	private static void CreateUdpConfig(BoltConfig config)
	{
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x791D00", Offset = "0x790300", VA = "0x180791D00")]
	private static void CreateBoltBehaviourObject()
	{
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x792020", Offset = "0x790620", VA = "0x180792020")]
	private static void ResetIdAllocator(BoltNetworkModes mode)
	{
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000190")]
	[Address(RVA = "0x7920C0", Offset = "0x7906C0", VA = "0x1807920C0")]
	internal static void BeginStart(ControlCommandStart cmd)
	{
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x792A60", Offset = "0x791060", VA = "0x180792A60")]
	internal static void ShutdownImmediate()
	{
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x793060", Offset = "0x791660", VA = "0x180793060")]
	internal static void BeginShutdown(ControlCommandShutdown cmd)
	{
	}

	// Token: 0x040000D1 RID: 209
	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x0")]
	internal static UdpSocket _udpSocket;

	// Token: 0x040000D2 RID: 210
	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x8")]
	internal static UdpPlatform _udpPlatform;

	// Token: 0x040000D3 RID: 211
	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x10")]
	internal static string _autoloadScene;

	// Token: 0x040000D4 RID: 212
	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x18")]
	internal static Stopwatch _timer;

	// Token: 0x040000D5 RID: 213
	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x20")]
	internal static SceneLoadState _localSceneLoading;

	// Token: 0x040000D6 RID: 214
	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x38")]
	internal static bool _canReceiveEntities;

	// Token: 0x040000D7 RID: 215
	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x40")]
	internal static IPrefabPool PrefabPool;

	// Token: 0x040000D8 RID: 216
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x48")]
	internal static IEventFilter EventFilter;

	// Token: 0x040000D9 RID: 217
	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x50")]
	internal static int _frame;

	// Token: 0x040000DA RID: 218
	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x54")]
	internal static BoltNetworkModes _mode;

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x58")]
	internal static BoltConfig _config;

	// Token: 0x040000DC RID: 220
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x60")]
	internal static UdpConfig _udpConfig;

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x68")]
	internal static BoltDoubleList<Entity> _entitiesOK;

	// Token: 0x040000DE RID: 222
	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x70")]
	internal static BoltDoubleList<Entity> _entitiesFZ;

	// Token: 0x040000DF RID: 223
	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x78")]
	internal static BoltDoubleList<BoltConnection> _connections;

	// Token: 0x040000E0 RID: 224
	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x80")]
	internal static EventDispatcher _globalEventDispatcher;

	// Token: 0x040000E1 RID: 225
	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x88")]
	internal static Dictionary<UniqueId, BoltEntity> _sceneObjects;

	// Token: 0x040000E2 RID: 226
	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x90")]
	internal static GameObject _globalControlObject;

	// Token: 0x040000E3 RID: 227
	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x98")]
	internal static GameObject _globalBehaviourObject;

	// Token: 0x040000E4 RID: 228
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0xA0")]
	internal static List<STuple<BoltGlobalBehaviourAttribute, Type>> _globalBehaviours;

	// Token: 0x040000E5 RID: 229
	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0xA8")]
	internal static Func<GameObject, Vector3, Quaternion, GameObject> _instantiate;

	// Token: 0x040000E6 RID: 230
	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0xB0")]
	internal static Action<GameObject> _destroy;

	// Token: 0x040000E7 RID: 231
	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0xB8")]
	public static TimeSpan SendTime;

	// Token: 0x040000E8 RID: 232
	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0xC0")]
	public static TimeSpan AutoscopeTime;

	// Token: 0x040000E9 RID: 233
	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0xC8")]
	public static TimeSpan PollNetworkTime;

	// Token: 0x040000EA RID: 234
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0xD0")]
	public static TimeSpan InvokeRemoteSceneCallbacksTime;

	// Token: 0x040000EB RID: 235
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0xD8")]
	public static TimeSpan AdjustEstimatedRemoteFramesTime;

	// Token: 0x040000EC RID: 236
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0xE0")]
	public static TimeSpan StepNonControlledRemoteEntitiesTime;

	// Token: 0x040000ED RID: 237
	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0xE8")]
	public static TimeSpan SimulateLocalAndControlledEntitiesTime;

	// Token: 0x040000EE RID: 238
	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0xF0")]
	public static TimeSpan DispatchAllEventsTime;
}
