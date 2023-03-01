using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Sequence;
using UnityEngine;

namespace Sons.Scene
{
	// Token: 0x0200052C RID: 1324
	[Token(Token = "0x200052C")]
	public class SceneSequencer : Sequencer
	{
		// Token: 0x06002266 RID: 8806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002266")]
		[Address(RVA = "0x2D68100", Offset = "0x2D67100", VA = "0x182D68100")]
		private void Update()
		{
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002267")]
		[Address(RVA = "0x2D67C60", Offset = "0x2D66C60", VA = "0x182D67C60")]
		private void CheckStageEnd(SceneSequenceStage activeStage)
		{
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002268")]
		[Address(RVA = "0x2D67A80", Offset = "0x2D66A80", VA = "0x182D67A80")]
		private void Awake()
		{
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002269")]
		[Address(RVA = "0x2D67FF0", Offset = "0x2D66FF0", VA = "0x182D67FF0")]
		private void SetSceneStart()
		{
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226A")]
		[Address(RVA = "0x2D67F80", Offset = "0x2D66F80", VA = "0x182D67F80")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226B")]
		[Address(RVA = "0x2D67DD0", Offset = "0x2D66DD0", VA = "0x182D67DD0")]
		private void GoToNextScene()
		{
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226C")]
		[Address(RVA = "0x2D67F20", Offset = "0x2D66F20", VA = "0x182D67F20")]
		private void LoadScene(SceneSequenceStage stage)
		{
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226D")]
		[Address(RVA = "0x2D67D70", Offset = "0x2D66D70", VA = "0x182D67D70")]
		private void FinalizeSequence()
		{
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226E")]
		[Address(RVA = "0x2D68060", Offset = "0x2D67060", VA = "0x182D68060", Slot = "5")]
		protected override void StartEvent(SequenceEventHandler sender)
		{
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226F")]
		[Address(RVA = "0x2D67CC0", Offset = "0x2D66CC0", VA = "0x182D67CC0", Slot = "4")]
		protected override void EndEvent(SequenceEventHandler sender)
		{
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002270")]
		[Address(RVA = "0x2D0F010", Offset = "0x2D0E010", VA = "0x182D0F010")]
		public SceneSequencer()
		{
		}

		// Token: 0x04001F44 RID: 8004
		[Token(Token = "0x4001F44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SceneSequenceStage> _sceneSequence;

		// Token: 0x04001F45 RID: 8005
		[Token(Token = "0x4001F45")]
		[FieldOffset(Offset = "0x30")]
		private int _currentSceneIndex;

		// Token: 0x04001F46 RID: 8006
		[Token(Token = "0x4001F46")]
		[FieldOffset(Offset = "0x38")]
		private SceneSequenceStage _activeStage;

		// Token: 0x04001F47 RID: 8007
		[Token(Token = "0x4001F47")]
		[FieldOffset(Offset = "0x40")]
		private float _activeStageStart;
	}
}
