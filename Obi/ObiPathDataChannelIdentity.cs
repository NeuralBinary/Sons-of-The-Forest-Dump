using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020001EC RID: 492
	[Token(Token = "0x20001EC")]
	public abstract class ObiPathDataChannelIdentity<T> : ObiPathDataChannel<T, T>
	{
		// Token: 0x06000A04 RID: 2564 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A04")]
		public ObiPathDataChannelIdentity(ObiInterpolator<T> interpolator)
		{
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000A05")]
		public T GetFirstDerivative(int index)
		{
			return null;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000A06")]
		public T GetSecondDerivative(int index)
		{
			return null;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000A07")]
		public T GetAtMu(bool closed, float mu)
		{
			return null;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000A08")]
		public T GetFirstDerivativeAtMu(bool closed, float mu)
		{
			return null;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000A09")]
		public T GetSecondDerivativeAtMu(bool closed, float mu)
		{
			return null;
		}
	}
}
