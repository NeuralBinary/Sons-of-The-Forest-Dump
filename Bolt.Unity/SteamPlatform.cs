using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
public class SteamPlatform : UdpPlatform
{
	// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x7AB070", Offset = "0x7A9670", VA = "0x1807AB070")]
	public SteamPlatform()
	{
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x0600008F RID: 143 RVA: 0x00002400 File Offset: 0x00000600
	[Token(Token = "0x1700001D")]
	public override bool SupportsMasterServer
	{
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x7AB0B0", Offset = "0x7A96B0", VA = "0x1807AB0B0", Slot = "10")]
	public override UdpPlatformSocket CreateSocket()
	{
		return null;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002418 File Offset: 0x00000618
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x7AB110", Offset = "0x7A9710", VA = "0x1807AB110", Slot = "8")]
	public override UdpIPv4Address GetBroadcastAddress()
	{
		return default(UdpIPv4Address);
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x7AB160", Offset = "0x7A9760", VA = "0x1807AB160", Slot = "11")]
	public override List<UdpPlatformInterface> GetNetworkInterfaces()
	{
		return null;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002430 File Offset: 0x00000630
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x7AB1C0", Offset = "0x7A97C0", VA = "0x1807AB1C0", Slot = "7")]
	public override uint GetPrecisionTime()
	{
		return 0U;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x7AB200", Offset = "0x7A9800", VA = "0x1807AB200", Slot = "9")]
	public override UdpIPv4Address[] ResolveHostAddresses(string host)
	{
		return null;
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000095 RID: 149 RVA: 0x00002448 File Offset: 0x00000648
	[Token(Token = "0x1700001E")]
	public override bool SupportsBroadcast
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	private class PrecisionTimer
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x7AB240", Offset = "0x7A9840", VA = "0x1807AB240")]
		internal static uint GetCurrentTime()
		{
			return 0U;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public PrecisionTimer()
		{
		}

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x0")]
		private static readonly long start;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x8")]
		private static readonly double freq;
	}
}
