using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[Serializable]
	public class QualityPresetOptionGui : CustomMenuOptionGui
	{
		// Token: 0x06000289 RID: 649 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x3051630", Offset = "0x304FC30", VA = "0x183051630", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700007A")]
		public override string SettingKey
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x3051660", Offset = "0x304FC60", VA = "0x183051660", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x3051690", Offset = "0x304FC90", VA = "0x183051690", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x30516C0", Offset = "0x304FCC0", VA = "0x1830516C0", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x3051810", Offset = "0x304FE10", VA = "0x183051810", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x3051AF0", Offset = "0x30500F0", VA = "0x183051AF0")]
		private void LinkedOptionChanged(string newValue)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x3051B70", Offset = "0x3050170", VA = "0x183051B70")]
		private bool AllLinkedOptionsMatch(out string result)
		{
			return default(bool);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x3051E00", Offset = "0x3050400", VA = "0x183051E00", Slot = "44")]
		public override void ValueChanged(string newValueString)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x3051F30", Offset = "0x3050530", VA = "0x183051F30", Slot = "6")]
		public override bool ApplyCachedChanges()
		{
			return default(bool);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x3051FD0", Offset = "0x30505D0", VA = "0x183051FD0")]
		private void ApplyToLinkedOptions(string newValueString)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x3052150", Offset = "0x3050750", VA = "0x183052150")]
		public void SetLinkedOptions(List<CustomMenuOptionGui> linkedOptions)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public QualityPresetOptionGui()
		{
		}

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0xA8")]
		private List<CustomMenuOptionGui> _linkedQualityOptions;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0xB0")]
		private bool _applyingToLinked;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		private const string LabelText = "Quality Preset";
	}
}
