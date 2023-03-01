using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Animation;
using Il2CppDummyDll;
using Sons.Cutscenes;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008C1 RID: 2241
	[Token(Token = "0x20008C1")]
	[AddComponentMenu("Sons/Animation/ChopperGroupLeaveIsland")]
	public class ChopperGroupLeaveIsland : EndGameCutscene
	{
		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06003C79 RID: 15481 RVA: 0x00011AC0 File Offset: 0x0000FCC0
		[Token(Token = "0x1700077C")]
		public int VirginiaMissingBoolHash
		{
			[Token(Token = "0x6003C79")]
			[Address(RVA = "0x2F144E0", Offset = "0x2F134E0", VA = "0x182F144E0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06003C7A RID: 15482 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		[Token(Token = "0x1700077D")]
		public override bool HandlePlayerAnimationMoveEvents
		{
			[Token(Token = "0x6003C7A")]
			[Address(RVA = "0x2F144B0", Offset = "0x2F134B0", VA = "0x182F144B0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06003C7B RID: 15483 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		[Token(Token = "0x1700077E")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x6003C7B")]
			[Address(RVA = "0x2F144C0", Offset = "0x2F134C0", VA = "0x182F144C0", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06003C7C RID: 15484 RVA: 0x00011B08 File Offset: 0x0000FD08
		[Token(Token = "0x1700077F")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x6003C7C")]
			[Address(RVA = "0x2F144D0", Offset = "0x2F134D0", VA = "0x182F144D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C7D")]
		[Address(RVA = "0x2F13920", Offset = "0x2F12920", VA = "0x182F13920", Slot = "28")]
		internal override void OnCutsceneReady()
		{
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C7E")]
		[Address(RVA = "0x2F13EE0", Offset = "0x2F12EE0", VA = "0x182F13EE0")]
		private void SetupCutsceneHashes()
		{
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C7F")]
		[Address(RVA = "0x2F133B0", Offset = "0x2F123B0", VA = "0x182F133B0", Slot = "29")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C80")]
		[Address(RVA = "0x2F136B0", Offset = "0x2F126B0", VA = "0x182F136B0", Slot = "25")]
		internal override void LateUpdate()
		{
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x00011B20 File Offset: 0x0000FD20
		[Token(Token = "0x6003C81")]
		[Address(RVA = "0x2F136A0", Offset = "0x2F126A0", VA = "0x182F136A0")]
		private float GetPlayerHelicopterConstraintTime()
		{
			return default(float);
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C82")]
		[Address(RVA = "0x2F13EB0", Offset = "0x2F12EB0", VA = "0x182F13EB0", Slot = "23")]
		internal override void OnNormalizedTimeChanged(float value)
		{
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C83")]
		[Address(RVA = "0x2F140F0", Offset = "0x2F130F0", VA = "0x182F140F0")]
		private void UpdateChopperTransform()
		{
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C84")]
		[Address(RVA = "0x2F14310", Offset = "0x2F13310", VA = "0x182F14310")]
		public ChopperGroupLeaveIsland()
		{
		}

		// Token: 0x040040AA RID: 16554
		[Token(Token = "0x40040AA")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private GameObject _robbyRoot;

		// Token: 0x040040AB RID: 16555
		[Token(Token = "0x40040AB")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject _virginiaRoot;

		// Token: 0x040040AC RID: 16556
		[Token(Token = "0x40040AC")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private GameObject _chopperRoot;

		// Token: 0x040040AD RID: 16557
		[Token(Token = "0x40040AD")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Transform _chopperSampleTransform;

		// Token: 0x040040AE RID: 16558
		[Token(Token = "0x40040AE")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Transform _playerHelicopterConstraintTransform;

		// Token: 0x040040AF RID: 16559
		[Token(Token = "0x40040AF")]
		[FieldOffset(Offset = "0x190")]
		[FormerlySerializedAs("_playerHelicopterConstraintTime")]
		[SerializeField]
		private float _playerHelicopterConstraintTimeRobby;

		// Token: 0x040040B0 RID: 16560
		[Token(Token = "0x40040B0")]
		[FieldOffset(Offset = "0x194")]
		[SerializeField]
		private float _playerHelicopterConstraintTimeVirginia;

		// Token: 0x040040B1 RID: 16561
		[Token(Token = "0x40040B1")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private float _playerHelicopterConstraintTimeGroup;

		// Token: 0x040040B2 RID: 16562
		[Token(Token = "0x40040B2")]
		[FieldOffset(Offset = "0x19C")]
		[SerializeField]
		private float _playerHelicopterConstraintTimePlayer;

		// Token: 0x040040B3 RID: 16563
		[Token(Token = "0x40040B3")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private float _chopperSpeedSampleTime;

		// Token: 0x040040B4 RID: 16564
		[Token(Token = "0x40040B4")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private List<AnimationSync> _syncToPlayer;

		// Token: 0x040040B5 RID: 16565
		[Token(Token = "0x40040B5")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private List<Animator> _animators;

		// Token: 0x040040B6 RID: 16566
		[Token(Token = "0x40040B6")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private ChopperCredits _nextCutscene;

		// Token: 0x040040B7 RID: 16567
		[Token(Token = "0x40040B7")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private List<ChopperGroupLeaveIsland.HelicopterConstraint> _helicopterConstraints;

		// Token: 0x040040B8 RID: 16568
		[Token(Token = "0x40040B8")]
		[FieldOffset(Offset = "0x1C8")]
		private Vector3 _chopperTotalVelocity;

		// Token: 0x040040B9 RID: 16569
		[Token(Token = "0x40040B9")]
		[FieldOffset(Offset = "0x1D4")]
		private int _chopperSpeedSamples;

		// Token: 0x040040BA RID: 16570
		[Token(Token = "0x40040BA")]
		[FieldOffset(Offset = "0x1D8")]
		private float _startTime;

		// Token: 0x040040BB RID: 16571
		[Token(Token = "0x40040BB")]
		[FieldOffset(Offset = "0x1DC")]
		private int _trackedAnimatorCutsceneStateHash;

		// Token: 0x040040BC RID: 16572
		[Token(Token = "0x40040BC")]
		[FieldOffset(Offset = "0x1E0")]
		private int _playerCutsceneStartHash;

		// Token: 0x040040BD RID: 16573
		[Token(Token = "0x40040BD")]
		[FieldOffset(Offset = "0x1E4")]
		private Vector3 _previousChopperPosition;

		// Token: 0x040040BE RID: 16574
		[Token(Token = "0x40040BE")]
		[FieldOffset(Offset = "0x1F0")]
		private float _normalizedTime;

		// Token: 0x040040BF RID: 16575
		[Token(Token = "0x40040BF")]
		[FieldOffset(Offset = "0x1F4")]
		private bool _handlePlayerAnimationMoveEvents;

		// Token: 0x040040C0 RID: 16576
		[Token(Token = "0x40040C0")]
		[FieldOffset(Offset = "0x1F8")]
		private float _playerHelicopterConstraintTime;

		// Token: 0x020008C2 RID: 2242
		[Token(Token = "0x20008C2")]
		[Serializable]
		public class HelicopterConstraint : IAnimatorMoveProxyReceiver
		{
			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x06003C85 RID: 15493 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003C86 RID: 15494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000780")]
			public Transform TargetTransform
			{
				[Token(Token = "0x6003C85")]
				[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003C86")]
				[Address(RVA = "0x5A85D0", Offset = "0x5A75D0", VA = "0x1805A85D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x06003C87 RID: 15495 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003C88 RID: 15496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000781")]
			public Transform ActorTransformRoot
			{
				[Token(Token = "0x6003C87")]
				[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003C88")]
				[Address(RVA = "0x5A85C0", Offset = "0x5A75C0", VA = "0x1805A85C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x06003C89 RID: 15497 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003C8A RID: 15498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000782")]
			public Transform ActorTransformRootBone
			{
				[Token(Token = "0x6003C89")]
				[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003C8A")]
				[Address(RVA = "0x541240", Offset = "0x540240", VA = "0x180541240")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x06003C8B RID: 15499 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003C8C RID: 15500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000783")]
			public Animator Animator
			{
				[Token(Token = "0x6003C8B")]
				[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003C8C")]
				[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x06003C8D RID: 15501 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003C8E RID: 15502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000784")]
			public string StateName
			{
				[Token(Token = "0x6003C8D")]
				[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003C8E")]
				[Address(RVA = "0x541250", Offset = "0x540250", VA = "0x180541250")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x06003C8F RID: 15503 RVA: 0x00011B38 File Offset: 0x0000FD38
			// (set) Token: 0x06003C90 RID: 15504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000785")]
			public int LayerIndex
			{
				[Token(Token = "0x6003C8F")]
				[Address(RVA = "0x63DF30", Offset = "0x63CF30", VA = "0x18063DF30")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003C90")]
				[Address(RVA = "0x2421820", Offset = "0x2420820", VA = "0x182421820")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x06003C91 RID: 15505 RVA: 0x00011B50 File Offset: 0x0000FD50
			// (set) Token: 0x06003C92 RID: 15506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000786")]
			public float StateNormalizedTime
			{
				[Token(Token = "0x6003C91")]
				[Address(RVA = "0x2004010", Offset = "0x2003010", VA = "0x182004010")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6003C92")]
				[Address(RVA = "0x2874C50", Offset = "0x2873C50", VA = "0x182874C50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x06003C93 RID: 15507 RVA: 0x00011B68 File Offset: 0x0000FD68
			[Token(Token = "0x17000787")]
			public bool IsValid
			{
				[Token(Token = "0x6003C93")]
				[Address(RVA = "0x2F1F8F0", Offset = "0x2F1E8F0", VA = "0x182F1F8F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003C94 RID: 15508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C94")]
			[Address(RVA = "0x2F1F710", Offset = "0x2F1E710", VA = "0x182F1F710")]
			public void UpdateConstraint()
			{
			}

			// Token: 0x06003C95 RID: 15509 RVA: 0x00011B80 File Offset: 0x0000FD80
			[Token(Token = "0x6003C95")]
			[Address(RVA = "0x2F1F4F0", Offset = "0x2F1E4F0", VA = "0x182F1F4F0")]
			public bool Initialize()
			{
				return default(bool);
			}

			// Token: 0x06003C96 RID: 15510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C96")]
			[Address(RVA = "0x2F1F700", Offset = "0x2F1E700", VA = "0x182F1F700", Slot = "4")]
			public void OnAnimatorMove()
			{
			}

			// Token: 0x06003C97 RID: 15511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C97")]
			[Address(RVA = "0x2F1F700", Offset = "0x2F1E700", VA = "0x182F1F700")]
			public void LateUpdate()
			{
			}

			// Token: 0x06003C98 RID: 15512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C98")]
			[Address(RVA = "0x2F1F430", Offset = "0x2F1E430", VA = "0x182F1F430")]
			public void Dispose()
			{
			}

			// Token: 0x06003C99 RID: 15513 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C99")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public HelicopterConstraint()
			{
			}

			// Token: 0x040040C8 RID: 16584
			[Token(Token = "0x40040C8")]
			[FieldOffset(Offset = "0x40")]
			private AnimatorMoveProxy _animatorMoveProxy;

			// Token: 0x040040C9 RID: 16585
			[Token(Token = "0x40040C9")]
			[FieldOffset(Offset = "0x48")]
			private bool _isInitialized;

			// Token: 0x040040CA RID: 16586
			[Token(Token = "0x40040CA")]
			[FieldOffset(Offset = "0x49")]
			private bool _isValid;

			// Token: 0x040040CB RID: 16587
			[Token(Token = "0x40040CB")]
			[FieldOffset(Offset = "0x4C")]
			private int _stateHash;
		}
	}
}
