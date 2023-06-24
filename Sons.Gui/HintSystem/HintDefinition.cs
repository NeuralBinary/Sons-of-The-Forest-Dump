using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Localization;

namespace Sons.Gui.HintSystem
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[Serializable]
	public class HintDefinition
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x305F290", Offset = "0x305D890", VA = "0x18305F290")]
		public string GetHintString()
		{
			return null;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public HintDefinition()
		{
		}

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		public const string NullLocalizationString = "NULL LOCALIZATION";

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _perInputScheme;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LocalizedString _localizedHint;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LocalizedString _localizedHintKeyboard;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LocalizedString _localizedHintGamepad;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _hintString;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x38")]
		private bool _shown;
	}
}
