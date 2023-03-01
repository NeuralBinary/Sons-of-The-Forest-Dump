using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Player.CustomActions
{
	// Token: 0x02000759 RID: 1881
	[Token(Token = "0x2000759")]
	[Serializable]
	public class DumpItemBurstDef
	{
		// Token: 0x06003120 RID: 12576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003120")]
		[Address(RVA = "0x1B45110", Offset = "0x1B44110", VA = "0x181B45110")]
		public DumpItemBurstDef(float startPercent, float endPercent, float delayBetweenItem, float delayAfter)
		{
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		[Token(Token = "0x17000626")]
		public float EndPercent
		{
			[Token(Token = "0x6003121")]
			[Address(RVA = "0x6849B0", Offset = "0x6839B0", VA = "0x1806849B0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		[Token(Token = "0x17000627")]
		public float StartPercent
		{
			[Token(Token = "0x6003122")]
			[Address(RVA = "0x8EE100", Offset = "0x8ED100", VA = "0x1808EE100")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x0000E100 File Offset: 0x0000C300
		[Token(Token = "0x17000628")]
		public float DelayBetweenItem
		{
			[Token(Token = "0x6003123")]
			[Address(RVA = "0x8CDC30", Offset = "0x8CCC30", VA = "0x1808CDC30")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x0000E118 File Offset: 0x0000C318
		[Token(Token = "0x17000629")]
		public float DelayAfter
		{
			[Token(Token = "0x6003124")]
			[Address(RVA = "0x661930", Offset = "0x660930", VA = "0x180661930")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x04002AF5 RID: 10997
		[Token(Token = "0x4002AF5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _startPercent;

		// Token: 0x04002AF6 RID: 10998
		[Token(Token = "0x4002AF6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _endPercent;

		// Token: 0x04002AF7 RID: 10999
		[Token(Token = "0x4002AF7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _delayBetweenItem;

		// Token: 0x04002AF8 RID: 11000
		[Token(Token = "0x4002AF8")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _delayAfter;
	}
}
