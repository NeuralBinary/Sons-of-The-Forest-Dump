using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[Serializable]
	public class ProjectileReticleOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x06000282 RID: 642 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x3051420", Offset = "0x304FA20", VA = "0x183051420", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000079")]
		public override string SettingKey
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x3051450", Offset = "0x304FA50", VA = "0x183051450", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x3051480", Offset = "0x304FA80", VA = "0x183051480")]
		public ProjectileReticleOptionGui()
		{
		}

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		private const string LabelText = "Projectile Reticle";
	}
}
