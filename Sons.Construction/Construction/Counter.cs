using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200025C RID: 604
	[Token(Token = "0x200025C")]
	[AddComponentMenu("Sons/Construction/Counter")]
	public class Counter
	{
		// Token: 0x06001284 RID: 4740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public void Init(int val)
		{
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0000B4D4 File Offset: 0x000096D4
		[Token(Token = "0x17000424")]
		public int Value
		{
			[Token(Token = "0x6001285")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0000B4EC File Offset: 0x000096EC
		[Token(Token = "0x6001286")]
		[Address(RVA = "0x2F3B030", Offset = "0x2F39630", VA = "0x182F3B030")]
		public int GetValueThenIncrement()
		{
			return 0;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0000B504 File Offset: 0x00009704
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x2F3B040", Offset = "0x2F39640", VA = "0x182F3B040")]
		public int IncrementThenGetValue()
		{
			return 0;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001288")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Counter()
		{
		}

		// Token: 0x04000939 RID: 2361
		[Token(Token = "0x4000939")]
		[FieldOffset(Offset = "0x10")]
		private int _counterInternal;
	}
}
