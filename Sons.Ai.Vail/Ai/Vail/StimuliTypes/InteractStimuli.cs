using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	public abstract class InteractStimuli : MonoBehaviourStimuli, IVailActorInteract
	{
		// Token: 0x06000D45 RID: 3397 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x2BA2540", Offset = "0x2BA0B40", VA = "0x182BA2540")]
		private string GetCooldownString()
		{
			return null;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x2BA2650", Offset = "0x2BA0C50", VA = "0x182BA2650", Slot = "9")]
		internal override void OnEnable()
		{
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x2BA26C0", Offset = "0x2BA0CC0", VA = "0x182BA26C0")]
		private void ResetCooldown()
		{
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x2BA2730", Offset = "0x2BA0D30", VA = "0x182BA2730")]
		public void StartCooldown()
		{
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x2BA2790", Offset = "0x2BA0D90", VA = "0x182BA2790")]
		public void StartInterruptCooldown()
		{
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00007A58 File Offset: 0x00005C58
		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x2BA2800", Offset = "0x2BA0E00", VA = "0x182BA2800", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00007A70 File Offset: 0x00005C70
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x2BA28E0", Offset = "0x2BA0EE0", VA = "0x182BA28E0")]
		private bool IsInCooldown()
		{
			return default(bool);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x2BA2960", Offset = "0x2BA0F60", VA = "0x182BA2960")]
		private bool IsInvalidTarget()
		{
			return default(bool);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x2BA2980", Offset = "0x2BA0F80", VA = "0x182BA2980")]
		private bool IsValidTarget()
		{
			return default(bool);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x2BA2B20", Offset = "0x2BA1120", VA = "0x182BA2B20", Slot = "29")]
		public virtual void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x2BA2BD0", Offset = "0x2BA11D0", VA = "0x182BA2BD0", Slot = "30")]
		public virtual void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x2BA2CD0", Offset = "0x2BA12D0", VA = "0x182BA2CD0", Slot = "31")]
		public virtual void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x2BA2DA0", Offset = "0x2BA13A0", VA = "0x182BA2DA0", Slot = "32")]
		protected virtual bool ShouldInterruptAndEnd(Action interruptedCallback)
		{
			return default(bool);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x2B955D0", Offset = "0x2B93BD0", VA = "0x182B955D0")]
		protected InteractStimuli()
		{
		}

		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x40008A5")]
		[FieldOffset(Offset = "0xA8")]
		[FormerlySerializedAs("_treeCutting")]
		[SerializeField]
		protected MonoBehaviour _target;

		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x40008A6")]
		[FieldOffset(Offset = "0xB0")]
		[FormerlySerializedAs("_coolDown")]
		[SerializeField]
		private float _cooldown;

		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x40008A7")]
		[FieldOffset(Offset = "0xB4")]
		private float _lastInteract;
	}
}
