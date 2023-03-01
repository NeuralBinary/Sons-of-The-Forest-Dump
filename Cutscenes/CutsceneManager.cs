using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.Cutscenes
{
	// Token: 0x0200076A RID: 1898
	[Token(Token = "0x200076A")]
	public class CutsceneManager : MonoBehaviour
	{
		// Token: 0x060031B5 RID: 12725 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
		[Token(Token = "0x60031B5")]
		[Address(RVA = "0x2E3F7B0", Offset = "0x2E3E7B0", VA = "0x182E3F7B0")]
		public static bool IsCutscenePlaying()
		{
			return default(bool);
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		[Token(Token = "0x60031B6")]
		[Address(RVA = "0x2E40A80", Offset = "0x2E3FA80", VA = "0x182E40A80")]
		private bool SetupInstance()
		{
			return default(bool);
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B7")]
		[Address(RVA = "0x2E3EEF0", Offset = "0x2E3DEF0", VA = "0x182E3EEF0")]
		private void OnEnable()
		{
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B8")]
		[Address(RVA = "0x2E3EEF0", Offset = "0x2E3DEF0", VA = "0x182E3EEF0")]
		private void OnDisable()
		{
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B9")]
		[Address(RVA = "0x2E3EEF0", Offset = "0x2E3DEF0", VA = "0x182E3EEF0")]
		private void CleanupOldInstances()
		{
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031BA")]
		[Address(RVA = "0x2E3EF50", Offset = "0x2E3DF50", VA = "0x182E3EF50")]
		private void DestroyInstance(Cutscene targetCutsceneInstance)
		{
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031BB")]
		[Address(RVA = "0x2E3ECE0", Offset = "0x2E3DCE0", VA = "0x182E3ECE0")]
		private void Awake()
		{
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031BC")]
		[Address(RVA = "0x2E3FB50", Offset = "0x2E3EB50", VA = "0x182E3FB50")]
		private void OnDestroy()
		{
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031BD")]
		[Address(RVA = "0x2E409D0", Offset = "0x2E3F9D0", VA = "0x182E409D0")]
		private void SetupDebugCommands()
		{
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031BE")]
		[Address(RVA = "0x2E41750", Offset = "0x2E40750", VA = "0x182E41750")]
		private void Start()
		{
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031BF")]
		[Address(RVA = "0x2E41B40", Offset = "0x2E40B40", VA = "0x182E41B40")]
		public static void TriggerOpeningCutscene()
		{
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C0")]
		[Address(RVA = "0x2E41870", Offset = "0x2E40870", VA = "0x182E41870")]
		private void TriggerOpeningCutsceneInternal()
		{
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C1")]
		[Address(RVA = "0x2E40000", Offset = "0x2E3F000", VA = "0x182E40000")]
		private void PlayOpeningCutscene(bool force = false, string crashCutscene = "")
		{
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C2")]
		[Address(RVA = "0x2E42060", Offset = "0x2E41060", VA = "0x182E42060")]
		private void VerifyFadeFromBlackCutscene()
		{
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C3")]
		[Address(RVA = "0x2E3FBE0", Offset = "0x2E3EBE0", VA = "0x182E3FBE0")]
		public void OnGameLoadedFromSave()
		{
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C4")]
		[Address(RVA = "0x2E3F370", Offset = "0x2E3E370", VA = "0x182E3F370")]
		private Cutscene FindCutsceneById(string crashSiteId)
		{
			return null;
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C5")]
		[Address(RVA = "0x2E3F1D0", Offset = "0x2E3E1D0", VA = "0x182E3F1D0")]
		private Cutscene FindCutsceneByIdInternal(string crashSiteId)
		{
			return null;
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C6")]
		[Address(RVA = "0x2E41F40", Offset = "0x2E40F40", VA = "0x182E41F40")]
		private void Update()
		{
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C7")]
		[Address(RVA = "0x2E40BE0", Offset = "0x2E3FBE0", VA = "0x182E40BE0")]
		private void SkipActiveCutsceneInternal()
		{
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C8")]
		[Address(RVA = "0x2E3F710", Offset = "0x2E3E710", VA = "0x182E3F710")]
		public static Cutscene GetActiveCutScene()
		{
			return null;
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C9")]
		[Address(RVA = "0x2E40CC0", Offset = "0x2E3FCC0", VA = "0x182E40CC0")]
		public static void SkipActiveCutscene()
		{
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x0000E310 File Offset: 0x0000C510
		[Token(Token = "0x60031CA")]
		[Address(RVA = "0x2E3EBD0", Offset = "0x2E3DBD0", VA = "0x182E3EBD0")]
		public static bool AddCutscene(Cutscene cutscene)
		{
			return default(bool);
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x0000E328 File Offset: 0x0000C528
		[Token(Token = "0x60031CB")]
		[Address(RVA = "0x2E40740", Offset = "0x2E3F740", VA = "0x182E40740")]
		public static bool QueueNextCutscene(string cutsceneName)
		{
			return default(bool);
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CC")]
		[Address(RVA = "0x2E3F6E0", Offset = "0x2E3E6E0", VA = "0x182E3F6E0")]
		private static Cutscene FindCutscene(string search)
		{
			return null;
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x0000E340 File Offset: 0x0000C540
		[Token(Token = "0x60031CD")]
		[Address(RVA = "0x2E41C10", Offset = "0x2E40C10", VA = "0x182E41C10")]
		private static bool TryFindCutscene(string cutsceneName, out Cutscene cutscene)
		{
			return default(bool);
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x0000E358 File Offset: 0x0000C558
		[Token(Token = "0x60031CE")]
		[Address(RVA = "0x2E3EFD0", Offset = "0x2E3DFD0", VA = "0x182E3EFD0")]
		private static bool FindCutsceneByAlias(string cutsceneName, ref Cutscene cutscene)
		{
			return default(bool);
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CF")]
		[Address(RVA = "0x2E3F5F0", Offset = "0x2E3E5F0", VA = "0x182E3F5F0")]
		private static Cutscene FindCutsceneByName(string cutsceneName)
		{
			return null;
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031D0")]
		[Address(RVA = "0x2E3F460", Offset = "0x2E3E460", VA = "0x182E3F460")]
		private Cutscene FindCutsceneByNameInternal(string cutsceneName)
		{
			return null;
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D1")]
		[Address(RVA = "0x2E405F0", Offset = "0x2E3F5F0", VA = "0x182E405F0")]
		public static void QueueNextCutscene(Cutscene nextCutscene)
		{
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D2")]
		[Address(RVA = "0x2E40450", Offset = "0x2E3F450", VA = "0x182E40450")]
		private static void QueueNextCutsceneInternal(Cutscene cutscene)
		{
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D3")]
		[Address(RVA = "0x2E40910", Offset = "0x2E3F910", VA = "0x182E40910")]
		public static void RemoveCutscene(Cutscene cutscene)
		{
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x0000E370 File Offset: 0x0000C570
		[Token(Token = "0x60031D4")]
		[Address(RVA = "0x2E41370", Offset = "0x2E40370", VA = "0x182E41370")]
		public static bool StartCutscene(string arguments)
		{
			return default(bool);
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x0000E388 File Offset: 0x0000C588
		[Token(Token = "0x60031D5")]
		[Address(RVA = "0x2E3F8D0", Offset = "0x2E3E8D0", VA = "0x182E3F8D0")]
		private static bool MatchesOpeningCutscene(string cutsceneName)
		{
			return default(bool);
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		[Token(Token = "0x60031D6")]
		[Address(RVA = "0x2E41600", Offset = "0x2E40600", VA = "0x182E41600")]
		public static bool StartCutscene(Cutscene cutscene)
		{
			return default(bool);
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		[Token(Token = "0x60031D7")]
		[Address(RVA = "0x2E40D60", Offset = "0x2E3FD60", VA = "0x182E40D60")]
		private static bool StartCutsceneInternal(Cutscene cutscene)
		{
			return default(bool);
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D8")]
		[Address(RVA = "0x2E3F9F0", Offset = "0x2E3E9F0", VA = "0x182E3F9F0")]
		private void OnCutsceneEnded()
		{
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D9")]
		[Address(RVA = "0x2E41790", Offset = "0x2E40790", VA = "0x182E41790")]
		public static void StopActiveCutscene()
		{
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DA")]
		[Address(RVA = "0x2E3F870", Offset = "0x2E3E870", VA = "0x182E3F870")]
		public static void LockInputState(bool value)
		{
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DB")]
		[Address(RVA = "0x2E40BA0", Offset = "0x2E3FBA0", VA = "0x182E40BA0")]
		public static void ShowSkip(bool value)
		{
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DC")]
		[Address(RVA = "0x2E41D70", Offset = "0x2E40D70", VA = "0x182E41D70")]
		public static void TryStopCutscene(Cutscene targetCutscene)
		{
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DD")]
		[Address(RVA = "0x2E42160", Offset = "0x2E41160", VA = "0x182E42160")]
		public CutsceneManager()
		{
		}

		// Token: 0x04002B72 RID: 11122
		[Token(Token = "0x4002B72")]
		internal const string CutsceneSkipId = "cutscene.skip";

		// Token: 0x04002B73 RID: 11123
		[Token(Token = "0x4002B73")]
		[FieldOffset(Offset = "0x0")]
		private static CutsceneManager _instance;

		// Token: 0x04002B74 RID: 11124
		[Token(Token = "0x4002B74")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _skipDelay;

		// Token: 0x04002B75 RID: 11125
		[Token(Token = "0x4002B75")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _inputState;

		// Token: 0x04002B76 RID: 11126
		[Token(Token = "0x4002B76")]
		[FieldOffset(Offset = "0x30")]
		private Cutscene _activeCutscene;

		// Token: 0x04002B77 RID: 11127
		[Token(Token = "0x4002B77")]
		[FieldOffset(Offset = "0x38")]
		private Cutscene _queuedCutscene;

		// Token: 0x04002B78 RID: 11128
		[Token(Token = "0x4002B78")]
		[FieldOffset(Offset = "0x40")]
		private UnityEvent _onCutsceneStartedEvent;

		// Token: 0x04002B79 RID: 11129
		[Token(Token = "0x4002B79")]
		[FieldOffset(Offset = "0x48")]
		private UnityEvent _onCutsceneEndedEvent;

		// Token: 0x04002B7A RID: 11130
		[Token(Token = "0x4002B7A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Cutscene> _cutscenes;

		// Token: 0x04002B7B RID: 11131
		[Token(Token = "0x4002B7B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _openingCutscene;

		// Token: 0x04002B7C RID: 11132
		[Token(Token = "0x4002B7C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[FormerlySerializedAs("_fadeFromBlackCutscene")]
		private GameObject _fadeFromBlackCutsceneAsset;

		// Token: 0x04002B7D RID: 11133
		[Token(Token = "0x4002B7D")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private OpeningCutscene _openingCutsceneInstance;

		// Token: 0x04002B7E RID: 11134
		[Token(Token = "0x4002B7E")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private Cutscene _fadeFromBlackCutsceneInstance;
	}
}
