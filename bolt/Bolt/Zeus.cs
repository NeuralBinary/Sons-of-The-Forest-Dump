using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	public static class Zeus
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x17000142")]
		public static bool IsConnected
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x9032E0", Offset = "0x9018E0", VA = "0x1809032E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x17000143")]
		public static int Hosts
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x9033D0", Offset = "0x9019D0", VA = "0x1809033D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x17000144")]
		public static int ClientsInZeus
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x9034D0", Offset = "0x901AD0", VA = "0x1809034D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x17000145")]
		public static int ClientsInGames
		{
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x9035D0", Offset = "0x901BD0", VA = "0x1809035D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x17000146")]
		public static Guid GameGuid
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x9036D0", Offset = "0x901CD0", VA = "0x1809036D0")]
			get
			{
				return default(Guid);
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x903830", Offset = "0x901E30", VA = "0x180903830")]
		public static void RequestInfo()
		{
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x9039A0", Offset = "0x901FA0", VA = "0x1809039A0")]
		public static void Connect()
		{
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x903A90", Offset = "0x902090", VA = "0x180903A90")]
		public static void Connect(UdpEndPoint endpoint)
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x903D20", Offset = "0x902320", VA = "0x180903D20")]
		public static void Disconnect()
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x903E20", Offset = "0x902420", VA = "0x180903E20")]
		public static void RequestSessionList()
		{
		}
	}
}
