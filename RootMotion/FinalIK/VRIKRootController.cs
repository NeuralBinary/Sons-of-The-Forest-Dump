using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	public class VRIKRootController : MonoBehaviour
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0000467C File Offset: 0x0000287C
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B4")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x29A0830", Offset = "0x299EE30", VA = "0x1829A0830")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x29A0850", Offset = "0x299EE50", VA = "0x1829A0850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x29A0860", Offset = "0x299EE60", VA = "0x1829A0860")]
		private void Awake()
		{
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x29A0A20", Offset = "0x299F020", VA = "0x1829A0A20")]
		public void Calibrate()
		{
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x29A0EF0", Offset = "0x299F4F0", VA = "0x1829A0EF0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x29A1280", Offset = "0x299F880", VA = "0x1829A1280")]
		private void OnPreUpdate()
		{
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x29A1DF0", Offset = "0x29A03F0", VA = "0x1829A1DF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VRIKRootController()
		{
		}

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0x30")]
		private Transform pelvisTarget;

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x38")]
		private Transform leftFootTarget;

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0x40")]
		private Transform rightFootTarget;

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0x48")]
		private VRIK ik;
	}
}
