using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.StatSystem
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[Serializable]
	public class CleanStat : Stat
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x3145110", Offset = "0x3143710", VA = "0x183145110", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x3145140", Offset = "0x3143740", VA = "0x183145140", Slot = "7")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x3145170", Offset = "0x3143770", VA = "0x183145170", Slot = "5")]
		public override string EditorGuiIconPath()
		{
			return null;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x31451A0", Offset = "0x31437A0", VA = "0x1831451A0")]
		public CleanStat()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x3145220", Offset = "0x3143820", VA = "0x183145220", Slot = "8")]
		public override void OnValidate()
		{
		}

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color GUIColor;
	}
}
