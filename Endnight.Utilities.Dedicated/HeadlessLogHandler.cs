using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities.Dedicated
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class HeadlessLogHandler : ILogHandler
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0xA82D20", Offset = "0xA81320", VA = "0x180A82D20")]
		private static void HookHeadlessLogHandler(bool unfilteredLogging, bool logFilesEnabled, bool timestampLogFilenames, bool timestampLogEntries)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0xA838D0", Offset = "0xA81ED0", VA = "0x180A838D0", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0xA83A40", Offset = "0xA82040", VA = "0x180A83A40", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0xA83B90", Offset = "0xA82190", VA = "0x180A83B90", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public HeadlessLogHandler()
		{
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x10")]
		private bool _verboseLogging;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x18")]
		private StreamWriter _writer;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x20")]
		private bool _timestampLogEntries;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		private static ILogHandler _defaultLogHandler;
	}
}
