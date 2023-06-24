using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020001EB RID: 491
	[Token(Token = "0x20001EB")]
	public abstract class ObiPathDataChannel<T, U> : IObiPathDataChannel
	{
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00005264 File Offset: 0x00003464
		[Token(Token = "0x17000196")]
		public int Count
		{
			[Token(Token = "0x60009F8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0000527C File Offset: 0x0000347C
		[Token(Token = "0x17000197")]
		public bool Dirty
		{
			[Token(Token = "0x60009F9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009FA")]
		public void Clean()
		{
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009FB")]
		public ObiPathDataChannel(ObiInterpolator<U> interpolator)
		{
		}

		// Token: 0x17000198 RID: 408
		[Token(Token = "0x17000198")]
		public T this[int i]
		{
			[Token(Token = "0x60009FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009FD")]
			set
			{
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009FE")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60009FF")]
		public U Evaluate(U v0, U v1, U v2, U v3, float mu)
		{
			return null;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000A00")]
		public U EvaluateFirstDerivative(U v0, U v1, U v2, U v3, float mu)
		{
			return null;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000A01")]
		public U EvaluateSecondDerivative(U v0, U v1, U v2, U v3, float mu)
		{
			return null;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00005294 File Offset: 0x00003494
		[Token(Token = "0x6000A02")]
		public int GetSpanCount(bool closed)
		{
			return 0;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000052AC File Offset: 0x000034AC
		[Token(Token = "0x6000A03")]
		public int GetSpanControlPointAtMu(bool closed, float mu, out float spanMu)
		{
			return 0;
		}

		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0x0")]
		protected ObiInterpolator<U> interpolator;

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x0")]
		protected bool dirty;

		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x4000812")]
		[FieldOffset(Offset = "0x0")]
		public List<T> data;
	}
}
