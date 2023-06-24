using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	public class LookAtController : MonoBehaviour
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x2993FB0", Offset = "0x29925B0", VA = "0x182993FB0")]
		private void Start()
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x2994080", Offset = "0x2992680", VA = "0x182994080")]
		private void LateUpdate()
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x170000A8")]
		private Vector3 pivot
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x2994E40", Offset = "0x2993440", VA = "0x182994E40")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x2995050", Offset = "0x2993650", VA = "0x182995050")]
		private void ApplyMinDistance()
		{
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x2995220", Offset = "0x2993820", VA = "0x182995220")]
		private void RootRotation()
		{
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x2995710", Offset = "0x2993D10", VA = "0x182995710")]
		public LookAtController()
		{
		}

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x20")]
		public LookAtIK ik;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		[Header("Target Smoothing")]
		public Transform target;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 offset;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Header("RootRotation")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x70")]
		private Transform lastTarget;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x78")]
		private float switchWeight;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x7C")]
		private float switchWeightV;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x80")]
		private float weightV;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 lastPosition;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 dir;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x9C")]
		private bool lastSmoothTowardsTarget;
	}
}
