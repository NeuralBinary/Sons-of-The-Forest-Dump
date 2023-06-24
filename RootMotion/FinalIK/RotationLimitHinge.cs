using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitHinge : RotationLimit
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2989050", Offset = "0x2987650", VA = "0x182989050")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x29890E0", Offset = "0x29876E0", VA = "0x1829890E0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x2989170", Offset = "0x2987770", VA = "0x182989170")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x2989200", Offset = "0x2987800", VA = "0x182989200")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0000425C File Offset: 0x0000245C
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x2989290", Offset = "0x2987890", VA = "0x182989290", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00004274 File Offset: 0x00002474
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x29892E0", Offset = "0x29878E0", VA = "0x1829892E0")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x29896F0", Offset = "0x2987CF0", VA = "0x1829896F0")]
		public RotationLimitHinge()
		{
		}

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x40")]
		public bool useLimits;

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x44")]
		public float min;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x48")]
		public float max;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0x4C")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion lastRotation;

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x60")]
		private float lastAngle;
	}
}
