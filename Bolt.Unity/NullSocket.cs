using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
public class NullSocket : UdpPlatformSocket
{
	// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
	public NullSocket(NullPlatform p)
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
	public override void Bind(UdpEndPoint ep)
	{
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000083 RID: 131 RVA: 0x00002358 File Offset: 0x00000558
	// (set) Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000018")]
	public override bool Broadcast
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
	public override void Close()
	{
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000086 RID: 134 RVA: 0x00002370 File Offset: 0x00000570
	[Token(Token = "0x17000019")]
	public override UdpEndPoint EndPoint
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x7AAFE0", Offset = "0x7A95E0", VA = "0x1807AAFE0", Slot = "8")]
		get
		{
			return default(UdpEndPoint);
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000087 RID: 135 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001A")]
	public override string Error
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x7AB030", Offset = "0x7A9630", VA = "0x1807AB030", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000088 RID: 136 RVA: 0x00002388 File Offset: 0x00000588
	[Token(Token = "0x1700001B")]
	public override bool IsBound
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000089 RID: 137 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001C")]
	public override UdpPlatform Platform
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "9")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000023A0 File Offset: 0x000005A0
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "15")]
	public override int RecvFrom(byte[] buffer, int bufferSize, ref UdpEndPoint remoteEndpoint)
	{
		return 0;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000023B8 File Offset: 0x000005B8
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "13")]
	public override bool RecvPoll(int timeout)
	{
		return default(bool);
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000023D0 File Offset: 0x000005D0
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "12")]
	public override bool RecvPoll()
	{
		return default(bool);
	}

	// Token: 0x0600008D RID: 141 RVA: 0x000023E8 File Offset: 0x000005E8
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x7AB060", Offset = "0x7A9660", VA = "0x1807AB060", Slot = "14")]
	public override int SendTo(byte[] buffer, int bytesToSend, UdpEndPoint endpoint)
	{
		return 0;
	}

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x18")]
	private NullPlatform platform;
}
