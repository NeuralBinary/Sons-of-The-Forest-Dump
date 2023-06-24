using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.StatSystem
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[Serializable]
	public class BloodAlcoholStat : Stat
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x3144FF0", Offset = "0x31435F0", VA = "0x183144FF0", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x3145020", Offset = "0x3143620", VA = "0x183145020", Slot = "7")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x3145050", Offset = "0x3143650", VA = "0x183145050")]
		public BloodAlcoholStat()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x3145070", Offset = "0x3143670", VA = "0x183145070")]
		public static Color GUIColor()
		{
			return default(Color);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x3145090", Offset = "0x3143690", VA = "0x183145090", Slot = "8")]
		public override void OnValidate()
		{
		}
	}
}
