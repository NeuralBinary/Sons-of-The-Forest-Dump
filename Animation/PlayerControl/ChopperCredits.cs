using System;
using System.Collections.Generic;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Gui.Credits;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008BF RID: 2239
	[Token(Token = "0x20008BF")]
	[AddComponentMenu("Sons/Animation/ChopperCredits")]
	public class ChopperCredits : EndGameCutscene
	{
		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06003C63 RID: 15459 RVA: 0x000119D0 File Offset: 0x0000FBD0
		[Token(Token = "0x17000775")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x6003C63")]
			[Address(RVA = "0x2F12E70", Offset = "0x2F11E70", VA = "0x182F12E70", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06003C64 RID: 15460 RVA: 0x000119E8 File Offset: 0x0000FBE8
		[Token(Token = "0x17000776")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x6003C64")]
			[Address(RVA = "0x2F12ED0", Offset = "0x2F11ED0", VA = "0x182F12ED0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x00011A00 File Offset: 0x0000FC00
		[Token(Token = "0x17000777")]
		public override bool IgnoreAnimatorState
		{
			[Token(Token = "0x6003C65")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x00011A18 File Offset: 0x0000FC18
		[Token(Token = "0x6003C66")]
		[Address(RVA = "0x2F123D0", Offset = "0x2F113D0", VA = "0x182F123D0", Slot = "26")]
		internal override bool CheckIsStillPlaying()
		{
			return default(bool);
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C67")]
		[Address(RVA = "0x2F12940", Offset = "0x2F11940", VA = "0x182F12940", Slot = "5")]
		internal override void OnValidate()
		{
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C68")]
		[Address(RVA = "0x2F12D70", Offset = "0x2F11D70", VA = "0x182F12D70", Slot = "24")]
		internal override void UpdateHook()
		{
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C69")]
		[Address(RVA = "0x2F12B00", Offset = "0x2F11B00", VA = "0x182F12B00")]
		private void UpdateHelicopterMovement()
		{
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x00011A30 File Offset: 0x0000FC30
		[Token(Token = "0x6003C6A")]
		[Address(RVA = "0x2F12A30", Offset = "0x2F11A30", VA = "0x182F12A30", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C6B")]
		[Address(RVA = "0x2F12520", Offset = "0x2F11520", VA = "0x182F12520", Slot = "25")]
		internal override void LateUpdate()
		{
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C6C")]
		[Address(RVA = "0x2F12560", Offset = "0x2F11560", VA = "0x182F12560", Slot = "28")]
		internal override void OnCutsceneReady()
		{
		}

		// Token: 0x06003C6D RID: 15469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C6D")]
		[Address(RVA = "0x2F12410", Offset = "0x2F11410", VA = "0x182F12410")]
		private void CreditsEnded()
		{
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C6E")]
		[Address(RVA = "0x2F12420", Offset = "0x2F11420", VA = "0x182F12420", Slot = "29")]
		internal override void CutsceneEnded(CutsceneState obj)
		{
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C6F")]
		[Address(RVA = "0x5ADD30", Offset = "0x5ACD30", VA = "0x1805ADD30")]
		public void UpdateChopperAverageVelocity(Vector3 chopperTotalVelocity)
		{
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C70")]
		[Address(RVA = "0x2F12A90", Offset = "0x2F11A90", VA = "0x182F12A90")]
		public void UpdateChopperTransform(Transform source)
		{
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C71")]
		[Address(RVA = "0x2F12DB0", Offset = "0x2F11DB0", VA = "0x182F12DB0")]
		public ChopperCredits()
		{
		}

		// Token: 0x04004097 RID: 16535
		[Token(Token = "0x4004097")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private Animator _helicopterAnimator;

		// Token: 0x04004098 RID: 16536
		[Token(Token = "0x4004098")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private List<Transform> _helicopterTransforms;

		// Token: 0x04004099 RID: 16537
		[Token(Token = "0x4004099")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private float _helicopterClimbSpeed;

		// Token: 0x0400409A RID: 16538
		[Token(Token = "0x400409A")]
		[FieldOffset(Offset = "0x17C")]
		private Vector3 _helicopterMovement;

		// Token: 0x0400409B RID: 16539
		[Token(Token = "0x400409B")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private GameObject _creditsGameObject;

		// Token: 0x0400409C RID: 16540
		[Token(Token = "0x400409C")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private CreditsScreen _creditsComponent;

		// Token: 0x0400409D RID: 16541
		[Token(Token = "0x400409D")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Transform _reparentTarget;

		// Token: 0x0400409E RID: 16542
		[Token(Token = "0x400409E")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private List<GameObject> _reparentObjects;

		// Token: 0x0400409F RID: 16543
		[Token(Token = "0x400409F")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private List<Animator> _animators;

		// Token: 0x040040A0 RID: 16544
		[Token(Token = "0x40040A0")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private GameObject _blackScreenCutGroup;

		// Token: 0x040040A1 RID: 16545
		[Token(Token = "0x40040A1")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private float _timeout;

		// Token: 0x040040A2 RID: 16546
		[Token(Token = "0x40040A2")]
		[FieldOffset(Offset = "0x1BC")]
		private bool _creditsEnded;

		// Token: 0x040040A3 RID: 16547
		[Token(Token = "0x40040A3")]
		[FieldOffset(Offset = "0x1C0")]
		private AutoTimer _timeoutTimer;

		// Token: 0x040040A4 RID: 16548
		[Token(Token = "0x40040A4")]
		[FieldOffset(Offset = "0x1C8")]
		private Quaternion _helicopterLastRotation;

		// Token: 0x040040A5 RID: 16549
		[Token(Token = "0x40040A5")]
		[FieldOffset(Offset = "0x1D8")]
		private Vector3 _helicopterLastPosition;

		// Token: 0x040040A6 RID: 16550
		[Token(Token = "0x40040A6")]
		[FieldOffset(Offset = "0x1E4")]
		private Vector3 _helicopterOffset;

		// Token: 0x040040A7 RID: 16551
		[Token(Token = "0x40040A7")]
		[FieldOffset(Offset = "0x1F0")]
		private int _triggerQuitToTitleFrame;
	}
}
