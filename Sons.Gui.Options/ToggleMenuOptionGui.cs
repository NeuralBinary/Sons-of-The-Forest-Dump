using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[Serializable]
	public abstract class ToggleMenuOptionGui : CustomMenuOptionGui
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x17000073")]
		public bool IsOn
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x2739860", Offset = "0x2737E60", VA = "0x182739860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x17000074")]
		public bool IsOff
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x3050C20", Offset = "0x304F220", VA = "0x183050C20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x3050C30", Offset = "0x304F230", VA = "0x183050C30", Slot = "4")]
		public override void OnValidate()
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x3050DE0", Offset = "0x304F3E0", VA = "0x183050DE0", Slot = "30")]
		public override string GetCurrentValue()
		{
			return null;
		}

		// Token: 0x06000270 RID: 624
		[Token(Token = "0x6000270")]
		public abstract bool GetDefaultBoolValue();

		// Token: 0x06000271 RID: 625 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x3050EF0", Offset = "0x304F4F0", VA = "0x183050EF0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x3050F50", Offset = "0x304F550", VA = "0x183050F50", Slot = "43")]
		public override void ValueChanged(int newValue)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x3051000", Offset = "0x304F600", VA = "0x183051000", Slot = "16")]
		public override void RevertCachedChanges()
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x3051010", Offset = "0x304F610", VA = "0x183051010", Slot = "6")]
		public override bool ApplyCachedChanges()
		{
			return default(bool);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x30510D0", Offset = "0x304F6D0", VA = "0x1830510D0", Slot = "17")]
		public override bool HasCachedChanges()
		{
			return default(bool);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x3051110", Offset = "0x304F710", VA = "0x183051110")]
		protected ToggleMenuOptionGui()
		{
		}

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly List<string> OffOnOption;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0xA8")]
		private bool? _cachedBoolValue;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0xAA")]
		private bool _isOn;
	}
}
