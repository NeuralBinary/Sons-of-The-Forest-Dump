using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class Janitor : Singleton<Janitor>
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x23CD820", Offset = "0x23CBE20", VA = "0x1823CD820")]
		public static void Dispose(ComputeBuffer buffer)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x23CD9D0", Offset = "0x23CBFD0", VA = "0x1823CD9D0", Slot = "5")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x23CDA70", Offset = "0x23CC070", VA = "0x1823CDA70", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x23CDB10", Offset = "0x23CC110", VA = "0x1823CDB10", Slot = "7")]
		protected override void OnApplicationQuit()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x23CDBB0", Offset = "0x23CC1B0", VA = "0x1823CDBB0")]
		private void Update()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x23CDBC0", Offset = "0x23CC1C0", VA = "0x1823CDBC0")]
		private void Queue(params ComputeBuffer[] buffers)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x23CDE80", Offset = "0x23CC480", VA = "0x1823CDE80")]
		private void TryFlush()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x23CE0E0", Offset = "0x23CC6E0", VA = "0x1823CE0E0")]
		private void FlushAll()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x23CE430", Offset = "0x23CCA30", VA = "0x1823CE430")]
		public Janitor()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		private Queue<Janitor.DisposalRecord> m_queue;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		private class DisposalRecord
		{
			// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x23CE540", Offset = "0x23CCB40", VA = "0x1823CE540")]
			public DisposalRecord()
			{
			}

			// Token: 0x04000007 RID: 7
			[Token(Token = "0x4000007")]
			[FieldOffset(Offset = "0x10")]
			public int Frame;

			// Token: 0x04000008 RID: 8
			[Token(Token = "0x4000008")]
			[FieldOffset(Offset = "0x18")]
			public List<ComputeBuffer> Buffers;
		}
	}
}
