using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Steamworks;
using UdpKit;

// Token: 0x02000017 RID: 23
[Token(Token = "0x2000017")]
public class SteamSocket : UdpPlatformSocket
{
	// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x7AB390", Offset = "0x7A9990", VA = "0x1807AB390")]
	public SteamSocket(SteamPlatform steamPlatform)
	{
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x7AB630", Offset = "0x7A9C30", VA = "0x1807AB630")]
	public void Send(bool isServer)
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x7ABA00", Offset = "0x7AA000", VA = "0x1807ABA00")]
	public void Recv(bool isServer)
	{
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002478 File Offset: 0x00000678
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x7ABF70", Offset = "0x7AA570", VA = "0x1807ABF70")]
	private bool IsP2PPacketAvailable(bool isServer, out uint size)
	{
		return default(bool);
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00002490 File Offset: 0x00000690
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x7AC000", Offset = "0x7AA600", VA = "0x1807AC000")]
	private bool SendP2PPacket(bool isServer, CSteamID id, byte[] data, int length, EP2PSend mode)
	{
		return default(bool);
	}

	// Token: 0x0600009E RID: 158 RVA: 0x000024A8 File Offset: 0x000006A8
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x7AC040", Offset = "0x7AA640", VA = "0x1807AC040")]
	private bool ReadP2PPacket(bool isServer, byte[] data, out uint msgSize, out CSteamID id)
	{
		return default(bool);
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x7AC090", Offset = "0x7AA690", VA = "0x1807AC090", Slot = "11")]
	public override void Bind(UdpEndPoint ep)
	{
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x060000A0 RID: 160 RVA: 0x000024C0 File Offset: 0x000006C0
	// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001F")]
	public override bool Broadcast
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x7AC0A0", Offset = "0x7AA6A0", VA = "0x1807AC0A0", Slot = "7")]
		set
		{
		}
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x7AC0E0", Offset = "0x7AA6E0", VA = "0x1807AC0E0", Slot = "10")]
	public override void Close()
	{
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x060000A3 RID: 163 RVA: 0x000024D8 File Offset: 0x000006D8
	[Token(Token = "0x17000020")]
	public override UdpEndPoint EndPoint
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "8")]
		get
		{
			return default(UdpEndPoint);
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000021")]
	public override string Error
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060000A5 RID: 165 RVA: 0x000024F0 File Offset: 0x000006F0
	[Token(Token = "0x17000022")]
	public override bool IsBound
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000023")]
	public override UdpPlatform Platform
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "9")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002508 File Offset: 0x00000708
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x7AC0F0", Offset = "0x7AA6F0", VA = "0x1807AC0F0", Slot = "15")]
	public override int RecvFrom(byte[] data, int dataSize, ref UdpEndPoint remoteEndpoint)
	{
		return 0;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00002520 File Offset: 0x00000720
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x7AC1B0", Offset = "0x7AA7B0", VA = "0x1807AC1B0", Slot = "13")]
	public override bool RecvPoll(int timeout)
	{
		return default(bool);
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00002538 File Offset: 0x00000738
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x7AA7D0", Offset = "0x7A8DD0", VA = "0x1807AA7D0", Slot = "12")]
	public override bool RecvPoll()
	{
		return default(bool);
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002550 File Offset: 0x00000750
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x7AC1F0", Offset = "0x7AA7F0", VA = "0x1807AC1F0", Slot = "14")]
	public override int SendTo(byte[] buffer, int bytesToSend, UdpEndPoint endpoint)
	{
		return 0;
	}

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x18")]
	private bool bound;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x20")]
	private UdpSteamID steamId;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x28")]
	private SteamPlatform platform;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x30")]
	private SteamSocket.BufferPool bufferPool;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x38")]
	private SteamSocket.PacketQueue recvQueue;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x40")]
	private SteamSocket.PacketQueue sendQueue;

	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	private struct Packet
	{
		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x0")]
		public UdpSteamID Id;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x8")]
		public byte[] Data;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x10")]
		public int Length;
	}

	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	private class PacketQueue
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x17000024")]
		public int Count
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x7AC320", Offset = "0x7AA920", VA = "0x1807AC320")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x7AC4B0", Offset = "0x7AAAB0", VA = "0x1807AC4B0")]
		public bool TryDequeue(out SteamSocket.Packet packet)
		{
			return default(bool);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x7AC830", Offset = "0x7AAE30", VA = "0x1807AC830")]
		public void Enqueue(SteamSocket.Packet packet)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x7ACAC0", Offset = "0x7AB0C0", VA = "0x1807ACAC0")]
		public PacketQueue()
		{
		}

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x10")]
		private Queue<SteamSocket.Packet> queue;
	}

	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	private class BufferPool
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x7ACBE0", Offset = "0x7AB1E0", VA = "0x1807ACBE0")]
		private Queue<byte[]> GetQueue(int size)
		{
			return null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x7ACCE0", Offset = "0x7AB2E0", VA = "0x1807ACCE0")]
		public byte[] Allocate(int size)
		{
			return null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x7ACF00", Offset = "0x7AB500", VA = "0x1807ACF00")]
		public byte[] Duplicate(byte[] data)
		{
			return null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x7ACF60", Offset = "0x7AB560", VA = "0x1807ACF60")]
		public void Free(byte[] buffer)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x7AD130", Offset = "0x7AB730", VA = "0x1807AD130")]
		public BufferPool()
		{
		}

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, Queue<byte[]>> bufferQueues;
	}
}
