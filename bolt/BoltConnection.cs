using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x02000022 RID: 34
[Token(Token = "0x2000022")]
[Documentation]
public class BoltConnection : BoltObject
{
	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060000F5 RID: 245 RVA: 0x000023D0 File Offset: 0x000005D0
	[Token(Token = "0x1700002B")]
	public bool IsLoadingMap
	{
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x7848E0", Offset = "0x782EE0", VA = "0x1807848E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700002C")]
	public EntityLookup ScopedTo
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x784970", Offset = "0x782F70", VA = "0x180784970")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700002D")]
	public EntityLookup SourceOf
	{
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x784990", Offset = "0x782F90", VA = "0x180784990")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700002E")]
	public EntityList HasControlOf
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000F9 RID: 249 RVA: 0x000023E8 File Offset: 0x000005E8
	[Token(Token = "0x1700002F")]
	public int RemoteFrame
	{
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x7849B0", Offset = "0x782FB0", VA = "0x1807849B0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060000FA RID: 250 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000030")]
	public IProtocolToken ConnectToken
	{
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x7849C0", Offset = "0x782FC0", VA = "0x1807849C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x7849D0", Offset = "0x782FD0", VA = "0x1807849D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060000FC RID: 252 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000031")]
	public IProtocolToken DisconnectToken
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x784A40", Offset = "0x783040", VA = "0x180784A40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000FE RID: 254 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000032")]
	public IProtocolToken AcceptToken
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x784AA0", Offset = "0x7830A0", VA = "0x180784AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x784AB0", Offset = "0x7830B0", VA = "0x180784AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06000100 RID: 256 RVA: 0x00002400 File Offset: 0x00000600
	[Token(Token = "0x17000033")]
	public float PingNetwork
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x784B10", Offset = "0x783110", VA = "0x180784B10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000101 RID: 257 RVA: 0x00002418 File Offset: 0x00000618
	[Token(Token = "0x17000034")]
	public int DejitterFrames
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x784B30", Offset = "0x783130", VA = "0x180784B30")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000102 RID: 258 RVA: 0x00002430 File Offset: 0x00000630
	[Token(Token = "0x17000035")]
	public float PingAliased
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x784B10", Offset = "0x783110", VA = "0x180784B10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000103 RID: 259 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000036")]
	internal UdpConnection udpConnection
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000104 RID: 260 RVA: 0x00002448 File Offset: 0x00000648
	[Token(Token = "0x17000037")]
	internal int remoteFrameLatest
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x784B40", Offset = "0x783140", VA = "0x180784B40")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06000105 RID: 261 RVA: 0x00002460 File Offset: 0x00000660
	[Token(Token = "0x17000038")]
	internal int remoteFrameDiff
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x76BE00", Offset = "0x76A400", VA = "0x18076BE00")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x06000106 RID: 262 RVA: 0x00002478 File Offset: 0x00000678
	[Token(Token = "0x17000039")]
	public int BitsPerSecondIn
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x6FF7C0", Offset = "0x6FDDC0", VA = "0x1806FF7C0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000107 RID: 263 RVA: 0x00002490 File Offset: 0x00000690
	[Token(Token = "0x1700003A")]
	public int BitsPerSecondOut
	{
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x784B50", Offset = "0x783150", VA = "0x180784B50")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000108 RID: 264 RVA: 0x000024A8 File Offset: 0x000006A8
	[Token(Token = "0x1700003B")]
	public uint ConnectionId
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x784B60", Offset = "0x783160", VA = "0x180784B60")]
		get
		{
			return 0U;
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000109 RID: 265 RVA: 0x000024C0 File Offset: 0x000006C0
	[Token(Token = "0x1700003C")]
	public UdpEndPoint RemoteEndPoint
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x784B80", Offset = "0x783180", VA = "0x180784B80")]
		get
		{
			return default(UdpEndPoint);
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x0600010A RID: 266 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700003D")]
	public object UserData
	{
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x784BB0", Offset = "0x7831B0", VA = "0x180784BB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x784C10", Offset = "0x783210", VA = "0x180784C10")]
	public void SetCanReceiveEntities(bool v)
	{
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x0600010D RID: 269 RVA: 0x000024D8 File Offset: 0x000006D8
	[Token(Token = "0x1700003E")]
	internal int SendRateMultiplier
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x784C20", Offset = "0x783220", VA = "0x180784C20")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010E")]
	[Address(RVA = "0x784CF0", Offset = "0x7832F0", VA = "0x180784CF0")]
	internal BoltConnection(UdpConnection udp)
	{
	}

	// Token: 0x0600010F RID: 271 RVA: 0x000024F0 File Offset: 0x000006F0
	[Token(Token = "0x600010F")]
	[Address(RVA = "0x785590", Offset = "0x783B90", VA = "0x180785590")]
	public ExistsResult ExistsOnRemote(BoltEntity entity)
	{
		return ExistsResult.No;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00002508 File Offset: 0x00000708
	[Token(Token = "0x6000110")]
	[Address(RVA = "0x785620", Offset = "0x783C20", VA = "0x180785620")]
	public ExistsResult ExistsOnRemote(BoltEntity entity, bool allowMaybe)
	{
		return ExistsResult.No;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000111")]
	[Address(RVA = "0x7856A0", Offset = "0x783CA0", VA = "0x1807856A0")]
	public void StreamBytes(UdpChannelName channel, byte[] data)
	{
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000112")]
	[Address(RVA = "0x7856D0", Offset = "0x783CD0", VA = "0x1807856D0")]
	public void SetStreamBandwidth(int bytesPerSecond)
	{
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000113")]
	[Address(RVA = "0x785860", Offset = "0x783E60", VA = "0x180785860")]
	public void Disconnect()
	{
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000114")]
	[Address(RVA = "0x785870", Offset = "0x783E70", VA = "0x180785870")]
	public void Disconnect(IProtocolToken token)
	{
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00002520 File Offset: 0x00000720
	[Token(Token = "0x6000115")]
	[Address(RVA = "0x785A40", Offset = "0x784040", VA = "0x180785A40")]
	public int GetSkippedUpdates(BoltEntity en)
	{
		return 0;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00002538 File Offset: 0x00000738
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00002550 File Offset: 0x00000750
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x785B30", Offset = "0x784130", VA = "0x180785B30", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000118")]
	[Address(RVA = "0x785B60", Offset = "0x784160", VA = "0x180785B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x785BE0", Offset = "0x7841E0", VA = "0x180785BE0")]
	internal void DisconnectedInternal()
	{
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00002568 File Offset: 0x00000768
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x785E60", Offset = "0x784460", VA = "0x180785E60")]
	internal bool StepRemoteEntities()
	{
		return default(bool);
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x7860E0", Offset = "0x7846E0", VA = "0x1807860E0")]
	internal void AdjustRemoteFrame()
	{
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011C")]
	[Address(RVA = "0x786440", Offset = "0x784A40", VA = "0x180786440")]
	internal void SwitchPerfCounters()
	{
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x786460", Offset = "0x784A60", VA = "0x180786460")]
	internal void Send()
	{
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011E")]
	[Address(RVA = "0x786890", Offset = "0x784E90", VA = "0x180786890")]
	internal void PacketReceived(UdpPacket udpPacket)
	{
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void HandleAckPacket(Packet packet)
	{
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x786B50", Offset = "0x785150", VA = "0x180786B50")]
	private void HandleFramePacket(Packet packet)
	{
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x786CC0", Offset = "0x7852C0", VA = "0x180786CC0")]
	internal void PacketDelivered(Packet packet)
	{
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x786D40", Offset = "0x785340", VA = "0x180786D40")]
	internal void PacketLost(Packet packet)
	{
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00002580 File Offset: 0x00000780
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x786DC0", Offset = "0x7853C0", VA = "0x180786DC0")]
	public static implicit operator bool(BoltConnection cn)
	{
		return default(bool);
	}

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x28")]
	private UdpConnection _udp;

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x30")]
	private BoltChannel[] _channels;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x38")]
	private int _framesToStep;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x3C")]
	private int _packetsReceived;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x40")]
	private int _packetCounter;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x44")]
	private int _remoteFrameDiff;

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x48")]
	private int _remoteFrameActual;

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x4C")]
	private int _remoteFrameEstimated;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x50")]
	private bool _remoteFrameAdjust;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x54")]
	private int _bitsSecondIn;

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x58")]
	private int _bitsSecondInAcc;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x5C")]
	private int _bitsSecondOut;

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x60")]
	private int _bitsSecondOutAcc;

	// Token: 0x04000095 RID: 149
	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x68")]
	internal EventChannel _eventChannel;

	// Token: 0x04000096 RID: 150
	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x70")]
	internal SceneLoadChannel _sceneLoadChannel;

	// Token: 0x04000097 RID: 151
	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x78")]
	internal EntityChannel _entityChannel;

	// Token: 0x04000098 RID: 152
	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x80")]
	internal EntityChannel.CommandChannel _commandChannel;

	// Token: 0x04000099 RID: 153
	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x88")]
	internal List<Entity> _controlling;

	// Token: 0x0400009A RID: 154
	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x90")]
	internal EntityList _controllingList;

	// Token: 0x0400009B RID: 155
	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x98")]
	internal BoltRingBuffer<PacketStats> _packetStatsIn;

	// Token: 0x0400009C RID: 156
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0xA0")]
	internal BoltRingBuffer<PacketStats> _packetStatsOut;

	// Token: 0x0400009D RID: 157
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0xA8")]
	internal bool _canReceiveEntities;

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0xB0")]
	internal SceneLoadState _remoteSceneLoading;
}
