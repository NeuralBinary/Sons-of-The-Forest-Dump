using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay.ZipLines
{
	// Token: 0x0200081E RID: 2078
	[Token(Token = "0x200081E")]
	[AddComponentMenu("Sons/Gameplay/ZipLines/ActorZiplineInteraction")]
	public class ActorZiplineInteraction : MonoBehaviour, IVailActorInteract
	{
		// Token: 0x06003A7F RID: 14975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A7F")]
		[Address(RVA = "0x35719A0", Offset = "0x356FFA0", VA = "0x1835719A0", Slot = "4")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A80")]
		[Address(RVA = "0x3571D90", Offset = "0x3570390", VA = "0x183571D90", Slot = "6")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A81")]
		[Address(RVA = "0x3571E20", Offset = "0x3570420", VA = "0x183571E20")]
		private void OnDetached(ZipLineController.Hook hook)
		{
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A82")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A83")]
		[Address(RVA = "0x26C07A0", Offset = "0x26BEDA0", VA = "0x1826C07A0")]
		public ActorZiplineInteraction()
		{
		}

		// Token: 0x040031C9 RID: 12745
		[Token(Token = "0x40031C9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ZipLineController _zipLineController;

		// Token: 0x040031CA RID: 12746
		[Token(Token = "0x40031CA")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _direction;

		// Token: 0x040031CB RID: 12747
		[Token(Token = "0x40031CB")]
		[FieldOffset(Offset = "0x38")]
		private Action _completedCallback;

		// Token: 0x040031CC RID: 12748
		[Token(Token = "0x40031CC")]
		[FieldOffset(Offset = "0x40")]
		private Action _interruptedCallback;

		// Token: 0x040031CD RID: 12749
		[Token(Token = "0x40031CD")]
		[FieldOffset(Offset = "0x48")]
		private bool _attachedToHook;
	}
}
