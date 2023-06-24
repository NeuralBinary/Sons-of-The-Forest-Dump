using System;
using System.Collections.Generic;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Gui.Credits;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000934 RID: 2356
	[Token(Token = "0x2000934")]
	[AddComponentMenu("Sons/Animation/ChopperCredits")]
	public class ChopperCredits : EndGameCutscene
	{
		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x060043B8 RID: 17336 RVA: 0x00014940 File Offset: 0x00012B40
		[Token(Token = "0x170008A3")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x60043B8")]
			[Address(RVA = "0x3649C70", Offset = "0x3648270", VA = "0x183649C70", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x060043B9 RID: 17337 RVA: 0x00014958 File Offset: 0x00012B58
		[Token(Token = "0x170008A4")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x60043B9")]
			[Address(RVA = "0x3649CD0", Offset = "0x36482D0", VA = "0x183649CD0", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x060043BA RID: 17338 RVA: 0x00014970 File Offset: 0x00012B70
		[Token(Token = "0x170008A5")]
		public override bool IgnoreAnimatorState
		{
			[Token(Token = "0x60043BA")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00014988 File Offset: 0x00012B88
		[Token(Token = "0x60043BB")]
		[Address(RVA = "0x3649D30", Offset = "0x3648330", VA = "0x183649D30", Slot = "29")]
		internal override bool CheckIsStillPlaying()
		{
			return default(bool);
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BC")]
		[Address(RVA = "0x3649D70", Offset = "0x3648370", VA = "0x183649D70", Slot = "5")]
		internal override void OnValidate()
		{
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BD")]
		[Address(RVA = "0x3649F50", Offset = "0x3648550", VA = "0x183649F50", Slot = "27")]
		internal override void UpdateHook()
		{
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BE")]
		[Address(RVA = "0x3649F70", Offset = "0x3648570", VA = "0x183649F70")]
		private void UpdateHelicopterMovement()
		{
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x000149A0 File Offset: 0x00012BA0
		[Token(Token = "0x60043BF")]
		[Address(RVA = "0x364A2D0", Offset = "0x36488D0", VA = "0x18364A2D0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C0")]
		[Address(RVA = "0x364A310", Offset = "0x3648910", VA = "0x18364A310", Slot = "28")]
		internal override void LateUpdate()
		{
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C1")]
		[Address(RVA = "0x364A3D0", Offset = "0x36489D0", VA = "0x18364A3D0", Slot = "31")]
		internal override void OnCutsceneReady()
		{
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C2")]
		[Address(RVA = "0x364AA80", Offset = "0x3649080", VA = "0x18364AA80")]
		private void CreditsEnded()
		{
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C3")]
		[Address(RVA = "0x364AA90", Offset = "0x3649090", VA = "0x18364AA90", Slot = "32")]
		internal override void CutsceneEnded(CutsceneState obj)
		{
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C4")]
		[Address(RVA = "0x364ABD0", Offset = "0x36491D0", VA = "0x18364ABD0")]
		public void UpdateChopperAverageVelocity(Vector3 chopperTotalVelocity)
		{
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C5")]
		[Address(RVA = "0x364ABF0", Offset = "0x36491F0", VA = "0x18364ABF0")]
		public void UpdateChopperTransform(Transform source)
		{
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C6")]
		[Address(RVA = "0x364ACE0", Offset = "0x36492E0", VA = "0x18364ACE0")]
		public ChopperCredits()
		{
		}

		// Token: 0x040046DD RID: 18141
		[Token(Token = "0x40046DD")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Animator _helicopterAnimator;

		// Token: 0x040046DE RID: 18142
		[Token(Token = "0x40046DE")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private List<Transform> _helicopterTransforms;

		// Token: 0x040046DF RID: 18143
		[Token(Token = "0x40046DF")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private float _helicopterClimbSpeed;

		// Token: 0x040046E0 RID: 18144
		[Token(Token = "0x40046E0")]
		[FieldOffset(Offset = "0x194")]
		private Vector3 _helicopterMovement;

		// Token: 0x040046E1 RID: 18145
		[Token(Token = "0x40046E1")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private GameObject _creditsGameObject;

		// Token: 0x040046E2 RID: 18146
		[Token(Token = "0x40046E2")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private CreditsScreen _creditsComponent;

		// Token: 0x040046E3 RID: 18147
		[Token(Token = "0x40046E3")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Transform _reparentTarget;

		// Token: 0x040046E4 RID: 18148
		[Token(Token = "0x40046E4")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private List<GameObject> _reparentObjects;

		// Token: 0x040046E5 RID: 18149
		[Token(Token = "0x40046E5")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private List<Animator> _animators;

		// Token: 0x040046E6 RID: 18150
		[Token(Token = "0x40046E6")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private GameObject _blackScreenCutGroup;

		// Token: 0x040046E7 RID: 18151
		[Token(Token = "0x40046E7")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private float _timeout;

		// Token: 0x040046E8 RID: 18152
		[Token(Token = "0x40046E8")]
		[FieldOffset(Offset = "0x1D4")]
		private bool _creditsEnded;

		// Token: 0x040046E9 RID: 18153
		[Token(Token = "0x40046E9")]
		[FieldOffset(Offset = "0x1D8")]
		private AutoTimer _timeoutTimer;

		// Token: 0x040046EA RID: 18154
		[Token(Token = "0x40046EA")]
		[FieldOffset(Offset = "0x1E0")]
		private Quaternion _helicopterLastRotation;

		// Token: 0x040046EB RID: 18155
		[Token(Token = "0x40046EB")]
		[FieldOffset(Offset = "0x1F0")]
		private Vector3 _helicopterLastPosition;

		// Token: 0x040046EC RID: 18156
		[Token(Token = "0x40046EC")]
		[FieldOffset(Offset = "0x1FC")]
		private Vector3 _helicopterOffset;

		// Token: 0x040046ED RID: 18157
		[Token(Token = "0x40046ED")]
		[FieldOffset(Offset = "0x208")]
		private int _triggerQuitToTitleFrame;
	}
}
