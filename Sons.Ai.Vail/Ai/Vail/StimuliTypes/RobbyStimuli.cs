using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	[AddComponentMenu("Sons/Stimuli/Robby Stimuli")]
	public class RobbyStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000BFA RID: 3066 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x2B974C0", Offset = "0x2B95AC0", VA = "0x182B974C0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00007308 File Offset: 0x00005508
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x15FFA90", Offset = "0x15FE090", VA = "0x1815FFA90")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00007320 File Offset: 0x00005520
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x2B974F0", Offset = "0x2B95AF0", VA = "0x182B974F0", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public RobbyStimuli()
		{
		}
	}
}
