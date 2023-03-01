using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Scene
{
	// Token: 0x0200052D RID: 1325
	[Token(Token = "0x200052D")]
	[Serializable]
	public class SceneSequenceStage
	{
		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x0000A038 File Offset: 0x00008238
		[Token(Token = "0x170004AB")]
		public bool IsCinematic
		{
			[Token(Token = "0x6002271")]
			[Address(RVA = "0x6B3E80", Offset = "0x6B2E80", VA = "0x1806B3E80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002272")]
		[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
		public string GetSceneName()
		{
			return null;
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x0000A050 File Offset: 0x00008250
		[Token(Token = "0x6002273")]
		[Address(RVA = "0x2D67A70", Offset = "0x2D66A70", VA = "0x182D67A70")]
		public double GetAutomaticEndTimer()
		{
			return default(double);
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002274")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public SceneSequenceStage()
		{
		}

		// Token: 0x04001F48 RID: 8008
		[Token(Token = "0x4001F48")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _scene;

		// Token: 0x04001F49 RID: 8009
		[Token(Token = "0x4001F49")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _cinematic;

		// Token: 0x04001F4A RID: 8010
		[Token(Token = "0x4001F4A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _automaticEndTimer;
	}
}
