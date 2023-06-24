using System;
using System.Net;
using System.Net.Sockets;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
internal class DotNetSocket : UdpPlatformSocket
{
	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000065 RID: 101 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000010")]
	public override UdpPlatform Platform
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "9")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x7A9F30", Offset = "0x7A8530", VA = "0x1807A9F30")]
	public DotNetSocket(DotNetPlatform platform)
	{
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000067 RID: 103 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000011")]
	public override string Error
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000068 RID: 104 RVA: 0x00002220 File Offset: 0x00000420
	[Token(Token = "0x17000012")]
	public override bool IsBound
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x7AA1F0", Offset = "0x7A87F0", VA = "0x1807AA1F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000069 RID: 105 RVA: 0x00002238 File Offset: 0x00000438
	[Token(Token = "0x17000013")]
	public override UdpEndPoint EndPoint
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x7AA200", Offset = "0x7A8800", VA = "0x1807AA200", Slot = "8")]
		get
		{
			return default(UdpEndPoint);
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x0600006A RID: 106 RVA: 0x00002250 File Offset: 0x00000450
	// (set) Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000014")]
	public override bool Broadcast
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x7AA270", Offset = "0x7A8870", VA = "0x1807AA270", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x7AA400", Offset = "0x7A8A00", VA = "0x1807AA400", Slot = "7")]
		set
		{
		}
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x7AA520", Offset = "0x7A8B20", VA = "0x1807AA520", Slot = "10")]
	public override void Close()
	{
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x7AA610", Offset = "0x7A8C10", VA = "0x1807AA610", Slot = "11")]
	public override void Bind(UdpEndPoint ep)
	{
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002268 File Offset: 0x00000468
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x7AA7D0", Offset = "0x7A8DD0", VA = "0x1807AA7D0", Slot = "12")]
	public override bool RecvPoll()
	{
		return default(bool);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x7AA7F0", Offset = "0x7A8DF0", VA = "0x1807AA7F0", Slot = "13")]
	public override bool RecvPoll(int timeoutInMs)
	{
		return default(bool);
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x7AA840", Offset = "0x7A8E40", VA = "0x1807AA840", Slot = "15")]
	public override int RecvFrom(byte[] buffer, int bufferSize, ref UdpEndPoint endpoint)
	{
		return 0;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x000022B0 File Offset: 0x000004B0
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x7AA8D0", Offset = "0x7A8ED0", VA = "0x1807AA8D0", Slot = "14")]
	public override int SendTo(byte[] buffer, int bytesToSend, UdpEndPoint endpoint)
	{
		return 0;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x7AA950", Offset = "0x7A8F50", VA = "0x1807AA950")]
	private void HandleSocketException(SocketException exn)
	{
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x7AAAE0", Offset = "0x7A90E0", VA = "0x1807AAAE0")]
	private void VerifyIsBound()
	{
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x7AAB50", Offset = "0x7A9150", VA = "0x1807AAB50")]
	private static void SetConnReset(Socket s)
	{
	}

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x18")]
	private string error;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x20")]
	private Socket socket;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x28")]
	private DotNetPlatform platform;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x30")]
	private EndPoint recvEndPoint;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x38")]
	private UdpEndPoint endpoint;
}
