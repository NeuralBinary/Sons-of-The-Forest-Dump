using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.Cutscenes
{
	// Token: 0x02000675 RID: 1653
	[Token(Token = "0x2000675")]
	public class CutsceneManager : MonoBehaviour
	{
		// Token: 0x06002B2C RID: 11052 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		[Token(Token = "0x6002B2C")]
		[Address(RVA = "0x34079D0", Offset = "0x3405FD0", VA = "0x1834079D0")]
		public static bool IsCutscenePlaying()
		{
			return default(bool);
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		[Token(Token = "0x6002B2D")]
		[Address(RVA = "0x3407B50", Offset = "0x3406150", VA = "0x183407B50")]
		private bool SetupInstance()
		{
			return default(bool);
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B2E")]
		[Address(RVA = "0x3407DF0", Offset = "0x34063F0", VA = "0x183407DF0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B2F")]
		[Address(RVA = "0x3407DF0", Offset = "0x34063F0", VA = "0x183407DF0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B30")]
		[Address(RVA = "0x3407E00", Offset = "0x3406400", VA = "0x183407E00")]
		private void CleanupOldInstances()
		{
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B31")]
		[Address(RVA = "0x3407EF0", Offset = "0x34064F0", VA = "0x183407EF0")]
		private void DestroyInstance(Cutscene targetCutsceneInstance)
		{
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B32")]
		[Address(RVA = "0x3407FD0", Offset = "0x34065D0", VA = "0x183407FD0")]
		private void Awake()
		{
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B33")]
		[Address(RVA = "0x3408100", Offset = "0x3406700", VA = "0x183408100")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B34")]
		[Address(RVA = "0x3408190", Offset = "0x3406790", VA = "0x183408190")]
		private void SetupDebugCommands()
		{
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B35")]
		[Address(RVA = "0x3408240", Offset = "0x3406840", VA = "0x183408240")]
		private void Start()
		{
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B36")]
		[Address(RVA = "0x3408280", Offset = "0x3406880", VA = "0x183408280")]
		public static void TriggerOpeningCutscene()
		{
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B37")]
		[Address(RVA = "0x34083E0", Offset = "0x34069E0", VA = "0x1834083E0")]
		private void TriggerOpeningCutsceneInternal()
		{
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B38")]
		[Address(RVA = "0x3408800", Offset = "0x3406E00", VA = "0x183408800")]
		private void PlayOpeningCutscene(bool force = false, string crashCutscene = "")
		{
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B39")]
		[Address(RVA = "0x3408BD0", Offset = "0x34071D0", VA = "0x183408BD0")]
		private void VerifyFadeFromBlackCutscene()
		{
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3A")]
		[Address(RVA = "0x3408D80", Offset = "0x3407380", VA = "0x183408D80")]
		public void OnGameLoadedFromSave()
		{
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B3B")]
		[Address(RVA = "0x3409410", Offset = "0x3407A10", VA = "0x183409410")]
		private Cutscene FindCutsceneById(string crashSiteId)
		{
			return null;
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B3C")]
		[Address(RVA = "0x3409560", Offset = "0x3407B60", VA = "0x183409560")]
		private Cutscene FindCutsceneByIdInternal(string crashSiteId)
		{
			return null;
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3D")]
		[Address(RVA = "0x3409800", Offset = "0x3407E00", VA = "0x183409800")]
		private void Update()
		{
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3E")]
		[Address(RVA = "0x34099B0", Offset = "0x3407FB0", VA = "0x1834099B0")]
		private void SkipActiveCutsceneInternal()
		{
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B3F")]
		[Address(RVA = "0x3409AF0", Offset = "0x34080F0", VA = "0x183409AF0")]
		public static Cutscene GetActiveCutScene()
		{
			return null;
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B40")]
		[Address(RVA = "0x3409BE0", Offset = "0x34081E0", VA = "0x183409BE0")]
		public static void SkipActiveCutscene()
		{
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		[Token(Token = "0x6002B41")]
		[Address(RVA = "0x3409CD0", Offset = "0x34082D0", VA = "0x183409CD0")]
		public static bool AddCutscene(Cutscene cutscene)
		{
			return default(bool);
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x0000CC00 File Offset: 0x0000AE00
		[Token(Token = "0x6002B42")]
		[Address(RVA = "0x3409E30", Offset = "0x3408430", VA = "0x183409E30")]
		public static bool QueueNextCutscene(string cutsceneName)
		{
			return default(bool);
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B43")]
		[Address(RVA = "0x340A1A0", Offset = "0x34087A0", VA = "0x18340A1A0")]
		private static Cutscene FindCutscene(string search)
		{
			return null;
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x0000CC18 File Offset: 0x0000AE18
		[Token(Token = "0x6002B44")]
		[Address(RVA = "0x340A1D0", Offset = "0x34087D0", VA = "0x18340A1D0")]
		private static bool TryFindCutscene(string cutsceneName, out Cutscene cutscene)
		{
			return default(bool);
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x0000CC30 File Offset: 0x0000AE30
		[Token(Token = "0x6002B45")]
		[Address(RVA = "0x340A5B0", Offset = "0x3408BB0", VA = "0x18340A5B0")]
		private static bool FindCutsceneByAlias(string cutsceneName, ref Cutscene cutscene)
		{
			return default(bool);
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B46")]
		[Address(RVA = "0x340A8A0", Offset = "0x3408EA0", VA = "0x18340A8A0")]
		private static Cutscene FindCutsceneByName(string cutsceneName)
		{
			return null;
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B47")]
		[Address(RVA = "0x340A9F0", Offset = "0x3408FF0", VA = "0x18340A9F0")]
		private Cutscene FindCutsceneByNameInternal(string cutsceneName)
		{
			return null;
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B48")]
		[Address(RVA = "0x340AC80", Offset = "0x3409280", VA = "0x18340AC80")]
		public static void QueueNextCutscene(Cutscene nextCutscene)
		{
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B49")]
		[Address(RVA = "0x340AE20", Offset = "0x3409420", VA = "0x18340AE20")]
		private static void QueueNextCutsceneInternal(Cutscene cutscene)
		{
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B4A")]
		[Address(RVA = "0x340B160", Offset = "0x3409760", VA = "0x18340B160")]
		public static void RemoveCutscene(Cutscene cutscene)
		{
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x0000CC48 File Offset: 0x0000AE48
		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0x340B280", Offset = "0x3409880", VA = "0x18340B280")]
		public static bool StartCutscene(string arguments)
		{
			return default(bool);
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x0000CC60 File Offset: 0x0000AE60
		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x340B4A0", Offset = "0x3409AA0", VA = "0x18340B4A0")]
		private static bool MatchesOpeningCutscene(string cutsceneName)
		{
			return default(bool);
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x0000CC78 File Offset: 0x0000AE78
		[Token(Token = "0x6002B4D")]
		[Address(RVA = "0x340B680", Offset = "0x3409C80", VA = "0x18340B680")]
		public static bool StartCutscene(Cutscene cutscene)
		{
			return default(bool);
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x0000CC90 File Offset: 0x0000AE90
		[Token(Token = "0x6002B4E")]
		[Address(RVA = "0x340B820", Offset = "0x3409E20", VA = "0x18340B820")]
		private static bool StartCutsceneInternal(Cutscene cutscene)
		{
			return default(bool);
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B4F")]
		[Address(RVA = "0x340BFA0", Offset = "0x340A5A0", VA = "0x18340BFA0")]
		private void OnCutsceneEnded()
		{
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B50")]
		[Address(RVA = "0x340C270", Offset = "0x340A870", VA = "0x18340C270")]
		public static void StopActiveCutscene()
		{
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B51")]
		[Address(RVA = "0x340C3F0", Offset = "0x340A9F0", VA = "0x18340C3F0")]
		public static void LockInputState(bool value)
		{
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B52")]
		[Address(RVA = "0x340C490", Offset = "0x340AA90", VA = "0x18340C490")]
		public static void ShowSkip(bool value)
		{
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B53")]
		[Address(RVA = "0x340C4D0", Offset = "0x340AAD0", VA = "0x18340C4D0")]
		public static void TryStopCutscene(Cutscene targetCutscene)
		{
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B54")]
		[Address(RVA = "0x340C870", Offset = "0x340AE70", VA = "0x18340C870")]
		public CutsceneManager()
		{
		}

		// Token: 0x04002645 RID: 9797
		[Token(Token = "0x4002645")]
		internal const string CutsceneSkipId = "cutscene.skip";

		// Token: 0x04002646 RID: 9798
		[Token(Token = "0x4002646")]
		[FieldOffset(Offset = "0x0")]
		private static CutsceneManager _instance;

		// Token: 0x04002647 RID: 9799
		[Token(Token = "0x4002647")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _skipDelay;

		// Token: 0x04002648 RID: 9800
		[Token(Token = "0x4002648")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _inputState;

		// Token: 0x04002649 RID: 9801
		[Token(Token = "0x4002649")]
		[FieldOffset(Offset = "0x30")]
		private Cutscene _activeCutscene;

		// Token: 0x0400264A RID: 9802
		[Token(Token = "0x400264A")]
		[FieldOffset(Offset = "0x38")]
		private Cutscene _queuedCutscene;

		// Token: 0x0400264B RID: 9803
		[Token(Token = "0x400264B")]
		[FieldOffset(Offset = "0x40")]
		private UnityEvent _onCutsceneStartedEvent;

		// Token: 0x0400264C RID: 9804
		[Token(Token = "0x400264C")]
		[FieldOffset(Offset = "0x48")]
		private UnityEvent _onCutsceneEndedEvent;

		// Token: 0x0400264D RID: 9805
		[Token(Token = "0x400264D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Cutscene> _cutscenes;

		// Token: 0x0400264E RID: 9806
		[Token(Token = "0x400264E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _openingCutscene;

		// Token: 0x0400264F RID: 9807
		[Token(Token = "0x400264F")]
		[FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("_fadeFromBlackCutscene")]
		[SerializeField]
		private GameObject _fadeFromBlackCutsceneAsset;

		// Token: 0x04002650 RID: 9808
		[Token(Token = "0x4002650")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private OpeningCutscene _openingCutsceneInstance;

		// Token: 0x04002651 RID: 9809
		[Token(Token = "0x4002651")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private Cutscene _fadeFromBlackCutsceneInstance;
	}
}
