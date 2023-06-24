using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitPolygonal : RotationLimit
	{
		// Token: 0x06000594 RID: 1428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2989750", Offset = "0x2987D50", VA = "0x182989750")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x29897E0", Offset = "0x2987DE0", VA = "0x1829897E0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2989870", Offset = "0x2987E70", VA = "0x182989870")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2989900", Offset = "0x2987F00", VA = "0x182989900")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2989990", Offset = "0x2987F90", VA = "0x182989990")]
		public void SetLimitPoints(RotationLimitPolygonal.LimitPoint[] points)
		{
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000428C File Offset: 0x0000248C
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x2989A50", Offset = "0x2988050", VA = "0x182989A50", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2989B50", Offset = "0x2988150", VA = "0x182989B50")]
		private void Start()
		{
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2989D50", Offset = "0x2988350", VA = "0x182989D50")]
		public void ResetToDefault()
		{
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x298A8B0", Offset = "0x2988EB0", VA = "0x18298A8B0")]
		public void BuildReachCones()
		{
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x298B120", Offset = "0x2989720", VA = "0x18298B120")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000042A4 File Offset: 0x000024A4
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x298B870", Offset = "0x2989E70", VA = "0x18298B870")]
		private float GetScalar(int k)
		{
			return 0f;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000042BC File Offset: 0x000024BC
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x298B8C0", Offset = "0x2989EC0", VA = "0x18298B8C0")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000042D4 File Offset: 0x000024D4
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x298B9E0", Offset = "0x2989FE0", VA = "0x18298B9E0")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000042EC File Offset: 0x000024EC
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x298BB40", Offset = "0x298A140", VA = "0x18298BB40")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00004304 File Offset: 0x00002504
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x298BEE0", Offset = "0x298A4E0", VA = "0x18298BEE0")]
		private int GetReachCone(Vector3 L)
		{
			return 0;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x298C070", Offset = "0x298A670", VA = "0x18298C070")]
		public RotationLimitPolygonal()
		{
		}

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 180f)]
		public float twistLimit;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 3f)]
		public int smoothIterations;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		public RotationLimitPolygonal.LimitPoint[] points;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		public Vector3[] P;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[SerializeField]
		public RotationLimitPolygonal.ReachCone[] reachCones;

		// Token: 0x020000A1 RID: 161
		[Token(Token = "0x20000A1")]
		[Serializable]
		public class ReachCone
		{
			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0000431C File Offset: 0x0000251C
			[Token(Token = "0x17000096")]
			public Vector3 o
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x298C110", Offset = "0x298A710", VA = "0x18298C110")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00004334 File Offset: 0x00002534
			[Token(Token = "0x17000097")]
			public Vector3 a
			{
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0x298C150", Offset = "0x298A750", VA = "0x18298C150")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0000434C File Offset: 0x0000254C
			[Token(Token = "0x17000098")]
			public Vector3 b
			{
				[Token(Token = "0x60005A6")]
				[Address(RVA = "0x298C190", Offset = "0x298A790", VA = "0x18298C190")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00004364 File Offset: 0x00002564
			[Token(Token = "0x17000099")]
			public Vector3 c
			{
				[Token(Token = "0x60005A7")]
				[Address(RVA = "0x298C1D0", Offset = "0x298A7D0", VA = "0x18298C1D0")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x060005A8 RID: 1448 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x298C210", Offset = "0x298A810", VA = "0x18298C210")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0000437C File Offset: 0x0000257C
			[Token(Token = "0x1700009A")]
			public bool isValid
			{
				[Token(Token = "0x60005A9")]
				[Address(RVA = "0x298C400", Offset = "0x298AA00", VA = "0x18298C400")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060005AA RID: 1450 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x298C410", Offset = "0x298AA10", VA = "0x18298C410")]
			public void Calculate()
			{
			}

			// Token: 0x040004F6 RID: 1270
			[Token(Token = "0x40004F6")]
			[FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			// Token: 0x040004F7 RID: 1271
			[Token(Token = "0x40004F7")]
			[FieldOffset(Offset = "0x18")]
			public float volume;

			// Token: 0x040004F8 RID: 1272
			[Token(Token = "0x40004F8")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			// Token: 0x040004F9 RID: 1273
			[Token(Token = "0x40004F9")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 B;
		}

		// Token: 0x020000A2 RID: 162
		[Token(Token = "0x20000A2")]
		[Serializable]
		public class LimitPoint
		{
			// Token: 0x060005AB RID: 1451 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x298C740", Offset = "0x298AD40", VA = "0x18298C740")]
			public LimitPoint()
			{
			}

			// Token: 0x040004FA RID: 1274
			[Token(Token = "0x40004FA")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 point;

			// Token: 0x040004FB RID: 1275
			[Token(Token = "0x40004FB")]
			[FieldOffset(Offset = "0x1C")]
			public float tangentWeight;
		}
	}
}
