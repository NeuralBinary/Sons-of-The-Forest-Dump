using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200089A RID: 2202
	[Token(Token = "0x200089A")]
	public class TechArmorAchievement : Achievement
	{
		// Token: 0x06003EBB RID: 16059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EBB")]
		[Address(RVA = "0x35D5410", Offset = "0x35D3A10", VA = "0x1835D5410", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EBC")]
		[Address(RVA = "0x35D54F0", Offset = "0x35D3AF0", VA = "0x1835D54F0")]
		private void OnArmorEquipped(object _)
		{
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EBD")]
		[Address(RVA = "0x35D5570", Offset = "0x35D3B70", VA = "0x1835D5570", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EBE")]
		[Address(RVA = "0x35D5660", Offset = "0x35D3C60", VA = "0x1835D5660", Slot = "7")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EBF")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TechArmorAchievement()
		{
		}
	}
}
