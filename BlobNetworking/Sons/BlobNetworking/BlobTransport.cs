using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class BlobTransport : IDisposable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event Action<BlobReceive> OnBlobReceived
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x76DD90", Offset = "0x76C390", VA = "0x18076DD90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x76DF00", Offset = "0x76C500", VA = "0x18076DF00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event Action<BlobTransportRemote> OnRemoteConnected
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x76E070", Offset = "0x76C670", VA = "0x18076E070")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x76E1E0", Offset = "0x76C7E0", VA = "0x18076E1E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x1700000A")]
		public bool IsListenServer
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x76E350", Offset = "0x76C950", VA = "0x18076E350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x1700000B")]
		public bool IsConnectClient
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x76E360", Offset = "0x76C960", VA = "0x18076E360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x1700000C")]
		public bool IsSending
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x76E370", Offset = "0x76C970", VA = "0x18076E370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x76E380", Offset = "0x76C980", VA = "0x18076E380")]
		private void TimeoutRemotes()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x76EEA0", Offset = "0x76D4A0", VA = "0x18076EEA0")]
		public void DisconnectRemote(BlobTransportRemote remote)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x76F310", Offset = "0x76D910", VA = "0x18076F310")]
		public BlobTransportRemote FindRemoteWithToken(ulong token)
		{
			return null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x76F630", Offset = "0x76DC30", VA = "0x18076F630")]
		public IEnumerable<BlobTransportRemote> Remotes()
		{
			return null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x76F960", Offset = "0x76DF60", VA = "0x18076F960")]
		public void SendBlob(byte[] data, byte channel)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x76FA40", Offset = "0x76E040", VA = "0x18076FA40")]
		public void SendBlob(BlobTransportEndpoint ep, byte[] data, byte channel)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x76FAF0", Offset = "0x76E0F0", VA = "0x18076FAF0")]
		public void SendBlob(ulong token, byte[] data, byte channel)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x76FC10", Offset = "0x76E210", VA = "0x18076FC10")]
		private void SendBlobInternal(BlobTransportEndpoint ep, byte[] data, byte channel)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x76FE90", Offset = "0x76E490", VA = "0x18076FE90")]
		public static BlobTransport CreateListening(string name, IBlobSyncNetworkInterface networkInterface)
		{
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x770050", Offset = "0x76E650", VA = "0x180770050")]
		public static BlobTransport CreateConnect(string name, IBlobSyncNetworkInterface networkInterface, BlobTransportEndpoint connectEp)
		{
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x770220", Offset = "0x76E820", VA = "0x180770220")]
		public void SetConnectToken(ulong token)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x770380", Offset = "0x76E980", VA = "0x180770380")]
		public void AddListenToken(ulong token)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x770530", Offset = "0x76EB30", VA = "0x180770530")]
		public void Start()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x770740", Offset = "0x76ED40", VA = "0x180770740")]
		public void Stop()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x770820", Offset = "0x76EE20", VA = "0x180770820", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x770880", Offset = "0x76EE80", VA = "0x180770880")]
		private void Reset()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x770F10", Offset = "0x76F510", VA = "0x180770F10")]
		private void Poll()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x771170", Offset = "0x76F770", VA = "0x180771170")]
		private void SleepWithTargetBandwidth(long targetBandwidth, long previousTick)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x7712D0", Offset = "0x76F8D0", VA = "0x1807712D0")]
		private void SendKeepAlive()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x771450", Offset = "0x76FA50", VA = "0x180771450")]
		private bool PollReceive()
		{
			return default(bool);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x771E50", Offset = "0x770450", VA = "0x180771E50")]
		private bool ValidateUdpPacket(byte[] buf, int length, BlobTransportEndpoint remoteEp)
		{
			return default(bool);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x772350", Offset = "0x770950", VA = "0x180772350")]
		private bool ProcessUdpPacket(byte[] buffer, BlobTransportEndpoint remoteEp)
		{
			return default(bool);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x7723C0", Offset = "0x7709C0", VA = "0x1807723C0")]
		private void ProcessBlock(byte[] buffer, BlobTransportEndpoint remoteEp)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x772F80", Offset = "0x771580", VA = "0x180772F80")]
		public void DispatchEvents()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x773710", Offset = "0x771D10", VA = "0x180773710")]
		private void ProcessBlockAck(byte[] buffer)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x773BA0", Offset = "0x7721A0", VA = "0x180773BA0")]
		private void ProcessKeepAlive(byte[] buffer, BlobTransportEndpoint remoteEp)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x774370", Offset = "0x772970", VA = "0x180774370")]
		private void ProcessKeepAliveAck(byte[] buffer)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x774560", Offset = "0x772B60", VA = "0x180774560")]
		private bool PollSend()
		{
			return default(bool);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x774BA0", Offset = "0x7731A0", VA = "0x180774BA0")]
		private void UdpSend(byte[] buf, int length, BlobTransportEndpoint ep)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		private static void ToBytes<T>(in T value, byte[] dest, out int length) where T : struct
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000040")]
		private static T FromBytes<T>(byte[] data) where T : struct
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x774CF0", Offset = "0x7732F0", VA = "0x180774CF0")]
		private static void Sign(byte[] buf, int length)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x774D80", Offset = "0x773380", VA = "0x180774D80")]
		private static bool IsSignatureValid(byte[] buf, int length)
		{
			return default(bool);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x774E40", Offset = "0x773440", VA = "0x180774E40")]
		public BlobTransport()
		{
		}

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		private const int NO_OP_POLL_DELAY = 50;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		private const int NO_OP_COOLDOWN = 200;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		private const int KEEPALIVE_DELAY_MS = 500;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] _packetBuffer;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		private object _tokenLock;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<ulong> _listenTokens;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x28")]
		private BlobTransportEndpoint _connectEp;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x30")]
		private ulong _connectToken;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x38")]
		private IBlobSyncNetworkInterface _networkInterface;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x40")]
		private BlobTransport.UdpSyncState _state;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x48")]
		private Queue<BlobSend> _blobSendQueue;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x50")]
		private SendRoundRobin _blobSendRoundRobin;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<int, BlobReceive> _blobReceiveMap;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x60")]
		private HashSet<int> _receivedBlobHistory;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x68")]
		private Thread _thread;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x70")]
		private string _name;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x78")]
		private long _lastKeepAliveTicks;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x80")]
		private short _localRtt;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<BlobTransportEndpoint, BlobTransportRemote> _remotesRtts;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x90")]
		private Stopwatch _stopwatch;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x98")]
		private int _ownerThreadId;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0xA0")]
		private Queue<BlobReceive> _onBlobReceivedQueue;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0xA8")]
		private Queue<BlobTransportRemote> _onRemoteConnectedQueue;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0xB0")]
		private bool _isSending;

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		private enum UdpSyncState
		{
			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			Running,
			// Token: 0x04000043 RID: 67
			[Token(Token = "0x4000043")]
			Stopping,
			// Token: 0x04000044 RID: 68
			[Token(Token = "0x4000044")]
			Stopped,
			// Token: 0x04000045 RID: 69
			[Token(Token = "0x4000045")]
			Disposed
		}
	}
}
