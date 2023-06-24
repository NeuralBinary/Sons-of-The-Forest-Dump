using System;
using System.Collections.Generic;
using System.Diagnostics;
using Bolt;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
[Documentation]
public static class BoltNetwork
{
	// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x77B9A0", Offset = "0x779FA0", VA = "0x18077B9A0")]
	public static void PreLoadPrefabDatabase()
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x77B9F0", Offset = "0x779FF0", VA = "0x18077B9F0")]
	[Conditional("DEBUG")]
	internal static void VerifyIsRunning()
	{
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x77BA90", Offset = "0x77A090", VA = "0x18077BA90")]
	public static void SetCanReceiveEntities(bool canReceiveEntities)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000053 RID: 83 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000003")]
	public static IEnumerable<BoltEntity> SceneObjects
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x77BAF0", Offset = "0x77A0F0", VA = "0x18077BAF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public static void RegisterShutdownDoneCallback(Action action)
	{
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000055 RID: 85 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x17000004")]
	public static int frame
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x77BB70", Offset = "0x77A170", VA = "0x18077BB70")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000056 RID: 86 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x17000005")]
	public static int maxConnections
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x77BC00", Offset = "0x77A200", VA = "0x18077BC00")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000057 RID: 87 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000006")]
	public static UdpSocket UdpSocket
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x77BDE0", Offset = "0x77A3E0", VA = "0x18077BDE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000058 RID: 88 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000007")]
	public static IEnumerable<BoltEntity> entities
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x77BE30", Offset = "0x77A430", VA = "0x18077BE30")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000059 RID: 89 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x17000008")]
	public static int serverFrame
	{
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x77C010", Offset = "0x77A610", VA = "0x18077C010")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600005A RID: 90 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x17000009")]
	public static float serverTime
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x77C050", Offset = "0x77A650", VA = "0x18077C050")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600005B RID: 91 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x1700000A")]
	public static float time
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x77C130", Offset = "0x77A730", VA = "0x18077C130")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600005C RID: 92 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x1700000B")]
	public static float frameDeltaTime
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x77C1B0", Offset = "0x77A7B0", VA = "0x18077C1B0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600005D RID: 93 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x1700000C")]
	[Obsolete("This property will be removed in a future update")]
	public static float frameBeginTime
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x77C230", Offset = "0x77A830", VA = "0x18077C230")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600005E RID: 94 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x1700000D")]
	[Obsolete("This property will be removed in a future update")]
	public static float frameAlpha
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x77C2B0", Offset = "0x77A8B0", VA = "0x18077C2B0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600005F RID: 95 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000E")]
	public static IEnumerable<BoltConnection> connections
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x77C2F0", Offset = "0x77A8F0", VA = "0x18077C2F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000060 RID: 96 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000F")]
	public static IEnumerable<BoltConnection> clients
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x77C380", Offset = "0x77A980", VA = "0x18077C380")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000061 RID: 97 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000010")]
	public static BoltConnection server
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x77C560", Offset = "0x77AB60", VA = "0x18077C560")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000062 RID: 98 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x17000011")]
	public static int framesPerSecond
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x77C5A0", Offset = "0x77ABA0", VA = "0x18077C5A0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000063 RID: 99 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x17000012")]
	public static bool isServer
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x77C630", Offset = "0x77AC30", VA = "0x18077C630")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000064 RID: 100 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x17000013")]
	[Obsolete("This property will be removed in a future update")]
	public static bool isServerOrNotRunning
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x77C670", Offset = "0x77AC70", VA = "0x18077C670")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000065 RID: 101 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x17000014")]
	public static bool isConnected
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x77C740", Offset = "0x77AD40", VA = "0x18077C740")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x77C870", Offset = "0x77AE70", VA = "0x18077C870")]
	public static UdpChannelName CreateStreamChannel(string name, UdpChannelMode mode, int priority)
	{
		return default(UdpChannelName);
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x77C9D0", Offset = "0x77AFD0", VA = "0x18077C9D0")]
	public static void UpdateSceneObjectsLookup()
	{
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000068 RID: 104 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x17000015")]
	public static bool isClient
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x77CA10", Offset = "0x77B010", VA = "0x18077CA10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000069 RID: 105 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x17000016")]
	public static bool isRunning
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x77CA50", Offset = "0x77B050", VA = "0x18077CA50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x0600006A RID: 106 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x17000017")]
	public static bool isDebugMode
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x77CB60", Offset = "0x77B160", VA = "0x18077CB60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600006B RID: 107 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x17000018")]
	public static ScopeMode scopeMode
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x77CBA0", Offset = "0x77B1A0", VA = "0x18077CBA0")]
		get
		{
			return ScopeMode.Automatic;
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x0600006C RID: 108 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000019")]
	public static GameObject globalObject
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x77CC00", Offset = "0x77B200", VA = "0x18077CC00")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x77CC90", Offset = "0x77B290", VA = "0x18077CC90")]
	public static BoltEntity FindEntity(NetworkId id)
	{
		return null;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006E")]
	public static void RegisterTokenClass<T>() where T : class, IProtocolToken, new()
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x77CEF0", Offset = "0x77B4F0", VA = "0x18077CEF0")]
	public static void EnableUPnP()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x77CF60", Offset = "0x77B560", VA = "0x18077CF60")]
	public static void DisableUPnP()
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x77CF70", Offset = "0x77B570", VA = "0x18077CF70")]
	public static void OpenPortUPnP(int port)
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x77CFE0", Offset = "0x77B5E0", VA = "0x18077CFE0")]
	public static void ClosePortUPnP(int port)
	{
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000073 RID: 115 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001A")]
	public static IEnumerable<INatDevice> NatDevicesUPnP
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x77D050", Offset = "0x77B650", VA = "0x18077D050")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x77D0D0", Offset = "0x77B6D0", VA = "0x18077D0D0")]
	public static void SetEventFilter(IEventFilter filter)
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x77D1D0", Offset = "0x77B7D0", VA = "0x18077D1D0")]
	public static void SetPrefabPool(IPrefabPool pool)
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x77D2D0", Offset = "0x77B8D0", VA = "0x18077D2D0")]
	public static BoltEntity Instantiate(GameObject prefab)
	{
		return null;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x77D3C0", Offset = "0x77B9C0", VA = "0x18077D3C0")]
	public static BoltEntity Instantiate(GameObject prefab, IProtocolToken token)
	{
		return null;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x77D4C0", Offset = "0x77BAC0", VA = "0x18077D4C0")]
	public static BoltEntity Instantiate(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x77D550", Offset = "0x77BB50", VA = "0x18077D550")]
	public static BoltEntity Instantiate(GameObject prefab, IProtocolToken token, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x77D850", Offset = "0x77BE50", VA = "0x18077D850")]
	public static BoltEntity Instantiate(PrefabId prefabId)
	{
		return null;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x77D9D0", Offset = "0x77BFD0", VA = "0x18077D9D0")]
	public static BoltEntity Instantiate(PrefabId prefabId, IProtocolToken token)
	{
		return null;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x77DAD0", Offset = "0x77C0D0", VA = "0x18077DAD0")]
	public static BoltEntity Instantiate(PrefabId prefabId, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x77DBF0", Offset = "0x77C1F0", VA = "0x18077DBF0")]
	public static BoltEntity Instantiate(PrefabId prefabId, IProtocolToken token, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x77DCF0", Offset = "0x77C2F0", VA = "0x18077DCF0")]
	public static void Destroy(GameObject gameObject)
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x77DD40", Offset = "0x77C340", VA = "0x18077DD40")]
	public static void Destroy(GameObject gameObject, IProtocolToken token)
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x77DF20", Offset = "0x77C520", VA = "0x18077DF20")]
	public static GameObject Attach(GameObject gameObject)
	{
		return null;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x77DF70", Offset = "0x77C570", VA = "0x18077DF70")]
	public static GameObject Attach(GameObject gameObject, IProtocolToken token)
	{
		return null;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x77E010", Offset = "0x77C610", VA = "0x18077E010")]
	public static void Detach(GameObject gameObject)
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x77E060", Offset = "0x77C660", VA = "0x18077E060")]
	public static void Detach(GameObject gameObject, IProtocolToken token)
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x77E1E0", Offset = "0x77C7E0", VA = "0x18077E1E0")]
	public static BoltPhysicsHits RaycastAll(Ray ray)
	{
		return null;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x77E380", Offset = "0x77C980", VA = "0x18077E380")]
	public static BoltPhysicsHits RaycastAll(Ray ray, int frame)
	{
		return null;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x77E3F0", Offset = "0x77C9F0", VA = "0x18077E3F0")]
	public static BoltPhysicsHits OverlapSphereAll(Vector3 origin, float radius)
	{
		return null;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x77E5B0", Offset = "0x77CBB0", VA = "0x18077E5B0")]
	public static BoltPhysicsHits OverlapSphereAll(Vector3 origin, float radius, int frame)
	{
		return null;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x77E630", Offset = "0x77CC30", VA = "0x18077E630")]
	public static void Accept(UdpEndPoint endpoint)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x77E680", Offset = "0x77CC80", VA = "0x18077E680")]
	public static void Accept(UdpEndPoint endpoint, IProtocolToken acceptToken)
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x77E6E0", Offset = "0x77CCE0", VA = "0x18077E6E0")]
	public static void Refuse(UdpEndPoint endpoint)
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x77E730", Offset = "0x77CD30", VA = "0x18077E730")]
	public static void Refuse(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x77E790", Offset = "0x77CD90", VA = "0x18077E790")]
	public static void AddGlobalEventListener(MonoBehaviour mb)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x77E800", Offset = "0x77CE00", VA = "0x18077E800")]
	public static void RemoveGlobalEventListener(MonoBehaviour mb)
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x77E870", Offset = "0x77CE70", VA = "0x18077E870")]
	public static void LoadScene(string scene)
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x77E8C0", Offset = "0x77CEC0", VA = "0x18077E8C0")]
	public static void LoadScene(string scene, IProtocolToken token)
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x77EA70", Offset = "0x77D070", VA = "0x18077EA70")]
	public static void Connect(UdpEndPoint endpoint)
	{
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x77EAC0", Offset = "0x77D0C0", VA = "0x18077EAC0")]
	public static void Connect(UdpSession session)
	{
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x77EB10", Offset = "0x77D110", VA = "0x18077EB10")]
	public static void Connect(UdpSession session, IProtocolToken token)
	{
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x77EB70", Offset = "0x77D170", VA = "0x18077EB70")]
	public static void Connect(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x77EBD0", Offset = "0x77D1D0", VA = "0x18077EBD0")]
	public static void SetHostInfo(string serverName, IProtocolToken token)
	{
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x77EC30", Offset = "0x77D230", VA = "0x18077EC30")]
	public static void SetDedicatedServerInfo(string serverName, IProtocolToken token)
	{
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x77EC90", Offset = "0x77D290", VA = "0x18077EC90")]
	public static void DisableLanBroadcast()
	{
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x77ECD0", Offset = "0x77D2D0", VA = "0x18077ECD0")]
	public static void EnableLanBroadcast()
	{
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000098 RID: 152 RVA: 0x00002208 File Offset: 0x00000408
	[Token(Token = "0x1700001B")]
	public static bool IsSinglePlayer
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x77EDE0", Offset = "0x77D3E0", VA = "0x18077EDE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x77EEB0", Offset = "0x77D4B0", VA = "0x18077EEB0")]
	public static void EnableLanBroadcast(ushort port)
	{
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x0600009A RID: 154 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001C")]
	public static Map<Guid, UdpSession> SessionList
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x77EFA0", Offset = "0x77D5A0", VA = "0x18077EFA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x77EFF0", Offset = "0x77D5F0", VA = "0x18077EFF0")]
	internal static void MasterServerRequestSessionList()
	{
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x77F160", Offset = "0x77D760", VA = "0x18077F160")]
	internal static void MasterServerConnect(UdpEndPoint endpoint)
	{
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x77F2E0", Offset = "0x77D8E0", VA = "0x18077F2E0")]
	internal static void MasterServerDisconnect()
	{
	}

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x0")]
	internal static Map<Guid, UdpSession> _sessionList;
}
