using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Player.CustomActions
{
	// Token: 0x02000664 RID: 1636
	[Token(Token = "0x2000664")]
	[Serializable]
	public class DumpItemBurstDef
	{
		// Token: 0x06002A95 RID: 10901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A95")]
		[Address(RVA = "0x1E20800", Offset = "0x1E1EE00", VA = "0x181E20800")]
		public DumpItemBurstDef(float startPercent, float endPercent, float delayBetweenItem, float delayAfter)
		{
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06002A96 RID: 10902 RVA: 0x0000C978 File Offset: 0x0000AB78
		[Token(Token = "0x17000591")]
		public float EndPercent
		{
			[Token(Token = "0x6002A96")]
			[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x0000C990 File Offset: 0x0000AB90
		[Token(Token = "0x17000592")]
		public float StartPercent
		{
			[Token(Token = "0x6002A97")]
			[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06002A98 RID: 10904 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		[Token(Token = "0x17000593")]
		public float DelayBetweenItem
		{
			[Token(Token = "0x6002A98")]
			[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		[Token(Token = "0x17000594")]
		public float DelayAfter
		{
			[Token(Token = "0x6002A99")]
			[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x040025C6 RID: 9670
		[Token(Token = "0x40025C6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _startPercent;

		// Token: 0x040025C7 RID: 9671
		[Token(Token = "0x40025C7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _endPercent;

		// Token: 0x040025C8 RID: 9672
		[Token(Token = "0x40025C8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _delayBetweenItem;

		// Token: 0x040025C9 RID: 9673
		[Token(Token = "0x40025C9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _delayAfter;
	}
}
