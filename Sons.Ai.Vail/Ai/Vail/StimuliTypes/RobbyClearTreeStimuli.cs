using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x20001D9")]
	public class RobbyClearTreeStimuli : RobbyOrderStimuliBase
	{
		// Token: 0x06000DEC RID: 3564 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x2BA82E0", Offset = "0x2BA68E0", VA = "0x182BA82E0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x2BA8310", Offset = "0x2BA6910", VA = "0x182BA8310")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x22F41B0", Offset = "0x22F27B0", VA = "0x1822F41B0")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x2BA7EF0", Offset = "0x2BA64F0", VA = "0x182BA7EF0", Slot = "26")]
		public override void Initialize(VailActor ownerActor)
		{
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x2BA8390", Offset = "0x2BA6990", VA = "0x182BA8390", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00007E78 File Offset: 0x00006078
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x2BA8B80", Offset = "0x2BA7180", VA = "0x182BA8B80", Slot = "18")]
		public override Vector3 GetLookAtPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public RobbyClearTreeStimuli()
		{
		}

		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		[FieldOffset(Offset = "0xB0")]
		private int _hits;

		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		private const int HitsToFellTree = 8;
	}
}
