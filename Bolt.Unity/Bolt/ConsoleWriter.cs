using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public static class ConsoleWriter
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x7AD510", Offset = "0x7ABB10", VA = "0x1807AD510")]
		public static void Open()
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x7AD8B0", Offset = "0x7ABEB0", VA = "0x1807AD8B0")]
		public static void Close()
		{
		}

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static TextWriter realOut;

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		private static class PInvoke
		{
			// Token: 0x060000C0 RID: 192
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x7AD9F0", Offset = "0x7ABFF0", VA = "0x1807AD9F0")]
			[PreserveSig]
			public static extern bool AttachConsole(uint dwProcessId);

			// Token: 0x060000C1 RID: 193
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x7ADA80", Offset = "0x7AC080", VA = "0x1807ADA80")]
			[PreserveSig]
			public static extern bool AllocConsole();

			// Token: 0x060000C2 RID: 194
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x7ADB00", Offset = "0x7AC100", VA = "0x1807ADB00")]
			[PreserveSig]
			public static extern bool FreeConsole();

			// Token: 0x060000C3 RID: 195
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x7ADB80", Offset = "0x7AC180", VA = "0x1807ADB80")]
			[PreserveSig]
			public static extern IntPtr GetStdHandle(int nStdHandle);

			// Token: 0x060000C4 RID: 196
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x7ADC10", Offset = "0x7AC210", VA = "0x1807ADC10")]
			[PreserveSig]
			public static extern bool SetConsoleTitle(string lpConsoleTitle);

			// Token: 0x04000054 RID: 84
			[Token(Token = "0x4000054")]
			public const int STD_OUTPUT_HANDLE = -11;
		}
	}
}
