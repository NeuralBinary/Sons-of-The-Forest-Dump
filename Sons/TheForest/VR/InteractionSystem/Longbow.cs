using System;
using System.Collections;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

namespace TheForest.VR.InteractionSystem
{
	// Token: 0x0200039F RID: 927
	[Token(Token = "0x200039F")]
	[RequireComponent(typeof(Interactable))]
	public class Longbow : MonoBehaviour
	{
		// Token: 0x060018EA RID: 6378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
		private void OnAttachedToHand(Hand attachedHand)
		{
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x328AEE0", Offset = "0x32894E0", VA = "0x18328AEE0")]
		private void Awake()
		{
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x328B040", Offset = "0x3289640", VA = "0x18328B040")]
		private void OnEnable()
		{
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x328B070", Offset = "0x3289670", VA = "0x18328B070")]
		private void OnDisable()
		{
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x328B0A0", Offset = "0x32896A0", VA = "0x18328B0A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x328B230", Offset = "0x3289830", VA = "0x18328B230")]
		private void OnNewPosesApplied()
		{
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x328B3C0", Offset = "0x32899C0", VA = "0x18328B3C0")]
		private void HandAttachedUpdate(Hand hand)
		{
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x328C760", Offset = "0x328AD60", VA = "0x18328C760")]
		private void PlayBowTensionClicks(float tension)
		{
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x328C850", Offset = "0x328AE50", VA = "0x18328C850")]
		private static Player GetVRPlayer()
		{
			return null;
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F3")]
		[Address(RVA = "0x328C9C0", Offset = "0x328AFC0", VA = "0x18328C9C0")]
		public void ArrowReleased()
		{
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x328CB30", Offset = "0x328B130", VA = "0x18328CB30")]
		private IEnumerator ResetDrawAnim()
		{
			return null;
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00007A40 File Offset: 0x00005C40
		[Token(Token = "0x60018F5")]
		[Address(RVA = "0x2739890", Offset = "0x2737E90", VA = "0x182739890")]
		public float GetArrowVelocity()
		{
			return 0f;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F6")]
		[Address(RVA = "0x328CBC0", Offset = "0x328B1C0", VA = "0x18328CBC0")]
		public void StartRotationLerp()
		{
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F7")]
		[Address(RVA = "0x328CCA0", Offset = "0x328B2A0", VA = "0x18328CCA0")]
		public void StartNock(ArrowHand currentArrowHand)
		{
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F8")]
		[Address(RVA = "0x328CEC0", Offset = "0x328B4C0", VA = "0x18328CEC0")]
		private void EvaluateHandedness()
		{
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F9")]
		[Address(RVA = "0x328D010", Offset = "0x328B610", VA = "0x18328D010")]
		private void DoHandednessCheck()
		{
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x328D110", Offset = "0x328B710", VA = "0x18328D110")]
		public void ArrowInPosition()
		{
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x328D200", Offset = "0x328B800", VA = "0x18328D200")]
		public void ReleaseNock()
		{
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x328D280", Offset = "0x328B880", VA = "0x18328D280")]
		private void ShutDown()
		{
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0xA71C70", Offset = "0xA70270", VA = "0x180A71C70")]
		private void OnHandFocusLost(Hand handTarget)
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x328D610", Offset = "0x328BC10", VA = "0x18328D610")]
		private void OnHandFocusAcquired(Hand handTarget)
		{
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x328D720", Offset = "0x328BD20", VA = "0x18328D720")]
		private void OnDetachedFromHand(Hand handTarget)
		{
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001900")]
		[Address(RVA = "0x328D7B0", Offset = "0x328BDB0", VA = "0x18328D7B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001901")]
		[Address(RVA = "0x328D7C0", Offset = "0x328BDC0", VA = "0x18328D7C0")]
		public Longbow()
		{
		}

		// Token: 0x04001869 RID: 6249
		[Token(Token = "0x4001869")]
		[FieldOffset(Offset = "0x20")]
		public Longbow.Handedness currentHandGuess;

		// Token: 0x0400186A RID: 6250
		[Token(Token = "0x400186A")]
		[FieldOffset(Offset = "0x24")]
		private float timeOfPossibleHandSwitch;

		// Token: 0x0400186B RID: 6251
		[Token(Token = "0x400186B")]
		[FieldOffset(Offset = "0x28")]
		private float timeBeforeConfirmingHandSwitch;

		// Token: 0x0400186C RID: 6252
		[Token(Token = "0x400186C")]
		[FieldOffset(Offset = "0x2C")]
		private bool possibleHandSwitch;

		// Token: 0x0400186D RID: 6253
		[Token(Token = "0x400186D")]
		[FieldOffset(Offset = "0x30")]
		public Transform bowFollowTransform;

		// Token: 0x0400186E RID: 6254
		[Token(Token = "0x400186E")]
		[FieldOffset(Offset = "0x38")]
		public Transform pivotTransform;

		// Token: 0x0400186F RID: 6255
		[Token(Token = "0x400186F")]
		[FieldOffset(Offset = "0x40")]
		public Transform handleTransform;

		// Token: 0x04001870 RID: 6256
		[Token(Token = "0x4001870")]
		[FieldOffset(Offset = "0x48")]
		private Hand hand;

		// Token: 0x04001871 RID: 6257
		[Token(Token = "0x4001871")]
		[FieldOffset(Offset = "0x50")]
		public ArrowHand arrowHand;

		// Token: 0x04001872 RID: 6258
		[Token(Token = "0x4001872")]
		[FieldOffset(Offset = "0x58")]
		public Transform nockTransform;

		// Token: 0x04001873 RID: 6259
		[Token(Token = "0x4001873")]
		[FieldOffset(Offset = "0x60")]
		public Transform nockRestTransform;

		// Token: 0x04001874 RID: 6260
		[Token(Token = "0x4001874")]
		[FieldOffset(Offset = "0x68")]
		public bool autoSpawnArrowHand;

		// Token: 0x04001875 RID: 6261
		[Token(Token = "0x4001875")]
		[FieldOffset(Offset = "0x70")]
		public ItemPackage arrowHandItemPackage;

		// Token: 0x04001876 RID: 6262
		[Token(Token = "0x4001876")]
		[FieldOffset(Offset = "0x78")]
		public GameObject arrowHandPrefab;

		// Token: 0x04001877 RID: 6263
		[Token(Token = "0x4001877")]
		[FieldOffset(Offset = "0x80")]
		public bool nocked;

		// Token: 0x04001878 RID: 6264
		[Token(Token = "0x4001878")]
		[FieldOffset(Offset = "0x81")]
		public bool pulled;

		// Token: 0x04001879 RID: 6265
		[Token(Token = "0x4001879")]
		[FieldOffset(Offset = "0x84")]
		public float minPull;

		// Token: 0x0400187A RID: 6266
		[Token(Token = "0x400187A")]
		[FieldOffset(Offset = "0x88")]
		public float maxPull;

		// Token: 0x0400187B RID: 6267
		[Token(Token = "0x400187B")]
		[FieldOffset(Offset = "0x8C")]
		private float nockDistanceTravelled;

		// Token: 0x0400187C RID: 6268
		[Token(Token = "0x400187C")]
		[FieldOffset(Offset = "0x90")]
		private float hapticDistanceThreshold;

		// Token: 0x0400187D RID: 6269
		[Token(Token = "0x400187D")]
		[FieldOffset(Offset = "0x94")]
		private float lastTickDistance;

		// Token: 0x0400187E RID: 6270
		[Token(Token = "0x400187E")]
		private const float bowPullPulseStrengthLow = 100f;

		// Token: 0x0400187F RID: 6271
		[Token(Token = "0x400187F")]
		private const float bowPullPulseStrengthHigh = 500f;

		// Token: 0x04001880 RID: 6272
		[Token(Token = "0x4001880")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 bowLeftVector;

		// Token: 0x04001881 RID: 6273
		[Token(Token = "0x4001881")]
		[FieldOffset(Offset = "0xA4")]
		public float arrowMinVelocity;

		// Token: 0x04001882 RID: 6274
		[Token(Token = "0x4001882")]
		[FieldOffset(Offset = "0xA8")]
		public float arrowMaxVelocity;

		// Token: 0x04001883 RID: 6275
		[Token(Token = "0x4001883")]
		[FieldOffset(Offset = "0xAC")]
		private float arrowVelocity;

		// Token: 0x04001884 RID: 6276
		[Token(Token = "0x4001884")]
		[FieldOffset(Offset = "0xB0")]
		private float minStrainTickTime;

		// Token: 0x04001885 RID: 6277
		[Token(Token = "0x4001885")]
		[FieldOffset(Offset = "0xB4")]
		private float maxStrainTickTime;

		// Token: 0x04001886 RID: 6278
		[Token(Token = "0x4001886")]
		[FieldOffset(Offset = "0xB8")]
		private float nextStrainTick;

		// Token: 0x04001887 RID: 6279
		[Token(Token = "0x4001887")]
		[FieldOffset(Offset = "0xBC")]
		private bool lerpBackToZeroRotation;

		// Token: 0x04001888 RID: 6280
		[Token(Token = "0x4001888")]
		[FieldOffset(Offset = "0xC0")]
		private float lerpStartTime;

		// Token: 0x04001889 RID: 6281
		[Token(Token = "0x4001889")]
		[FieldOffset(Offset = "0xC4")]
		private float lerpDuration;

		// Token: 0x0400188A RID: 6282
		[Token(Token = "0x400188A")]
		[FieldOffset(Offset = "0xC8")]
		private Quaternion lerpStartRotation;

		// Token: 0x0400188B RID: 6283
		[Token(Token = "0x400188B")]
		[FieldOffset(Offset = "0xD8")]
		private float nockLerpStartTime;

		// Token: 0x0400188C RID: 6284
		[Token(Token = "0x400188C")]
		[FieldOffset(Offset = "0xDC")]
		private Quaternion nockLerpStartRotation;

		// Token: 0x0400188D RID: 6285
		[Token(Token = "0x400188D")]
		[FieldOffset(Offset = "0xEC")]
		public float drawOffset;

		// Token: 0x0400188E RID: 6286
		[Token(Token = "0x400188E")]
		[FieldOffset(Offset = "0xF0")]
		public bool useCustomScale;

		// Token: 0x0400188F RID: 6287
		[Token(Token = "0x400188F")]
		[FieldOffset(Offset = "0xF8")]
		public LinearMapping bowDrawLinearMapping;

		// Token: 0x04001890 RID: 6288
		[Token(Token = "0x4001890")]
		[FieldOffset(Offset = "0x100")]
		private bool deferNewPoses;

		// Token: 0x04001891 RID: 6289
		[Token(Token = "0x4001891")]
		[FieldOffset(Offset = "0x104")]
		private Vector3 lateUpdatePos;

		// Token: 0x04001892 RID: 6290
		[Token(Token = "0x4001892")]
		[FieldOffset(Offset = "0x110")]
		private Quaternion lateUpdateRot;

		// Token: 0x04001893 RID: 6291
		[Token(Token = "0x4001893")]
		[FieldOffset(Offset = "0x120")]
		[CanBeNull]
		public SoundBowClick drawSound;

		// Token: 0x04001894 RID: 6292
		[Token(Token = "0x4001894")]
		[FieldOffset(Offset = "0x128")]
		private float drawTension;

		// Token: 0x04001895 RID: 6293
		[Token(Token = "0x4001895")]
		[FieldOffset(Offset = "0x130")]
		[CanBeNull]
		public SoundPlayOneshot arrowSlideSound;

		// Token: 0x04001896 RID: 6294
		[Token(Token = "0x4001896")]
		[FieldOffset(Offset = "0x138")]
		[CanBeNull]
		public SoundPlayOneshot releaseSound;

		// Token: 0x04001897 RID: 6295
		[Token(Token = "0x4001897")]
		[FieldOffset(Offset = "0x140")]
		[CanBeNull]
		public SoundPlayOneshot nockSound;

		// Token: 0x04001898 RID: 6296
		[Token(Token = "0x4001898")]
		[FieldOffset(Offset = "0x148")]
		private SteamVR_Events.Action newPosesAppliedAction;

		// Token: 0x020003A0 RID: 928
		[Token(Token = "0x20003A0")]
		public enum Handedness
		{
			// Token: 0x0400189A RID: 6298
			[Token(Token = "0x400189A")]
			Left,
			// Token: 0x0400189B RID: 6299
			[Token(Token = "0x400189B")]
			Right
		}
	}
}
