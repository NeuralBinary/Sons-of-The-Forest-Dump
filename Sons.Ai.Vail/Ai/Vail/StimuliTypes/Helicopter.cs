using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	public class Helicopter : MonoBehaviourStimuli
	{
		// Token: 0x06000D2E RID: 3374 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x2BA1D30", Offset = "0x2BA0330", VA = "0x182BA1D30")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x2BA1D60", Offset = "0x2BA0360", VA = "0x182BA1D60")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x000079E0 File Offset: 0x00005BE0
		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x2BA1DE0", Offset = "0x2BA03E0", VA = "0x182BA1DE0", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public Helicopter()
		{
		}

		// Token: 0x040008A3 RID: 2211
		[Token(Token = "0x40008A3")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _hideObject;
	}
}
