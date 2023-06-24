using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	[Serializable]
	public class Finger
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00002CCC File Offset: 0x00000ECC
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000015")]
		public bool initiated
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x998EF0", Offset = "0x9974F0", VA = "0x180998EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00002CE4 File Offset: 0x00000EE4
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x28F9B90", Offset = "0x28F8190", VA = "0x1828F9B90")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x28F9BC0", Offset = "0x28F81C0", VA = "0x1828F9BC0")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00002CFC File Offset: 0x00000EFC
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x28F9BF0", Offset = "0x28F81F0", VA = "0x1828F9BF0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x28F9C20", Offset = "0x28F8220", VA = "0x1828F9C20")]
			set
			{
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x28F9C40", Offset = "0x28F8240", VA = "0x1828F9C40")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x28F9EA0", Offset = "0x28F84A0", VA = "0x1828F9EA0")]
		public void Initiate(Transform hand, int index)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x28FAC40", Offset = "0x28F9240", VA = "0x1828FAC40")]
		public void FixTransforms()
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x28FAE00", Offset = "0x28F9400", VA = "0x1828FAE00")]
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x28FAFC0", Offset = "0x28F95C0", VA = "0x1828FAFC0")]
		public void Update(float masterWeight)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x28FBEC0", Offset = "0x28FA4C0", VA = "0x1828FBEC0")]
		public Finger()
		{
		}

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		[Tooltip("Master Weight for the finger.")]
		public float weight;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		public float rotationWeight;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public Finger.DOF rotationDOF;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		[Serializable]
		public enum DOF
		{
			// Token: 0x04000120 RID: 288
			[Token(Token = "0x4000120")]
			One,
			// Token: 0x04000121 RID: 289
			[Token(Token = "0x4000121")]
			Three
		}
	}
}
