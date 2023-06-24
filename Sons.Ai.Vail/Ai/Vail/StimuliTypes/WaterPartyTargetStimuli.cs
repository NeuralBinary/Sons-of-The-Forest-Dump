using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001F2 RID: 498
	[Token(Token = "0x20001F2")]
	[AddComponentMenu("Sons/Stimuli/WaterPartyTargetStimuli")]
	public class WaterPartyTargetStimuli : SearchPartyStimuli
	{
		// Token: 0x06000E85 RID: 3717 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x2BAE910", Offset = "0x2BACF10", VA = "0x182BAE910")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x2BAE940", Offset = "0x2BACF40", VA = "0x182BAE940")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000082E0 File Offset: 0x000064E0
		[Token(Token = "0x6000E87")]
		[Address(RVA = "0xE51980", Offset = "0xE4FF80", VA = "0x180E51980")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x2BAE910", Offset = "0x2BACF10", VA = "0x182BAE910", Slot = "26")]
		public override string GetDebugName()
		{
			return null;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x2BAE9C0", Offset = "0x2BACFC0", VA = "0x182BAE9C0", Slot = "13")]
		public override bool Validate(WorldSimActor worldActor)
		{
			return default(bool);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x2BAEA20", Offset = "0x2BAD020", VA = "0x182BAEA20", Slot = "14")]
		public override void OnActorReachedStimuli(WorldSimActor worldActor, VailActor actor)
		{
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public WaterPartyTargetStimuli()
		{
		}
	}
}
