using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[Serializable]
	public class SetAttention : ActionTemplate
	{
		// Token: 0x0600008D RID: 141 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2B87C30", Offset = "0x2B86230", VA = "0x182B87C30", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2D1F760", Offset = "0x2D1DD60", VA = "0x182D1F760", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2BC0FA0", Offset = "0x2BBF5A0", VA = "0x182BC0FA0")]
		public SetAttention()
		{
		}

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Frequency _frequency;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Expression _expression;
	}
}
