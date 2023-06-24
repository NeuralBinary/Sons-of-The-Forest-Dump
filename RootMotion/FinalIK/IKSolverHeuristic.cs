using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[Serializable]
	public class IKSolverHeuristic : IKSolver
	{
		// Token: 0x06000397 RID: 919 RVA: 0x00003734 File Offset: 0x00001934
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x29446C0", Offset = "0x2942CC0", VA = "0x1829446C0")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x29448F0", Offset = "0x2942EF0", VA = "0x1829448F0")]
		public void AddBone(Transform bone)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2944B90", Offset = "0x2943190", VA = "0x182944B90", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2944D00", Offset = "0x2943300", VA = "0x182944D00", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000374C File Offset: 0x0000194C
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2944D80", Offset = "0x2943380", VA = "0x182944D80", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x2945400", Offset = "0x2943A00", VA = "0x182945400", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00003764 File Offset: 0x00001964
		[Token(Token = "0x17000054")]
		protected virtual int minBones
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000377C File Offset: 0x0000197C
		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00003794 File Offset: 0x00001994
		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x29455A0", Offset = "0x2943BA0", VA = "0x1829455A0")]
		protected void InitiateBones()
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x000037AC File Offset: 0x000019AC
		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x2945E30", Offset = "0x2944430", VA = "0x182945E30", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x000037C4 File Offset: 0x000019C4
		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x2946050", Offset = "0x2944650", VA = "0x182946050")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000037DC File Offset: 0x000019DC
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x29460D0", Offset = "0x29446D0", VA = "0x1829460D0")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000037F4 File Offset: 0x000019F4
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x2946630", Offset = "0x2944C30", VA = "0x182946630")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x29469A0", Offset = "0x2944FA0", VA = "0x1829469A0")]
		public IKSolverHeuristic()
		{
		}

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x58")]
		public Transform target;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x60")]
		public float tolerance;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x64")]
		public int maxIterations;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x69")]
		public bool XY;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x70")]
		public IKSolver.Bone[] bones;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x84")]
		protected float chainLength;
	}
}
