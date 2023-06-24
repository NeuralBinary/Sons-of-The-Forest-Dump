using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	[Serializable]
	public class WorldHold : WorldSimAction
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x17000099")]
		protected override bool ShowStimuli
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x2B876B0", Offset = "0x2B85CB0", VA = "0x182B876B0", Slot = "4")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00006750 File Offset: 0x00004950
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x2B876D0", Offset = "0x2B85CD0", VA = "0x182B876D0", Slot = "9")]
		public override bool IsValid(VailWorldSimulation worldSim, WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x2B87870", Offset = "0x2B85E70", VA = "0x182B87870", Slot = "11")]
		public override void OnConvertToVailActor(WorldSimActor worldActor, VailActor vailActor)
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x2B87B40", Offset = "0x2B86140", VA = "0x182B87B40")]
		public WorldHold()
		{
		}

		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _snapToStimuli;

		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string _snapStimuliType;
	}
}
