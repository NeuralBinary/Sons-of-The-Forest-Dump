using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Sequence;
using UnityEngine;

namespace Sons.Scene
{
	// Token: 0x02000534 RID: 1332
	[Token(Token = "0x2000534")]
	public class SceneSequencer : Sequencer
	{
		// Token: 0x06002353 RID: 9043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002353")]
		[Address(RVA = "0x334C4A0", Offset = "0x334AAA0", VA = "0x18334C4A0")]
		private void Update()
		{
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002354")]
		[Address(RVA = "0x334C540", Offset = "0x334AB40", VA = "0x18334C540")]
		private void CheckStageEnd(SceneSequenceStage activeStage)
		{
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002355")]
		[Address(RVA = "0x334C5E0", Offset = "0x334ABE0", VA = "0x18334C5E0")]
		private void Awake()
		{
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002356")]
		[Address(RVA = "0x334C810", Offset = "0x334AE10", VA = "0x18334C810")]
		private void SetSceneStart()
		{
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002357")]
		[Address(RVA = "0x334C430", Offset = "0x334AA30", VA = "0x18334C430")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002358")]
		[Address(RVA = "0x334C910", Offset = "0x334AF10", VA = "0x18334C910")]
		private void GoToNextScene()
		{
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002359")]
		[Address(RVA = "0x334CA40", Offset = "0x334B040", VA = "0x18334CA40")]
		private void LoadScene(SceneSequenceStage stage)
		{
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235A")]
		[Address(RVA = "0x334CAE0", Offset = "0x334B0E0", VA = "0x18334CAE0")]
		private void FinalizeSequence()
		{
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235B")]
		[Address(RVA = "0x334CB40", Offset = "0x334B140", VA = "0x18334CB40", Slot = "5")]
		protected override void StartEvent(SequenceEventHandler sender)
		{
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235C")]
		[Address(RVA = "0x334CBE0", Offset = "0x334B1E0", VA = "0x18334CBE0", Slot = "4")]
		protected override void EndEvent(SequenceEventHandler sender)
		{
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235D")]
		[Address(RVA = "0x32EF700", Offset = "0x32EDD00", VA = "0x1832EF700")]
		public SceneSequencer()
		{
		}

		// Token: 0x04001FF8 RID: 8184
		[Token(Token = "0x4001FF8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SceneSequenceStage> _sceneSequence;

		// Token: 0x04001FF9 RID: 8185
		[Token(Token = "0x4001FF9")]
		[FieldOffset(Offset = "0x30")]
		private int _currentSceneIndex;

		// Token: 0x04001FFA RID: 8186
		[Token(Token = "0x4001FFA")]
		[FieldOffset(Offset = "0x38")]
		private SceneSequenceStage _activeStage;

		// Token: 0x04001FFB RID: 8187
		[Token(Token = "0x4001FFB")]
		[FieldOffset(Offset = "0x40")]
		private float _activeStageStart;
	}
}
