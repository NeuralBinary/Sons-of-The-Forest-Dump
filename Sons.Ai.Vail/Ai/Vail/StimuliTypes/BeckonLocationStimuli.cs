using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	public class BeckonLocationStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000BAA RID: 2986 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x2B955F0", Offset = "0x2B93BF0", VA = "0x182B955F0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x2B95620", Offset = "0x2B93C20", VA = "0x182B95620")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000071B8 File Offset: 0x000053B8
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x2B956A0", Offset = "0x2B93CA0", VA = "0x182B956A0", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x2B956C0", Offset = "0x2B93CC0", VA = "0x182B956C0", Slot = "14")]
		public override void OnActorReachedStimuli(WorldSimActor worldActor, VailActor actor)
		{
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public BeckonLocationStimuli()
		{
		}

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0xA8")]
		private bool _wasUsed;
	}
}
