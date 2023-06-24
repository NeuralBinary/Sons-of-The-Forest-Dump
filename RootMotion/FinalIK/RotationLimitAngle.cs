using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		// Token: 0x06000586 RID: 1414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x2988A00", Offset = "0x2987000", VA = "0x182988A00")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x2988A90", Offset = "0x2987090", VA = "0x182988A90")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x2988B20", Offset = "0x2987120", VA = "0x182988B20")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x2988BB0", Offset = "0x29871B0", VA = "0x182988BB0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000422C File Offset: 0x0000242C
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x2988C40", Offset = "0x2987240", VA = "0x182988C40", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00004244 File Offset: 0x00002444
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2988CF0", Offset = "0x29872F0", VA = "0x182988CF0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x2989030", Offset = "0x2987630", VA = "0x182989030")]
		public RotationLimitAngle()
		{
		}

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 180f)]
		public float limit;

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 180f)]
		public float twistLimit;
	}
}
