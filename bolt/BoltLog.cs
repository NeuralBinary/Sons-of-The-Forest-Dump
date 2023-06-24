using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Il2CppDummyDll;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public static class BoltLog
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x7781D0", Offset = "0x7767D0", VA = "0x1807781D0")]
	public static void RemoveAll()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	public static void Add<T>(T instance) where T : class, BoltLog.IWriter
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x7785A0", Offset = "0x776BA0", VA = "0x1807785A0")]
	[Conditional("DEBUG")]
	public static void Info(string message)
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Info(object message)
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Info(string message, object arg0)
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Info(string message, object arg0, object arg1)
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Info(string message, object arg0, object arg1, object arg2)
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Info(string message, params object[] args)
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x7788F0", Offset = "0x776EF0", VA = "0x1807788F0")]
	[Conditional("DEBUG")]
	internal static void Debug(string message)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void Debug(object message)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void Debug(string message, object arg0)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void Debug(string message, object arg0, object arg1)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void Debug(string message, object arg0, object arg1, object arg2)
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void Debug(string message, params object[] args)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x778C40", Offset = "0x777240", VA = "0x180778C40")]
	private static void VerifyOneWriter()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x778CB0", Offset = "0x7772B0", VA = "0x180778CB0")]
	[Conditional("DEBUG")]
	public static void Warn(string message)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Warn(object message)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Warn(string message, object arg0)
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Warn(string message, object arg0, object arg1)
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Warn(string message, object arg0, object arg1, object arg2)
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Warn(string message, params object[] args)
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x779000", Offset = "0x777600", VA = "0x180779000")]
	private static object[] FixNulls(object[] args)
	{
		return null;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x7790E0", Offset = "0x7776E0", VA = "0x1807790E0")]
	[Conditional("DEBUG")]
	public static void Error(string message)
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Error(object message)
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Error(string message, object arg0)
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Error(string message, object arg0, object arg1)
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Error(string message, object arg0, object arg1, object arg2)
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	public static void Error(string message, params object[] args)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x779430", Offset = "0x777A30", VA = "0x180779430")]
	[Conditional("DEBUG")]
	public static void Exception(Exception exception)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x779810", Offset = "0x777E10", VA = "0x180779810")]
	private static string Format(object message)
	{
		return null;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x779870", Offset = "0x777E70", VA = "0x180779870")]
	private static string Format(string message, object arg0)
	{
		return null;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x779960", Offset = "0x777F60", VA = "0x180779960")]
	private static string Format(string message, object arg0, object arg1)
	{
		return null;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x779AB0", Offset = "0x7780B0", VA = "0x180779AB0")]
	private static string Format(string message, object arg0, object arg1, object arg2)
	{
		return null;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x779C50", Offset = "0x778250", VA = "0x180779C50")]
	private static string Format(string message, object[] args)
	{
		return null;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	internal static void Setup(BoltNetworkModes mode, BoltConfigLogTargets logTargets)
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private static readonly object _lock;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x8")]
	private static List<BoltLog.IWriter> _writers;

	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public interface IWriter : IDisposable
	{
		// Token: 0x06000025 RID: 37
		[Token(Token = "0x6000025")]
		void Info(string message);

		// Token: 0x06000026 RID: 38
		[Token(Token = "0x6000026")]
		void Debug(string message);

		// Token: 0x06000027 RID: 39
		[Token(Token = "0x6000027")]
		void Warn(string message);

		// Token: 0x06000028 RID: 40
		[Token(Token = "0x6000028")]
		void Error(string message);
	}

	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	internal class File : BoltLog.IWriter, IDisposable
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x77A1B0", Offset = "0x7787B0", VA = "0x18077A1B0")]
		public File(bool server)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x77A460", Offset = "0x778A60", VA = "0x18077A460")]
		private void Queue(string message)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x77A660", Offset = "0x778C60", VA = "0x18077A660", Slot = "4")]
		private void Info(string message)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x77A660", Offset = "0x778C60", VA = "0x18077A660", Slot = "5")]
		private void Debug(string message)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x77A660", Offset = "0x778C60", VA = "0x18077A660", Slot = "6")]
		private void Warn(string message)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x77A660", Offset = "0x778C60", VA = "0x18077A660", Slot = "7")]
		private void Error(string message)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x77A670", Offset = "0x778C70", VA = "0x18077A670", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x77A680", Offset = "0x778C80", VA = "0x18077A680")]
		private void WriteLoop()
		{
		}

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		private bool running;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x11")]
		private bool isServer;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x18")]
		private Thread thread;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		private AutoResetEvent threadEvent;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		private Queue<string> threadQueue;
	}

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	internal class Console : BoltLog.IWriter, IDisposable
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x77AF10", Offset = "0x779510", VA = "0x18077AF10", Slot = "4")]
		private void Info(string message)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x77AFB0", Offset = "0x7795B0", VA = "0x18077AFB0", Slot = "5")]
		private void Debug(string message)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x77B050", Offset = "0x779650", VA = "0x18077B050", Slot = "6")]
		private void Warn(string message)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x77B0F0", Offset = "0x7796F0", VA = "0x18077B0F0", Slot = "7")]
		private void Error(string message)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Console()
		{
		}
	}

	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	internal class SystemOut : BoltLog.IWriter, IDisposable
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x77B190", Offset = "0x779790", VA = "0x18077B190", Slot = "4")]
		private void Info(string message)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x77B230", Offset = "0x779830", VA = "0x18077B230", Slot = "5")]
		private void Debug(string message)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x77B2D0", Offset = "0x7798D0", VA = "0x18077B2D0", Slot = "6")]
		private void Warn(string message)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x77B370", Offset = "0x779970", VA = "0x18077B370", Slot = "7")]
		private void Error(string message)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SystemOut()
		{
		}
	}

	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	internal class Unity : BoltLog.IWriter, IDisposable
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x77B420", Offset = "0x779A20", VA = "0x18077B420", Slot = "4")]
		private void Info(string message)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x77B470", Offset = "0x779A70", VA = "0x18077B470", Slot = "5")]
		private void Debug(string message)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x77B4C0", Offset = "0x779AC0", VA = "0x18077B4C0", Slot = "6")]
		private void Warn(string message)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x77B510", Offset = "0x779B10", VA = "0x18077B510", Slot = "7")]
		private void Error(string message)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Unity()
		{
		}
	}
}
