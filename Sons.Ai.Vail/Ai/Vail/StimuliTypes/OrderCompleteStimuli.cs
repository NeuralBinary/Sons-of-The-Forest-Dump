using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	[AddComponentMenu("Sons/Stimuli/Order Complete Stimuli")]
	public class OrderCompleteStimuli : RobbyOrderStimuliBase
	{
		// Token: 0x06000DE1 RID: 3553 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x2BA7C70", Offset = "0x2BA6270", VA = "0x182BA7C70")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x2BA7CA0", Offset = "0x2BA62A0", VA = "0x182BA7CA0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00007E30 File Offset: 0x00006030
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x22F41B0", Offset = "0x22F27B0", VA = "0x1822F41B0")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x2BA7D20", Offset = "0x2BA6320", VA = "0x182BA7D20", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public OrderCompleteStimuli()
		{
		}
	}
}
