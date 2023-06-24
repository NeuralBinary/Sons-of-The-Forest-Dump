using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.StatSystem
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[Serializable]
	public class FearStat : Stat
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x3145460", Offset = "0x3143A60", VA = "0x183145460", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x3145490", Offset = "0x3143A90", VA = "0x183145490", Slot = "7")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x31454C0", Offset = "0x3143AC0", VA = "0x1831454C0", Slot = "5")]
		public override string EditorGuiIconPath()
		{
			return null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x31454F0", Offset = "0x3143AF0", VA = "0x1831454F0")]
		public FearStat()
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x3145570", Offset = "0x3143B70", VA = "0x183145570", Slot = "8")]
		public override void OnValidate()
		{
		}

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color GUIColor;
	}
}
