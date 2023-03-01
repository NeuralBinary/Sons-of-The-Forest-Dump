using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay.ZipLines
{
	// Token: 0x020006D2 RID: 1746
	[Token(Token = "0x20006D2")]
	[AddComponentMenu("Sons/Gameplay/ZipLines/ActorZiplineInteraction")]
	public class ActorZiplineInteraction : MonoBehaviour, IVailActorInteract
	{
		// Token: 0x06002C9C RID: 11420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C9C")]
		[Address(RVA = "0x2DE1400", Offset = "0x2DE0400", VA = "0x182DE1400", Slot = "4")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C9D")]
		[Address(RVA = "0x2DE1760", Offset = "0x2DE0760", VA = "0x182DE1760", Slot = "6")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C9E")]
		[Address(RVA = "0x2DE17C0", Offset = "0x2DE07C0", VA = "0x182DE17C0")]
		private void OnDetached(ZipLineController.Hook hook)
		{
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C9F")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "5")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA0")]
		[Address(RVA = "0x2279260", Offset = "0x2278260", VA = "0x182279260")]
		public ActorZiplineInteraction()
		{
		}

		// Token: 0x040027EB RID: 10219
		[Token(Token = "0x40027EB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ZipLineController _zipLineController;

		// Token: 0x040027EC RID: 10220
		[Token(Token = "0x40027EC")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _direction;

		// Token: 0x040027ED RID: 10221
		[Token(Token = "0x40027ED")]
		[FieldOffset(Offset = "0x38")]
		private Action _completedCallback;

		// Token: 0x040027EE RID: 10222
		[Token(Token = "0x40027EE")]
		[FieldOffset(Offset = "0x40")]
		private Action _interruptedCallback;

		// Token: 0x040027EF RID: 10223
		[Token(Token = "0x40027EF")]
		[FieldOffset(Offset = "0x48")]
		private bool _attachedToHook;
	}
}
