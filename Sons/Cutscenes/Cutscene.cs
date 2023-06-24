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
	// Token: 0x0200066E RID: 1646
	[Token(Token = "0x200066E")]
	public class Cutscene : MonoBehaviour
	{
		// Token: 0x06002AE9 RID: 10985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE9")]
		[Address(RVA = "0x3404450", Offset = "0x3402A50", VA = "0x183404450")]
		internal void AlignLocalPlayer(Transform locator, float alignTimer, out bool completed)
		{
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AEA")]
		[Address(RVA = "0x3404560", Offset = "0x3402B60", VA = "0x183404560")]
		internal void AlignLocalPlayer(Transform locator, Vector3 offsetPos, Quaternion offsetRotation, float alignTimer, out bool completed)
		{
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AEB")]
		[Address(RVA = "0x3404850", Offset = "0x3402E50", VA = "0x183404850")]
		internal void AlignLocalPlayer(Vector3 locatorPosition, Quaternion locatorRotation, float alignTimer, out bool completed)
		{
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A6")]
		public List<string> Aliases
		{
			[Token(Token = "0x6002AEC")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x0000CA80 File Offset: 0x0000AC80
		[Token(Token = "0x170005A7")]
		public bool InstantiateFromAsset
		{
			[Token(Token = "0x6002AED")]
			[Address(RVA = "0x213CBB0", Offset = "0x213B1B0", VA = "0x18213CBB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x0000CA98 File Offset: 0x0000AC98
		[Token(Token = "0x170005A8")]
		public bool IsSkippable
		{
			[Token(Token = "0x6002AEE")]
			[Address(RVA = "0x620EF0", Offset = "0x61F4F0", VA = "0x180620EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		[Token(Token = "0x170005A9")]
		public bool HideVailActors
		{
			[Token(Token = "0x6002AEF")]
			[Address(RVA = "0x213CBA0", Offset = "0x213B1A0", VA = "0x18213CBA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		[Token(Token = "0x170005AA")]
		public bool PauseVailActors
		{
			[Token(Token = "0x6002AF0")]
			[Address(RVA = "0x3404BE0", Offset = "0x34031E0", VA = "0x183404BE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AB")]
		public virtual string SaveId
		{
			[Token(Token = "0x6002AF1")]
			[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06002AF2 RID: 10994 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002AF3 RID: 10995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001E")]
		protected event Action<CutsceneState> OnCutsceneEndedEvent
		{
			[Token(Token = "0x6002AF2")]
			[Address(RVA = "0x3404BF0", Offset = "0x34031F0", VA = "0x183404BF0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002AF3")]
			[Address(RVA = "0x3404D60", Offset = "0x3403360", VA = "0x183404D60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AC")]
		protected ILayerBehaviourActivator[] FullBodyDisableSpineActivators
		{
			[Token(Token = "0x6002AF4")]
			[Address(RVA = "0x3404ED0", Offset = "0x34034D0", VA = "0x183404ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AF5")]
		[Address(RVA = "0x6124F0", Offset = "0x610AF0", VA = "0x1806124F0")]
		internal void SetIsPlaying(bool isPlaying)
		{
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AD")]
		protected ILayerBehaviourActivator[] FullBodyActivators
		{
			[Token(Token = "0x6002AF6")]
			[Address(RVA = "0x3405160", Offset = "0x3403760", VA = "0x183405160")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		[Token(Token = "0x170005AE")]
		protected bool BlockFullBodyInteraction
		{
			[Token(Token = "0x6002AF7")]
			[Address(RVA = "0x2E1DDC0", Offset = "0x2E1C3C0", VA = "0x182E1DDC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF8")]
		[Address(RVA = "0x3405320", Offset = "0x3403920", VA = "0x183405320")]
		public static IEnumerator WaitForPlayerHandsEmpty()
		{
			return null;
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		[Token(Token = "0x6002AF9")]
		[Address(RVA = "0x3405360", Offset = "0x3403960", VA = "0x183405360")]
		public static bool IsPlayerHandsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFA")]
		[Address(RVA = "0x34055B0", Offset = "0x3403BB0", VA = "0x1834055B0", Slot = "5")]
		internal virtual void OnValidate()
		{
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFB")]
		[Address(RVA = "0x3405710", Offset = "0x3403D10", VA = "0x183405710")]
		private void Awake()
		{
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFC")]
		[Address(RVA = "0x3405720", Offset = "0x3403D20", VA = "0x183405720")]
		private void CheckInitialize()
		{
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFD")]
		[Address(RVA = "0x3405820", Offset = "0x3403E20", VA = "0x183405820")]
		private void SetupCullDistances(CullDistanceSettings cullDistanceSettings)
		{
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		internal virtual void InitializeHook()
		{
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFF")]
		[Address(RVA = "0x34059B0", Offset = "0x3403FB0", VA = "0x1834059B0")]
		protected void Start()
		{
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B00")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		protected virtual void PostStartHook()
		{
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B01")]
		[Address(RVA = "0x34059E0", Offset = "0x3403FE0", VA = "0x1834059E0")]
		protected void OnDestroy()
		{
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B02")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		protected virtual void PostOnDestroyHook()
		{
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x0000CB10 File Offset: 0x0000AD10
		[Token(Token = "0x6002B03")]
		[Address(RVA = "0x3405B10", Offset = "0x3404110", VA = "0x183405B10")]
		public bool CanBePlayed()
		{
			return default(bool);
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[Token(Token = "0x6002B04")]
		[Address(RVA = "0x3405B30", Offset = "0x3404130", VA = "0x183405B30", Slot = "9")]
		public virtual bool Play()
		{
			return default(bool);
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B05")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		public virtual void OnCutsceneQueued()
		{
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B06")]
		[Address(RVA = "0x3405C60", Offset = "0x3404260", VA = "0x183405C60", Slot = "11")]
		public virtual void Stop()
		{
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B07")]
		[Address(RVA = "0x3405CC0", Offset = "0x34042C0", VA = "0x183405CC0", Slot = "12")]
		public virtual void Skip()
		{
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B08")]
		[Address(RVA = "0x3405D20", Offset = "0x3404320", VA = "0x183405D20")]
		protected void CutsceneComplete()
		{
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B09")]
		[Address(RVA = "0x3405D80", Offset = "0x3404380", VA = "0x183405D80", Slot = "13")]
		protected virtual void Cleanup()
		{
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B0A")]
		[Address(RVA = "0x3406050", Offset = "0x3404650", VA = "0x183406050")]
		private void DoDestroy()
		{
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B0B")]
		[Address(RVA = "0x3406200", Offset = "0x3404800", VA = "0x183406200", Slot = "14")]
		protected virtual void ResetCutscene()
		{
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[Token(Token = "0x6002B0C")]
		[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x0000CB58 File Offset: 0x0000AD58
		[Token(Token = "0x6002B0D")]
		[Address(RVA = "0x3406290", Offset = "0x3404890", VA = "0x183406290")]
		public bool MatchesAlias(string searchAlias)
		{
			return default(bool);
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[Token(Token = "0x6002B0E")]
		[Address(RVA = "0x3406470", Offset = "0x3404A70", VA = "0x183406470")]
		public bool Matches(Cutscene otherCutscene)
		{
			return default(bool);
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B0F")]
		[Address(RVA = "0x3406620", Offset = "0x3404C20", VA = "0x183406620")]
		public Cutscene()
		{
		}

		// Token: 0x04002617 RID: 9751
		[Token(Token = "0x4002617")]
		[FieldOffset(Offset = "0x20")]
		protected Cutscene.CameraUtility CameraUtil;

		// Token: 0x04002618 RID: 9752
		[Token(Token = "0x4002618")]
		[FieldOffset(Offset = "0x28")]
		private float _alignStartTime;

		// Token: 0x04002619 RID: 9753
		[Token(Token = "0x4002619")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 _alignStartPos;

		// Token: 0x0400261A RID: 9754
		[Token(Token = "0x400261A")]
		[FieldOffset(Offset = "0x38")]
		private Quaternion _alignStartRot;

		// Token: 0x0400261B RID: 9755
		[Token(Token = "0x400261B")]
		[FieldOffset(Offset = "0x48")]
		private float _alignmentFactor;

		// Token: 0x0400261C RID: 9756
		[Token(Token = "0x400261C")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		protected bool _destroyOnceCompleted;

		// Token: 0x0400261D RID: 9757
		[Token(Token = "0x400261D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected GameObject _destroyTarget;

		// Token: 0x0400261E RID: 9758
		[Token(Token = "0x400261E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _destroyDelay;

		// Token: 0x0400261F RID: 9759
		[Token(Token = "0x400261F")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		protected bool _resetOnceCompleted;

		// Token: 0x04002620 RID: 9760
		[Token(Token = "0x4002620")]
		[FieldOffset(Offset = "0x5D")]
		[SerializeField]
		protected bool _isSingleUse;

		// Token: 0x04002621 RID: 9761
		[Token(Token = "0x4002621")]
		[FieldOffset(Offset = "0x5E")]
		[SerializeField]
		protected bool _isSkippable;

		// Token: 0x04002622 RID: 9762
		[Token(Token = "0x4002622")]
		[FieldOffset(Offset = "0x5F")]
		[SerializeField]
		protected bool _pauseVailActors;

		// Token: 0x04002623 RID: 9763
		[Token(Token = "0x4002623")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected bool _hideVailActors;

		// Token: 0x04002624 RID: 9764
		[Token(Token = "0x4002624")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		protected bool _instantiateCutsceneFromAsset;

		// Token: 0x04002625 RID: 9765
		[Token(Token = "0x4002625")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<string> _aliases;

		// Token: 0x04002626 RID: 9766
		[Token(Token = "0x4002626")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CullDistanceSettings _cullDistanceSettings;

		// Token: 0x04002627 RID: 9767
		[Token(Token = "0x4002627")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public UnityEvent OnCutsceneEnded;

		// Token: 0x04002629 RID: 9769
		[Token(Token = "0x4002629")]
		[FieldOffset(Offset = "0x88")]
		[HideInInspector]
		[SerializeField]
		protected bool _hasBeenPlayed;

		// Token: 0x0400262A RID: 9770
		[Token(Token = "0x400262A")]
		[FieldOffset(Offset = "0x89")]
		private bool _initialized;

		// Token: 0x0400262B RID: 9771
		[Token(Token = "0x400262B")]
		[FieldOffset(Offset = "0x90")]
		private ILayerBehaviourActivator[] _cachedFullBodyDisableSpineActivators;

		// Token: 0x0400262C RID: 9772
		[Token(Token = "0x400262C")]
		[FieldOffset(Offset = "0x98")]
		private ILayerBehaviourActivator[] _cachedFullBodyActivators;

		// Token: 0x0400262D RID: 9773
		[Token(Token = "0x400262D")]
		[FieldOffset(Offset = "0xA0")]
		private bool _isPlaying;

		// Token: 0x0400262E RID: 9774
		[Token(Token = "0x400262E")]
		[FieldOffset(Offset = "0xA8")]
		protected Cutscene.PlayerUtility PlayerUtil;

		// Token: 0x0200066F RID: 1647
		[Token(Token = "0x200066F")]
		protected class CameraUtility
		{
			// Token: 0x06002B10 RID: 11024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B10")]
			[Address(RVA = "0x34067F0", Offset = "0x3404DF0", VA = "0x1834067F0")]
			public void SetOwner(Cutscene owner)
			{
			}

			// Token: 0x06002B11 RID: 11025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B11")]
			[Address(RVA = "0x3406950", Offset = "0x3404F50", VA = "0x183406950")]
			public void RestrictMouseMovementAngle(float angle, float rate, Cutscene.CameraUtility.Axis axis)
			{
			}

			// Token: 0x06002B12 RID: 11026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B12")]
			[Address(RVA = "0x3406A60", Offset = "0x3405060", VA = "0x183406A60")]
			private IEnumerator LerpMouseRange(float amount, float rate, Cutscene.CameraUtility.Axis axis)
			{
				return null;
			}

			// Token: 0x06002B13 RID: 11027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B13")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CameraUtility()
			{
			}

			// Token: 0x0400262F RID: 9775
			[Token(Token = "0x400262F")]
			[FieldOffset(Offset = "0x10")]
			private Cutscene _cutscene;

			// Token: 0x04002630 RID: 9776
			[Token(Token = "0x4002630")]
			[FieldOffset(Offset = "0x18")]
			private Coroutine _cameraRestrictionMovementCoroutine;

			// Token: 0x04002631 RID: 9777
			[Token(Token = "0x4002631")]
			[FieldOffset(Offset = "0x20")]
			private SimpleMouseRotator _cameraRotator;

			// Token: 0x02000670 RID: 1648
			[Token(Token = "0x2000670")]
			public enum Axis
			{
				// Token: 0x04002633 RID: 9779
				[Token(Token = "0x4002633")]
				X,
				// Token: 0x04002634 RID: 9780
				[Token(Token = "0x4002634")]
				Y
			}
		}

		// Token: 0x02000672 RID: 1650
		[Token(Token = "0x2000672")]
		protected class PlayerUtility
		{
			// Token: 0x06002B1A RID: 11034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B1A")]
			[Address(RVA = "0x3406D10", Offset = "0x3405310", VA = "0x183406D10")]
			public void EnableCamera(bool enable)
			{
			}

			// Token: 0x06002B1B RID: 11035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B1B")]
			[Address(RVA = "0x3406E80", Offset = "0x3405480", VA = "0x183406E80")]
			public void SnapToWorldPosition(Vector3 position)
			{
			}

			// Token: 0x06002B1C RID: 11036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B1C")]
			[Address(RVA = "0x3406F50", Offset = "0x3405550", VA = "0x183406F50")]
			public void SetWorldRotation(Quaternion rotation)
			{
			}

			// Token: 0x06002B1D RID: 11037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B1D")]
			[Address(RVA = "0x3407030", Offset = "0x3405630", VA = "0x183407030")]
			public void SnapToTransform(Transform snapTransform)
			{
			}

			// Token: 0x06002B1E RID: 11038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B1E")]
			[Address(RVA = "0x3407130", Offset = "0x3405730", VA = "0x183407130")]
			public void Lock()
			{
			}

			// Token: 0x06002B1F RID: 11039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B1F")]
			[Address(RVA = "0x3407280", Offset = "0x3405880", VA = "0x183407280")]
			public void Unlock()
			{
			}

			// Token: 0x06002B20 RID: 11040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B20")]
			[Address(RVA = "0x34073B0", Offset = "0x34059B0", VA = "0x1834073B0")]
			private static void SetRigidBodyLock(bool lockValue)
			{
			}

			// Token: 0x06002B21 RID: 11041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B21")]
			[Address(RVA = "0x3407690", Offset = "0x3405C90", VA = "0x183407690")]
			public void LockRigidBody()
			{
			}

			// Token: 0x06002B22 RID: 11042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B22")]
			[Address(RVA = "0x34076A0", Offset = "0x3405CA0", VA = "0x1834076A0")]
			public void UnlockRigidBody()
			{
			}

			// Token: 0x06002B23 RID: 11043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B23")]
			[Address(RVA = "0x34076B0", Offset = "0x3405CB0", VA = "0x1834076B0")]
			public void DisableCharacterCollision()
			{
			}

			// Token: 0x06002B24 RID: 11044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B24")]
			[Address(RVA = "0x3407700", Offset = "0x3405D00", VA = "0x183407700")]
			public void EnableCharacterCollision()
			{
			}

			// Token: 0x06002B25 RID: 11045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B25")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PlayerUtility()
			{
			}
		}
	}
}
