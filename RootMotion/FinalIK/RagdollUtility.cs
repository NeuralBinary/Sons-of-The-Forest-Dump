using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	[RequireComponent(typeof(Animator))]
	public class RagdollUtility : MonoBehaviour
	{
		// Token: 0x06000557 RID: 1367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x2983D80", Offset = "0x2982380", VA = "0x182983D80")]
		public void EnableRagdoll()
		{
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x2983DE0", Offset = "0x29823E0", VA = "0x182983DE0")]
		public void DisableRagdoll()
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x2983EF0", Offset = "0x29824F0", VA = "0x182983EF0")]
		public void Start()
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x2984A00", Offset = "0x2983000", VA = "0x182984A00")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x2984A90", Offset = "0x2983090", VA = "0x182984A90")]
		private void Update()
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2984DB0", Offset = "0x29833B0", VA = "0x182984DB0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x2984DF0", Offset = "0x29833F0", VA = "0x182984DF0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2984F30", Offset = "0x2983530", VA = "0x182984F30")]
		private void AfterLastIK()
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2984F80", Offset = "0x2983580", VA = "0x182984F80")]
		private void AfterAnimation()
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2984FC0", Offset = "0x29835C0", VA = "0x182984FC0")]
		private void OnFinalPose()
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2985000", Offset = "0x2983600", VA = "0x182985000")]
		private void RagdollEnabler()
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00004124 File Offset: 0x00002324
		[Token(Token = "0x1700008F")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x2985370", Offset = "0x2983970", VA = "0x182985370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x2985460", Offset = "0x2983A60", VA = "0x182985460")]
		private void RecordVelocities()
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0000413C File Offset: 0x0000233C
		[Token(Token = "0x17000090")]
		private bool ikUsed
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x2985940", Offset = "0x2983F40", VA = "0x182985940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x2985B60", Offset = "0x2984160", VA = "0x182985B60")]
		private void StoreLocalState()
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2985CB0", Offset = "0x29842B0", VA = "0x182985CB0")]
		private void FixTransforms(float weight)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2986060", Offset = "0x2984660", VA = "0x182986060")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x2986250", Offset = "0x2984850", VA = "0x182986250")]
		public RagdollUtility()
		{
		}

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x38")]
		private Animator animator;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x40")]
		private RagdollUtility.Rigidbone[] rigidbones;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x48")]
		private RagdollUtility.Child[] children;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x50")]
		private bool enableRagdollFlag;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x54")]
		private AnimatorUpdateMode animatorUpdateMode;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x58")]
		private IK[] allIKComponents;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x60")]
		private bool[] fixTransforms;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x68")]
		private float ragdollWeight;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x6C")]
		private float ragdollWeightV;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x70")]
		private bool fixedFrame;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x78")]
		private bool[] disabledIKComponents;

		// Token: 0x0200009A RID: 154
		[Token(Token = "0x200009A")]
		public class Rigidbone
		{
			// Token: 0x06000569 RID: 1385 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x29864E0", Offset = "0x2984AE0", VA = "0x1829864E0")]
			public Rigidbone(Rigidbody r)
			{
			}

			// Token: 0x0600056A RID: 1386 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x29869D0", Offset = "0x2984FD0", VA = "0x1829869D0")]
			public void RecordVelocity()
			{
			}

			// Token: 0x0600056B RID: 1387 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x2986C50", Offset = "0x2985250", VA = "0x182986C50")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}

			// Token: 0x040004D2 RID: 1234
			[Token(Token = "0x40004D2")]
			[FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			// Token: 0x040004D3 RID: 1235
			[Token(Token = "0x40004D3")]
			[FieldOffset(Offset = "0x18")]
			public Transform t;

			// Token: 0x040004D4 RID: 1236
			[Token(Token = "0x40004D4")]
			[FieldOffset(Offset = "0x20")]
			public Collider collider;

			// Token: 0x040004D5 RID: 1237
			[Token(Token = "0x40004D5")]
			[FieldOffset(Offset = "0x28")]
			public Joint joint;

			// Token: 0x040004D6 RID: 1238
			[Token(Token = "0x40004D6")]
			[FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			// Token: 0x040004D7 RID: 1239
			[Token(Token = "0x40004D7")]
			[FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			// Token: 0x040004D8 RID: 1240
			[Token(Token = "0x40004D8")]
			[FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			// Token: 0x040004D9 RID: 1241
			[Token(Token = "0x40004D9")]
			[FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			// Token: 0x040004DA RID: 1242
			[Token(Token = "0x40004DA")]
			[FieldOffset(Offset = "0x58")]
			public float deltaTime;

			// Token: 0x040004DB RID: 1243
			[Token(Token = "0x40004DB")]
			[FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			// Token: 0x040004DC RID: 1244
			[Token(Token = "0x40004DC")]
			[FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;
		}

		// Token: 0x0200009B RID: 155
		[Token(Token = "0x200009B")]
		public class Child
		{
			// Token: 0x0600056C RID: 1388 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x2987120", Offset = "0x2985720", VA = "0x182987120")]
			public Child(Transform transform)
			{
			}

			// Token: 0x0600056D RID: 1389 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x2987270", Offset = "0x2985870", VA = "0x182987270")]
			public void FixTransform(float weight)
			{
			}

			// Token: 0x0600056E RID: 1390 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x29875C0", Offset = "0x2985BC0", VA = "0x1829875C0")]
			public void StoreLocalState()
			{
			}

			// Token: 0x040004DD RID: 1245
			[Token(Token = "0x40004DD")]
			[FieldOffset(Offset = "0x10")]
			public Transform t;

			// Token: 0x040004DE RID: 1246
			[Token(Token = "0x40004DE")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			// Token: 0x040004DF RID: 1247
			[Token(Token = "0x40004DF")]
			[FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;
		}
	}
}
