using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
public class NullPlatform : UdpPlatform
{
	// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x7AAC00", Offset = "0x7A9200", VA = "0x1807AAC00")]
	public NullPlatform()
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x7AAC20", Offset = "0x7A9220", VA = "0x1807AAC20", Slot = "10")]
	public override UdpPlatformSocket CreateSocket()
	{
		return null;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x000022C8 File Offset: 0x000004C8
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x7AACB0", Offset = "0x7A92B0", VA = "0x1807AACB0", Slot = "8")]
	public override UdpIPv4Address GetBroadcastAddress()
	{
		return default(UdpIPv4Address);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x7AAD00", Offset = "0x7A9300", VA = "0x1807AAD00", Slot = "11")]
	public override List<UdpPlatformInterface> GetNetworkInterfaces()
	{
		return null;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x000022E0 File Offset: 0x000004E0
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x7AAD60", Offset = "0x7A9360", VA = "0x1807AAD60", Slot = "7")]
	public override uint GetPrecisionTime()
	{
		return 0U;
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x7AAE40", Offset = "0x7A9440", VA = "0x1807AAE40", Slot = "9")]
	public override UdpIPv4Address[] ResolveHostAddresses(string host)
	{
		return null;
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600007B RID: 123 RVA: 0x000022F8 File Offset: 0x000004F8
	[Token(Token = "0x17000015")]
	public override bool SupportsBroadcast
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600007C RID: 124 RVA: 0x00002310 File Offset: 0x00000510
	[Token(Token = "0x17000016")]
	public override bool SupportsMasterServer
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x0600007D RID: 125 RVA: 0x00002328 File Offset: 0x00000528
	[Token(Token = "0x17000017")]
	public override bool IsNull
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	private class PrecisionTimer
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x7AAE80", Offset = "0x7A9480", VA = "0x1807AAE80")]
		internal static uint GetCurrentTime()
		{
			return 0U;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public PrecisionTimer()
		{
		}

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly long start;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly double freq;
	}
}
