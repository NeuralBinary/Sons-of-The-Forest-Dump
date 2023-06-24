using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	public class AimController : MonoBehaviour
	{
		// Token: 0x060005B4 RID: 1460 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x298D030", Offset = "0x298B630", VA = "0x18298D030")]
		private void Start()
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x298D160", Offset = "0x298B760", VA = "0x18298D160")]
		private void LateUpdate()
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x000043C4 File Offset: 0x000025C4
		[Token(Token = "0x1700009B")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x298E0E0", Offset = "0x298C6E0", VA = "0x18298E0E0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x298E2F0", Offset = "0x298C8F0", VA = "0x18298E2F0")]
		private void ApplyMinDistance()
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x298E4C0", Offset = "0x298CAC0", VA = "0x18298E4C0")]
		private void RootRotation()
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x298EA00", Offset = "0x298D000", VA = "0x18298EA00")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x298EA90", Offset = "0x298D090", VA = "0x18298EA90")]
		public AimController()
		{
		}

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		[Header("Target Smoothing")]
		public Transform target;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x6C")]
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Header("RootRotation")]
		public float maxRootAngle;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0x74")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0x78")]
		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection;

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0x7C")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x90")]
		private float switchWeight;

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x98")]
		private float weightV;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;
	}
}
