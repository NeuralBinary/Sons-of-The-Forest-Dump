using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001BF RID: 447
	[Token(Token = "0x20001BF")]
	[AddComponentMenu("Sons/Stimuli/Landing Spot Extended Stimuli")]
	public class LandingSpotInteractStimuli : MonoBehaviourStimuli, IVailActorInteract
	{
		// Token: 0x06000D5A RID: 3418 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x2BA3020", Offset = "0x2BA1620", VA = "0x182BA3020")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x2BA3050", Offset = "0x2BA1650", VA = "0x182BA3050")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[Token(Token = "0x6000D5C")]
		[Address(RVA = "0x22F41B0", Offset = "0x22F27B0", VA = "0x1822F41B0")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5D")]
		[Address(RVA = "0x2BA30F0", Offset = "0x2BA16F0", VA = "0x182BA30F0", Slot = "26")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public LandingSpotInteractStimuli()
		{
		}

		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x40008A8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int ElectrocutedHash;

		// Token: 0x040008A9 RID: 2217
		[Token(Token = "0x40008A9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _electrocute;
	}
}
