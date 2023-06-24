using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
internal class BoltDebugStartSettings
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000017 RID: 23 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x17000005")]
	public static bool startServer
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x7A4810", Offset = "0x7A2E10", VA = "0x1807A4810")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000018 RID: 24 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x17000006")]
	public static bool startClient
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x7A4860", Offset = "0x7A2E60", VA = "0x1807A4860")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000019 RID: 25 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x17000007")]
	public static int windowIndex
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x7A48B0", Offset = "0x7A2EB0", VA = "0x1807A48B0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600001A RID: 26
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x7A4990", Offset = "0x7A2F90", VA = "0x1807A4990")]
	[PreserveSig]
	private static extern int GetWindowThreadProcessId(HandleRef handle, out int processId);

	// Token: 0x0600001B RID: 27
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x7A4A30", Offset = "0x7A3030", VA = "0x1807A4A30")]
	[PreserveSig]
	private static extern bool EnumWindows(BoltDebugStartSettings.EnumWindowsProc callback, IntPtr extraData);

	// Token: 0x0600001C RID: 28
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x7A4AD0", Offset = "0x7A30D0", VA = "0x1807A4AD0")]
	[PreserveSig]
	private static extern int GetSystemMetrics(int index);

	// Token: 0x0600001D RID: 29
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x7A4B50", Offset = "0x7A3150", VA = "0x1807A4B50")]
	[PreserveSig]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

	// Token: 0x0600001E RID: 30 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x7A4C20", Offset = "0x7A3220", VA = "0x1807A4C20")]
	private static bool Window(IntPtr hWnd, IntPtr lParam)
	{
		return default(bool);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x7A4EE0", Offset = "0x7A34E0", VA = "0x1807A4EE0")]
	public static void PositionWindow()
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public BoltDebugStartSettings()
	{
	}

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly object handle;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static HandleRef unityHandle;

	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	private static class HWND
	{
		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static IntPtr NoTopMost;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static IntPtr TopMost;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static IntPtr Top;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static IntPtr Bottom;
	}

	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	private static class SWP
	{
		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int NOSIZE;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int NOMOVE;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int NOZORDER;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int NOREDRAW;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int NOACTIVATE;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int DRAWFRAME;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int FRAMECHANGED;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int SHOWWINDOW;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int HIDEWINDOW;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int NOCOPYBITS;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int NOOWNERZORDER;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int NOREPOSITION;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int NOSENDCHANGING;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int DEFERERASE;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int ASYNCWINDOWPOS;
	}

	// Token: 0x02000008 RID: 8
	// (Invoke) Token: 0x06000025 RID: 37
	[Token(Token = "0x2000008")]
	private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
}
