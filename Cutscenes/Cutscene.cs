using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Cutscenes
{
	// Token: 0x02000763 RID: 1891
	[Token(Token = "0x2000763")]
	public class Cutscene : MonoBehaviour
	{
		// Token: 0x06003174 RID: 12660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003174")]
		[Address(RVA = "0x2E42480", Offset = "0x2E41480", VA = "0x182E42480")]
		internal void AlignLocalPlayer(Transform locator, float alignTimer, out bool completed)
		{
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003175")]
		[Address(RVA = "0x2E42200", Offset = "0x2E41200", VA = "0x182E42200")]
		internal void AlignLocalPlayer(Transform locator, Vector3 offsetPos, Quaternion offsetRotation, float alignTimer, out bool completed)
		{
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003176")]
		[Address(RVA = "0x2E42580", Offset = "0x2E41580", VA = "0x182E42580")]
		internal void AlignLocalPlayer(Vector3 locatorPosition, Quaternion locatorRotation, float alignTimer, out bool completed)
		{
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063B")]
		public List<string> Aliases
		{
			[Token(Token = "0x6003177")]
			[Address(RVA = "0x5E4C40", Offset = "0x5E3C40", VA = "0x1805E4C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		[Token(Token = "0x1700063C")]
		public bool InstantiateFromAsset
		{
			[Token(Token = "0x6003178")]
			[Address(RVA = "0x1DD5070", Offset = "0x1DD4070", VA = "0x181DD5070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06003179 RID: 12665 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		[Token(Token = "0x1700063D")]
		public bool IsSkippable
		{
			[Token(Token = "0x6003179")]
			[Address(RVA = "0x5A2400", Offset = "0x5A1400", VA = "0x1805A2400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x0600317A RID: 12666 RVA: 0x0000E208 File Offset: 0x0000C408
		[Token(Token = "0x1700063E")]
		public bool HideVailActors
		{
			[Token(Token = "0x600317A")]
			[Address(RVA = "0x2E43940", Offset = "0x2E42940", VA = "0x182E43940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600317B RID: 12667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063F")]
		public virtual string SaveId
		{
			[Token(Token = "0x600317B")]
			[Address(RVA = "0x28E6AF0", Offset = "0x28E5AF0", VA = "0x1828E6AF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x0600317C RID: 12668 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600317D RID: 12669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000025")]
		protected event Action<CutsceneState> OnCutsceneEndedEvent
		{
			[Token(Token = "0x600317C")]
			[Address(RVA = "0x2E43560", Offset = "0x2E42560", VA = "0x182E43560")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600317D")]
			[Address(RVA = "0x2E43950", Offset = "0x2E42950", VA = "0x182E43950")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000640")]
		protected ILayerBehaviourActivator[] FullBodyDisableSpineActivators
		{
			[Token(Token = "0x600317E")]
			[Address(RVA = "0x2E43750", Offset = "0x2E42750", VA = "0x182E43750")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600317F")]
		[Address(RVA = "0x589EC0", Offset = "0x588EC0", VA = "0x180589EC0")]
		internal void SetIsPlaying(bool isPlaying)
		{
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06003180 RID: 12672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000641")]
		protected ILayerBehaviourActivator[] FullBodyActivators
		{
			[Token(Token = "0x6003180")]
			[Address(RVA = "0x2E43610", Offset = "0x2E42610", VA = "0x182E43610")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003181")]
		[Address(RVA = "0x2E43420", Offset = "0x2E42420", VA = "0x182E43420")]
		public static IEnumerator WaitForPlayerHandsEmpty()
		{
			return null;
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x0000E220 File Offset: 0x0000C420
		[Token(Token = "0x6003182")]
		[Address(RVA = "0x2E42B80", Offset = "0x2E41B80", VA = "0x182E42B80")]
		public static bool IsPlayerHandsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003183")]
		[Address(RVA = "0x2E43070", Offset = "0x2E42070", VA = "0x182E43070", Slot = "5")]
		internal virtual void OnValidate()
		{
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003184")]
		[Address(RVA = "0x2E42810", Offset = "0x2E41810", VA = "0x182E42810")]
		private void Awake()
		{
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003185")]
		[Address(RVA = "0x2E42840", Offset = "0x2E41840", VA = "0x182E42840")]
		private void CheckInitialize()
		{
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003186")]
		[Address(RVA = "0x2E43240", Offset = "0x2E42240", VA = "0x182E43240")]
		private void SetupCullDistances(CullDistanceSettings cullDistanceSettings)
		{
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003187")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "6")]
		internal virtual void InitializeHook()
		{
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003188")]
		[Address(RVA = "0x2E43390", Offset = "0x2E42390", VA = "0x182E43390")]
		protected void Start()
		{
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003189")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "7")]
		protected virtual void PostStartHook()
		{
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600318A")]
		[Address(RVA = "0x2E42FA0", Offset = "0x2E41FA0", VA = "0x182E42FA0")]
		protected void OnDestroy()
		{
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600318B")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "8")]
		protected virtual void PostOnDestroyHook()
		{
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x0000E238 File Offset: 0x0000C438
		[Token(Token = "0x600318C")]
		[Address(RVA = "0x2E42820", Offset = "0x2E41820", VA = "0x182E42820")]
		public bool CanBePlayed()
		{
			return default(bool);
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x0000E250 File Offset: 0x0000C450
		[Token(Token = "0x600318D")]
		[Address(RVA = "0x2E43100", Offset = "0x2E42100", VA = "0x182E43100", Slot = "9")]
		public virtual bool Play()
		{
			return default(bool);
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600318E")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "10")]
		public virtual void OnCutsceneQueued()
		{
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600318F")]
		[Address(RVA = "0x2E433C0", Offset = "0x2E423C0", VA = "0x182E433C0", Slot = "11")]
		public virtual void Stop()
		{
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003190")]
		[Address(RVA = "0x2E43330", Offset = "0x2E42330", VA = "0x182E43330", Slot = "12")]
		public virtual void Skip()
		{
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003191")]
		[Address(RVA = "0x2E42A60", Offset = "0x2E41A60", VA = "0x182E42A60")]
		protected void CutsceneComplete()
		{
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003192")]
		[Address(RVA = "0x2E428E0", Offset = "0x2E418E0", VA = "0x182E428E0", Slot = "13")]
		protected virtual void Cleanup()
		{
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003193")]
		[Address(RVA = "0x2E42AC0", Offset = "0x2E41AC0", VA = "0x182E42AC0")]
		private void DoDestroy()
		{
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003194")]
		[Address(RVA = "0x2E431B0", Offset = "0x2E421B0", VA = "0x182E431B0", Slot = "14")]
		protected virtual void ResetCutscene()
		{
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x0000E268 File Offset: 0x0000C468
		[Token(Token = "0x6003195")]
		[Address(RVA = "0x58ECB0", Offset = "0x58DCB0", VA = "0x18058ECB0")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x0000E280 File Offset: 0x0000C480
		[Token(Token = "0x6003196")]
		[Address(RVA = "0x2E42DB0", Offset = "0x2E41DB0", VA = "0x182E42DB0")]
		public bool MatchesAlias(string searchAlias)
		{
			return default(bool);
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x0000E298 File Offset: 0x0000C498
		[Token(Token = "0x6003197")]
		[Address(RVA = "0x2E42EE0", Offset = "0x2E41EE0", VA = "0x182E42EE0")]
		public bool Matches(Cutscene otherCutscene)
		{
			return default(bool);
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003198")]
		[Address(RVA = "0x2E43470", Offset = "0x2E42470", VA = "0x182E43470")]
		public Cutscene()
		{
		}

		// Token: 0x04002B46 RID: 11078
		[Token(Token = "0x4002B46")]
		[FieldOffset(Offset = "0x20")]
		protected Cutscene.CameraUtility CameraUtil;

		// Token: 0x04002B47 RID: 11079
		[Token(Token = "0x4002B47")]
		[FieldOffset(Offset = "0x28")]
		private float _alignStartTime;

		// Token: 0x04002B48 RID: 11080
		[Token(Token = "0x4002B48")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 _alignStartPos;

		// Token: 0x04002B49 RID: 11081
		[Token(Token = "0x4002B49")]
		[FieldOffset(Offset = "0x38")]
		private Quaternion _alignStartRot;

		// Token: 0x04002B4A RID: 11082
		[Token(Token = "0x4002B4A")]
		[FieldOffset(Offset = "0x48")]
		private float _alignmentFactor;

		// Token: 0x04002B4B RID: 11083
		[Token(Token = "0x4002B4B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		protected bool _destroyOnceCompleted;

		// Token: 0x04002B4C RID: 11084
		[Token(Token = "0x4002B4C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected GameObject _destroyTarget;

		// Token: 0x04002B4D RID: 11085
		[Token(Token = "0x4002B4D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _destroyDelay;

		// Token: 0x04002B4E RID: 11086
		[Token(Token = "0x4002B4E")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		protected bool _resetOnceCompleted;

		// Token: 0x04002B4F RID: 11087
		[Token(Token = "0x4002B4F")]
		[FieldOffset(Offset = "0x5D")]
		[SerializeField]
		protected bool _isSingleUse;

		// Token: 0x04002B50 RID: 11088
		[Token(Token = "0x4002B50")]
		[FieldOffset(Offset = "0x5E")]
		[SerializeField]
		protected bool _isSkippable;

		// Token: 0x04002B51 RID: 11089
		[Token(Token = "0x4002B51")]
		[FieldOffset(Offset = "0x5F")]
		[SerializeField]
		protected bool _hideVailActors;

		// Token: 0x04002B52 RID: 11090
		[Token(Token = "0x4002B52")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected bool _instantiateCutsceneFromAsset;

		// Token: 0x04002B53 RID: 11091
		[Token(Token = "0x4002B53")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<string> _aliases;

		// Token: 0x04002B54 RID: 11092
		[Token(Token = "0x4002B54")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CullDistanceSettings _cullDistanceSettings;

		// Token: 0x04002B55 RID: 11093
		[Token(Token = "0x4002B55")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public UnityEvent OnCutsceneEnded;

		// Token: 0x04002B57 RID: 11095
		[Token(Token = "0x4002B57")]
		[FieldOffset(Offset = "0x88")]
		[HideInInspector]
		[SerializeField]
		protected bool _hasBeenPlayed;

		// Token: 0x04002B58 RID: 11096
		[Token(Token = "0x4002B58")]
		[FieldOffset(Offset = "0x89")]
		private bool _initialized;

		// Token: 0x04002B59 RID: 11097
		[Token(Token = "0x4002B59")]
		[FieldOffset(Offset = "0x90")]
		private ILayerBehaviourActivator[] _cachedFullBodyDisableSpineActivators;

		// Token: 0x04002B5A RID: 11098
		[Token(Token = "0x4002B5A")]
		[FieldOffset(Offset = "0x98")]
		private ILayerBehaviourActivator[] _cachedFullBodyActivators;

		// Token: 0x04002B5B RID: 11099
		[Token(Token = "0x4002B5B")]
		[FieldOffset(Offset = "0xA0")]
		private bool _isPlaying;

		// Token: 0x04002B5C RID: 11100
		[Token(Token = "0x4002B5C")]
		[FieldOffset(Offset = "0xA8")]
		protected Cutscene.PlayerUtility PlayerUtil;

		// Token: 0x02000764 RID: 1892
		[Token(Token = "0x2000764")]
		protected class CameraUtility
		{
			// Token: 0x06003199 RID: 12697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003199")]
			[Address(RVA = "0x2E3CA40", Offset = "0x2E3BA40", VA = "0x182E3CA40")]
			public void SetOwner(Cutscene owner)
			{
			}

			// Token: 0x0600319A RID: 12698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600319A")]
			[Address(RVA = "0x2E3C960", Offset = "0x2E3B960", VA = "0x182E3C960")]
			public void RestrictMouseMovementAngle(float angle, float rate, Cutscene.CameraUtility.Axis axis)
			{
			}

			// Token: 0x0600319B RID: 12699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600319B")]
			[Address(RVA = "0x2E3C8C0", Offset = "0x2E3B8C0", VA = "0x182E3C8C0")]
			private IEnumerator LerpMouseRange(float amount, float rate, Cutscene.CameraUtility.Axis axis)
			{
				return null;
			}

			// Token: 0x0600319C RID: 12700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600319C")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public CameraUtility()
			{
			}

			// Token: 0x04002B5D RID: 11101
			[Token(Token = "0x4002B5D")]
			[FieldOffset(Offset = "0x10")]
			private Cutscene _cutscene;

			// Token: 0x04002B5E RID: 11102
			[Token(Token = "0x4002B5E")]
			[FieldOffset(Offset = "0x18")]
			private Coroutine _cameraRestrictionMovementCoroutine;

			// Token: 0x04002B5F RID: 11103
			[Token(Token = "0x4002B5F")]
			[FieldOffset(Offset = "0x20")]
			private SimpleMouseRotator _cameraRotator;

			// Token: 0x02000765 RID: 1893
			[Token(Token = "0x2000765")]
			public enum Axis
			{
				// Token: 0x04002B61 RID: 11105
				[Token(Token = "0x4002B61")]
				X,
				// Token: 0x04002B62 RID: 11106
				[Token(Token = "0x4002B62")]
				Y
			}
		}

		// Token: 0x02000767 RID: 1895
		[Token(Token = "0x2000767")]
		protected class PlayerUtility
		{
			// Token: 0x060031A3 RID: 12707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60031A3")]
			[Address(RVA = "0x2E53310", Offset = "0x2E52310", VA = "0x182E53310")]
			public void EnableCamera(bool enable)
			{
			}

			// Token: 0x060031A4 RID: 12708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60031A4")]
			[Address(RVA = "0x2E53790", Offset = "0x2E52790", VA = "0x182E53790")]
			public void SnapToWorldPosition(Vector3 position)
			{
			}

			// Token: 0x060031A5 RID: 12709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60031A5")]
			[Address(RVA = "0x2E53680", Offset = "0x2E52680", VA = "0x182E53680")]
			public void SetWorldRotation(Quaternion rotation)
			{
			}

			// Token: 0x060031A6 RID: 12710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60031A6")]
			[Address(RVA = "0x2E53710", Offset = "0x2E52710", VA = "0x182E53710")]
			public void SnapToTransform(Transform snapTransform)
			{
			}

			// Token: 0x060031A7 RID: 12711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60031A7")]
			[Address(RVA = "0x2E53410", Offset = "0x2E52410", VA = "0x182E53410")]
			public void Lock()
			{
			}

			// Token: 0x060031A8 RID: 12712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60031A8")]
			[Address(RVA = "0x2E53830", Offset = "0x2E52830", VA = "0x182E53830")]
			public void Unlock()
			{
			}

			// Token: 0x060031A9 RID: 12713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60031A9")]
			[Address(RVA = "0x2E534E0", Offset = "0x2E524E0", VA = "0x182E534E0")]
			private static void SetRigidBodyLock(bool lockValue)
			{
			}

			// Token: 0x060031AA RID: 12714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60031AA")]
			[Address(RVA = "0x2E53400", Offset = "0x2E52400", VA = "0x182E53400")]
			public void LockRigidBody()
			{
			}

			// Token: 0x060031AB RID: 12715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60031AB")]
			[Address(RVA = "0x2E53820", Offset = "0x2E52820", VA = "0x182E53820")]
			public void UnlockRigidBody()
			{
			}

			// Token: 0x060031AC RID: 12716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60031AC")]
			[Address(RVA = "0x2E532C0", Offset = "0x2E522C0", VA = "0x182E532C0")]
			public void DisableCharacterCollision()
			{
			}

			// Token: 0x060031AD RID: 12717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60031AD")]
			[Address(RVA = "0x2E533B0", Offset = "0x2E523B0", VA = "0x182E533B0")]
			public void EnableCharacterCollision()
			{
			}

			// Token: 0x060031AE RID: 12718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60031AE")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public PlayerUtility()
			{
			}
		}
	}
}
