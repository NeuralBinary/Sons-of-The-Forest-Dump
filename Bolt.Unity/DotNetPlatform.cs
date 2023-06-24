using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
public class DotNetPlatform : UdpPlatform
{
	// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x7A7DC0", Offset = "0x7A63C0", VA = "0x1807A7DC0")]
	public DotNetPlatform()
	{
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000050 RID: 80 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x1700000E")]
	public override bool SupportsBroadcast
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000051 RID: 81 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x1700000F")]
	public override bool SupportsMasterServer
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x7A7E00", Offset = "0x7A6400", VA = "0x1807A7E00", Slot = "7")]
	public override uint GetPrecisionTime()
	{
		return 0U;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x7A7E40", Offset = "0x7A6440", VA = "0x1807A7E40", Slot = "8")]
	public override UdpIPv4Address GetBroadcastAddress()
	{
		return default(UdpIPv4Address);
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x7A7ED0", Offset = "0x7A64D0", VA = "0x1807A7ED0", Slot = "10")]
	public override UdpPlatformSocket CreateSocket()
	{
		return null;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x7A7F30", Offset = "0x7A6530", VA = "0x1807A7F30", Slot = "11")]
	public override List<UdpPlatformInterface> GetNetworkInterfaces()
	{
		return null;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x7A7F40", Offset = "0x7A6540", VA = "0x1807A7F40", Slot = "9")]
	public override UdpIPv4Address[] ResolveHostAddresses(string host)
	{
		return null;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x7A81C0", Offset = "0x7A67C0", VA = "0x1807A81C0")]
	private List<UdpPlatformInterface> FindInterfaces()
	{
		return null;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x7A84E0", Offset = "0x7A6AE0", VA = "0x1807A84E0")]
	private DotNetInterface ParseInterface(NetworkInterface n)
	{
		return null;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x7A91C0", Offset = "0x7A77C0", VA = "0x1807A91C0")]
	public static UdpEndPoint ConvertEndPoint(EndPoint endpoint)
	{
		return default(UdpEndPoint);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x7A92C0", Offset = "0x7A78C0", VA = "0x1807A92C0")]
	public static UdpEndPoint ConvertEndPoint(IPEndPoint endpoint)
	{
		return default(UdpEndPoint);
	}

	// Token: 0x0600005B RID: 91 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x7A9360", Offset = "0x7A7960", VA = "0x1807A9360")]
	public static UdpIPv4Address ConvertAddress(IPAddress address)
	{
		return default(UdpIPv4Address);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x7A93E0", Offset = "0x7A79E0", VA = "0x1807A93E0")]
	public static IPEndPoint ConvertEndPoint(UdpEndPoint endpoint)
	{
		return null;
	}

	// Token: 0x0600005D RID: 93 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x7A9550", Offset = "0x7A7B50", VA = "0x1807A9550")]
	private static bool IsValidInterface(NetworkInterface nic, IPInterfaceProperties p)
	{
		return default(bool);
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x7A9720", Offset = "0x7A7D20", VA = "0x1807A9720")]
	private static IPAddress FindBroadcastAddress(bool strict)
	{
		return null;
	}

	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	private class PrecisionTimer
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x7A9CC0", Offset = "0x7A82C0", VA = "0x1807A9CC0")]
		internal static uint GetCurrentTime()
		{
			return 0U;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public PrecisionTimer()
		{
		}

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x0")]
		private static readonly long start;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x8")]
		private static readonly double freq;
	}
}
