using System;
using System.Collections;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

namespace TheForest.VR.InteractionSystem
{
	// Token: 0x020003AD RID: 941
	[Token(Token = "0x20003AD")]
	[RequireComponent(typeof(Interactable))]
	public class Longbow : MonoBehaviour
	{
		// Token: 0x060018AF RID: 6319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x5E65D0", Offset = "0x5E55D0", VA = "0x1805E65D0")]
		private void OnAttachedToHand(Hand attachedHand)
		{
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x2CCF7E0", Offset = "0x2CCE7E0", VA = "0x182CCF7E0")]
		private void Awake()
		{
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x2CD0830", Offset = "0x2CCF830", VA = "0x182CD0830")]
		private void OnEnable()
		{
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x2CD0800", Offset = "0x2CCF800", VA = "0x182CD0800")]
		private void OnDisable()
		{
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x2CD0710", Offset = "0x2CCF710", VA = "0x182CD0710")]
		private void LateUpdate()
		{
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x2CD08B0", Offset = "0x2CCF8B0", VA = "0x182CD08B0")]
		private void OnNewPosesApplied()
		{
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x2CCFAA0", Offset = "0x2CCEAA0", VA = "0x182CCFAA0")]
		private void HandAttachedUpdate(Hand hand)
		{
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x2CD0940", Offset = "0x2CCF940", VA = "0x182CD0940")]
		private void PlayBowTensionClicks(float tension)
		{
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x2CCF9D0", Offset = "0x2CCE9D0", VA = "0x182CCF9D0")]
		private static Player GetVRPlayer()
		{
			return null;
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x2CCF690", Offset = "0x2CCE690", VA = "0x182CCF690")]
		public void ArrowReleased()
		{
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x2CD0A90", Offset = "0x2CCFA90", VA = "0x182CD0A90")]
		private IEnumerator ResetDrawAnim()
		{
			return null;
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x22E98B0", Offset = "0x22E88B0", VA = "0x1822E98B0")]
		public float GetArrowVelocity()
		{
			return default(float);
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x2CD0E30", Offset = "0x2CCFE30", VA = "0x182CD0E30")]
		public void StartRotationLerp()
		{
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x2CD0CD0", Offset = "0x2CCFCD0", VA = "0x182CD0CD0")]
		public void StartNock(ArrowHand currentArrowHand)
		{
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x2CCF8F0", Offset = "0x2CCE8F0", VA = "0x182CCF8F0")]
		private void EvaluateHandedness()
		{
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x2CCF880", Offset = "0x2CCE880", VA = "0x182CCF880")]
		private void DoHandednessCheck()
		{
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x2CCF5B0", Offset = "0x2CCE5B0", VA = "0x182CCF5B0")]
		public void ArrowInPosition()
		{
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x2CD09D0", Offset = "0x2CCF9D0", VA = "0x182CD09D0")]
		public void ReleaseNock()
		{
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x2CD0B00", Offset = "0x2CCFB00", VA = "0x182CD0B00")]
		private void ShutDown()
		{
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x921FE0", Offset = "0x920FE0", VA = "0x180921FE0")]
		private void OnHandFocusLost(Hand handTarget)
		{
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x2CD0860", Offset = "0x2CCF860", VA = "0x182CD0860")]
		private void OnHandFocusAcquired(Hand handTarget)
		{
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C4")]
		[Address(RVA = "0x2CD07A0", Offset = "0x2CCF7A0", VA = "0x182CD07A0")]
		private void OnDetachedFromHand(Hand handTarget)
		{
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x2CD0790", Offset = "0x2CCF790", VA = "0x182CD0790")]
		private void OnDestroy()
		{
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x2CD0E90", Offset = "0x2CCFE90", VA = "0x182CD0E90")]
		public Longbow()
		{
		}

		// Token: 0x0400184A RID: 6218
		[Token(Token = "0x400184A")]
		[FieldOffset(Offset = "0x20")]
		public Longbow.Handedness currentHandGuess;

		// Token: 0x0400184B RID: 6219
		[Token(Token = "0x400184B")]
		[FieldOffset(Offset = "0x24")]
		private float timeOfPossibleHandSwitch;

		// Token: 0x0400184C RID: 6220
		[Token(Token = "0x400184C")]
		[FieldOffset(Offset = "0x28")]
		private float timeBeforeConfirmingHandSwitch;

		// Token: 0x0400184D RID: 6221
		[Token(Token = "0x400184D")]
		[FieldOffset(Offset = "0x2C")]
		private bool possibleHandSwitch;

		// Token: 0x0400184E RID: 6222
		[Token(Token = "0x400184E")]
		[FieldOffset(Offset = "0x30")]
		public Transform bowFollowTransform;

		// Token: 0x0400184F RID: 6223
		[Token(Token = "0x400184F")]
		[FieldOffset(Offset = "0x38")]
		public Transform pivotTransform;

		// Token: 0x04001850 RID: 6224
		[Token(Token = "0x4001850")]
		[FieldOffset(Offset = "0x40")]
		public Transform handleTransform;

		// Token: 0x04001851 RID: 6225
		[Token(Token = "0x4001851")]
		[FieldOffset(Offset = "0x48")]
		private Hand hand;

		// Token: 0x04001852 RID: 6226
		[Token(Token = "0x4001852")]
		[FieldOffset(Offset = "0x50")]
		public ArrowHand arrowHand;

		// Token: 0x04001853 RID: 6227
		[Token(Token = "0x4001853")]
		[FieldOffset(Offset = "0x58")]
		public Transform nockTransform;

		// Token: 0x04001854 RID: 6228
		[Token(Token = "0x4001854")]
		[FieldOffset(Offset = "0x60")]
		public Transform nockRestTransform;

		// Token: 0x04001855 RID: 6229
		[Token(Token = "0x4001855")]
		[FieldOffset(Offset = "0x68")]
		public bool autoSpawnArrowHand;

		// Token: 0x04001856 RID: 6230
		[Token(Token = "0x4001856")]
		[FieldOffset(Offset = "0x70")]
		public ItemPackage arrowHandItemPackage;

		// Token: 0x04001857 RID: 6231
		[Token(Token = "0x4001857")]
		[FieldOffset(Offset = "0x78")]
		public GameObject arrowHandPrefab;

		// Token: 0x04001858 RID: 6232
		[Token(Token = "0x4001858")]
		[FieldOffset(Offset = "0x80")]
		public bool nocked;

		// Token: 0x04001859 RID: 6233
		[Token(Token = "0x4001859")]
		[FieldOffset(Offset = "0x81")]
		public bool pulled;

		// Token: 0x0400185A RID: 6234
		[Token(Token = "0x400185A")]
		[FieldOffset(Offset = "0x84")]
		public float minPull;

		// Token: 0x0400185B RID: 6235
		[Token(Token = "0x400185B")]
		[FieldOffset(Offset = "0x88")]
		public float maxPull;

		// Token: 0x0400185C RID: 6236
		[Token(Token = "0x400185C")]
		[FieldOffset(Offset = "0x8C")]
		private float nockDistanceTravelled;

		// Token: 0x0400185D RID: 6237
		[Token(Token = "0x400185D")]
		[FieldOffset(Offset = "0x90")]
		private float hapticDistanceThreshold;

		// Token: 0x0400185E RID: 6238
		[Token(Token = "0x400185E")]
		[FieldOffset(Offset = "0x94")]
		private float lastTickDistance;

		// Token: 0x0400185F RID: 6239
		[Token(Token = "0x400185F")]
		private const float bowPullPulseStrengthLow = 100f;

		// Token: 0x04001860 RID: 6240
		[Token(Token = "0x4001860")]
		private const float bowPullPulseStrengthHigh = 500f;

		// Token: 0x04001861 RID: 6241
		[Token(Token = "0x4001861")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 bowLeftVector;

		// Token: 0x04001862 RID: 6242
		[Token(Token = "0x4001862")]
		[FieldOffset(Offset = "0xA4")]
		public float arrowMinVelocity;

		// Token: 0x04001863 RID: 6243
		[Token(Token = "0x4001863")]
		[FieldOffset(Offset = "0xA8")]
		public float arrowMaxVelocity;

		// Token: 0x04001864 RID: 6244
		[Token(Token = "0x4001864")]
		[FieldOffset(Offset = "0xAC")]
		private float arrowVelocity;

		// Token: 0x04001865 RID: 6245
		[Token(Token = "0x4001865")]
		[FieldOffset(Offset = "0xB0")]
		private float minStrainTickTime;

		// Token: 0x04001866 RID: 6246
		[Token(Token = "0x4001866")]
		[FieldOffset(Offset = "0xB4")]
		private float maxStrainTickTime;

		// Token: 0x04001867 RID: 6247
		[Token(Token = "0x4001867")]
		[FieldOffset(Offset = "0xB8")]
		private float nextStrainTick;

		// Token: 0x04001868 RID: 6248
		[Token(Token = "0x4001868")]
		[FieldOffset(Offset = "0xBC")]
		private bool lerpBackToZeroRotation;

		// Token: 0x04001869 RID: 6249
		[Token(Token = "0x4001869")]
		[FieldOffset(Offset = "0xC0")]
		private float lerpStartTime;

		// Token: 0x0400186A RID: 6250
		[Token(Token = "0x400186A")]
		[FieldOffset(Offset = "0xC4")]
		private float lerpDuration;

		// Token: 0x0400186B RID: 6251
		[Token(Token = "0x400186B")]
		[FieldOffset(Offset = "0xC8")]
		private Quaternion lerpStartRotation;

		// Token: 0x0400186C RID: 6252
		[Token(Token = "0x400186C")]
		[FieldOffset(Offset = "0xD8")]
		private float nockLerpStartTime;

		// Token: 0x0400186D RID: 6253
		[Token(Token = "0x400186D")]
		[FieldOffset(Offset = "0xDC")]
		private Quaternion nockLerpStartRotation;

		// Token: 0x0400186E RID: 6254
		[Token(Token = "0x400186E")]
		[FieldOffset(Offset = "0xEC")]
		public float drawOffset;

		// Token: 0x0400186F RID: 6255
		[Token(Token = "0x400186F")]
		[FieldOffset(Offset = "0xF0")]
		public bool useCustomScale;

		// Token: 0x04001870 RID: 6256
		[Token(Token = "0x4001870")]
		[FieldOffset(Offset = "0xF8")]
		public LinearMapping bowDrawLinearMapping;

		// Token: 0x04001871 RID: 6257
		[Token(Token = "0x4001871")]
		[FieldOffset(Offset = "0x100")]
		private bool deferNewPoses;

		// Token: 0x04001872 RID: 6258
		[Token(Token = "0x4001872")]
		[FieldOffset(Offset = "0x104")]
		private Vector3 lateUpdatePos;

		// Token: 0x04001873 RID: 6259
		[Token(Token = "0x4001873")]
		[FieldOffset(Offset = "0x110")]
		private Quaternion lateUpdateRot;

		// Token: 0x04001874 RID: 6260
		[Token(Token = "0x4001874")]
		[FieldOffset(Offset = "0x120")]
		[CanBeNull]
		public SoundBowClick drawSound;

		// Token: 0x04001875 RID: 6261
		[Token(Token = "0x4001875")]
		[FieldOffset(Offset = "0x128")]
		private float drawTension;

		// Token: 0x04001876 RID: 6262
		[Token(Token = "0x4001876")]
		[FieldOffset(Offset = "0x130")]
		[CanBeNull]
		public SoundPlayOneshot arrowSlideSound;

		// Token: 0x04001877 RID: 6263
		[Token(Token = "0x4001877")]
		[FieldOffset(Offset = "0x138")]
		[CanBeNull]
		public SoundPlayOneshot releaseSound;

		// Token: 0x04001878 RID: 6264
		[Token(Token = "0x4001878")]
		[FieldOffset(Offset = "0x140")]
		[CanBeNull]
		public SoundPlayOneshot nockSound;

		// Token: 0x04001879 RID: 6265
		[Token(Token = "0x4001879")]
		[FieldOffset(Offset = "0x148")]
		private SteamVR_Events.Action newPosesAppliedAction;

		// Token: 0x020003AE RID: 942
		[Token(Token = "0x20003AE")]
		public enum Handedness
		{
			// Token: 0x0400187B RID: 6267
			[Token(Token = "0x400187B")]
			Left,
			// Token: 0x0400187C RID: 6268
			[Token(Token = "0x400187C")]
			Right
		}
	}
}
