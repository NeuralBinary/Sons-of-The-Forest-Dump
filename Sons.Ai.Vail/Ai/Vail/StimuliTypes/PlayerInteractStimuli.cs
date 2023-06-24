using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x0200015E RID: 350
	[Token(Token = "0x200015E")]
	public class PlayerInteractStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000B92 RID: 2962 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x2B94ED0", Offset = "0x2B934D0", VA = "0x182B94ED0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x2B94F00", Offset = "0x2B93500", VA = "0x182B94F00")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00007188 File Offset: 0x00005388
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x22F41B0", Offset = "0x22F27B0", VA = "0x1822F41B0")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x13428C0", Offset = "0x1340EC0", VA = "0x1813428C0")]
		public void SetInteractActor(VailActor actor)
		{
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000071A0 File Offset: 0x000053A0
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x2B94F80", Offset = "0x2B93580", VA = "0x182B94F80", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public PlayerInteractStimuli()
		{
		}

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[FieldOffset(Offset = "0xA8")]
		private VailActor _actor;
	}
}
