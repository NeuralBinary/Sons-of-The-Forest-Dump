using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace RootMotion.Demos
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	[Serializable]
	public class Navigator
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00004694 File Offset: 0x00002894
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B5")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x29A2980", Offset = "0x29A0F80", VA = "0x1829A2980")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x29A29A0", Offset = "0x29A0FA0", VA = "0x1829A29A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000046AC File Offset: 0x000028AC
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B6")]
		public Navigator.State state
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			[CompilerGenerated]
			get
			{
				return Navigator.State.Idle;
			}
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x29A29B0", Offset = "0x29A0FB0", VA = "0x1829A29B0")]
		public void Initiate(Transform transform)
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x29A2B90", Offset = "0x29A1190", VA = "0x1829A2B90")]
		public void Update(Vector3 targetPosition)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x29A2FF0", Offset = "0x29A15F0", VA = "0x1829A2FF0")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000046C4 File Offset: 0x000028C4
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x29A30D0", Offset = "0x29A16D0", VA = "0x1829A30D0")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x29A3380", Offset = "0x29A1980", VA = "0x1829A3380")]
		private void Stop()
		{
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000046DC File Offset: 0x000028DC
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x29A33D0", Offset = "0x29A19D0", VA = "0x1829A33D0")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return 0f;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x29A3400", Offset = "0x29A1A00", VA = "0x1829A3400")]
		public void Visualize()
		{
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x29A3830", Offset = "0x29A1E30", VA = "0x1829A3830")]
		public Navigator()
		{
		}

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x38")]
		private Transform transform;

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x64")]
		private bool initiated;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		// Token: 0x020000D5 RID: 213
		[Token(Token = "0x20000D5")]
		public enum State
		{
			// Token: 0x0400061B RID: 1563
			[Token(Token = "0x400061B")]
			Idle,
			// Token: 0x0400061C RID: 1564
			[Token(Token = "0x400061C")]
			Seeking,
			// Token: 0x0400061D RID: 1565
			[Token(Token = "0x400061D")]
			OnPath
		}
	}
}
