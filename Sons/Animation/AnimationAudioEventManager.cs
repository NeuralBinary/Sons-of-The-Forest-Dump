using System;
using System.Collections.Generic;
using Ashkatchap.AnimatorEvents;
using FMOD;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008F4 RID: 2292
	[Token(Token = "0x20008F4")]
	[AddComponentMenu("Sons/Animation/Animation Audio Event Manager")]
	public class AnimationAudioEventManager : MonoBehaviour
	{
		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x0600419B RID: 16795 RVA: 0x00014160 File Offset: 0x00012360
		[Token(Token = "0x1700084D")]
		private bool PrefabValid
		{
			[Token(Token = "0x600419B")]
			[Address(RVA = "0x362B870", Offset = "0x3629E70", VA = "0x18362B870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600419C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void CheckRefreshController()
		{
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600419D")]
		[Address(RVA = "0x362B930", Offset = "0x3629F30", VA = "0x18362B930")]
		public AnimationAudioEventManager()
		{
		}

		// Token: 0x0400364A RID: 13898
		[Token(Token = "0x400364A")]
		internal const string InlineAutoPrefix = "Inline/AUTO";

		// Token: 0x0400364B RID: 13899
		[Token(Token = "0x400364B")]
		private const string GetCurrentStateNameMethodName = "GetCurrentStateName";

		// Token: 0x0400364C RID: 13900
		[Token(Token = "0x400364C")]
		private const string GetNextStateNameMethodName = "GetNextStateName";

		// Token: 0x0400364D RID: 13901
		[Token(Token = "0x400364D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x0400364E RID: 13902
		[Token(Token = "0x400364E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _prefabSubPath;

		// Token: 0x0400364F RID: 13903
		[Token(Token = "0x400364F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _targetAnimator;

		// Token: 0x04003650 RID: 13904
		[Token(Token = "0x4003650")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RuntimeAnimatorController _overrideAnimatorController;

		// Token: 0x04003651 RID: 13905
		[Token(Token = "0x4003651")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimatorEvent _targetAnimatorEvent;

		// Token: 0x04003652 RID: 13906
		[Token(Token = "0x4003652")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FMOD_AnimationEventHandler _targetFmodEventHandler;

		// Token: 0x04003653 RID: 13907
		[Token(Token = "0x4003653")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<AnimationAudioEventManager.AnimationAudioEvent> _events;

		// Token: 0x04003654 RID: 13908
		[Token(Token = "0x4003654")]
		private const int PreparedConditionsIndexFirstOnly = 5;

		// Token: 0x04003655 RID: 13909
		[Token(Token = "0x4003655")]
		private const int PreparedConditionsIndex = 11;

		// Token: 0x04003656 RID: 13910
		[Token(Token = "0x4003656")]
		private const int OnStateExitTransitionEndConditionsIndex = 4;

		// Token: 0x04003657 RID: 13911
		[Token(Token = "0x4003657")]
		[FieldOffset(Offset = "0x58")]
		private RuntimeAnimatorController _targetController;

		// Token: 0x04003658 RID: 13912
		[Token(Token = "0x4003658")]
		[FieldOffset(Offset = "0x60")]
		private bool _pendingRefresh;

		// Token: 0x04003659 RID: 13913
		[Token(Token = "0x4003659")]
		[FieldOffset(Offset = "0x64")]
		private int _prevEventsCount;

		// Token: 0x020008F5 RID: 2293
		[Token(Token = "0x20008F5")]
		[Serializable]
		public class AnimationAudioEvent
		{
			// Token: 0x1700084E RID: 2126
			// (get) Token: 0x0600419E RID: 16798 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700084E")]
			private string GetFmodGroupLabel
			{
				[Token(Token = "0x600419E")]
				[Address(RVA = "0x362BA90", Offset = "0x362A090", VA = "0x18362BA90")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700084F RID: 2127
			// (get) Token: 0x0600419F RID: 16799 RVA: 0x00014178 File Offset: 0x00012378
			[Token(Token = "0x1700084F")]
			public bool Ignore
			{
				[Token(Token = "0x600419F")]
				[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060041A0 RID: 16800 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60041A0")]
			[Address(RVA = "0x362BAE0", Offset = "0x362A0E0", VA = "0x18362BAE0")]
			private string FmodGroupLabelSuffix()
			{
				return null;
			}

			// Token: 0x060041A1 RID: 16801 RVA: 0x00014190 File Offset: 0x00012390
			[Token(Token = "0x60041A1")]
			[Address(RVA = "0x362BD90", Offset = "0x362A390", VA = "0x18362BD90")]
			public int GetConditionsIndex()
			{
				return 0;
			}

			// Token: 0x060041A2 RID: 16802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60041A2")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public AnimationAudioEvent()
			{
			}

			// Token: 0x0400365A RID: 13914
			[Token(Token = "0x400365A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _ignore;

			// Token: 0x0400365B RID: 13915
			[Token(Token = "0x400365B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _animationState;

			// Token: 0x0400365C RID: 13916
			[Token(Token = "0x400365C")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Range(0f, 1f)]
			[HideInInspector]
			private float _normalizedTime;

			// Token: 0x0400365D RID: 13917
			[Token(Token = "0x400365D")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			[Range(0f, 100f)]
			private float _normalizedTimePercent;

			// Token: 0x0400365E RID: 13918
			[Token(Token = "0x400365E")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			[HideInInspector]
			private bool _convertedToPercent;

			// Token: 0x0400365F RID: 13919
			[Token(Token = "0x400365F")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			[EventRef]
			private string _eventPath;

			// Token: 0x04003660 RID: 13920
			[Token(Token = "0x4003660")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private bool _firstOnly;

			// Token: 0x04003661 RID: 13921
			[Token(Token = "0x4003661")]
			[FieldOffset(Offset = "0x39")]
			[SerializeField]
			internal bool _stopEvent;

			// Token: 0x04003662 RID: 13922
			[Token(Token = "0x4003662")]
			[FieldOffset(Offset = "0x3A")]
			[SerializeField]
			internal bool _stopOnExit;

			// Token: 0x04003663 RID: 13923
			[Token(Token = "0x4003663")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Animator _targetAnimator;

			// Token: 0x04003664 RID: 13924
			[Token(Token = "0x4003664")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private string _animEventPath;

			// Token: 0x04003665 RID: 13925
			[Token(Token = "0x4003665")]
			[FieldOffset(Offset = "0x50")]
			[HideInInspector]
			[SerializeField]
			private RuntimeAnimatorController _targetController;
		}
	}
}
