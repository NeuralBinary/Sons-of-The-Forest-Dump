using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	[Serializable]
	public class IKSolverTrigonometric : IKSolver
	{
		// Token: 0x060003DF RID: 991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x294F3C0", Offset = "0x294D9C0", VA = "0x18294F3C0")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x294F710", Offset = "0x294DD10", VA = "0x18294F710")]
		public void SetBendPlaneToCurrent()
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x294FA60", Offset = "0x294E060", VA = "0x18294FA60")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x294FA70", Offset = "0x294E070", VA = "0x18294FA70")]
		public void SetIKRotationWeight(float weight)
		{
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000392C File Offset: 0x00001B2C
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x294FAA0", Offset = "0x294E0A0", VA = "0x18294FAA0")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00003944 File Offset: 0x00001B44
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
		public float GetIKRotationWeight()
		{
			return 0f;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x294FAB0", Offset = "0x294E0B0", VA = "0x18294FAB0", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x294FBE0", Offset = "0x294E1E0", VA = "0x18294FBE0", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x294FEF0", Offset = "0x294E4F0", VA = "0x18294FEF0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x294FF40", Offset = "0x294E540", VA = "0x18294FF40", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000395C File Offset: 0x00001B5C
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x294FFA0", Offset = "0x294E5A0", VA = "0x18294FFA0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00003974 File Offset: 0x00001B74
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x29506E0", Offset = "0x294ECE0", VA = "0x1829506E0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2950840", Offset = "0x294EE40", VA = "0x182950840")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000398C File Offset: 0x00001B8C
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x2951340", Offset = "0x294F940", VA = "0x182951340")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x29515D0", Offset = "0x294FBD0", VA = "0x1829515D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000039A4 File Offset: 0x00001BA4
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2951950", Offset = "0x294FF50", VA = "0x182951950")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2951C30", Offset = "0x2950230", VA = "0x182951C30")]
		private void InitiateBones()
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x2951DE0", Offset = "0x29503E0", VA = "0x182951DE0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000039BC File Offset: 0x00001BBC
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2952D10", Offset = "0x2951310", VA = "0x182952D10")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x2953170", Offset = "0x2951770", VA = "0x182953170")]
		public IKSolverTrigonometric()
		{
		}

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x58")]
		public Transform target;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x80")]
		public IKSolverTrigonometric.TrigonometricBone bone1;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x88")]
		public IKSolverTrigonometric.TrigonometricBone bone2;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x90")]
		public IKSolverTrigonometric.TrigonometricBone bone3;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		// Token: 0x02000075 RID: 117
		[Token(Token = "0x2000075")]
		[Serializable]
		public class TrigonometricBone : IKSolver.Bone
		{
			// Token: 0x060003F6 RID: 1014 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x2953380", Offset = "0x2951980", VA = "0x182953380")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x000039D4 File Offset: 0x00001BD4
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x2953650", Offset = "0x2951C50", VA = "0x182953650")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x000039EC File Offset: 0x00001BEC
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x2953870", Offset = "0x2951E70", VA = "0x182953870")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x294ED20", Offset = "0x294D320", VA = "0x18294ED20")]
			public TrigonometricBone()
			{
			}

			// Token: 0x0400033B RID: 827
			[Token(Token = "0x400033B")]
			[FieldOffset(Offset = "0x80")]
			private Quaternion targetToLocalSpace;

			// Token: 0x0400033C RID: 828
			[Token(Token = "0x400033C")]
			[FieldOffset(Offset = "0x90")]
			private Vector3 defaultLocalBendNormal;
		}
	}
}
