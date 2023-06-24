using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	[Serializable]
	public class IKMapping
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x00003344 File Offset: 0x00001544
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000335C File Offset: 0x0000155C
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2926D60", Offset = "0x2925360", VA = "0x182926D60")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00003374 File Offset: 0x00001574
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2920300", Offset = "0x291E900", VA = "0x182920300")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public IKMapping()
		{
		}

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x2000059")]
		[Serializable]
		public class BoneMap
		{
			// Token: 0x060002AD RID: 685 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x2926F90", Offset = "0x2925590", VA = "0x182926F90")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060002AE RID: 686 RVA: 0x0000338C File Offset: 0x0000158C
			[Token(Token = "0x17000037")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60002AE")]
				[Address(RVA = "0x2927010", Offset = "0x2925610", VA = "0x182927010")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x060002AF RID: 687 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x29270E0", Offset = "0x29256E0", VA = "0x1829270E0")]
			public void StoreDefaultLocalState()
			{
			}

			// Token: 0x060002B0 RID: 688 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x29271D0", Offset = "0x29257D0", VA = "0x1829271D0")]
			public void FixTransform(bool position)
			{
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060002B1 RID: 689 RVA: 0x000033A4 File Offset: 0x000015A4
			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002B1")]
				[Address(RVA = "0x29272B0", Offset = "0x29258B0", VA = "0x1829272B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x29272C0", Offset = "0x29258C0", VA = "0x1829272C0")]
			public void SetLength(IKMapping.BoneMap nextBone)
			{
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x2927470", Offset = "0x2925A70", VA = "0x182927470")]
			public void SetLocalSwingAxis(IKMapping.BoneMap swingTarget)
			{
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x2927480", Offset = "0x2925A80", VA = "0x182927480")]
			public void SetLocalSwingAxis(IKMapping.BoneMap bone1, IKMapping.BoneMap bone2)
			{
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x29276B0", Offset = "0x2925CB0", VA = "0x1829276B0")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x2927830", Offset = "0x2925E30", VA = "0x182927830")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x2927A00", Offset = "0x2926000", VA = "0x182927A00")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x2927C60", Offset = "0x2926260", VA = "0x182927C60")]
			public void SetIKPosition()
			{
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x2927CF0", Offset = "0x29262F0", VA = "0x182927CF0")]
			public void MaintainRotation()
			{
			}

			// Token: 0x060002BA RID: 698 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x2927D70", Offset = "0x2926370", VA = "0x182927D70")]
			public void SetToIKPosition()
			{
			}

			// Token: 0x060002BB RID: 699 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x2927DF0", Offset = "0x29263F0", VA = "0x182927DF0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			// Token: 0x060002BC RID: 700 RVA: 0x000033BC File Offset: 0x000015BC
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x2928020", Offset = "0x2926620", VA = "0x182928020")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			// Token: 0x060002BD RID: 701 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x2928140", Offset = "0x2926740", VA = "0x182928140")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			// Token: 0x060002BE RID: 702 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x29281D0", Offset = "0x29267D0", VA = "0x1829281D0")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			// Token: 0x060002BF RID: 703 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x29284E0", Offset = "0x2926AE0", VA = "0x1829284E0")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			// Token: 0x060002C0 RID: 704 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x29285C0", Offset = "0x2926BC0", VA = "0x1829285C0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			// Token: 0x060002C1 RID: 705 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x2928AA0", Offset = "0x29270A0", VA = "0x182928AA0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			// Token: 0x060002C2 RID: 706 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x2928F70", Offset = "0x2927570", VA = "0x182928F70")]
			public void RotateToMaintain(float weight)
			{
			}

			// Token: 0x060002C3 RID: 707 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x29290D0", Offset = "0x29276D0", VA = "0x1829290D0")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x000033D4 File Offset: 0x000015D4
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x2929390", Offset = "0x2927990", VA = "0x182929390")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060002C5 RID: 709 RVA: 0x000033EC File Offset: 0x000015EC
			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002C5")]
				[Address(RVA = "0x2929660", Offset = "0x2927C60", VA = "0x182929660")]
				get
				{
					return default(Quaternion);
				}
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x2929A20", Offset = "0x2928020", VA = "0x182929A20")]
			public BoneMap()
			{
			}

			// Token: 0x04000260 RID: 608
			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			// Token: 0x04000261 RID: 609
			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			// Token: 0x04000262 RID: 610
			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			// Token: 0x04000263 RID: 611
			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			// Token: 0x04000264 RID: 612
			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			// Token: 0x04000265 RID: 613
			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			// Token: 0x04000266 RID: 614
			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			// Token: 0x04000267 RID: 615
			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			// Token: 0x04000268 RID: 616
			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			// Token: 0x04000269 RID: 617
			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			// Token: 0x0400026A RID: 618
			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			// Token: 0x0400026B RID: 619
			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			// Token: 0x0400026C RID: 620
			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			// Token: 0x0400026D RID: 621
			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			// Token: 0x0400026E RID: 622
			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			// Token: 0x0400026F RID: 623
			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			// Token: 0x04000270 RID: 624
			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			// Token: 0x04000273 RID: 627
			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			// Token: 0x04000274 RID: 628
			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			// Token: 0x04000275 RID: 629
			[Token(Token = "0x4000275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;
		}
	}
}
