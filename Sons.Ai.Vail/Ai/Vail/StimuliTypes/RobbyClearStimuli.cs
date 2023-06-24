using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	public class RobbyClearStimuli : RobbyOrderStimuliBase
	{
		// Token: 0x06000DE6 RID: 3558 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x2BA7E40", Offset = "0x2BA6440", VA = "0x182BA7E40")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x2BA7E70", Offset = "0x2BA6470", VA = "0x182BA7E70")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x22F41B0", Offset = "0x22F27B0", VA = "0x1822F41B0")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x2BA7EF0", Offset = "0x2BA64F0", VA = "0x182BA7EF0", Slot = "26")]
		public override void Initialize(VailActor ownerActor)
		{
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x2BA7F50", Offset = "0x2BA6550", VA = "0x182BA7F50", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public RobbyClearStimuli()
		{
		}

		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		[FieldOffset(Offset = "0xB0")]
		private int _hits;
	}
}
