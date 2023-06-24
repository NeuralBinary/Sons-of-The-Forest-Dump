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
	// Token: 0x02000936 RID: 2358
	[Token(Token = "0x2000936")]
	[AddComponentMenu("Sons/Animation/ChopperGroupLeaveIsland")]
	public class ChopperGroupLeaveIsland : EndGameCutscene
	{
		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x060043CE RID: 17358 RVA: 0x00014A30 File Offset: 0x00012C30
		[Token(Token = "0x170008AA")]
		public int VirginiaMissingBoolHash
		{
			[Token(Token = "0x60043CE")]
			[Address(RVA = "0x364B300", Offset = "0x3649900", VA = "0x18364B300")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x060043CF RID: 17359 RVA: 0x00014A48 File Offset: 0x00012C48
		[Token(Token = "0x170008AB")]
		public override bool HandlePlayerAnimationMoveEvents
		{
			[Token(Token = "0x60043CF")]
			[Address(RVA = "0x364B360", Offset = "0x3649960", VA = "0x18364B360", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x060043D0 RID: 17360 RVA: 0x00014A60 File Offset: 0x00012C60
		[Token(Token = "0x170008AC")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x60043D0")]
			[Address(RVA = "0x364B370", Offset = "0x3649970", VA = "0x18364B370", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x060043D1 RID: 17361 RVA: 0x00014A78 File Offset: 0x00012C78
		[Token(Token = "0x170008AD")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x60043D1")]
			[Address(RVA = "0x364B380", Offset = "0x3649980", VA = "0x18364B380", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D2")]
		[Address(RVA = "0x364B390", Offset = "0x3649990", VA = "0x18364B390", Slot = "31")]
		internal override void OnCutsceneReady()
		{
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D3")]
		[Address(RVA = "0x364B930", Offset = "0x3649F30", VA = "0x18364B930")]
		private void SetupCutsceneHashes()
		{
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D4")]
		[Address(RVA = "0x364BBC0", Offset = "0x364A1C0", VA = "0x18364BBC0", Slot = "32")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D5")]
		[Address(RVA = "0x364BF40", Offset = "0x364A540", VA = "0x18364BF40", Slot = "28")]
		internal override void LateUpdate()
		{
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x00014A90 File Offset: 0x00012C90
		[Token(Token = "0x60043D6")]
		[Address(RVA = "0x364C310", Offset = "0x364A910", VA = "0x18364C310")]
		private float GetPlayerHelicopterConstraintTime()
		{
			return 0f;
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D7")]
		[Address(RVA = "0x364C320", Offset = "0x364A920", VA = "0x18364C320", Slot = "26")]
		internal override void OnNormalizedTimeChanged(float value)
		{
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D8")]
		[Address(RVA = "0x364C3A0", Offset = "0x364A9A0", VA = "0x18364C3A0")]
		private void UpdateChopperTransform()
		{
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D9")]
		[Address(RVA = "0x364C6E0", Offset = "0x364ACE0", VA = "0x18364C6E0")]
		public ChopperGroupLeaveIsland()
		{
		}

		// Token: 0x040046F0 RID: 18160
		[Token(Token = "0x40046F0")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private GameObject _robbyRoot;

		// Token: 0x040046F1 RID: 18161
		[Token(Token = "0x40046F1")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private GameObject _virginiaRoot;

		// Token: 0x040046F2 RID: 18162
		[Token(Token = "0x40046F2")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private GameObject _chopperRoot;

		// Token: 0x040046F3 RID: 18163
		[Token(Token = "0x40046F3")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Transform _chopperSampleTransform;

		// Token: 0x040046F4 RID: 18164
		[Token(Token = "0x40046F4")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private Transform _playerHelicopterConstraintTransform;

		// Token: 0x040046F5 RID: 18165
		[Token(Token = "0x40046F5")]
		[FieldOffset(Offset = "0x1A8")]
		[FormerlySerializedAs("_playerHelicopterConstraintTime")]
		[SerializeField]
		private float _playerHelicopterConstraintTimeRobby;

		// Token: 0x040046F6 RID: 18166
		[Token(Token = "0x40046F6")]
		[FieldOffset(Offset = "0x1AC")]
		[SerializeField]
		private float _playerHelicopterConstraintTimeVirginia;

		// Token: 0x040046F7 RID: 18167
		[Token(Token = "0x40046F7")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private float _playerHelicopterConstraintTimeGroup;

		// Token: 0x040046F8 RID: 18168
		[Token(Token = "0x40046F8")]
		[FieldOffset(Offset = "0x1B4")]
		[SerializeField]
		private float _playerHelicopterConstraintTimePlayer;

		// Token: 0x040046F9 RID: 18169
		[Token(Token = "0x40046F9")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private float _chopperSpeedSampleTime;

		// Token: 0x040046FA RID: 18170
		[Token(Token = "0x40046FA")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private List<AnimationSync> _syncToPlayer;

		// Token: 0x040046FB RID: 18171
		[Token(Token = "0x40046FB")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private List<Animator> _animators;

		// Token: 0x040046FC RID: 18172
		[Token(Token = "0x40046FC")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private ChopperCredits _nextCutscene;

		// Token: 0x040046FD RID: 18173
		[Token(Token = "0x40046FD")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private List<ChopperGroupLeaveIsland.HelicopterConstraint> _helicopterConstraints;

		// Token: 0x040046FE RID: 18174
		[Token(Token = "0x40046FE")]
		[FieldOffset(Offset = "0x1E0")]
		private Vector3 _chopperTotalVelocity;

		// Token: 0x040046FF RID: 18175
		[Token(Token = "0x40046FF")]
		[FieldOffset(Offset = "0x1EC")]
		private int _chopperSpeedSamples;

		// Token: 0x04004700 RID: 18176
		[Token(Token = "0x4004700")]
		[FieldOffset(Offset = "0x1F0")]
		private float _startTime;

		// Token: 0x04004701 RID: 18177
		[Token(Token = "0x4004701")]
		[FieldOffset(Offset = "0x1F4")]
		private int _trackedAnimatorCutsceneStateHash;

		// Token: 0x04004702 RID: 18178
		[Token(Token = "0x4004702")]
		[FieldOffset(Offset = "0x1F8")]
		private int _playerCutsceneStartHash;

		// Token: 0x04004703 RID: 18179
		[Token(Token = "0x4004703")]
		[FieldOffset(Offset = "0x1FC")]
		private Vector3 _previousChopperPosition;

		// Token: 0x04004704 RID: 18180
		[Token(Token = "0x4004704")]
		[FieldOffset(Offset = "0x208")]
		private float _normalizedTime;

		// Token: 0x04004705 RID: 18181
		[Token(Token = "0x4004705")]
		[FieldOffset(Offset = "0x20C")]
		private bool _handlePlayerAnimationMoveEvents;

		// Token: 0x04004706 RID: 18182
		[Token(Token = "0x4004706")]
		[FieldOffset(Offset = "0x210")]
		private float _playerHelicopterConstraintTime;

		// Token: 0x02000937 RID: 2359
		[Token(Token = "0x2000937")]
		[Serializable]
		public class HelicopterConstraint : IAnimatorMoveProxyReceiver
		{
			// Token: 0x170008AE RID: 2222
			// (get) Token: 0x060043DA RID: 17370 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060043DB RID: 17371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008AE")]
			public Transform TargetTransform
			{
				[Token(Token = "0x60043DA")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60043DB")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170008AF RID: 2223
			// (get) Token: 0x060043DC RID: 17372 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060043DD RID: 17373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008AF")]
			public Transform ActorTransformRoot
			{
				[Token(Token = "0x60043DC")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60043DD")]
				[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170008B0 RID: 2224
			// (get) Token: 0x060043DE RID: 17374 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060043DF RID: 17375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008B0")]
			public Transform ActorTransformRootBone
			{
				[Token(Token = "0x60043DE")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60043DF")]
				[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170008B1 RID: 2225
			// (get) Token: 0x060043E0 RID: 17376 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060043E1 RID: 17377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008B1")]
			public Animator Animator
			{
				[Token(Token = "0x60043E0")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60043E1")]
				[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170008B2 RID: 2226
			// (get) Token: 0x060043E2 RID: 17378 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060043E3 RID: 17379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008B2")]
			public string StateName
			{
				[Token(Token = "0x60043E2")]
				[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60043E3")]
				[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x060043E4 RID: 17380 RVA: 0x00014AA8 File Offset: 0x00012CA8
			// (set) Token: 0x060043E5 RID: 17381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008B3")]
			public int LayerIndex
			{
				[Token(Token = "0x60043E4")]
				[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60043E5")]
				[Address(RVA = "0x993AE0", Offset = "0x9920E0", VA = "0x180993AE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170008B4 RID: 2228
			// (get) Token: 0x060043E6 RID: 17382 RVA: 0x00014AC0 File Offset: 0x00012CC0
			// (set) Token: 0x060043E7 RID: 17383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008B4")]
			public float StateNormalizedTime
			{
				[Token(Token = "0x60043E6")]
				[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60043E7")]
				[Address(RVA = "0x2D63590", Offset = "0x2D61B90", VA = "0x182D63590")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170008B5 RID: 2229
			// (get) Token: 0x060043E8 RID: 17384 RVA: 0x00014AD8 File Offset: 0x00012CD8
			[Token(Token = "0x170008B5")]
			public bool IsValid
			{
				[Token(Token = "0x60043E8")]
				[Address(RVA = "0x364C950", Offset = "0x364AF50", VA = "0x18364C950")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060043E9 RID: 17385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043E9")]
			[Address(RVA = "0x364CBE0", Offset = "0x364B1E0", VA = "0x18364CBE0")]
			public void UpdateConstraint()
			{
			}

			// Token: 0x060043EA RID: 17386 RVA: 0x00014AF0 File Offset: 0x00012CF0
			[Token(Token = "0x60043EA")]
			[Address(RVA = "0x364CF10", Offset = "0x364B510", VA = "0x18364CF10")]
			public bool Initialize()
			{
				return default(bool);
			}

			// Token: 0x060043EB RID: 17387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043EB")]
			[Address(RVA = "0x364D300", Offset = "0x364B900", VA = "0x18364D300", Slot = "4")]
			public void OnAnimatorMove()
			{
			}

			// Token: 0x060043EC RID: 17388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043EC")]
			[Address(RVA = "0x364D300", Offset = "0x364B900", VA = "0x18364D300")]
			public void LateUpdate()
			{
			}

			// Token: 0x060043ED RID: 17389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043ED")]
			[Address(RVA = "0x364D310", Offset = "0x364B910", VA = "0x18364D310")]
			public void Dispose()
			{
			}

			// Token: 0x060043EE RID: 17390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043EE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public HelicopterConstraint()
			{
			}

			// Token: 0x0400470E RID: 18190
			[Token(Token = "0x400470E")]
			[FieldOffset(Offset = "0x40")]
			private AnimatorMoveProxy _animatorMoveProxy;

			// Token: 0x0400470F RID: 18191
			[Token(Token = "0x400470F")]
			[FieldOffset(Offset = "0x48")]
			private bool _isInitialized;

			// Token: 0x04004710 RID: 18192
			[Token(Token = "0x4004710")]
			[FieldOffset(Offset = "0x49")]
			private bool _isValid;

			// Token: 0x04004711 RID: 18193
			[Token(Token = "0x4004711")]
			[FieldOffset(Offset = "0x4C")]
			private int _stateHash;
		}
	}
}
