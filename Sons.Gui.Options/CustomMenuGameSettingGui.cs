using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	[Serializable]
	public abstract class CustomMenuGameSettingGui : CustomMenuOptionGui
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000046")]
		internal override Func<string, int, int> GetIntSettingDelegate
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x30498A0", Offset = "0x3047EA0", VA = "0x1830498A0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000047")]
		internal override Func<string, string, string> GetStringSettingDelegate
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x3049900", Offset = "0x3047F00", VA = "0x183049900", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000048")]
		internal override Func<string, bool, bool> GetBoolSettingDelegate
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x3049960", Offset = "0x3047F60", VA = "0x183049960", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000049")]
		internal override Func<string, float, float> GetFloatSettingDelegate
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x30499C0", Offset = "0x3047FC0", VA = "0x1830499C0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700004A")]
		internal override Action<string, int> SetIntSettingDelegate
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x3049A20", Offset = "0x3048020", VA = "0x183049A20", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700004B")]
		internal override Action<string, string> SetStringSettingDelegate
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x3049A80", Offset = "0x3048080", VA = "0x183049A80", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700004C")]
		internal override Action<string, bool> SetBoolSettingDelegate
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x3049AE0", Offset = "0x30480E0", VA = "0x183049AE0", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700004D")]
		internal override Action<string, float> SetFloatSettingDelegate
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x3049B40", Offset = "0x3048140", VA = "0x183049B40", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		protected CustomMenuGameSettingGui()
		{
		}
	}
}
