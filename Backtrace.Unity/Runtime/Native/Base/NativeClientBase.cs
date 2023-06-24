using System;
using System.Threading;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Breadcrumbs;
using Il2CppDummyDll;

namespace Backtrace.Unity.Runtime.Native.Base
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	internal abstract class NativeClientBase
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x749FD0", Offset = "0x7485D0", VA = "0x180749FD0")]
		internal NativeClientBase(BacktraceConfiguration configuration, BacktraceBreadcrumbs breadcrumbs)
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x74A170", Offset = "0x748770", VA = "0x18074A170", Slot = "4")]
		public void Update(float time)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x74A320", Offset = "0x748920", VA = "0x18074A320")]
		internal void OnAnrDetection()
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x74A330", Offset = "0x748930", VA = "0x18074A330", Slot = "5")]
		public void PauseAnrThread(bool stopAnr)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x74A340", Offset = "0x748940", VA = "0x18074A340", Slot = "6")]
		public virtual void Disable()
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x74A360", Offset = "0x748960", VA = "0x18074A360")]
		private bool ShouldStoreAnrBreadcrumbs()
		{
			return default(bool);
		}

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		internal const string AnrMessage = "ANRException: Blocked thread detected.";

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		protected const string HangType = "Hang";

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		protected const string CrashType = "Crash";

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		protected const string ErrorTypeAttribute = "error.type";

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x10")]
		protected int AnrWatchdogTimeout;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x14")]
		protected bool LogAnr;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x18")]
		protected internal float LastUpdateTime;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x1C")]
		internal bool PreventAnr;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x1D")]
		internal bool StopAnr;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x20")]
		internal Thread AnrThread;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x28")]
		protected bool CaptureNativeCrashes;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x29")]
		protected bool HandlerANR;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x30")]
		protected readonly BacktraceConfiguration _configuration;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x38")]
		protected readonly BacktraceBreadcrumbs _breadcrumbs;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x40")]
		private readonly bool _shouldLogAnrsInBreadcrumbs;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x48")]
		private object _lockObject;
	}
}
