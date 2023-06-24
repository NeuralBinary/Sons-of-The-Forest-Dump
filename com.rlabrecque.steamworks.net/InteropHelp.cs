using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace Steamworks
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	public class InteropHelp
	{
		// Token: 0x060008BB RID: 2235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void TestIfPlatformSupported()
		{
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x981780", Offset = "0x97FD80", VA = "0x180981780")]
		public static void TestIfAvailableClient()
		{
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x981820", Offset = "0x97FE20", VA = "0x180981820")]
		public static void TestIfAvailableGameServer()
		{
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x9818C0", Offset = "0x97FEC0", VA = "0x1809818C0")]
		public static string PtrToStringUTF8(IntPtr nativeUtf8)
		{
			return null;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x981A90", Offset = "0x980090", VA = "0x180981A90")]
		public static string ByteArrayToStringUTF8(byte[] buffer)
		{
			return null;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x981B10", Offset = "0x980110", VA = "0x180981B10")]
		public static void StringToByteArrayUTF8(string str, byte[] outArrayBuffer, int outArrayBufferSize)
		{
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public InteropHelp()
		{
		}

		// Token: 0x02000182 RID: 386
		[Token(Token = "0x2000182")]
		public class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
		{
			// Token: 0x060008C2 RID: 2242 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x981BC0", Offset = "0x9801C0", VA = "0x180981BC0")]
			public UTF8StringHandle(string str)
			{
			}

			// Token: 0x060008C3 RID: 2243 RVA: 0x00007BBC File Offset: 0x00005DBC
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x981D50", Offset = "0x980350", VA = "0x180981D50", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}

		// Token: 0x02000183 RID: 387
		[Token(Token = "0x2000183")]
		public class SteamParamStringArray
		{
			// Token: 0x060008C4 RID: 2244 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x981DC0", Offset = "0x9803C0", VA = "0x180981DC0")]
			public SteamParamStringArray(IList<string> strings)
			{
			}

			// Token: 0x060008C5 RID: 2245 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x9826C0", Offset = "0x980CC0", VA = "0x1809826C0", Slot = "1")]
			protected override void Finalize()
			{
			}

			// Token: 0x060008C6 RID: 2246 RVA: 0x00007BD4 File Offset: 0x00005DD4
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x9827D0", Offset = "0x980DD0", VA = "0x1809827D0")]
			public static implicit operator IntPtr(InteropHelp.SteamParamStringArray that)
			{
				return 0;
			}

			// Token: 0x040009F6 RID: 2550
			[Token(Token = "0x40009F6")]
			[FieldOffset(Offset = "0x10")]
			private IntPtr[] m_Strings;

			// Token: 0x040009F7 RID: 2551
			[Token(Token = "0x40009F7")]
			[FieldOffset(Offset = "0x18")]
			private IntPtr m_ptrStrings;

			// Token: 0x040009F8 RID: 2552
			[Token(Token = "0x40009F8")]
			[FieldOffset(Offset = "0x20")]
			private IntPtr m_pSteamParamStringArray;
		}
	}
}
