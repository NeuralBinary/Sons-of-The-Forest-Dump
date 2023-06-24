using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	[Serializable]
	public abstract class IKSolver
	{
		// Token: 0x060002E7 RID: 743 RVA: 0x00003464 File Offset: 0x00001664
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x292ED10", Offset = "0x292D310", VA = "0x18292ED10")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060002E8 RID: 744
		[Token(Token = "0x60002E8")]
		public abstract bool IsValid(ref string message);

		// Token: 0x060002E9 RID: 745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x292ED70", Offset = "0x292D370", VA = "0x18292ED70")]
		public void Initiate(Transform root)
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x292EF70", Offset = "0x292D570", VA = "0x18292EF70")]
		public void Update()
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000347C File Offset: 0x0000167C
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1766460", Offset = "0x1764A60", VA = "0x181766460", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2040020", Offset = "0x203E620", VA = "0x182040020")]
		public void SetIKPosition(Vector3 position)
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00003494 File Offset: 0x00001694
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
		public float GetIKPositionWeight()
		{
			return 0f;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x292EFE0", Offset = "0x292D5E0", VA = "0x18292EFE0")]
		public void SetIKPositionWeight(float weight)
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
		public Transform GetRoot()
		{
			return null;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x000034AC File Offset: 0x000016AC
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003A")]
		public bool initiated
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060002F2 RID: 754
		[Token(Token = "0x60002F2")]
		public abstract IKSolver.Point[] GetPoints();

		// Token: 0x060002F3 RID: 755
		[Token(Token = "0x60002F3")]
		public abstract IKSolver.Point GetPoint(Transform transform);

		// Token: 0x060002F4 RID: 756
		[Token(Token = "0x60002F4")]
		public abstract void FixTransforms();

		// Token: 0x060002F5 RID: 757
		[Token(Token = "0x60002F5")]
		public abstract void StoreDefaultLocalState();

		// Token: 0x060002F6 RID: 758
		[Token(Token = "0x60002F6")]
		protected abstract void OnInitiate();

		// Token: 0x060002F7 RID: 759
		[Token(Token = "0x60002F7")]
		protected abstract void OnUpdate();

		// Token: 0x060002F8 RID: 760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x292F010", Offset = "0x292D610", VA = "0x18292F010")]
		protected void LogWarning(string message)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x292F0B0", Offset = "0x292D6B0", VA = "0x18292F0B0")]
		public static Transform ContainsDuplicateBone(IKSolver.Bone[] bones)
		{
			return null;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000034C4 File Offset: 0x000016C4
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x292F270", Offset = "0x292D870", VA = "0x18292F270")]
		public static bool HierarchyIsValid(IKSolver.Bone[] bones)
		{
			return default(bool);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000034DC File Offset: 0x000016DC
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x292F300", Offset = "0x292D900", VA = "0x18292F300")]
		protected static float PreSolveBones(ref IKSolver.Bone[] bones)
		{
			return 0f;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x292F710", Offset = "0x292DD10", VA = "0x18292F710")]
		protected IKSolver()
		{
		}

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		[Tooltip("The positional or the master weight of the solver.")]
		public float IKPositionWeight;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x28")]
		public IKSolver.UpdateDelegate OnPreInitiate;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x30")]
		public IKSolver.UpdateDelegate OnPostInitiate;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x38")]
		public IKSolver.UpdateDelegate OnPreUpdate;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x40")]
		public IKSolver.UpdateDelegate OnPostUpdate;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		// Token: 0x0200005F RID: 95
		[Token(Token = "0x200005F")]
		[Serializable]
		public class Point
		{
			// Token: 0x060002FD RID: 765 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x292F720", Offset = "0x292DD20", VA = "0x18292F720")]
			public void StoreDefaultLocalState()
			{
			}

			// Token: 0x060002FE RID: 766 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x292F810", Offset = "0x292DE10", VA = "0x18292F810")]
			public void FixTransform()
			{
			}

			// Token: 0x060002FF RID: 767 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x292FA50", Offset = "0x292E050", VA = "0x18292FA50")]
			public void UpdateSolverPosition()
			{
			}

			// Token: 0x06000300 RID: 768 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x292FAE0", Offset = "0x292E0E0", VA = "0x18292FAE0")]
			public void UpdateSolverLocalPosition()
			{
			}

			// Token: 0x06000301 RID: 769 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x292FB70", Offset = "0x292E170", VA = "0x18292FB70")]
			public void UpdateSolverState()
			{
			}

			// Token: 0x06000302 RID: 770 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x292FC60", Offset = "0x292E260", VA = "0x18292FC60")]
			public void UpdateSolverLocalState()
			{
			}

			// Token: 0x06000303 RID: 771 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x292FD50", Offset = "0x292E350", VA = "0x18292FD50")]
			public Point()
			{
			}

			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			[FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			[FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			// Token: 0x040002A4 RID: 676
			[Token(Token = "0x40002A4")]
			[FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			// Token: 0x040002A5 RID: 677
			[Token(Token = "0x40002A5")]
			[FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;
		}

		// Token: 0x02000060 RID: 96
		[Token(Token = "0x2000060")]
		[Serializable]
		public class Bone : IKSolver.Point
		{
			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000304 RID: 772 RVA: 0x000020AE File Offset: 0x000002AE
			// (set) Token: 0x06000305 RID: 773 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700003B")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000304")]
				[Address(RVA = "0x292FDA0", Offset = "0x292E3A0", VA = "0x18292FDA0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000305")]
				[Address(RVA = "0x292FF90", Offset = "0x292E590", VA = "0x18292FF90")]
				set
				{
				}
			}

			// Token: 0x06000306 RID: 774 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x29300B0", Offset = "0x292E6B0", VA = "0x1829300B0")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			// Token: 0x06000307 RID: 775 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x29304F0", Offset = "0x292EAF0", VA = "0x1829304F0")]
			public static void SolverSwing(IKSolver.Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			// Token: 0x06000308 RID: 776 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x2930A00", Offset = "0x292F000", VA = "0x182930A00")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			// Token: 0x06000309 RID: 777 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x2930D20", Offset = "0x292F320", VA = "0x182930D20")]
			public void SetToSolverPosition()
			{
			}

			// Token: 0x0600030A RID: 778 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x2930DA0", Offset = "0x292F3A0", VA = "0x182930DA0")]
			public Bone()
			{
			}

			// Token: 0x0600030B RID: 779 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x2930E60", Offset = "0x292F460", VA = "0x182930E60")]
			public Bone(Transform transform)
			{
			}

			// Token: 0x0600030C RID: 780 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x2930F80", Offset = "0x292F580", VA = "0x182930F80")]
			public Bone(Transform transform, float weight)
			{
			}

			// Token: 0x040002A6 RID: 678
			[Token(Token = "0x40002A6")]
			[FieldOffset(Offset = "0x58")]
			public float length;

			// Token: 0x040002A7 RID: 679
			[Token(Token = "0x40002A7")]
			[FieldOffset(Offset = "0x5C")]
			public float sqrMag;

			// Token: 0x040002A8 RID: 680
			[Token(Token = "0x40002A8")]
			[FieldOffset(Offset = "0x60")]
			public Vector3 axis;

			// Token: 0x040002A9 RID: 681
			[Token(Token = "0x40002A9")]
			[FieldOffset(Offset = "0x70")]
			private RotationLimit _rotationLimit;

			// Token: 0x040002AA RID: 682
			[Token(Token = "0x40002AA")]
			[FieldOffset(Offset = "0x78")]
			private bool isLimited;
		}

		// Token: 0x02000061 RID: 97
		[Token(Token = "0x2000061")]
		[Serializable]
		public class Node : IKSolver.Point
		{
			// Token: 0x0600030D RID: 781 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x292FD50", Offset = "0x292E350", VA = "0x18292FD50")]
			public Node()
			{
			}

			// Token: 0x0600030E RID: 782 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x29310B0", Offset = "0x292F6B0", VA = "0x1829310B0")]
			public Node(Transform transform)
			{
			}

			// Token: 0x0600030F RID: 783 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x2931150", Offset = "0x292F750", VA = "0x182931150")]
			public Node(Transform transform, float weight)
			{
			}

			// Token: 0x040002AB RID: 683
			[Token(Token = "0x40002AB")]
			[FieldOffset(Offset = "0x58")]
			public float length;

			// Token: 0x040002AC RID: 684
			[Token(Token = "0x40002AC")]
			[FieldOffset(Offset = "0x5C")]
			public float effectorPositionWeight;

			// Token: 0x040002AD RID: 685
			[Token(Token = "0x40002AD")]
			[FieldOffset(Offset = "0x60")]
			public float effectorRotationWeight;

			// Token: 0x040002AE RID: 686
			[Token(Token = "0x40002AE")]
			[FieldOffset(Offset = "0x64")]
			public Vector3 offset;
		}

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x06000311 RID: 785
		[Token(Token = "0x2000062")]
		public delegate void UpdateDelegate();

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x06000315 RID: 789
		[Token(Token = "0x2000063")]
		public delegate void IterationDelegate(int i);
	}
}
