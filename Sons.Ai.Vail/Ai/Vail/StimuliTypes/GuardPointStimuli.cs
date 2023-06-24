using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	[AddComponentMenu("Sons/Stimuli/GuardPointStimuli")]
	public class GuardPointStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000D25 RID: 3365 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x2BA1B70", Offset = "0x2BA0170", VA = "0x182BA1B70")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x2BA1BA0", Offset = "0x2BA01A0", VA = "0x182BA1BA0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00007998 File Offset: 0x00005B98
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x2BA1C20", Offset = "0x2BA0220", VA = "0x182BA1C20", Slot = "12")]
		public override bool Validate(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public GuardPointStimuli()
		{
		}

		// Token: 0x040008A2 RID: 2210
		[Token(Token = "0x40008A2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private VailActorTypeId _actorType;
	}
}
