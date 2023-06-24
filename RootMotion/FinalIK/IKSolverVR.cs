using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace RootMotion.FinalIK
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	[Serializable]
	public class IKSolverVR : IKSolver
	{
		// Token: 0x060003FA RID: 1018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2953940", Offset = "0x2951F40", VA = "0x182953940")]
		public void SetToReferences(VRIK.References references)
		{
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2953FD0", Offset = "0x29525D0", VA = "0x182953FD0")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2954420", Offset = "0x2952A20", VA = "0x182954420")]
		public void DefaultAnimationCurves()
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x29547D0", Offset = "0x2952DD0", VA = "0x1829547D0")]
		public void AddPositionOffset(IKSolverVR.PositionOffset positionOffset, Vector3 value)
		{
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2954AD0", Offset = "0x29530D0", VA = "0x182954AD0")]
		public void AddRotationOffset(IKSolverVR.RotationOffset rotationOffset, Vector3 value)
		{
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2954BB0", Offset = "0x29531B0", VA = "0x182954BB0")]
		public void AddRotationOffset(IKSolverVR.RotationOffset rotationOffset, Quaternion value)
		{
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2954CB0", Offset = "0x29532B0", VA = "0x182954CB0")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2954F80", Offset = "0x2953580", VA = "0x182954F80")]
		public void Reset()
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2955110", Offset = "0x2953710", VA = "0x182955110", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2955390", Offset = "0x2953990", VA = "0x182955390", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2955660", Offset = "0x2953C60", VA = "0x182955660", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x29556C0", Offset = "0x2953CC0", VA = "0x1829556C0", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00003A04 File Offset: 0x00001C04
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2955720", Offset = "0x2953D20", VA = "0x182955720", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00003A1C File Offset: 0x00001C1C
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2955AA0", Offset = "0x29540A0", VA = "0x182955AA0")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00003A34 File Offset: 0x00001C34
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2955F70", Offset = "0x2954570", VA = "0x182955F70")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00003A4C File Offset: 0x00001C4C
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x29561E0", Offset = "0x29547E0", VA = "0x1829561E0")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2956990", Offset = "0x2954F90", VA = "0x182956990")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2956A20", Offset = "0x2955020", VA = "0x182956A20")]
		private void UpdateSolverTransforms()
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2956C90", Offset = "0x2955290", VA = "0x182956C90", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2956CF0", Offset = "0x29552F0", VA = "0x182956CF0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2957600", Offset = "0x2955C00", VA = "0x182957600")]
		private void WriteTransforms()
		{
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2957F90", Offset = "0x2956590", VA = "0x182957F90")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2958A50", Offset = "0x2957050", VA = "0x182958A50")]
		private void Solve()
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00003A64 File Offset: 0x00001C64
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x295A580", Offset = "0x2958B80", VA = "0x18295A580")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00003A7C File Offset: 0x00001C7C
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x295A5D0", Offset = "0x2958BD0", VA = "0x18295A5D0")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000061")]
		[HideInInspector]
		public IKSolverVR.VirtualBone rootBone
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x784A40", Offset = "0x783040", VA = "0x180784A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x295A610", Offset = "0x2958C10", VA = "0x18295A610")]
		private void Write()
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00003A94 File Offset: 0x00001C94
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x295A790", Offset = "0x2958D90", VA = "0x18295A790")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x295B190", Offset = "0x2959790", VA = "0x18295B190")]
		public IKSolverVR()
		{
		}

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x60")]
		private bool hasChest;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x63")]
		private bool hasToes;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0xC4")]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		[Range(0f, 2f)]
		public int LOD;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0xC8")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0xD8")]
		[Tooltip("The spine solver.")]
		public IKSolverVR.Spine spine;

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0xE0")]
		[Tooltip("The left arm solver.")]
		public IKSolverVR.Arm leftArm;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0xE8")]
		[Tooltip("The right arm solver.")]
		public IKSolverVR.Arm rightArm;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0xF0")]
		[Tooltip("The left leg solver.")]
		public IKSolverVR.Leg leftLeg;

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0xF8")]
		[Tooltip("The right leg solver.")]
		public IKSolverVR.Leg rightLeg;

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x100")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public IKSolverVR.Locomotion locomotion;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x108")]
		private IKSolverVR.Leg[] legs;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x110")]
		private IKSolverVR.Arm[] arms;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		// Token: 0x02000077 RID: 119
		[Token(Token = "0x2000077")]
		[Serializable]
		public class Arm : IKSolverVR.BodyPart
		{
			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000418 RID: 1048 RVA: 0x00003AAC File Offset: 0x00001CAC
			// (set) Token: 0x06000419 RID: 1049 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000062")]
			public Vector3 position
			{
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x295B840", Offset = "0x2959E40", VA = "0x18295B840")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000419")]
				[Address(RVA = "0x295B860", Offset = "0x2959E60", VA = "0x18295B860")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600041A RID: 1050 RVA: 0x00003AC4 File Offset: 0x00001CC4
			// (set) Token: 0x0600041B RID: 1051 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x600041A")]
				[Address(RVA = "0x295B880", Offset = "0x2959E80", VA = "0x18295B880")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600041B")]
				[Address(RVA = "0x295B890", Offset = "0x2959E90", VA = "0x18295B890")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600041C RID: 1052 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x17000064")]
			private IKSolverVR.VirtualBone shoulder
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x295B8A0", Offset = "0x2959EA0", VA = "0x18295B8A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600041D RID: 1053 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x17000065")]
			private IKSolverVR.VirtualBone upperArm
			{
				[Token(Token = "0x600041D")]
				[Address(RVA = "0x295B8D0", Offset = "0x2959ED0", VA = "0x18295B8D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x0600041E RID: 1054 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x17000066")]
			private IKSolverVR.VirtualBone forearm
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0x295B920", Offset = "0x2959F20", VA = "0x18295B920")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x0600041F RID: 1055 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x17000067")]
			private IKSolverVR.VirtualBone hand
			{
				[Token(Token = "0x600041F")]
				[Address(RVA = "0x295B970", Offset = "0x2959F70", VA = "0x18295B970")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x295B9C0", Offset = "0x2959FC0", VA = "0x18295B9C0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x295C660", Offset = "0x295AC60", VA = "0x18295C660", Slot = "5")]
			public override void PreSolve()
			{
			}

			// Token: 0x06000422 RID: 1058 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x295CC90", Offset = "0x295B290", VA = "0x18295CC90", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x295CD00", Offset = "0x295B300", VA = "0x18295CD00")]
			private void Stretching()
			{
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x295D370", Offset = "0x295B970", VA = "0x18295D370")]
			public void Solve(bool isLeft)
			{
			}

			// Token: 0x06000425 RID: 1061 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x295F8F0", Offset = "0x295DEF0", VA = "0x18295F8F0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			// Token: 0x06000426 RID: 1062 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x295F940", Offset = "0x295DF40", VA = "0x18295F940", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x00003ADC File Offset: 0x00001CDC
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x295FCD0", Offset = "0x295E2D0", VA = "0x18295FCD0")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return 0f;
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x00003AF4 File Offset: 0x00001CF4
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x295FDA0", Offset = "0x295E3A0", VA = "0x18295FDA0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x29606E0", Offset = "0x295ECE0", VA = "0x1829606E0")]
			private void Visualize(IKSolverVR.VirtualBone bone1, IKSolverVR.VirtualBone bone2, IKSolverVR.VirtualBone bone3, Color color)
			{
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x2960970", Offset = "0x295EF70", VA = "0x182960970")]
			public Arm()
			{
			}

			// Token: 0x04000361 RID: 865
			[Token(Token = "0x4000361")]
			[FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			// Token: 0x04000362 RID: 866
			[Token(Token = "0x4000362")]
			[FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			// Token: 0x04000363 RID: 867
			[Token(Token = "0x4000363")]
			[FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight;

			// Token: 0x04000364 RID: 868
			[Token(Token = "0x4000364")]
			[FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			// Token: 0x04000365 RID: 869
			[Token(Token = "0x4000365")]
			[FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public IKSolverVR.Arm.ShoulderRotationMode shoulderRotationMode;

			// Token: 0x04000366 RID: 870
			[Token(Token = "0x4000366")]
			[FieldOffset(Offset = "0x64")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			// Token: 0x04000367 RID: 871
			[Token(Token = "0x4000367")]
			[FieldOffset(Offset = "0x68")]
			[Range(0f, 1f)]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			public float shoulderTwistWeight;

			// Token: 0x04000368 RID: 872
			[Token(Token = "0x4000368")]
			[FieldOffset(Offset = "0x6C")]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			// Token: 0x04000369 RID: 873
			[Token(Token = "0x4000369")]
			[FieldOffset(Offset = "0x70")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the elbow bending direction.")]
			public float swivelOffset;

			// Token: 0x0400036A RID: 874
			[Token(Token = "0x400036A")]
			[FieldOffset(Offset = "0x74")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			// Token: 0x0400036B RID: 875
			[Token(Token = "0x400036B")]
			[FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			// Token: 0x0400036C RID: 876
			[Token(Token = "0x400036C")]
			[FieldOffset(Offset = "0x8C")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			public float armLengthMlp;

			// Token: 0x0400036D RID: 877
			[Token(Token = "0x400036D")]
			[FieldOffset(Offset = "0x90")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			// Token: 0x0400036E RID: 878
			[Token(Token = "0x400036E")]
			[FieldOffset(Offset = "0x98")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 IKPosition;

			// Token: 0x0400036F RID: 879
			[Token(Token = "0x400036F")]
			[FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			[NonSerialized]
			public Quaternion IKRotation;

			// Token: 0x04000370 RID: 880
			[Token(Token = "0x4000370")]
			[FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 bendDirection;

			// Token: 0x04000371 RID: 881
			[Token(Token = "0x4000371")]
			[FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 handPositionOffset;

			// Token: 0x04000374 RID: 884
			[Token(Token = "0x4000374")]
			[FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			// Token: 0x04000375 RID: 885
			[Token(Token = "0x4000375")]
			[FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			// Token: 0x04000376 RID: 886
			[Token(Token = "0x4000376")]
			[FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			// Token: 0x04000377 RID: 887
			[Token(Token = "0x4000377")]
			[FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			// Token: 0x04000378 RID: 888
			[Token(Token = "0x4000378")]
			[FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			// Token: 0x04000379 RID: 889
			[Token(Token = "0x4000379")]
			[FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			// Token: 0x0400037A RID: 890
			[Token(Token = "0x400037A")]
			[FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			// Token: 0x0400037B RID: 891
			[Token(Token = "0x400037B")]
			[FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			// Token: 0x0400037C RID: 892
			[Token(Token = "0x400037C")]
			private const float yawOffsetAngle = 45f;

			// Token: 0x0400037D RID: 893
			[Token(Token = "0x400037D")]
			private const float pitchOffsetAngle = -30f;

			// Token: 0x02000078 RID: 120
			[Token(Token = "0x2000078")]
			[Serializable]
			public enum ShoulderRotationMode
			{
				// Token: 0x0400037F RID: 895
				[Token(Token = "0x400037F")]
				YawPitch,
				// Token: 0x04000380 RID: 896
				[Token(Token = "0x4000380")]
				FromTo
			}
		}

		// Token: 0x02000079 RID: 121
		[Token(Token = "0x2000079")]
		[Serializable]
		public abstract class BodyPart
		{
			// Token: 0x0600042B RID: 1067
			[Token(Token = "0x600042B")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			// Token: 0x0600042C RID: 1068
			[Token(Token = "0x600042C")]
			public abstract void PreSolve();

			// Token: 0x0600042D RID: 1069
			[Token(Token = "0x600042D")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			// Token: 0x0600042E RID: 1070
			[Token(Token = "0x600042E")]
			public abstract void ApplyOffsets();

			// Token: 0x0600042F RID: 1071
			[Token(Token = "0x600042F")]
			public abstract void ResetOffsets();

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000430 RID: 1072 RVA: 0x00003B0C File Offset: 0x00001D0C
			// (set) Token: 0x06000431 RID: 1073 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000068")]
			public float sqrMag
			{
				[Token(Token = "0x6000430")]
				[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000431")]
				[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000432 RID: 1074 RVA: 0x00003B24 File Offset: 0x00001D24
			// (set) Token: 0x06000433 RID: 1075 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000432")]
				[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000433")]
				[Address(RVA = "0xA308B0", Offset = "0xA2EEB0", VA = "0x180A308B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000434 RID: 1076 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x2960BE0", Offset = "0x295F1E0", VA = "0x182960BE0")]
			public void SetLOD(int LOD)
			{
			}

			// Token: 0x06000435 RID: 1077 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x2960BF0", Offset = "0x295F1F0", VA = "0x182960BF0")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			// Token: 0x06000436 RID: 1078 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x2960CF0", Offset = "0x295F2F0", VA = "0x182960CF0")]
			public void MovePosition(Vector3 position)
			{
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x2960DC0", Offset = "0x295F3C0", VA = "0x182960DC0")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x2960E70", Offset = "0x295F470", VA = "0x182960E70")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x2960F50", Offset = "0x295F550", VA = "0x182960F50")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x29612F0", Offset = "0x295F8F0", VA = "0x1829612F0")]
			public void RotateTo(IKSolverVR.VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x29614A0", Offset = "0x295FAA0", VA = "0x1829614A0")]
			public void Visualize(Color color)
			{
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x29616B0", Offset = "0x295FCB0", VA = "0x1829616B0")]
			public void Visualize()
			{
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x29618C0", Offset = "0x295FEC0", VA = "0x1829618C0")]
			protected BodyPart()
			{
			}

			// Token: 0x04000383 RID: 899
			[Token(Token = "0x4000383")]
			[FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public IKSolverVR.VirtualBone[] bones;

			// Token: 0x04000384 RID: 900
			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x20")]
			protected bool initiated;

			// Token: 0x04000385 RID: 901
			[Token(Token = "0x4000385")]
			[FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			// Token: 0x04000386 RID: 902
			[Token(Token = "0x4000386")]
			[FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			// Token: 0x04000387 RID: 903
			[Token(Token = "0x4000387")]
			[FieldOffset(Offset = "0x40")]
			protected int index;

			// Token: 0x04000388 RID: 904
			[Token(Token = "0x4000388")]
			[FieldOffset(Offset = "0x44")]
			protected int LOD;
		}

		// Token: 0x0200007A RID: 122
		[Token(Token = "0x200007A")]
		[Serializable]
		public class Footstep
		{
			// Token: 0x1700006A RID: 106
			// (get) Token: 0x0600043E RID: 1086 RVA: 0x00003B3C File Offset: 0x00001D3C
			[Token(Token = "0x1700006A")]
			public bool isStepping
			{
				[Token(Token = "0x600043E")]
				[Address(RVA = "0x2961990", Offset = "0x295FF90", VA = "0x182961990")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x0600043F RID: 1087 RVA: 0x00003B54 File Offset: 0x00001D54
			// (set) Token: 0x06000440 RID: 1088 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x600043F")]
				[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000440")]
				[Address(RVA = "0x290B500", Offset = "0x2909B00", VA = "0x18290B500")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x29619A0", Offset = "0x295FFA0", VA = "0x1829619A0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			// Token: 0x06000442 RID: 1090 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x2961D10", Offset = "0x2960310", VA = "0x182961D10")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			// Token: 0x06000443 RID: 1091 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x2961D60", Offset = "0x2960360", VA = "0x182961D60")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			// Token: 0x06000444 RID: 1092 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x2962040", Offset = "0x2960640", VA = "0x182962040")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			// Token: 0x06000445 RID: 1093 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x2962500", Offset = "0x2960B00", VA = "0x182962500")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x2962690", Offset = "0x2960C90", VA = "0x182962690")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}

			// Token: 0x04000389 RID: 905
			[Token(Token = "0x4000389")]
			[FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			// Token: 0x0400038A RID: 906
			[Token(Token = "0x400038A")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			// Token: 0x0400038B RID: 907
			[Token(Token = "0x400038B")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 position;

			// Token: 0x0400038C RID: 908
			[Token(Token = "0x400038C")]
			[FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			// Token: 0x0400038D RID: 909
			[Token(Token = "0x400038D")]
			[FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			// Token: 0x0400038E RID: 910
			[Token(Token = "0x400038E")]
			[FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			// Token: 0x04000390 RID: 912
			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			// Token: 0x04000391 RID: 913
			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			// Token: 0x04000392 RID: 914
			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			// Token: 0x04000393 RID: 915
			[Token(Token = "0x4000393")]
			[FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			// Token: 0x04000394 RID: 916
			[Token(Token = "0x4000394")]
			[FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			// Token: 0x04000395 RID: 917
			[Token(Token = "0x4000395")]
			[FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			// Token: 0x04000396 RID: 918
			[Token(Token = "0x4000396")]
			[FieldOffset(Offset = "0xA0")]
			private float supportLegWV;
		}

		// Token: 0x0200007B RID: 123
		[Token(Token = "0x200007B")]
		[Serializable]
		public class Leg : IKSolverVR.BodyPart
		{
			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000447 RID: 1095 RVA: 0x00003B6C File Offset: 0x00001D6C
			// (set) Token: 0x06000448 RID: 1096 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700006C")]
			public Vector3 position
			{
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x623610", Offset = "0x621C10", VA = "0x180623610")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000448")]
				[Address(RVA = "0x29628F0", Offset = "0x2960EF0", VA = "0x1829628F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000449 RID: 1097 RVA: 0x00003B84 File Offset: 0x00001D84
			// (set) Token: 0x0600044A RID: 1098 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000449")]
				[Address(RVA = "0x2962910", Offset = "0x2960F10", VA = "0x182962910")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600044A")]
				[Address(RVA = "0x2962920", Offset = "0x2960F20", VA = "0x182962920")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x0600044B RID: 1099 RVA: 0x00003B9C File Offset: 0x00001D9C
			// (set) Token: 0x0600044C RID: 1100 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x600044B")]
				[Address(RVA = "0xA03DD0", Offset = "0xA023D0", VA = "0x180A03DD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x2962930", Offset = "0x2960F30", VA = "0x182962930")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x0600044D RID: 1101 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x1700006F")]
			public IKSolverVR.VirtualBone thigh
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x295B8A0", Offset = "0x2959EA0", VA = "0x18295B8A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x0600044E RID: 1102 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x17000070")]
			private IKSolverVR.VirtualBone calf
			{
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x2962940", Offset = "0x2960F40", VA = "0x182962940")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600044F RID: 1103 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x17000071")]
			private IKSolverVR.VirtualBone foot
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x2962970", Offset = "0x2960F70", VA = "0x182962970")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x06000450 RID: 1104 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x17000072")]
			private IKSolverVR.VirtualBone toes
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x29629A0", Offset = "0x2960FA0", VA = "0x1829629A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x06000451 RID: 1105 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x17000073")]
			public IKSolverVR.VirtualBone lastBone
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x29629D0", Offset = "0x2960FD0", VA = "0x1829629D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x06000452 RID: 1106 RVA: 0x00003BB4 File Offset: 0x00001DB4
			// (set) Token: 0x06000453 RID: 1107 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x2942AF0", Offset = "0x29410F0", VA = "0x182942AF0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000453")]
				[Address(RVA = "0x2942B10", Offset = "0x2941110", VA = "0x182942B10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000454 RID: 1108 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x2962A00", Offset = "0x2961000", VA = "0x182962A00", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			// Token: 0x06000455 RID: 1109 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x2963440", Offset = "0x2961A40", VA = "0x182963440", Slot = "5")]
			public override void PreSolve()
			{
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x2963EF0", Offset = "0x29624F0", VA = "0x182963EF0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x2964960", Offset = "0x2962F60", VA = "0x182964960")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			// Token: 0x06000458 RID: 1112 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x2964A30", Offset = "0x2963030", VA = "0x182964A30")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x2964C90", Offset = "0x2963290", VA = "0x182964C90")]
			public void Solve(bool stretch)
			{
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x2964F80", Offset = "0x2963580", VA = "0x182964F80")]
			private void FixTwistRotations()
			{
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x2965440", Offset = "0x2963A40", VA = "0x182965440")]
			private void Stretching()
			{
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x2965AE0", Offset = "0x29640E0", VA = "0x182965AE0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x2965D90", Offset = "0x2964390", VA = "0x182965D90", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x2965E60", Offset = "0x2964460", VA = "0x182965E60")]
			public Leg()
			{
			}

			// Token: 0x04000397 RID: 919
			[Token(Token = "0x4000397")]
			[FieldOffset(Offset = "0x48")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			// Token: 0x04000398 RID: 920
			[Token(Token = "0x4000398")]
			[FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			// Token: 0x04000399 RID: 921
			[Token(Token = "0x4000399")]
			[FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			// Token: 0x0400039A RID: 922
			[Token(Token = "0x400039A")]
			[FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			// Token: 0x0400039B RID: 923
			[Token(Token = "0x400039B")]
			[FieldOffset(Offset = "0x60")]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			// Token: 0x0400039C RID: 924
			[Token(Token = "0x400039C")]
			[FieldOffset(Offset = "0x64")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of knee bending direction.")]
			public float swivelOffset;

			// Token: 0x0400039D RID: 925
			[Token(Token = "0x400039D")]
			[FieldOffset(Offset = "0x68")]
			[Range(0f, 1f)]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			public float bendToTargetWeight;

			// Token: 0x0400039E RID: 926
			[Token(Token = "0x400039E")]
			[FieldOffset(Offset = "0x6C")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			public float legLengthMlp;

			// Token: 0x0400039F RID: 927
			[Token(Token = "0x400039F")]
			[FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			// Token: 0x040003A0 RID: 928
			[Token(Token = "0x40003A0")]
			[FieldOffset(Offset = "0x78")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 IKPosition;

			// Token: 0x040003A1 RID: 929
			[Token(Token = "0x40003A1")]
			[FieldOffset(Offset = "0x84")]
			[HideInInspector]
			[NonSerialized]
			public Quaternion IKRotation;

			// Token: 0x040003A2 RID: 930
			[Token(Token = "0x40003A2")]
			[FieldOffset(Offset = "0x94")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 footPositionOffset;

			// Token: 0x040003A3 RID: 931
			[Token(Token = "0x40003A3")]
			[FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 heelPositionOffset;

			// Token: 0x040003A4 RID: 932
			[Token(Token = "0x40003A4")]
			[FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			[NonSerialized]
			public Quaternion footRotationOffset;

			// Token: 0x040003A5 RID: 933
			[Token(Token = "0x40003A5")]
			[FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			[NonSerialized]
			public float currentMag;

			// Token: 0x040003A6 RID: 934
			[Token(Token = "0x40003A6")]
			[FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			// Token: 0x040003AB RID: 939
			[Token(Token = "0x40003AB")]
			[FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			// Token: 0x040003AC RID: 940
			[Token(Token = "0x40003AC")]
			[FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			// Token: 0x040003AD RID: 941
			[Token(Token = "0x40003AD")]
			[FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			// Token: 0x040003AE RID: 942
			[Token(Token = "0x40003AE")]
			[FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			// Token: 0x040003AF RID: 943
			[Token(Token = "0x40003AF")]
			[FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			// Token: 0x040003B0 RID: 944
			[Token(Token = "0x40003B0")]
			[FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			// Token: 0x040003B1 RID: 945
			[Token(Token = "0x40003B1")]
			[FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;
		}

		// Token: 0x0200007C RID: 124
		[Token(Token = "0x200007C")]
		[Serializable]
		public class Locomotion
		{
			// Token: 0x17000075 RID: 117
			// (get) Token: 0x0600045F RID: 1119 RVA: 0x00003BCC File Offset: 0x00001DCC
			// (set) Token: 0x06000460 RID: 1120 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000075")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x2966060", Offset = "0x2964660", VA = "0x182966060")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x2966080", Offset = "0x2964680", VA = "0x182966080")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x29660A0", Offset = "0x29646A0", VA = "0x1829660A0")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x29664D0", Offset = "0x2964AD0", VA = "0x1829664D0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x29667B0", Offset = "0x2964DB0", VA = "0x1829667B0")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x2967000", Offset = "0x2965600", VA = "0x182967000")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x29671B0", Offset = "0x29657B0", VA = "0x1829671B0")]
			public void Solve(IKSolverVR.VirtualBone rootBone, IKSolverVR.Spine spine, IKSolverVR.Leg leftLeg, IKSolverVR.Leg rightLeg, IKSolverVR.Arm leftArm, IKSolverVR.Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x06000466 RID: 1126 RVA: 0x00003BE4 File Offset: 0x00001DE4
			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x2968F90", Offset = "0x2967590", VA = "0x182968F90")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000467 RID: 1127 RVA: 0x00003BFC File Offset: 0x00001DFC
			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x2968FE0", Offset = "0x29675E0", VA = "0x182968FE0")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x06000468 RID: 1128 RVA: 0x00003C14 File Offset: 0x00001E14
			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x2969030", Offset = "0x2967630", VA = "0x182969030")]
				get
				{
					return default(Quaternion);
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x06000469 RID: 1129 RVA: 0x00003C2C File Offset: 0x00001E2C
			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000469")]
				[Address(RVA = "0x2969070", Offset = "0x2967670", VA = "0x182969070")]
				get
				{
					return default(Quaternion);
				}
			}

			// Token: 0x0600046A RID: 1130 RVA: 0x00003C44 File Offset: 0x00001E44
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x29690B0", Offset = "0x29676B0", VA = "0x1829690B0")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			// Token: 0x0600046B RID: 1131 RVA: 0x00003C5C File Offset: 0x00001E5C
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x2969300", Offset = "0x2967900", VA = "0x182969300")]
			private bool CanStep()
			{
				return default(bool);
			}

			// Token: 0x0600046C RID: 1132 RVA: 0x00003C74 File Offset: 0x00001E74
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x2969370", Offset = "0x2967970", VA = "0x182969370")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			// Token: 0x0600046D RID: 1133 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x29695B0", Offset = "0x2967BB0", VA = "0x1829695B0")]
			public Locomotion()
			{
			}

			// Token: 0x040003B2 RID: 946
			[Token(Token = "0x40003B2")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			[Range(0f, 1f)]
			public float weight;

			// Token: 0x040003B3 RID: 947
			[Token(Token = "0x40003B3")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			// Token: 0x040003B4 RID: 948
			[Token(Token = "0x40003B4")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			// Token: 0x040003B5 RID: 949
			[Token(Token = "0x40003B5")]
			[FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			// Token: 0x040003B6 RID: 950
			[Token(Token = "0x40003B6")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			// Token: 0x040003B7 RID: 951
			[Token(Token = "0x40003B7")]
			[FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			// Token: 0x040003B8 RID: 952
			[Token(Token = "0x40003B8")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			// Token: 0x040003B9 RID: 953
			[Token(Token = "0x40003B9")]
			[FieldOffset(Offset = "0x2C")]
			[Range(0.9f, 1f)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch;

			// Token: 0x040003BA RID: 954
			[Token(Token = "0x40003BA")]
			[FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			// Token: 0x040003BB RID: 955
			[Token(Token = "0x40003BB")]
			[FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed;

			// Token: 0x040003BC RID: 956
			[Token(Token = "0x40003BC")]
			[FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			// Token: 0x040003BD RID: 957
			[Token(Token = "0x40003BD")]
			[FieldOffset(Offset = "0x40")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			// Token: 0x040003BE RID: 958
			[Token(Token = "0x40003BE")]
			[FieldOffset(Offset = "0x48")]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[Range(0f, 180f)]
			public float relaxLegTwistMinAngle;

			// Token: 0x040003BF RID: 959
			[Token(Token = "0x40003BF")]
			[FieldOffset(Offset = "0x4C")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			// Token: 0x040003C0 RID: 960
			[Token(Token = "0x40003C0")]
			[FieldOffset(Offset = "0x50")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			// Token: 0x040003C1 RID: 961
			[Token(Token = "0x40003C1")]
			[FieldOffset(Offset = "0x54")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			// Token: 0x040003C2 RID: 962
			[Token(Token = "0x40003C2")]
			[FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			// Token: 0x040003C3 RID: 963
			[Token(Token = "0x40003C3")]
			[FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			// Token: 0x040003C4 RID: 964
			[Token(Token = "0x40003C4")]
			[FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			// Token: 0x040003C5 RID: 965
			[Token(Token = "0x40003C5")]
			[FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			// Token: 0x040003C6 RID: 966
			[Token(Token = "0x40003C6")]
			[FieldOffset(Offset = "0x70")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			// Token: 0x040003C7 RID: 967
			[Token(Token = "0x40003C7")]
			[FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			// Token: 0x040003C9 RID: 969
			[Token(Token = "0x40003C9")]
			[FieldOffset(Offset = "0x90")]
			private IKSolverVR.Footstep[] footsteps;

			// Token: 0x040003CA RID: 970
			[Token(Token = "0x40003CA")]
			[FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			// Token: 0x040003CB RID: 971
			[Token(Token = "0x40003CB")]
			[FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			// Token: 0x040003CC RID: 972
			[Token(Token = "0x40003CC")]
			[FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			// Token: 0x040003CD RID: 973
			[Token(Token = "0x40003CD")]
			[FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;
		}

		// Token: 0x0200007D RID: 125
		[Token(Token = "0x200007D")]
		[Serializable]
		public class Spine : IKSolverVR.BodyPart
		{
			// Token: 0x1700007A RID: 122
			// (get) Token: 0x0600046E RID: 1134 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x1700007A")]
			public IKSolverVR.VirtualBone pelvis
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x2969850", Offset = "0x2967E50", VA = "0x182969850")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x0600046F RID: 1135 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x1700007B")]
			public IKSolverVR.VirtualBone firstSpineBone
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x2969880", Offset = "0x2967E80", VA = "0x182969880")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000470 RID: 1136 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x1700007C")]
			public IKSolverVR.VirtualBone chest
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x29698B0", Offset = "0x2967EB0", VA = "0x1829698B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000471 RID: 1137 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x1700007D")]
			private IKSolverVR.VirtualBone neck
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x2969900", Offset = "0x2967F00", VA = "0x182969900")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000472 RID: 1138 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x1700007E")]
			public IKSolverVR.VirtualBone head
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x2969930", Offset = "0x2967F30", VA = "0x182969930")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x06000473 RID: 1139 RVA: 0x00003C8C File Offset: 0x00001E8C
			// (set) Token: 0x06000474 RID: 1140 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000473")]
				[Address(RVA = "0x2969960", Offset = "0x2967F60", VA = "0x182969960")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000474")]
				[Address(RVA = "0x2969970", Offset = "0x2967F70", VA = "0x182969970")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x06000475 RID: 1141 RVA: 0x00003CA4 File Offset: 0x00001EA4
			// (set) Token: 0x06000476 RID: 1142 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000475")]
				[Address(RVA = "0x2969980", Offset = "0x2967F80", VA = "0x182969980")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000476")]
				[Address(RVA = "0x2969990", Offset = "0x2967F90", VA = "0x182969990")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000477 RID: 1143 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x29699A0", Offset = "0x2967FA0", VA = "0x1829699A0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			// Token: 0x06000478 RID: 1144 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x296AAD0", Offset = "0x29690D0", VA = "0x18296AAD0", Slot = "5")]
			public override void PreSolve()
			{
			}

			// Token: 0x06000479 RID: 1145 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x296B180", Offset = "0x2969780", VA = "0x18296B180", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			// Token: 0x0600047A RID: 1146 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x296BBC0", Offset = "0x296A1C0", VA = "0x18296BBC0")]
			private void CalculateChestTargetRotation(IKSolverVR.VirtualBone rootBone, IKSolverVR.Arm[] arms)
			{
			}

			// Token: 0x0600047B RID: 1147 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x296BF30", Offset = "0x296A530", VA = "0x18296BF30")]
			public void Solve(IKSolverVR.VirtualBone rootBone, IKSolverVR.Leg[] legs, IKSolverVR.Arm[] arms)
			{
			}

			// Token: 0x0600047C RID: 1148 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x296C6C0", Offset = "0x296ACC0", VA = "0x18296C6C0")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			// Token: 0x0600047D RID: 1149 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x296CA20", Offset = "0x296B020", VA = "0x18296CA20")]
			private void SolvePelvis()
			{
			}

			// Token: 0x0600047E RID: 1150 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x296CE20", Offset = "0x296B420", VA = "0x18296CE20", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			// Token: 0x0600047F RID: 1151 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x296D030", Offset = "0x296B630", VA = "0x18296D030", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x296D180", Offset = "0x296B780", VA = "0x18296D180")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, IKSolverVR.Arm[] arms)
			{
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x296D720", Offset = "0x296BD20", VA = "0x18296D720")]
			public void InverseTranslateToHead(IKSolverVR.Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			// Token: 0x06000482 RID: 1154 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x296D8B0", Offset = "0x296BEB0", VA = "0x18296D8B0")]
			private void TranslatePelvis(IKSolverVR.Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			// Token: 0x06000483 RID: 1155 RVA: 0x00003CBC File Offset: 0x00001EBC
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x296E1E0", Offset = "0x296C7E0", VA = "0x18296E1E0")]
			private Vector3 LimitPelvisPosition(IKSolverVR.Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			// Token: 0x06000484 RID: 1156 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x296E5E0", Offset = "0x296CBE0", VA = "0x18296E5E0")]
			private void Bend(IKSolverVR.VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x296E8C0", Offset = "0x296CEC0", VA = "0x18296E8C0")]
			private void Bend(IKSolverVR.VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x296ECA0", Offset = "0x296D2A0", VA = "0x18296ECA0")]
			public Spine()
			{
			}

			// Token: 0x040003CE RID: 974
			[Token(Token = "0x40003CE")]
			[FieldOffset(Offset = "0x48")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust it's position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			// Token: 0x040003CF RID: 975
			[Token(Token = "0x40003CF")]
			[FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			// Token: 0x040003D0 RID: 976
			[Token(Token = "0x40003D0")]
			[FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			public float positionWeight;

			// Token: 0x040003D1 RID: 977
			[Token(Token = "0x40003D1")]
			[FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			// Token: 0x040003D2 RID: 978
			[Token(Token = "0x40003D2")]
			[FieldOffset(Offset = "0x60")]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			// Token: 0x040003D3 RID: 979
			[Token(Token = "0x40003D3")]
			[FieldOffset(Offset = "0x64")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			public float pelvisRotationWeight;

			// Token: 0x040003D4 RID: 980
			[Token(Token = "0x40003D4")]
			[FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			// Token: 0x040003D5 RID: 981
			[Token(Token = "0x40003D5")]
			[FieldOffset(Offset = "0x70")]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			// Token: 0x040003D6 RID: 982
			[Token(Token = "0x40003D6")]
			[FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			// Token: 0x040003D7 RID: 983
			[Token(Token = "0x40003D7")]
			[FieldOffset(Offset = "0x78")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			// Token: 0x040003D8 RID: 984
			[Token(Token = "0x40003D8")]
			[FieldOffset(Offset = "0x7C")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			public float bodyRotStiffness;

			// Token: 0x040003D9 RID: 985
			[Token(Token = "0x40003D9")]
			[FieldOffset(Offset = "0x80")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			public float neckStiffness;

			// Token: 0x040003DA RID: 986
			[Token(Token = "0x40003DA")]
			[FieldOffset(Offset = "0x84")]
			[Range(0f, 1f)]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			public float rotateChestByHands;

			// Token: 0x040003DB RID: 987
			[Token(Token = "0x40003DB")]
			[FieldOffset(Offset = "0x88")]
			[Range(0f, 1f)]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			public float chestClampWeight;

			// Token: 0x040003DC RID: 988
			[Token(Token = "0x40003DC")]
			[FieldOffset(Offset = "0x8C")]
			[Range(0f, 1f)]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			public float headClampWeight;

			// Token: 0x040003DD RID: 989
			[Token(Token = "0x40003DD")]
			[FieldOffset(Offset = "0x90")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			// Token: 0x040003DE RID: 990
			[Token(Token = "0x40003DE")]
			[FieldOffset(Offset = "0x94")]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			[Range(0f, 1f)]
			public float maintainPelvisPosition;

			// Token: 0x040003DF RID: 991
			[Token(Token = "0x40003DF")]
			[FieldOffset(Offset = "0x98")]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			public float maxRootAngle;

			// Token: 0x040003E0 RID: 992
			[Token(Token = "0x40003E0")]
			[FieldOffset(Offset = "0x9C")]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			[Range(-180f, 180f)]
			public float rootHeadingOffset;

			// Token: 0x040003E1 RID: 993
			[Token(Token = "0x40003E1")]
			[FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 IKPositionHead;

			// Token: 0x040003E2 RID: 994
			[Token(Token = "0x40003E2")]
			[FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			[NonSerialized]
			public Quaternion IKRotationHead;

			// Token: 0x040003E3 RID: 995
			[Token(Token = "0x40003E3")]
			[FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 IKPositionPelvis;

			// Token: 0x040003E4 RID: 996
			[Token(Token = "0x40003E4")]
			[FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			[NonSerialized]
			public Quaternion IKRotationPelvis;

			// Token: 0x040003E5 RID: 997
			[Token(Token = "0x40003E5")]
			[FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 goalPositionChest;

			// Token: 0x040003E6 RID: 998
			[Token(Token = "0x40003E6")]
			[FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 pelvisPositionOffset;

			// Token: 0x040003E7 RID: 999
			[Token(Token = "0x40003E7")]
			[FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 chestPositionOffset;

			// Token: 0x040003E8 RID: 1000
			[Token(Token = "0x40003E8")]
			[FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 headPositionOffset;

			// Token: 0x040003E9 RID: 1001
			[Token(Token = "0x40003E9")]
			[FieldOffset(Offset = "0x108")]
			[HideInInspector]
			[NonSerialized]
			public Quaternion pelvisRotationOffset;

			// Token: 0x040003EA RID: 1002
			[Token(Token = "0x40003EA")]
			[FieldOffset(Offset = "0x118")]
			[HideInInspector]
			[NonSerialized]
			public Quaternion chestRotationOffset;

			// Token: 0x040003EB RID: 1003
			[Token(Token = "0x40003EB")]
			[FieldOffset(Offset = "0x128")]
			[HideInInspector]
			[NonSerialized]
			public Quaternion headRotationOffset;

			// Token: 0x040003EC RID: 1004
			[Token(Token = "0x40003EC")]
			[FieldOffset(Offset = "0x138")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 faceDirection;

			// Token: 0x040003ED RID: 1005
			[Token(Token = "0x40003ED")]
			[FieldOffset(Offset = "0x144")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 locomotionHeadPositionOffset;

			// Token: 0x040003EE RID: 1006
			[Token(Token = "0x40003EE")]
			[FieldOffset(Offset = "0x150")]
			[HideInInspector]
			[NonSerialized]
			public Vector3 headPosition;

			// Token: 0x040003F1 RID: 1009
			[Token(Token = "0x40003F1")]
			[FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			// Token: 0x040003F2 RID: 1010
			[Token(Token = "0x40003F2")]
			[FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			// Token: 0x040003F3 RID: 1011
			[Token(Token = "0x40003F3")]
			[FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			// Token: 0x040003F4 RID: 1012
			[Token(Token = "0x40003F4")]
			[FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			// Token: 0x040003F5 RID: 1013
			[Token(Token = "0x40003F5")]
			[FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			// Token: 0x040003F6 RID: 1014
			[Token(Token = "0x40003F6")]
			[FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			// Token: 0x040003F7 RID: 1015
			[Token(Token = "0x40003F7")]
			[FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			// Token: 0x040003F8 RID: 1016
			[Token(Token = "0x40003F8")]
			[FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			// Token: 0x040003F9 RID: 1017
			[Token(Token = "0x40003F9")]
			[FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			// Token: 0x040003FA RID: 1018
			[Token(Token = "0x40003FA")]
			[FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			// Token: 0x040003FB RID: 1019
			[Token(Token = "0x40003FB")]
			[FieldOffset(Offset = "0x200")]
			private int chestIndex;

			// Token: 0x040003FC RID: 1020
			[Token(Token = "0x40003FC")]
			[FieldOffset(Offset = "0x204")]
			private int neckIndex;

			// Token: 0x040003FD RID: 1021
			[Token(Token = "0x40003FD")]
			[FieldOffset(Offset = "0x208")]
			private int headIndex;

			// Token: 0x040003FE RID: 1022
			[Token(Token = "0x40003FE")]
			[FieldOffset(Offset = "0x20C")]
			private float length;

			// Token: 0x040003FF RID: 1023
			[Token(Token = "0x40003FF")]
			[FieldOffset(Offset = "0x210")]
			private bool hasChest;

			// Token: 0x04000400 RID: 1024
			[Token(Token = "0x4000400")]
			[FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			// Token: 0x04000401 RID: 1025
			[Token(Token = "0x4000401")]
			[FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			// Token: 0x04000402 RID: 1026
			[Token(Token = "0x4000402")]
			[FieldOffset(Offset = "0x214")]
			private float headHeight;

			// Token: 0x04000403 RID: 1027
			[Token(Token = "0x4000403")]
			[FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			// Token: 0x04000404 RID: 1028
			[Token(Token = "0x4000404")]
			[FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;
		}

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x200007E")]
		[Serializable]
		public enum PositionOffset
		{
			// Token: 0x04000406 RID: 1030
			[Token(Token = "0x4000406")]
			Pelvis,
			// Token: 0x04000407 RID: 1031
			[Token(Token = "0x4000407")]
			Chest,
			// Token: 0x04000408 RID: 1032
			[Token(Token = "0x4000408")]
			Head,
			// Token: 0x04000409 RID: 1033
			[Token(Token = "0x4000409")]
			LeftHand,
			// Token: 0x0400040A RID: 1034
			[Token(Token = "0x400040A")]
			RightHand,
			// Token: 0x0400040B RID: 1035
			[Token(Token = "0x400040B")]
			LeftFoot,
			// Token: 0x0400040C RID: 1036
			[Token(Token = "0x400040C")]
			RightFoot,
			// Token: 0x0400040D RID: 1037
			[Token(Token = "0x400040D")]
			LeftHeel,
			// Token: 0x0400040E RID: 1038
			[Token(Token = "0x400040E")]
			RightHeel
		}

		// Token: 0x0200007F RID: 127
		[Token(Token = "0x200007F")]
		[Serializable]
		public enum RotationOffset
		{
			// Token: 0x04000410 RID: 1040
			[Token(Token = "0x4000410")]
			Pelvis,
			// Token: 0x04000411 RID: 1041
			[Token(Token = "0x4000411")]
			Chest,
			// Token: 0x04000412 RID: 1042
			[Token(Token = "0x4000412")]
			Head
		}

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000080")]
		[Serializable]
		public class VirtualBone
		{
			// Token: 0x06000487 RID: 1159 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x296EFB0", Offset = "0x296D5B0", VA = "0x18296EFB0")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			// Token: 0x06000488 RID: 1160 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x296EFB0", Offset = "0x296D5B0", VA = "0x18296EFB0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			// Token: 0x06000489 RID: 1161 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x296EFE0", Offset = "0x296D5E0", VA = "0x18296EFE0")]
			public static void SwingRotation(IKSolverVR.VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			// Token: 0x0600048A RID: 1162 RVA: 0x00003CD4 File Offset: 0x00001ED4
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x296F3B0", Offset = "0x296D9B0", VA = "0x18296F3B0")]
			public static float PreSolve(ref IKSolverVR.VirtualBone[] bones)
			{
				return 0f;
			}

			// Token: 0x0600048B RID: 1163 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x296F670", Offset = "0x296DC70", VA = "0x18296F670")]
			public static void RotateAroundPoint(IKSolverVR.VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			// Token: 0x0600048C RID: 1164 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x296F800", Offset = "0x296DE00", VA = "0x18296F800")]
			public static void RotateBy(IKSolverVR.VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			// Token: 0x0600048D RID: 1165 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x296F9B0", Offset = "0x296DFB0", VA = "0x18296F9B0")]
			public static void RotateBy(IKSolverVR.VirtualBone[] bones, Quaternion rotation)
			{
			}

			// Token: 0x0600048E RID: 1166 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x296FB60", Offset = "0x296E160", VA = "0x18296FB60")]
			public static void RotateTo(IKSolverVR.VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			// Token: 0x0600048F RID: 1167 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x296FC20", Offset = "0x296E220", VA = "0x18296FC20")]
			public static void SolveTrigonometric(IKSolverVR.VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			// Token: 0x06000490 RID: 1168 RVA: 0x00003CEC File Offset: 0x00001EEC
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x2970430", Offset = "0x296EA30", VA = "0x182970430")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x29706C0", Offset = "0x296ECC0", VA = "0x1829706C0")]
			public static void SolveFABRIK(IKSolverVR.VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			// Token: 0x06000492 RID: 1170 RVA: 0x00003D04 File Offset: 0x00001F04
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x2970C40", Offset = "0x296F240", VA = "0x182970C40")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x2970DC0", Offset = "0x296F3C0", VA = "0x182970DC0")]
			public static void SolveCCD(IKSolverVR.VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}

			// Token: 0x04000413 RID: 1043
			[Token(Token = "0x4000413")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			// Token: 0x04000414 RID: 1044
			[Token(Token = "0x4000414")]
			[FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			// Token: 0x04000415 RID: 1045
			[Token(Token = "0x4000415")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			// Token: 0x04000416 RID: 1046
			[Token(Token = "0x4000416")]
			[FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			// Token: 0x04000417 RID: 1047
			[Token(Token = "0x4000417")]
			[FieldOffset(Offset = "0x48")]
			public float length;

			// Token: 0x04000418 RID: 1048
			[Token(Token = "0x4000418")]
			[FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			// Token: 0x04000419 RID: 1049
			[Token(Token = "0x4000419")]
			[FieldOffset(Offset = "0x50")]
			public Vector3 axis;
		}
	}
}
