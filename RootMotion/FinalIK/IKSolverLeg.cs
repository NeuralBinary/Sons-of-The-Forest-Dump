using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	[Serializable]
	public class IKSolverLeg : IKSolver
	{
		// Token: 0x060003A9 RID: 937 RVA: 0x0000380C File Offset: 0x00001A0C
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2946A40", Offset = "0x2945040", VA = "0x182946A40", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00003824 File Offset: 0x00001A24
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2933EF0", Offset = "0x29324F0", VA = "0x182933EF0")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x29470E0", Offset = "0x29456E0", VA = "0x1829470E0", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2947290", Offset = "0x2945890", VA = "0x182947290", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2934790", Offset = "0x2932D90", VA = "0x182934790", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x29347F0", Offset = "0x2932DF0", VA = "0x1829347F0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2947760", Offset = "0x2945D60", VA = "0x182947760", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2947880", Offset = "0x2945E80", VA = "0x182947880", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x2947990", Offset = "0x2945F90", VA = "0x182947990")]
		private void Solve()
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x2947A90", Offset = "0x2946090", VA = "0x182947A90")]
		private void Read()
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x29482C0", Offset = "0x29468C0", VA = "0x1829482C0")]
		private void Write()
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2948660", Offset = "0x2946C60", VA = "0x182948660")]
		public IKSolverLeg()
		{
		}

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x70")]
		public IKSolver.Point pelvis;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x78")]
		public IKSolver.Point thigh;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x80")]
		public IKSolver.Point calf;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x88")]
		public IKSolver.Point foot;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x90")]
		public IKSolver.Point toe;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;
	}
}
