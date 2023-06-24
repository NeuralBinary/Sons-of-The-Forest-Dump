using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.Inventory;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	public abstract class PickupStimuli : InteractStimuli
	{
		// Token: 0x06000D73 RID: 3443 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D73")]
		[Address(RVA = "0x2BA4310", Offset = "0x2BA2910", VA = "0x182BA4310")]
		public VailPickup GetPickupTarget()
		{
			return null;
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00007B78 File Offset: 0x00005D78
		[Token(Token = "0x6000D74")]
		[Address(RVA = "0x2BA43A0", Offset = "0x2BA29A0", VA = "0x182BA43A0", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D75")]
		[Address(RVA = "0x2BA4490", Offset = "0x2BA2A90", VA = "0x182BA4490", Slot = "29")]
		public override void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x2BA4610", Offset = "0x2BA2C10", VA = "0x182BA4610", Slot = "30")]
		public override void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D77")]
		[Address(RVA = "0x2B955D0", Offset = "0x2B93BD0", VA = "0x182B955D0")]
		protected PickupStimuli()
		{
		}
	}
}
