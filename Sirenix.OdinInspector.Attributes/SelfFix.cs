using System;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	public struct SelfFix
	{
		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2A8C5D0", Offset = "0x2A8ABD0", VA = "0x182A8C5D0")]
		public SelfFix(string name, Action action, bool offerInInspector)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2A8C5D0", Offset = "0x2A8ABD0", VA = "0x182A8C5D0")]
		public SelfFix(string name, Delegate action, bool offerInInspector)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2A8C6A0", Offset = "0x2A8ACA0", VA = "0x182A8C6A0")]
		public static SelfFix Create(Action action, bool offerInInspector = true)
		{
			return default(SelfFix);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x600016A")]
		[Address(RVA = "0xE0C100", Offset = "0xE0A700", VA = "0x180E0C100")]
		public static SelfFix Create(string title, Action action, bool offerInInspector = true)
		{
			return default(SelfFix);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x600016B")]
		public static SelfFix Create<T>(Action<T> action, bool offerInInspector = true) where T : new()
		{
			return default(SelfFix);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x600016C")]
		public static SelfFix Create<T>(string title, Action<T> action, bool offerInInspector = true) where T : new()
		{
			return default(SelfFix);
		}

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x0")]
		public string Title;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x8")]
		public Delegate Action;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x10")]
		public bool OfferInInspector;
	}
}
