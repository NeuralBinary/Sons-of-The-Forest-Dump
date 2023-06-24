using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	internal static class UPnP
	{
		// Token: 0x06000710 RID: 1808 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x901780", Offset = "0x8FFD80", VA = "0x180901780")]
		private static bool Available()
		{
			return default(bool);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x901830", Offset = "0x8FFE30", VA = "0x180901830")]
		public static bool Enabled()
		{
			return default(bool);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x9018A0", Offset = "0x8FFEA0", VA = "0x1809018A0")]
		public static bool Update()
		{
			return default(bool);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00004B00 File Offset: 0x00002D00
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x901930", Offset = "0x8FFF30", VA = "0x180901930")]
		public static bool NextPortStatusChange(out INatDevice device, out IPortMapping mapping)
		{
			return default(bool);
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700013E")]
		public static IEnumerable<INatDevice> NatDevices
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x77D050", Offset = "0x77B650", VA = "0x18077D050")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x77CF70", Offset = "0x77B570", VA = "0x18077CF70")]
		public static void OpenPort(int port)
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x77CFE0", Offset = "0x77B5E0", VA = "0x18077CFE0")]
		public static void ClosePort(int port)
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x77CEF0", Offset = "0x77B4F0", VA = "0x18077CEF0")]
		public static void Enable()
		{
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x901A90", Offset = "0x900090", VA = "0x180901A90")]
		public static void Disable(bool async)
		{
		}
	}
}
