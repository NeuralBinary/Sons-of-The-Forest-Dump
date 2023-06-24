using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	public static class VRIKCalibrator
	{
		// Token: 0x06000661 RID: 1633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x299B100", Offset = "0x2999700", VA = "0x18299B100")]
		public static void RecalibrateScale(VRIK ik, VRIKCalibrator.Settings settings)
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x299B410", Offset = "0x2999A10", VA = "0x18299B410")]
		public static VRIKCalibrator.CalibrationData Calibrate(VRIK ik, VRIKCalibrator.Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x299D6E0", Offset = "0x299BCE0", VA = "0x18299D6E0")]
		private static void CalibrateLeg(VRIKCalibrator.Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x299EA30", Offset = "0x299D030", VA = "0x18299EA30")]
		public static void Calibrate(VRIK ik, VRIKCalibrator.CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x299FB20", Offset = "0x299E120", VA = "0x18299FB20")]
		private static void CalibrateLeg(VRIKCalibrator.CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		// Token: 0x020000CD RID: 205
		[Token(Token = "0x20000CD")]
		[Serializable]
		public class Settings
		{
			// Token: 0x06000666 RID: 1638 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x299FF40", Offset = "0x299E540", VA = "0x18299FF40")]
			public Settings()
			{
			}

			// Token: 0x040005DE RID: 1502
			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			// Token: 0x040005DF RID: 1503
			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			// Token: 0x040005E0 RID: 1504
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			// Token: 0x040005E1 RID: 1505
			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the body tracker towards the player's forward direction.")]
			public Vector3 bodyTrackerForward;

			// Token: 0x040005E2 RID: 1506
			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the body tracker towards the up direction.")]
			public Vector3 bodyTrackerUp;

			// Token: 0x040005E3 RID: 1507
			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			// Token: 0x040005E4 RID: 1508
			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			// Token: 0x040005E5 RID: 1509
			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			// Token: 0x040005E6 RID: 1510
			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			// Token: 0x040005E7 RID: 1511
			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Space(10f)]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			public Vector3 headOffset;

			// Token: 0x040005E8 RID: 1512
			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			// Token: 0x040005E9 RID: 1513
			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			// Token: 0x040005EA RID: 1514
			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			// Token: 0x040005EB RID: 1515
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Range(-180f, 180f)]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			public float footHeadingOffset;

			// Token: 0x040005EC RID: 1516
			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			// Token: 0x040005ED RID: 1517
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;
		}

		// Token: 0x020000CE RID: 206
		[Token(Token = "0x20000CE")]
		[Serializable]
		public class CalibrationData
		{
			// Token: 0x06000667 RID: 1639 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CalibrationData()
			{
			}

			// Token: 0x040005EE RID: 1518
			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			// Token: 0x040005EF RID: 1519
			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public VRIKCalibrator.CalibrationData.Target head;

			// Token: 0x040005F0 RID: 1520
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VRIKCalibrator.CalibrationData.Target leftHand;

			// Token: 0x040005F1 RID: 1521
			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VRIKCalibrator.CalibrationData.Target rightHand;

			// Token: 0x040005F2 RID: 1522
			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public VRIKCalibrator.CalibrationData.Target pelvis;

			// Token: 0x040005F3 RID: 1523
			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public VRIKCalibrator.CalibrationData.Target leftFoot;

			// Token: 0x040005F4 RID: 1524
			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public VRIKCalibrator.CalibrationData.Target rightFoot;

			// Token: 0x040005F5 RID: 1525
			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public VRIKCalibrator.CalibrationData.Target leftLegGoal;

			// Token: 0x040005F6 RID: 1526
			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public VRIKCalibrator.CalibrationData.Target rightLegGoal;

			// Token: 0x040005F7 RID: 1527
			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			// Token: 0x040005F8 RID: 1528
			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			// Token: 0x040005F9 RID: 1529
			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			// Token: 0x020000CF RID: 207
			[Token(Token = "0x20000CF")]
			[Serializable]
			public class Target
			{
				// Token: 0x06000668 RID: 1640 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6000668")]
				[Address(RVA = "0x29A0160", Offset = "0x299E760", VA = "0x1829A0160")]
				public Target(Transform t)
				{
				}

				// Token: 0x06000669 RID: 1641 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6000669")]
				[Address(RVA = "0x29A0300", Offset = "0x299E900", VA = "0x1829A0300")]
				public void SetTo(Transform t)
				{
				}

				// Token: 0x040005FA RID: 1530
				[Token(Token = "0x40005FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				// Token: 0x040005FB RID: 1531
				[Token(Token = "0x40005FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				// Token: 0x040005FC RID: 1532
				[Token(Token = "0x40005FC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;
			}
		}
	}
}
