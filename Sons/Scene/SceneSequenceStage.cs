using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Scene
{
	// Token: 0x02000535 RID: 1333
	[Token(Token = "0x2000535")]
	[Serializable]
	public class SceneSequenceStage
	{
		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x0000A680 File Offset: 0x00008880
		[Token(Token = "0x170004BF")]
		public bool IsCinematic
		{
			[Token(Token = "0x600235E")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235F")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public string GetSceneName()
		{
			return null;
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x0000A698 File Offset: 0x00008898
		[Token(Token = "0x6002360")]
		[Address(RVA = "0x334CC90", Offset = "0x334B290", VA = "0x18334CC90")]
		public double GetAutomaticEndTimer()
		{
			return 0.0;
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002361")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SceneSequenceStage()
		{
		}

		// Token: 0x04001FFC RID: 8188
		[Token(Token = "0x4001FFC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _scene;

		// Token: 0x04001FFD RID: 8189
		[Token(Token = "0x4001FFD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _cinematic;

		// Token: 0x04001FFE RID: 8190
		[Token(Token = "0x4001FFE")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _automaticEndTimer;
	}
}
