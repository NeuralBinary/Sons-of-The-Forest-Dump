using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[Serializable]
	public class Ragdoll : ActionTemplate
	{
		// Token: 0x0600008A RID: 138 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2B87C30", Offset = "0x2B86230", VA = "0x182B87C30", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2D1F700", Offset = "0x2D1DD00", VA = "0x182D1F700", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2BC0FA0", Offset = "0x2BBF5A0", VA = "0x182BC0FA0")]
		public Ragdoll()
		{
		}

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _setValue;
	}
}
