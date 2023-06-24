using System;
using System.Net.NetworkInformation;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
public class DotNetInterface : UdpPlatformInterface
{
	// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x7A79E0", Offset = "0x7A5FE0", VA = "0x1807A79E0")]
	public DotNetInterface(NetworkInterface n, UdpIPv4Address[] gw, UdpIPv4Address[] uni, UdpIPv4Address[] multi)
	{
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000046 RID: 70 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000008")]
	public override string Name
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000047 RID: 71 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x17000009")]
	public override UdpLinkType LinkType
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580", Slot = "6")]
		get
		{
			return UdpLinkType.Unknown;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000048 RID: 72 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000A")]
	public override byte[] PhysicalAddress
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000049 RID: 73 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000B")]
	public override UdpIPv4Address[] GatewayAddresses
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80", Slot = "9")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600004A RID: 74 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000C")]
	public override UdpIPv4Address[] UnicastAddresses
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600004B RID: 75 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000D")]
	public override UdpIPv4Address[] MulticastAddresses
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x7A7C40", Offset = "0x7A6240", VA = "0x1807A7C40")]
	private static string ParseName(NetworkInterface n)
	{
		return null;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x7A7C80", Offset = "0x7A6280", VA = "0x1807A7C80")]
	private static byte[] ParsePhysicalAddress(NetworkInterface n)
	{
		return null;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x7A7D50", Offset = "0x7A6350", VA = "0x1807A7D50")]
	private static UdpLinkType ParseLinkType(NetworkInterface n)
	{
		return UdpLinkType.Unknown;
	}

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x18")]
	private string name;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x20")]
	private UdpLinkType linkType;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x28")]
	private byte[] physicalAddress;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x30")]
	private UdpIPv4Address[] gatewayAddresses;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x38")]
	private UdpIPv4Address[] unicastAddresses;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x40")]
	private UdpIPv4Address[] multicastAddresses;
}
