using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Json;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Metrics
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	internal abstract class MetricsSubmissionQueue<T> where T : EventAggregationBase
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000299C File Offset: 0x00000B9C
		[Token(Token = "0x1700005F")]
		public int Count
		{
			[Token(Token = "0x60001F8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000029B4 File Offset: 0x00000BB4
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000060")]
		public uint MaximumEvents
		{
			[Token(Token = "0x60001F9")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60001FA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000061")]
		internal string SubmissionUrl
		{
			[Token(Token = "0x60001FB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FD")]
		internal MetricsSubmissionQueue(string name, string submissionUrl)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x60001FE")]
		public bool ReachedLimit()
		{
			return default(bool);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x60001FF")]
		public bool ShouldProcessEvent(string name)
		{
			return default(bool);
		}

		// Token: 0x06000200 RID: 512
		[Token(Token = "0x6000200")]
		public abstract void StartWithEvent(string eventName);

		// Token: 0x06000201 RID: 513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000201")]
		internal void Send()
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000202")]
		internal void SendPayload(ICollection<T> events, uint attempts = 0U)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000203")]
		public void SendPendingEvents(float time)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000204")]
		internal virtual void OnMaximumAttemptsReached(ICollection<T> events)
		{
		}

		// Token: 0x06000205 RID: 517
		[Token(Token = "0x6000205")]
		internal abstract IEnumerable<BacktraceJObject> GetEventsPayload(ICollection<T> events);

		// Token: 0x06000206 RID: 518 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000206")]
		internal virtual BacktraceJObject CreateJsonPayload(ICollection<T> events)
		{
			return null;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x6000207")]
		private double CalculateNextRetryTime(uint attemps)
		{
			return 0.0;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000208")]
		private BacktraceJObject CreatePayloadMetadata()
		{
			return null;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000209")]
		private void OnRequestCompleted()
		{
		}

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		public const int DefaultTimeInSecBetweenRequests = 10;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _name;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<MetricsSubmissionJob<T>> _submissionJobs;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x0")]
		internal LinkedList<T> Events;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x0")]
		private int _numberOfDroppedRequests;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x0")]
		internal IBacktraceHttpClient RequestHandler;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _applicationName;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _applicationVersion;
	}
}
