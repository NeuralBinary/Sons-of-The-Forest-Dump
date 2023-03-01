using System;
using System.Collections.Generic;
using Ashkatchap.AnimatorEvents;
using FMOD;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000882 RID: 2178
	[Token(Token = "0x2000882")]
	[AddComponentMenu("Sons/Animation/Animation Audio Event Manager")]
	public class AnimationAudioEventManager : MonoBehaviour
	{
		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x000112C8 File Offset: 0x0000F4C8
		[Token(Token = "0x17000728")]
		private bool PrefabValid
		{
			[Token(Token = "0x6003A72")]
			[Address(RVA = "0x2EF2DC0", Offset = "0x2EF1DC0", VA = "0x182EF2DC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A73")]
		[Address(RVA = "0x2EF2D20", Offset = "0x2EF1D20", VA = "0x182EF2D20")]
		public AnimationAudioEventManager()
		{
		}

		// Token: 0x04003180 RID: 12672
		[Token(Token = "0x4003180")]
		internal const string InlineAutoPrefix = "Inline/AUTO";

		// Token: 0x04003181 RID: 12673
		[Token(Token = "0x4003181")]
		private const string GetCurrentStateNameMethodName = "GetCurrentStateName";

		// Token: 0x04003182 RID: 12674
		[Token(Token = "0x4003182")]
		private const string GetNextStateNameMethodName = "GetNextStateName";

		// Token: 0x04003183 RID: 12675
		[Token(Token = "0x4003183")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x04003184 RID: 12676
		[Token(Token = "0x4003184")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _prefabSubPath;

		// Token: 0x04003185 RID: 12677
		[Token(Token = "0x4003185")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _targetAnimator;

		// Token: 0x04003186 RID: 12678
		[Token(Token = "0x4003186")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RuntimeAnimatorController _overrideAnimatorController;

		// Token: 0x04003187 RID: 12679
		[Token(Token = "0x4003187")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimatorEvent _targetAnimatorEvent;

		// Token: 0x04003188 RID: 12680
		[Token(Token = "0x4003188")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FMOD_AnimationEventHandler _targetFmodEventHandler;

		// Token: 0x04003189 RID: 12681
		[Token(Token = "0x4003189")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<AnimationAudioEventManager.AnimationAudioEvent> _events;

		// Token: 0x0400318A RID: 12682
		[Token(Token = "0x400318A")]
		private const int PreparedConditionsIndexFirstOnly = 5;

		// Token: 0x0400318B RID: 12683
		[Token(Token = "0x400318B")]
		private const int PreparedConditionsIndex = 11;

		// Token: 0x0400318C RID: 12684
		[Token(Token = "0x400318C")]
		private const int OnStateExitTransitionEndConditionsIndex = 4;

		// Token: 0x0400318D RID: 12685
		[Token(Token = "0x400318D")]
		[FieldOffset(Offset = "0x58")]
		private RuntimeAnimatorController _targetController;

		// Token: 0x0400318E RID: 12686
		[Token(Token = "0x400318E")]
		[FieldOffset(Offset = "0x60")]
		private bool _pendingRefresh;

		// Token: 0x02000883 RID: 2179
		[Token(Token = "0x2000883")]
		[Serializable]
		public class AnimationAudioEvent
		{
			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x06003A74 RID: 14964 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000729")]
			private string GetFmodGroupLabel
			{
				[Token(Token = "0x6003A74")]
				[Address(RVA = "0x2EF2ED0", Offset = "0x2EF1ED0", VA = "0x182EF2ED0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x06003A75 RID: 14965 RVA: 0x000112E0 File Offset: 0x0000F4E0
			[Token(Token = "0x1700072A")]
			public bool Ignore
			{
				[Token(Token = "0x6003A75")]
				[Address(RVA = "0x576380", Offset = "0x575380", VA = "0x180576380")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003A76 RID: 14966 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A76")]
			[Address(RVA = "0x2EF2E10", Offset = "0x2EF1E10", VA = "0x182EF2E10")]
			private string FmodGroupLabelSuffix()
			{
				return null;
			}

			// Token: 0x06003A77 RID: 14967 RVA: 0x000112F8 File Offset: 0x0000F4F8
			[Token(Token = "0x6003A77")]
			[Address(RVA = "0x2EF2EB0", Offset = "0x2EF1EB0", VA = "0x182EF2EB0")]
			public int GetConditionsIndex()
			{
				return default(int);
			}

			// Token: 0x06003A78 RID: 14968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A78")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public AnimationAudioEvent()
			{
			}

			// Token: 0x0400318F RID: 12687
			[Token(Token = "0x400318F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _ignore;

			// Token: 0x04003190 RID: 12688
			[Token(Token = "0x4003190")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _animationState;

			// Token: 0x04003191 RID: 12689
			[Token(Token = "0x4003191")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Range(0f, 1f)]
			[HideInInspector]
			private float _normalizedTime;

			// Token: 0x04003192 RID: 12690
			[Token(Token = "0x4003192")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			[Range(0f, 100f)]
			private float _normalizedTimePercent;

			// Token: 0x04003193 RID: 12691
			[Token(Token = "0x4003193")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			[HideInInspector]
			private bool _convertedToPercent;

			// Token: 0x04003194 RID: 12692
			[Token(Token = "0x4003194")]
			[FieldOffset(Offset = "0x30")]
			[EventRef]
			[SerializeField]
			private string _eventPath;

			// Token: 0x04003195 RID: 12693
			[Token(Token = "0x4003195")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private bool _firstOnly;

			// Token: 0x04003196 RID: 12694
			[Token(Token = "0x4003196")]
			[FieldOffset(Offset = "0x39")]
			[SerializeField]
			internal bool _stopEvent;

			// Token: 0x04003197 RID: 12695
			[Token(Token = "0x4003197")]
			[FieldOffset(Offset = "0x3A")]
			[SerializeField]
			internal bool _stopOnExit;

			// Token: 0x04003198 RID: 12696
			[Token(Token = "0x4003198")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Animator _targetAnimator;

			// Token: 0x04003199 RID: 12697
			[Token(Token = "0x4003199")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private string _animEventPath;

			// Token: 0x0400319A RID: 12698
			[Token(Token = "0x400319A")]
			[FieldOffset(Offset = "0x50")]
			[HideInInspector]
			[SerializeField]
			private RuntimeAnimatorController _targetController;
		}
	}
}
