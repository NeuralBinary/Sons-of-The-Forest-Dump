using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	[Serializable]
	public class IKSolverLookAt : IKSolver
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x292EFE0", Offset = "0x292D5E0", VA = "0x18292EFE0")]
		public void SetLookAtWeight(float weight)
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x294B380", Offset = "0x2949980", VA = "0x18294B380")]
		public void SetLookAtWeight(float weight, float inBodyWeight)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x294B3C0", Offset = "0x29499C0", VA = "0x18294B3C0")]
		public void SetLookAtWeight(float weight, float inBodyWeight, float inHeadWeight)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x294B420", Offset = "0x2949A20", VA = "0x18294B420")]
		public void SetLookAtWeight(float weight, float inBodyWeight, float inHeadWeight, float inEyesWeight)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x294B4A0", Offset = "0x2949AA0", VA = "0x18294B4A0")]
		public void SetLookAtWeight(float weight, float inBodyWeight, float inHeadWeight, float inEyesWeight, float inClampWeight)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x294B550", Offset = "0x2949B50", VA = "0x18294B550")]
		public void SetLookAtWeight(float weight, float inBodyWeight, float inHeadWeight, float inEyesWeight, float inClampWeight, float inClampWeightHead, float inClampWeightEyes)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x294B630", Offset = "0x2949C30", VA = "0x18294B630", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x294B7E0", Offset = "0x2949DE0", VA = "0x18294B7E0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00003854 File Offset: 0x00001A54
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x294B9A0", Offset = "0x2949FA0", VA = "0x18294B9A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x294BEC0", Offset = "0x294A4C0", VA = "0x18294BEC0", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x294C410", Offset = "0x294AA10", VA = "0x18294C410", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000386C File Offset: 0x00001A6C
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x294C790", Offset = "0x294AD90", VA = "0x18294C790")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x294C880", Offset = "0x294AE80", VA = "0x18294C880", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x294CEA0", Offset = "0x294B4A0", VA = "0x18294CEA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00003884 File Offset: 0x00001A84
		[Token(Token = "0x1700005A")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x294D020", Offset = "0x294B620", VA = "0x18294D020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0000389C File Offset: 0x00001A9C
		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x294D170", Offset = "0x294B770", VA = "0x18294D170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x294D190", Offset = "0x294B790", VA = "0x18294D190")]
		protected void SolveSpine()
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x000038B4 File Offset: 0x00001AB4
		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x294D4A0", Offset = "0x294BAA0", VA = "0x18294D4A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x000038CC File Offset: 0x00001ACC
		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x294D4B0", Offset = "0x294BAB0", VA = "0x18294D4B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x294D580", Offset = "0x294BB80", VA = "0x18294D580")]
		protected void SolveHead()
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000038E4 File Offset: 0x00001AE4
		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x294D9F0", Offset = "0x294BFF0", VA = "0x18294D9F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x000038FC File Offset: 0x00001AFC
		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x294DB40", Offset = "0x294C140", VA = "0x18294DB40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x294DB60", Offset = "0x294C160", VA = "0x18294DB60")]
		protected void SolveEyes()
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x294E250", Offset = "0x294C850", VA = "0x18294E250")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x294E640", Offset = "0x294CC40", VA = "0x18294E640")]
		protected void SetBones(Transform[] array, ref IKSolverLookAt.LookAtBone[] bones)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x294E8C0", Offset = "0x294CEC0", VA = "0x18294E8C0")]
		public IKSolverLookAt()
		{
		}

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x58")]
		public Transform target;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x60")]
		public IKSolverLookAt.LookAtBone[] spine;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x68")]
		public IKSolverLookAt.LookAtBone head;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x70")]
		public IKSolverLookAt.LookAtBone[] eyes;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		// Token: 0x02000073 RID: 115
		[Token(Token = "0x2000073")]
		[Serializable]
		public class LookAtBone : IKSolver.Bone
		{
			// Token: 0x060003DA RID: 986 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x294ED20", Offset = "0x294D320", VA = "0x18294ED20")]
			public LookAtBone()
			{
			}

			// Token: 0x060003DB RID: 987 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x294ED30", Offset = "0x294D330", VA = "0x18294ED30")]
			public LookAtBone(Transform transform)
			{
			}

			// Token: 0x060003DC RID: 988 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x294EDA0", Offset = "0x294D3A0", VA = "0x18294EDA0")]
			public void Initiate(Transform root)
			{
			}

			// Token: 0x060003DD RID: 989 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x294EF90", Offset = "0x294D590", VA = "0x18294EF90")]
			public void LookAt(Vector3 direction, float weight)
			{
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x060003DE RID: 990 RVA: 0x00003914 File Offset: 0x00001B14
			[Token(Token = "0x17000060")]
			public Vector3 forward
			{
				[Token(Token = "0x60003DE")]
				[Address(RVA = "0x294F2F0", Offset = "0x294D8F0", VA = "0x18294F2F0")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x04000331 RID: 817
			[Token(Token = "0x4000331")]
			[FieldOffset(Offset = "0x80")]
			public Vector3 baseForwardOffsetEuler;
		}
	}
}
