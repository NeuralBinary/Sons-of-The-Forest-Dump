using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	public abstract class BirdStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000BC7 RID: 3015 RVA: 0x00007260 File Offset: 0x00005460
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0xB51A40", Offset = "0xB50040", VA = "0x180B51A40")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x2B95DD0", Offset = "0x2B943D0", VA = "0x182B95DD0", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		protected BirdStimuli()
		{
		}
	}
}
