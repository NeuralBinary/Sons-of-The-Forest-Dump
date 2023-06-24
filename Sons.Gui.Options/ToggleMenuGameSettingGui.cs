using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	[Serializable]
	public abstract class ToggleMenuGameSettingGui : ToggleMenuOptionGui
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700006B")]
		internal override Func<string, int, int> GetIntSettingDelegate
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x3050920", Offset = "0x304EF20", VA = "0x183050920", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700006C")]
		internal override Func<string, string, string> GetStringSettingDelegate
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x3050980", Offset = "0x304EF80", VA = "0x183050980", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700006D")]
		internal override Func<string, bool, bool> GetBoolSettingDelegate
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x30509E0", Offset = "0x304EFE0", VA = "0x1830509E0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700006E")]
		internal override Func<string, float, float> GetFloatSettingDelegate
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x3050A40", Offset = "0x304F040", VA = "0x183050A40", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700006F")]
		internal override Action<string, int> SetIntSettingDelegate
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x3050AA0", Offset = "0x304F0A0", VA = "0x183050AA0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000070")]
		internal override Action<string, string> SetStringSettingDelegate
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x3050B00", Offset = "0x304F100", VA = "0x183050B00", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000071")]
		internal override Action<string, bool> SetBoolSettingDelegate
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x3050B60", Offset = "0x304F160", VA = "0x183050B60", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000072")]
		internal override Action<string, float> SetFloatSettingDelegate
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x3050BC0", Offset = "0x304F1C0", VA = "0x183050BC0", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x303B480", Offset = "0x3039A80", VA = "0x18303B480")]
		protected ToggleMenuGameSettingGui()
		{
		}
	}
}
