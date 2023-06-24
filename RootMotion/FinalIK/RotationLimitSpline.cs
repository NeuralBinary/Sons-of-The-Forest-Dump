using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		// Token: 0x060005AC RID: 1452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x298C790", Offset = "0x298AD90", VA = "0x18298C790")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x298C820", Offset = "0x298AE20", VA = "0x18298C820")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x298C8B0", Offset = "0x298AEB0", VA = "0x18298C8B0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x298C940", Offset = "0x298AF40", VA = "0x18298C940")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x298C9D0", Offset = "0x298AFD0", VA = "0x18298C9D0")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00004394 File Offset: 0x00002594
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x298CA40", Offset = "0x298B040", VA = "0x18298CA40", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000043AC File Offset: 0x000025AC
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x298CAF0", Offset = "0x298B0F0", VA = "0x18298CAF0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x298D020", Offset = "0x298B620", VA = "0x18298D020")]
		public RotationLimitSpline()
		{
		}

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 180f)]
		public float twistLimit;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		public AnimationCurve spline;
	}
}
