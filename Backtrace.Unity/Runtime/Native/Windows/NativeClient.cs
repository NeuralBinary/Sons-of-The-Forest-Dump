using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Backtrace.Unity.Interfaces;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Attributes;
using Backtrace.Unity.Model.Breadcrumbs;
using Backtrace.Unity.Runtime.Native.Base;
using Il2CppDummyDll;

namespace Backtrace.Unity.Runtime.Native.Windows
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	internal sealed class NativeClient : NativeClientBase, INativeClient, IDynamicAttributeProvider, IStartupMinidumpSender
	{
		// Token: 0x06000120 RID: 288
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x747230", Offset = "0x745830", VA = "0x180747230")]
		[PreserveSig]
		private static extern bool Initialize(string submissionUrl, string databasePath, string handlerPath, string[] attachments, int attachmentSize);

		// Token: 0x06000121 RID: 289
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x7473D0", Offset = "0x7459D0", VA = "0x1807473D0")]
		[PreserveSig]
		private static extern bool AddNativeAttribute(string key, string value);

		// Token: 0x06000122 RID: 290
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x7474A0", Offset = "0x745AA0", VA = "0x1807474A0")]
		[PreserveSig]
		private static extern void NativeReport(string message, bool setMainThreadAsFaultingThread);

		// Token: 0x06000123 RID: 291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x747550", Offset = "0x745B50", VA = "0x180747550")]
		public NativeClient(BacktraceConfiguration configuration, BacktraceBreadcrumbs breadcrumbs, IDictionary<string, string> clientAttributes, IEnumerable<string> attachments)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x7475D0", Offset = "0x745BD0", VA = "0x1807475D0")]
		private void HandleNativeCrashes(IDictionary<string, string> clientAttributes, IEnumerable<string> attachments)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x747E20", Offset = "0x746420", VA = "0x180747E20")]
		private bool Isx86Build(string pluginDirectoryPath)
		{
			return default(bool);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "13")]
		public void GetAttributes(IDictionary<string, string> attributes)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x747EB0", Offset = "0x7464B0", VA = "0x180747EB0", Slot = "7")]
		public void HandleAnr()
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
		public bool OnOOM()
		{
			return default(bool);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x748120", Offset = "0x746720", VA = "0x180748120", Slot = "8")]
		public void SetAttribute(string key, string value)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x7481B0", Offset = "0x7467B0", VA = "0x1807481B0", Slot = "14")]
		public IEnumerator SendMinidumpOnStartup(ICollection<string> clientAttachments, IBacktraceApi backtraceApi)
		{
			return null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x7482B0", Offset = "0x7468B0", VA = "0x1807482B0")]
		private string GetPluginDirectoryPath()
		{
			return null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x748380", Offset = "0x746980", VA = "0x180748380")]
		private string GetDefaultPathToCrashpadHandler(string pluginDirectoryPath)
		{
			return null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x748400", Offset = "0x746A00", VA = "0x180748400")]
		internal static void CleanScopedAttributes()
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x748680", Offset = "0x746C80", VA = "0x180748680")]
		internal static IDictionary<string, string> GetScopedAttributes()
		{
			return null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x748DA0", Offset = "0x7473A0", VA = "0x180748DA0")]
		private void AddAttributes(string key, string value)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x748DF0", Offset = "0x7473F0", VA = "0x180748DF0")]
		internal void AddScopedAttributes(IDictionary<string, string> attributes)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x7490F0", Offset = "0x7476F0", VA = "0x1807490F0")]
		private void AddScopedAttribute(string key, string value)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x7492C0", Offset = "0x7478C0", VA = "0x1807492C0")]
		private static bool HasScopedAttributesEmpty(string attributesJson)
		{
			return default(bool);
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		private const string ScopedAttributeListKey = "backtrace-scoped-attributes";

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		private const string ScopedAttributesPattern = "bt-{0}";

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		internal const string VersionKey = "backtrace-app-version";

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		internal const string MachineUuidKey = "backtrace-uuid";

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		internal const string SessionKey = "backtrace-session-id";

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x2000025")]
		[Serializable]
		private class ScopedAttributesContainer
		{
			// Token: 0x06000133 RID: 307 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x749350", Offset = "0x747950", VA = "0x180749350")]
			public ScopedAttributesContainer()
			{
			}

			// Token: 0x040000D2 RID: 210
			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> Keys;
		}
	}
}
